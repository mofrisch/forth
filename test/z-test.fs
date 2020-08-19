.( Test big numbers)

\ num/z_test.fs
\ Testfile for mpz

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

true constant z-coverage

z-coverage [if] 
include ../../gforth/coverage.fs 
include ../num/z.fs
[else]
require ../num/z.fs
[then]
\ 0 z-print-inits !

[ifundef] a1
variable a1    variable a2   variable a3
[then]

print-summary
\ print-detail
cr 80 draw-seperator



tests Variables:
t( 12 u>z a1 z! a1 z@ z 12 z= )
t( 13 u>z a1 z! a1 z@ z 13 z= )
t( a1 z@ z 13 z= )
t( z 14 a1 z! true )
totals

tests allocate and free
t( z0 z 0 z= )
t( z0 zfree true )
totals

tests stack
t( z 1 zdrop true )
t( z 1 z 2 znip z 2 z= )
t( z 14 zdup znip z 14 z= )
t( z 1 z 2 ztuck zdrop zdrop z 2 z= )
t( z 1 z 2 zover zdrop zdrop z 1 z= )
t( z 1 z 2 z 3 1 zpick -rot zdrop zdrop swap zdrop z 2 z= )
t( z0 z?dup z0 z= )
t( z 17 z?dup z 17 z= swap z 17 z= and )
t( z 12 z 15 z2drop true )
t( z 1 z 2 z 3 z 4 z2nip z 4 z= swap z 3 z= and )
t( z 1 z 2 z2dup 2swap z2drop z 2 z= swap z 1 z= and )
t( z 1 z 2 z 3 z 4 z2tuck z2drop z2drop z 4 z= swap z 3 z= and )
t( z 1 z 2 z 3 z 4 z2over z2drop z2drop z 2 z= swap z 1 z= and )
totals


tests Comparison:
t( z 1 z 1 z= )
t( z 1 z 2 z<> )
t( a1 z@ a1 z@ z= )
t( z 14 a1 z@ z= )
t( 200 fct 201 fct z<= )
t( 200 fct 201 fct z< )
t( 201 fct 200 fct z>= ) 
t( 201 fct 200 fct z> ) 
totals

tests creating
t( 23 u>z z 23 z= )
t( -12 s>z z -12 z= )
t( s" 123" {z} z 123 z= )
totals

tests printing
t( ." you should see 21: " z 21 {z.} cr zdrop true )
t( ." you should see {22}: " z 22 z{z.} cr zdrop true )
t( ." you should see {23}: " z 23 z. cr true )
totals

tests Arithmetics and special functions:
t( z 123456789012345678901234567890 a1 z! true )
t( z 1 z 1 z+ z 2 z= )
t( a1 z@ 2 zu+ z 123456789012345678901234567892 z= )
t( a1 z@ 2 zu- z 123456789012345678901234567888 z= )
t( a1 z@ a1 z@ z- z0 z= )
t( 5 fct z 120 z= )
t( z 42 3 zu* z 126 z= )
t( z 42 3 zu/ z 14 z= )
t( z 42 3 zumod z0 z= )
t( z 39 4 zumod z 3 z= )
t( z 18 a1 z@ z+ z 123456789012345678901234567908 z= )
t( a1 z@ z 18 z- z 123456789012345678901234567872 z= )
t( z 2 z 3 z* z 6 z= )
t( z 21 z 4 z/ z 5 z= )
t( z 21 z 4 zmod z 1 z= )
t( z 23 z 4 z/mod z 5 z= swap z 3 z= and )
t( z 123 zneg z -123 z= )
t( z -123 zneg z 123 z= )
t( z 42 zabs z 42 z= )
t( z -43 zabs z 43 z= )
t( z 1 z 2 zmin z 1 z= )
t( z 1 z 1 zmin z 1 z= )
t( z 5 z -1 zmin z -1 z= )
t( z 1 z 2 zmax z 2 z= )
t( z 1 z 1 zmax z 1 z= )
t( z 5 z -1 zmax z 5 z= )
t( z 24 z 8 zgcd z 8 z=)
t( z 17 z 13 zgcd z 1 z= )
t( 100 fct 100 fct2 z= )
t( 100 fct 100 fct3 z= )
t( ." you should see 100!: " 100 fct z. cr true )
totals

a1 zv-free
a1 zv-free

z-mem-stats
z-coverage [if] cr cov% [then]
cr
