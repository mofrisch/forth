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

2variable ben
variable ben$   ben$ $init

: ben!  ( addr u -- ) ben$ $! ;
: ben@  ( -- addr u ) ben$ $@ ;
: ben. ( d -- )   d>f 1000e f/    8 3 1 f.rdp    ."  ms" cr ;
: ben-start ( -- )  utime ben 2! ;
: ben-stop ( -- )   utime ben 2@ d- ben. ;
: b( ')' parse ben! ben@ type ben-start ben@ evaluate ben-stop ; immediate

