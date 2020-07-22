#include <libcc.h>
#include <harfbuzz/hb.h>
#ifdef __gnu_linux__
#undef stderr
extern struct _IO_FILE *stderr;
#endif
#define CALLBACK_hb_buffer_message_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_buffer_message_func_t__##I (void* x0, void* x1, void* x2, void* x3) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  c_str2gforth_str((x2),x.spx[-3],x.spx[-4]); \
  x.spx[-5]=(Cell)(x3); \
  x.spx+=-5; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_buffer_message_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_buffer_message_func_t_[2] = {
  0, 0,};
CALLBACK_hb_buffer_message_func_t_(0)
CALLBACK_hb_buffer_message_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_buffer_message_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_buffer_message_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_buffer_message_func_t__1,
};
#define CALLBACK_hb_destroy_func_t_(I) \
void libgfharfbuzz_LTX_gforth_cb_hb_destroy_func_t__##I (void* x0) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx+=-1; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_destroy_func_t_[I], &x); \
; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_destroy_func_t_[2] = {
  0, 0,};
CALLBACK_hb_destroy_func_t_(0)
CALLBACK_hb_destroy_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_destroy_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_destroy_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_destroy_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_func_t__##I (void* x0, void* x1, UCell x2, UCell x3, void* x4, void* x5) \
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
  x.spx[-6]=(Cell)(x5); \
  x.spx+=-6; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_func_t_(0)
CALLBACK_hb_font_get_glyph_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_func_t__1,
};
#define CALLBACK_hb_unicode_eastasian_width_func_t_(I) \
UCell libgfharfbuzz_LTX_gforth_cb_hb_unicode_eastasian_width_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_eastasian_width_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_eastasian_width_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_eastasian_width_func_t_(0)
CALLBACK_hb_unicode_eastasian_width_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_eastasian_width_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_eastasian_width_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_eastasian_width_func_t__1,
};
#define CALLBACK_hb_unicode_decompose_compatibility_func_t_(I) \
UCell libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_compatibility_func_t__##I (void* x0, UCell x1, void* x2, void* x3) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx+=-4; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_decompose_compatibility_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_decompose_compatibility_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_decompose_compatibility_func_t_(0)
CALLBACK_hb_unicode_decompose_compatibility_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_decompose_compatibility_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_compatibility_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_compatibility_func_t__1,
};
#define CALLBACK_hb_reference_table_func_t_(I) \
void* libgfharfbuzz_LTX_gforth_cb_hb_reference_table_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_reference_table_func_t_[I], &x); \
  return (void *)(x.spx[0]); \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_reference_table_func_t_[2] = {
  0, 0,};
CALLBACK_hb_reference_table_func_t_(0)
CALLBACK_hb_reference_table_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_reference_table_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_reference_table_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_reference_table_func_t__1,
};
#define CALLBACK_hb_font_get_font_extents_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_font_extents_func_t__##I (void* x0, void* x1, void* x2, void* x3) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx+=-4; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_font_extents_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_font_extents_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_font_extents_func_t_(0)
CALLBACK_hb_font_get_font_extents_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_font_extents_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_font_extents_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_font_extents_func_t__1,
};
#define CALLBACK_hb_font_get_nominal_glyph_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyph_func_t__##I (void* x0, void* x1, UCell x2, void* x3, void* x4) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx+=-5; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_nominal_glyph_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_nominal_glyph_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_nominal_glyph_func_t_(0)
CALLBACK_hb_font_get_nominal_glyph_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_nominal_glyph_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyph_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyph_func_t__1,
};
#define CALLBACK_hb_font_get_variation_glyph_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_variation_glyph_func_t__##I (void* x0, void* x1, UCell x2, UCell x3, void* x4, void* x5) \
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
  x.spx[-6]=(Cell)(x5); \
  x.spx+=-6; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_variation_glyph_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_variation_glyph_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_variation_glyph_func_t_(0)
