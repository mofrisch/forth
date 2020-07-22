\ display words in reverse

\ Author: Bernd Paysan
\ Copyright (C) 2017,2019 Free Software Foundation, Inc.

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

[IFDEF] large-wordlists
    \ solution for wordlists greater than the stack
    Variable words[]

    : wid>words[] ( wid -- )
	[: words[] >stack true ;] swap traverse-wordlist ;
    : .words[] ( -- )
	cr 0  words[] $@ bounds cell- swap cell- U-DO
	    I @ .word
	cell -LOOP  drop ;

    0 warnings !@
    : wordlist-words ( wid -- )  wid>words[] .words[] words[] $free ;
[ELSE]
    \ solution for smaller wordlists
    : wid@ ( wid -- nt1 .. ntn n )
	depth >r ['] true swap traverse-wordlist depth r> - 1+ ;
    : .wids ( nt1 .. ntn n ) cr 0 swap 0 ?DO swap .word LOOP drop ;
    0 warnings !@
    : wordlist-words ( wid -- )  wid@ .wids ;
[THEN]
: words ( -- ) context @ wordlist-words ;
warnings !
