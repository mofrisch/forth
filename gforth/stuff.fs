\ miscelleneous words

\ Authors: Anton Ertl, Bernd Paysan, Neal Crook
\ Copyright (C) 1996,1997,1998,2000,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019 Free Software Foundation, Inc.

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

: save-mem-dict ( addr1 u -- addr2 u )
    here swap dup allot ( addr1 addr2 u )
    2dup 2>r move 2r> ;

require glocals.fs

' require alias needs ( ... "name" -- ... ) \ gforth
\G An alias for @code{require}; exists on other systems (e.g., Win32Forth).
\ needs is an F-PC name. we will probably switch to 'needs' in the future

\ a little more compiler security

\ currently not used by Gforth, but maybe by add-ons e.g., the 486asm
AUser CSP

: !CSP ( -- )
    sp@ csp ! ;

: ?CSP ( -- )
    sp@ csp @ <> -22 and throw ;

\ DMIN and DMAX

: dmin ( d1 d2 -- d ) \ double d-min
    2over 2over d> IF  2swap  THEN 2drop ;


: dmax ( d1 d2 -- d ) \ double d-max
    2over 2over d< IF  2swap  THEN 2drop ;

\ shell commands

UValue $? ( -- n ) \ gforth dollar-question
\G @code{Value} -- the exit status returned by the most recently executed
\G @code{system} command.

: system ( c-addr u -- ) \ gforth
\G Pass the string specified by @var{c-addr u} to the host operating
\G system for execution in a sub-shell.  The value of the environment
\G variable @code{GFORTHSYSTEMPREFIX} (or its default value) is
\G prepended to the string (mainly to support using @code{command.com}
\G as shell in Windows instead of whatever shell Cygwin uses by
\G default; @pxref{Environment variables}).
    (system) throw TO $? ;

: sh ( "..." -- ) \ gforth
\G Parse a string and use @code{system} to pass it to the host
\G operating system for execution in a sub-shell.
    '# parse cr system ;

\ stuff

: ]L ( compilation: n -- ; run-time: -- n ) \ gforth
    \G equivalent to @code{] literal}
    ] postpone literal ;

[ifundef] in-dictionary?
: in-dictionary? ( x -- f )
    forthstart dictionary-end within ;
[endif]

: in-return-stack? ( addr -- f )
    rp0 @ [ forthstart 7 cells + ]L @ - $FFF + -$1000 and rp0 @ within ;

\ const-does>

: compile-literals ( w*u u -- ; run-time: -- w*u ) recursive
    \ compile u literals, starting with the bottommost one
    ?dup-if
	swap >r 1- compile-literals
	r> POSTPONE literal
    endif ;

: compile-fliterals ( r*u u -- ; run-time: -- w*u ) recursive
    \ compile u fliterals, starting with the bottommost one
    ?dup-if
	{ F: r } 1- compile-fliterals
	r POSTPONE fliteral
    endif ;

: (const-does>) ( w*uw r*ur uw ur target "name" -- )
    \ define a colon definition "name" containing w*uw r*ur as
    \ literals and a call to target.
    { uw ur target }
    header docol: cfa, \ start colon def without stack junk
    ur compile-fliterals uw compile-literals
    target compile, POSTPONE exit reveal ;

: const-does> ( run-time: w*uw r*ur uw ur "name" -- ) \ gforth
    \G Defines @var{name} and returns.
    \G  
    \G @var{name} execution: pushes @var{w*uw r*ur}, then performs the
    \G code following the @code{const-does>}.
    here >r 0 POSTPONE literal
    POSTPONE (const-does>)
    POSTPONE ;
    noname : POSTPONE rdrop
    latestnt r> cell+ ! \ patch the literal
; immediate

\ !! rewrite slurp-file using slurp-fid
: slurp-file ( c-addr1 u1 -- c-addr2 u2 ) \ gforth
    \G @var{c-addr1 u1} is the filename, @var{c-addr2 u2} is the file's contents
    r/o bin open-file throw >r
    r@ file-size throw abort" file too large"
    dup allocate throw swap
    2dup r@ read-file throw over <> abort" could not read whole file"
    r> close-file throw ;

