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
variable total-test-passed  0 total-test-passed !
variable total-test-failed  0 total-test-failed !

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

: grand-totals-passed
   ." Passed: " total-test-passed @ . 
;

: grand-totals-failed
   ." Failed: " total-test-failed @ .
;

: test-ok.
   success-color attr! ." test passed: " default-color attr!
;

: test-nok.
   error-color attr! ." test failed: " default-color attr!
;

: totals 
   ." Tests: "    test-passed @ test-failed @ + . 
   ['] totals-passed success-color color-execute
   test-failed @ if ['] totals-failed error-color color-execute then
   test-passed @ total-test-passed @ + total-test-passed !
   test-failed @ total-test-failed @ + total-test-failed !
   cr 80 draw-seperator
;

: grand-totals
   cr ." Tests altogether: "    total-test-passed @ total-test-failed @ + . 
   ['] grand-totals-passed success-color color-execute
   test-failed @ if ['] grand-totals-failed error-color color-execute then
   0 total-test-passed !  0 total-test-failed !
   cr 80 draw-seperator
;


: t(  ')' parse    test-expression $!
   test-expression $@ evaluate if 
      test-passed ++   
      test-print-detail if 
         sourcefilename type ':' emit sourceline# .du ':' emit 1 .du ':' 
      emit ."  info: " test-ok. test-expression $@ type    cr 
      then
   else
      test-failed ++   
      sourcefilename type ':' emit sourceline# .du ':' emit 1 .du ':' 
      emit ."  error: " test-nok. test-expression $@ type cr 
   then
;

: print-summary
   false to test-print-detail
;

: print-detail
   true to test-print-detail
;

