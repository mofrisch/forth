#include <libcc.h>
#include <pthread.h>
#include <limits.h>
#include <sys/mman.h>
#include <unistd.h>
#include <setjmp.h>
#include <stdio.h>
#include <signal.h>
#ifndef FIONREAD
#include <sys/socket.h>
#endif

void create_pipe(FILE ** addr)
{
  int epipe[2];
  pipe(epipe);
  addr[0]=fdopen(epipe[0], "r");
  addr[1]=fdopen(epipe[1], "a");
  setvbuf(addr[1], NULL, _IONBF, 0);
}
void *gforth_thread(user_area * t)
{
  Cell x;
  int throw_code;
  void *ip0=(void*)(t->save_task);
  sigset_t set;
  gforth_UP=t;
  gforth_setstacks(t);

  *--gforth_SP=(Cell)t;

  pthread_cleanup_push((void (*)(void*))gforth_free_stacks, (void*)t);
  gforth_sigset(&set, SIGINT, SIGQUIT, SIGTERM, SIGWINCH, 0);
  pthread_sigmask(SIG_BLOCK, &set, NULL);
  x=gforth_go(ip0);
  pthread_cleanup_pop(1);
  pthread_exit((void*)x);
}
static inline void *gforth_thread_p()
{
  return (void*)&gforth_thread;
}
static inline void *pthread_plus(void * thread)
{
  return thread+sizeof(pthread_t);
}
static inline Cell pthreads(Cell thread)
{
  return thread*(int)sizeof(pthread_t);
}
static inline void *pthread_mutex_plus(void * thread)
{
  return thread+sizeof(pthread_mutex_t);
}
static inline Cell pthread_mutexes(Cell thread)
{
  return thread*(int)sizeof(pthread_mutex_t);
}
static inline void *pthread_cond_plus(void * thread)
{
  return thread+sizeof(pthread_cond_t);
}
static inline Cell pthread_conds(Cell thread)
{
  return thread*(int)sizeof(pthread_cond_t);
}
pthread_attr_t * pthread_detach_attr(void)
{
  static pthread_attr_t attr;
  pthread_attr_init(&attr);
  pthread_attr_setdetachstate(&attr, PTHREAD_CREATE_DETACHED);
  return &attr;
}
#include <sys/ioctl.h>
#include <errno.h>
int check_read(FILE * fid)
{
  int pipe = fileno(fid);
  int chars_avail;
  int result = ioctl(pipe, FIONREAD, &chars_avail);
  return (result==-1) ? -errno : chars_avail;
}
#include <poll.h>
int wait_read(FILE * fid, Cell timeoutns, Cell timeouts)
{
  struct pollfd fds = { fileno(fid), POLLIN, 0 };
#if defined(linux) && !defined(__ANDROID__)
  struct timespec tout = { timeouts, timeoutns };
  ppoll(&fds, 1, &tout, 0);
#else
  poll(&fds, 1, timeoutns/1000000+timeouts*1000);
#endif
  return check_read(fid);
}
/* optional: CPU affinity */
#include <sched.h>
int stick_to_core(int core_id) {
#ifdef HAVE_PTHREAD_SETAFFINITY_NP
  cpu_set_t cpuset;

  core_id %= sysconf(_SC_NPROCESSORS_ONLN);
    return EINVAL;
  
  CPU_ZERO(&cpuset);
  CPU_SET(core_id, &cpuset);
  
  return pthread_setaffinity_np(pthread_self(), sizeof(cpu_set_t), &cpuset);
#else
  return 0;
#endif
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_plus_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)pthread_plus((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthreads_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthreads(x.spx[0]);
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_gforth_thread_p__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)gforth_thread_p();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_gforth_stacks_nnnn_a(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=(Cell)gforth_stacks(x.spx[3],x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_create_aaaa_n(GFORTH_ARGS)
{
  ARGN(3,-1);
  x.spx[3]=pthread_create((pthread_t*)(x.spx[3]),(void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_exit_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  pthread_exit((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_kill_an_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=pthread_kill(*(pthread_t*)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cancel_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_cancel(*(pthread_t*)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutex_init_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=pthread_mutex_init((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutex_destroy_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_mutex_destroy((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutex_lock_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_mutex_lock((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutex_unlock_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_mutex_unlock((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutex_plus_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)pthread_mutex_plus((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_mutexes_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_mutexes(x.spx[0]);
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cond_plus_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)pthread_cond_plus((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_conds_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_conds(x.spx[0]);
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_sched_yield__v(GFORTH_ARGS)
{
  ARGN(-1,-1);
  sched_yield();
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_detach_attr__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)pthread_detach_attr();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cond_signal_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_cond_signal((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cond_broadcast_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=pthread_cond_broadcast((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cond_wait_aa_n(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=pthread_cond_wait((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_pthread_cond_timedwait_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=pthread_cond_timedwait((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_create_pipe_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  create_pipe((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_check_read_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=check_read((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_wait_read_ann_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=wait_read((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgfpthread_LTX_gforth_c_stick_to_core_n_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=stick_to_core(x.spx[0]);
  return x;
}
#define get_pthread_id(addr) *(pthread_t*)(addr) = pthread_self()
gforth_stackpointers libgfpthread_LTX_gforth_c_get_pthread_id_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  get_pthread_id((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
hash_128 gflibcc_hash_pthread = "\x9A\x76\xB1\x40\xA0\xF8\x01\x95\xB4\x3C\x39\x57\x8F\x89\x1B\x08";
