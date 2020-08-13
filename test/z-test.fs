.( Test big numbers)

\ num/mpz_test.fs
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

require ../num/z.fs

-1 to z-total-inits

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

tests Comparison:
t( z 1 z 1 z= )
t( z 1 z 2 z<> )
totals

tests Arithmetics and special functions:
t( z 123456789012345678901234567890 a1 z! true )
t( z 1 z 1 z+ z 2 z= )
t( a1 z@ 2 zu+ z 123456789012345678901234567892 z= )
t( a1 z@ 2 zu- z 123456789012345678901234567888 z= )
t( a1 z@ a1 z@ z- z0 z= )
t( 5 fct z 120 z= )
totals

cr

z-total-inits [if] z-mem-stats [then]
