#include <libcc.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <sys/time.h>
#include <unistd.h>
gforth_stackpointers libgffilestat_LTX_gforth_c_stat_sa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=stat(gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_fstat_na_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=fstat(x.spx[1],(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_lstat_sa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=lstat(gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_utimes_sa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=utimes(gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_lutimes_sa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=lutimes(gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_futimes_na_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=futimes(x.spx[1],(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_chmod_sn_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=chmod(gforth_str2c((Char*)x.spx[2],x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_fchmod_nn_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=fchmod(x.spx[1],x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_chown_snn_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=chown(gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_fchown_nnn_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=fchown(x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffilestat_LTX_gforth_c_lchown_snn_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=lchown(gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
hash_128 gflibcc_hash_filestat = "\xBF\xA7\xD0\x34\xD6\x9C\x58\xC7\x35\x93\x8E\x0E\x27\x82\x20\x3B";
