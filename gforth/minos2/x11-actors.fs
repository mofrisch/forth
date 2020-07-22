\ MINOS2 actors on X11

\ Authors: Bernd Paysan, Anton Ertl
\ Copyright (C) 2017,2018,2019 Free Software Foundation, Inc.

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

require ../bits.fs

handler-class class
    2field: lastpos
    field: lasttime
    field: buttonmask
    field: flags
    value: clicks
end-class x11-handler

: lasttime@ ( -- seconds ) lasttime @ s>f 1m f* ;

0 Constant #pending
1 Constant #lastdown
2 Constant #clearme

also x11

#200 Value twoclicks  \ every edge further apart than 150ms into separate clicks
#6 Value samepos      \ position difference square-summed less than is same pos

Create x-key>ekey#
XK_BackSpace , #del ,
XK_Tab       , #tab ,
XK_Linefeed  , #lf  ,
XK_Escape    , #esc ,
XK_Return    , k-enter ,
XK_Home      , k-home ,
XK_End       , k-end ,
XK_Left      , k-left ,
XK_Up        , k-up   ,
XK_Right     , k-right ,
XK_Down      , k-down ,
XK_Insert    , k-insert ,
XK_Delete    , k-delete ,
XK_Prior     , k-prior ,
XK_Next      , k-next ,
XK_F1        , k-f1 ,
XK_F2        , k-f2 ,
XK_F3        , k-f3 ,
XK_F4        , k-f4 ,
XK_F5        , k-f5 ,
XK_F6        , k-f6 ,
XK_F7        , k-f7 ,
XK_F8        , k-f8 ,
XK_F9        , k-f9 ,
XK_F10       , k-f10 ,
XK_F12       , k-f11 ,
XK_F12       , k-f12 ,
XK_Pause     , k-pause ,
XF86XK_AudioMute , k-mute ,
XF86XK_AudioRaiseVolume , k-volup ,
XF86XK_AudioLowerVolume , k-voldown ,
0            , 0 ,
DOES> ( x-key [addr] -- ekey )
  over '@' #del within IF  drop
      e.state ControlMask and IF  $1F and  THEN
  ELSE
      swap >r
      BEGIN  dup cell+ swap @ dup r@ <> and WHILE  cell+  REPEAT
      @ rdrop dup 0= ?EXIT
  THEN  e.state xmeta@ mask-shift# lshift or ;

: resize-widgets ( w h -- )
    dpy-h ! dpy-w !  config-changed ;
:noname  ic ?dup-IF
	event look_chars $FF look_key comp_stat  Xutf8LookupString
    ELSE
	event look_chars $FF look_key comp_stat  XLookupString
    THEN
    dup 1 = IF  look_chars c@ dup $7F = swap bl < or +  THEN \ we want the other delete
    ?dup-IF  look_chars swap top-act ?dup-IF  .ukeyed  ELSE  2drop  THEN
    ELSE   look_key l@ x-key>ekey# ?dup-IF
	    top-act ?dup-IF  .ekeyed  ELSE  #esc = level# +!  THEN  THEN  THEN
; x11-handler to DoKeyPress

here
' (key) A,
' (key?) A,
A, here AConstant default-in'
:noname
    default-in' ip-vector !@ >r ekey r> ip-vector !
    ekey>xchar IF  [: xemit ;] $tmp top-act .ukeyed  EXIT  THEN
    top-act .ekeyed
; is looper-ekey
\ ' noop x11-handler to DoKeyRelease
: samepos? ( x y -- flag )
    lastpos 2@ rot - dup * -rot - dup * + samepos < ;
: ?samepos ( -- )
    e.x e.y 2dup samepos? 0= IF   0 to clicks  THEN  lastpos 2! ;
: send-clicks ( button-mask -- )
    lastpos 2@ swap s>f s>f
    clicks 2* flags #lastdown bit@ -
    flags #pending -bit
    grab-move? ?dup-IF  fswap gx-sum f+ fswap gy-sum f+
	[: .clicked ;] vp-needed<>|  EXIT  THEN
    top-act    ?dup-IF  .clicked  EXIT  THEN
    2drop fdrop fdrop ;
