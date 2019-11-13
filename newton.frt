: fn ( r -- r )
fdup f* 2e f-
;

: fn' ( r -- r )
2e f*
;

: next ( r -- r )
fdup fdup fn fswap fn' f/ f-
;

: near ( r1 r2 -- f )
f- fabs 1e-12 f<
;

: fnew ( r -- r )
begin 
    fdup next ( x1 x2 )
    fswap fover ( x2 x1 x2 )
near until
;


