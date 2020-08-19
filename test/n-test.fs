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

fr 1e-19 eps!

variable n1 
variable n2 
variable n3

nz 23 n1 n!
nq 1/3 n2 n!
nfr 2.01 n3 n!

tests basic tests
t( nz 1 dup ntype swap ndrop z-type = )
totals
n-show-mem

\ nz 2 n1 n!
\ n1 n@ n.
\ n1 @ ndup n.
\ nz 1 n1 n!
\ n-show-mem

tests Initialization
t( nz 1 dup ntype z-type = swap ndrop )
t( nq 1/2 dup ntype q-type = swap ndrop )
t( nfr 2.01 dup ntype fr-type = swap ndrop )
t( 3 c-type = )
t( n1 @ nvalue zdup z 23 z= )
t( n2 @ nvalue q 1/3 q= )
t( n3 @ nvalue fr 2.01 eps fr~abs )
t( q-type n1 @ ntype! n1 @ ntype q-type = ) 
t( n1 @ z-type swap ntype! n1 @ ntype z-type = ) 
t( z 3 n1 @ nvalue! n1 @ nvalue z 3 z= )
t( z 23 n1 @ nvalue! n1 @ nvalue z 23 z= )
totals

n-mem-debug [if] n-show-mem [then]

tests common tests
t( nz 1 n. cr true )
t( nq 1/2 n. cr true )
t( nfr .5 n. cr true ) n-show-mem
t( nz 1 nz 2 n+ nvalue z 3 z= )
totals
\ n1 nv-free

n-show-mem
n-coverage [if] cr cov% [then]