: slurp-fid ( fid -- addr u ) \ gforth
\G @var{addr u} is the content of the file @var{fid}
    { fid }
    0 0 begin ( awhole uwhole )
	dup 1024 + dup >r extend-mem ( anew awhole uwhole R: unew )
	rot r@ fid read-file throw ( awhole uwhole uread R: unew )
	r> 2dup =
    while ( awhole uwhole uread unew )
	2drop
    repeat
    - + dup >r resize throw r> ;

\ file>path

: file>path ( addr1 u1 path-addr -- addr2 u2 ) \ gforth
    open-path-file throw rot close-file throw ;

: file>fpath ( addr1 u1 -- addr2 u2 ) \ gforth
    fpath file>path ;

\ ]] ... [[

: [[ ( -- ) \ gforth left-bracket-bracket
\G switch from postpone state to compile state
    \ this is only a marker; it is never really interpreted
    compile-only-error ; immediate

[ifdef] compiler1
: compile-literal ( n -- )
    postpone literal ;

: compile-compile-literal ( n -- )
    compile-literal postpone compile-literal ;

: compile-2literal ( n1 n2 -- )
    postpone 2literal ;

: compile-compile-2literal ( n1 n2 -- )
    compile-2literal postpone compile-2literal ;

: postponer1 ( c-addr u -- ... xt )
    2dup find-name
    [ifdef] run-prelude run-prelude [then]
    dup if ( c-addr u nt )
	nip nip name>comp
	2dup [comp'] [[ d= if
	    2drop ['] compiler1 is parser1 ['] noop
	else
	    ['] postpone,
	endif
    else
	drop
	2dup 2>r snumber? dup if
	    0> IF
		['] compile-compile-2literal
            ELSE
                ['] compile-compile-literal
	    THEN
	    2rdrop
	ELSE
	    drop 2r> no.extensions
	THEN
    then ;

: ]] ( -- ) \ gforth right-bracket-bracket
    \G switch into postpone state
    ['] postponer1 is parser1 state on ; immediate restrict
[then]

[ifdef] compiler-r
: postponer-r ( addr u -- ... xt )
    forth-recognizer recognize over
    [ s" [[" find-name ] Literal =
    IF  2drop [comp'] ] drop ELSE  ['] >postpone  THEN ;

: ]] ( -- ) \ gforth right-bracket-bracket
    \G switch into postpone state
    ['] postponer-r is parser1 state on ; immediate restrict
[then]

\ interp

: >interp ( .. rectype -- )
    dup >r rectype>post execute r> rectype>int compile, ;
: [interp] ( "name" -- )
    \G Compiles the interpretation semantics of @i{name}, see @code{postpone}.
    parse-name forth-recognizer recognize >interp ; immediate compile-only

\ f.rdp

: push-right ( c-addr u1 u2 cfill -- )
    \ move string at c-addr u1 right by u2 chars (without exceeding
    \ the original bound); fill the gap with cfill
    >r over min dup >r rot dup >r ( u1 u2 c-addr R: cfill u2 c-addr )
    dup 2swap /string cmove>
    r> r> r> fill ;

: f>buf-rdp-try { f: rf c-addr ur nd up um1 -- um2 }
    \ um1 is the mantissa length to try, um2 is the actual mantissa length
    c-addr ur um1 /string '0 fill
    rf c-addr um1 represent if { nexp fsign }
	nd nexp + up >= up 0= or
	ur nd - 1- dup { beforep } fsign + nexp 0 max >= and if
	    \ fixed-point notation
	    c-addr ur beforep nexp - dup { befored } '0 push-right
            befored 1+ ur >= if \ <=1 digit left, will be pushed out by '.'
                rf fabs f2* 0.1e nd s>d d>f f** f> if \ round last digit
                    '1 c-addr befored + 1- c!
                endif
            endif
	    c-addr beforep 1- befored min dup { beforez } 0 max bl fill
	    fsign if
		'- c-addr beforez 1- 0 max + c!
	    endif
	    c-addr ur beforep /string 1 '. push-right
	    nexp nd +
	else \ exponential notation
	    c-addr ur 1 /string 1 '. push-right
	    fsign if
		c-addr ur 1 '- push-right
	    endif
	    nexp 1- s>d tuck dabs <<# #s rot sign 'E hold #> { explen }
	    ur explen - 1- fsign + { mantlen }
	    mantlen 0< if \ exponent too large
		drop c-addr ur '* fill
	    else
		c-addr ur + 0 explen negate /string move
	    endif
	    #>> mantlen
	endif
    else \ inf or nan
        \ don't rely on REPRESENT result
        2drop
        rf f0< if s" -Inf" else rf f0>= if s" Inf" else s" NaN" endif endif
        c-addr ur rot umin dup >r move c-addr ur r> /string blank
        ur
    endif
    1 max ur min ;

: f>buf-rdp ( rf c-addr +nr +nd +np -- ) \ gforth
\G Convert @i{rf} into a string at @i{c-addr nr}.  The conversion
\G rules and the meanings of @i{nr nd np} are the same as for
\G @code{f.rdp}.
    \ first, get the mantissa length, then convert for real.  The
    \ mantissa length is wrong in a few cases because of different
    \ rounding; In most cases this does not matter, because the
    \ mantissa is shorter than expected and the final digits are 0;
    \ but in a few cases the mantissa gets longer.  Then it is
    \ conceivable that you will see a result that is rounded too much.
    \ However, I have not been able to construct an example where this
    \ leads to an unexpected result.
    swap 0 max swap 0 max
    fdup 2over 2over 2 pick f>buf-rdp-try f>buf-rdp-try drop ;

: f>str-rdp ( rf +nr +nd +np -- c-addr nr ) \ gforth
\G Convert @i{rf} into a string at @i{c-addr nr}.  The conversion
\G rules and the meanings of @i{nr +nd np} are the same as for
\G @code{f.rdp}.  The result in in the pictured numeric output buffer
\G and will be destroyed by anything destroying that buffer.
    rot holdptr @ 1- 0 rot negate /string ( rf +nd np c-addr nr )
    over holdbuf u< -&17 and throw
    2tuck 2>r f>buf-rdp 2r> ;

: f.rdp ( rf +nr +nd +np -- ) \ gforth
\G Print float @i{rf} formatted.  The total width of the output is
\G @i{nr}.  For fixed-point notation, the number of digits after the
\G decimal point is @i{+nd} and the minimum number of significant
\G digits is @i{np}.  @code{Set-precision} has no effect on
\G @code{f.rdp}.  Fixed-point notation is used if the number of
\G siginicant digits would be at least @i{np} and if the number of
\G digits before the decimal point would fit.  If fixed-point notation
\G is not used, exponential notation is used, and if that does not
\G fit, asterisks are printed.  We recommend using @i{nr}>=7 to avoid
\G the risk of numbers not fitting at all.  We recommend
\G @i{nr}>=@i{np}+5 to avoid cases where @code{f.rdp} switches to
\G exponential notation because fixed-point notation would have too
\G few significant digits, yet exponential notation offers fewer
\G significant digits.  We recommend @i{nr}>=@i{nd}+2, if you want to
\G have fixed-point notation for some numbers; the smaller the value
\G of @i{np}, the more cases are shown in fixed-point notation (cases
\G where few or no significant digits remain in fixed-point notation).
\G We recommend @i{np}>@i{nr}, if you want to have exponential
\G notation for all numbers.
    f>str-rdp type ;

0 [if]
: testx ( rf ur nd up -- )
    '| emit f.rdp ;

: test ( -- )
    -0.123456789123456789e-20
    40 0 ?do
	cr
	fdup 7 3 1 testx
	fdup 7 3 4 testx
	fdup 7 3 0 testx
	fdup 7 7 1 testx
	fdup 7 5 1 testx
	fdup 7 0 2 testx
	fdup 5 2 1 testx
	fdup 4 2 1 testx
	fdup 18 8 5 testx
	'| emit
	10e f*
    loop ;
[then]

14 Value f.s-precision
\G the field width for f.s output. Other precision details are derived
\G from that value.

: f.s ( -- ) \ gforth f-dot-s
\G Display the number of items on the floating-point stack, followed
\G by a list of the items (but not more than specified by
\G @code{maxdepth-.s}; TOS is the right-most item.
    ." <" fdepth 0 .r ." > " fdepth 0 max maxdepth-.s @ min dup 0 ?DO
	dup i - 1- floats fp@ + f@
	f.s-precision 7 max dup 0 f.rdp space LOOP
    drop ; 

\ new interpret/compile:

: interpret/compile: ( interp-xt comp-xt "name" -- ) \ gforth
    swap alias ,
    ['] i/c>comp set->comp
    ['] no-to set-to
    ['] no-defer@ set-defer@ ;

\ defer stuff

:noname ' defer@ ;
:noname (') name>int defer@, ;
interpret/compile: action-of ( interpretation "name" -- xt; compilation "name" -- ; run-time -- xt ) \ core-ext
\G @i{Xt} is the XT that is currently assigned to @i{name}.

synonym what's action-of ( interpretation "name" -- xt; compilation "name" -- ; run-time -- xt ) \ gforth-obsolete
\G Old name of @code{action-of}


: typewhite ( addr n -- ) \ gforth
\G Like type, but white space is printed instead of the characters.
    \ bounds u+do
    0 max bounds ?do
	i c@ #tab = if \ check for tab
	    #tab
	else
	    bl
	then
	emit
    loop ;

\ w and l stuff

environment-wordlist >order

16 address-unit-bits / 1 max constant /w ( -- u ) \ gforth slash-w
\G address units for a 16-bit value
    
32 address-unit-bits / 1 max constant /l ( -- u ) \ gforth slash-l
\G address units for a 32-bit value

previous

[ifdef] uw@ \ Open firmware names
    ' uw@ alias w@ ( addr -- u )
    ' ul@ alias l@ ( addr -- u )
[ELSE] \ gforth names
    ' w@ alias uw@ ( addr -- u )
    ' l@ alias ul@ ( addr -- u )
[THEN]

[IFDEF] ux@ ' ux@ alias x@ ( addr -- u )
[ELSE] [IFDEF] x@ ' x@ alias ux@ [THEN] [THEN]
[IFDEF] uxd@ ' uxd@ alias xd@ ( addr -- u )
[ELSE] [IFDEF] xd@ ' xd@ alias uxd@ [THEN] [THEN]

1 pad ! pad c@ 1 = [IF] \ little endian
    [IFDEF] w>< synonym wbe w>< [THEN]
    [IFDEF] l>< synonym lbe l>< [THEN]
    [IFDEF] x>< synonym xbe x><
	' noop alias xle immediate
    [THEN]
    [IFDEF] xd>< synonym xdbe xd><
    [ELSE] : xdbe l>< swap l>< ; [THEN]
    ' noop alias xdle immediate
    ' noop alias wle immediate
    ' noop alias lle immediate
[ELSE]
    [IFDEF] w>< synonym wle w>< [THEN]
    [IFDEF] l>< synonym lle l>< [THEN]
    [IFDEF] x>< synonym xle x><
	' noop alias xbe immediate
    [THEN]
    [IFDEF] xd>< synonym xdle xd><
    [ELSE] : xdle l>< swap l>< ; [THEN]
    ' noop alias xdbe immediate
    ' noop alias wbe immediate
    ' noop alias lbe immediate
[THEN]

: w, ( w -- )  here w!  2 allot ;
: l, ( l -- )  here l!  4 allot ;
[IFDEF] x!  : x, ( l -- )  here x!  8 allot ;  [THEN]

: *aligned ( addr n -- addr' )  tuck 1- + swap negate and ;
: *align ( n -- )  here swap *aligned dp ! ;
: walign ( -- )  2 *align ;
: waligned ( addr -- addr' )  2 *aligned ;
: lalign ( -- )  4 *align ;
: laligned ( addr -- addr' )  4 *aligned ;
: xalign ( -- )  8 *align ;
: xaligned ( addr -- addr' )  8 *aligned ;

\ safe output redirection

: outfile-execute ( ... xt file-id -- ... ) \ gforth
    \G execute @i{xt} with the output of @code{type} etc. redirected to
    \G @i{file-id}.
    op-vector @ outfile-id { oldout oldfid } try
	default-out op-vector !
	to outfile-id execute 0
    restore
	oldfid to outfile-id
	oldout op-vector !
    endtry
    throw ;

: infile-execute ( ... xt file-id -- ... ) \ gforth
    \G execute @i{xt} with the input of @code{key} etc. redirected to
    \G @i{file-id}.
    ip-vector @ infile-id { oldin oldfid } try
	default-in ip-vector !
	to infile-id execute 0
    restore
	oldfid to infile-id
	oldin ip-vector !
    endtry
    throw ;

\ safe BASE wrapper

: base-execute ( i*x xt u -- j*x ) \ gforth
    \G execute @i{xt} with the content of @code{BASE} being @i{u}, and
    \G restoring the original @code{BASE} afterwards.
    base @ { oldbase } \ use local, because TRY blocks the return stack
    try
	base ! execute 0
    restore
	oldbase base !
    endtry
    throw ;

: hex.r ( u1 u2 -- )
    ['] u.r #16 base-execute ;

: dump ( addr u -- ) ['] dump $10 base-execute ;
\ wrap dump into base-execute

\ th

: th ( addr1 u -- addr2 )
    cells + ;

\ \\\ - skip to end of file

: \\\ ( -- ) \ gforth
    \G skip remaining source file
    source-id dup 1 -1 within IF
	>r r@ file-size throw r> reposition-file throw
	BEGIN  refill 0= UNTIL  postpone \  THEN ; immediate

\ multiple values to and from return stack

: n>r ( x1 .. xn n -- r:xn..x1 r:n )
    scope r> { n ret }
    0  BEGIN  dup n <  WHILE  swap >r 1+  REPEAT  >r
    ret >r endscope ;
: nr> ( r:xn..x1 r:n -- x1 .. xn n )
    scope r> r> { ret n }
    0  BEGIN  dup n <  WHILE  r> swap 1+  REPEAT
    ret >r endscope ;

\ x:traverse-wordlist words

' name>int alias name>interpret ( nt -- xt|0 )
    \G @i{xt} represents the interpretation semantics @i{nt}; returns
    \G 0 if @i{nt} has no interpretation semantics

' name>comp alias name>compile ( nt -- w xt )
\G @i{w xt} is the compilation token for the word @i{nt}.

\ 2value

: (2to) ( addr -- ) >body 2!-table to-!exec ;
to-opt: ( xt -- ) >body postpone literal 2!-table to-!, ;

: 2Value ( d "name" -- ) \ Forth200x
    Create 2,
    [: >body postpone Literal postpone 2@ ;] set-optimizer
    ['] (2to) set-to
  DOES> 2@ ;

s" help.txt" open-fpath-file throw 2drop slurp-fid save-mem-dict
2>r : basic-help ( -- ) [ 2r> ] 2literal type ;
\G Print some help for the first steps

\ rectype-word and rectype-name

:noname drop execute ;
:noname 0> IF execute ELSE compile, THEN ;
[ifdef] 2lit, ' 2lit, [else] :noname postpone 2literal ; [then]
rectype: rectype-word ( takes xt +/-1, i.e. result of find and search-wordlist )

\ concat recognizers to another recognizer

: rec-sequence ( xt1 .. xtn n "name" -- )
    \G concatenate a stack of recognizers to one recognizer with the
    \G name @var{"name"}.  @var{xtn} is tried first, @{xt1} last, just
    \G like on the recognizer stack
    n>r : nr> ]] 2>r [[ 0 ?DO
	]] 2r@ [[ compile,
	]] dup rectype-null <> IF 2rdrop EXIT THEN drop [[
    LOOP ]] 2rdrop ; [[ ;

\ growing buffers that need not be full

struct
    cell% 0 * field buffer-descriptor \ addr u
    cell% field buffer-length
    cell% field buffer-address
    cell% field buffer-maxlength \ >=length
end-struct buffer%

: init-buffer ( addr -- )
    buffer% %size erase ;

: adjust-buffer ( u addr -- )
    \G adjust buffer% at addr to length u
    \ this may grow the allocated area, but never shrinks it
    dup >r buffer-maxlength @ over < if ( u )
	r@ buffer-address @ over resize throw r@ buffer-address !
	dup r@ buffer-maxlength ! then
    r> buffer-length ! ;

\ traverse directory

: try-read-dir { buf handle -- n flag }
    BEGIN  buf $@ handle read-dir >r r@  WHILE
	    over buf $@len = over and  WHILE
		buf $@len 3 cells + 2* buf $!len
		rdrop 2drop  REPEAT  buf $free  r> throw  EXIT
    THEN  rdrop ;

: traverse-dir ( addr u xt -- )
    0 { xt w^ buf } open-dir throw { handle }
    [ $100 6 cells - ]L buf $!len
    BEGIN  buf handle try-read-dir  WHILE
	    buf $@ drop swap xt execute  REPEAT
    buf $free  handle close-dir throw ;

: traverse-matched-dir ( addrdir u1 addrmatch u2 xt -- )
    0 { d: match xt w^ buf } open-dir throw { handle }
    [ $100 6 cells - ]L buf $!len
    BEGIN  buf handle try-read-dir  WHILE
	    buf $@ drop swap 2dup match filename-match
	    IF  xt execute  THEN  REPEAT
    buf $free  handle close-dir throw ;

: s+ { addr1 u1 addr2 u2 -- addr u }
    u1 u2 + allocate throw { addr }
    addr1 addr u1 move
    addr2 addr u1 + u2 move
    addr u1 u2 +
;

: append { addr1 u1 addr2 u2 -- addr u }
    addr1 u1 u2 + dup { u } resize throw { addr }
    addr2 addr u1 + u2 move
    addr u ;

\ char/[char]

: char   ( '<spaces>ccc' -- c ) \ core
    \G Skip leading spaces. Parse the string @i{ccc} and return @i{c}, the
    \G display code representing the first character of @i{ccc}.
    ?parse-name
    2dup x-size u< #-16 and throw
    xc@ ;

: [char] ( compilation '<spaces>ccc' -- ; run-time -- c ) \ core bracket-char
    \G Compilation: skip leading spaces. Parse the string
    \G @i{ccc}. Run-time: return @i{c}, the display code
    \G representing the first character of @i{ccc}.  Interpretation
    \G semantics for this word are undefined.
    char postpone Literal ; immediate restrict

\ xchar version of parse

: string-parse ( c-addr1 u1 "ccc<string>" -- c-addr2 u2 )
\G Parse @i{ccc}, delimited by the string @i{c-addr1 u1}, in the parse
\G area. @i{c-addr2 u2} specifies the parsed string within the
\G parse area. If the parse area was empty, @i{u2} is 0.
    2>r source  >in @ over min /string ( c-addr1 u1 )
    over swap 2r@ search if
	drop over - r> rdrop
    else
	nip 0 2rdrop
    then
    over + >in +!
    2dup input-lexeme! ;

: (xparse)    ( xchar "ccc<char>" -- c-addr u ) \ core-ext
\G Parse @i{ccc}, delimited by @i{xchar}, in the parse
\G area. @i{c-addr u} specifies the parsed string within the
\G parse area. If the parse area was empty, @i{u} is 0.
    dup $80 < if (parse) exit then \ for -1, also possibly faster
    {: | xc[ 2 cells ] :} xc[ tuck xc!+ over - string-parse ;
\ 2 cells are absolutely sufficient

' (xparse) is parse
