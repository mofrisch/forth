.( SDL2 Library)

\ sdl2/sdl2-lib.fs
\ Simple DirectMedia Layer Support

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

Vocabulary sdl2

get-current also sdl2 definitions

s" libtypeset.so" prefetch-lib

include sdl2.fs

previous definitions also sdl2

\ create sdlv SDL_version allot
\ sdlv SDL_GetVersion
\ sdlv 16 dump
\ sdlv SDL_version-major c@ .

previous set-current