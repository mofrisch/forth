#include <libcc.h>
gforth_stackpointers libgfcstr_LTX_gforth_c_cstr_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)cstr((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfcstr_LTX_gforth_c_tilde_cstr_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)tilde_cstr((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_cstr = "\xC2\x7D\xB8\x78\x29\xDA\xD0\x6A\x71\x14\xEE\xE1\xB0\x1A\xD3\x09";
