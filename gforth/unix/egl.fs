\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library egl
s" EGL" add-lib
\c #include <EGL/egl.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ ----===< int constants >===-----
#1	constant __egl_h_
#1	constant EGL_EGL_PROTOTYPES
#1	constant EGL_VERSION_1_0
#12321	constant EGL_ALPHA_SIZE
#12290	constant EGL_BAD_ACCESS
#12291	constant EGL_BAD_ALLOC
#12292	constant EGL_BAD_ATTRIBUTE
#12293	constant EGL_BAD_CONFIG
#12294	constant EGL_BAD_CONTEXT
#12295	constant EGL_BAD_CURRENT_SURFACE
#12296	constant EGL_BAD_DISPLAY
#12297	constant EGL_BAD_MATCH
#12298	constant EGL_BAD_NATIVE_PIXMAP
#12299	constant EGL_BAD_NATIVE_WINDOW
#12300	constant EGL_BAD_PARAMETER
#12301	constant EGL_BAD_SURFACE
#12322	constant EGL_BLUE_SIZE
#12320	constant EGL_BUFFER_SIZE
#12327	constant EGL_CONFIG_CAVEAT
#12328	constant EGL_CONFIG_ID
#12379	constant EGL_CORE_NATIVE_ENGINE
#12325	constant EGL_DEPTH_SIZE
#12377	constant EGL_DRAW
#12373	constant EGL_EXTENSIONS
#0	constant EGL_FALSE
#12323	constant EGL_GREEN_SIZE
#12374	constant EGL_HEIGHT
#12376	constant EGL_LARGEST_PBUFFER
#12329	constant EGL_LEVEL
#12330	constant EGL_MAX_PBUFFER_HEIGHT
#12331	constant EGL_MAX_PBUFFER_PIXELS
#12332	constant EGL_MAX_PBUFFER_WIDTH
#12333	constant EGL_NATIVE_RENDERABLE
#12334	constant EGL_NATIVE_VISUAL_ID
#12335	constant EGL_NATIVE_VISUAL_TYPE
#12344	constant EGL_NONE
#12369	constant EGL_NON_CONFORMANT_CONFIG
#12289	constant EGL_NOT_INITIALIZED
#1	constant EGL_PBUFFER_BIT
#2	constant EGL_PIXMAP_BIT
#12378	constant EGL_READ
#12324	constant EGL_RED_SIZE
#12337	constant EGL_SAMPLES
#12338	constant EGL_SAMPLE_BUFFERS
#12368	constant EGL_SLOW_CONFIG
#12326	constant EGL_STENCIL_SIZE
#12288	constant EGL_SUCCESS
#12339	constant EGL_SURFACE_TYPE
#12341	constant EGL_TRANSPARENT_BLUE_VALUE
#12342	constant EGL_TRANSPARENT_GREEN_VALUE
#12343	constant EGL_TRANSPARENT_RED_VALUE
#12370	constant EGL_TRANSPARENT_RGB
#12340	constant EGL_TRANSPARENT_TYPE
#1	constant EGL_TRUE
#12371	constant EGL_VENDOR
#12372	constant EGL_VERSION
#12375	constant EGL_WIDTH
#4	constant EGL_WINDOW_BIT
#1	constant EGL_VERSION_1_1
#12420	constant EGL_BACK_BUFFER
#12345	constant EGL_BIND_TO_TEXTURE_RGB
#12346	constant EGL_BIND_TO_TEXTURE_RGBA
#12302	constant EGL_CONTEXT_LOST
#12347	constant EGL_MIN_SWAP_INTERVAL
#12348	constant EGL_MAX_SWAP_INTERVAL
#12418	constant EGL_MIPMAP_TEXTURE
#12419	constant EGL_MIPMAP_LEVEL
#12380	constant EGL_NO_TEXTURE
#12383	constant EGL_TEXTURE_2D
#12416	constant EGL_TEXTURE_FORMAT
#12381	constant EGL_TEXTURE_RGB
#12382	constant EGL_TEXTURE_RGBA
#12417	constant EGL_TEXTURE_TARGET
#1	constant EGL_VERSION_1_2
#12424	constant EGL_ALPHA_FORMAT
#12427	constant EGL_ALPHA_FORMAT_NONPRE
#12428	constant EGL_ALPHA_FORMAT_PRE
#12350	constant EGL_ALPHA_MASK_SIZE
#12436	constant EGL_BUFFER_PRESERVED
#12437	constant EGL_BUFFER_DESTROYED
#12429	constant EGL_CLIENT_APIS
#12423	constant EGL_COLORSPACE
#12425	constant EGL_COLORSPACE_sRGB
#12426	constant EGL_COLORSPACE_LINEAR
#12351	constant EGL_COLOR_BUFFER_TYPE
#12439	constant EGL_CONTEXT_CLIENT_TYPE
#10000	constant EGL_DISPLAY_SCALING
#12432	constant EGL_HORIZONTAL_RESOLUTION
#12431	constant EGL_LUMINANCE_BUFFER
#12349	constant EGL_LUMINANCE_SIZE
#1	constant EGL_OPENGL_ES_BIT
#2	constant EGL_OPENVG_BIT
#12448	constant EGL_OPENGL_ES_API
#12449	constant EGL_OPENVG_API
#12438	constant EGL_OPENVG_IMAGE
#12434	constant EGL_PIXEL_ASPECT_RATIO
#12352	constant EGL_RENDERABLE_TYPE
#12422	constant EGL_RENDER_BUFFER
#12430	constant EGL_RGB_BUFFER
#12421	constant EGL_SINGLE_BUFFER
#12435	constant EGL_SWAP_BEHAVIOR
#12433	constant EGL_VERTICAL_RESOLUTION
#1	constant EGL_VERSION_1_3
#12354	constant EGL_CONFORMANT
#12440	constant EGL_CONTEXT_CLIENT_VERSION
#12353	constant EGL_MATCH_NATIVE_PIXMAP
#4	constant EGL_OPENGL_ES2_BIT
#12424	constant EGL_VG_ALPHA_FORMAT
#12427	constant EGL_VG_ALPHA_FORMAT_NONPRE
#12428	constant EGL_VG_ALPHA_FORMAT_PRE
#64	constant EGL_VG_ALPHA_FORMAT_PRE_BIT
#12423	constant EGL_VG_COLORSPACE
#12425	constant EGL_VG_COLORSPACE_sRGB
#12426	constant EGL_VG_COLORSPACE_LINEAR
#32	constant EGL_VG_COLORSPACE_LINEAR_BIT
#1	constant EGL_VERSION_1_4
#512	constant EGL_MULTISAMPLE_RESOLVE_BOX_BIT
#12441	constant EGL_MULTISAMPLE_RESOLVE
#12442	constant EGL_MULTISAMPLE_RESOLVE_DEFAULT
#12443	constant EGL_MULTISAMPLE_RESOLVE_BOX
#12450	constant EGL_OPENGL_API
#8	constant EGL_OPENGL_BIT
#1024	constant EGL_SWAP_BEHAVIOR_PRESERVED_BIT
#1	constant EGL_VERSION_1_5
#12440	constant EGL_CONTEXT_MAJOR_VERSION
#12539	constant EGL_CONTEXT_MINOR_VERSION
#12541	constant EGL_CONTEXT_OPENGL_PROFILE_MASK
#12733	constant EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY
#12734	constant EGL_NO_RESET_NOTIFICATION
#12735	constant EGL_LOSE_CONTEXT_ON_RESET
#1	constant EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT
#2	constant EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT
#12720	constant EGL_CONTEXT_OPENGL_DEBUG
#12721	constant EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE
#12722	constant EGL_CONTEXT_OPENGL_ROBUST_ACCESS
#64	constant EGL_OPENGL_ES3_BIT
#12444	constant EGL_CL_EVENT_HANDLE
#12542	constant EGL_SYNC_CL_EVENT
#12543	constant EGL_SYNC_CL_EVENT_COMPLETE
#12528	constant EGL_SYNC_PRIOR_COMMANDS_COMPLETE
#12535	constant EGL_SYNC_TYPE
#12529	constant EGL_SYNC_STATUS
#12536	constant EGL_SYNC_CONDITION
#12530	constant EGL_SIGNALED
#12531	constant EGL_UNSIGNALED
#1	constant EGL_SYNC_FLUSH_COMMANDS_BIT
#12533	constant EGL_TIMEOUT_EXPIRED
#12534	constant EGL_CONDITION_SATISFIED
#12537	constant EGL_SYNC_FENCE
#12445	constant EGL_GL_COLORSPACE
#12425	constant EGL_GL_COLORSPACE_SRGB
#12426	constant EGL_GL_COLORSPACE_LINEAR
#12473	constant EGL_GL_RENDERBUFFER
#12465	constant EGL_GL_TEXTURE_2D
#12476	constant EGL_GL_TEXTURE_LEVEL
#12466	constant EGL_GL_TEXTURE_3D
#12477	constant EGL_GL_TEXTURE_ZOFFSET
#12467	constant EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X
#12468	constant EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X
#12469	constant EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y
#12470	constant EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
#12471	constant EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z
#12472	constant EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
#12498	constant EGL_IMAGE_PRESERVED

