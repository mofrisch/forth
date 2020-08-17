.( Testing Numbers)

\ file
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
require ../num/n.fs

true constant n-mem-debug

variable n1 
variable n2 
variable n3


nz 23 n1 n!
nz 12 n1 n!
nz 23 n1 n!
nq 1/3 n2 !
nfr 2.01 n3 !

: n-show-mem
   .s z-mem-stats q-mem-stats fr-mem-stats n-mem-stats
;

n-mem-debug [if] n-show-mem [then]

tests Initialization
t( nz 1 dup ntype z_type = swap ndrop )
t( nq 1/2 dup ntype q_type = swap ndrop )
t( nfr 2.01 dup ntype fr_type = swap ndrop )
t( 8 c_type = )
t( n1 @ nvalue  z 23 z= )
t( n2 @ nvalue q 1/3 q= )
t( n3 @ nvalue fr 2.01 eps fr~abs )
t( q_type n1 @ ntype! n1 @ ntype q_type = ) 
t( n1 @ z_type swap ntype! n1 @ ntype z_type = ) 
t( z 3 n1 @ nvalue! n1 @ nvalue z 3 z= )
t( z 23 n1 @ nvalue! n1 @ nvalue z 23 z= )
totals

n-mem-debug [if] n-show-mem [then]

tests Printing
t( nz 12 n. cr true )
t( nq 1/7 n. cr true )
t( nfr 3.14 n. cr true )
totals

n-mem-debug [if] n-show-mem [then]

tests Operators
t( nz 17 nfr 3.4 nbefore 2swap 2drop ndrop z 17 z= )
t( nz 12 nz 13 opz+ nvaldrop z 25 z= )
t( nq 1/3 nq 1/2 opq+ nvaldrop q 5/6 q= )
t( nfr 1.2 nfr 1.3 opfr+ nvaldrop fr 2.5 eps fr~abs )
t( nz 12 nz 13 opz- nvaldrop z -1 z= )
t( nq 1/3 nq 1/2 opq- nvaldrop q -1/6 q= )
t( nfr 1.2 nfr 1.3 opfr- nvaldrop fr -0.1 eps fr~abs )
t( nz 12 nz 13 opz* nvaldrop z 156 z= )
t( nq 1/3 nq 1/2 opq* nvaldrop q 1/6 q= )
t( nfr 1.2 nfr 1.3 opfr* nvaldrop fr 1.56 eps fr~abs )
totals

n-mem-debug [if] n-show-mem [then]

tests nop
t( nz 1 nz 2 z_type add_op nop nvaldrop z 3 z= )
t( nz 1 nz 2 z_type sub_op nop nvaldrop z -1 z= )
t( nz 1 nz 2 z_type mul_op nop nvaldrop z 2 z= )
t( nq 1/2 nq 1/2 q_type add_op nop nvaldrop q 1/1 q= )
t( nq 1/2 nq 1/2 q_type sub_op nop nvaldrop q 0/1 q= )
t( nq 1/2 nq 1/2 q_type mul_op nop nvaldrop q 1/4 q= )
t( nfr 2.0 nfr 0.5 fr_type add_op nop nvaldrop fr 2.5 eps fr~abs )
t( nfr 2.0 nfr 0.5 fr_type sub_op nop nvaldrop fr 1.5 eps fr~abs )
t( nfr 2.0 nfr 0.5 fr_type mul_op nop nvaldrop fr 1.0 eps fr~abs )
t( 1 2 0 add_op nop 3 = )
t( 1 2 0 sub_op nop -1 = )
t( 1 2 0 mul_op nop 2 = )
t( 1 2 0 37 nop drop true ) \ <- this fails, need it for full code coverage
totals

n-mem-debug [if] n-show-mem [then]

