#include <libcc.h>
#include <libpng16/png.h>
#ifdef __gnu_linux__
#undef stderr
extern struct _IO_FILE *stderr;
#endif
#define CALLBACK_png_error_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_error_ptr__##I (void* x0, void* x1) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  c_str2gforth_str((x1),x.spx[-2],x.spx[-3]); \
  x.spx+=-3; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_error_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_error_ptr_[2] = {
  0, 0,};
CALLBACK_png_error_ptr_(0)
CALLBACK_png_error_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_error_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_error_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_error_ptr__1,
};
#define CALLBACK_png_rw_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_rw_ptr__##I (void* x0, void* x1, Cell x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx[-3]=(x2); \
  x.spx+=-3; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_rw_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_rw_ptr_[2] = {
  0, 0,};
CALLBACK_png_rw_ptr_(0)
CALLBACK_png_rw_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_rw_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_rw_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_rw_ptr__1,
};
#define CALLBACK_png_flush_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_flush_ptr__##I (void* x0) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx+=-1; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_flush_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_flush_ptr_[2] = {
  0, 0,};
CALLBACK_png_flush_ptr_(0)
CALLBACK_png_flush_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_flush_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_flush_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_flush_ptr__1,
};
#define CALLBACK_png_read_status_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_read_status_ptr__##I (void* x0, UCell x1, Cell x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(x2); \
  x.spx+=-3; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_read_status_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_read_status_ptr_[2] = {
  0, 0,};
CALLBACK_png_read_status_ptr_(0)
CALLBACK_png_read_status_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_read_status_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_read_status_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_read_status_ptr__1,
};
#define CALLBACK_png_write_status_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_write_status_ptr__##I (void* x0, UCell x1, Cell x2) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx[-3]=(x2); \
  x.spx+=-3; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_write_status_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_write_status_ptr_[2] = {
  0, 0,};
CALLBACK_png_write_status_ptr_(0)
CALLBACK_png_write_status_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_write_status_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_write_status_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_write_status_ptr__1,
};
#define CALLBACK_png_malloc_ptr_(I) \
void* libgfpng16_LTX_gforth_cb_png_malloc_ptr__##I (void* x0, Cell x1) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(x1); \
  x.spx+=-2; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_malloc_ptr_[I], &x); \
  return (void *)(x.spx[0]); \
}
Xt* libgfpng16_LTX_gforth_cbips_png_malloc_ptr_[2] = {
  0, 0,};
CALLBACK_png_malloc_ptr_(0)
CALLBACK_png_malloc_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_malloc_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_malloc_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_malloc_ptr__1,
};
#define CALLBACK_png_free_ptr_(I) \
void libgfpng16_LTX_gforth_cb_png_free_ptr__##I (void* x0, void* x1) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(Cell)(x0); \
  x.spx[-2]=(Cell)(x1); \
  x.spx+=-2; \
  gforth_engine(libgfpng16_LTX_gforth_cbips_png_free_ptr_[I], &x); \
; \
}
Xt* libgfpng16_LTX_gforth_cbips_png_free_ptr_[2] = {
  0, 0,};
CALLBACK_png_free_ptr_(0)
CALLBACK_png_free_ptr_(1)
const Address libgfpng16_LTX_gforth_callbacks_png_free_ptr_[2] = {
  (Address)libgfpng16_LTX_gforth_cb_png_free_ptr__0,
  (Address)libgfpng16_LTX_gforth_cb_png_free_ptr__1,
};
gforth_stackpointers libgfpng16_LTX_gforth_c_png_access_version_number__u(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=png_access_version_number();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_sig_bytes_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_set_sig_bytes((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_sig_cmp_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=png_sig_cmp((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_create_read_struct_saaa_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)png_create_read_struct(gforth_str2c((Char*)x.spx[4],x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_create_write_struct_saaa_a(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=(Cell)png_create_write_struct(gforth_str2c((Char*)x.spx[4],x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_compression_buffer_size_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=png_get_compression_buffer_size((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_compression_buffer_size_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_set_compression_buffer_size((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_longjmp_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_longjmp((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_sig_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  png_write_sig((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_chunk_aaan_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_write_chunk((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_chunk_start_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_write_chunk_start((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_chunk_data_aan_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_write_chunk_data((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_chunk_end_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  png_write_chunk_end((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_create_info_struct_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)png_create_info_struct((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_info_before_PLTE_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_write_info_before_PLTE((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_info_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_write_info((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_start_read_image_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  png_start_read_image((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_read_update_info_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_read_update_info((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_row_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_write_row((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_rows_aau_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_write_rows((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_image_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_write_image((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_write_end_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_write_end((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_destroy_info_struct_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_destroy_info_struct((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_destroy_read_struct_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_destroy_read_struct((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_destroy_write_struct_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_destroy_write_struct((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_crc_action_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_set_crc_action((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_error_fn_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_set_error_fn((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_error_ptr_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)png_get_error_ptr((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_write_fn_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_set_write_fn((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_read_fn_aaa_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_set_read_fn((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_io_ptr_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)png_get_io_ptr((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_read_status_fn_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_set_read_status_fn((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_write_status_fn_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_set_write_status_fn((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_malloc_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)png_malloc((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_calloc_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)png_calloc((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_malloc_warn_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)png_malloc_warn((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_free_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  png_free((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_free_data_aaun_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_free_data((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_data_freer_aanu_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_data_freer((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_error_as_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_error((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_chunk_error_as_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_chunk_error((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_valid_aau_u(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=png_get_valid((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_rowbytes_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=png_get_rowbytes((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_channels_aa_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=png_get_channels((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_IHDR_aaaaaaaaa_u(GFORTH_ARGS)
{
  ARGN(8,-1);
  x.spx[8]=png_get_IHDR((void *)(x.spx[8]),(void *)(x.spx[7]),(void *)(x.spx[6]),(void *)(x.spx[5]),(void *)(x.spx[4]),(void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 8;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_IHDR_aauunnnnn_v(GFORTH_ARGS)
{
  ARGN(8,-1);
  png_set_IHDR((void *)(x.spx[8]),(void *)(x.spx[7]),x.spx[6],x.spx[5],x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 9;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_PLTE_aaaa_u(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=png_get_PLTE((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_PLTE_aaan_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  png_set_PLTE((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_set_invalid_aan_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  png_set_invalid((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_copyright_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(png_get_copyright((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_header_ver_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(png_get_header_ver((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_header_version_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(png_get_header_version((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_libpng_ver_a_s(GFORTH_ARGS)
{
  ARGN(0,-1);
  c_str2gforth_str(png_get_libpng_ver((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpng16_LTX_gforth_c_png_get_uint_31_aa_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=png_get_uint_31((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_png16 = "\x59\x2D\xEE\xEA\xB4\x1B\xC5\xA4\x9A\xBC\x5F\x4A\x6E\x4C\xAF\x03";
