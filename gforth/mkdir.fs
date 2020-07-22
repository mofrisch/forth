\ mkdir wrapper

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 2008,2010,2012,2016,2019 Free Software Foundation, Inc.

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

\ there is now a primitive =MKDIR
[IFUNDEF] =mkdir
    [IFUNDEF] c-library
	\ define dummy mkdir
	: =mkdir ( c-addr u mode -- ior )
	    2drop drop 0 ;
    [ELSE]
	require cstr.fs
	c-library mkdir
	\c #include <sys/stat.h>
	\c #include <sys/types.h>
	c-function mkdir mkdir a n -- n ( pathname\0 mode -- f )
	\c #include <errno.h>
	\c #define IOR(flag)	((flag)? -512-errno : 0)
	c-function f>ior IOR n -- n ( f -- ior )
	    
	: =mkdir ( c-addr u mode -- ior )
	>r tilde_cstr r> over >r mkdir r> free drop f>ior ;
        end-c-library
    [THEN]
[THEN]

17 Constant EEXIST
#-512 EEXIST - Constant file-exist#

: mkdir-parents { c-addr u mode -- ior }
    \G create the directory @i{c-addr u} and all its parents with
    \G mode @i{mode} (modified by umask)
    c-addr u begin { d: s }
        s 1 /string '/' scan 2dup while ( s1 s1addr )
	    c-addr tuck - 2dup [: type '/' emit ;] $tmp file-status nip
	    0< IF  2dup delete-file drop  THEN  \ if it's a file, delete it
	    mode =mkdir dup file-exist# <> and throw
    repeat
    drop 2drop
    c-addr u mode =mkdir ;
