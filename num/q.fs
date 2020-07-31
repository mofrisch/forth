.( Rationals library)

\ num/q.fs
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

require mpz.fs
-1 to mpz-init-mem-debug
0 to mpz-init-print

struct
   cell% field num
	cell% field den
end-struct _q

\ Accessors
: qn@ ( q -- z )   num z@ ;
: qd@ ( q -- z )   den z@ ;
: qn! ( q z -- )   swap num ! ;
: qni! ( q z -- )   swap num z! ;
: qd! ( q z -- )   swap den ! ;
: qdi! ( q z -- ) swap den z! ;

\ Initialize and free
: q-is ( q -- q flag )   try dup qn@ drop -1 iferror drop 0 then endtry ;
: qnew ( -- q )   _q %allocate throw ;
: qinit ( q -- )   dup z0 qn!  dup 1 u>z qd! ;
: qfree ( q -- )   dup num @ zdrop   dup den @ zdrop   free throw ;
: q0 ( -- q )   qnew dup qinit ;
: qred { q1 -- q2 }
   q1 qn@ q1 qd@ zgcd zdup
   q1 qn@ swap z/ q1 swap qni!   q1 qd@ swap z/ q1 swap qdi!   q1 ;
: q ( "z/z" -- q )
   qnew dup   '/' parse (z) qn!   dup bl parse (z) qd!   qred ;

\ Conversion
: zz>q { z1 z2 -- q }   qnew   dup z1 qn!   dup z2 qd!   qred ;
: z>q { z1 -- q=z/1 }   qnew   dup z1 qn!   dup 1 u>z qd! ;
: q>z ( q -- z )   dup qn@ swap qd@ z/ ;


\ Stack manipulation
: qdrop ( q -- )   qfree ;
: qdup { q1 -- q1 q1 }   qnew dup   dup q1 qn@ qn!   dup q1 qd@ qd! ;

\ Printing
: (q.) ( q -- q )   dup num @ (z.) drop  '/' emit    dup den @ (z.) drop ;
: q. ( q -- )   (q.) bl emit qdrop ;
: q.s ( -- )
   ." <" depth 0 .r ." > "
   depth maxdepth-.s @ > if ." ... " then
   depth 0 max maxdepth-.s @ min
   dup 0 ?do   dup i - pick
      q-is if   (q.) drop else 
      z-is if   z(z.) drop else    
      . 
   then then loop drop ;
' q.s is ..s

\ Comparison
: qcmp { q1 q2 -- -1|0|1 } \ -1: q1<q2 0: q1=q2 1: q1>q2
   q1 qn@ q2 qd@ z*   q1 qd@ q2 qn@ z*   zcmp ;
: q= ( q1 q2 -- flag )   qcmp 0= ;
: q<> ( q1 q2 -- flag )   qcmp 0<> ;
: q> ( q1 q2 -- flag )   qcmp 1 = ;
: q>= ( q1 q2 -- flag )   qcmp dup 0= swap 1 = or ;
: q< ( q1 q2 -- flag )   qcmp -1 = ;
: q<= ( q1 q2 -- flag )   qcmp dup 0= swap -1 = or ;

\ Arithmetics
: qneg ( q -- q )   dup dup qn@ znegate qni! ;
: qabs ( q -- q )   dup dup qn@ zabs qni! ;
: q+ { q1 q2 -- q1+q2 } \ ( q1n * q2d + q1d * q2n ) / ( q1d * q2d )
   qnew dup   q1 qn@ q2 qd@ z*   q1 qd@ q2 qn@ z*   z+   qn!
   dup   q1 qd@ q2 qd@ z*   qd!
   qred q1 qdrop q2 qdrop ;
: q- ( q1 q2 -- q1-q2 )   qneg q+ qred ;
: q* { q1 q2 -- q1*q2 } \ ( q1n * q2n ) / ( q1d * q2d )
   qnew   dup q1 qn@ q2 qn@ z* qn!   dup q1 qd@ q2 qd@ z* qd!
   qred q1 qdrop q2 qdrop ;
: q/ { q1 q2 -- q1/q2 } \ ( q1n * q2d ) / (q1d * q2n )
   qnew   dup q1 qn@ q2 qd@ z* qn!   dup q1 qd@ q2 qn@ z* qd!
   qred q1 qdrop q2 qdrop ;