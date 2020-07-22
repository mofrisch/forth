\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 2000,2003,2007,2019 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation, either version 3
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

\ this code works with the following register assignments:
\ esi=sp, ebx=tos

code my+ ( n1 n2 -- n )
    4 si D) bx add
    4 # si add
    Next
end-code

\ see my+
\ 3 5 my+ .
