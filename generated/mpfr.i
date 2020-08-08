// generated/mpfr.i
// SWIG interface for MPFR

// Author : Moritz Frisch
// Copyright(C) 2020 Free Software Foundation, Inc.

// this file is in the public domain

%module mpfr
%insert("include")
%{
#include <mpfr.h>
%} 



%apply SWIGTYPE * { mpz_srcptr, mpz_ptr, mpq_srcptr, mpq_ptr };
%apply SWIGTYPE * { gmp_randstate_t };
%apply __mpfr_struct * { mpfr_ptr, mpfr_srcptr };
%apply long { mpfr_prec_t } ;
%apply int { size_t };
#define MPFR_USE_FILE 1
#define MPFR_USE_NO_MACRO 1

%include <mpfr.h>
