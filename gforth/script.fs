\ Authors: Bernd Paysan, Anton Ertl
\ Copyright (C) 2001,2003,2007,2013,2014,2015,2016,2017,2018,2019 Free Software Foundation, Inc.

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

\ scripting extensions

: >system ( addr u -- ) cr system ;
: system, slit, postpone >system ;
' >system ' system, ' slit, rectype: rectype-eval

: rec-shell ( addr u -- addr u' rectype-eval | rectype-null )
    \G evaluate string + rest of command line
    over source drop = IF
	drop source drop - >in ! source >in @ /string dup >in +!
	rectype-eval
    ELSE  2drop rectype-null  THEN ;
' rec-shell get-recognizers 1+ set-recognizers

User sh$  cell uallot drop
: sh-get ( addr u -- addr' u' )
    \G open command addr u, and read in the result
    sh$ free-mem-var
    r/o open-pipe throw dup >r slurp-fid
    r> close-pipe throw to $? 2dup sh$ 2! ;

:noname '`' parse sh-get ;
:noname '`' parse postpone SLiteral postpone sh-get ;
interpret/compile: s` ( "eval-string" -- addr u )

[IFDEF] thread-init
    :noname defers thread-init #0. sh$ 2! ; is thread-init
[THEN]
