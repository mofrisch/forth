.( Run all Tests) 

\ test/all-tests.fs
\ Run tests for z.fs and q.fs

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

true constant run-all-tests
true constant all-coverage 

all-coverage [if] 
include ../../gforth/coverage.fs 
include ../num/z.fs
include ../num/q.fs
include ../num/fr.fs
include ../num/n.fs
[then]

require z-test.fs
require q-test.fs
require fr-test.fs
require n-test.fs 


z-mem-stats
q-mem-stats
fr-mem-stats
all-coverage [if] cr cov% [then]
grand-totals