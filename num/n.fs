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

0 constant add-op
1 constant sub-op
2 constant mul-op
3 constant div-op

\ Maybe better than the big case: in nop...
create print-ops ' {z.} , ' {q.} , ' {fr.} ,
create add-ops ' z+ , ' q+ , ' fr+ ,
create sub-ops ' z- , ' q- , ' fr- ,
create drop-ops ' zdrop , ' qdrop , ' frdrop ,
create cmp-ops ' zcmp , ' qcmp , ' frcmp ,
create arith-ops add-ops , sub-ops ,


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



\ : ndup ( num1 -- num1 num1 )  
\   nallocate  2dup 2dup swap ntype swap ntype! swap nvalue swap nvalue! ;

: n-type-value ( num -- type obj )
   dup dup ntype swap nvalue rot drop ;

: n-type-value! ( num type obj -- )
   rot dup ( t v n n ) rot swap nvalue! ntype! ;

: ndup ( num1 -- num1 num1 )
   nallocate 2dup ( n1 n2 n1 n2) swap ( n1 n2 n2 n1 )
   n-type-value ( n1 n2 n2 t v ) n-type-value! ;

: nfree-value ( num -- )
   ~~ n-type-value drop-ops rot cells + @ execute ;

: nfree ( num -- )
   n-clears ++
   dup nfree-value
    ~~ free throw ;

: ndrop
   nfree ;

: n! ( num var -- )
   dup @ dup 0<> if ndrop else drop then ! ;

: n@ ( var -- num)
   @ ndup nip ; 

: nv-free ( var -- )
   @  ndrop ;

: nmake ( type obj -- num )
   nallocate tuck nvalue! tuck ntype!  ;

: nz ( -- num )
   z-type z nmake ;

: nq ( -- num )
   q-type q nmake ;

: nfr ( -- num )
   fr-type fr nmake ;

: {n.} ( num -- num )
   ~~ dup n-type-value print-ops rot cells + @ execute drop ~~ ;
   
: n. ( num -- )
   {n.}  ndrop ;

: nbefore ( n1 n2 -- n1 n1 n1val n2val )
   swap tuck tuck  ( n1 n1 n2 n1 )  ~~ over swap  nvalue swap nvalue rot drop ;   

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
      add-op of 
         case 
            z-type of opz+ endof
            q-type of opq+ endof
            fr-type of opfr+ endof
            drop + dup
            endcase
      endof
      sub-op of
         case 
            z-type of opz- endof
            q-type of opq- endof
            fr-type of opfr- endof
            drop - dup
         endcase
      endof
      mul-op of
         case 
            z-type of opz* endof
            q-type of opq* endof
            fr-type of opfr* endof
            drop * dup
         endcase
      endof
      2drop ." invalid operator" cr
   endcase ;

: nz>q ( num -- num )
      dup dup nvalue z>q swap nvalue! dup q-type swap ntype! ;


: nz>fr ( num -- num )
   dup dup nvalue z>fr swap nvalue! dup fr-type swap ntype! ;

: nq>fr ( num -- num )
   dup dup nvalue q>fr swap nvalue! dup fr-type swap ntype! ;

: nconvert ( num type -- num )
   dup q-type = if drop nz>q
   else over ntype z-type = if drop nz>fr 
   else drop nq>fr 
   then then ;

\ : n-common-type { num1 num2 -- num1 num2 type }
\      num1 ntype num2 ntype 2dup < if 
\         nip dup num1 swap nconvert num2 rot
\      else 2dup > if 
\         drop dup num2 swap nconvert num1 swap rot
\      else drop num1 num2 rot
\     then then  ;

: n-common-type ( num 1 num2 -- type )
   ntype swap ntype swap max ;

\ : n-to-value ( num type -- obj )
\   swap n-type-value ( type t1 v1 ) -rot 2dup > if  
\         swap q-type = if 
\         drop z>q
\      else 
\         z-type = if
\            drop z>fr
\         else 
\            2drop q>fr
\   else 
\      2drop
\  then 
\  then 
\  then ~~ ;

: n-to-value ( num type -- obj )
   swap n-type-value -rot 2dup > if
   else 2drop then ; 



: n+ ( num1 num2 -- num1+num2 ) \ add according to type
   ~~ 2dup 2dup n-common-type ( n1 n2 t ) 
   tuck ~~ n-to-value ( n1 t z )-rot ~~ 
   n-to-value  ~~ z+ z-type swap ~~ nmake dup . ~~
   -rot ~~ ndrop ndrop dup . ;

: n- ( num1 num2 -- num )
   n-common-type sub-op nop ;

: n* ( n1 n2 -- n1*n2 )
   n-common-type mul-op nop ;

: ncmp ( n1 n2 -- -1|0|1 )
   n-common-type cmp-ops swap cells + @ execute ;


: n-mem-stats ( -- )   
    cr ." n-inits:   " n-inits @ .   
    bl emit ." n-clears:  " n-clears @ . ;

: n-show-mem
   cr .s z-mem-stats q-mem-stats fr-mem-stats n-mem-stats
;