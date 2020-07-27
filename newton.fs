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

: fn ( r -- r )
fdup f* 2e f-
;

: fn' ( r -- r )
2e f*
;

: next ( r -- r )
fdup fdup fn fswap fn' f/ f-
;

: near ( r1 r2 -- f )
f- fabs 1e-12 f<
;

: fnew ( r -- r )
begin 
    fdup next ( x1 x2 )
    fswap fover ( x2 x1 x2 )
near until
;