Variable xy$
: >xy$ ( x1 y1 .. xn yn n -- $rxy )
    2* sfloats xy$ $!len
    xy$ $@ bounds 1 sfloats - swap 1 sfloats - U-DO
	s>f I sf!
    1 sfloats -LOOP
    xy$ ;
:noname ( -- )
    event-handler @ >o
    Xtime lasttime @ - twoclicks >= IF
	flags #pending -bit@ IF
	    buttonmask le-ul@ send-clicks
	THEN
	flags #clearme -bit@ IF
	    0 to clicks
	THEN
    THEN
    o> ; x11-handler is ?looper-timeouts
:noname ( -- )
    buttonmask e.button 1- +bit
    top-act IF  e.x e.y 1 >xy$ buttonmask le-ul@ top-act .touchdown  THEN
    e.kbm.time lasttime !  ?samepos
    flags #lastdown +bit  flags #pending +bit
; x11-handler to DoButtonPress
:noname ( -- )
    ?samepos  e.kbm.time lasttime !
    flags #lastdown -bit@  IF
	1 +to clicks  flags #clearme +bit
	buttonmask le-ul@
	buttonmask e.button 1- -bit
	send-clicks  THEN
    buttonmask e.button 1- -bit
    top-act IF  e.x e.y 1 >xy$ buttonmask le-ul@ top-act .touchup  THEN
; x11-handler to DoButtonRelease
:noname ( -- )
    flags #pending bit@  e.x e.y samepos? 0= and IF
	buttonmask le-ul@ send-clicks  0 to clicks
    THEN
    grab-move? IF  e.x e.y 1 >xy$ >dxy buttonmask le-ul@
	[: grab-move? .touchmove ;] vp-needed<>|  EXIT
    THEN
    top-act    IF  e.x e.y 1 >xy$ buttonmask le-ul@ top-act    .touchmove  THEN
; x11-handler to DoMotionNotify
:noname ; x11-handler to DoEnterNotify
:noname ; x11-handler to DoLeaveNotify
:noname e.window focus-ic ; x11-handler to DoFocusIn
\ ' noop x11-handler to DoFocusOut
\ ' noop x11-handler to DoKeymapNotify
:noname top-widget .widget-draw ; x11-handler to DoExpose
:noname top-widget .widget-draw ; x11-handler to DoGraphicsExpose
\ ' noop x11-handler to DoNoExpose
:noname gui( ~~ ) ; x11-handler to DoVisibilityNotify
:noname e.w-width e.w-height resize-widgets ; x11-handler to DoCreateNotify
\ ' noop x11-handler to DoDestroyNotify
:noname gui( ~~ ) -1 rendering ! ; x11-handler to DoUnmapNotify
:noname gui( ~~ ) -2 rendering ! ; x11-handler to DoMapNotify
:noname gui( ~~ ) ; x11-handler to DoMapRequest
\ ' noop x11-handler to DoReparentNotify
:noname e.c-width  e.c-height resize-widgets ; x11-handler to DoConfigureNotify
\ ' noop x11-handler to DoConfigureRequest
\ ' noop x11-handler to DoGravityNotify
:noname e.r-width  e.r-height resize-widgets ; x11-handler to DoResizeRequest
\ ' noop x11-handler to DoCirculateNotify
\ ' noop x11-handler to DoCirculateRequest
\ ' noop x11-handler to DoPropertyNotify
\ ' noop x11-handler to DoSelectionClear
\ ' noop x11-handler to DoSelectionRequest
\ ' noop x11-handler to DoSelectionNotify
\ ' noop x11-handler to DoColormapNotify
:noname gui( ~~ ) ; x11-handler to DoMappingNotify
\ ' noop x11-handler to DoGenericEvent

x11-handler ' new static-a with-allocater Constant x11-keyboard
: enter-minos ( -- )
    exposed @ 0= IF  set-sync-request map-win  THEN
    edit-widget edit-out !
    x11-keyboard event-handler ! ;
: leave-minos ( -- )
    edit-terminal edit-out !
    [ event-handler @ ]L event-handler !
    [IFDEF] term-textures
	terminal-program terminal-init term-textures [THEN]
    +sync +config +show ;

previous