CALLBACK_hb_font_get_variation_glyph_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_variation_glyph_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_variation_glyph_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_variation_glyph_func_t__1,
};
#define CALLBACK_hb_font_get_nominal_glyphs_func_t_(I) \
UCell libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyphs_func_t__##I (void* x0, void* x1, UCell x2, void* x3, UCell x4, void* x5, UCell x6, void* x7) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(x4); \
  x.spx[-6]=(Cell)(x5); \
  x.spx[-7]=(x6); \
  x.spx[-8]=(Cell)(x7); \
  x.spx+=-8; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_nominal_glyphs_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_nominal_glyphs_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_nominal_glyphs_func_t_(0)
CALLBACK_hb_font_get_nominal_glyphs_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_nominal_glyphs_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyphs_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_nominal_glyphs_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_advance_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advance_func_t__##I (void* x0, void* x1, UCell x2, void* x3) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx+=-4; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_advance_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_advance_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_advance_func_t_(0)
CALLBACK_hb_font_get_glyph_advance_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_advance_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advance_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advance_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_advances_func_t_(I) \
void libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advances_func_t__##I (void* x0, void* x1, UCell x2, void* x3, UCell x4, void* x5, UCell x6, void* x7) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(x4); \
  x.spx[-6]=(Cell)(x5); \
  x.spx[-7]=(x6); \
  x.spx[-8]=(Cell)(x7); \
  x.spx+=-8; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_advances_func_t_[I], &x); \
; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_advances_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_advances_func_t_(0)
CALLBACK_hb_font_get_glyph_advances_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_advances_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advances_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_advances_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_origin_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_origin_func_t__##I (void* x0, void* x1, UCell x2, void* x3, void* x4, void* x5) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx[-6]=(Cell)(x5); \
  x.spx+=-6; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_origin_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_origin_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_origin_func_t_(0)
CALLBACK_hb_font_get_glyph_origin_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_origin_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_origin_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_origin_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_kerning_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_kerning_func_t__##I (void* x0, void* x1, UCell x2, UCell x3, void* x4) \
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
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_kerning_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_kerning_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_kerning_func_t_(0)
CALLBACK_hb_font_get_glyph_kerning_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_kerning_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_kerning_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_kerning_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_extents_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_extents_func_t__##I (void* x0, void* x1, UCell x2, void* x3, void* x4) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx+=-5; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_extents_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_extents_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_extents_func_t_(0)
CALLBACK_hb_font_get_glyph_extents_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_extents_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_extents_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_extents_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_contour_point_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_contour_point_func_t__##I (void* x0, void* x1, UCell x2, UCell x3, void* x4, void* x5, void* x6) \
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
  x.spx[-6]=(Cell)(x5); \
  x.spx[-7]=(Cell)(x6); \
  x.spx+=-7; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_contour_point_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_contour_point_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_contour_point_func_t_(0)
CALLBACK_hb_font_get_glyph_contour_point_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_contour_point_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_contour_point_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_contour_point_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_name_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_name_func_t__##I (void* x0, void* x1, UCell x2, void* x3, UCell x4, void* x5) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(x4); \
  x.spx[-6]=(Cell)(x5); \
  x.spx+=-6; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_name_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_name_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_name_func_t_(0)
CALLBACK_hb_font_get_glyph_name_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_name_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_name_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_name_func_t__1,
};
#define CALLBACK_hb_font_get_glyph_from_name_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_from_name_func_t__##I (void* x0, void* x1, void* x2, Cell x3, void* x4, void* x5) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx[-4]=(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx[-6]=(Cell)(x5); \
  x.spx+=-6; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_from_name_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_font_get_glyph_from_name_func_t_[2] = {
  0, 0,};
