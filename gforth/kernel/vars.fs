\ VARS.FS      Kernal variables

\ Authors: Anton Ertl, Bernd Paysan, Neal Crook, Jens Wilke
\ Copyright (C) 1995,1996,1997,1998,2000,2003,2006,2007,2011,2012,2013,2014,2015,2016,2017,2018,2019 Free Software Foundation, Inc.

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

\ important definers

: uvalue-to ( n uvalue-xt -- )
    \g uvalue-to is the to-method for uvalues
    !!?addr!! >body @ next-task +  !-table to-!exec ;
opt: ( uvalue-xt to-xt -- )
    ?fold-to !!?addr!! >body @ postpone useraddr , !-table to-!, ;
: u-compile, ( xt -- )  >body @ postpone user@ , ;

: (UValue) ( "name" -- )
    \G Define a per-thread value
    Create cell uallot ,
  DOES> @ next-task + @ ;
: UValue ( "name" -- )
    (UValue)
    ['] uvalue-to set-to
    ['] u-compile, set-optimizer ;

: 2Constant ( w1 w2 "name" -- ) \ double two-constant
    Create ( w1 w2 "name" -- )
    2,
  DOES> ( -- w1 w2 )
    2@ ;

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
Create main-task  has? OS [IF] $100 [ELSE] $40 [THEN] cells dup allot

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

AUser rp0 ( -- a-addr ) \ gforth
\G @code{User} variable -- initial value of the return stack pointer.

has? floating [IF]
AUser fp0 ( -- a-addr ) \ gforth
\G @code{User} variable -- initial value of the floating-point stack pointer.
\ no f0, because this leads to unexpected results when using hex
[THEN]

has? glocals [IF]
AUser lp0 ( -- a-addr ) \ gforth
\G @code{User} variable -- initial value of the locals stack pointer.
[THEN]

AUser throw-entry  \ pointer to task-specific signal handler

: handler ( -- addr ) sps@ cell+ ;	\ pointer to last throw frame
: first-throw ( -- addr ) sps@ [ 2 cells ] Literal + ; \ contains true if the next throw is the first throw
: wraphandler ( -- addr ) sps@ [ 3 cells ] Literal + ; \ wrap handler, experimental

has? backtrace [IF]
AUser backtrace-rp0 \ rp at last call of interpret
[THEN]
\ AUser output
\ AUser input

AUser errorhandler

AUser "error            0 "error !

AUser holdbufptr
here word-pno-size chars allot dup holdbufptr !
word-pno-size chars +
: holdbuf ( -- addr ) holdbufptr @ ;
: holdbuf-end   holdbuf word-pno-size chars + ;
AUser holdptr dup holdptr !
AUser holdend     holdend !

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

User >num-state ( -- a-addr ) \ Gforth
\G Internal state of the number conversion
0 >num-state !

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

UValue dp               \ initialized at boot time with normal-dp
			\ the pointer to the current dictionary pointer
                        \ ist reset to normal-dp on (doerror)
                        \  (i.e. any throw caught by quit)
AUser Last

Variable warnings ( -- addr ) \ gforth
\G set warnings level to
\G @table @code
\G @item 0
\G turns warnings off
\G @item -1
\G turns normal warnings on
\G @item -2
\G turns beginner warnngs on
\G @item -3
\G pedantic warnings on
\G @item -4
\G turns warnings into errors (including beginner warnings)
\G @end table
G -2 warnings T ! \ default to -Won
