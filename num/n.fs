.( Numbers Library )

\ num/n.fs
\ description

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ #region License
\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http: //www.gnu.org/licenses/.
\ #endregion


require intro.fs

0 constant add_op
1 constant sub_op
2 constant mul_op
3 constant div_op

variable n-inits   0 n-inits !
variable n-clears  0 n-clears !


begin-structure _num%
	drop 0 8 +field _num%-ptr
	drop 8 8 +field _num%-type
drop 16 end-structure

: ntype ( o -- type )
    _num%-type @ ;

: ntype! ( type num -- )
    _num%-type ! ;

: nvalue ( obj -- value )
   _num%-ptr @ ;

: nvalue! ( value num -- )
   _num%-ptr ! ;

: nallocate ( -- num )
   n-inits ++
   _num% allocate throw ;

: nfree ( num --  )
   n-clears ++
   free throw  ;

: ndrop ( num -- )
   nfree ;

: n-type-val ( num -- type obj )
   dup dup ntype swap nvalue rot ndrop ; 


: nv-destroy ( var num -- )
   ~~ dup ntype dup . z_type = if
      nvalue zdrop ~~ 
   then ;

: nv-free ( var -- )
   dup @ dup 0<> if ndrop then 0 swap ! ;

: n! ( num var -- )
   dup @ dup 0<> if 
      dup ntype z_type = if
         ~~ dup nvalue zdrop
         else 
            dup ntype q_type = if
               dup nvalue qdrop
            else
               dup nvalue frdrop
            then
         then
      ndrop 
   else 
      drop 
   then ! ;   




: nnip ( num1 num2 -- num2 )
   swap ndrop ;

: nvaldrop ( num -- obj )
   dup nvalue swap ndrop ;

: nmake ( type obj -- num )
   nallocate tuck nvalue! tuck ntype!  ;

: nz ( -- num )
   z_type z nmake ;

: nq ( -- num )
   q_type q nmake ;

: nfr ( -- num )
   fr_type fr nmake ;

\ : >num ( obj -- num ) \ description
\   _num% %allocate throw
\   2dup _num%-ptr !
\   dup rot q-is if q-type else z-type then swap _num%-type !
\   ;

: {n.} ( num -- num )
   dup ntype z_type = if
       dup nvalue z.  
   else dup ntype q_type = if
      dup nvalue q.
   else
      dup nvalue fr.
   then then ;
   

: n. ( num -- )
   {n.}  ndrop ;

: nbefore ( n1 n2 -- n1 n1 n1val n2val )
   swap tuck tuck  ( n1 n1 n2 n1 )  over swap  nvalue swap nvalue rot  ndrop ;   

: opz+ ( num1 num2 -- num )
    nbefore  z+ swap nvalue! ;

: opq+ ( num1 num2 -- num )
   nbefore q+ swap nvalue! ;

: opfr+ ( num1 num2 -- num )
   nbefore fr+ swap nvalue! ;

: opz- ( num1 num2 -- num )
   nbefore z- swap nvalue! ;

: opq- ( num1 num2 -- num )
   nbefore q- swap nvalue! ;

: opfr- ( num1 num2 -- num )
   nbefore fr- swap nvalue! ;

: opz* ( num1 num2 -- num )
   nbefore z* swap nvalue! ;

: opq* ( num1 num2 -- num )
   nbefore q* swap nvalue! ;

: opfr* ( num1 num2 -- num )
   nbefore fr* swap nvalue! ;



: nop ( num1 num2 type op -- num )
   case 
      add_op of 
         case 
            z_type of opz+ endof
            q_type of opq+ endof
            fr_type of opfr+ endof
            drop + dup
            endcase
      endof
      sub_op of
         case 
            z_type of opz- endof
            q_type of opq- endof
            fr_type of opfr- endof
            drop - dup
         endcase
      endof
      mul_op of
         case 
            z_type of opz* endof
            q_type of opq* endof
            fr_type of opfr* endof
            drop * dup
         endcase
      endof
      2drop ." invalid operator" cr
   endcase ;

: nz>q ( num -- num )
      dup dup nvalue z>q swap nvalue! dup q_type swap ntype! ;


: nz>fr ( num -- num )
   dup dup nvalue z>fr swap nvalue! dup fr_type swap ntype! ;

: nq>fr ( num -- num )
   dup dup nvalue q>fr swap nvalue! dup fr_type swap ntype! ;

: nconvert ( num type -- num )
   dup q_type = if drop nz>q
   else over ntype z_type = if drop nz>fr 
   else drop nq>fr 
   then then ;

: ncommon-type { num1 num2 -- num1 num2 type }
      num1 ntype num2 ntype 2dup < if 
         nip dup num1 swap nconvert num2 rot
      else 2dup > if 
         drop dup num2 swap nconvert num1 swap rot
      else drop num1 num2 rot
      then then  ;

: n+ ( num1 num2 -- num1+num2 ) \ add according to type
   ncommon-type add_op nop ;

: n- ( num1 num2 -- num )
   ncommon-type sub_op nop ;

: n* ( n1 n2 -- n1*n2 )
   ncommon-type mul_op nop ;

: n-mem-stats ( -- )   
    cr ." n-inits:   " n-inits @ .   
    bl emit ." n-clears:  " n-clears @ . ;


