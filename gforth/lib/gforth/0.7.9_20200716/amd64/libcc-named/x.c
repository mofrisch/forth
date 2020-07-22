#include <libcc.h>
#include <X11/X.h>
#include <X11/Xlib.h>
#include <X11/Xutil.h>
#include <X11/keysym.h>
#include <X11/XF86keysym.h>
#include <X11/extensions/sync.h>
#include <X11/extensions/Xrandr.h>
gforth_stackpointers libgfx_LTX_gforth_c___struct__XExtData__ptr___free_private_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  Cell ptr = *x.spx++;
  x.spx[0]=((struct _XExtData*)ptr)->free_private((void *)(x.spx[0]));
  x.spx += 0;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___create_image_aaunnauunn_a(GFORTH_ARGS)
{
  ARGN(9,-1);
  Cell ptr = *x.spx++;
  x.spx[9]=(Cell)((struct funcs*)ptr)->create_image((void *)(x.spx[9]),(void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___destroy_image_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  Cell ptr = *x.spx++;
  x.spx[0]=((struct funcs*)ptr)->destroy_image((void *)(x.spx[0]));
  x.spx += 0;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___get_pixel_ann_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  Cell ptr = *x.spx++;
  x.spx[2]=((struct funcs*)ptr)->get_pixel((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___put_pixel_annu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  Cell ptr = *x.spx++;
  x.spx[3]=((struct funcs*)ptr)->put_pixel((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___sub_image_annuu_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  Cell ptr = *x.spx++;
  x.spx[4]=(Cell)((struct funcs*)ptr)->sub_image((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c___struct_funcs__ptr___add_pixel_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  Cell ptr = *x.spx++;
  x.spx[1]=((struct funcs*)ptr)->add_pixel((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
#define CALLBACK_XIMProc_(I) \
void libgfx_LTX_gforth_cb_XIMProc__##I (void* x0, void* x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfx_LTX_gforth_cbips_XIMProc_[I], &x); \
; \
}
Xt* libgfx_LTX_gforth_cbips_XIMProc_[2] = {
  0, 0,};
CALLBACK_XIMProc_(0)
CALLBACK_XIMProc_(1)
const Address libgfx_LTX_gforth_callbacks_XIMProc_[2] = {
  (Address)libgfx_LTX_gforth_cb_XIMProc__0,
  (Address)libgfx_LTX_gforth_cb_XIMProc__1,
};
#define CALLBACK_XICProc_(I) \
Cell libgfx_LTX_gforth_cb_XICProc__##I (void* x0, void* x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfx_LTX_gforth_cbips_XICProc_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfx_LTX_gforth_cbips_XICProc_[2] = {
  0, 0,};
CALLBACK_XICProc_(0)
CALLBACK_XICProc_(1)
const Address libgfx_LTX_gforth_callbacks_XICProc_[2] = {
  (Address)libgfx_LTX_gforth_cb_XICProc__0,
  (Address)libgfx_LTX_gforth_cb_XICProc__1,
};
#define CALLBACK_XIDProc_(I) \
void libgfx_LTX_gforth_cb_XIDProc__##I (void* x0, void* x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfx_LTX_gforth_cbips_XIDProc_[I], &x); \
; \
}
Xt* libgfx_LTX_gforth_cbips_XIDProc_[2] = {
  0, 0,};
CALLBACK_XIDProc_(0)
CALLBACK_XIDProc_(1)
const Address libgfx_LTX_gforth_callbacks_XIDProc_[2] = {
  (Address)libgfx_LTX_gforth_cb_XIDProc__0,
  (Address)libgfx_LTX_gforth_cb_XIDProc__1,
};
#define CALLBACK_XErrorHandler_(I) \
Cell libgfx_LTX_gforth_cb_XErrorHandler__##I (void* x0, void* x1) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx+=-2; \
  gforth_engine(libgfx_LTX_gforth_cbips_XErrorHandler_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfx_LTX_gforth_cbips_XErrorHandler_[2] = {
  0, 0,};
CALLBACK_XErrorHandler_(0)
CALLBACK_XErrorHandler_(1)
const Address libgfx_LTX_gforth_callbacks_XErrorHandler_[2] = {
  (Address)libgfx_LTX_gforth_cb_XErrorHandler__0,
  (Address)libgfx_LTX_gforth_cb_XErrorHandler__1,
};
#define CALLBACK_XIOErrorHandler_(I) \
Cell libgfx_LTX_gforth_cb_XIOErrorHandler__##I (void* x0) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx+=-1; \
  gforth_engine(libgfx_LTX_gforth_cbips_XIOErrorHandler_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfx_LTX_gforth_cbips_XIOErrorHandler_[2] = {
  0, 0,};
CALLBACK_XIOErrorHandler_(0)
CALLBACK_XIOErrorHandler_(1)
const Address libgfx_LTX_gforth_callbacks_XIOErrorHandler_[2] = {
  (Address)libgfx_LTX_gforth_cb_XIOErrorHandler__0,
  (Address)libgfx_LTX_gforth_cb_XIOErrorHandler__1,
};
#define CALLBACK_XConnectionWatchProc_(I) \
void libgfx_LTX_gforth_cb_XConnectionWatchProc__##I (void* x0, void* x1, Cell x2, Cell x3, void* x4) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx+=-5; \
  gforth_engine(libgfx_LTX_gforth_cbips_XConnectionWatchProc_[I], &x); \
; \
}
Xt* libgfx_LTX_gforth_cbips_XConnectionWatchProc_[2] = {
  0, 0,};
CALLBACK_XConnectionWatchProc_(0)
CALLBACK_XConnectionWatchProc_(1)
const Address libgfx_LTX_gforth_callbacks_XConnectionWatchProc_[2] = {
  (Address)libgfx_LTX_gforth_cb_XConnectionWatchProc__0,
  (Address)libgfx_LTX_gforth_cb_XConnectionWatchProc__1,
};
gforth_stackpointers libgfx_LTX_gforth_c__Xmblen_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=_Xmblen((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLoadQueryFont_as_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XLoadQueryFont((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryFont_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XQueryFont((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetMotionEvents_auuua_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetMotionEvents((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDeleteModifiermapEntry_aun_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XDeleteModifiermapEntry((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetModifierMapping_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XGetModifierMapping((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInsertModifiermapEntry_aun_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XInsertModifiermapEntry((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XNewModifiermap_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XNewModifiermap(x.spx[0]);
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateImage_aaunnauunn_a(GFORTH_ARGS)
{
  ARGN(9,-1);
  x.spx[9]=(Cell)XCreateImage((void *)(x.spx[9]),(void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInitImage_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XInitImage((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetImage_aunnuuun_a(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=(Cell)XGetImage((void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetSubImage_aunnuuunann_a(GFORTH_ARGS)
{
  ARGN(10,-1);
  x.spx[10]=(Cell)XGetSubImage((void *)(x.spx[10]),x.spx[9],x.spx[8],x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 10;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XOpenDisplay_s_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XOpenDisplay(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XrmInitialize__v(GFORTH_ARGS)
{
  ARGN(-1,-1);
  XrmInitialize();
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFetchBytes_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XFetchBytes((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFetchBuffer_aan_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XFetchBuffer((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetAtomName_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XGetAtomName((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetAtomNames_aana_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetAtomNames((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetDefault_ass_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetDefault((void *)(x.spx[4]),gforth_str2c((Char*)x.spx[3],x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayName_s_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XDisplayName(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XKeysymToString_u_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XKeysymToString(x.spx[0]);
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSynchronize_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XSynchronize((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetAfterFunction_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XSetAfterFunction((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInternAtom_asn_u(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XInternAtom((void *)(x.spx[3]),gforth_str2c((Char*)x.spx[2],x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInternAtoms_aanna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XInternAtoms((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCopyColormapAndFree_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XCopyColormapAndFree((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateColormap_auan_u(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XCreateColormap((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreatePixmapCursor_auuaauu_u(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XCreatePixmapCursor((void *)(x.spx[6]),x.spx[5],x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateGlyphCursor_auuuuaa_u(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XCreateGlyphCursor((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateFontCursor_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XCreateFontCursor((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLoadFont_as_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XLoadFont((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateGC_auua_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XCreateGC((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGContextFromGC_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XGContextFromGC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFlushGC_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XFlushGC((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreatePixmap_auuuu_u(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XCreatePixmap((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateBitmapFromData_auauu_u(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XCreateBitmapFromData((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreatePixmapFromBitmapData_auauuuuu_u(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=XCreatePixmapFromBitmapData((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateSimpleWindow_aunnuuuuu_u(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XCreateSimpleWindow((void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetSelectionOwner_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XGetSelectionOwner((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateWindow_aunnuuunuaua_u(GFORTH_ARGS)
{
  ARGN(11,-1);
  x.spx[11]=XCreateWindow((void *)(x.spx[11]),x.spx[10],x.spx[9],x.spx[8],x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 11;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListInstalledColormaps_aua_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XListInstalledColormaps((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListFonts_asna_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XListFonts((void *)(x.spx[4]),gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListFontsWithInfo_asnaa_a(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=(Cell)XListFontsWithInfo((void *)(x.spx[5]),gforth_str2c((Char*)x.spx[4],x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetFontPath_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XGetFontPath((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListExtensions_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XListExtensions((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListProperties_aua_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XListProperties((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListHosts_aaa_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XListHosts((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XKeycodeToKeysym_aun_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XKeycodeToKeysym((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLookupKeysym_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XLookupKeysym((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetKeyboardMapping_auna_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XGetKeyboardMapping((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStringToKeysym_s_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XStringToKeysym(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMaxRequestSize_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XMaxRequestSize((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XExtendedMaxRequestSize_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XExtendedMaxRequestSize((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XResourceManagerString_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XResourceManagerString((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XScreenResourceString_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XScreenResourceString((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayMotionBufferSize_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDisplayMotionBufferSize((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XVisualIDFromVisual_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XVisualIDFromVisual((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInitThreads__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=XInitThreads();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLockDisplay_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XLockDisplay((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnlockDisplay_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XUnlockDisplay((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInitExtension_as_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XInitExtension((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddExtension_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XAddExtension((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFindOnExtensionList_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XFindOnExtensionList((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEHeadOfExtensionList_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XEHeadOfExtensionList(*(XEDataObject*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRootWindow_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRootWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultRootWindow_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDefaultRootWindow((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRootWindowOfScreen_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XRootWindowOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultVisual_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XDefaultVisual((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultVisualOfScreen_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDefaultVisualOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultGC_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XDefaultGC((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultGCOfScreen_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDefaultGCOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBlackPixel_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XBlackPixel((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWhitePixel_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XWhitePixel((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllPlanes__u(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=XAllPlanes();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBlackPixelOfScreen_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XBlackPixelOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWhitePixelOfScreen_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XWhitePixelOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XNextRequest_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XNextRequest((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLastKnownRequestProcessed_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XLastKnownRequestProcessed((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XServerVendor_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XServerVendor((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayString_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDisplayString((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultColormap_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDefaultColormap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultColormapOfScreen_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDefaultColormapOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayOfScreen_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDisplayOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XScreenOfDisplay_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XScreenOfDisplay((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultScreenOfDisplay_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDefaultScreenOfDisplay((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEventMaskOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XEventMaskOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XScreenNumberOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XScreenNumberOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetErrorHandler_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XSetErrorHandler((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIOErrorHandler_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XSetIOErrorHandler((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListPixmapFormats_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XListPixmapFormats((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XListDepths_ana_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XListDepths((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XReconfigureWMWindow_aunua_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XReconfigureWMWindow((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMProtocols_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetWMProtocols((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMProtocols_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetWMProtocols((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XIconifyWindow_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XIconifyWindow((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWithdrawWindow_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XWithdrawWindow((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetCommand_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetCommand((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMColormapWindows_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetWMColormapWindows((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMColormapWindows_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetWMColormapWindows((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeStringList_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XFreeStringList((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetTransientForHint_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetTransientForHint((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XActivateScreenSaver_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XActivateScreenSaver((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddHost_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XAddHost((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddHosts_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XAddHosts((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddToExtensionList_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XAddToExtensionList((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddToSaveSet_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XAddToSaveSet((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocColor_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XAllocColor((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocColorCells_aunauau_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XAllocColorCells((void *)(x.spx[6]),x.spx[5],x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocColorPlanes_aunannnnaaa_n(GFORTH_ARGS)
{
  ARGN(10,-1);
  x.spx[10]=XAllocColorPlanes((void *)(x.spx[10]),x.spx[9],x.spx[8],(void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 10;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocNamedColor_ausaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XAllocNamedColor((void *)(x.spx[5]),x.spx[4],gforth_str2c((Char*)x.spx[3],x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllowEvents_anu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XAllowEvents((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAutoRepeatOff_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XAutoRepeatOff((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAutoRepeatOn_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XAutoRepeatOn((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBell_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XBell((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBitmapBitOrder_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XBitmapBitOrder((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBitmapPad_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XBitmapPad((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBitmapUnit_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XBitmapUnit((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCellsOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XCellsOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeActivePointerGrab_auuu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XChangeActivePointerGrab((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeGC_aaua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XChangeGC((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeKeyboardControl_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XChangeKeyboardControl((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeKeyboardMapping_annan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XChangeKeyboardMapping((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangePointerControl_annnnn_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XChangePointerControl((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeProperty_auuunnan_n(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=XChangeProperty((void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeSaveSet_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XChangeSaveSet((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XChangeWindowAttributes_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XChangeWindowAttributes((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCheckIfEvent_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XCheckIfEvent((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCheckMaskEvent_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XCheckMaskEvent((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCheckTypedEvent_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XCheckTypedEvent((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCheckTypedWindowEvent_auna_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XCheckTypedWindowEvent((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCheckWindowEvent_auna_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XCheckWindowEvent((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCirculateSubwindows_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XCirculateSubwindows((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCirculateSubwindowsDown_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XCirculateSubwindowsDown((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCirculateSubwindowsUp_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XCirculateSubwindowsUp((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XClearArea_aunnuun_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XClearArea((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XClearWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XClearWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCloseDisplay_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XCloseDisplay((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XConfigureWindow_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XConfigureWindow((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XConnectionNumber_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XConnectionNumber((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XConvertSelection_auuuuu_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XConvertSelection((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCopyArea_auuannuunn_n(GFORTH_ARGS)
{
  ARGN(9,-1);
  x.spx[9]=XCopyArea((void *)(x.spx[9]),x.spx[8],x.spx[7],(void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCopyGC_aaua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XCopyGC((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCopyPlane_auuannuunnu_n(GFORTH_ARGS)
{
  ARGN(10,-1);
  x.spx[10]=XCopyPlane((void *)(x.spx[10]),x.spx[9],x.spx[8],(void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 10;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultDepth_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDefaultDepth((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultDepthOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDefaultDepthOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDefaultScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefineCursor_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XDefineCursor((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDeleteProperty_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XDeleteProperty((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDestroyWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDestroyWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDestroySubwindows_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDestroySubwindows((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDoesBackingStore_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDoesBackingStore((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDoesSaveUnders_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDoesSaveUnders((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisableAccessControl_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDisableAccessControl((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayCells_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayCells((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayHeight_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayHeight((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayHeightMM_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayHeightMM((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayKeycodes_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XDisplayKeycodes((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayPlanes_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayPlanes((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayWidth_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayWidth((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayWidthMM_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XDisplayWidthMM((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawArc_auannuunn_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XDrawArc((void *)(x.spx[8]),x.spx[7],(void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawArcs_auaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XDrawArcs((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawImageString_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawImageString((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawImageString16_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawImageString16((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawLine_auannnn_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawLine((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawLines_auaann_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XDrawLines((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawPoint_auann_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XDrawPoint((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawPoints_auaann_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XDrawPoints((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawRectangle_auannuu_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawRectangle((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawRectangles_auaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XDrawRectangles((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawSegments_auaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XDrawSegments((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawString_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawString((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawString16_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawString16((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawText_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawText((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDrawText16_auannan_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XDrawText16((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEnableAccessControl_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XEnableAccessControl((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEventsQueued_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XEventsQueued((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFetchName_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XFetchName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFillArc_auannuunn_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XFillArc((void *)(x.spx[8]),x.spx[7],(void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFillArcs_auaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XFillArcs((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFillPolygon_auaannn_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XFillPolygon((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFillRectangle_auannuu_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XFillRectangle((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFillRectangles_auaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XFillRectangles((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFlush_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFlush((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XForceScreenSaver_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XForceScreenSaver((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFree_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFree((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeColormap_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFreeColormap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeColors_auanu_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XFreeColors((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeCursor_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFreeCursor((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeExtensionList_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFreeExtensionList((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeFont_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFreeFont((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeFontInfo_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XFreeFontInfo((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeFontNames_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFreeFontNames((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeFontPath_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFreeFontPath((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeGC_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFreeGC((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeModifiermap_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XFreeModifiermap((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreePixmap_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFreePixmap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGeometry_anssuuunnaaaa_n(GFORTH_ARGS)
{
  ARGN(14,-1);
  x.spx[14]=XGeometry((void *)(x.spx[14]),x.spx[13],gforth_str2c((Char*)x.spx[12],x.spx[11]),gforth_str2c((Char*)x.spx[10],x.spx[9]),x.spx[8],x.spx[7],x.spx[6],x.spx[5],x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 14;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetErrorDatabaseText_asssan_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XGetErrorDatabaseText((void *)(x.spx[8]),gforth_str2c((Char*)x.spx[7],x.spx[6]),gforth_str2c((Char*)x.spx[5],x.spx[4]),gforth_str2c((Char*)x.spx[3],x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetErrorText_anan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetErrorText((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetFontProperty_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetFontProperty((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetGCValues_aaua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetGCValues((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetGeometry_auaaaaaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XGetGeometry((void *)(x.spx[8]),x.spx[7],(void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetIconName_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetIconName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetInputFocus_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetInputFocus((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetKeyboardControl_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XGetKeyboardControl((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetPointerControl_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetPointerControl((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetPointerMapping_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetPointerMapping((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetScreenSaver_aaaaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XGetScreenSaver((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetTransientForHint_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetTransientForHint((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWindowProperty_auunnnuaaaaa_n(GFORTH_ARGS)
{
  ARGN(11,-1);
  x.spx[11]=XGetWindowProperty((void *)(x.spx[11]),x.spx[10],x.spx[9],x.spx[8],x.spx[7],x.spx[6],x.spx[5],(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 11;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWindowAttributes_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetWindowAttributes((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGrabButton_auuununnuu_n(GFORTH_ARGS)
{
  ARGN(9,-1);
  x.spx[9]=XGrabButton((void *)(x.spx[9]),x.spx[8],x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGrabKey_anuunnn_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XGrabKey((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGrabKeyboard_aunnnu_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XGrabKeyboard((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGrabPointer_aununnuuu_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XGrabPointer((void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGrabServer_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XGrabServer((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XHeightMMOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XHeightMMOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XHeightOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XHeightOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XIfEvent_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XIfEvent((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XImageByteOrder_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XImageByteOrder((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInstallColormap_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XInstallColormap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XKeysymToKeycode_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XKeysymToKeycode((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XKillClient_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XKillClient((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLookupColor_ausaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XLookupColor((void *)(x.spx[5]),x.spx[4],gforth_str2c((Char*)x.spx[3],x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLowerWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XLowerWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMapRaised_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XMapRaised((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMapSubwindows_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XMapSubwindows((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMapWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XMapWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMaskEvent_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XMaskEvent((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMaxCmapsOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XMaxCmapsOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMinCmapsOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XMinCmapsOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMoveResizeWindow_aunnuu_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XMoveResizeWindow((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMoveWindow_aunn_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XMoveWindow((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XNextEvent_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XNextEvent((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XNoOp_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XNoOp((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XParseColor_ausa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XParseColor((void *)(x.spx[4]),x.spx[3],gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XParseGeometry_saaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XParseGeometry(gforth_str2c((Char*)x.spx[5],x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPeekEvent_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XPeekEvent((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPeekIfEvent_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XPeekIfEvent((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPending_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XPending((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPlanesOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XPlanesOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XProtocolRevision_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XProtocolRevision((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XProtocolVersion_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XProtocolVersion((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPutBackEvent_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XPutBackEvent((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPutImage_auaannnnuu_n(GFORTH_ARGS)
{
  ARGN(9,-1);
  x.spx[9]=XPutImage((void *)(x.spx[9]),x.spx[8],(void *)(x.spx[7]),(void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQLength_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XQLength((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryBestCursor_auuuaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XQueryBestCursor((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryBestSize_anuuuaa_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XQueryBestSize((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryBestStipple_auuuaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XQueryBestStipple((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryBestTile_auuuaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XQueryBestTile((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryColor_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XQueryColor((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryColors_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XQueryColors((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryExtension_asaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XQueryExtension((void *)(x.spx[5]),gforth_str2c((Char*)x.spx[4],x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryKeymap_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XQueryKeymap((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryPointer_auaaaaaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XQueryPointer((void *)(x.spx[8]),x.spx[7],(void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryTextExtents_auanaaaa_n(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=XQueryTextExtents((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryTextExtents16_auanaaaa_n(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=XQueryTextExtents16((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XQueryTree_auaaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XQueryTree((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRaiseWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRaiseWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XReadBitmapFile_ausaaaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XReadBitmapFile((void *)(x.spx[8]),x.spx[7],gforth_str2c((Char*)x.spx[6],x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XReadBitmapFileData_saaaaa_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XReadBitmapFileData(gforth_str2c((Char*)x.spx[6],x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRebindKeysym_auanan_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XRebindKeysym((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRecolorCursor_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XRecolorCursor((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRefreshKeyboardMapping_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XRefreshKeyboardMapping((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRemoveFromSaveSet_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRemoveFromSaveSet((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRemoveHost_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRemoveHost((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRemoveHosts_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRemoveHosts((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XReparentWindow_auunn_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XReparentWindow((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XResetScreenSaver_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XResetScreenSaver((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XResizeWindow_auuu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XResizeWindow((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRestackWindows_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRestackWindows((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRotateBuffers_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRotateBuffers((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRotateWindowProperties_auann_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XRotateWindowProperties((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XScreenCount_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XScreenCount((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSelectInput_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSelectInput((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSendEvent_aunna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XSendEvent((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetAccessControl_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSetAccessControl((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetArcMode_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetArcMode((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetBackground_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetBackground((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetClipMask_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetClipMask((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetClipOrigin_aann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetClipOrigin((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetClipRectangles_aannann_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XSetClipRectangles((void *)(x.spx[6]),(void *)(x.spx[5]),x.spx[4],x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetCloseDownMode_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSetCloseDownMode((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetCommand_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetCommand((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetDashes_aanan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XSetDashes((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetFillRule_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetFillRule((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetFillStyle_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetFillStyle((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetFont_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetFont((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetFontPath_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetFontPath((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetForeground_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetForeground((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetFunction_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetFunction((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetGraphicsExposures_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetGraphicsExposures((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIconName_aus_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetIconName((void *)(x.spx[3]),x.spx[2],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetInputFocus_aunu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetInputFocus((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetLineAttributes_aaunnn_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XSetLineAttributes((void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetModifierMapping_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSetModifierMapping((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetPlaneMask_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetPlaneMask((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetPointerMapping_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetPointerMapping((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetScreenSaver_annnn_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XSetScreenSaver((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetSelectionOwner_auuu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetSelectionOwner((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetState_aauunu_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XSetState((void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetStipple_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetStipple((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetSubwindowMode_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetSubwindowMode((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetTSOrigin_aann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetTSOrigin((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetTile_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetTile((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowBackground_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowBackground((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowBackgroundPixmap_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowBackgroundPixmap((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowBorder_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowBorder((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowBorderPixmap_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowBorderPixmap((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowBorderWidth_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowBorderWidth((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWindowColormap_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWindowColormap((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreBuffer_aann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XStoreBuffer((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreBytes_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XStoreBytes((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreColor_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XStoreColor((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreColors_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XStoreColors((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreName_aus_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XStoreName((void *)(x.spx[3]),x.spx[2],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStoreNamedColor_ausun_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XStoreNamedColor((void *)(x.spx[5]),x.spx[4],gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSync_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSync((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTextExtents_aanaaaa_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XTextExtents((void *)(x.spx[6]),(void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTextExtents16_aanaaaa_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XTextExtents16((void *)(x.spx[6]),(void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTextWidth_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XTextWidth((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTextWidth16_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XTextWidth16((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTranslateCoordinates_auunnaaa_n(GFORTH_ARGS)
{
  ARGN(7,-1);
  x.spx[7]=XTranslateCoordinates((void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUndefineCursor_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUndefineCursor((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUngrabButton_auuu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XUngrabButton((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUngrabKey_anuu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XUngrabKey((void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUngrabKeyboard_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUngrabKeyboard((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUngrabPointer_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUngrabPointer((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUngrabServer_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XUngrabServer((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUninstallColormap_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUninstallColormap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnloadFont_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUnloadFont((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnmapSubwindows_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUnmapSubwindows((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnmapWindow_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XUnmapWindow((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XVendorRelease_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XVendorRelease((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWarpPointer_auunnuunn_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XWarpPointer((void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWidthMMOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XWidthMMOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWidthOfScreen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XWidthOfScreen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWindowEvent_auna_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XWindowEvent((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWriteBitmapFile_aauuunn_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XWriteBitmapFile((void *)(x.spx[6]),(void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSupportsLocale__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=XSupportsLocale();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetLocaleModifiers_s_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XSetLocaleModifiers(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XOpenOM_aass_a(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=(Cell)XOpenOM((void *)(x.spx[5]),(void *)(x.spx[4]),gforth_str2c((Char*)x.spx[3],x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCloseOM_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XCloseOM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOMValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XSetOMValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOMValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XSetOMValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOMValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XSetOMValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOMValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XGetOMValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOMValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetOMValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOMValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XGetOMValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayOfOM_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDisplayOfOM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLocaleOfOM_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XLocaleOfOM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateOC_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XCreateOC((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateOC_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XCreateOC((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateOC_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XCreateOC((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDestroyOC_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XDestroyOC((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XOMOfOC_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XOMOfOC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOCValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XSetOCValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOCValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XSetOCValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetOCValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XSetOCValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOCValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XGetOCValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOCValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetOCValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetOCValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XGetOCValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateFontSet_asaaa_a(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=(Cell)XCreateFontSet((void *)(x.spx[5]),gforth_str2c((Char*)x.spx[4],x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeFontSet_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XFreeFontSet((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFontsOfFontSet_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XFontsOfFontSet((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XBaseFontNameListOfFontSet_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XBaseFontNameListOfFontSet((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLocaleOfFontSet_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XLocaleOfFontSet((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XContextDependentDrawing_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XContextDependentDrawing((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDirectionalDependentDrawing_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDirectionalDependentDrawing((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XContextualDrawing_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XContextualDrawing((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XExtentsOfFontSet_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XExtentsOfFontSet((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbTextEscapement_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XmbTextEscapement((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcTextEscapement_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XwcTextEscapement((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8TextEscapement_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=Xutf8TextEscapement((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbTextExtents_aanaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XmbTextExtents((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcTextExtents_aanaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XwcTextExtents((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8TextExtents_aanaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=Xutf8TextExtents((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbTextPerCharExtents_aanaanaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XmbTextPerCharExtents((void *)(x.spx[8]),(void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcTextPerCharExtents_aanaanaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XwcTextPerCharExtents((void *)(x.spx[8]),(void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8TextPerCharExtents_aanaanaaa_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=Xutf8TextPerCharExtents((void *)(x.spx[8]),(void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbDrawText_auannan_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  XmbDrawText((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcDrawText_auannan_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  XwcDrawText((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8DrawText_auannan_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  Xutf8DrawText((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbDrawString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XmbDrawString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcDrawString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XwcDrawString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8DrawString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  Xutf8DrawString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbDrawImageString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XmbDrawImageString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcDrawImageString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XwcDrawImageString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8DrawImageString_auaannan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  Xutf8DrawImageString((void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XOpenIM_aaaa_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XOpenIM((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCloseIM_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XCloseIM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetIMValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XGetIMValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetIMValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetIMValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetIMValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XGetIMValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIMValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XSetIMValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIMValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XSetIMValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIMValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XSetIMValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDisplayOfIM_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XDisplayOfIM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLocaleOfIM_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XLocaleOfIM((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateIC_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XCreateIC((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateIC_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XCreateIC((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateIC_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XCreateIC((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDestroyIC_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XDestroyIC((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetICFocus_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XSetICFocus((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnsetICFocus_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XUnsetICFocus((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcResetIC_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XwcResetIC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbResetIC_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XmbResetIC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8ResetIC_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)Xutf8ResetIC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetICValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XSetICValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetICValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XSetICValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetICValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XSetICValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetICValues_aaa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XGetICValues((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetICValues_aaaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XGetICValues((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetICValues_aaaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XGetICValues((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XIMOfIC_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XIMOfIC((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFilterEvent_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XFilterEvent((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbLookupString_aaanaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XmbLookupString((void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcLookupString_aaanaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XwcLookupString((void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8LookupString_aaanaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=Xutf8LookupString((void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XVaCreateNestedList_naa__a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XVaCreateNestedList(x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XVaCreateNestedList_naaaa__a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)XVaCreateNestedList(x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XVaCreateNestedList_naaaaaa__a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)XVaCreateNestedList(x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]),NULL);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRegisterIMInstantiateCallback_aaaaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XRegisterIMInstantiateCallback((void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnregisterIMInstantiateCallback_aaaaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XUnregisterIMInstantiateCallback((void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XInternalConnectionNumbers_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XInternalConnectionNumbers((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XProcessInternalConnection_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XProcessInternalConnection((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAddConnectionWatch_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XAddConnectionWatch((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRemoveConnectionWatch_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRemoveConnectionWatch((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetAuthorization_anan_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSetAuthorization((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c__Xmbtowc_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=_Xmbtowc((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c__Xwctomb_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=_Xwctomb((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetEventData_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XGetEventData((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFreeEventData_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XFreeEventData((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocClassHint__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XAllocClassHint();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocIconSize__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XAllocIconSize();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocSizeHints__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XAllocSizeHints();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocStandardColormap__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XAllocStandardColormap();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XAllocWMHints__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XAllocWMHints();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XClipBox_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XClipBox((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XCreateRegion__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)XCreateRegion();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDefaultString__s(GFORTH_ARGS)
{
  ARGN(-1,-1);
  c_str2gforth_str(XDefaultString(),x.spx[-1],x.spx[-2]);
  x.spx += -2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDeleteContext_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XDeleteContext((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XDestroyRegion_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XDestroyRegion((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEmptyRegion_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XEmptyRegion((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XEqualRegion_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XEqualRegion((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XFindContext_auna_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XFindContext((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetClassHint_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetClassHint((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetIconSizes_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetIconSizes((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetNormalHints_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetNormalHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetRGBColormaps_auaau_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XGetRGBColormaps((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetSizeHints_auau_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetSizeHints((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetStandardColormap_auau_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetStandardColormap((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetTextProperty_auau_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetTextProperty((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetVisualInfo_anaa_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XGetVisualInfo((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMClientMachine_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetWMClientMachine((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMHints_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XGetWMHints((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMIconName_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetWMIconName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMName_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetWMName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMNormalHints_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XGetWMNormalHints((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetWMSizeHints_auaau_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XGetWMSizeHints((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XGetZoomHints_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XGetZoomHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XIntersectRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XIntersectRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XConvertCase_uaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XConvertCase(x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XLookupString_aanaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XLookupString((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XMatchVisualInfo_annna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XMatchVisualInfo((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XOffsetRegion_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XOffsetRegion((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPointInRegion_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XPointInRegion((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XPolygonRegion_ann_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XPolygonRegion((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRectInRegion_annuu_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XRectInRegion((void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSaveContext_auns_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XSaveContext((void *)(x.spx[4]),x.spx[3],x.spx[2],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetClassHint_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetClassHint((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetIconSizes_auan_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetIconSizes((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetNormalHints_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetNormalHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetRGBColormaps_auanu_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  XSetRGBColormaps((void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetSizeHints_auau_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSetSizeHints((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetStandardProperties_ausauana_n(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=XSetStandardProperties((void *)(x.spx[8]),x.spx[7],gforth_str2c((Char*)x.spx[6],x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetTextProperty_auau_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSetTextProperty((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMClientMachine_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XSetWMClientMachine((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMHints_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetWMHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMIconName_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XSetWMIconName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMName_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XSetWMName((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMNormalHints_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XSetWMNormalHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMProperties_auaaanaaa_v(GFORTH_ARGS)
{
  ARGN(8,-1);
  XSetWMProperties((void *)(x.spx[8]),x.spx[7],(void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbSetWMProperties_aussanaaa_v(GFORTH_ARGS)
{
  ARGN(10,-1);
  XmbSetWMProperties((void *)(x.spx[10]),x.spx[9],gforth_str2c((Char*)x.spx[8],x.spx[7]),gforth_str2c((Char*)x.spx[6],x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 11;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8SetWMProperties_aussanaaa_v(GFORTH_ARGS)
{
  ARGN(10,-1);
  Xutf8SetWMProperties((void *)(x.spx[10]),x.spx[9],gforth_str2c((Char*)x.spx[8],x.spx[7]),gforth_str2c((Char*)x.spx[6],x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 11;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetWMSizeHints_auau_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSetWMSizeHints((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetStandardColormap_auau_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSetStandardColormap((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSetZoomHints_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSetZoomHints((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XShrinkRegion_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XShrinkRegion((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XStringListToTextProperty_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XStringListToTextProperty((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSubtractRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSubtractRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbTextListToTextProperty_aanna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XmbTextListToTextProperty((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcTextListToTextProperty_aanna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=XwcTextListToTextProperty((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8TextListToTextProperty_aanna_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=Xutf8TextListToTextProperty((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcFreeStringList_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XwcFreeStringList((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XTextPropertyToStringList_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XTextPropertyToStringList((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XmbTextPropertyToTextList_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XmbTextPropertyToTextList((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XwcTextPropertyToTextList_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XwcTextPropertyToTextList((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_Xutf8TextPropertyToTextList_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=Xutf8TextPropertyToTextList((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnionRectWithRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XUnionRectWithRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XUnionRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XUnionRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XWMGeometry_ansauaaaaaa_n(GFORTH_ARGS)
{
  ARGN(11,-1);
  x.spx[11]=XWMGeometry((void *)(x.spx[11]),x.spx[10],gforth_str2c((Char*)x.spx[9],x.spx[8]),(void *)(x.spx[7]),x.spx[6],(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 11;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XXorRegion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XXorRegion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncIntToValue_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XSyncIntToValue((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncIntsToValue_aun_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XSyncIntsToValue((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueGreaterThan_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncValueGreaterThan(*(XSyncValue*)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueLessThan_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncValueLessThan(*(XSyncValue*)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueGreaterOrEqual_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncValueGreaterOrEqual(*(XSyncValue*)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueLessOrEqual_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncValueLessOrEqual(*(XSyncValue*)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueEqual_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncValueEqual(*(XSyncValue*)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueIsNegative_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XSyncValueIsNegative(*(XSyncValue*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueIsZero_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XSyncValueIsZero(*(XSyncValue*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueIsPositive_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XSyncValueIsPositive(*(XSyncValue*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueLow32_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XSyncValueLow32(*(XSyncValue*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueHigh32_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XSyncValueHigh32(*(XSyncValue*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueAdd_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSyncValueAdd((void *)(x.spx[3]),*(XSyncValue*)(x.spx[2]),*(XSyncValue*)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncValueSubtract_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  XSyncValueSubtract((void *)(x.spx[3]),*(XSyncValue*)(x.spx[2]),*(XSyncValue*)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncMaxValue_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XSyncMaxValue((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncMinValue_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XSyncMinValue((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncQueryExtension_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncQueryExtension((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncInitialize_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncInitialize((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncListSystemCounters_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XSyncListSystemCounters((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncFreeSystemCounterList_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XSyncFreeSystemCounterList((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncCreateCounter_aa_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncCreateCounter((void *)(x.spx[1]),*(XSyncValue*)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncSetCounter_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncSetCounter((void *)(x.spx[2]),x.spx[1],*(XSyncValue*)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncChangeCounter_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncChangeCounter((void *)(x.spx[2]),x.spx[1],*(XSyncValue*)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncDestroyCounter_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncDestroyCounter((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncQueryCounter_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncQueryCounter((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncAwait_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncAwait((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncCreateAlarm_aua_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncCreateAlarm((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncDestroyAlarm_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncDestroyAlarm((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncQueryAlarm_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncQueryAlarm((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncChangeAlarm_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XSyncChangeAlarm((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncSetPriority_aun_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncSetPriority((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncGetPriority_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncGetPriority((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncCreateFence_aun_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncCreateFence((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncTriggerFence_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncTriggerFence((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncResetFence_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncResetFence((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncDestroyFence_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XSyncDestroyFence((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncQueryFence_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncQueryFence((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XSyncAwaitFence_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XSyncAwaitFence((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRQueryExtension_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRQueryExtension((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRQueryVersion_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRQueryVersion((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetScreenInfo_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRGetScreenInfo((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeScreenConfigInfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeScreenConfigInfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetScreenConfig_aaunnu_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XRRSetScreenConfig((void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetScreenConfigAndRate_aaunnnu_n(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=XRRSetScreenConfigAndRate((void *)(x.spx[6]),(void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigRotations_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRConfigRotations((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigTimes_aa_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRConfigTimes((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigSizes_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRConfigSizes((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigRates_ana_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRConfigRates((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigCurrentConfiguration_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRConfigCurrentConfiguration((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigCurrentRate_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XRRConfigCurrentRate((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRRootToScreen_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRRootToScreen((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSelectInput_aun_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRSelectInput((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRRotations_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRRotations((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSizes_ana_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRSizes((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRRates_anna_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XRRRates((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRTimes_ana_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRTimes((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetScreenSizeRange_auaaaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=XRRGetScreenSizeRange((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetScreenSize_aunnnn_v(GFORTH_ARGS)
{
  ARGN(5,-1);
  XRRSetScreenSize((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetScreenResources_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRGetScreenResources((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeScreenResources_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeScreenResources((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetOutputInfo_aau_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRGetOutputInfo((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeOutputInfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeOutputInfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRListOutputProperties_aua_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRListOutputProperties((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRQueryOutputProperty_auu_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRQueryOutputProperty((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigureOutputProperty_auunnna_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  XRRConfigureOutputProperty((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRChangeOutputProperty_auuunnan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XRRChangeOutputProperty((void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRDeleteOutputProperty_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRDeleteOutputProperty((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetOutputProperty_auunnnnuaaaaa_n(GFORTH_ARGS)
{
  ARGN(12,-1);
  x.spx[12]=XRRGetOutputProperty((void *)(x.spx[12]),x.spx[11],x.spx[10],x.spx[9],x.spx[8],x.spx[7],x.spx[6],x.spx[5],(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 12;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRAllocModeInfo_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRAllocModeInfo((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRCreateMode_aua_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRCreateMode((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRDestroyMode_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  XRRDestroyMode((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRAddOutputMode_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRAddOutputMode((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRDeleteOutputMode_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRDeleteOutputMode((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeModeInfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeModeInfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetCrtcInfo_aau_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRGetCrtcInfo((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeCrtcInfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeCrtcInfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetCrtcConfig_aauunnunan_n(GFORTH_ARGS)
{
  ARGN(9,-1);
  x.spx[9]=XRRSetCrtcConfig((void *)(x.spx[9]),(void *)(x.spx[8]),x.spx[7],x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetCrtcGammaSize_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRGetCrtcGammaSize((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetCrtcGamma_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRGetCrtcGamma((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRAllocGamma_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)XRRAllocGamma(x.spx[0]);
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetCrtcGamma_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRSetCrtcGamma((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeGamma_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeGamma((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetScreenResourcesCurrent_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRGetScreenResourcesCurrent((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetCrtcTransform_auasan_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  XRRSetCrtcTransform((void *)(x.spx[6]),x.spx[5],(void *)(x.spx[4]),gforth_str2c((Char*)x.spx[3],x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetCrtcTransform_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRGetCrtcTransform((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRUpdateConfiguration_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=XRRUpdateConfiguration((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetPanning_aau_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRGetPanning((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreePanning_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreePanning((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetPanning_aaua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=XRRSetPanning((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetOutputPrimary_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRSetOutputPrimary((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetOutputPrimary_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=XRRGetOutputPrimary((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetProviderResources_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRGetProviderResources((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeProviderResources_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeProviderResources((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetProviderInfo_aau_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRGetProviderInfo((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeProviderInfo_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeProviderInfo((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetProviderOutputSource_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRSetProviderOutputSource((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetProviderOffloadSink_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=XRRSetProviderOffloadSink((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRListProviderProperties_aua_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRListProviderProperties((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRQueryProviderProperty_auu_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)XRRQueryProviderProperty((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRConfigureProviderProperty_auunnna_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  XRRConfigureProviderProperty((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRChangeProviderProperty_auuunnan_v(GFORTH_ARGS)
{
  ARGN(7,-1);
  XRRChangeProviderProperty((void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRDeleteProviderProperty_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRDeleteProviderProperty((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetProviderProperty_auunnnnuaaaaa_n(GFORTH_ARGS)
{
  ARGN(12,-1);
  x.spx[12]=XRRGetProviderProperty((void *)(x.spx[12]),x.spx[11],x.spx[10],x.spx[9],x.spx[8],x.spx[7],x.spx[6],x.spx[5],(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 12;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRAllocateMonitor_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)XRRAllocateMonitor((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRGetMonitors_auna_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)XRRGetMonitors((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRSetMonitor_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRSetMonitor((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRDeleteMonitor_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  XRRDeleteMonitor((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfx_LTX_gforth_c_XRRFreeMonitors_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  XRRFreeMonitors((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_x = "\x7E\x8B\x0D\x7B\x93\xAA\x7E\x06\x83\xBB\x14\xBC\x27\xC7\x17\x38";
