\ first.fs
\ Some exercises

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.
\ Version 0.0.0

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
    




