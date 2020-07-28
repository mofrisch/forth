.( Common Tools)

\ patches/tools.fs
\ tools for inserting and editing files

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

variable user-include    0 user-include !

: current-file ( -- u addr )
	included-files dup @ swap $@ nip + $@ 
;

: current-file-num ( -- n )
	included-files $@ nip
;

: .du ( n -- )       
	0  <<# #s #> type #>> 
;

: code-l:c ( line pos -- )  
	swap ." :" .du  ." :" .du 
;

: edit-cmd ( addr u -- )
	." code-insiders -g " type \ 0 0 code-l:c
;

: edit-file ( addr u -- )
	['] edit-cmd >string-execute   2dup type   2dup system   drop free throw
;

: select-file ( "name" -- addr u ) \ select file "name"
	(name) dup 0<> if 
  		user-include @ 0= if 
			$make user-include !
		else
			user-include $!
		then
	else
		2drop
	then 
;

: in ( "name" | "" -- ) \ include file "name" or last file included by "name"
	select-file 
	user-include @ 0<> if    
		user-include $@ included
	else ." no current file" then
;

: ed ( "name" | -- ) 
	select-file
	user-include @ 0<> if   
		user-include $@ edit-file
	else ." no current file" then
;

