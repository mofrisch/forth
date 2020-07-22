\ require.fs

\ Authors: Anton Ertl, Bernd Paysan, Neal Crook, Jens Wilke
\ Copyright (C) 1995,1996,1997,1998,2000,2003,2006,2007,2010,2012,2013,2016,2017,2019 Free Software Foundation, Inc.

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

\ Now: Kernel Module, Reloadable

$[]Variable included-files

: sourcefilename ( -- c-addr u ) \ gforth
    \G The name of the source file which is currently the input
    \G source.  The result is valid only while the file is being
    \G loaded.  If the current input source is no (stream) file, the
    \G result is undefined.  In Gforth, the result is valid during the
    \G whole session (but not across @code{savesystem} etc.).
    loadfilename# @ included-filename[] ;
: included-filename[] ( index -- c-addr u ) \ gforth
    \G convert a file name index to a file name
    dup -3 = IF  drop s" *a block*"           EXIT  THEN
    dup -2 = IF  drop s" *evaluated string*"  EXIT  THEN
    dup 0<   IF  drop s" *the terminal*"      EXIT  THEN
    included-files $@ rot cells safe/string
    IF  $@  ELSE  drop  s" *unknown file*"  THEN ;

: sourceline# ( -- u ) \ gforth		sourceline-number
    \G The line number of the line that is currently being interpreted
    \G from a (stream) file. The first line has the number 1. If the
    \G current input source is not a (stream) file, the result is
    \G undefined.
    loadline @ ;

: str>loadfilename# ( addr u -- n )
    included-files $@ bounds ?do ( addr u )
	2dup I $@ str= if
	    2drop I included-files $@ drop - cell/ unloop exit
	endif
    cell +loop
    2dup s" *a block*"          str= IF  2drop -3  EXIT  THEN
    2dup s" *evaluated string*" str= IF  2drop -2  EXIT  THEN
    2drop -1 ;

: included? ( c-addr u -- f ) \ gforth
    \G True only if the file @var{c-addr u} is in the list of earlier
    \G included files. If the file has been loaded, it may have been
    \G specified as, say, @file{foo.fs} and found somewhere on the
    \G Forth search path. To return @code{true} from @code{included?},
    \G you must specify the exact path to the file, even if that is
    \G @file{./foo.fs}
    str>loadfilename# 0>= ;

: add-included-file ( c-addr u -- ) \ gforth
    \G add name c-addr u to included-files
    $make included-files >stack ;

: included1 ( i*x file-id c-addr u -- j*x ) \ gforth
\G Include the file file-id with the name given by @var{c-addr u}.
    add-included-file  included-files $@ + cell-
    $@ ['] read-loop execute-parsing-named-file ;

Defer >included ( c-addr1 u1 -- fd c-addr2 u2 wior )
' open-fpath-file is >included
Defer >include ( c-addr1 u1 -- c-addr2 u2 )
' noop is >include

: included ( i*x c-addr u -- j*x ) \ file
    \G @code{include-file} the file whose name is given by the string
    \G @var{c-addr u}.
    >included throw included1 ;

: required ( i*x addr u -- i*x ) \ gforth
    \G @code{include-file} the file with the name given by @var{addr
    \G u}, if it is not @code{included} (or @code{required})
    \G already. Currently this works by comparing the name of the file
    \G (with path) against the names of earlier included files.
    \ however, it may be better to fstat the file,
    \ and compare the device and inode. The advantages would be: no
    \ problems with several paths to the same file (e.g., due to
    \ links) and we would catch files included with include-file and
    \ write a require-file.
    >included throw 2dup included?
    if
	2drop close-file throw
    else
	included1
    then ;

\ INCLUDE                                               9may93jaw

: include  ( ... "file" -- ... ) \ gforth
    \G @code{include-file} the file @var{file}.
    ?parse-name >include included ;

: require  ( ... "file" -- ... ) \ gforth
    \G @code{include-file} @var{file} only if it is not included already.
    ?parse-name >include required ;

\ : \I
\   here 
\   0 word count
\   string,
\   needsrcs^ @ ! ;

\ : .included ( -- ) \ gforth
\     \G list the names of the files that have been @code{included}
\   cr
\   needs^ @
\   BEGIN		dup 
\   WHILE		dup cell+ count type cr
\ 		5 spaces
\ 		dup cell+ count + aligned
\ 		@ dup IF count type ELSE drop THEN cr
\ 		@
\   REPEAT
\   drop ;

: .strings ( addr u -- ) \ gforth
    \G list the strings from an array of string descriptors at addr
    \G with u entries, one per line.
    2* cells bounds ?DO
	cr I 2@ type 2 cells +LOOP ;

: .included ( -- ) \ gforth
    \G list the names of the files that have been @code{included}
    included-files $@ bounds ?DO
	cr I $@ type
    cell +LOOP ;
