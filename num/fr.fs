.( MPFR Library)

\ fr.fs
\ Library for Floting Point numbers with arbitrary precision

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ #region License
\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http: //www.gnu.org/licenses/.
\ #endregion

\ #region Definitions
\ require tools.fs
require z.fs
require q.fs

vocabulary mpfr
get-current also mpfr definitions
include ../generated/mpfr.fs
previous definitions also mpfr

false value fr-total-inits
false value fr-print-inits
200 value fr-digits
fr-digits 1000 3321 */ value fr-decimal-digits \ divide by log(2,10)

MPFR_RNDN value fr-round


[ifundef] fr-inits   variable fr-inits   variable fr-clears  [then]     
0 fr-inits !   0 fr-clears !
\ #endregion

\ #region Allocate and free

: frinit ( fr -- ) 
    fr-inits ++
    \ fr-print-inits if ." init: " dup . then
    fr-digits mpfr_init2 ;

: frclear ( fr -- )
    fr-clears ++
    \ fr-print-inits if ." clear: " dup . then
    mpfr_clear ;

: frnew (   -- fr ) \ create uninilized value
     __mpfr_struct allocate throw 
     dup frinit ;

: fr0 ( -- fr )   
    frnew dup 0 fr-round mpfr_set_ui drop ;

: frfree ( fr -- )   
    dup frclear free throw ;

: frdrop ( fr --  ) \ 
    frfree ;

: z>fr ( z -- fr )
    dup frnew dup rot fr-round mpfr_set_z drop swap zdrop ;

: fr! ( fr -- )
    dup @ dup 0<> if frdrop else drop then ! ;


: fr@ ( fr -- fr )
    @ frnew dup rot fr-round mpfr_set drop ;

: frv-free ( var -- )
   dup dup @ 0<> if @ frdrop then 0 swap ! ;

\ #endregion

: frdig ( u -- )
    to fr-digits
    fr-digits 1000 3321 */ to fr-decimal-digits ;

: frdup ( fr -- fr fr )   dup frnew dup rot fr-round mpfr_set drop ;


: fr2dup ( fr1 fr2 -- fr1 fr2 fr1 fr2 )
    swap frdup rot frdup -rot ;


\ #region Comparison
: frcmp ( fr1 fr2 -- -1|0|1 ) \ -1: fr1<fr2 0: fr1=fr2 1: fr1>2
    2dup mpfr_cmp -rot frfree frfree 
    ;

: fr=  ( fr1 fr2 -- ? )   
    frcmp 0= ;

: fr<> ( fr1 fr2 -- ? )   
    frcmp 0<> ;

: fr<  ( fr1 fr2 -- ? )   
    frcmp 0< ;

: fr<= ( fr1 fr2 -- ? )   
    frcmp 0<= ;

: fr>  ( fr1 fr2 -- ? )   
    frcmp 0> ;

: fr>= ( fr1 fr2 -- ? )   
    frcmp 0>= ;


\ #endregion

\ #region Creating MPFR numbers
: u>fr ( u -- fr )   
    >r frnew dup r> fr-round mpfr_set_ui drop ;

: s>fr ( s -- fr )   
    >r frnew dup r> fr-round mpfr_set_si drop ;

: {fr} ( str -- fr )
    frnew dup 2swap base @ fr-round mpfr_set_str drop ;

: fr ( "value" -- fr )
    parse-name {fr} ;





    


\ z! ( z var -- )   dup @ dup 0<> if zdrop else drop then ! ;
\ z@ ( var -- z )   @ z0 dup rot __gmpz_set ;
\ #endregion

\ #region Arithmetics

: frunary ( fr1 -- fr1 fr1 fr1 fr-round )
    dup dup fr-round ;

: frbin ( fr1 fr2 -- fr2 fr1 fr1 fr1 fr2 fr-round )
    tuck over dup 2swap fr-round ;

: frafter ( fr2 fr1 0 -- fr1 )
    drop swap frdrop ;

: fr+ ( fr1 fr2 -- fr1+fr2 )
    frbin mpfr_add frafter
    ;

: fr- ( fr1 fr2 -- fr1-fr2 )
    frbin mpfr_sub frafter
    ;

: fr* ( fr1 fr2 -- fr1*fr2 )
    frbin mpfr_mul frafter
    ;

: fr/ ( fr1 fr2 -- fr1*fr2 )
    frbin mpfr_div frafter
    ;

: frabs ( fr1 -- |fr1| )
    frunary mpfr_abs drop ;


\ #endregion

: q>fr ( q -- fr )
    dup dup frnew dup rot qn@ tuck fr-round mpfr_set_z drop zdrop swap
    frnew dup rot qd@ tuck fr-round mpfr_set_z drop zdrop fr/ qnip ;

: {fr.} ( fr --  ) \ print fr number
    dup >r 
    stdout 
    base @ 
    fr-decimal-digits
    r> 
    fr-round 
    __gmpfr_out_str drop ;

: fr. ( fr --  ) \ description
    {fr.} frdrop ;


: #fr. ( fr u --  ) \ print fr number with u digits
    >r dup >r stdout base @ 2r> fr-round __gmpfr_out_str drop frdrop ;

: frsin ( fr -- fr ) \ sine
    frunary mpfr_sin drop ;

: frupow ( fr u -- fr ) \ raise to the power of u
    >r dup dup r> fr-round mpfr_pow_ui drop ;


: fr~abs ( fr1 fr2 fr3 - ? ) \ is |fr1 - fr2| <= fr3 
    -rot fr- frabs swap fr<=
;

: fr~rel ( fr1 fr2 fr3 -- ? ) \ |fr1 - fr2| <= fr3 * | fr1 + fr2 |
    -rot fr2dup fr- frabs -rot fr+ frabs rot fr* fr<= ;

: fr-mem-stats ( -- )   
    cr ." fr-inits:  " fr-inits @ .   
    bl emit ." fr-clears: " fr-clears @ . ;

: fr-mem-reset ( -- ) 
    0 fr-inits !   0 fr-clears ! ;

previous set-current
