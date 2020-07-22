\ run-time routine headers

\ Authors: Anton Ertl, Bernd Paysan, David Kühling
\ Copyright (C) 1997,1998,2002,2003,2006,2007,2010,2013,2015,2016,2019 Free Software Foundation, Inc.

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

-2 Doer: :docol
-3 Doer: :docon
-4 Doer: :dovar
-5 Doer: :douser
-6 Doer: :dodefer
-7 Doer: :dofield
-8 Doer: :dovalue
-9 Doer: :dodoes
-&10 Doer: :doabicode
-&11 Doer: :do;abicode
-&2 first-primitive
\ this does not work for (at least) (DODOES),
\ so the following routines are commented out
 0 [if]
155 0 #loc prim Primitive (docol)
167 0 #loc prim Primitive (docon)
171 0 #loc prim Primitive (dovar)
175 0 #loc prim Primitive (douser)
179 0 #loc prim Primitive (dodefer)
185 0 #loc prim Primitive (dofield)
189 0 #loc prim Primitive (dovalue)
193 0 #loc prim Primitive (dodoes)
199 0 #loc prim Primitive (doabicode)
206 0 #loc prim Primitive (do;abicode)
 [endif]
10 groupadd
group  control
218 0 #loc prim Primitive noop
222 0 #loc prim Primitive call
234 0 #loc prim Primitive execute
243 0 #loc prim Primitive perform
252 0 #loc prim Primitive ;s
256 0 #loc prim Primitive execute-;s
265 0 #loc prim Primitive unloop
270 0 #loc prim Primitive lit-perform
275 0 #loc prim Primitive does-xt
9 groupadd
has? glocals [IF]
289 0 #loc prim Primitive branch-lp+!#
1 groupadd
[THEN]
297 0 #loc prim Primitive branch
325 0 #loc prim Primitive ?branch
2 groupadd
has? glocals [IF]
325 0 #loc prim Primitive ?branch-lp+!#
1 groupadd
[THEN]
0 groupadd
has? xconds [IF]
338 0 #loc prim Primitive ?dup-?branch
347 0 #loc prim Primitive ?dup-0=-?branch
2 groupadd
[THEN]
has? skiploopprims 0= [IF]
358 0 #loc prim Primitive (next)
1 groupadd
has? glocals [IF]
358 0 #loc prim Primitive (next)-lp+!#
1 groupadd
[THEN]
365 0 #loc prim Primitive (loop)
1 groupadd
has? glocals [IF]
365 0 #loc prim Primitive (loop)-lp+!#
1 groupadd
[THEN]
373 0 #loc prim Primitive (+loop)
1 groupadd
has? glocals [IF]
373 0 #loc prim Primitive (+loop)-lp+!#
1 groupadd
[THEN]
0 groupadd
has? xconds [IF]
392 0 #loc prim Primitive (-loop)
1 groupadd
has? glocals [IF]
392 0 #loc prim Primitive (-loop)-lp+!#
1 groupadd
[THEN]
398 0 #loc prim Primitive (/loop)#
1 groupadd
has? glocals [IF]
398 0 #loc prim Primitive (/loop)#-lp+!#
1 groupadd
[THEN]
403 0 #loc prim Primitive (s+loop)
1 groupadd
has? glocals [IF]
403 0 #loc prim Primitive (s+loop)-lp+!#
1 groupadd
[THEN]
0 groupadd
[THEN]
420 0 #loc prim Primitive (for)
426 0 #loc prim Primitive (do)
430 0 #loc prim Primitive (?do)
3 groupadd
has? xconds [IF]
444 0 #loc prim Primitive (+do)
458 0 #loc prim Primitive (u+do)
472 0 #loc prim Primitive (-do)
486 0 #loc prim Primitive (u-do)
500 0 #loc prim Primitive (try)
509 0 #loc prim Primitive uncatch
512 0 #loc prim Primitive fast-throw
522 0 #loc prim Primitive pushwrap
530 0 #loc prim Primitive dropwrap
533 0 #loc prim Primitive exit-wrap
10 groupadd
[THEN]
547 0 #loc prim Primitive i
552 0 #loc prim Primitive i'
558 0 #loc prim Primitive j
564 0 #loc prim Primitive k
[THEN]
4 groupadd
group  strings
576 0 #loc prim Primitive move
585 0 #loc prim Primitive cmove
594 0 #loc prim Primitive cmove>
605 0 #loc prim Primitive fill
612 0 #loc prim Primitive compare
644 0 #loc prim Primitive toupper
651 0 #loc prim Primitive capscompare
660 0 #loc prim Primitive /string
668 0 #loc prim Primitive safe/string
9 groupadd
group  arith
683 0 #loc prim Primitive lit
687 0 #loc prim Primitive +
692 0 #loc prim Primitive lit+
699 0 #loc prim Primitive under+
705 0 #loc prim Primitive -
710 0 #loc prim Primitive negate
716 0 #loc prim Primitive 1+
721 0 #loc prim Primitive 1-
726 0 #loc prim Primitive max
734 0 #loc prim Primitive min
742 0 #loc prim Primitive abs
750 0 #loc prim Primitive *
755 0 #loc prim Primitive /f
767 0 #loc prim Primitive modf
779 0 #loc prim Primitive /modf
795 0 #loc prim Primitive */modf
820 0 #loc prim Primitive */f
843 0 #loc prim Primitive /s
853 0 #loc prim Primitive mods
863 0 #loc prim Primitive /mods
875 0 #loc prim Primitive */mods
894 0 #loc prim Primitive */s
912 0 #loc prim Primitive 2*
918 0 #loc prim Primitive 2/
929 0 #loc prim Primitive fm/mod
950 0 #loc prim Primitive sm/rem
966 0 #loc prim Primitive m*
973 0 #loc prim Primitive um*
985 0 #loc prim Primitive um/mod
1005 0 #loc prim Primitive u/-stage2m
1011 0 #loc prim Primitive umod-stage2m
1018 0 #loc prim Primitive u/mod-stage2m
1026 0 #loc prim Primitive /f-stage2m
1031 0 #loc prim Primitive modf-stage2m
1038 0 #loc prim Primitive /modf-stage2m
1046 0 #loc prim Primitive m+
1056 0 #loc prim Primitive d+
1061 0 #loc prim Primitive d-
1071 0 #loc prim Primitive dnegate
1081 0 #loc prim Primitive d2*
1087 0 #loc prim Primitive d2/
1100 0 #loc prim Primitive and
1103 0 #loc prim Primitive or
1108 0 #loc prim Primitive xor
1111 0 #loc prim Primitive invert
1116 0 #loc prim Primitive rshift
1126 0 #loc prim Primitive lshift
1135 0 #loc prim Primitive umax
1143 0 #loc prim Primitive umin
1151 0 #loc prim Primitive mux
1157 0 #loc prim Primitive select
1163 0 #loc prim Primitive dlshift
1178 0 #loc prim Primitive drshift
1193 0 #loc prim Primitive rol
1197 0 #loc prim Primitive ror
1201 0 #loc prim Primitive drol
1220 0 #loc prim Primitive dror
1239 0 #loc prim Primitive du/mod
1258 0 #loc prim Primitive u/
1266 0 #loc prim Primitive umod
1274 0 #loc prim Primitive u/mod
1284 0 #loc prim Primitive u*/mod
1302 0 #loc prim Primitive u*/
1320 0 #loc prim Primitive arshift
1326 0 #loc prim Primitive darshift
65 groupadd
group  compare
1394 0 #loc prim Primitive 0=
1394 0 #loc prim Primitive 0<>
1394 0 #loc prim Primitive 0<
1394 0 #loc prim Primitive 0>
1394 0 #loc prim Primitive 0<=
1394 0 #loc prim Primitive 0>=
1395 0 #loc prim Primitive =
1395 0 #loc prim Primitive <>
1395 0 #loc prim Primitive <
1395 0 #loc prim Primitive >
1395 0 #loc prim Primitive <=
1395 0 #loc prim Primitive >=
1396 0 #loc prim Primitive u=
1396 0 #loc prim Primitive u<>
1396 0 #loc prim Primitive u<
1396 0 #loc prim Primitive u>
1396 0 #loc prim Primitive u<=
1396 0 #loc prim Primitive u>=
18 groupadd
has? dcomps [IF]
1446 0 #loc prim Primitive d=
1446 0 #loc prim Primitive d<>
1446 0 #loc prim Primitive d<
1446 0 #loc prim Primitive d>
1446 0 #loc prim Primitive d<=
1446 0 #loc prim Primitive d>=
1447 0 #loc prim Primitive d0=
1447 0 #loc prim Primitive d0<>
1447 0 #loc prim Primitive d0<
1447 0 #loc prim Primitive d0>
1447 0 #loc prim Primitive d0<=
1447 0 #loc prim Primitive d0>=
1448 0 #loc prim Primitive du=
1448 0 #loc prim Primitive du<>
1448 0 #loc prim Primitive du<
1448 0 #loc prim Primitive du>
1448 0 #loc prim Primitive du<=
1448 0 #loc prim Primitive du>=
18 groupadd
[THEN]
1452 0 #loc prim Primitive within
1 groupadd
group  stack
1466 0 #loc prim Primitive useraddr
1469 0 #loc prim Primitive up!
1475 0 #loc prim Primitive sp@
1478 0 #loc prim Primitive sp!
1481 0 #loc prim Primitive rp@
1484 0 #loc prim Primitive rp!
6 groupadd
has? floating [IF]
1489 0 #loc prim Primitive fp@
1492 0 #loc prim Primitive fp!
2 groupadd
[THEN]
1497 0 #loc prim Primitive >r
1502 0 #loc prim Primitive r>
1507 0 #loc prim Primitive rdrop
1512 0 #loc prim Primitive 2>r
1516 0 #loc prim Primitive 2r>
1520 0 #loc prim Primitive 2r@
1524 0 #loc prim Primitive 2rdrop
1529 0 #loc prim Primitive over
1533 0 #loc prim Primitive drop
1538 0 #loc prim Primitive swap
1543 0 #loc prim Primitive dup
1547 0 #loc prim Primitive rot
1556 0 #loc prim Primitive -rot
1560 0 #loc prim Primitive nip
1564 0 #loc prim Primitive tuck
1568 0 #loc prim Primitive ?dup
1577 0 #loc prim Primitive pick
1583 0 #loc prim Primitive third
1585 0 #loc prim Primitive fourth
1587 0 #loc prim Primitive 2drop
1592 0 #loc prim Primitive 2dup
1596 0 #loc prim Primitive 2over
1600 0 #loc prim Primitive 2swap
1604 0 #loc prim Primitive 2rot
1608 0 #loc prim Primitive 2nip
1612 0 #loc prim Primitive 2tuck
1616 0 #loc prim Primitive user@
1619 0 #loc prim Primitive sps@
28 groupadd
group  memory
1626 0 #loc prim Primitive @
1632 0 #loc prim Primitive lit@
1635 0 #loc prim Primitive !
1639 0 #loc prim Primitive +!
1645 0 #loc prim Primitive c@
1671 0 #loc prim Primitive c!
1701 0 #loc prim Primitive 2!
1708 0 #loc prim Primitive 2@
1716 0 #loc prim Primitive cell+
1722 0 #loc prim Primitive cells
1733 0 #loc prim Primitive char+
1739 0 #loc prim Primitive (chars)
1744 0 #loc prim Primitive count
1752 0 #loc prim Primitive cell/
1763 0 #loc prim Primitive cell-
1769 0 #loc prim Primitive inc#
16 groupadd
group  compiler
0 groupadd
has? f83headerstring [IF]
1778 0 #loc prim Primitive (f83find)
1 groupadd
[ELSE]
1808 0 #loc prim Primitive (listlfind)
1 groupadd
has? hash [IF]
1829 0 #loc prim Primitive (hashlfind)
1839 0 #loc prim Primitive (tablelfind)
1856 0 #loc prim Primitive (hashkey1)
1872 0 #loc prim Primitive (hashkey2)
1876 0 #loc prim Primitive hashkey2
5 groupadd
[THEN]
0 groupadd
[THEN]
1885 0 #loc prim Primitive (parse-white)
1895 0 #loc prim Primitive scan
1916 0 #loc prim Primitive skip
1933 0 #loc prim Primitive aligned
1939 0 #loc prim Primitive faligned
has? standardthreading has? compiler and [IF]
1947 0 #loc prim Primitive threading-method
1962 0 #loc prim Primitive debugging-method
[THEN]
7 groupadd
group  hostos
1976 0 #loc prim Primitive (key-file)
1990 0 #loc prim Primitive key?-file
2002 0 #loc prim Primitive stdin
2006 0 #loc prim Primitive stdout
2010 0 #loc prim Primitive stderr
2014 0 #loc prim Primitive term-prep?
6 groupadd
has? os [IF]
2019 0 #loc prim Primitive (form)
2032 0 #loc prim Primitive isatty
2036 0 #loc prim Primitive isfg
2044 0 #loc prim Primitive wcwidth
2048 0 #loc prim Primitive flush-icache
2060 0 #loc prim Primitive (bye)
2068 0 #loc prim Primitive (system)
2072 0 #loc prim Primitive getenv
2083 0 #loc prim Primitive open-pipe
2090 0 #loc prim Primitive close-pipe
2094 0 #loc prim Primitive time&date
2108 0 #loc prim Primitive (ms)
2112 0 #loc prim Primitive heap-allocate
2121 0 #loc prim Primitive heap-free
2129 0 #loc prim Primitive heap-resize
2148 0 #loc prim Primitive strerror
2152 0 #loc prim Primitive strsignal
2156 0 #loc prim Primitive call-c
2169 0 #loc prim Primitive call-c#
2182 0 #loc prim Primitive gforth-pointers
20 groupadd
[THEN]
0 groupadd
has? file [IF]
2188 0 #loc prim Primitive close-file
2191 0 #loc prim Primitive open-file
2196 0 #loc prim Primitive create-file
2201 0 #loc prim Primitive delete-file
2206 0 #loc prim Primitive rename-file
2210 0 #loc prim Primitive file-position
2215 0 #loc prim Primitive reposition-file
2218 0 #loc prim Primitive file-size
2228 0 #loc prim Primitive resize-file
2231 0 #loc prim Primitive read-file
2242 0 #loc prim Primitive (read-line)
11 groupadd
[THEN]
2251 0 #loc prim Primitive write-file
2264 0 #loc prim Primitive emit-file
2 groupadd
has? file [IF]
2277 0 #loc prim Primitive flush-file
2280 0 #loc prim Primitive file-status
2285 0 #loc prim Primitive file-eof?
2288 0 #loc prim Primitive open-dir
2296 0 #loc prim Primitive read-dir
2324 0 #loc prim Primitive close-dir
2328 0 #loc prim Primitive filename-match
2338 0 #loc prim Primitive set-dir
2345 0 #loc prim Primitive get-dir
2355 0 #loc prim Primitive =mkdir
10 groupadd
[THEN]
2363 0 #loc prim Primitive newline
1 groupadd
has? os [IF]
2382 0 #loc prim Primitive utime
2388 0 #loc prim Primitive cputime
2406 0 #loc prim Primitive ntime
2419 0 #loc prim Primitive (ns)
4 groupadd
[THEN]
0 groupadd
has? floating [IF]
0 groupadd
group  floating
2439 0 #loc prim Primitive f=
2439 0 #loc prim Primitive f<>
2439 0 #loc prim Primitive f<
2439 0 #loc prim Primitive f>
2439 0 #loc prim Primitive f<=
2439 0 #loc prim Primitive f>=
2440 0 #loc prim Primitive f0=
2440 0 #loc prim Primitive f0<>
2440 0 #loc prim Primitive f0<
2440 0 #loc prim Primitive f0>
2440 0 #loc prim Primitive f0<=
2440 0 #loc prim Primitive f0>=
2442 0 #loc prim Primitive s>f
2445 0 #loc prim Primitive d>f
2461 0 #loc prim Primitive f>d
2465 0 #loc prim Primitive f>s
2468 0 #loc prim Primitive f!
2472 0 #loc prim Primitive f@
2476 0 #loc prim Primitive df@
2484 0 #loc prim Primitive df!
2493 0 #loc prim Primitive sf@
2501 0 #loc prim Primitive sf!
2510 0 #loc prim Primitive f+
2513 0 #loc prim Primitive f-
2516 0 #loc prim Primitive f*
2519 0 #loc prim Primitive f/
2522 0 #loc prim Primitive f**
2528 0 #loc prim Primitive fm*
2531 0 #loc prim Primitive fm/
2534 0 #loc prim Primitive fm*/
2537 0 #loc prim Primitive f**2
2540 0 #loc prim Primitive fnegate
2543 0 #loc prim Primitive fdrop
2546 0 #loc prim Primitive fdup
2548 0 #loc prim Primitive fswap
2550 0 #loc prim Primitive fover
2552 0 #loc prim Primitive frot
2554 0 #loc prim Primitive fnip
2556 0 #loc prim Primitive ftuck
2558 0 #loc prim Primitive float+
2562 0 #loc prim Primitive floats
2566 0 #loc prim Primitive floor
2573 0 #loc prim Primitive fround
2579 0 #loc prim Primitive fmax
2585 0 #loc prim Primitive fmin
2591 0 #loc prim Primitive represent
2622 0 #loc prim Primitive >float
2636 0 #loc prim Primitive fabs
2639 0 #loc prim Primitive facos
2644 0 #loc prim Primitive fasin
2649 0 #loc prim Primitive fatan
2654 0 #loc prim Primitive fatan2
2661 0 #loc prim Primitive fcos
2666 0 #loc prim Primitive fexp
2671 0 #loc prim Primitive fexpm1
2686 0 #loc prim Primitive fln
2691 0 #loc prim Primitive flnp1
2706 0 #loc prim Primitive flog
2712 0 #loc prim Primitive falog
2719 0 #loc prim Primitive fsin
2724 0 #loc prim Primitive fsincos
2730 0 #loc prim Primitive fsqrt
2735 0 #loc prim Primitive ftan
2742 0 #loc prim Primitive fsinh
2749 0 #loc prim Primitive fcosh
2756 0 #loc prim Primitive ftanh
2763 0 #loc prim Primitive fasinh
2770 0 #loc prim Primitive facosh
2777 0 #loc prim Primitive fatanh
2785 0 #loc prim Primitive sfloats
2790 0 #loc prim Primitive dfloats
2795 0 #loc prim Primitive sfaligned
2802 0 #loc prim Primitive dfaligned
2809 0 #loc prim Primitive v*
2819 0 #loc prim Primitive faxpy
2827 0 #loc prim Primitive >float1
2842 0 #loc prim Primitive float/
2845 0 #loc prim Primitive dfloat/
2848 0 #loc prim Primitive sfloat/
2851 0 #loc prim Primitive f-rot
2853 0 #loc prim Primitive flit
81 groupadd
[THEN]
0 groupadd
has? glocals [IF]
0 groupadd
group  locals
2870 0 #loc prim Primitive @local#
2873 0 #loc prim Primitive @local0
2876 0 #loc prim Primitive @local1
2879 0 #loc prim Primitive @local2
2882 0 #loc prim Primitive @local3
5 groupadd
has? floating [IF]
2887 0 #loc prim Primitive f@local#
2890 0 #loc prim Primitive f@local0
2893 0 #loc prim Primitive f@local1
3 groupadd
[THEN]
2898 0 #loc prim Primitive laddr#
2902 0 #loc prim Primitive lp+!#
2909 0 #loc prim Primitive lp-
2912 0 #loc prim Primitive lp+
2916 0 #loc prim Primitive lp+2
2920 0 #loc prim Primitive lp!
2923 0 #loc prim Primitive >l
7 groupadd
has? floating [IF]
2929 0 #loc prim Primitive f>l
2933 0 #loc prim Primitive fpick
2939 0 #loc prim Primitive fthird
2941 0 #loc prim Primitive ffourth
4 groupadd
[THEN]
0 groupadd
[THEN]
0 groupadd
has? OS [IF]
0 groupadd
group  syslib
2950 0 #loc prim Primitive open-lib
2953 0 #loc prim Primitive lib-sym
2969 0 #loc prim Primitive wcall
2974 0 #loc prim Primitive uw@
2980 0 #loc prim Primitive sw@
2986 0 #loc prim Primitive w!
2991 0 #loc prim Primitive ul@
2997 0 #loc prim Primitive sl@
3003 0 #loc prim Primitive l!
3008 0 #loc prim Primitive lib-error
3021 0 #loc prim Primitive be-w!
3030 0 #loc prim Primitive be-l!
3039 0 #loc prim Primitive le-w!
3048 0 #loc prim Primitive le-l!
3057 0 #loc prim Primitive be-uw@
3067 0 #loc prim Primitive be-ul@
3077 0 #loc prim Primitive le-uw@
3087 0 #loc prim Primitive le-ul@
3097 0 #loc prim Primitive close-lib
19 groupadd
[THEN]
0 groupadd
group  64bit
0 groupadd
has? 64bit [IF]
3106 0 #loc prim Primitive x!
3111 0 #loc prim Primitive ux@
3117 0 #loc prim Primitive sx@
3123 0 #loc prim Primitive be-x!
3133 0 #loc prim Primitive le-x!
3143 0 #loc prim Primitive be-ux@
3153 0 #loc prim Primitive le-ux@
7 groupadd
[THEN]
0 groupadd
group  memory
3167 0 #loc prim Primitive xd!
3191 0 #loc prim Primitive uxd@
3213 0 #loc prim Primitive sxd@
3235 0 #loc prim Primitive be-xd!
3267 0 #loc prim Primitive le-xd!
3299 0 #loc prim Primitive be-uxd@
3329 0 #loc prim Primitive le-uxd@
3359 0 #loc prim Primitive w><
3362 0 #loc prim Primitive l><
3365 0 #loc prim Primitive x><
3368 0 #loc prim Primitive xd><
3379 0 #loc prim Primitive c>s
3382 0 #loc prim Primitive w>s
3385 0 #loc prim Primitive l>s
3388 0 #loc prim Primitive >pow2
3405 0 #loc prim Primitive log2
16 groupadd
group  atomic
3428 0 #loc prim Primitive !@
3437 0 #loc prim Primitive +!@
3446 0 #loc prim Primitive ?!@
3455 0 #loc prim Primitive barrier
4 groupadd
group  peephole
0 groupadd
has? peephole [IF]
3465 0 #loc prim Primitive compile-prim1
3469 0 #loc prim Primitive finish-code
3476 0 #loc prim Primitive forget-dyncode
3479 0 #loc prim Primitive decompile-prim
3484 0 #loc prim Primitive tag-offsets
3488 0 #loc prim Primitive finish-code|
6 groupadd
[THEN]
0 groupadd
group  primitive_centric
3502 0 #loc prim Primitive abi-call
3509 0 #loc prim Primitive ;abi-code-exec
3517 0 #loc prim Primitive lit-execute
3 groupadd
group  object_pointer
0 groupadd
has? objects [IF]
3528 0 #loc prim Primitive >o
3532 0 #loc prim Primitive o>
3535 0 #loc prim Primitive o#+
3538 0 #loc prim Primitive o#exec
3544 0 #loc prim Primitive x#exec
3550 0 #loc prim Primitive u#exec
3556 0 #loc prim Primitive u#+
7 groupadd
[THEN]
0 groupadd
group  static_super
0 groupadd
group  end
