/*
  Aarch64 icache flush support using inline assembler

  Authors: Bernd Paysan, Anton Ertl
  Copyright (C) 2014,2015,2017,2019 Free Software Foundation, Inc.

  This file is part of Gforth.

  Gforth is free software; you can redistribute it and/or
  modify it under the terms of the GNU General Public License
  as published by the Free Software Foundation; either version 2
  of the License, or (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111, USA.
*/
#include "config.h"
#include <stddef.h>
#if __APPLE__
# include <libkern/OSCacheControl.h>
#endif

void gforth_cacheflush(void *p, size_t size) 
{
   /* Inspired by Linux kernel sources
    * arch/arm64/mm/proc-macros.S and arch/arm64/mm/cache.S
    * and (more readable) Google V8 sources:
    * https://v8.googlecode.com/svn/branches/bleeding_edge/src/arm64/cpu-arm64.cc
    * see also ARM Architecture Reference Manual ARMv8, B2-73 and D7-1851
    *
    * I only assemble the special instructions, and do the rest in C
    *
    * iOS and GCC builtin version inspired by FFI
    * https://github.com/atgreen/libffi/blob/master/src/aarch64/ffi.c
    */
#if defined (__clang__) && defined (__APPLE__)
  sys_icache_invalidate (p, size);
#elif defined (__GNUC__)
  __builtin___clear_cache (p, p+size);
#else
# define ASM __asm__ __volatile__
  long icachez, dcachez, ctr_el0;
  void *q=p+size, *ps=p;
  ASM( "mrs	%0, ctr_el0\n" : "=r"(ctr_el0) ::); // read CTR_EL0
  dcachez = 4l << ((ctr_el0 >> 16) & 0xF);	// extract data cache line size
  icachez = 4l << (ctr_el0 & 0xF);		// extract icache line size
  do {
    ASM("dc      cvau, %0\n" :: "r"(p) :);      // spill dcache line
  } while((p += dcachez) < q);
  ASM("dsb     ish\n" :::);	// barrier, let dcache operations retire
  p = ps;
  do {
    ASM("ic      ivau, %0\n" :: "r"(p) :);      // invalidate icache line
  } while((p += icachez) < q);
  ASM("dsb     ish\n" :::);	// barrier, let icache operations retire
  ASM("isb\n" :::);                             // instruction barrier
#endif
}
