.( Benchmark Tools)

\ benchmark.fs
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

2variable bench
variable expression   0 expression !


: start-bench
   utime bench 2!
;

: stop-bench
   utime bench 2@ d- ( 2dup d. ) d>f 1000e f/ f. ." ms" cr
;

: b(  
   ')' parse  
   expression @ 0= if 
      $make expression !
   else
      expression $!
   then
   expression $@ type
   start-bench
   expression $@ evaluate
   stop-bench
;

