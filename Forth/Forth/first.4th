
\ a line comment
: first 1 . ;

: <> ( n n -- f )
    = invert ;

: ?dup dup if dup then ;

: nip swap drop ;

: tuck swap over ;
