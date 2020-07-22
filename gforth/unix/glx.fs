\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library glx
s" GLX" add-lib
\c #include <GL/glx.h>

\ ----===< int constants >===-----
#1	constant GLX_VERSION_1_1
#1	constant GLX_VERSION_1_2
#1	constant GLX_VERSION_1_3
#1	constant GLX_VERSION_1_4
#1	constant GLX_USE_GL
#2	constant GLX_BUFFER_SIZE
#3	constant GLX_LEVEL
#4	constant GLX_RGBA
#5	constant GLX_DOUBLEBUFFER
#6	constant GLX_STEREO
#7	constant GLX_AUX_BUFFERS
#8	constant GLX_RED_SIZE
#9	constant GLX_GREEN_SIZE
#10	constant GLX_BLUE_SIZE
#11	constant GLX_ALPHA_SIZE
#12	constant GLX_DEPTH_SIZE
#13	constant GLX_STENCIL_SIZE
#14	constant GLX_ACCUM_RED_SIZE
#15	constant GLX_ACCUM_GREEN_SIZE
#16	constant GLX_ACCUM_BLUE_SIZE
#17	constant GLX_ACCUM_ALPHA_SIZE
#1	constant GLX_BAD_SCREEN
#2	constant GLX_BAD_ATTRIBUTE
#3	constant GLX_NO_EXTENSION
#4	constant GLX_BAD_VISUAL
#5	constant GLX_BAD_CONTEXT
#6	constant GLX_BAD_VALUE
#7	constant GLX_BAD_ENUM
#1	constant GLX_VENDOR
#2	constant GLX_VERSION
#3	constant GLX_EXTENSIONS
#32	constant GLX_CONFIG_CAVEAT
#4294967295	constant GLX_DONT_CARE
#34	constant GLX_X_VISUAL_TYPE
#35	constant GLX_TRANSPARENT_TYPE
#36	constant GLX_TRANSPARENT_INDEX_VALUE
#37	constant GLX_TRANSPARENT_RED_VALUE
#38	constant GLX_TRANSPARENT_GREEN_VALUE
#39	constant GLX_TRANSPARENT_BLUE_VALUE
#40	constant GLX_TRANSPARENT_ALPHA_VALUE
#1	constant GLX_WINDOW_BIT
#2	constant GLX_PIXMAP_BIT
#4	constant GLX_PBUFFER_BIT
#16	constant GLX_AUX_BUFFERS_BIT
#1	constant GLX_FRONT_LEFT_BUFFER_BIT
#2	constant GLX_FRONT_RIGHT_BUFFER_BIT
#4	constant GLX_BACK_LEFT_BUFFER_BIT
#8	constant GLX_BACK_RIGHT_BUFFER_BIT
#32	constant GLX_DEPTH_BUFFER_BIT
#64	constant GLX_STENCIL_BUFFER_BIT
#128	constant GLX_ACCUM_BUFFER_BIT
#32768	constant GLX_NONE
#32769	constant GLX_SLOW_CONFIG
#32770	constant GLX_TRUE_COLOR
#32771	constant GLX_DIRECT_COLOR
#32772	constant GLX_PSEUDO_COLOR
#32773	constant GLX_STATIC_COLOR
#32774	constant GLX_GRAY_SCALE
#32775	constant GLX_STATIC_GRAY
#32776	constant GLX_TRANSPARENT_RGB
#32777	constant GLX_TRANSPARENT_INDEX
#32779	constant GLX_VISUAL_ID
#32780	constant GLX_SCREEN
#32781	constant GLX_NON_CONFORMANT_CONFIG
#32784	constant GLX_DRAWABLE_TYPE
#32785	constant GLX_RENDER_TYPE
#32786	constant GLX_X_RENDERABLE
#32787	constant GLX_FBCONFIG_ID
#32788	constant GLX_RGBA_TYPE
#32789	constant GLX_COLOR_INDEX_TYPE
#32790	constant GLX_MAX_PBUFFER_WIDTH
#32791	constant GLX_MAX_PBUFFER_HEIGHT
#32792	constant GLX_MAX_PBUFFER_PIXELS
#32795	constant GLX_PRESERVED_CONTENTS
#32796	constant GLX_LARGEST_PBUFFER
#32797	constant GLX_WIDTH
#32798	constant GLX_HEIGHT
#32799	constant GLX_EVENT_MASK
#32800	constant GLX_DAMAGED
#32801	constant GLX_SAVED
#32802	constant GLX_WINDOW
#32803	constant GLX_PBUFFER
#32832	constant GLX_PBUFFER_HEIGHT
#32833	constant GLX_PBUFFER_WIDTH
#1	constant GLX_RGBA_BIT
#2	constant GLX_COLOR_INDEX_BIT
#134217728	constant GLX_PBUFFER_CLOBBER_MASK
#100000	constant GLX_SAMPLE_BUFFERS
#100001	constant GLX_SAMPLES
#0	constant GLX_PbufferClobber
#1	constant GLX_BufferSwapComplete
#17	constant __GLX_NUMBER_EVENTS
#1	constant GLX_ARB_get_proc_address
#1	constant GLX_ARB_render_texture
#1	constant GLX_MESA_swap_frame_usage
#1	constant GLX_MESA_swap_control

