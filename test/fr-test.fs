.( Test Floating Point)

\ test/fr-test.fs
\ test cases for fr (long floating numbers)

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ #region License
\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http: //www.gnu.org/licenses/.
\ #endregion

require ../num/z.fs
require ../num/q.fs

start-coverage [if] fr-mem-reset [then]

true constant fr-coverage

fr-coverage [if] 
include ../../gforth/coverage.fs 
include ../num/fr.fs
fr-mem-reset
[else]
require ../num/fr.fs
[then]

variable epsilon 
: eps ( -- fr )
   epsilon fr@ ;

: eps! ( fr -- )
    epsilon fr! ;

fr 1e-19 eps!
variable fr_1   fr 1 fr_1 fr!
variable fr_2   fr 2 fr_2 fr!


tests initialization
t( fr_1 fr@ fr_2 fr@ fr+ fr 3 eps fr~abs )
t( fr_1 fr@ fr_2 fr@ fr+ fr 3 fr= ) \ <- do not rely on this...
t( fr0 fr0 fr= )
t( fr0 frdup frdrop fr0 fr= )
t( z 2 z>fr fr 2 eps fr~abs )
t( 2 u>fr fr 2 fr= )
t( -2 s>fr fr. cr true )
totals



tests auxiliary
t( 1000 frdig fr-decimal-digits 301 = )
t( 200 frdig fr-decimal-digits 60 = )
t( fr 1.5 frdup fr 1.5 eps fr~abs swap fr 1.5 eps fr~abs and )
t( fr 2.3 fr 3.1 fr2dup 2swap frdrop frdrop fr 3.1 eps fr~abs swap fr 2.3 eps fr~abs and )
totals


tests comparison
t( fr_1 fr@ fr_2 fr@ frcmp -1 = )
t( fr_1 fr@ fr_1 fr@ frcmp 0= )
t( fr_2 fr@ fr_1 fr@ frcmp 1 = )
t( fr_1 fr@ fr_1 fr@ fr= )
t( fr_1 fr@ fr_2 fr@ fr<> )
t( fr_1 fr@ fr_2 fr@ fr< )
t( fr_1 fr@ fr_2 fr@ fr<= )
t( fr_2 fr@ fr_1 fr@ fr> )
t( fr_2 fr@ fr_1 fr@ fr>= )
totals

tests creation
t( 2 u>fr fr 2 fr= )
t( -2 s>fr fr -2 fr= )
t( "-2.4e-03" {fr} fr -2.4e-3 fr= )
t( fr -3.14e-2 "-3.14e-02" {fr} fr= )
t( eps fr 1e-19 fr= )
totals


tests arithmetics
t( fr 2.3 frunary fr-round = nip nip swap frdrop )
t( fr 1.1 fr 4.5 frbin fr-round = nip nip nip swap fr 1.1 fr= and swap fr 4.5 fr= and )
t( fr 1.2 fr 4.8 0 frafter fr 4.8 fr= )
t( fr 7.8 fr 2.2 fr+ fr 10 fr= )
t( fr 7.8 fr 2.2 fr- fr 5.6 eps fr~abs )
t( fr 7.8 fr 2 fr* fr 15.6 fr= )
t( fr 7.8 fr 2 fr/ fr 3.9 eps fr~abs )
t( fr -7.8 frabs fr 7.8 fr= )
totals

z-mem-stats
tests utility
t( q 1/2 q>fr fr 0.5 fr= )
z-mem-stats
t( ." you should see 3.300...0e-1: " fr 0.33 {fr.} cr frdrop true )
t( ." you should see 3.300...0e-1: " fr 0.33 fr. cr true )
t( ." you should see 3.30000e-1: " fr 0.33 6 #fr. cr true )

t( fr 0 frsin fr 0 fr= )
t( fr 2 10 frupow fr 1024 fr= )
t( fr 0 fr 0.001 fr 0.001 fr~abs )
t( fr 0 fr 0.001 fr 0.000999 fr~abs invert )
t( fr 0 fr 0.001 fr 1. fr~rel )
t( fr 0 fr 0.001 fr 0.99999 fr~rel invert )
totals 



fr_1 frv-free
fr_2 frv-free
epsilon frv-free


z-mem-stats
q-mem-stats
fr-mem-stats
fr-coverage [if] cr cov% [then]
cr