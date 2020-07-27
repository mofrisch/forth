.( MPZ library 0.0.0)

Vocabulary gmp

get-current also gmp definitions

require gmp.fs

previous definitions also gmp



false value mem_debug

\ variable dict_start   here dict_start !
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

: mem_stats
    cr ." dictionary usage: " here dict_start @ - 1024 / . ." KB "
    cr ." inits: " inits @ .
    cr ." clears: " clears @ .
;

previous set-current



mem_debug [if] mem_stats [then]