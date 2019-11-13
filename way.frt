: letter-I ( char -- char f )
    DUP DUP [CHAR] I = SWAP [CHAR] i = OR
;

: letter-J ( char -- char f )
    DUP DUP [CHAR] J = SWAP [CHAR] j = OR
;

: print-UP ( f -- )
    ." UP" DROP
;

: print-LEFT ( f -- )
    ." LEFT" DROP
;

: printkey2 ( char -- )
    letter-I IF print-UP
        ELSE 
        letter-J IF print-LEFT
            ELSE 
                EMIT 
            THEN
        THEN
;

: printkey ( char -- )
    
    CASE
        [CHAR] I OF ." UP" ENDOF
        [CHAR] i OF ." UP" ENDOF

        [CHAR] J OF ." LEFT" ENDOF
        [CHAR] j OF ." LEFT" ENDOF

        [CHAR] K OF ." HOME" ENDOF
        [CHAR] k OF ." HOME" ENDOF

        [CHAR] L OF ." RIGHT" ENDOF
        [CHAR] l OF ." RIGHT" ENDOF

        [CHAR] M OF ." DOWN" ENDOF
        [CHAR] m OF ." DOWN" ENDOF
        
        DUP EMIT
    ENDCASE
;

: ?way ( -- )
BEGIN
    KEY DUP
    printkey
27 = UNTIL
;