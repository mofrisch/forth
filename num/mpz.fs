.( MPZ library)

\ num/mpz.fs
\ Integers of arbitrary size via GMP

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

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

Vocabulary gmp

get-current also gmp definitions

require gmp.fs

previous definitions also gmp

false value mem_debug
variable inits        0 inits !
variable clears       0 clears !

: z_init ( z -- ) 
    mem_debug if
        ." init: " dup .
        inits @ 1+ inits !
    then
    __gmpz_init
;

: z_clear ( z -- )
    mem_debug if
        ." clear: " dup .
        clears @ 1+ clears !
    then
    __gmpz_clear
;

: z_new ( -- z )
    __mpz_struct allocate throw dup z_init
;

: z_free ( z -- )
    dup z_clear free throw
;

: zdrop ( z -- )
    z_free
;

: u>z ( u -- z )
    z_new
    dup rot __gmpz_set_ui
;

: (z) ( str -- )
    z_new dup 2swap 10 __gmpz_set_str 0<> if 1 throw then
;

: z ( "name" -- z )
    parse-name ( str len ) 
    z_new dup 2swap 
    ( z z str len ) 10 __gmpz_set_str 0<> if 
        1 throw 
    then
;

: z! ( z var -- )
    dup @ dup 0<> if z_free else drop then !
;

: z@ ( var -- z )
    @ z_new dup rot __gmpz_set
;

: (z.) ( z -- z )
    dup 0 10 rot 
    ( z 0 10 z ) __gmpz_out_str drop bl emit 
;

: z. ( z -- )
    (z.) z_free
;

: ab->aaab ( a b -- a a a b ) \ prepare for binary operation
    over dup 2swap
;

: ab->baaab ( a b -- b a a a b )
    tuck ab->aaab
;

: zu* ( z u -- z )
    ab->aaab __gmpz_mul_ui
;

: z* ( z1 z2 -- z1 = z1*z2 )
    ab->baaab __gmpz_mul swap z_free
;

: z_cmp ( z1 z2 -- n )
    2dup __gmpz_cmp -rot z_free z_free
;

: z= ( z1 z2 -- flag )
    z_cmp 0=
;

: z<> ( z1 z2 -- flag )
    z_cmp 0<>
;

: z< ( z1 z2 -- flag )
    z_cmp 0<
;

: z<= ( z1 z2 -- flag )
    z_cmp 0<=
;

: z> ( z1 z2 -- flag )
    z_cmp 0>
;

: z>= ( z1 z2 -- flag )
    z_cmp 0>=
;

: fct ( u -- z )
    1 u>z swap
    1+ 1 do 
        i zu*
    loop
;

: fct2 ( u -- z )
    1 u>z swap
    1+ 1 do 
        i u>z z*
    loop
;

: fct3 ( u -- z )
    z_new dup rot __gmpz_fac_ui
;

: mem_stats
    cr ." inits: " inits @ .
    cr ." clears: " clears @ .
;

previous set-current

mem_debug [if] mem_stats [then]