\ -------===< structs >===--------
\ GLXPbufferClobberEvent
begin-structure GLXPbufferClobberEvent
	drop 24 8 +field GLXPbufferClobberEvent-display
	drop 44 4 +field GLXPbufferClobberEvent-aux_buffer
	drop 48 4 +field GLXPbufferClobberEvent-x
	drop 52 4 +field GLXPbufferClobberEvent-y
	drop 64 4 +field GLXPbufferClobberEvent-count
	drop 4 4 +field GLXPbufferClobberEvent-draw_type
	drop 8 8 +field GLXPbufferClobberEvent-serial
	drop 32 8 +field GLXPbufferClobberEvent-drawable
	drop 60 4 +field GLXPbufferClobberEvent-height
	drop 0 4 +field GLXPbufferClobberEvent-event_type
	drop 16 4 +field GLXPbufferClobberEvent-send_event
	drop 40 4 +field GLXPbufferClobberEvent-buffer_mask
	drop 56 4 +field GLXPbufferClobberEvent-width
drop 72 end-structure
\ GLXBufferSwapComplete
begin-structure GLXBufferSwapComplete
	drop 24 8 +field GLXBufferSwapComplete-display
	drop 56 8 +field GLXBufferSwapComplete-msc
	drop 64 8 +field GLXBufferSwapComplete-sbc
	drop 8 8 +field GLXBufferSwapComplete-serial
	drop 32 8 +field GLXBufferSwapComplete-drawable
	drop 0 4 +field GLXBufferSwapComplete-type
	drop 16 4 +field GLXBufferSwapComplete-send_event
	drop 40 4 +field GLXBufferSwapComplete-event_type
	drop 48 8 +field GLXBufferSwapComplete-ust
drop 72 end-structure
\ GLXEvent
begin-structure GLXEvent
drop 192 end-structure

