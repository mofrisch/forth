\ way.fs
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

: upper ( char -- char )
    dup [char] i [char] m 1 + within if 32 - then
;

: printkey ( char -- )
    upper
    CASE
        [CHAR] I OF ." UP" ENDOF
        [CHAR] J OF ." LEFT" ENDOF
        [CHAR] K OF ." HOME" ENDOF
        [CHAR] L OF ." RIGHT" ENDOF
        [CHAR] M OF ." DOWN" ENDOF
        DUP EMIT
    ENDCASE
;

: ?way ( -- )
BEGIN
    KEY DUP
    printkey
27 = UNTIL
;