\ ----===< long constants >===-----
#18446744073709551615.	2constant EGL_FOREVER

\ ------===< functions >===-------
c-function eglChooseConfig eglChooseConfig a a a n a -- u	( dpy attrib_list configs config_size num_config -- )
c-function eglCopyBuffers eglCopyBuffers a a n -- u	( dpy surface target -- )
c-function eglCreateContext eglCreateContext a a a a -- a	( dpy config share_context attrib_list -- )
c-function eglCreatePbufferSurface eglCreatePbufferSurface a a a -- a	( dpy config attrib_list -- )
c-function eglCreatePixmapSurface eglCreatePixmapSurface a a n a -- a	( dpy config pixmap attrib_list -- )
c-function eglCreateWindowSurface eglCreateWindowSurface a a n a -- a	( dpy config win attrib_list -- )
c-function eglDestroyContext eglDestroyContext a a -- u	( dpy ctx -- )
c-function eglDestroySurface eglDestroySurface a a -- u	( dpy surface -- )
c-function eglGetConfigAttrib eglGetConfigAttrib a a n a -- u	( dpy config attribute value -- )
c-function eglGetConfigs eglGetConfigs a a n a -- u	( dpy configs config_size num_config -- )
c-function eglGetCurrentDisplay eglGetCurrentDisplay  -- a	( -- )
c-function eglGetCurrentSurface eglGetCurrentSurface n -- a	( readdraw -- )
c-function eglGetDisplay eglGetDisplay a -- a	( display_id -- )
c-function eglGetError eglGetError  -- n	( -- )
c-function eglGetProcAddress eglGetProcAddress s -- a	( procname -- )
c-function eglInitialize eglInitialize a a a -- u	( dpy major minor -- )
c-function eglMakeCurrent eglMakeCurrent a a a a -- u	( dpy draw read ctx -- )
c-function eglQueryContext eglQueryContext a a n a -- u	( dpy ctx attribute value -- )
c-function eglQueryString eglQueryString a n -- s	( dpy name -- )
c-function eglQuerySurface eglQuerySurface a a n a -- u	( dpy surface attribute value -- )
c-function eglSwapBuffers eglSwapBuffers a a -- u	( dpy surface -- )
c-function eglTerminate eglTerminate a -- u	( dpy -- )
c-function eglWaitGL eglWaitGL  -- u	( -- )
c-function eglWaitNative eglWaitNative n -- u	( engine -- )
c-function eglBindTexImage eglBindTexImage a a n -- u	( dpy surface buffer -- )
c-function eglReleaseTexImage eglReleaseTexImage a a n -- u	( dpy surface buffer -- )
c-function eglSurfaceAttrib eglSurfaceAttrib a a n n -- u	( dpy surface attribute value -- )
c-function eglSwapInterval eglSwapInterval a n -- u	( dpy interval -- )
c-function eglBindAPI eglBindAPI u -- u	( api -- )
c-function eglQueryAPI eglQueryAPI  -- u	( -- )
c-function eglCreatePbufferFromClientBuffer eglCreatePbufferFromClientBuffer a u a a a -- a	( dpy buftype buffer config attrib_list -- )
c-function eglReleaseThread eglReleaseThread  -- u	( -- )
c-function eglWaitClient eglWaitClient  -- u	( -- )
c-function eglGetCurrentContext eglGetCurrentContext  -- a	( -- )
c-function eglCreateSync eglCreateSync a u a -- a	( dpy type attrib_list -- )
c-function eglDestroySync eglDestroySync a a -- u	( dpy sync -- )
c-function eglClientWaitSync eglClientWaitSync a a n n -- n	( dpy sync flags timeout -- )
c-function eglGetSyncAttrib eglGetSyncAttrib a a n a -- u	( dpy sync attribute value -- )
c-function eglCreateImage eglCreateImage a a u a a -- a	( dpy ctx target buffer attrib_list -- )
c-function eglDestroyImage eglDestroyImage a a -- u	( dpy image -- )
c-function eglGetPlatformDisplay eglGetPlatformDisplay u a a -- a	( platform native_display attrib_list -- )
c-function eglCreatePlatformWindowSurface eglCreatePlatformWindowSurface a a a a -- a	( dpy config native_window attrib_list -- )
c-function eglCreatePlatformPixmapSurface eglCreatePlatformPixmapSurface a a a a -- a	( dpy config native_pixmap attrib_list -- )
c-function eglWaitSync eglWaitSync a a n -- u	( dpy sync flags -- )

\ ----===< postfix >===-----
end-c-library
