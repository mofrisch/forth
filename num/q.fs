.( Rationals library)

\ _q%-num/q.fs
\ Rationals of arbitrary size implemented in Forth

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

\* require intro.fs
require z.fs *\

-1 to z-total-inits    0 to z-print-inits

variable q-debug-mem  -1 q-debug-mem !
variable q-news       0 q-news !
variable q-frees      0 q-frees !

begin-structure _q%
	drop 0 8 +field _q%-num
	drop 8 8 +field _q%-den
drop 24 end-structure

\ Accessors -- use qni! and qdi! for initialized variables to avoid a memory
\ leak
: qn@ ( q -- z )   
   _q%-num z@ ;

: qn! ( q z -- )   
   swap _q%-num ! ;

: qni! ( q z -- )   
   swap _q%-num z! ;

: qd@ ( q -- z )   
   _q%-den z@ ;

: qd! ( q z -- )   
   swap _q%-den ! ;

: qdi! ( q z -- ) 
   swap _q%-den z! ;

\ Initialize and free
: qnew ( -- q )   
   q-debug-mem if q-news ++ then
   _q% allocate throw ;

: qinit ( q -- )   
   dup z0 qn!  dup 1 u>z qd! ;

: qfree ( q -- )   
   q-debug-mem if q-frees ++ then
   dup _q%-num @ zdrop   dup _q%-den @ zdrop   free throw ;

: qdrop ( q -- )   
   qfree ;

: qdup { q1 -- q1 q1 }   
   qnew dup   dup q1 qn@ qn!   dup q1 qd@ qd! ;

: qv-free ( var -- )
   dup dup @ 0<> if @ qdrop then 0 swap ! ;

: q0 ( -- q )   
   qnew dup qinit ;

: qred { q1 -- q2 }   
   q1 qn@ q1 qd@ zgcd zdup   q1 qn@ swap z/ q1 swap qni!   
   q1 qd@ swap z/ q1 swap qdi!   q1 ;

: q ( "z/z" -- q )   
   qnew dup   '/' parse (z) qn!   dup bl parse (z) qd!   qred ;

: q! ( q var -- )
   dup @ 0<> if dup @ qdrop then ! ;

: q@ ( var -- q )
   @ qdup nip ;

\ Conversion
: zz>q { z1 z2 -- q }   
   qnew   dup z1 qn!   dup z2 qd!   qred ;

: z>q { z1 -- q=z/1 }   
   qnew   dup z1 qn!   dup 1 u>z qd! ;

: q>z ( q -- z )   
   dup qn@ swap qd@ z/ ;



\ Printing
: (q.) ( q -- q )   
   dup qn@ (z.) zdrop '/' emit dup qd@ (z.) zdrop ;

: q. ( q -- )   
   (q.) bl emit qdrop ;
\ : q.s ( -- )   
\   ." <" depth 0 .r ." > "
\   depth maxdepth-.s @ > if ." ... " then
\   depth 0 max maxdepth-.s @ min dup 0 ?do   
\      dup i - pick
\      dup q-is if (q.) drop else z-is if z(z.) drop else . drop then then 
\   loop ;
\ ' q.s is ..s

\ Comparison
: qcmp { q1 q2 -- -1|0|1 } \ -1: q1<q2 0: q1=q2 1: q1>q2
   q1 qn@ q2 qd@ z*   q1 qd@ q2 qn@ z*   zcmp 
   q1 qdrop q2 qdrop ;

: q=  ( q1 q2 -- ? )   
   qcmp 0= ;

: q<> ( q1 q2 -- ? )   
   qcmp 0<> ;

: q>  ( q1 q2 -- ? )   
   qcmp 0>  ;

: q>= ( q1 q2 -- ? )   
   qcmp 0>= ;

: q<  ( q1 q2 -- ? )   
   qcmp 0< ;

: q<= ( q1 q2 -- ? )   
   qcmp 0<= ;

\ Arithmetics
: qneg ( q -- q )   
   dup dup qn@ zneg qni! ;

: qabs ( q -- q )   
   dup dup qn@ zabs qni! ;

: qinv { q1 -- 1/q1 } 
   qnew dup  q1 qn@ qd!   dup q1 qd@ qn!   q1 qdrop ;

: q+ { q1 q2 -- q1+q2 } \ ( q1n * q2d + q1d * q2n ) / ( q1d * q2d )
   qnew dup   q1 qn@ q2 qd@ z*   q1 qd@ q2 qn@ z*   z+   qn!
   dup   q1 qd@ q2 qd@ z*   qd!   qred 
   q1 qdrop   q2 qdrop ;

: q- ( q1 q2 -- q1-q2 )   
   qneg q+ qred ;

: q* { q1 q2 -- q1*q2 } \ ( q1n * q2n ) / ( q1d * q2d )
   qnew dup   q1 qn@ q2 qn@ z*   qn!   dup   q1 qd@ q2 qd@ z*   qd!   qred   
   q1 qdrop   q2 qdrop ;

: q/ ( q1 q2 -- q1/q2 )   
   qinv q* qred ;

: q-mem-stats ( -- )
   cr ." news: " q-news @ .   
   cr ." frees: " q-frees @ . ;


