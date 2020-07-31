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

begin-structure _q
   drop 0 8 +field num
	drop 8 16 +field den
end-structure

: num! 
   num z!
;

: den! 
   den z!
;

: num@
   num z@
;

: den@
   den z@
;

: qn! ( q z -- ) 
   swap num !
;

: qni! ( q z -- )
   swap num!
;

: qd! ( q z -- )
   swap den !
;

: qdi! ( q z -- )
   swap den!
;

: qabs ( q -- q )
   dup dup num@ zabs qni!
;

: q-is ( q -- flag )
   try qabs drop -1 iferror 2drop 0 then endtry
;



: qnew ( -- q )
   _q allocate throw
;

: qinit ( q -- )
   dup z0 qn!  dup 1 u>z qd!   
;

: qfree ( q -- )
   dup num @ zdrop   dup den @ zdrop   free throw
;

: q0 ( -- q )
   qnew dup qinit
;

: qreduce { q1 -- q2 }
   q1 num@ q1 den@ zgcd zdup
   q1 num@ swap z/ q1 num!   q1 den@ swap z/ q1 den!   
   q1 
;

: q ( "z/z" -- q )
   qnew dup   '/' parse (z) qn!   dup bl parse (z) qd!   qreduce
;

: qdrop ( q -- )
   qfree
;

: qdup { q1 -- q1 q1 }
   qnew dup   dup q1 num@ qn!   dup q1 den@ qd!
;

: zz>q { z1 z2 -- q }
   qnew   dup z1 qn!   dup z2 qd!   qreduce
;

: z>q { z1 -- q=z/1 }
   qnew   dup z1 qn!   dup 1 u>z qd!
;

: q>z ( q -- z )
   dup num@ swap den@ z/
;

: (q.) ( q -- q ) 
   dup num @ (z.) drop  '/' emit    dup den @ (z.) drop
;

: q.
   (q.) bl emit qdrop
;



: qnegate ( q -- q )
   dup dup num@ znegate qni!
;



: q+ { q1 q2 -- q1+q2 }
   \ ( q1n * q2d + q1d * q2n ) / ( q1d * q2d )
   qnew
   dup   q1 num@ q2 den@ z*   q1 den@ q2 num@ z*   z+   qn!
   dup   q1 den@ q2 den@ z*   qd!
   qreduce q1 qdrop q2 qdrop
;

: q- ( q1 q2 -- q1-q2 )
   qnegate q+ qreduce
;

: q* { q1 q2 -- q1*q2 }
   \ ( q1n * q2n ) / ( q1d * q2d )
   qnew 
   dup q1 num@ q2 num@ z* qn!   
   dup q1 den@ q2 den@ z* qd!
   qreduce q1 qdrop q2 qdrop
;

: q/ { q1 q2 -- q1/q2 }
   \ ( q1n * q2d ) / (q1d * q2n )
   qnew 
   dup q1 num@ q2 den@ z* qn!   
   dup q1 den@ q2 num@ z* qd!
   qreduce q1 qdrop q2 qdrop
;