\ ------===< callbacks >===-------
c-callback PFNGLXGETFBCONFIGSPROC: a n a -- a	( dpy screen nelements -- )
c-callback PFNGLXCHOOSEFBCONFIGPROC: a n a a -- a	( dpy screen attrib_list nelements -- )
c-callback PFNGLXGETFBCONFIGATTRIBPROC: a a n a -- n	( dpy config attribute value -- )
c-callback PFNGLXGETVISUALFROMFBCONFIGPROC: a a -- a	( dpy config -- )
c-callback PFNGLXCREATEWINDOWPROC: a a n a -- n	( dpy config win attrib_list -- )
c-callback PFNGLXDESTROYWINDOWPROC: a n -- void	( dpy win -- )
c-callback PFNGLXCREATEPIXMAPPROC: a a n a -- n	( dpy config pixmap attrib_list -- )
c-callback PFNGLXDESTROYPIXMAPPROC: a n -- void	( dpy pixmap -- )
c-callback PFNGLXCREATEPBUFFERPROC: a a a -- n	( dpy config attrib_list -- )
c-callback PFNGLXDESTROYPBUFFERPROC: a n -- void	( dpy pbuf -- )
c-callback PFNGLXQUERYDRAWABLEPROC: a n n a -- void	( dpy draw attribute value -- )
c-callback PFNGLXCREATENEWCONTEXTPROC: a a n a n -- a	( dpy config render_type share_list direct -- )
c-callback PFNGLXMAKECONTEXTCURRENTPROC: a n n a -- n	( dpy draw read ctx -- )
c-callback PFNGLXGETCURRENTREADDRAWABLEPROC:  -- n	( <noname> -- )
c-callback PFNGLXGETCURRENTDISPLAYPROC:  -- a	( <noname> -- )
c-callback PFNGLXQUERYCONTEXTPROC: a a n a -- n	( dpy ctx attribute value -- )
c-callback PFNGLXSELECTEVENTPROC: a n u -- void	( dpy draw event_mask -- )
c-callback PFNGLXGETSELECTEDEVENTPROC: a n a -- void	( dpy draw event_mask -- )
c-callback __GLXextFuncPtr:  -- void	( <noname> -- )
c-callback PFNGLXGETPROCADDRESSPROC: a -- a	( procName -- )
c-callback PFNGLXALLOCATEMEMORYNVPROC: n r r r -- a	( size readfreq writefreq priority -- )
c-callback PFNGLXFREEMEMORYNVPROC: a -- void	( pointer -- )
c-callback PFNGLXGETFRAMEUSAGEMESAPROC: a n a -- n	( dpy drawable usage -- )
c-callback PFNGLXBEGINFRAMETRACKINGMESAPROC: a n -- n	( dpy drawable -- )
c-callback PFNGLXENDFRAMETRACKINGMESAPROC: a n -- n	( dpy drawable -- )
c-callback PFNGLXQUERYFRAMETRACKINGMESAPROC: a n a a a -- n	( dpy drawable swapCount missedFrames lastMissedUsage -- )
c-callback PFNGLXSWAPINTERVALMESAPROC: u -- n	( interval -- )
c-callback PFNGLXGETSWAPINTERVALMESAPROC:  -- n	( <noname> -- )

