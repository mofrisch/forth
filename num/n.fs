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

create print-ops ' {z.} , ' {q.} , ' {fr.} ,

: n-show-mem
   cr .s z-mem-stats q-mem-stats fr-mem-stats ;

: ntype ( cell -- type ) 
   dup z? if z-type else 
   dup q? if q-type else 
   dup fr? if fr-type else
   other-type 
   then then then nip ;

: {n.} ( cell -- cell ) ;