CALLBACK_hb_font_get_glyph_from_name_func_t_(0)
CALLBACK_hb_font_get_glyph_from_name_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_font_get_glyph_from_name_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_from_name_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_font_get_glyph_from_name_func_t__1,
};
#define CALLBACK_hb_unicode_combining_class_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_unicode_combining_class_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_combining_class_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_combining_class_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_combining_class_func_t_(0)
CALLBACK_hb_unicode_combining_class_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_combining_class_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_combining_class_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_combining_class_func_t__1,
};
#define CALLBACK_hb_unicode_general_category_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_unicode_general_category_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_general_category_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_general_category_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_general_category_func_t_(0)
CALLBACK_hb_unicode_general_category_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_general_category_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_general_category_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_general_category_func_t__1,
};
#define CALLBACK_hb_unicode_mirroring_func_t_(I) \
UCell libgfharfbuzz_LTX_gforth_cb_hb_unicode_mirroring_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_mirroring_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_mirroring_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_mirroring_func_t_(0)
CALLBACK_hb_unicode_mirroring_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_mirroring_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_mirroring_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_mirroring_func_t__1,
};
#define CALLBACK_hb_unicode_script_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_unicode_script_func_t__##I (void* x0, UCell x1, void* x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx+=-3; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_script_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_script_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_script_func_t_(0)
CALLBACK_hb_unicode_script_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_script_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_script_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_script_func_t__1,
};
#define CALLBACK_hb_unicode_compose_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_unicode_compose_func_t__##I (void* x0, UCell x1, UCell x2, void* x3, void* x4) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx+=-5; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_compose_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_compose_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_compose_func_t_(0)
CALLBACK_hb_unicode_compose_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_compose_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_compose_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_compose_func_t__1,
};
#define CALLBACK_hb_unicode_decompose_func_t_(I) \
Cell libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_func_t__##I (void* x0, UCell x1, void* x2, void* x3, void* x4) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(Cell)(x2); \
  x.spx[-4]=(Cell)(x3); \
  x.spx[-5]=(Cell)(x4); \
  x.spx+=-5; \
  gforth_engine(libgfharfbuzz_LTX_gforth_cbips_hb_unicode_decompose_func_t_[I], &x); \
  return x.spx[0]; \
}
Xt* libgfharfbuzz_LTX_gforth_cbips_hb_unicode_decompose_func_t_[2] = {
  0, 0,};
