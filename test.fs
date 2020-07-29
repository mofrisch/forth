.( Testing Tools)

\ test.fs
\ Some exercises

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.
\ Version 0.0.0

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

variable test-expression

: t(  
   ')' parse 
   test-expression @ 0= if 
      $make test-expression !
   else
      test-expression $!
   then
   test-expression $@ type
   
   test-expression $@ evaluate if 
      success-color attr! ." test passed " 0 attr! cr
   else
      error-color attr! ." test failed " 0 attr! cr
   then
   
;

cr 
t( z 1 z 1 z= )
t( z 1 z 2 z= )