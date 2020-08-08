.( MPFR Library)

\ fr.fs
\ Library for Floting Point numbers with arbitrary precision

\ Author: Moritz Frisch
\ Copyright (C) 2020 Free Software Foundation, Inc.

\ #region License
\ This program is free software; you can redistribute it and/or modify it
\ under the terms of the GNU General Public License as published by the
\ Free Software Foundation; either version 3, or (at your option) any
\ later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http: //www.gnu.org/licenses/.
\ #endregion

\ #region Definitions
require tools.fs

vocabulary mpfr
get-current also mpfr definitions
require generated/mpfr.fs
previous definitions also mpfr

false value fr-total-inits
false value fr-print-inits

[ifundef] fr-inits   variable fr-inits   variable fr-clears  [then]     
0 fr-inits !   0 fr-clears !
\ #endregion

: fr. ( fr --  ) \ print fr number
    >r 0 10 0 r> MPFR_RNDN ~~ __gmpfr_out_str ;



__mpfr_struct allocate throw dup 53 mpfr_init2 ~~ \ /* x: 53-bit precision */
dup 10 MPFR_RNDN mpfr_set_ui drop ~~ fr.
\ dup 22 MPFR_RNDN ~~ mpfr_pow_ui
\    mpfr_sin (x, x, MPFR_RNDN);
\    mpfr_printf ("sin(10^22) = %.17Rg\n", x);
\    mpfr_clear (x);
\    return 0;