CALLBACK_hb_unicode_decompose_func_t_(0)
CALLBACK_hb_unicode_decompose_func_t_(1)
const Address libgfharfbuzz_LTX_gforth_callbacks_hb_unicode_decompose_func_t_[2] = {
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_func_t__0,
  (Address)libgfharfbuzz_LTX_gforth_cb_hb_unicode_decompose_func_t__1,
};
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_create_sunaa_a(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=(Cell)hb_blob_create(gforth_str2c((Char*)x.spx[5],x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_create_from_file_s_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_blob_create_from_file(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_create_sub_blob_auu_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)hb_blob_create_sub_blob((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_copy_writable_or_fail_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_blob_copy_writable_or_fail((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_blob_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_blob_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_blob_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_blob_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_blob_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_make_immutable_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_blob_make_immutable((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_is_immutable_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_blob_is_immutable((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_get_length_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_blob_get_length((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_get_data_aa_s(GFORTH_ARGS)
{
  ARGN(1,-1);
  c_str2gforth_str(hb_blob_get_data((void *)(x.spx[1]),(void *)(x.spx[0])),x.spx[1],x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_blob_get_data_writable_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_blob_get_data_writable((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_segment_properties_equal_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_segment_properties_equal((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_segment_properties_hash_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_segment_properties_hash((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_create__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_buffer_create();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_buffer_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_buffer_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_buffer_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_buffer_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_content_type_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_content_type((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_content_type_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_content_type((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_unicode_funcs_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_unicode_funcs((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_unicode_funcs_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_buffer_get_unicode_funcs((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_direction_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_direction((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_direction_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_direction((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_script_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_script((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_script_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_script((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_language_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_language((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_language_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_buffer_get_language((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_segment_properties_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_segment_properties((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_segment_properties_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_get_segment_properties((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_guess_segment_properties_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_guess_segment_properties((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_flags_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_flags((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_flags_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_flags((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_cluster_level_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_cluster_level((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_cluster_level_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_cluster_level((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_replacement_codepoint_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_replacement_codepoint((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_replacement_codepoint_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_replacement_codepoint((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_invisible_glyph_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_buffer_set_invisible_glyph((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_invisible_glyph_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_invisible_glyph((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_reset_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_reset((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_clear_contents_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_clear_contents((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_pre_allocate_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_buffer_pre_allocate((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_allocation_successful_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_allocation_successful((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_reverse_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_reverse((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_reverse_range_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_buffer_reverse_range((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_reverse_clusters_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_reverse_clusters((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_buffer_add((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_utf8_aanun_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_buffer_add_utf8((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_utf16_aanun_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_buffer_add_utf16((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_utf32_aanun_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_buffer_add_utf32((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_latin1_aanun_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_buffer_add_latin1((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_add_codepoints_aanun_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_buffer_add_codepoints((void *)(x.spx[4]),(void *)(x.spx[3]),x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_append_aauu_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_buffer_append((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_length_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_buffer_set_length((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_length_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_buffer_get_length((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_glyph_infos_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_buffer_get_glyph_infos((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_get_glyph_positions_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_buffer_get_glyph_positions((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_normalize_glyphs_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_buffer_normalize_glyphs((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_serialize_format_from_string_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_buffer_serialize_format_from_string((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_serialize_format_to_string_n_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(hb_buffer_serialize_format_to_string(x.spx[0]),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_serialize_list_formats__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_buffer_serialize_list_formats();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_serialize_glyphs_auuauaann_u(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=hb_buffer_serialize_glyphs((void *)(x.spx[8]),x.spx[7],x.spx[6],(void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_deserialize_glyphs_aanaan_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=hb_buffer_deserialize_glyphs((void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_diff_aauu_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_buffer_diff((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_buffer_set_message_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_buffer_set_message_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_tag_from_string_an_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_tag_from_string((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_tag_to_string_ua_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_tag_to_string(x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_direction_from_string_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_direction_from_string((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_direction_to_string_n_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(hb_direction_to_string(x.spx[0]),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_language_from_string_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_language_from_string((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_language_to_string_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(hb_language_to_string((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_language_get_default__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_language_get_default();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_script_from_iso15924_tag_u_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_script_from_iso15924_tag(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_script_from_string_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_script_from_string((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_script_to_iso15924_tag_n_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_script_to_iso15924_tag(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_script_get_horizontal_direction_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_script_get_horizontal_direction(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_feature_from_string_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_feature_from_string((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_feature_to_string_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_feature_to_string((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_variation_from_string_ana_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_variation_from_string((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_variation_to_string_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_variation_to_string((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_color_get_alpha_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_color_get_alpha(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_color_get_red_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_color_get_red(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_color_get_green_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_color_get_green(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_color_get_blue_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_color_get_blue(x.spx[0]);
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_invert_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_set_invert((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_eastasian_width_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_eastasian_width_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_eastasian_width_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_unicode_eastasian_width((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_decompose_compatibility_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_decompose_compatibility_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_decompose_compatibility_aua_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_unicode_decompose_compatibility((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_v_kerning_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_v_kerning_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_v_kerning_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_font_get_glyph_v_kerning((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_count_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_face_count((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_create_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_face_create((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_create_for_tables_aaa_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)hb_face_create_for_tables((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_face_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_face_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_face_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_face_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_face_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_make_immutable_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_face_make_immutable((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_is_immutable_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_face_is_immutable((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_reference_table_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_face_reference_table((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_reference_blob_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_face_reference_blob((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_set_index_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_face_set_index((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_index_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_face_get_index((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_set_upem_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_face_set_upem((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_upem_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_face_get_upem((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_set_glyph_count_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_face_set_glyph_count((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_glyph_count_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_face_get_glyph_count((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_get_table_tags_auaa_u(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_face_get_table_tags((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_collect_unicodes_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_face_collect_unicodes((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_collect_variation_selectors_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_face_collect_variation_selectors((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_collect_variation_unicodes_aua_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_face_collect_variation_unicodes((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_builder_create__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_face_builder_create();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_face_builder_add_table_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_face_builder_add_table((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_create__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_font_funcs_create();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_font_funcs_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_funcs_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_font_funcs_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_font_funcs_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_font_funcs_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_make_immutable_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_font_funcs_make_immutable((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_is_immutable_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_font_funcs_is_immutable((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_font_h_extents_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_font_h_extents_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_font_v_extents_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_font_v_extents_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_nominal_glyph_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_nominal_glyph_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_nominal_glyphs_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_nominal_glyphs_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_variation_glyph_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_variation_glyph_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_h_advance_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_h_advance_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_v_advance_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_v_advance_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_h_advances_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_h_advances_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_v_advances_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_v_advances_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_h_origin_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_h_origin_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_v_origin_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_v_origin_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_h_kerning_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_h_kerning_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_extents_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_extents_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_contour_point_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_contour_point_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_name_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_name_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_funcs_set_glyph_from_name_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_funcs_set_glyph_from_name_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_h_extents_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_font_get_h_extents((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_v_extents_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_font_get_v_extents((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_nominal_glyph_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_font_get_nominal_glyph((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_variation_glyph_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_variation_glyph((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_nominal_glyphs_auauau_u(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=hb_font_get_nominal_glyphs((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_h_advance_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_font_get_glyph_h_advance((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_v_advance_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_font_get_glyph_v_advance((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_h_advances_auauau_v(GFORTH_ARGS)
{
  ARGN(5,-1);
  hb_font_get_glyph_h_advances((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_v_advances_auauau_v(GFORTH_ARGS)
{
  ARGN(5,-1);
  hb_font_get_glyph_v_advances((void *)(x.spx[5]),x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_h_origin_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph_h_origin((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_v_origin_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph_v_origin((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_h_kerning_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_font_get_glyph_h_kerning((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_extents_aua_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_font_get_glyph_extents((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_contour_point_auuaa_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_font_get_glyph_contour_point((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_name_auau_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph_name((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_from_name_aana_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph_from_name((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_extents_for_direction_ana_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_get_extents_for_direction((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_advance_for_direction_aunaa_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_font_get_glyph_advance_for_direction((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_advances_for_direction_anuauau_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  hb_font_get_glyph_advances_for_direction((void *)(x.spx[6]),x.spx[5],x.spx[4],(void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_origin_for_direction_aunaa_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_font_get_glyph_origin_for_direction((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_add_glyph_origin_for_direction_aunaa_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_font_add_glyph_origin_for_direction((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_subtract_glyph_origin_for_direction_aunaa_v(GFORTH_ARGS)
{
  ARGN(4,-1);
  hb_font_subtract_glyph_origin_for_direction((void *)(x.spx[4]),x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_kerning_for_direction_auunaa_v(GFORTH_ARGS)
{
  ARGN(5,-1);
  hb_font_get_glyph_kerning_for_direction((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_extents_for_origin_auna_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_get_glyph_extents_for_origin((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_glyph_contour_point_for_origin_auunaa_n(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=hb_font_get_glyph_contour_point_for_origin((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_glyph_to_string_auau_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_glyph_to_string((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_glyph_from_string_aana_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_font_glyph_from_string((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_create_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_create((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_create_sub_font_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_create_sub_font((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_font_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_font_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_font_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_font_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_make_immutable_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_font_make_immutable((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_is_immutable_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_font_is_immutable((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_parent_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_font_set_parent((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_parent_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_get_parent((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_face_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_font_set_face((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_face_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_font_get_face((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_funcs_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_font_set_funcs((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_funcs_data_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_funcs_data((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_scale_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_scale((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_scale_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_get_scale((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_ppem_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_ppem((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_ppem_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_get_ppem((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_ptem_ar_v(GFORTH_ARGS)
{
  ARGN(0,0);
  hb_font_set_ptem((void *)(x.spx[0]),x.fpx[0]);
  x.spx += 1;
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_ptem_a_r(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.fpx[-1]=hb_font_get_ptem((void *)(x.spx[0]));
  x.spx += 1;
  x.fpx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_variations_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_variations((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_var_coords_design_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_var_coords_design((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_var_coords_normalized_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_font_set_var_coords_normalized((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_get_var_coords_normalized_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_font_get_var_coords_normalized((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_font_set_var_named_instance_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_font_set_var_named_instance((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_create__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_set_create();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_set_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_set_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_set_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_set_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_set_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_allocation_successful_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_set_allocation_successful((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_clear_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_set_clear((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_is_empty_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_set_is_empty((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_has_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_set_has((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_add_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_add((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_add_range_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_set_add_range((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_del_au_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_del((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_del_range_auu_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_set_del_range((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_is_equal_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_set_is_equal((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_is_subset_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_set_is_subset((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_set_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_set((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_union_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_union((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_intersect_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_intersect((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_subtract_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_subtract((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_symmetric_difference_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  hb_set_symmetric_difference((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_get_population_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_set_get_population((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_get_min_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_set_get_min((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_get_max_a_u(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_set_get_max((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_next_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_set_next((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_previous_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_set_previous((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_next_range_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_set_next_range((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_set_previous_range_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_set_previous_range((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_aaau_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_shape((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_full_aaaua_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_shape_full((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_list_shapers__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_shape_list_shapers();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_create_aaaua_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)hb_shape_plan_create((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_create_cached_aaaua_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)hb_shape_plan_create_cached((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_create2_aaauaua_a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)hb_shape_plan_create2((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_create_cached2_aaauaua_a(GFORTH_ARGS)
{
  ARGN(6,-1);
  x.spx[6]=(Cell)hb_shape_plan_create_cached2((void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),x.spx[3],(void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 6;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_shape_plan_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_shape_plan_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_shape_plan_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_shape_plan_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_shape_plan_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_execute_aaaau_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_shape_plan_execute((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_shape_plan_get_shaper_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(hb_shape_plan_get_shaper((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_get_default__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_unicode_funcs_get_default();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_create_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_unicode_funcs_create((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_get_empty__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)hb_unicode_funcs_get_empty();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_reference_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_unicode_funcs_reference((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_destroy_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_unicode_funcs_destroy((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_user_data_aaaan_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=hb_unicode_funcs_set_user_data((void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_get_user_data_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)hb_unicode_funcs_get_user_data((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_make_immutable_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  hb_unicode_funcs_make_immutable((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_is_immutable_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=hb_unicode_funcs_is_immutable((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_get_parent_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)hb_unicode_funcs_get_parent((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_combining_class_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_combining_class_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_general_category_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_general_category_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_mirroring_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_mirroring_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_script_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_script_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_compose_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_compose_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_funcs_set_decompose_func_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  hb_unicode_funcs_set_decompose_func((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_combining_class_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_unicode_combining_class((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_general_category_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_unicode_general_category((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_mirroring_au_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_unicode_mirroring((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_script_au_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=hb_unicode_script((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_compose_auua_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_unicode_compose((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_unicode_decompose_auaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=hb_unicode_decompose((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_version_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  hb_version((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_version_string__s(GFORTH_ARGS)
{
  ARGN(-1,-1);
  c_str2gforth_str(hb_version_string(),x.spx[-1],x.spx[-2]);
  x.spx += -2;
  return x;
}
gforth_stackpointers libgfharfbuzz_LTX_gforth_c_hb_version_atleast_uuu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=hb_version_atleast(x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
hash_128 gflibcc_hash_harfbuzz = "\x85\x64\x64\x59\xE1\x0D\xCB\x94\x25\xFD\x73\xE7\x5F\xCE\x34\xCD";
