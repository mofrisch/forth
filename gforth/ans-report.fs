\ report words used from the various wordsets

\ Authors: Anton Ertl, Bernd Paysan, Jens Wilke
\ Copyright (C) 1996,1998,1999,2003,2005,2006,2007,2009,2012,2013,2014,2015,2017,2019 Free Software Foundation, Inc.

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


\ Use this program like this:
\ include it, then the program you want to check; then say print-ans-report
\ e.g., start it with
\  gforth ans-report.fs myprog.fs -e "print-ans-report bye"

\ Caveats:

\ Note that this program just checks which words are used, not whether
\ they are used in an ANS Forth conforming way!

\ Some words are defined in several wordsets in the standard. This
\ program reports them for only one of the wordsets, and not
\ necessarily the one you expect.


\ This program uses Gforth internals and won't be easy to port
\ to other systems.

\ !! ignore struct-voc stuff (dummy, [then] etc.).

vocabulary ans-report-words ans-report-words definitions

: wordset ( "name" -- )
    latestxt >body
    create
    0 , \ link to next wordset
    0 0 2, \ array of nfas
    ( lastlinkp ) latest swap ! \ set link ptr of last wordset
;

wordlist constant wordsets wordsets set-current
create CORE 0 , 0 0 2,
wordset CORE-EXT
wordset CORE-EXT-obsolescent
wordset CORE-EXT-2012
wordset BLOCK
wordset BLOCK-EXT
wordset DOUBLE
wordset DOUBLE-EXT
wordset DOUBLE-EXT-2012
wordset EXCEPTION
wordset EXCEPTION-EXT
wordset FACILITY
wordset FACILITY-EXT
wordset FACILITY-EXT-2012
wordset FILE
wordset FILE-EXT
wordset FILE-EXT-2012
wordset FLOAT
wordset FLOAT-EXT
wordset FLOAT-EXT-2012
wordset LOCAL
wordset LOCAL-EXT
wordset LOCAL-EXT-2012
wordset MEMORY
wordset SEARCH
wordset SEARCH-EXT
wordset STRING
wordset STRING-EXT-2012
wordset TOOLS
wordset TOOLS-EXT
wordset TOOLS-EXT-2012
wordset TOOLS-EXT-obsolescent
wordset XCHAR-2012
wordset XCHAR-EXT-2012

wordset non-ANS

ans-report-words definitions

: standardword { D: wordname D: wordset -- }
    wordname find-name
    ?dup-if
	sp@ cell nextname create drop
	wordset wordsets search-wordlist 0= abort" wordset unknown" ,
    endif ;
    
: answord ( "name wordset pronounciation" -- )
    \ check the documentation of an ans word
    parse-name parse-name parse-name 2drop standardword ;

: xword ( "name wordset" )
    parse-name parse-name standardword ;

table constant answords answords set-current
warnings @ warnings off
include ./answords.fs
include ./2012words.fs
warnings !
ans-report-words definitions

: add-unless-present ( nt addr -- )
    \ add nt to array described by addr 2@, unless it contains nt
    >r ( nt )
    r@ 2@ bounds
    u+do ( nt )
	dup i @ =
	if
	    drop rdrop UNLOOP EXIT
	endif
	cell
    +loop
    r@ 2@ cell extend-mem r> 2!
    ( nt addr ) ! ;


: note-name ( nt -- )
    \ remember name in the appropriate wordset, unless already there
    \ or the word is defined in the checked program
    dup [ here ]L forthstart within
    [IFDEF] locals-buffer
	over locals-buffer dup 1000 + within or  \ or a local
    [THEN]
    if
	drop EXIT
    endif
    sp@ cell answords search-wordlist ( nt xt true | nt false )
    if \ ans word
	>body @ >body
    else \ non-ans word
	[ get-order wordsets swap 1+ set-order ] non-ANS [ previous ]
    endif
    ( nt wordset ) cell+ add-unless-present ;

: find&note-name ( c-addr u -- nt/0 )
    \ find-name replacement. Takes note of all the words used.
    lookup @ find-name-in dup
    if
	dup note-name
    endif ;

: print-names ( endaddr startaddr -- )
    space 1 -rot
    u+do ( pos )
        i @ name>string nip 1+ { len }
        len + ( newpos )
        dup cols 4 - >= if
            cr space drop len 1+
        endif
        i @ .name
    cell +loop
    drop ;

forth definitions
ans-report-words

: print-ans-report ( -- )
    cr
    ." The program uses the following words" cr
    [ get-order wordsets swap 1+ set-order ] [(')] core [ previous ]
    begin
	dup 0<>
    while
	dup >r name>int >body dup @ swap cell+ 2@ dup
	if
	    ." from " r@ .name ." :" cr
	    bounds print-names cr
	else
	    2drop
	endif
	rdrop
    repeat
    drop ;

: hide ( "name" -- )
    \ replace the last character of the name of word "name" with a
    \ blank, so it won't be found
    bl parse-name lookup @ find-name-in name>string + 1- c! ;

\ the following sequence "' replace-word forth execute" is necessary
\ to restore the default search order without effect on the "used
\ word" lists
' find&note-name ' find-name ' replace-word forth execute
