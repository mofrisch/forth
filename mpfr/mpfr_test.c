#include <stdio.h>
#include <assert.h>
#include <gmp.h>
#include <mpfr.h>
int main (void)
{
/* for mpfr_printf, before #include <mpfr.h> */
    mpfr_t x;  int inex;
    mpfr_init2 (x, 53);  /* x: 53-bit precision */
    inex = mpfr_set_ui (x, 10, MPFR_RNDN);     assert (inex == 0);
    inex = mpfr_pow_ui (x, x, 22, MPFR_RNDN);  assert (inex == 0);
    mpfr_sin (x, x, MPFR_RNDN);
    mpfr_printf ("sin(10^22) = %.17Rg\n", x);
    mpfr_clear (x);
    return 0;
}