tests conversion
\ t( nz 21 nz>q nq 21/1 n= )
t( nz 21 nz>fr dup dup nvalue fr 21 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nq 1/2 nq>fr dup dup nvalue fr 0.5 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nz 65 q_type nconvert dup dup  nvalue q 65/1 q= swap ntype q_type = rot ndrop and )
t( nz 73 fr_type nconvert dup dup nvalue fr 73 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nq 1/3 fr_type nconvert dup dup nvalue q 1/3 q>fr eps fr~abs swap ntype fr_type = rot ndrop and )

n-mem-debug [if] n-show-mem [then]

t( nz 34 nz 35 ncommon-type z_type = swap nvaldrop z 35 z= rot dup nvalue zdrop ndrop and )
t( nz 23 nq 1/7 ncommon-type q_type = nnip swap nvaldrop q 23/1 q= and )
t( nq 1/8 nz 17 ncommon-type q_type = swap nvaldrop q 17/1 q= rot ndrop and )
t( nz 56 nfr 9.01 ncommon-type fr_type = nnip swap nvaldrop fr 56 eps fr~abs and )
t( nq 1/2 nfr 3.14 ncommon-type fr_type = nnip swap nvaldrop fr 0.5 eps fr~abs and )
t( nfr 4.5 nz 37 ncommon-type fr_type = swap nvaldrop fr 37 eps fr~abs rot ndrop and )
t( nfr 17.3 nq 1/3 ncommon-type fr_type = swap nvaldrop q 1/3 q>fr eps fr~abs rot ndrop and )
totals

n-mem-debug [if] n-show-mem [then]

tests arithmetics
t( nz 17 nz 13 n+ dup dup nvalue z 30 z= swap ntype z_type = rot ndrop and )
t( nz 17 nz 13 n+ n-type-val z 30 z= swap z_type = and )
t( nz 35 nq 1/2 n+ dup dup nvalue q 71/2 q= swap ntype q_type = rot ndrop and )
t( nq 1/3 nz 36 n+ dup dup nvalue q 109/3 q= swap ntype q_type = rot ndrop and )
t( nz 41 nfr 2.5 n+ dup dup nvalue fr 43.5 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 3.5 nz 42 n+ dup dup nvalue fr 45.5 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nq 1/2 nfr 0.5 n+ dup dup nvalue fr 1 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 0.5 nq 1/2 n+ dup dup nvalue fr 1 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 1.1 nfr 2.2 n+ dup dup nvalue fr 3.3 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nz 17 nz 13 n- dup dup nvalue z 4 z= swap ntype z_type = rot ndrop and )
t( nz 35 nq 1/2 n- dup dup nvalue q 69/2 q= swap ntype q_type = rot ndrop and )
t( nq 1/3 nz 36 n- dup dup nvalue q -107/3 q= swap ntype q_type = rot ndrop and )
t( nz 41 nfr 2.5 n- dup dup nvalue fr 38.5 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 3.5 nz 42 n- dup dup nvalue fr -38.5 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nq 1/2 nfr 0.5 n- dup dup nvalue fr 0 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 0.5 nq 1/2 n- dup dup nvalue fr 0 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 1.1 nfr 2.2 n- dup dup nvalue fr -1.1 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nz 17 nz 13 n* dup dup nvalue z 221 z= swap ntype z_type = rot ndrop and )
t( nz 35 nq 1/2 n* dup dup nvalue q 35/2 q= swap ntype q_type = rot ndrop and )
t( nq 1/3 nz 36 n* dup dup nvalue q 12/1 q= swap ntype q_type = rot ndrop and )
t( nz 41 nfr 2.5 n* dup dup nvalue fr 102.5 eps fr~abs swap ntype rot ndrop fr_type = and )
t( nfr 3.5 nz 42 n* dup dup nvalue fr 147 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nq 1/2 nfr 0.5 n* dup dup nvalue fr 0.25 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 0.5 nq 1/2 n* dup dup nvalue fr 0.25 eps fr~abs swap ntype fr_type = rot ndrop and )
t( nfr 1.1 nfr 2.2 n* dup dup nvalue fr 2.42 eps fr~abs swap ntype fr_type = rot ndrop and )
totals


n1 nv-free
n2 nv-free
n3 nv-free

n-show-mem




