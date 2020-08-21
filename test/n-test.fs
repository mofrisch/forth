.( Testing Numbers)

\ test/n-test.fs
\ description

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

require ../num/intro.fs
require ../num/z.fs
require ../num/q.fs
require ../num/fr.fs

true constant n-mem-debug
false constant n-coverage
[ifundef] run-all-tests false constant run-all-tests [then]

n-coverage [if] 
include ../../gforth/coverage.fs 
include ../num/n.fs
[else]
require ../num/n.fs
[then]

variable epsilon 

: eps ( -- fr )
   epsilon fr@ ;

: eps! ( fr -- )
    epsilon fr! ;



variable n1 
variable n2 
variable n3

\ false  z-print-inits !
print-summary
\ print-detail
cr 80 draw-seperator


tests Initialization
t( 1 fr? nip invert )
t( z 3 fr? znip invert )
t( q 1/3 fr? qnip invert )
t( fr 5.1 fr? frnip )
t( 1 q? nip invert )
t( z 3 q? znip invert )
t( q 1/3 q? qnip ) 
t( fr 5.1 q? frnip invert )
t( 1 z? nip invert )
t( z 3 z? znip )
t( q 1/3 z? qnip invert )
t( fr 5.1 z? frnip invert )
t( fr 1e-19 eps! true )
t( eps fr. cr true )
t( 1 ntype nip other-type = )
t( z 1 ntype znip z-type = )
t( q 7/5 ntype qnip q-type = )
t( fr 9.3 ntype frnip fr-type = )
totals

tests printing
t( 1 {n.} cr true )
t( z 1 {n.} zdrop cr true )
t( q 3/27 {n.} qdrop cr true )
t( fr 3.141 {n.} frdrop cr true )
t( 1 n. cr true )
t( z 1 n. cr true )
t( q 3/27 n. cr true )
t( fr 3.141 n. cr true )
totals

tests deletion
t( epsilon frv-free true )
totals


run-all-tests invert [if]
n-mem-debug [if] n-show-mem [then]
n-coverage [if] cr cov% [then]
grand-totals
[then]
