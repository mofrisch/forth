
: upper ( char -- char )
    DUP [CHAR] i [char] m 1 + WITHIN IF 32 - THENi
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