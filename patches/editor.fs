.[ Patches for Visual Code Editor 0.0.0]

\ patches/editor.fs
\ Does VS Code Integration with Gforth.

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

require tools.fs

: editor-cmd2 ( souceview -- )
    s" EDITOR" getenv dup 0= IF
	    2drop s" vi" \ if you don't set EDITOR, use vi as default
    THEN

    2dup 2>r type space 
    
    2r@ s" code" string-prefix? IF \ vscode
        ." -g "
        decode-view 1+ 2>r
        ''' emit loadfilename#>str esc'type  2r> code-l:c ''' emit
    ELSE 
        2r@ s" emacsclient" string-prefix? IF  ." -n "  THEN
        decode-view 1+
        2r@ s" emacs" search nip nip  2r@ s" gedit" str= or  IF  
            emacs-l:c  
        ELSE
	        2r@ s" kate" string-prefix? IF  
                kate-l:c  
            ELSE
                vi-l:c  \ also works for joe, mcedit, nano, and is de facto standard
	        THEN    
        THEN
        ''' emit loadfilename#>str esc'type ''' emit  
    then
    2rdrop 
    ;

: extern-g2 ( -- )
    \g Enter the external editor at the place of the latest error,
    \g @code{locate}, @code{n} or @code{b}.
    current-location?
    bn-view @   ['] editor-cmd2   >string-execute   2dup type 2dup system   drop free throw 
    ;


' extern-g2 is g

