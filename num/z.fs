.( MPZ library)

\ num/mpz.fs
\ Integers of arbitrary size via GMP

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
\ along with this program. If not, see http://www.gnu.org/licenses/.
\ #endregion

\ #region Definitions
\ require tools.fs
require intro.fs

vocabulary gmp
get-current also gmp definitions
include ../generated/gmp.fs
previous definitions also gmp

variable z-print-inits   false z-print-inits !

begin-structure __z_struct
	drop 0 4 +field __z_struct-_mp_alloc
	drop 4 4 +field __z_struct-_mp_size
	drop 8 8 +field __z_struct-_mp_d
drop 16 end-structure

variable z-inits   0 z-inits ! 
variable z-clears  0 z-clears ! 
  
\ #endregion

\ #region Allocate and free
: zinit ( z -- ) 
    z-inits ++
    z-print-inits @ if ." init: " dup . then
    dup __gmpz_init ;

: zclear ( z -- )
    z-clears ++
    z-print-inits @ if ." clear: " dup . then
    __gmpz_clear ;

: z0 ( -- z )   
    __z_struct allocate throw    dup zinit drop ;

: zfree ( z -- )   
    dup zclear free throw ;


\ #endregion

\ #region Comparison

: zcmp ( z1 z2 -- -1|0|1 ) \ -1: z1<z2 0: z1=z2 1: z1>z2
    2dup __gmpz_cmp -rot zfree zfree ;

: z=  ( z1 z2 -- ? )  
    zcmp 0= ;

: z<> ( z1 z2 -- ? )   
    zcmp 0<> ;

: z<  ( z1 z2 -- ? )   
    zcmp 0< ;

: z<= ( z1 z2 -- ? )   
    zcmp 0<= ;

: z>  ( z1 z2 -- ? )   
    zcmp 0> ;

: z>= ( z1 z2 -- ? )   
    zcmp 0>= ;

\ #endregion

\ #region Stack Manipulation
\ We only need creative and destructive words

: zdrop ( z -- )   
    zfree ;

: znip ( z1 z2 -- z2 )   
    swap zdrop ;

: zdup ( z -- z z )   
    dup z0 dup rot __gmpz_set ;

: ztuck ( z1 z2 -- z2 z1 z2 )   
    zdup -rot ;

: zover ( z1 z2 -- z1 z2 z1 )   
    swap ztuck ;
    
: zpick ( z1 ... zn u -- z1 ... zn zu )   
    pick >r z0 dup r> __gmpz_set ;

: z?dup ( z1<>0 -- z1 z1 )    
    zdup z0 z<> if zdup then ;

: z2drop ( z1 z2 -- )   
    zdrop zdrop ;

: z2nip ( z1 z2 z3 z4 -- z3 z4 )   
    2swap z2drop ;
: z2dup ( z1 z2 -- z1 z2 z1 z2 )   
    swap zdup rot zdup -rot ;

: z2tuck ( z1 z2 z3 z4 -- z3 z4 z1 z2 z3 z4 )   
    z2dup -2rot ;

: z2over ( z1 z2 z3 z4 -- z1 z2 z3 z4 z1 z2 )   
    2swap z2tuck ;

\ #endregion




\ #region Creating MPZ numbers

: u>z ( u -- z )   
    z0 dup rot __gmpz_set_ui ;

: s>z ( s -- z )
    z0 dup rot __gmpz_set_si ;

: {z} ( str -- )
    z0 dup 2swap 10 __gmpz_set_str 0<> if 
        s" invalid character " throw
    then ;

: z ( "name" -- z )
    parse-name {z} ;

: z! ( z var -- )   
    dup @ dup 0<> if zdrop else drop then ! ;

: z@ ( var -- z )   
    @ z0 dup rot __gmpz_set ;

: zv-free ( var -- )
   dup dup @ 0<> if @ zdrop then 0 swap ! ;

\ #endregion

\ #region Printing

: {z.} ( z -- z )
    dup stdout base @ rot __gmpz_out_str drop ;

: z{z.} ( z -- z )
    '{' emit dup stdout base @ rot __gmpz_out_str drop '}' emit ;

: z. ( z -- )       
    z{z.} zdrop bl emit ;
\ : z.s ( -- )
\    ." <" depth 0 .r ." > "
\    depth maxdepth-.s @ > if ." ... " then
\    depth 0 max maxdepth-.s @ min
\    dup 0
\    ?do
\        dup i - pick
\        z-is if z{z.} drop else . then 
\    loop
\    drop ;
\ ' z.s is ..s
\ #endregion

\ #region Arithmetics
\ division is floored

: zbinzu ( z u -- z z z u ) \ prepare for binary operation
    over dup 2swap ;

: zbinzz ( z1 z2 -- z2 z1 z1 z1 z2 )   
    tuck zbinzu ;

: zu+ ( z u -- z+u )        
    zbinzu __gmpz_add_ui ;

: zu- ( z u -- z-u )        
    zbinzu __gmpz_sub_ui ;

: zu* ( z u -- z*u )        
    zbinzu __gmpz_mul_ui ;

: zu/ ( z u -- z/u )        
    zbinzu __gmpz_fdiv_q_ui drop ;

: zumod ( z u -- z%u )      
    zbinzu __gmpz_fdiv_r_ui drop ;

: z+ ( z1 z2 -- z1+z2 )     
    zbinzz __gmpz_add swap zdrop ;

: z- ( z1 z2 -- z1-z2 )     
    zbinzz __gmpz_sub swap zdrop ;

: z* ( z1 z2 -- z1*z2 )    
    zbinzz __gmpz_mul swap zdrop ;

: z/ ( z1 z2 -- z1/z2 )     
    zbinzz __gmpz_fdiv_q swap zdrop ;

: zmod ( z1 z2 -- z1%z2 )   
    zbinzz __gmpz_fdiv_r swap zdrop ;

: z/mod ( z1 z2 -- z1/z2 z1%z2 )
    2dup z0 z0 2dup 2rot __gmpz_fdiv_qr 2swap zdrop zdrop swap ;

: zneg ( z -- -z )    
    dup dup __gmpz_neg ;

: zabs ( z -- |z| )   
    dup dup __gmpz_abs ;

: zmin ( z1 z2 -- z )   
    z2dup z<= if zdrop else swap zdrop then ;

: zmax ( z1 z2 -- z )   
    z2dup z>= if zdrop else swap zdrop then ;

: zgcd ( z1 z2 -- z )   
    zbinzz __gmpz_gcd swap zdrop ;

\ #endregion

\ #region Special functions
: fct ( u -- z )    
    1 u>z swap 1+ 1 do i zu* loop ;

: fct2 ( u -- z )   
    1 u>z swap 1+ 1 do i u>z z* loop ;

: fct3 ( u -- z )   
    z0 dup rot __gmpz_fac_ui ;

: z-mem-stats ( -- )   
    cr ." z-inits:   " z-inits @ .   
    bl emit ." z-clears:  " z-clears @ . ;
\ #endregion

previous set-current





