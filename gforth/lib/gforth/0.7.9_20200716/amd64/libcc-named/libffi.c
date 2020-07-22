#include <libcc.h>
#ifdef __APPLE__
# define MACOSX
#endif
#include <ffi/ffi.h>
#include <stdio.h>
static PER_THREAD void **gforth_clist;
static PER_THREAD void *gforth_ritem;
typedef void *Label;
static void gforth_callback_ffi(ffi_cif * cif, void * resp, void ** args, void * ip)
{
  {
    /* save global variables */
    stackpointers *SPs=get_gforth_SPs();
    gforth_stackpointers x;
    Cell *rp = SPs->rpx;
    char *lp = SPs->lpx;
    void ** clist = gforth_clist;
    void * ritem = gforth_ritem;
    x.spx = SPs->spx;
    x.fpx = SPs->fpx;

    gforth_clist = args;
    gforth_ritem = resp;

    gforth_engine((Xt *)ip, SPs);

    /* restore global variables */
    SPs->rpx = rp;
    SPs->spx = x.spx;
    SPs->fpx = x.fpx;
    SPs->lpx = lp;
    gforth_clist = clist;
    gforth_ritem = ritem;
  }
}
static void* ffi_types[] =
    { &ffi_type_void,
      &ffi_type_uint8, &ffi_type_sint8,
      &ffi_type_uint16, &ffi_type_sint16,
      &ffi_type_uint32, &ffi_type_sint32,
      &ffi_type_uint64, &ffi_type_sint64,
      &ffi_type_float, &ffi_type_double, &ffi_type_longdouble,
      &ffi_type_pointer };
#define ffi_type(n) (ffi_types[n])
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_type_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)ffi_type(x.spx[0]);
  return x;
}
static int ffi_sizes[] = { sizeof(ffi_cif), sizeof(ffi_closure) };
#define ffi_size(n1) (ffi_sizes[n1])
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_size_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=ffi_size(x.spx[0]);
  return x;
}
#define ffi_prep_cif1(atypes, n, rtype, cif) \
          ffi_prep_cif((ffi_cif *)cif, FFI_DEFAULT_ABI, n, \
                       (ffi_type *)rtype, (ffi_type **)atypes)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_prep_cif1_anaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=ffi_prep_cif1((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
#ifdef HAS_BACKLINK
#define ffi_call1(a_avalues, a_rvalue ,a_ip ,a_cif) \
            ffi_call((ffi_cif *)a_cif, (void(*)())a_ip, \
                     (void *)a_rvalue, (void **)a_avalues)
#else
#define ffi_call1(a_avalues, a_rvalue ,a_ip ,a_cif) \
            ffi_call((ffi_cif *)a_cif, (void(*)())a_ip, \
                     (void *)a_rvalue, (void **)a_avalues)
#endif
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_call1_aaaa_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  ffi_call1((void *)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
#define ffi_prep_closure1(a_ip, a_cif, a_closure) \
             ffi_prep_closure((ffi_closure *)a_closure, (ffi_cif *)a_cif, gforth_callback_ffi, (void *)a_ip)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_prep_closure1_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=ffi_prep_closure1((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
#define ffi_2fetch(a_addr) (*(long long *)a_addr)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_2fetch_a_d(GFORTH_ARGS)
{
  ARGN(0,-1);
  gforth_ll2d(ffi_2fetch((void *)(x.spx[0])),x.spx[0],x.spx[-1]);
  x.spx += -1;
  return x;
}
#define ffi_2store(d,a_addr) ((*(long long *)a_addr) = (long long)d)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_2store_da_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  ffi_2store(gforth_d2ll(x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
#define ffi_arg_int() (*(int *)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_int__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=ffi_arg_int();
  x.spx += -1;
  return x;
}
#define ffi_arg_long() (*(long *)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_long__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=ffi_arg_long();
  x.spx += -1;
  return x;
}
#define ffi_arg_longlong() (*(long long *)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_longlong__d(GFORTH_ARGS)
{
  ARGN(-1,-1);
  gforth_ll2d(ffi_arg_longlong(),x.spx[-1],x.spx[-2]);
  x.spx += -2;
  return x;
}
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_long__d(GFORTH_ARGS)
{
  ARGN(-1,-1);
  gforth_ll2d(ffi_arg_long(),x.spx[-1],x.spx[-2]);
  x.spx += -2;
  return x;
}
#define ffi_arg_ptr() (*(char **)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_ptr__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)ffi_arg_ptr();
  x.spx += -1;
  return x;
}
#define ffi_arg_float() (*(float *)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_float__r(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.fpx[-1]=ffi_arg_float();
  x.fpx += -1;
  return x;
}
#define ffi_arg_double() (*(double *)(*gforth_clist++))
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_arg_double__r(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.fpx[-1]=ffi_arg_double();
  x.fpx += -1;
  return x;
}
#define ffi_ret_int1(w) (*(int*)(gforth_ritem) = w)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_int1_n_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  ffi_ret_int1(x.spx[0]);
  x.spx += 1;
  return x;
}
#define ffi_ret_longlong1(d) (*(long long *)(gforth_ritem) = d)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_longlong1_d_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  ffi_ret_longlong1(gforth_d2ll(x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
#define ffi_ret_dlong1(d) (*(long *)(gforth_ritem) = d)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_dlong1_d_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  ffi_ret_dlong1(gforth_d2ll(x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_dlong1_n_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  ffi_ret_dlong1(x.spx[0]);
  x.spx += 1;
  return x;
}
#define ffi_ret_ptr1(w) (*(char **)(gforth_ritem) = w)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_ptr1_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  ffi_ret_ptr1((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
#define ffi_ret_float1(r) (*(float *)(gforth_ritem) = r)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_float1_r_v(GFORTH_ARGS)
{
  ARGN(-1,0);
  ffi_ret_float1(x.fpx[0]);
  x.fpx += 1;
  return x;
}
#define ffi_ret_double1(r) (*(double *)(gforth_ritem) = r)
gforth_stackpointers libgflibffi_LTX_gforth_c_ffi_ret_double1_r_v(GFORTH_ARGS)
{
  ARGN(-1,0);
  ffi_ret_double1(x.fpx[0]);
  x.fpx += 1;
  return x;
}
hash_128 gflibcc_hash_libffi = "\x9C\x11\x9B\x8B\x5C\x37\xE8\x13\xAB\x67\x6D\xED\x0A\xD1\xA7\x14";
