1, /* (docol) */
0, /* (docon) */
0, /* (dovar) */
0, /* (douser) */
1, /* (dodefer) */
0, /* (dofield) */
0, /* (dovalue) */
1, /* (dodoes) */
0, /* (doabicode) */
0, /* (do;abicode) */
GROUPADD(10)
GROUP( control, 10)
0, /* noop */
1, /* call */
1, /* execute */
1, /* perform */
1, /* ;s */
1, /* execute-;s */
0, /* unloop */
1, /* lit-perform */
1, /* does-xt */
GROUPADD(9)
#ifdef HAS_GLOCALS
1, /* branch-lp+!# */
GROUPADD(1)
#endif
1, /* branch */
0, /* ?branch */
GROUPADD(2)
#ifdef HAS_GLOCALS
0, /* ?branch-lp+!# */
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
1, /* ?dup-?branch */
1, /* ?dup-0=-?branch */
GROUPADD(2)
#endif
0, /* (next) */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (next)-lp+!# */
GROUPADD(1)
#endif
0, /* (loop) */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (loop)-lp+!# */
GROUPADD(1)
#endif
0, /* (+loop) */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (+loop)-lp+!# */
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
0, /* (-loop) */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (-loop)-lp+!# */
GROUPADD(1)
#endif
0, /* (/loop)# */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (/loop)#-lp+!# */
GROUPADD(1)
#endif
0, /* (s+loop) */
GROUPADD(1)
#ifdef HAS_GLOCALS
0, /* (s+loop)-lp+!# */
GROUPADD(1)
#endif
GROUPADD(0)
#endif
0, /* (for) */
0, /* (do) */
1, /* (?do) */
GROUPADD(3)
#ifdef HAS_XCONDS
1, /* (+do) */
1, /* (u+do) */
1, /* (-do) */
1, /* (u-do) */
0, /* (try) */
0, /* uncatch */
1, /* fast-throw */
0, /* pushwrap */
0, /* dropwrap */
1, /* exit-wrap */
GROUPADD(10)
#endif
0, /* i */
0, /* i' */
0, /* j */
0, /* k */
GROUPADD(4)
GROUP( strings, 54)
0, /* move */
0, /* cmove */
0, /* cmove> */
0, /* fill */
0, /* compare */
0, /* toupper */
0, /* capscompare */
0, /* /string */
0, /* safe/string */
GROUPADD(9)
GROUP( arith, 63)
0, /* lit */
0, /* + */
0, /* lit+ */
0, /* under+ */
0, /* - */
0, /* negate */
0, /* 1+ */
0, /* 1- */
0, /* max */
0, /* min */
0, /* abs */
0, /* * */
0, /* /f */
0, /* modf */
0, /* /modf */
0, /* x/modf */
0, /* x/f */
0, /* /s */
0, /* mods */
0, /* /mods */
0, /* x/mods */
0, /* x/s */
0, /* 2* */
0, /* 2/ */
0, /* fm/mod */
0, /* sm/rem */
0, /* m* */
0, /* um* */
0, /* um/mod */
0, /* u/-stage2m */
0, /* umod-stage2m */
0, /* u/mod-stage2m */
0, /* /f-stage2m */
0, /* modf-stage2m */
0, /* /modf-stage2m */
0, /* m+ */
0, /* d+ */
0, /* d- */
0, /* dnegate */
0, /* d2* */
0, /* d2/ */
0, /* and */
0, /* or */
0, /* xor */
0, /* invert */
0, /* rshift */
0, /* lshift */
0, /* umax */
0, /* umin */
0, /* mux */
0, /* select */
0, /* dlshift */
0, /* drshift */
0, /* rol */
0, /* ror */
0, /* drol */
0, /* dror */
0, /* du/mod */
0, /* u/ */
0, /* umod */
0, /* u/mod */
0, /* ux/mod */
0, /* ux/ */
0, /* arshift */
0, /* darshift */
GROUPADD(65)
GROUP( compare, 128)
0, /* 0= */
0, /* 0<> */
0, /* 0< */
0, /* 0> */
0, /* 0<= */
0, /* 0>= */
0, /* = */
0, /* <> */
0, /* < */
0, /* > */
0, /* <= */
0, /* >= */
0, /* u= */
0, /* u<> */
0, /* u< */
0, /* u> */
0, /* u<= */
0, /* u>= */
GROUPADD(18)
#ifdef HAS_DCOMPS
0, /* d= */
0, /* d<> */
0, /* d< */
0, /* d> */
0, /* d<= */
0, /* d>= */
0, /* d0= */
0, /* d0<> */
0, /* d0< */
0, /* d0> */
0, /* d0<= */
0, /* d0>= */
0, /* du= */
0, /* du<> */
0, /* du< */
0, /* du> */
0, /* du<= */
0, /* du>= */
GROUPADD(18)
#endif
0, /* within */
GROUPADD(1)
GROUP( stack, 165)
0, /* useraddr */
0, /* up! */
0, /* sp@ */
0, /* sp! */
0, /* rp@ */
0, /* rp! */
GROUPADD(6)
#ifdef HAS_FLOATING
0, /* fp@ */
0, /* fp! */
GROUPADD(2)
#endif
0, /* >r */
0, /* r> */
0, /* rdrop */
0, /* 2>r */
0, /* 2r> */
0, /* 2r@ */
0, /* 2rdrop */
0, /* over */
0, /* drop */
0, /* swap */
0, /* dup */
0, /* rot */
0, /* -rot */
0, /* nip */
0, /* tuck */
0, /* ?dup */
0, /* pick */
0, /* third */
0, /* fourth */
0, /* 2drop */
0, /* 2dup */
0, /* 2over */
0, /* 2swap */
0, /* 2rot */
0, /* 2nip */
0, /* 2tuck */
0, /* user@ */
0, /* sps@ */
GROUPADD(28)
GROUP( memory, 201)
0, /* @ */
0, /* lit@ */
0, /* ! */
0, /* +! */
0, /* c@ */
0, /* c! */
0, /* 2! */
0, /* 2@ */
0, /* cell+ */
0, /* cells */
0, /* char+ */
0, /* (chars) */
0, /* count */
0, /* cell/ */
0, /* cell- */
0, /* inc# */
GROUPADD(16)
GROUP( compiler, 217)
GROUPADD(0)
#ifdef HAS_F83HEADERSTRING
0, /* (f83find) */
GROUPADD(1)
#else /* 218 */
0, /* (listlfind) */
GROUPADD(1)
#ifdef HAS_HASH
0, /* (hashlfind) */
0, /* (tablelfind) */
0, /* (hashkey1) */
0, /* (hashkey2) */
0, /* hashkey2 */
GROUPADD(5)
#endif
GROUPADD(0)
#endif
0, /* (parse-white) */
0, /* scan */
0, /* skip */
0, /* aligned */
0, /* faligned */
0, /* threading-method */
0, /* debugging-method */
GROUPADD(7)
GROUP( hostos, 231)
0, /* (key-file) */
0, /* key?-file */
0, /* stdin */
0, /* stdout */
0, /* stderr */
0, /* term-prep? */
GROUPADD(6)
#ifdef HAS_OS
0, /* (form) */
0, /* isatty */
0, /* isfg */
0, /* wcwidth */
0, /* flush-icache */
1, /* (bye) */
0, /* (system) */
0, /* getenv */
0, /* open-pipe */
0, /* close-pipe */
0, /* time&date */
0, /* (ms) */
0, /* heap-allocate */
0, /* heap-free */
0, /* heap-resize */
0, /* strerror */
0, /* strsignal */
0, /* call-c */
0, /* call-c# */
0, /* gforth-pointers */
GROUPADD(20)
#endif
GROUPADD(0)
#ifdef HAS_FILE
0, /* close-file */
0, /* open-file */
0, /* create-file */
0, /* delete-file */
0, /* rename-file */
0, /* file-position */
0, /* reposition-file */
0, /* file-size */
0, /* resize-file */
0, /* read-file */
0, /* (read-line) */
GROUPADD(11)
#endif
0, /* write-file */
0, /* emit-file */
GROUPADD(2)
#ifdef HAS_FILE
0, /* flush-file */
0, /* file-status */
0, /* file-eof? */
0, /* open-dir */
0, /* read-dir */
0, /* close-dir */
0, /* filename-match */
0, /* set-dir */
0, /* get-dir */
0, /* =mkdir */
GROUPADD(10)
#endif
0, /* newline */
GROUPADD(1)
#ifdef HAS_OS
0, /* utime */
0, /* cputime */
0, /* ntime */
0, /* (ns) */
GROUPADD(4)
#endif
GROUPADD(0)
#ifdef HAS_FLOATING
GROUPADD(0)
GROUP( floating, 285)
0, /* f= */
0, /* f<> */
0, /* f< */
0, /* f> */
0, /* f<= */
0, /* f>= */
0, /* f0= */
0, /* f0<> */
0, /* f0< */
0, /* f0> */
0, /* f0<= */
0, /* f0>= */
0, /* s>f */
0, /* d>f */
0, /* f>d */
0, /* f>s */
0, /* f! */
0, /* f@ */
0, /* df@ */
0, /* df! */
0, /* sf@ */
0, /* sf! */
0, /* f+ */
0, /* f- */
0, /* f* */
0, /* f/ */
0, /* f** */
0, /* fm* */
0, /* fm/ */
0, /* fmx/ */
0, /* f**2 */
0, /* fnegate */
0, /* fdrop */
0, /* fdup */
0, /* fswap */
0, /* fover */
0, /* frot */
0, /* fnip */
0, /* ftuck */
0, /* float+ */
0, /* floats */
0, /* floor */
0, /* fround */
0, /* fmax */
0, /* fmin */
0, /* represent */
0, /* >float */
0, /* fabs */
0, /* facos */
0, /* fasin */
0, /* fatan */
0, /* fatan2 */
0, /* fcos */
0, /* fexp */
0, /* fexpm1 */
0, /* fln */
0, /* flnp1 */
0, /* flog */
0, /* falog */
0, /* fsin */
0, /* fsincos */
0, /* fsqrt */
0, /* ftan */
0, /* fsinh */
0, /* fcosh */
0, /* ftanh */
0, /* fasinh */
0, /* facosh */
0, /* fatanh */
0, /* sfloats */
0, /* dfloats */
0, /* sfaligned */
0, /* dfaligned */
0, /* v* */
0, /* faxpy */
0, /* >float1 */
0, /* float/ */
0, /* dfloat/ */
0, /* sfloat/ */
0, /* f-rot */
0, /* flit */
GROUPADD(81)
#endif
GROUPADD(0)
#ifdef HAS_GLOCALS
GROUPADD(0)
GROUP( locals, 366)
0, /* @local# */
0, /* @local0 */
0, /* @local1 */
0, /* @local2 */
0, /* @local3 */
GROUPADD(5)
#ifdef HAS_FLOATING
0, /* f@local# */
0, /* f@local0 */
0, /* f@local1 */
GROUPADD(3)
#endif
0, /* laddr# */
0, /* lp+!# */
0, /* lp- */
0, /* lp+ */
0, /* lp+2 */
0, /* lp! */
0, /* >l */
GROUPADD(7)
#ifdef HAS_FLOATING
0, /* f>l */
0, /* fpick */
0, /* fthird */
0, /* ffourth */
GROUPADD(4)
#endif
GROUPADD(0)
#endif
GROUPADD(0)
#ifdef HAS_OS
GROUPADD(0)
GROUP( syslib, 385)
0, /* open-lib */
0, /* lib-sym */
0, /* wcall */
0, /* uw@ */
0, /* sw@ */
0, /* w! */
0, /* ul@ */
0, /* sl@ */
0, /* l! */
0, /* lib-error */
0, /* be-w! */
0, /* be-l! */
0, /* le-w! */
0, /* le-l! */
0, /* be-uw@ */
0, /* be-ul@ */
0, /* le-uw@ */
0, /* le-ul@ */
0, /* close-lib */
GROUPADD(19)
#endif
GROUPADD(0)
GROUP( 64bit, 404)
GROUPADD(0)
#ifdef HAS_64BIT
0, /* x! */
0, /* ux@ */
0, /* sx@ */
0, /* be-x! */
0, /* le-x! */
0, /* be-ux@ */
0, /* le-ux@ */
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( memory, 411)
0, /* xd! */
0, /* uxd@ */
0, /* sxd@ */
0, /* be-xd! */
0, /* le-xd! */
0, /* be-uxd@ */
0, /* le-uxd@ */
0, /* w>< */
0, /* l>< */
0, /* x>< */
0, /* xd>< */
0, /* c>s */
0, /* w>s */
0, /* l>s */
0, /* >pow2 */
0, /* log2 */
GROUPADD(16)
GROUP( atomic, 427)
0, /* !@ */
0, /* +!@ */
0, /* ?!@ */
0, /* barrier */
GROUPADD(4)
GROUP( peephole, 431)
GROUPADD(0)
#ifdef HAS_PEEPHOLE
0, /* compile-prim1 */
0, /* finish-code */
0, /* forget-dyncode */
0, /* decompile-prim */
0, /* tag-offsets */
0, /* finish-code| */
GROUPADD(6)
#endif
GROUPADD(0)
GROUP( primitive_centric, 437)
0, /* abi-call */
0, /* ;abi-code-exec */
1, /* lit-execute */
GROUPADD(3)
GROUP( object_pointer, 440)
GROUPADD(0)
#ifdef HAS_OBJECTS
0, /* >o */
0, /* o> */
0, /* o#+ */
1, /* o#exec */
1, /* x#exec */
1, /* u#exec */
0, /* u#+ */
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( static_super, 447)
1, /* super2 */
0, /* super6 */
1, /* super11 */
0, /* super15 */
0, /* super16 */
1, /* super18 */
0, /* super19 */
0, /* super23 */
1, /* super25 */
0, /* super26 */
0, /* super27 */
0, /* super29 */
0, /* super30 */
0, /* super31 */
0, /* super32 */
0, /* super33 */
0, /* super34 */
0, /* super35 */
0, /* super36 */
0, /* super37 */
0, /* super38 */
0, /* super39 */
0, /* super40 */
0, /* cb1 */
0, /* cb2 */
0, /* cb3 */
0, /* cb4 */
0, /* cb5 */
0, /* cb6 */
0, /* cb7 */
0, /* cb8 */
0, /* cb9 */
0, /* cb10 */
0, /* cb11 */
0, /* cb12 */
0, /* cb13 */
0, /* cb14 */
0, /* cb15 */
0, /* cb16 */
0, /* cb17 */
0, /* cb18 */
0, /* cb19 */
0, /* cb20 */
0, /* cb21 */
0, /* cb22 */
0, /* cscfetch */
0, /* cswfetch */
0, /* cslfetch */
0, /* swapwfetch */
0, /* swaplfetch */
0, /* csswapwfetch */
0, /* csswaplfetch */
0, /* lit */
0, /* lit@ */
0, /* dup */
0, /* under+ */
0, /* i */
0, /* useraddr */
0, /* over */
0, /* 2dup */
0, /* drop */
0, /* drop */
0, /* >r */
0, /* r> */
0, /* lp+!# */
0, /* unloop */
0, /* lp+ */
0, /* @local0 */
0, /* nip */
0, /* lp- */
0, /* @local# */
0, /* 2drop */
0, /* 2drop */
0, /* @local2 */
0, /* rdrop */
0, /* @local1 */
0, /* i' */
0, /* laddr# */
0, /* j */
0, /* 2rdrop */
0, /* f@ */
0, /* f+ */
0, /* f* */
0, /* f! */
0, /* >l */
0, /* abi-call */
0, /* ;abi-code-exec */
0, /* noop */
0, /* noop */
GROUPADD(52)
GROUP( end, 499)
