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

require intro.fs
require z.fs 

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

: qdup ( q1 -- q1 q1 )  
   qnew  2dup 2dup swap qn@  qn! swap qd@ qd! ;

: qnip ( q1 q2 -- q2 )
   swap qdrop ;

: qv-free ( var -- )
   dup dup @ 0<> if @ qdrop then 0 swap ! ;

: q0 ( -- q )   
   qnew qinit ;

: qred { q1tmp -- q2 }   
   q1tmp qn@ q1tmp qd@ zgcd zdup   q1tmp qn@ swap z/ q1tmp swap qni!   
   q1tmp qd@ swap z/ q1tmp swap qdi!   q1tmp ;

: q ( "z/z" -- q )   
   qnew dup   '/' parse {z} qn!   dup bl parse {z} qd!   qred ;

: q! ( q var -- )
   dup @ dup 0<> if qdrop else drop then ! ;

: q@ ( var -- q )
   @ qdup nip ;

: q? ( num -- ? )
   try qn@ zdrop iferror 2drop false nothrow 
   else true then endtry
   ;


\ Conversion
: zz>q { z1tmp z2tmp -- q }   
   qnew   dup z1tmp qn!   dup z2tmp qd!   qred ;

: z>q { z1tmp -- q=z/1 }   
   qnew   dup z1tmp qn!   dup 1 u>z qd! ;

: q>z ( q -- z )   
   dup dup qn@ swap qd@ z/ swap qdrop ;



\ Printing
: {q.} ( q -- q )   
   dup qn@ {z.} zdrop '/' emit dup qd@ {z.} zdrop ;

: q. ( q -- )   
   {q.} bl emit qdrop ;
\ : q.s ( -- )   
\   ." <" depth 0 .r ." > "
\   depth maxdepth-.s @ > if ." ... " then
\   depth 0 max maxdepth-.s @ min dup 0 ?do   
\      dup i - pick
\      dup q-is if (q.) drop else z-is if z{z.} drop else . drop then then 
\   loop ;
\ ' q.s is ..s

\ Comparison
: qcmp { q1tmp q2tmp -- -1|0|1 } \ -1: q1<q2 0: q1=q2 1: q1>q2
   q1tmp qn@ q2tmp qd@ z*   q1tmp qd@ q2tmp qn@ z*   zcmp 
   q1tmp qdrop q2tmp qdrop ;

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

: qinv { q1tmp -- 1/q1 } 
   qnew dup  q1tmp qn@ qd!   dup q1tmp qd@ qn!   q1tmp qdrop ;

: q+ { q1tmp q2tmp -- q1+q2 } \ ( q1n * q2d + q1d * q2n ) / ( q1d * q2d )
   qnew dup   q1tmp qn@ q2tmp qd@ z*   q1tmp qd@ q2tmp qn@ z*   z+   qn!
   dup   q1tmp qd@ q2tmp qd@ z*   qd!   qred 
   q1tmp qdrop   q2tmp qdrop ;

: q- ( q1 q2 -- q1-q2 )   
   qneg q+ qred ;

: q* { q1tmp q2tmp -- q1*q2 } \ ( q1n * q2n ) / ( q1d * q2d )
   qnew dup   q1tmp qn@ q2tmp qn@ z*   qn!   dup   q1tmp qd@ q2tmp qd@ z*   qd!   qred   
   q1tmp qdrop   q2tmp qdrop ;

: q/ ( q1 q2 -- q1/q2 )   
   qinv q* qred ;

: q-mem-stats ( -- )
   cr ." q-inits:   " q-news @ .   
   bl emit ." q-clears:  " q-frees @ . ;


