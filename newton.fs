\ newton.fs
\ Newton algorithm for root finding

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

19 set-precision

: fn ( f -- f ) \ x^2-2
    fdup f* 2e f-
;

: fn' ( f -- f ) \ 2x
2e f*
;

: next-iteration ( f -- f ) 
fdup fdup fn fswap fn' f/ f-
;

: near ( f1 f2 -- flag )
1e-14 f~
;

: fnew ( f -- f )
begin 
    fdup next-iteration ftuck
near until
;


