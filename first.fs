: sqr ( u -- u )
    dup * * ;

: fn ( F: r -- r)
    fdup f* 2e f- ;

: fn' ( F: r -- r)
    2e f* ;

: next-iteration ( F: x1 -- x2 )
    \ x2 = x1 - f(x1) / f'(x1)
    fdup fdup fn 
    fswap fn' 
    f/ f- ;

: near ( r1 r2 -- f )
    f- fabs 1e-6 f< ;

: newton ( F: start-value -- estimation )
    page 
    10 0 DO 
    	fdup f. cr 
    	next-iteration
    LOOP ; 

: nwt2 ( F: r -- r )
    
;
    




