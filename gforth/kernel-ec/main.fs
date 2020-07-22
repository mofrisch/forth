\ MAIN.FS      Kernel main load file                   20may93jaw

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 1995,1996,1997,1998,2000,2003,2006,2007,2008,2011,2012,2013,2019 Free Software Foundation, Inc.

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

Create mach-file here over 1+ allot place

0 [IF]
\ debugging: produce a relocation and a symbol table
s" rel-table" r/w create-file throw
Constant fd-relocation-table

\ debuggging: produce a symbol table
s" sym-table" r/w create-file throw
Constant fd-symbol-table
[THEN]


parse-name vocabulary find-name 0= [IF]
    \ if search order stuff is missing assume we are compiling on a gforth
    \ system and include it.
    \ We want the files taken from our current gforth installation
    \ so we don't include relatively to this file
    require ./../startup.fs
[THEN]

\ include etags.fs

include ./../cross.fs              \ cross-compiler

decimal

has? rom 0= [IF]
    has? kernel-start has? kernel-size makekernel
[THEN]
    \ create image-header

doc-off
has? prims [IF]
    include ../kernel/aliases.fs             \ primitive aliases
[ELSE]
    prims-include
    undef-words
    include ../kernel/prim.fs
    all-words  
[THEN]
doc-on

has? header [IF]
1802 <> [IF] .s cr .( header start address expected!) cr uffz [THEN]
AConstant image-header
: forthstart image-header @ ;
[THEN]

\ 0 AConstant forthstart

\ include ./vars.fs                  \ variables and other stuff
\ include kernel/version.fs          \ is in $(build)/kernel
include ./kernel.fs                  \ kernel
\ include ./errore.fs
include ./doers.fs

has? compiler [IF]
    include ./cond.fs            \ IF and co.
     \ these two games can be added to provide complex examples for the 4stack
    \ and misc simulators (see arch/4stack/README and arch/misc/README).
    has? games [IF]
	include arch/misc/tt.fs
        \ disabled, as cross-compilation support seems broken currently:
        include arch/misc/sokoban.fs
    [THEN]
[THEN]
include ./quotes.fs
\ include ./tools.fs               \ load tools ( .s dump )
include ./getdoers.fs

\ Setup                                                13feb93py

include ./pass.fs                    \ pass pointers from cross to target

>boot

.unresolved                          \ how did we do?
