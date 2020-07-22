\ run timings on some small Forth benchmarks

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 2007,2012,2019 Free Software Foundation, Inc.

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

\ many platforms don't have GNU time, so we do it ourselves

.(  sieve bubble matrix   fib   fft) cr

warnings off

: include-main-time ( addr u -- )
    cputime d+ 2>r
    included s" main" evaluate
    cputime d+ 2r> d-
    <# # # # # # # '. hold #s #> 9 over - spaces 3 - type ;
: run-bench
    s" marker onebench" evaluate
    s" siev.fs"      include-main-time space
    s" bubble.fs"    include-main-time space
    s" matrix.fs"    include-main-time
    s" fib.fs"       include-main-time
    s" fft-bench.fs" include-main-time
    s" onebench" evaluate ;
run-bench
script? [IF] cr argc @ 2 < [IF] bye [THEN] [THEN]
