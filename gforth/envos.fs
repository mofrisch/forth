\ envos.fs set os-specific environmental queries 	07jul97jaw

\ Authors: Anton Ertl, Bernd Paysan, David Kühling
\ Copyright (C) 1997,1999,2000,2003,2006,2007,2008,2009,2010,2012,2013,2015,2016,2018,2019 Free Software Foundation, Inc.

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

get-current environment-wordlist set-current
: os-class ( -- c-addr u ) \ gforth-environment
    \G Counted string representing a description of the host operating system.
    s" unix" ;
: os-type ( -- c-addr u ) \ gforth-environment
    \G Counted string equal to "$host_os"
    s" darwin" ;
set-current

: lib-suffix ( -- c-addr u ) \ gforth
\G the suffix for loading shared objects
    s" .la" ;

: machine ( -- c-addr u ) \ gforth
    \G the machine we are running on
    s" amd64" ;

: libtool-command ( -- c-addr u ) \ gforth
\G name of the GNU libtool command
    s" glibtool" ;

: libtool-cc ( -- c-addr u ) \ gforth
\G invocation string of the C compiler used for libtool
    s" gcc -Wimplicit-function-declaration -g -O2 -fomit-frame-pointer -pthread  -I/opt/X11/include -I/usr/local/include     -I/usr/local/include/gforth/0.7.9_20200716/amd64  -pthread -L/opt/X11/lib -L/usr/local/lib" ;

: libtool-flags ( -- c-addr u ) \ gforth
\G force no undefined for cygwin
    [ s" darwin" s" cygwin" str= ] [IF]  s"  -no-undefined "
    [ELSE]  s" "  [THEN] ;

\ test for the presence of libffi or ffcall
false constant ffcall-present \ libffi present (on building)
true constant libffi-present \ ffcall libs present (on building)

: include-ffi.h-string ( -- c-addr u )
  s" #include <ffi/ffi.h>" ;

true constant getentropy?
false constant getrandom?
