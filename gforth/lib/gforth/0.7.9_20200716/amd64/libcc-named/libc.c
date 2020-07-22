#include <libcc.h>
#include <stdio.h>
#include <errno.h>
#include <unistd.h>
#include <poll.h>
#include <fcntl.h>
#include <locale.h>
#include <sys/stat.h>
#if HAVE_GETPAGESIZE
#elif HAVE_SYSCONF && defined(_SC_PAGESIZE)
#define getpagesize() sysconf(_SC_PAGESIZE)
#elif PAGESIZE
#define getpagesize() PAGESIZE
#endif
#define set_errno(n) (errno=n)
extern char ** environ;
gforth_stackpointers libgflibc_LTX_gforth_c_errno__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(errno);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_set_errno_n_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  set_errno(x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_getpagesize__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=getpagesize();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_fileno_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=fileno((FILE*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_poll_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=poll((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_fdopen_ns_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)fdopen(x.spx[2],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_fcntl_nnn_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=fcntl(x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_open_snn_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=open(gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_read_nan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=read(x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_write_nan_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=write(x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_close_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=close(x.spx[0]);
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_setlocale_ns_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)setlocale(x.spx[2],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_getpid__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=getpid();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_fork__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=fork();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_execvp_sa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=execvp(gforth_str2c((Char*)x.spx[2],x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_exit_n_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  exit(x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_symlink_ss_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=symlink(gforth_str2c((Char*)x.spx[3],x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_link_ss_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=link(gforth_str2c((Char*)x.spx[3],x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_readlink_san_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=readlink(gforth_str2c((Char*)x.spx[3],x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_rmdir_s_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=rmdir(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_mknod_snn_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=mknod(gforth_str2c((Char*)x.spx[3],x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_mkstemp_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=mkstemp((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_getcwd_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)getcwd((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_strlen_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=strlen((void *)(x.spx[0]));
  return x;
}
#include <sys/random.h>
gforth_stackpointers libgflibc_LTX_gforth_c_getentropy_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=getentropy((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_setenv_ssn_n(GFORTH_ARGS)
{
  ARGN(4,-1);
  x.spx[4]=setenv(gforth_str2c((Char*)x.spx[4],x.spx[3]),gforth_str2c((Char*)x.spx[2],x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_unsetenv_s_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=unsetenv(gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgflibc_LTX_gforth_c_environ__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)(environ);
  x.spx += -1;
  return x;
}
hash_128 gflibcc_hash_libc = "\xF9\x4A\x88\x63\xFE\x36\x5D\x70\xAF\x54\x76\x07\xB7\x1E\xFE\x0A";
