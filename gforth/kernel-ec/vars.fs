\ VARS.FS      Kernal variables

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 1995,1996,1997,1998,2000,2003,2006,2007,2011,2012,2015,2019 Free Software Foundation, Inc.

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

hex \ everything now hex!                               11may93jaw

\ important constants                                  17dec92py

\ dpANS6 (sect 3.1.3.1) says 
\ "a true flag ... [is] a single-cell value with all bits set"
\ better definition: 0 0= constant true ( no dependence on 2's compl)
 -1 Constant true ( -- f ) \ core-ext
\G @code{Constant} -- @i{f} is a cell with all bits set.
\ see starts looking for primitives after this word!

  0 Constant false ( -- f ) \ core-ext
\G @code{Constant} -- @i{f} is a cell with all bits clear.

[IFUNDEF] cell 
1 cells Constant cell ( -- u ) \ gforth
\G @code{Constant} -- @code{1 cells}
[THEN]

has? floating [IF]
1 floats Constant float ( -- u ) \ gforth
\G @code{Constant} -- the number of address units corresponding to a floating-point number.
[THEN]

20 Constant bl ( -- c-char ) \ core b-l
\G @i{c-char} is the character value for a space.
\ used by docon:, must be constant

has? EC [IF] 20 cells [ELSE] FF [THEN] Constant /line

has? file [IF]
40 Value c/l
10 Value l/s
400 Value chars/block
[THEN]

20 8 2* cells + 2 + cell+ constant word-pno-size ( -- u )

84 constant pad-minsize ( -- u )

$400 Value def#tib
\G default size of terminal input buffer. Default size is 1K

\ that's enough so long

\ User variables                                       13feb93py

\ initialized by COLD

has? no-userspace 0= [IF]
Create main-task  has? OS [IF] 100 [ELSE] 40 [THEN] cells dup allot

\ set user-pointer from cross-compiler right
main-task 
UNLOCK swap region user-region user-region setup-region LOCK

Variable udp ( -- a-addr ) \ gforth
\G user area size

AUser next-task        main-task next-task !
AUser prev-task        main-task prev-task !
AUser save-task        0 save-task !
[THEN]
AUser sp0 ( -- a-addr ) \ gforth
\G @code{User} variable -- initial value of the data stack pointer.
\ sp0 is used by douser:, must be user
\    ' sp0 Alias s0 ( -- a-addr ) \ gforth
\G OBSOLETE alias of @code{sp0}

AUser rp0 ( -- a-addr ) \ gforth
\G @code{User} variable -- initial value of the return stack pointer.
\    ' rp0 Alias r0 ( -- a-addr ) \ gforth
\G OBSOLETE alias of @code{rp0}

AUser throw-entry  \ pointer to task-specific signal handler

AUser handler	\ pointer to last throw frame
\ AUser output
\ AUser input

AUser errorhandler

AUser "error            0 "error !

[IFUNDEF] #tib		\ in ec-Version we may define this ourself
    User tibstack		\ saves >tib in execute
    User >tib		\ pointer to terminal input buffer
    User #tib ( -- a-addr ) \ core-ext number-t-i-b
    \G @code{User} variable -- @i{a-addr} is the address of a cell containing
	\G the number of characters in the terminal input buffer.
    \G OBSOLESCENT: @code{source} superceeds the function of this word.
	
    User >in ( -- a-addr ) \ core to-in
    \G @code{User} variable -- @i{a-addr} is the address of a cell containing the
    \G char offset from the start of the input buffer to the start of the
    \G parse area.
    0 >in ! \ char number currently processed in tib
[THEN]

User base ( -- a-addr ) \ core
\G @code{User} variable -- @i{a-addr} is the address of a cell that
\G stores the number base used by default for number conversion during
\G input and output.  Don't store to @code{base}, use
\G @code{base-execute} instead.
                       A base !
User dpl ( -- a-addr ) \ gforth
\G @code{User} variable -- @i{a-addr} is the address of a cell that stores the 		
\G position of the decimal point in the most recent numeric conversion.
\G Initialised to -1. After the conversion of a number containing no
\G decimal point, @code{dpl} is -1. After the conversion of @code{2.} it holds
\G 0. After the conversion of 234123.9 it contains 1, and so forth.
-1 dpl !

User dp-char ( -- a-addr ) \ VFX
\G @code{User} variable -- @i{a-addr} is the address of a cell that stores the
\G decimal point character for double number conversion
'.' dp-char !

User fp-char ( -- a-addr ) \ VFX
\G @code{User} variable -- @i{a-addr} is the address of a cell that stores the
\G decimal point character for floating point number conversion
'.' fp-char !

User state ( -- a-addr ) \ core,tools-ext
\G @code{User} variable -- @i{a-addr} is the address of a cell
\G containing the compilation state flag. 0 => interpreting, -1 =>
\G compiling.  A program shall not directly alter the value of
\G @code{state}. The following Standard words alter the value in
\G @code{state}: @code{:} (colon) @code{;} (semicolon) @code{abort}
\G @code{quit} @code{:noname} @code{[} (left-bracket) @code{]}
\G (right-bracket) @code{;code}. Don't use @code{state}! For an
\G alternative see @ref{Interpretation and Compilation Semantics}.
\ Recommended reading: @cite{@code{State}-smartness--Why it is evil
\ and how to exorcise it},
\ @url{http://www.complang.tuwien.ac.at/papers/ertl98.ps.gz}; short
\ version: Don't use @code{state}!
0 state !

AUser normal-dp		\ the usual dictionary pointer
AUser dpp		normal-dp dpp !
			\ the pointer to the current dictionary pointer
                        \ ist reset to normal-dp on (doerror)
                        \  (i.e. any throw caught by quit)
AUser LastCFA
AUser Last

has? flash [IF]
    AUser flash-dp
    : rom  flash-dp dpp ! ;
    : ram  normal-dp dpp ! ;
[THEN]

User max-name-length \ maximum length of all names defined yet
32 max-name-length !
