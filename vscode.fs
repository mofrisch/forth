.( Visual Code Editor)

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
[ifundef] code-l:c
require ../tools.fs
[then]

: editor-name ( -- addr n )
    s" EDITOR" getenv
;

: use-code ( -- flag )
    editor-name s" code" string-prefix?
;

: editor-cmd2 ( souceview -- )
    editor-name 2dup 2>r type   ."  -g " 
    decode-view 1+ 2>r loadfilename#>str type   2r> code-l:c   2rdrop 
;

: extern-g2 ( -- )
    \g Enter the external editor at the place of the latest error,
    \g @code{locate}, @code{n} or @code{b}.
    current-location?
    bn-view @   ['] editor-cmd2   >string-execute   2dup type 2dup system   drop free throw 
    ;

use-code [if]
' extern-g2 is g
[then]

