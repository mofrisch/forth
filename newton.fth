: fn ( r -- r )
fdup f* 2e f-
;

: fn' ( r -- r )
2e f*
;

: fnext ( r -- r )
fdup fdup fn fswap fn' f/ f-
;

: fnear ( r1 r2 -- f )
f- fabs 1e-12 f<
;

: fnew ( r -- r )
begin 
    fdup fnext fswap fover
fnear until
;
