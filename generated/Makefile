# Generic makefile, for crosscompiling use make -f Makefile.<target>

#Authors: Bernd Paysan, Anton Ertl
#Copyright (C) 2014,2015,2016,2017,2018,2019 Free Software Foundation, Inc.

#This file is part of Gforth.

#Gforth is free software; you can redistribute it and/or
#modify it under the terms of the GNU General Public License
#as published by the Free Software Foundation, either version 3
#of the License, or (at your option) any later version.

#This program is distributed in the hope that it will be useful,
#but WITHOUT ANY WARRANTY; without even the implied warranty of
#MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#GNU General Public License for more details.

#You should have received a copy of the GNU General Public License
#along with this program. If not, see http://www.gnu.org/licenses/.

INCLUDES   = -I/usr/local/Cellar/gcc/10.2.0/lib/gcc/10/gcc/x86_64-apple-darwin20/10.2.0/include-fixed -I/usr/local/include -I/Applications/Xcode-beta.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/MacOSX.sdk/usr/include
SWIG       = /usr/local/bin/swig
TARGETS    =  gmp.fs sdl2.fs mpfr.fs
WRAPPERS   = $(patsubst %.fs, %.fsx, $(TARGETS))
GENWRAPPERS   = $(patsubst %.fs, %-fsi.c, $(TARGETS))
LIBRARY    =  gmp.fs sdl2.fs mpfr.fs
HOST_OS    = $(subst -,_,darwin)
OPTIONS    = -forth -cpperraswarn -Dhost_os_$(HOST_OS) -no-sectioncomments -use-structs -stackcomments $(subst -F,-I, $(INCLUDES))
INSTALL	= /usr/bin/install -c
ARCH=
VERSION	= "`gforth --version 2>&1 | cut -f2 -d' '`"
SHELL	= /bin/sh
RMTREE	= rm -rf
prefix = 
exec_prefix = ${prefix}
libexecdir = $(package)${exec_prefix}/lib
libccdir = $(subst $(DESTDIR),,$(libexecdir)/gforth$(ARCH)/$(VERSION)/libcc-named/)
VPATH = .
srcdir = .
top_srcdir = ..
top_builddir = ..
DESTDIR = $(PWD)
LIBTOOL = $(SHELL) $(top_builddir)/libtool
GCC	= gcc
HOSTCC	= $(GCC)
CC	= $(HOSTCC) $(INCLUDES) -I.

all: $(GENWRAPPERS) $(TARGETS)

wrappers: $(WRAPPERS)

build-libcc-named: $(LIBRARY) $(TARGETS)
		$(RMTREE) lib/gforth$(ARCH)/$(VERSION)/libcc-named/
		-for i in $(LIBRARY); do echo $$i:; (cd ..; ./libforth -e "also c-lib s\" `pwd`/lib/gforth$(ARCH)/$(VERSION)/libcc-named/\" >libcc-named-dir libcc-path clear-path libcc-named-dir libcc-path also-path :noname 2drop s\" $(DESTDIR)$(libccdir)\" ; is replace-rpath previous" $(srcdir)/$$i -e bye); done

libs: build-libcc-named $(LIBRARY)
	for i in $(LIBRARY); do \
	    $(LIBTOOL) --silent --mode=install $(INSTALL) lib/gforth$(ARCH)/$(VERSION)/libcc-named/libgf`basename $$i .fs`.la $(DESTDIR)$(libccdir)libgf`basename $$i .fs`.la; \
	done

# execute compiled file
%.fs: %-fsi.c
	$(CC) -o $@x $<
	./$@x -gforth | $(srcdir)/doexec $@ $(srcdir) > $@

# compile fsi-file
#%.fsx: %-fsi.c
#	$(CC) -o $@ $<

# use swig to create the fsi file
%-fsi.c: $(srcdir)/%.i
	$(SWIG) $(OPTIONS) -o $@+ $(srcdir)/$(patsubst %-fsi.c,%.i,$@)
	$(srcdir)/doprep $@+ $(srcdir) > $@

run: $(DEMO)
	gforth $(DEMO)

.PHONY: clean

clean:
	rm -f $(TARGETS) stat.fs
	rm -f $(GENWRAPPERS)
	rm -f $(WRAPPERS) stat.fsx

