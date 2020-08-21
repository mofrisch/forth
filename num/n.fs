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
require z.fs
require q.fs
require fr.fs

also gmp also mpfr


create print-ops{} ' . , ' z{z.} , ' {q.} , ' {fr.} ,
create print-ops ' . , ' z. , ' q. , ' fr. ,

: n-show-mem
   cr .s z-mem-stats q-mem-stats fr-mem-stats ;

: fr? ( cell -- cell ? )
    try dup dup mpfr_cmp drop iferror drop false nothrow 
    else true then endtry
    ;

: q? ( cell -- cell ? )
   try dup _q%-num @ dup __gmpz_cmp iferror drop false nothrow 
   else drop true then endtry  ;

: z? ( cell -- cell ? )
    try dup @ dup here < swap 1000000 > and iferror drop false nothrow 
    else then endtry ;

: ntype ( cell -- cell type ) 
   z? if z-type else  q? if q-type else fr? if fr-type else other-type 
   then then then ;

: {n.} ( cell -- cell ) 
   ntype print-ops{} swap cells + @ execute ;

: n. ( cell -- )
   ntype print-ops swap cells + @ execute ;
   