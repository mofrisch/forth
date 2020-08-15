.( Test rationals)

\ test/q-test.fs
\ Test rational numbers.

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

require ../num/q.fs

variable q1  q 1/2 q1 q!

\ #region Arithmetic tests
tests Aritmetic tests
t( q 1/3 q1 q! true )
t( q1 q@ q 1/3 q+ q 2/3 q= )
t( q 1/2 q1 q! true )
t( q1 q@ q1 q@ q* q 1/4 q= ) 
t( q1 q@ q 1/2 q+ q 1/1 q= )
t( q 1/2 q 1/3 q+ q 5/6 q= )
t( q1 qv-free true )
t( q1 qv-free true )
totals
\ #endregion




z-mem-stats
q-mem-stats

