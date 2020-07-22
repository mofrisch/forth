#include <libcc.h>
#include <string.h>
#include <stdlib.h>
gforth_stackpointers libgflibcc_LTX_gforth_c_strlen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=strlen((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgflibcc_LTX_gforth_c_labs_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=labs(x.spx[0]);
  return x;
}
#define _FILE_OFFSET_BITS 64
#include <sys/types.h>
#include <unistd.h>
gforth_stackpointers libgflibcc_LTX_gforth_c_lseek_ndn_d(GFORTH_ARGS)
{
  ARGN(3,-1);
  gforth_ll2d(lseek(x.spx[3],gforth_d2ll(x.spx[2],x.spx[1]),x.spx[0]),x.spx[3],x.spx[2]);
  x.spx += 2;
  return x;
}
#include <stdio.h>
gforth_stackpointers libgflibcc_LTX_gforth_c_sprintf_aanr_n(GFORTH_ARGS)
{
  ARGN(2,0);
  x.spx[2]=sprintf((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0],x.fpx[0]);
  x.spx += 2;
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgflibcc_LTX_gforth_c_sprintf_aarn_n(GFORTH_ARGS)
{
  ARGN(2,0);
  x.spx[2]=sprintf((void *)(x.spx[2]),(void *)(x.spx[1]),x.fpx[0],x.spx[0]);
  x.spx += 2;
  x.fpx += 1;
  return x;
}
#define sprintfull(a,s,ull) sprintf(a,s,(unsigned long long)ull)
gforth_stackpointers libgflibcc_LTX_gforth_c_sprintfull_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=sprintfull((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
#define sprintfll(a,s,ll) sprintf(a,s,(long long)ll)
gforth_stackpointers libgflibcc_LTX_gforth_c_sprintfll_aan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=sprintfll((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
typedef long (* func1)(long);
#define labsptr(dummy) ((func1)labs)
gforth_stackpointers libgflibcc_LTX_gforth_c_labsptr__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)labsptr();
  x.spx += -1;
  return x;
}
#define call_func1(par1,fptr) ((func1)fptr)(par1)
gforth_stackpointers libgflibcc_LTX_gforth_c_call_func1_nf_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=call_func1(x.spx[1],(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
#define CALLBACK_test_callback_(I) \
UCell libgflibcc_LTX_gforth_cb_test_callback__##I (UCell x0, UCell x1) \
{ \
  stackpointers x; \
  Cell stack[GFSS+8], rstack[GFSS], lstack[GFSS]; Float fstack[GFSS+2]; \
  x.spx=stack+GFSS; x.rpx=rstack+GFSS; x.lpx=(char*)(lstack+GFSS); x.fpx=fstack+GFSS; x.upx=gforth_main_UP; x.magic=GFORTH_MAGIC; \
  x.handler=0; x.first_throw = ~0; x.wraphandler=0; \
  x.spx[-1]=(x0); \
  x.spx[-2]=(x1); \
  x.spx+=-2; \
  gforth_engine(libgflibcc_LTX_gforth_cbips_test_callback_[I], &x); \
  return x.spx[0]; \
}
Xt* libgflibcc_LTX_gforth_cbips_test_callback_[2] = {
  0, 0,};
CALLBACK_test_callback_(0)
CALLBACK_test_callback_(1)
const Address libgflibcc_LTX_gforth_callbacks_test_callback_[2] = {
  (Address)libgflibcc_LTX_gforth_cb_test_callback__0,
  (Address)libgflibcc_LTX_gforth_cb_test_callback__1,
};
gforth_stackpointers libgflibcc_LTX_gforth_c___Cell____Cell_Cell___ptr___uu_u(GFORTH_ARGS)
{
  ARGN(1,-1);
  Cell ptr = *x.spx++;
  x.spx[1]=((Cell(*)(Cell,Cell))(ptr))(x.spx[1],x.spx[0]);
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_libcc = "\x94\xB5\x74\xF3\x4F\x8B\x43\xA4\x43\xF5\x3E\x72\xA8\xB4\xF7\x08";
