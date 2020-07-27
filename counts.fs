\ counts.fs
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

: counts ( limit counter -- )
    DO I . LOOP
;

: odd ( n -- f )
    2 mod 
;

: avalanche ( n -- )
    BEGIN
        dup 2 mod
            IF 3 * 1+ 
            ELSE 2/ 
            THEN 
        dup . dup
    1 = UNTIL
    drop
;

: range ( n1 n2 -- )
    swap
    DO
    I .
    I 50 >= IF LEAVE THEN
    LOOP
;

: star ( -- )
    ." *"
;

: stars ( n -- n )
dup 0 do star loop
;

: box ( n1 n2 -- )
page swap 0 do stars cr loop drop
;

: /box ( height width -- )
page swap 0 do dup i - spaces stars cr loop drop
;



: midline ( n -- )
    star 2 * 1 - spaces star cr
;

: firstline ( n -- )
    spaces star cr
;

: line ( n current -- )
    swap  over - 1- spaces star
    dup 0= IF
    cr drop else
    2* 1- spaces star cr then
;

: diamond ( n -- )
    page
    dup 0 do 
        dup i line
    loop
    dup 1 > if 
        dup 2 - 0 swap do
            dup i line
        -1 +loop
    then
    drop
;

: sigma ( n -- n )
    dup 0 do i + loop
;

: two ( n -- n n )
    dup
;

: ramp ( n -- )
    dup 0 do 
        dup i swap 2 / < if 
        i 1+ else 
        dup i - then 
        7 min .
    loop drop
;