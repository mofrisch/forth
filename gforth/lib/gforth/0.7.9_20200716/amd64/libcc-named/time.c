#include <libcc.h>
#include <time.h>
gforth_stackpointers libgftime_LTX_gforth_c_localtime_r_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)localtime_r((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgftime_LTX_gforth_c_tzset__v(GFORTH_ARGS)
{
  ARGN(-1,-1);
  tzset();
  return x;
}
gforth_stackpointers libgftime_LTX_gforth_c_tzname__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)(tzname);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgftime_LTX_gforth_c_timezone__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(timezone);
  x.spx += -1;
  return x;
}
gforth_stackpointers libgftime_LTX_gforth_c_daylight__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(daylight);
  x.spx += -1;
  return x;
}
hash_128 gflibcc_hash_time = "\xB4\xE7\x47\xC8\x27\x27\x43\xAA\xEE\x69\x09\x31\x4C\x34\x3C\x4E";
