#include <libcc.h>
#include <termios.h>
#include <sys/ioctl.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
gforth_stackpointers libgfserial_LTX_gforth_c_tcgetattr_na_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=tcgetattr(x.spx[1],(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_tcsetattr_nna_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=tcsetattr(x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_cfmakeraw_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  cfmakeraw((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_cfsetispeed_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=cfsetispeed((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_cfsetospeed_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=cfsetospeed((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_tcflow_nn_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=tcflow(x.spx[1],x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_ioctl_nna_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=ioctl(x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfserial_LTX_gforth_c_setvbuf_aann_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=setvbuf((void *)(x.spx[3]),(void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
hash_128 gflibcc_hash_serial = "\x1E\xAD\x8C\xF6\x59\x00\x9D\xCE\xB1\x66\x5D\x6A\x5A\xFD\x82\xA4";
