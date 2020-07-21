Vocabulary gmp

get-current also gmp definitions

include gmp.fs

previous definitions also gmp

false value mem_debug

variable dict_start   here dict_start !
variable inits        0 inits !
variable clears       0 clears !

128 constant mpz_stack_size
mpz_stack_size __mpz_struct * allocate throw constant mpz_stack
mpz_stack value mpz_sp

9 value mpz_max_depth \ max depth for mpz.s


\ Auxiliary functions

: mpz_init ( a -- ) 
    mem_debug if
        ." init: " dup .
        inits @ 1+ inits !
    then
    __gmpz_init
;

: mpz_clear ( a -- )
    mem_debug if
        ." clear: " dup .
        clears @ 1+ clears !
    then
    __gmpz_clear
;

: mpz_0 ( -- mpz-addr | m: -- )
    __mpz_struct allocate throw dup mpz_init
;

: mpz_free ( mpz-addr -- | m: -- )
    dup mpz_clear free throw
;

: (mpz) ( str -- )
    mpz_0
    dup 2swap 10 __gmpz_set_str 0<> if 1 throw then
;

: mpz ( "name" -- )
    parse-name (mpz) s>mpz
;

: u>mpz ( u -- a )
    __mpz_struct allocate throw dup mpz_init
    dup rot __gmpz_set_ui mpz_push
;


\ Stack manipulation

: mpz_depth ( -- n | m: -- )
    mpz_sp mpz_stack - __mpz_struct /
;

: mpz_check_underflow ( -- | m: -- )
    mpz_sp mpz_stack = if 1 throw then
;

: mpz_drop ( -- | m: mpz -- )
    mpz_check_underflow
    mpz_sp __mpz_struct - to mpz_sp 
    mpz_sp mpz_clear
;

: mpz_clear_stack ( -- | m: i*mpz -- )
    mpz_depth 0 ?do
        mpz_drop
    loop
;

: mpz.s 
    cr
    mpz_depth dup ." < " . ." >" cr mpz_max_depth min 1+ 1 ?do
        i mpz_pick (mpz.) cr drop
    loop
;

: mpz_pick ( n -- mpz )
    mpz_sp swap __mpz_struct * - @
;

: mpz_push ( mpz -- )
    mpz_sp ! 
    mpz_sp __mpz_struct + to mpz_sp 
;



: mpz_pop ( -- mpz )
    mpz_check_underflow
    mpz_sp __mpz_struct - to mpz_sp 
    mpz_sp @
;



: mpz_top ( mpz -- mpz )
    mpz_sp __mpz_struct - @
;

: mpz_sec ( mpz1 mpz2 -- mpz1 )
    mpz_sp __mpz_struct 2 * - @
;

: mpz_dup ( -- mpz mpz )
    mpz_top mpz_push
;


\ Variables

: mpz_var ( "name" --  ) 
    create here __mpz_struct allot mpz_init
;

: mpz_var_clear
    dup 0 <> if dup mpz_clear 0 swap ! then
;



: (mpz.) ( a -- )
    dup 0 10 rot __gmpz_out_str drop bl emit 
;

: mpz. ( -- )
    mpz_pop (mpz.) mpz_clear
;



: mpzu* ( u -- mpz )
    mpz_top dup rot __gmpz_mul_ui
;

: mpz* ( mpz1 mpz2 -- mpz1 )
    mpz_pop dup mpz_top dup rot __gmpz_mul 
    dup mpz_clear free throw
;



: mpz1! ( vmpz -- )
    1 __gmpz_set_ui ;

: mpzu! ( u vmpz -- )
    swap __gmpz_set_ui
;

: mpz! ( vmpz -- )
    \ dup @ mpz_clear
    mpz_pop dup -rot __gmpz_set mpz_clear
;

: mpz@
    mpz0 dup rot __gmpz_set mpz_push
;

: mpz_fact ( u -- mpz )
    1 u>mpz
    1+ 1 do 
        i mpzu*
    loop
;

: bigfactorial2 ( u -- addr )
    1 u>mpz
    1+ 1 do 
        i u>mpz mpz*
    loop
;

: mem_stats
    cr ." dictionary usage: " here dict_start @ - 1024 / . ." KB "
    cr ." inits: " inits @ .
    cr ." clears: " clears @ .
;

previous set-current

mpz_var tmp1 
mpz_var tmp2
mpz_var tmp3
cr
mpz 12 tmp1 mpz!
mpz 13 tmp1 mpz!
tmp1 mpz@ mpz.
tmp1 mpz@ mpz.

\ tmp1 .
\ tmp2 .
\ mpz 13 tmp1 mpz!
mpz 23 tmp2 mpz!
\ 34 tmp3 zu!
\ tmp1 z.
\ tmp2 z.

tmp2 mpz@ 5 mpzu* mpz.
\ tmp1 z.
\ 12 23 * 34 * .
tmp1 mpz@ tmp2 mpz@ mpz* tmp3 mpz!
tmp3 mpz@ mpz.
\ tmp1 tmp2 mpz* tmp3 z* z.
cr
12 u>mpz 23 u>mpz mpz* mpz.
12 u>mpz 23 mpzu* mpz.
44 u>mpz mpz.
mpz 123 mpz.
\ cr
\ mpz 1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111 
\ mpz 1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111 
\ mpz* mpz.
cr
100 mpz_fact mpz.
cr
mpz 100 mpz 100 mpz* mpz 100 mpz* mpz.

tmp1 mpz_var_clear
tmp2 mpz_var_clear
tmp3 mpz_var_clear

mem_debug [if] mem_stats [then]






