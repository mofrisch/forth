: letter-I ( char -- f )
    DUP [CHAR] I = SWAP [CHAR] i = OR
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