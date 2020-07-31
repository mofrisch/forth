\ startup.fs
\ Startup Code. Set start-report to true to see a short report of the files
\ loaded and their space consumption.

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

variable dict_start   here dict_start !
true constant start-report

: draw-seperator ( n -- ) 
   0 ?do [char] - emit loop
;

\ Redifine .( )
warnings @    warnings off
: .( ')' parse start-report if type then ; immediate  
warnings !

: .dict ( -- )
   start-report if ." : "   here dict_start @ - .   ." Bytes " cr then
;

: require2 
   here dict_start !   require   .dict
;

bold attr! 
success-color attr! 
start-report [if]
   80 draw-seperator cr
   ." Startup Code" .dict 
[then]
require2 tools.fs
require2 patches/editor.fs
require2 test.fs
require2 benchmark.fs
require2 num/mpz.fs
require2 num/q.fs
require2 sdl2/sdl2-lib.fs
start-report [if]
   ." Unused: " unused . ." Bytes" cr 
   80 draw-seperator cr
[then]
0 attr!

