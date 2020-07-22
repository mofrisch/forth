"(docol)",
"(docon)",
"(dovar)",
"(douser)",
"(dodefer)",
"(dofield)",
"(dovalue)",
"(dodoes)",
"(doabicode)",
"(do;abicode)",
GROUPADD(10)
GROUP( control, 10)
"noop",
"call",
"execute",
"perform",
";s",
"execute-;s",
"unloop",
"lit-perform",
"does-xt",
GROUPADD(9)
#ifdef HAS_GLOCALS
"branch-lp+!#",
GROUPADD(1)
#endif
"branch",
"?branch",
GROUPADD(2)
#ifdef HAS_GLOCALS
"?branch-lp+!#",
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
"?dup-?branch",
"?dup-0=-?branch",
GROUPADD(2)
#endif
"(next)",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(next)-lp+!#",
GROUPADD(1)
#endif
"(loop)",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(loop)-lp+!#",
GROUPADD(1)
#endif
"(+loop)",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(+loop)-lp+!#",
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
"(-loop)",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(-loop)-lp+!#",
GROUPADD(1)
#endif
"(/loop)#",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(/loop)#-lp+!#",
GROUPADD(1)
#endif
"(s+loop)",
GROUPADD(1)
#ifdef HAS_GLOCALS
"(s+loop)-lp+!#",
GROUPADD(1)
#endif
GROUPADD(0)
#endif
"(for)",
"(do)",
"(?do)",
GROUPADD(3)
#ifdef HAS_XCONDS
"(+do)",
"(u+do)",
"(-do)",
"(u-do)",
"(try)",
"uncatch",
"fast-throw",
"pushwrap",
"dropwrap",
"exit-wrap",
GROUPADD(10)
#endif
"i",
"i'",
"j",
"k",
GROUPADD(4)
GROUP( strings, 54)
"move",
"cmove",
"cmove>",
"fill",
"compare",
"toupper",
"capscompare",
"/string",
"safe/string",
GROUPADD(9)
GROUP( arith, 63)
"lit",
"+",
"lit+",
"under+",
"-",
"negate",
"1+",
"1-",
"max",
"min",
"abs",
"*",
"/f",
"modf",
"/modf",
"*/modf",
"*/f",
"/s",
"mods",
"/mods",
"*/mods",
"*/s",
"2*",
"2/",
"fm/mod",
"sm/rem",
"m*",
"um*",
"um/mod",
"u/-stage2m",
"umod-stage2m",
"u/mod-stage2m",
"/f-stage2m",
"modf-stage2m",
"/modf-stage2m",
"m+",
"d+",
"d-",
"dnegate",
"d2*",
"d2/",
"and",
"or",
"xor",
"invert",
"rshift",
"lshift",
"umax",
"umin",
"mux",
"select",
"dlshift",
"drshift",
"rol",
"ror",
"drol",
"dror",
"du/mod",
"u/",
"umod",
"u/mod",
"u*/mod",
"u*/",
"arshift",
"darshift",
GROUPADD(65)
GROUP( compare, 128)
"0=",
"0<>",
"0<",
"0>",
"0<=",
"0>=",
"=",
"<>",
"<",
">",
"<=",
">=",
"u=",
"u<>",
"u<",
"u>",
"u<=",
"u>=",
GROUPADD(18)
#ifdef HAS_DCOMPS
"d=",
"d<>",
"d<",
"d>",
"d<=",
"d>=",
"d0=",
"d0<>",
"d0<",
"d0>",
"d0<=",
"d0>=",
"du=",
"du<>",
"du<",
"du>",
"du<=",
"du>=",
GROUPADD(18)
#endif
"within",
GROUPADD(1)
GROUP( stack, 165)
"useraddr",
"up!",
"sp@",
"sp!",
"rp@",
"rp!",
GROUPADD(6)
#ifdef HAS_FLOATING
"fp@",
"fp!",
GROUPADD(2)
#endif
">r",
"r>",
"rdrop",
"2>r",
"2r>",
"2r@",
"2rdrop",
"over",
"drop",
"swap",
"dup",
"rot",
"-rot",
"nip",
"tuck",
"?dup",
"pick",
"third",
"fourth",
"2drop",
"2dup",
"2over",
"2swap",
"2rot",
"2nip",
"2tuck",
"user@",
"sps@",
GROUPADD(28)
GROUP( memory, 201)
"@",
"lit@",
"!",
"+!",
"c@",
"c!",
"2!",
"2@",
"cell+",
"cells",
"char+",
"(chars)",
"count",
"cell/",
"cell-",
"inc#",
GROUPADD(16)
GROUP( compiler, 217)
GROUPADD(0)
#ifdef HAS_F83HEADERSTRING
"(f83find)",
GROUPADD(1)
#else /* 218 */
"(listlfind)",
GROUPADD(1)
#ifdef HAS_HASH
"(hashlfind)",
"(tablelfind)",
"(hashkey1)",
"(hashkey2)",
"hashkey2",
GROUPADD(5)
#endif
GROUPADD(0)
#endif
"(parse-white)",
"scan",
"skip",
"aligned",
"faligned",
"threading-method",
"debugging-method",
GROUPADD(7)
GROUP( hostos, 231)
"(key-file)",
"key?-file",
"stdin",
"stdout",
"stderr",
"term-prep?",
GROUPADD(6)
#ifdef HAS_OS
"(form)",
"isatty",
"isfg",
"wcwidth",
"flush-icache",
"(bye)",
"(system)",
"getenv",
"open-pipe",
"close-pipe",
"time&date",
"(ms)",
"heap-allocate",
"heap-free",
"heap-resize",
"strerror",
"strsignal",
"call-c",
"call-c#",
"gforth-pointers",
GROUPADD(20)
#endif
GROUPADD(0)
#ifdef HAS_FILE
"close-file",
"open-file",
"create-file",
"delete-file",
"rename-file",
"file-position",
"reposition-file",
"file-size",
"resize-file",
"read-file",
"(read-line)",
GROUPADD(11)
#endif
"write-file",
"emit-file",
GROUPADD(2)
#ifdef HAS_FILE
"flush-file",
"file-status",
"file-eof?",
"open-dir",
"read-dir",
"close-dir",
"filename-match",
"set-dir",
"get-dir",
"=mkdir",
GROUPADD(10)
#endif
"newline",
GROUPADD(1)
#ifdef HAS_OS
"utime",
"cputime",
"ntime",
"(ns)",
GROUPADD(4)
#endif
GROUPADD(0)
#ifdef HAS_FLOATING
GROUPADD(0)
GROUP( floating, 285)
"f=",
"f<>",
"f<",
"f>",
"f<=",
"f>=",
"f0=",
"f0<>",
"f0<",
"f0>",
"f0<=",
"f0>=",
"s>f",
"d>f",
"f>d",
"f>s",
"f!",
"f@",
"df@",
"df!",
"sf@",
"sf!",
"f+",
"f-",
"f*",
"f/",
"f**",
"fm*",
"fm/",
"fm*/",
"f**2",
"fnegate",
"fdrop",
"fdup",
"fswap",
"fover",
"frot",
"fnip",
"ftuck",
"float+",
"floats",
"floor",
"fround",
"fmax",
"fmin",
"represent",
">float",
"fabs",
"facos",
"fasin",
"fatan",
"fatan2",
"fcos",
"fexp",
"fexpm1",
"fln",
"flnp1",
"flog",
"falog",
"fsin",
"fsincos",
"fsqrt",
"ftan",
"fsinh",
"fcosh",
"ftanh",
"fasinh",
"facosh",
"fatanh",
"sfloats",
"dfloats",
"sfaligned",
"dfaligned",
"v*",
"faxpy",
">float1",
"float/",
"dfloat/",
"sfloat/",
"f-rot",
"flit",
GROUPADD(81)
#endif
GROUPADD(0)
#ifdef HAS_GLOCALS
GROUPADD(0)
GROUP( locals, 366)
"@local#",
"@local0",
"@local1",
"@local2",
"@local3",
GROUPADD(5)
#ifdef HAS_FLOATING
"f@local#",
"f@local0",
"f@local1",
GROUPADD(3)
#endif
"laddr#",
"lp+!#",
"lp-",
"lp+",
"lp+2",
"lp!",
">l",
GROUPADD(7)
#ifdef HAS_FLOATING
"f>l",
"fpick",
"fthird",
"ffourth",
GROUPADD(4)
#endif
GROUPADD(0)
#endif
GROUPADD(0)
#ifdef HAS_OS
GROUPADD(0)
GROUP( syslib, 385)
"open-lib",
"lib-sym",
"wcall",
"uw@",
"sw@",
"w!",
"ul@",
"sl@",
"l!",
"lib-error",
"be-w!",
"be-l!",
"le-w!",
"le-l!",
"be-uw@",
"be-ul@",
"le-uw@",
"le-ul@",
"close-lib",
GROUPADD(19)
#endif
GROUPADD(0)
GROUP( 64bit, 404)
GROUPADD(0)
#ifdef HAS_64BIT
"x!",
"ux@",
"sx@",
"be-x!",
"le-x!",
"be-ux@",
"le-ux@",
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( memory, 411)
"xd!",
"uxd@",
"sxd@",
"be-xd!",
"le-xd!",
"be-uxd@",
"le-uxd@",
"w><",
"l><",
"x><",
"xd><",
"c>s",
"w>s",
"l>s",
">pow2",
"log2",
GROUPADD(16)
GROUP( atomic, 427)
"!@",
"+!@",
"?!@",
"barrier",
GROUPADD(4)
GROUP( peephole, 431)
GROUPADD(0)
#ifdef HAS_PEEPHOLE
"compile-prim1",
"finish-code",
"forget-dyncode",
"decompile-prim",
"tag-offsets",
"finish-code|",
GROUPADD(6)
#endif
GROUPADD(0)
GROUP( primitive_centric, 437)
"abi-call",
";abi-code-exec",
"lit-execute",
GROUPADD(3)
GROUP( object_pointer, 440)
GROUPADD(0)
#ifdef HAS_OBJECTS
">o",
"o>",
"o#+",
"o#exec",
"x#exec",
"u#exec",
"u#+",
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( static_super, 447)
GROUPADD(0)
GROUP( end, 447)