\ ------===< functions >===-------
c-function glXChooseVisual glXChooseVisual a n a -- a	( dpy screen attribList -- )
c-function glXCreateContext glXCreateContext a a a n -- a	( dpy vis shareList direct -- )
c-function glXDestroyContext glXDestroyContext a a -- void	( dpy ctx -- )
c-function glXMakeCurrent glXMakeCurrent a n a -- n	( dpy drawable ctx -- )
c-function glXCopyContext glXCopyContext a a a u -- void	( dpy src dst mask -- )
c-function glXSwapBuffers glXSwapBuffers a n -- void	( dpy drawable -- )
c-function glXCreateGLXPixmap glXCreateGLXPixmap a a n -- n	( dpy visual pixmap -- )
c-function glXDestroyGLXPixmap glXDestroyGLXPixmap a n -- void	( dpy pixmap -- )
c-function glXQueryExtension glXQueryExtension a a a -- n	( dpy errorb event -- )
c-function glXQueryVersion glXQueryVersion a a a -- n	( dpy maj min -- )
c-function glXIsDirect glXIsDirect a a -- n	( dpy ctx -- )
c-function glXGetConfig glXGetConfig a a n a -- n	( dpy visual attrib value -- )
c-function glXGetCurrentContext glXGetCurrentContext  -- a	( -- )
c-function glXGetCurrentDrawable glXGetCurrentDrawable  -- n	( -- )
c-function glXWaitGL glXWaitGL  -- void	( -- )
c-function glXWaitX glXWaitX  -- void	( -- )
c-function glXUseXFont glXUseXFont n n n n -- void	( font first count list -- )
c-function glXQueryExtensionsString glXQueryExtensionsString a n -- s	( dpy screen -- )
c-function glXQueryServerString glXQueryServerString a n n -- s	( dpy screen name -- )
c-function glXGetClientString glXGetClientString a n -- s	( dpy name -- )
c-function glXGetCurrentDisplay glXGetCurrentDisplay  -- a	( -- )
c-function glXChooseFBConfig glXChooseFBConfig a n a a -- a	( dpy screen attribList nitems -- )
c-function glXGetFBConfigAttrib glXGetFBConfigAttrib a a n a -- n	( dpy config attribute value -- )
c-function glXGetFBConfigs glXGetFBConfigs a n a -- a	( dpy screen nelements -- )
c-function glXGetVisualFromFBConfig glXGetVisualFromFBConfig a a -- a	( dpy config -- )
c-function glXCreateWindow glXCreateWindow a a n a -- n	( dpy config win attribList -- )
c-function glXDestroyWindow glXDestroyWindow a n -- void	( dpy window -- )
c-function glXCreatePixmap glXCreatePixmap a a n a -- n	( dpy config pixmap attribList -- )
c-function glXDestroyPixmap glXDestroyPixmap a n -- void	( dpy pixmap -- )
c-function glXCreatePbuffer glXCreatePbuffer a a a -- n	( dpy config attribList -- )
c-function glXDestroyPbuffer glXDestroyPbuffer a n -- void	( dpy pbuf -- )
c-function glXQueryDrawable glXQueryDrawable a n n a -- void	( dpy draw attribute value -- )
c-function glXCreateNewContext glXCreateNewContext a a n a n -- a	( dpy config renderType shareList direct -- )
c-function glXMakeContextCurrent glXMakeContextCurrent a n n a -- n	( dpy draw read ctx -- )
c-function glXGetCurrentReadDrawable glXGetCurrentReadDrawable  -- n	( -- )
c-function glXQueryContext glXQueryContext a a n a -- n	( dpy ctx attribute value -- )
c-function glXSelectEvent glXSelectEvent a n u -- void	( dpy drawable mask -- )
c-function glXGetSelectedEvent glXGetSelectedEvent a n a -- void	( dpy drawable mask -- )
c-function glXGetProcAddressARB glXGetProcAddressARB a -- a	( <noname> -- )
c-function glXGetProcAddress glXGetProcAddress a -- a	( procname -- )
c-function glXAllocateMemoryNV glXAllocateMemoryNV n r r r -- a	( size readfreq writefreq priority -- )
c-function glXFreeMemoryNV glXFreeMemoryNV a -- void	( pointer -- )
c-function glXBindTexImageARB glXBindTexImageARB a n n -- n	( dpy pbuffer buffer -- )
c-function glXReleaseTexImageARB glXReleaseTexImageARB a n n -- n	( dpy pbuffer buffer -- )
c-function glXDrawableAttribARB glXDrawableAttribARB a n a -- n	( dpy draw attribList -- )
c-function glXGetFrameUsageMESA glXGetFrameUsageMESA a n a -- n	( dpy drawable usage -- )
c-function glXBeginFrameTrackingMESA glXBeginFrameTrackingMESA a n -- n	( dpy drawable -- )
c-function glXEndFrameTrackingMESA glXEndFrameTrackingMESA a n -- n	( dpy drawable -- )
c-function glXQueryFrameTrackingMESA glXQueryFrameTrackingMESA a n a a a -- n	( dpy drawable swapCount missedFrames lastMissedUsage -- )
c-function glXSwapIntervalMESA glXSwapIntervalMESA u -- n	( interval -- )
c-function glXGetSwapIntervalMESA glXGetSwapIntervalMESA  -- n	( -- )

\ ----===< postfix >===-----
end-c-library
