# generated automatically by aclocal 1.16.1 -*- Autoconf -*-

# Copyright (C) 1996-2018 Free Software Foundation, Inc.

# This file is free software; the Free Software Foundation
# gives unlimited permission to copy and/or distribute it,
# with or without modifications, as long as this notice is preserved.

# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY, to the extent permitted by law; without
# even the implied warranty of MERCHANTABILITY or FITNESS FOR A
# PARTICULAR PURPOSE.

m4_ifndef([AC_CONFIG_MACRO_DIRS], [m4_defun([_AM_CONFIG_MACRO_DIRS], [])m4_defun([AC_CONFIG_MACRO_DIRS], [_AM_CONFIG_MACRO_DIRS($@)])])
# AM_CONDITIONAL                                            -*- Autoconf -*-

# Copyright (C) 1997-2018 Free Software Foundation, Inc.
#
# This file is free software; the Free Software Foundation
# gives unlimited permission to copy and/or distribute it,
# with or without modifications, as long as this notice is preserved.

# AM_CONDITIONAL(NAME, SHELL-CONDITION)
# -------------------------------------
# Define a conditional.
AC_DEFUN([AM_CONDITIONAL],
[AC_PREREQ([2.52])dnl
 m4_if([$1], [TRUE],  [AC_FATAL([$0: invalid condition: $1])],
       [$1], [FALSE], [AC_FATAL([$0: invalid condition: $1])])dnl
AC_SUBST([$1_TRUE])dnl
AC_SUBST([$1_FALSE])dnl
_AM_SUBST_NOTMAKE([$1_TRUE])dnl
_AM_SUBST_NOTMAKE([$1_FALSE])dnl
m4_define([_AM_COND_VALUE_$1], [$2])dnl
if $2; then
  $1_TRUE=
  $1_FALSE='#'
else
  $1_TRUE='#'
  $1_FALSE=
fi
AC_CONFIG_COMMANDS_PRE(
[if test -z "${$1_TRUE}" && test -z "${$1_FALSE}"; then
  AC_MSG_ERROR([[conditional "$1" was never defined.
Usually this means the macro was only invoked conditionally.]])
fi])])

# Copyright (C) 1996-2018 Free Software Foundation, Inc.
#
# This file is free software; the Free Software Foundation
# gives unlimited permission to copy and/or distribute it,
# with or without modifications, as long as this notice is preserved.

# AM_PATH_LISPDIR
# ---------------
AC_DEFUN([AM_PATH_LISPDIR],
[AC_PREREQ([2.60])dnl
 # If set to t, that means we are running in a shell under Emacs.
 # If you have an Emacs named "t", then use the full path.
 test x"$EMACS" = xt && EMACS=
 AC_CHECK_PROGS([EMACS], [emacs xemacs], [no])
 AC_ARG_VAR([EMACS], [the Emacs editor command])
 AC_ARG_VAR([EMACSLOADPATH], [the Emacs library search path])
 AC_ARG_WITH([lispdir],
 [AS_HELP_STRING([--with-lispdir],
                 [override the default lisp directory])],
 [ lispdir="$withval"
   AC_MSG_CHECKING([where .elc files should go])
   AC_MSG_RESULT([$lispdir])],
 [
 AC_CACHE_CHECK([where .elc files should go], [am_cv_lispdir], [
   if test $EMACS != "no"; then
     if test x${lispdir+set} != xset; then
  # If $EMACS isn't GNU Emacs or XEmacs, this can blow up pretty badly
  # Some emacsen will start up in interactive mode, requiring C-x C-c to exit,
  #  which is non-obvious for non-emacs users.
  # Redirecting /dev/null should help a bit; pity we can't detect "broken"
  #  emacsen earlier and avoid running this altogether.
  AC_RUN_LOG([$EMACS -batch -Q -eval '(while load-path (princ (concat (car load-path) "\n")) (setq load-path (cdr load-path)))' </dev/null >conftest.out])
	am_cv_lispdir=`sed -n \
       -e 's,/$,,' \
       -e '/.*\/lib\/x*emacs\/site-lisp$/{s,.*/lib/\(x*emacs/site-lisp\)$,${libdir}/\1,;p;q;}' \
       -e '/.*\/share\/x*emacs\/site-lisp$/{s,.*/share/\(x*emacs/site-lisp\),${datarootdir}/\1,;p;q;}' \
       conftest.out`
       rm conftest.out
     fi
   fi
   test -z "$am_cv_lispdir" && am_cv_lispdir='${datadir}/emacs/site-lisp'
  ])
  lispdir="$am_cv_lispdir"
])
AC_SUBST([lispdir])
])# AM_PATH_LISPDIR

# Copyright (C) 2006-2018 Free Software Foundation, Inc.
#
# This file is free software; the Free Software Foundation
# gives unlimited permission to copy and/or distribute it,
# with or without modifications, as long as this notice is preserved.

# _AM_SUBST_NOTMAKE(VARIABLE)
# ---------------------------
# Prevent Automake from outputting VARIABLE = @VARIABLE@ in Makefile.in.
# This macro is traced by Automake.
AC_DEFUN([_AM_SUBST_NOTMAKE])

# AM_SUBST_NOTMAKE(VARIABLE)
# --------------------------
# Public sister of _AM_SUBST_NOTMAKE.
AC_DEFUN([AM_SUBST_NOTMAKE], [_AM_SUBST_NOTMAKE($@)])

m4_include([m4/ax_gcc_builtin.m4])
m4_include([m4/libtool.m4])
m4_include([m4/ltargz.m4])
m4_include([m4/ltdl.m4])
m4_include([m4/ltoptions.m4])
m4_include([m4/ltsugar.m4])
m4_include([m4/ltversion.m4])
m4_include([m4/lt~obsolete.m4])
