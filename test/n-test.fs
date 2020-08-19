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

false constant n-mem-debug
true constant n-coverage

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



tests Initialization
t( fr 1e-19 eps! true )
t( eps fr. cr true )
t( z 1 ntype z-type = )
t( z 1 {n.} cr true )

totals

n-mem-debug [if] n-show-mem [then]

epsilon frv-free
n-show-mem
n-coverage [if] cr cov% [then]
