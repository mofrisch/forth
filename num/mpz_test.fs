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

require mpz.fs

variable a0
12 u>z a0 z!
a0 z@ z.
13 u>z a0 z!
a0 z@ z.
a0 z@ z.

3 fct z.
3 fct2 z.