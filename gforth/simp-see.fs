\ simple-minded see (good for seeing what the compiler produces)

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 2001,2003,2007,2014,2017,2019 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation, either version 3
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

require see.fs

get-current also see-voc definitions

: xt-range ( xt -- addr1 addr2 )
    \ get the range of threaded-code addresses for (possibly deferred)
    \ colon def xt
    begin
	dup >definer dodefer: = while
	    cr ." defer " dup >name id.
	    defer@ repeat
    dup >definer docol: = if
	>body dup next-head
    else
	cr ." not a colon definition" dup \ ensure 0 iterations
    then ;
	    
: simple-see-word { addr -- }
    xpos off addr hex. addr cell+ addr @ .word drop ;

: simple-see-range ( addr1 addr2 -- ) \ gforth
    swap u+do
	cr i simple-see-word
    cell +loop ;

: see-code-next-inline { addr1 addr2 -- addr3 }
    \ decompile starting at addr1 until an inlined primitive is found,
    \ or addr2 is reached; addr3 is addr2 or the next inlined
    \ primitive
    addr1 begin { addr }
        addr addr2 u< while
            addr @ dup decompile-prim = while
                addr cr simple-see-word
                addr cell+
        repeat then
    addr ;

: see-code-range { addr1 addr2 -- } \ gforth
    cr addr1 begin { a }
        a simple-see-word
        a cell+ addr2 see-code-next-inline { b }
        b addr2 u< while
            a @ b @ over - discode
            b
    repeat ;

set-current

: xt-simple-see ( xt -- ) \ gforth
    \G a simple decompiler that's closer to @code{dump} than @code{see}.
    \ !! at the moment NEXT-HEAD is a little too optimistic (see
    \ comment in HEAD?)
    xt-range simple-see-range ;

: simple-see ( "name" -- ) \ gforth
    \G a simple decompiler that's closer to @code{dump} than @code{see}.
    \ !! at the moment NEXT-HEAD is a little too optimistic (see
    \ comment in HEAD?)
    ' xt-simple-see ;

: xt-see-code ( xt -- ) \ gforth
\G like @code{simple-see}, but also shows the dynamic native code for
\G the inlined primitives (except for the last).
    xt-range see-code-range ;

: see-code ( "name" -- ) \ gforth
\G like @code{simple-see}, but also shows the dynamic native code for
\G the inlined primitives (except for the last).
    ' xt-see-code ;
    
previous