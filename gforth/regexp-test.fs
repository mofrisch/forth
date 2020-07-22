\ regexp test

\ Authors: Bernd Paysan, Anton Ertl, David Kühling
\ Copyright (C) 2005,2007,2009,2010,2018,2019 Free Software Foundation, Inc.

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

: ?depth  depth IF  ." unbalanced: " .s clearstack cr  THEN ;

charclass [bl-]   blanks +class '-' +char
charclass [0-9(]  '(' +char '0' '9' ..char

: telnum ( addr u -- flag )
    (( {{ ` (  \( \d \d \d \) ` ) || \( \d \d \d \) }}  blanks c?
    \( \d \d \d \) [bl-] c?
    \( \d \d \d \d \) {{ \$ || -\d }} )) ;

: ?tel ( addr u -- ) telnum
    IF  '(' emit \1 type ." ) " \2 type '-' emit \3 type ."  succeeded"
    ELSE \0 type ."  failed " THEN ;

: ?tel-s ( addr u -- ) ?tel ."  should succeed" space cr ?depth ;
: ?tel-f ( addr u -- ) ?tel ."  should fail" space cr ?depth ;

." --- Telephone number match ---" cr
s" (123) 456-7890" ?tel-s
s" (123) 456-7890 " ?tel-s
s" (123)-456 7890" ?tel-f
s" (123) 456 789" ?tel-f
s" 123 456-7890" ?tel-s
s" 123 456-78909" ?tel-f

: telnum2 ( addr u -- flag )
    (( // {{ [0-9(] -c? || \^ }}
    {{ ` (  \( \d \d \d \) ` ) || \( \d \d \d \) }}  blanks c?
    \( \d \d \d \) [bl-] c?
    \( \d \d \d \d \) {{ \$ || -\d }} )) ;

: ?tel2 ( addr u -- ) telnum2
    IF   '(' emit \1 type ." ) " \2 type '-' emit \3 type ."  succeeded"
    ELSE \0 type ."  failed " THEN  cr ?depth ;
." --- Telephone number search ---" cr
s" blabla (123) 456-7890" ?tel2
s" blabla (123) 456-7890 " ?tel2
s" blabla (123)-456 7890" ?tel2
s" blabla (123) 456 789" ?tel2
s" blabla 123 456-7890" ?tel2
s" blabla 123 456-78909" ?tel2
s" (123) 456-7890" ?tel2
s"  (123) 456-7890 " ?tel2
s" a (123)-456 7890" ?tel2
s" la (123) 456 789" ?tel2
s" bla 123 456-7890" ?tel2
s" abla 123 456-78909" ?tel2

." --- Number extraction test ---" cr

charclass [0-9,./:]  '0' '9' ..char ',' +char '.' +char '/' +char ':' +char

