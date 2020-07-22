#include <libcc.h>
#include <unistd.h>
#include <sys/mman.h>
#include <limits.h>
gforth_stackpointers libgfmmap_LTX_gforth_c_mmap_annnnn_a(GFORTH_ARGS)
{
  ARGN(5,-1);
  x.spx[5]=(Cell)mmap((void *)(x.spx[5]),x.spx[4],x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 5;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_munmap_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=munmap((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_madvise_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=madvise((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_mprotect_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=mprotect((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_mlock_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=mlock((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_munlock_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=munlock((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfmmap_LTX_gforth_c_msync_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=msync((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
hash_128 gflibcc_hash_mmap = "\xA6\x35\x8E\x43\x95\xAF\xF5\x25\xDF\x2B\xB2\x0A\x54\xB6\xA8\x68";
