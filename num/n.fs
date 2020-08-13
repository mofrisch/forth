require intro.fs

0 constant add_op
1 constant sub_op
2 constant mul_op



begin-structure _num%
	drop 0 8 +field _num%-ptr
	drop 8 8 +field _num%-type
drop 16 end-structure

: ntype ( o -- type )
    _num%-type @ ;

: ntype! ( o -- type )
    swap _num%-type ! ;

: nvalue ( o -- value )
   _num%-ptr @ ;

: nvalue! 
   swap _num%-ptr ! ;

\ : >num ( obj -- num ) \ description
\   _num% %allocate throw
\   2dup _num%-ptr !
\   dup rot q-is if q-type else z-type then swap _num%-type !
\   ;

: (n.) ( num -- num )
   dup ntype z_type = if
      nvalue (z.)
   else dup ntype q_type = if
      nvalue (q.)
   else
      nvalue (fr.)
   then then ;
   

: n. ( num -- )
   (n.) ;

: nbefore
   swap tuck tuck nvalue swap nvalue ;

: opz+ ( num1 num2 -- num )
   nbefore z+ nvalue! ;

: opq+ ( num1 num2 -- num )
   nbefore q+ nvalue! ;

: opfr+ ( num1 num2 -- num )
   nbefore fr+ nvalue! ;

: opz- ( num1 num2 -- num )
   nbefore z- nvalue! ;

: opq- ( num1 num2 -- num )
   nbefore q- nvalue! ;

: opfr- ( num1 num2 -- num )
   nbefore fr- nvalue! ;

: opz* ( num1 num2 -- num )
   nbefore z* nvalue! ;

: opq* ( num1 num2 -- num )
   nbefore q* nvalue! ;

: opfr* ( num1 num2 -- num )
   nbefore fr* nvalue! ;



: nop ( num1 num2 type op -- num )
   case 
      add_op of 
         case 
            z_type of opz+ endof
            q_type of opq+ endof
            fr_type of opfr+ endof
         endcase
      endof
      sub_op of
         case 
            z_type of opz- endof
            q_type of opq- endof
            fr_type of opfr- endof
         endcase
      endof
      mul_op of
         case 
            z_type of opz* endof
            q_type of opq* endof
            fr_type of opfr* endof
         endcase
      endof
   endcase ;

: nz>q ( num -- num )
   ~~ dup dup nvalue ~~ z>q nvalue! ~~ dup q_type ~~ ntype! ;

: nz>fr ( num -- num )
   dup dup nvalue z>fr nvalue! dup fr_type ntype! ;

: nq>fr ( num -- num )
   dup dup nvalue q>fr nvalue! dup fr_type ntype! ;

: convert ( num type -- num )
   ~~ dup q_type = if 
      nz>q drop
   else
      ~~ over ntype z_type = if 
         drop ~~ nz>fr ~~ 
      else
         nq>fr 
   then then ;

: common_type { num1 num2 -- num1 num2 type }
      ~~ num1 ntype num2 ntype ~~ 2dup < if 
         nip dup num1 swap ~~ convert ~~ num2 rot ~~
      else ~~ 2dup > if 
         drop dup num2 swap convert num1 swap rot
      else drop num1 num2 rot ~~
      then 
      
      then  ;

: (n+) ( num1 num2 type -- num1 + num2 )
   ~~
   case 
   z_type of ~~ swap tuck tuck ~~ nvalue swap nvalue z+ swap _num%-ptr ! endof
   q_type of q+ endof
   endcase ;


: n+ ( num1 num2 -- num1+num2 ) \ add according to type
   2dup swap ( n1 n2 n2 n1 ) ntype dup . ~~ ( n1 n2 n2 t1 ) tuck swap ( n1 n2 t1 t1 n2 ) ntype = if
      ~~ (n+)
   then ;

: n- ( num1 num2 -- num )
   common_type ( n1 n2 t ) ~~ sub_op ~~ nop ;

: nnew ( -- num )
   _num% allocate throw ;

: nz ( -- num )
   z nnew tuck _num%-ptr !  z_type over _num%-type ! ;

: nq ( -- num )
   q nnew tuck _num%-ptr !  q_type over _num%-type ! ;

: nfr ( -- num )
   fr nnew tuck _num%-ptr !  fr_type over _num%-type ! ;

\ z 1 >num q 1/2 >num n+
\ zn 1 zq 1/2 n+