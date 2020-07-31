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

require ../tools.fs

Vocabulary gmp

get-current also gmp definitions

include gmp.fs

\ previous set-current also gmp
previous definitions also gmp
\ Vocabulary mpz 
\ get-current also mpz definitions

false value mpz-init-mem-debug
false value mpz-init-print

[ifundef] mpz-inits 
variable mpz-inits   variable mpz-clears  
[then]     

0 mpz-inits !   0 mpz-clears !

: zinit ( z -- ) 
    mpz-init-mem-debug if mpz-inits ++ then
    mpz-init-print if ." init: " dup . then
    __gmpz_init
;

: zclear ( z -- )
    mpz-init-mem-debug if mpz-clears ++ then
    mpz-init-print if ." clear: " dup . then
    __gmpz_clear
;

: z0 ( -- z )
    __mpz_struct allocate throw    dup zinit
;

: zfree ( z -- )
    dup zclear free throw
;

: z-is ( z | n -- z -1 | n 0 )
    try dup dup __gmpz_cmp drop -1 iferror drop 0 then endtry
;

\ Comparison

: zcmp ( z1 z2 -- n )
    2dup __gmpz_cmp -rot zfree zfree
;

: z= ( z1 z2 -- flag )
    zcmp 0=
;

: z<> ( z1 z2 -- flag )
    zcmp 0<>
;

: z< ( z1 z2 -- flag )
    zcmp 0<
;

: z<= ( z1 z2 -- flag )
    zcmp 0<=
;

: z> ( z1 z2 -- flag )
    zcmp 0>
;

: z>= ( z1 z2 -- flag )
    zcmp 0>=
;




\ Stack Manipulation: We only need creative and destructive words

: zdrop ( z -- )
    zfree
;

: znip ( z1 z2 -- z2 )
    swap zdrop
;

: zdup ( z -- z z )
    dup z0 dup rot ( z z0 z0 z ) __gmpz_set
;

: ztuck ( z1 z2 -- z2 z1 z2 )
    zdup -rot
;

: zover ( z1 z2 -- z1 z2 z1 )
    swap ztuck
;

: zpick ( z1 ... zn u -- z1 ... zn zu )
    pick >r z0 dup r> __gmpz_set
;

: z?dup ( z1<>0 -- z1 z1 )
    zdup z0 z<> if zdup then
;

: z2drop ( z1 z2 -- )
    zdrop zdrop
;

: z2nip ( z1 z2 z3 z4 -- z3 z4 )
    2swap z2drop
;

: z2dup ( z1 z2 -- z1 z2 z1 z2 )
    swap zdup rot zdup -rot
;

: -2rot ( z1 z2 z3 z4 z5 z6 -- z5 z6 z1 z2 z3 z4 )
    2rot 2rot
;

: z2tuck ( z1 z2 z3 z4 -- z3 z4 z1 z2 z3 z4 )
    z2dup -2rot
;

: z2over ( z1 z2 z3 z4 -- z1 z2 z3 z4 z1 z2 )
    2swap z2tuck
;


\ Creating MPZ numbers

: u>z ( u -- z )
    z0 dup rot __gmpz_set_ui
;

: (z) ( str -- )
    z0 dup 2swap 10 __gmpz_set_str 0<> if s" invalid character " exception throw then
;

: z ( "name" -- z )
    parse-name ( str len ) 
    z0 dup 2swap 
    ( z z str len ) 10 __gmpz_set_str 0<> if 
        1 throw 
    then
;

: z! ( z var -- )
    dup @ dup 0<> if zdrop else drop then !
;

: z@ ( var -- z )
    @ z0 dup rot __gmpz_set
;

: (z.)
    dup 0 10 rot __gmpz_out_str drop 
;

: z(z.) ( z -- z )
    ." z(" dup 0 10 rot __gmpz_out_str drop ." ) "
;


: z. ( z -- )
    z-is if z(z.) zdrop else . then
;

: z.s 
    ." <" depth 0 .r ." > "
    depth maxdepth-.s @ > if ." ... " then
    depth 0 max maxdepth-.s @ min
    dup 0
    ?do
        dup i - pick
        z-is if z(z.) drop else . then 
    loop
    drop
;

' z.s is ..s


\ Arithmetics

: ab>aaab ( a b -- a a a b ) \ prepare for binary operation
    over dup 2swap
;

: ab>baaab ( a b -- b a a a b )
    tuck ab>aaab
;

: zu+ ( z u -- z+u )
    ab>aaab __gmpz_add_ui
;

: z+ ( z1 z2 -- z1 = z1+z2 )
    ab>baaab __gmpz_add swap zdrop
;

: zu- ( z u -- z-u )
    ab>aaab __gmpz_sub_ui
;

: z- ( z1 z2 -- z1 = z1-z2 )
    ab>baaab __gmpz_sub swap zdrop
;

: zu* ( z u -- z*u )
    ab>aaab __gmpz_mul_ui
;

: z* ( z1 z2 -- z1 = z1*z2 )
    ab>baaab __gmpz_mul swap zdrop
;

\ Division is floored

: zu/ ( z u -- z/u )
    ab>aaab __gmpz_fdiv_q_ui drop ( the remainder )
;

: z/ ( z1 z2 -- z1/z2 )
    ab>baaab __gmpz_fdiv_q swap zdrop
;

: z/mod ( z1 z2 -- z1/z2 z1%z2 )
    2dup z0 z0 2dup 2rot ( z1 z2 z0 z0 z0 z0 z1 z2 ) 
    __gmpz_fdiv_qr 
    2swap zdrop zdrop swap
;

: zumod ( z u -- z%u )
    ab>aaab __gmpz_fdiv_r_ui drop
;

: zmod ( z1 z2 -- z1%z2 )
    ab>baaab __gmpz_fdiv_r swap zdrop
;

: znegate ( z -- -z )
    dup dup __gmpz_neg
;

: zabs ( z -- |z| )
    dup dup __gmpz_abs
;

: zmin ( z1 z2 -- z )
    z2dup z<= if zdrop else swap zdrop then
;

: zmax ( z1 z2 -- z )
    z2dup z>= if zdrop else swap zdrop then
;

: zgcd ( z1 z2 -- z )
    ab>baaab __gmpz_gcd swap zdrop
;


\ Special functions

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
    z0 dup rot __gmpz_fac_ui
;

: z-mem-stats
    cr ." inits: " mpz-inits @ .
    cr ." clears: " mpz-clears @ .
;

previous ( previous ) set-current


