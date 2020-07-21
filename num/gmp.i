// this file is in the public domain
%module gmp
%insert("include")
%{
#include <gmp.h>
%}

#define _GMP_H_HAVE_FILE 1

%include <gmp.h>