: ?num
    (( // \( {++ [0-9,./:] c? ++} \) ))
    IF  \1 type  ELSE  \0 type ."  failed"  THEN   cr ?depth ;

s" 1234" ?num
s" 12,345abc" ?num
s" foobar12/345:678.9abc" ?num
s" blafasel" ?num

." --- String test --- " cr

: ?string
    (( // \( {{ =" foo" || =" bar" || =" test" }} \) ))
    IF  \1 type  cr THEN ;
s" dies ist ein test" ?string
s" foobar" ?string
s" baz bar foo" ?string
s" Hier kommt nichts vor" ?string

." --- longer matches test --- " cr

: ?foos
    (( \( {** =" foo" **} \) ))
    IF  \1 type  ELSE  \0 type ."  failed"  THEN  cr ?depth ;

: ?foobars
    (( // \( {** =" foo" **} \) \( {++ =" bar" ++} \) ))
    IF  \1 type ',' emit \2 type  ELSE  \0 type ."  failed"  THEN  cr ?depth ;

: ?foos1
    (( // \( {+ =" foo" +} \) \( {++ =" bar" ++} \) ))
    IF  \1 type ',' emit \2 type  ELSE  \0 type ."  failed"  THEN  cr ?depth ;

s" foobar" ?foos
s" foofoofoobar" ?foos
s" fofoofoofofooofoobarbar" ?foos
s" bla baz bar" ?foos
s" foofoofoo" ?foos

s" foobar" ?foobars
s" foofoofoobar" ?foobars
s" fofoofoofofooofoobarbar" ?foobars
s" bla baz bar" ?foobars
s" foofoofoo" ?foobars

s" foobar" ?foos1
s" foofoofoobar" ?foos1
s" fofoofoofofooofoobarbar" ?foos1
s" bla baz bar" ?foos1
s" foofoofoo" ?foos1

\ backtracking on decissions

: ?aab ( addr u -- flag )
   (( {{ =" aa" || =" a" }} {{ =" ab" || =" a" }} )) ;
s" aab" ?aab 0= [IF] .( aab failed!) cr [THEN]

\ buffer overrun test (bug in =")

." --- buffer overrun test ---" cr

 : ?long-string
    (( // \( =" abcdefghi" \) ))
    IF  \1 type  cr THEN ;

4096 allocate throw 4096 + 8 - constant test-string
 s" abcdefgh" test-string swap cmove>
 .( provoking overflow [i.e. see valgrind output]) cr
 test-string . cr
 test-string 8 ?long-string
.( done) cr ?depth

\ simple replacement test
 
." --- simple replacement test ---" cr

: delnum  ( addr u -- addr' u' )   s// \d >> s" " //g ;
: test-delnum  ( addr u addr' u' -- )
   2swap delnum 2over 2over str= 0= IF
      ." test-delnum: got '" type ." ', expected '" type ." '"
   ELSE  2drop 2drop ." test-delnum passed" cr  THEN  ?depth ;
s" 0"  s" " test-delnum
s" 00"  s" " test-delnum
s" 0a"  s" a" test-delnum
s" a0"  s" a" test-delnum
s" aa"  s" aa" test-delnum

: delcomment  ( addr u -- addr' u' )  s// ` # {** .? **} >> s" " //g ;
s" hello # test " delcomment type cr
: delparents  ( addr u -- addr' u' )  s// ` ( {* .? *} ` ) >> s" ()" //g ;
s" delete (test) and (another test) " delparents type cr
?depth

\ replacement tests

." --- replacement tests ---" cr

: hms>s ( addr u -- addr' u' )
  s// \( \d \d \) ` : \( \d \d \) ` : \( \d \d \) >>
  \1 s>number drop 60 *
  \2 s>number drop + 60 *
  \3 s>number drop + 0 <# 's' hold #s #> //g ;

s" bla 12:34:56 fasel 00:01:57 blubber" 2dup type hms>s
."  -> " 2dup type
s" bla 45296s fasel 117s blubber" str= [IF] .(  ok) [ELSE] .(  failed) [THEN] cr
?depth

: hms>s,del() ( addr u -- addr' u' )
  s// {{ ` ( // ` ) >> <<" ()"
      || \( \d \d \) ` : \( \d \d \) ` : \( \d \d \)
         >> \1 s>number drop 60 *
            \2 s>number drop + 60 *
            \3 s>number drop + 0 <# 's' hold #s #> <<
      }} LEAVE //s ;

s" (bla) 12:34:56 (fasel) 00:01:57 (blubber)" 2dup type hms>s,del() ."  -> " type cr

\ more tests from David Kühling

coverage? false to coverage?
require test/ttester.fs
to coverage?

: underflow1  ( c-addr u -- flag )
   (( {{
         {{ ` - || }} \d
         || \d
      }} )) ;
T{ s" -1dummy" underflow1 -> true }T

: underflow2  ( -- )
   (( \( {{ \s {** \s **} 
	 || =" /*" // =" */"
	 || =" //" {** \d **} }} \) )) ;
T{ s" /*10203030203030404*/   " underflow2 -> true }T
T{ pad 0 underflow2 -> false }T

charclass [*] '* +char
charclass [*/] '* +char '/ +char

: underflow3  ( -- )
   ((
      =" /*"
      \( {** {{ [*] -c? || ` * [*/] -c? }} **} \)
      {++ ` * ++} ` /
   )) ;

\ this still seems to be too complicated
T{ s" /*10203030203030404*/   " underflow3 -> true }T
\1 type cr

: underflow4  ( -- )
   (( \( {{ {** \d **} || {** \d **} }} \d \) )) ;

T{ s" 0  " underflow4 -> true }T

coverage? [IF] .coverage cov% cr [THEN]
script? [IF] bye [THEN]
