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

require ../num/z.fs
false constant q-coverage

q-coverage [if] 
include ../../gforth/coverage.fs 
include ../num/q.fs
[else]
require ../num/q.fs
[then]

variable q1  q 1/2 q1 q!

\ #region Accessors
tests accessors
t( q 23/45 dup qn@ z 23 z= swap qdrop ) 
t( q 11/17 dup qd@ z 17 z= swap qdrop )
t( qnew dup z 24 qn! dup z 13 qd! q 24/13 q= )
t( q0 dup z 11 qni! dup z 15 qdi! q 11/15 q= )
totals
\ #endregion

\ #region initialize and free

tests initialize and free
t( qnew dup _q%-num z0 swap ! dup _q%-den z 1 swap !  qfree true )
t( qnew qinit q 0/1 q= )
t( q0 qdrop true )
t( q0 qdup qdrop q0 q= )
t( q 1/2 qdup qdrop q 1/2 q= )
t( q 15/30 qred q 1/2 q= )
totals
\ #endregion

\ #region Conversion

tests conversion
t( z 2 z 6 zz>q q 1/3 q= )
t( z 7 z>q q 7/1 q= )
t( q 8/2 q>z z 4 z= )
t( q 4/3 q>z z 1 z= )
totals

\ #endregion

\ #region Printing
tests printing
t( ." you should see 1/7: " q 1/7 {q.} cr qdrop true )
t( ." you should see 1/8: " q 1/8 q. cr true )
totals
\ #endregion

\ #region Comparison
tests comparison
t( q 1/2 q 1/3 qcmp 1 = )
t( q 1/3 q 1/2 qcmp -1 = )
t( q 1/3 q 1/3 qcmp 0= )
t( q 1/7 q 1/7 q= )
t( q 1/7 q 1/3 q<> )
t( q 1/3 q 1/8 q> )
t( q 1/3 q 1/8 q>= )
t( q 1/16 q 1/8 q< )
t( q 1/16 q 1/8 q<= )
totals
\ #endregion



\ #region Arithmetic tests
tests Aritmetic tests
t( q 1/2 qneg q -1/2 q= )
t( q 1/5 qabs q 1/5 q= )
t( q -1/5 qabs q 1/5 q= )
t( q 1/9 qinv q 9/1 q= )
t( q 1/3 q1 q! true )
t( q 1/2 q1 q! true )
t( q1 q@ q 1/3 q+ q 5/6 q= )
t( q 1/2 q1 q! true )
t( q1 q@ q1 q@ q* q 1/4 q= ) 
t( q1 q@ q 1/2 q+ q 1/1 q= )
t( q 1/2 q 1/3 q+ q 5/6 q= )
t( q 1/2 q 1/2 q- q0 q= )
t( q 1/2 q 2/1 q/ q 1/4 q= )
t( q1 qv-free true )
t( q1 qv-free true )
totals
\ #endregion

z-mem-stats
q-mem-stats
q-coverage [if] cr cov% [then]
cr

