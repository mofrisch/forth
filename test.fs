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

variable test-expression   test-expression $init
variable test-section      test-section $init
variable test-passed       0 test-passed !
variable test-failed       0 test-failed !
variable test-print-string test-print-string $init
true value test-print-detail


: tests 
   10 parse   test-section $!
   cr
   test-section $@ type cr
   0 test-passed !   0 test-failed !
;

: totals-passed
   ." Passed: " test-passed @ . 
;

: totals-failed
   ." Failed: " test-failed @ .
;

: test-ok.
   success-color attr! ." test passed " default-color attr! cr
;

: test-nok.
   error-color attr! ." test failed " default-color attr! cr
;

: totals 
   ." Tests: "    test-passed @ test-failed @ + . 
   ['] totals-passed success-color color-execute
   test-failed @ if ['] totals-failed error-color color-execute then
   cr 80 draw-seperator
;


: t(  ')' parse    test-expression $!
   test-expression $@ evaluate if 
      test-passed ++   
      test-print-detail if test-expression $@ type   test-ok. then
   else
      test-failed ++   test-expression $@ type   test-nok.
   then
;

: print-summary
   false to test-print-detail
;

: print-detail
   true to test-print-detail
;

