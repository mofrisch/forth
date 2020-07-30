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

[ifundef] zinit 
   require mpz.fs
[then]

false to mem_debug

variable a0
12 u>z a0 z!
a0 z@ z.
13 u>z a0 z!
a0 z@ z.
a0 z@ z.

3 fct z.
3 fct2 z.

cr z 123456789012345678901234567890 2 zu+ z.
cr z 123456789012345678901234567890 z 123456789012345678901234567890 z+ z.
cr z 123456789012345678901234567890 2 zu- z.
cr z 123456789012345678901234567890 z 123456789012345678901234567890 z- z.

\ mem_stats

print-summary
\ print-detail
cr 80 draw-seperator

tests Comparison :
t( z 1 z 1 z= )
t( z 1 z 2 z= )
t( z 1 z 1 z= )
totals

tests Arithmetics and special functions :
t( z 1 z 1 z+ z 2 z= )
totals
cr