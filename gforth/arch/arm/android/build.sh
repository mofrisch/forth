#!/bin/bash
#Authors: Bernd Paysan, Anton Ertl
#Copyright (C) 2011,2012,2013,2014,2015,2016,2017,2018,2019 Free Software Foundation, Inc.

#This file is part of Gforth.

#Gforth is free software; you can redistribute it and/or
#modify it under the terms of the GNU General Public License
#as published by the Free Software Foundation, either version 3
#of the License, or (at your option) any later version.

#This program is distributed in the hope that it will be useful,
#but WITHOUT ANY WARRANTY; without even the implied warranty of
#MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.#See the
#GNU General Public License for more details.

#You should have received a copy of the GNU General Public License
#along with this program. If not, see http://www.gnu.org/licenses/.

nprocs=`nproc || echo 1`

function extra_apps {
    for i in $EXTRADIRS
    do
	test -f $i/AndroidManifest/apps && . $i/AndroidManifest/apps
    done
}

function extra_perms {
    for i in $EXTRADIRS
    do
	test -f $i/AndroidManifest/perms && cat $i/AndroidManifest/perms
    done
}

function extra_features {
    for i in $EXTRADIRS
    do
	test -f $i/AndroidManifest/app && cat $i/AndroidManifest/features
    done
}

. build.local
export PKG_CONFIG_PATH
TOOLCHAIN=$(which $TARGET-gcc | sed -e s,/bin/.*-gcc,,g)
NDK=${NDK-~/proj/android-ndk-r10e}
SRC=$(cd ../../..; pwd)

while [ "${1%%[^\+]*}" == '+' ]
do
    arch+=" ${1#+}"
    shift
done

if [ ! -z "$arch" ]
then
    (cd $SRC; ./autogen.sh) >autogen.log
    echo "Extra builds in$arch"
    APP_PACKAGE=gnu.gforth
else
    APP_PACKAGE=gnu.gforth_$machine
fi

APP_VERSION=$[$(cat ~/.app-version)+1]
for i in $arch
do
    (cd $SRC/arch/$i/android && ./build.sh "$@" || printf "\e[31mFailed to build for $i\e[0m\n")
done
echo $APP_VERSION >~/.app-version

# Create log file from here on

exec 3>&1 1>build.log 2>&1

if [ ! -f local.properties ]
then
    android update project -p . -s --target android-28
fi

#eval $(grep ^sdk.dir= local.properties| sed -e 's/^sdk.dir=/sdk_dir=/g')
#
#mkdir -p libs
#ln -fs ${sdk_dir}/extras/android/support/v7/appcompat/libs/android-support-v4.jar libs

# takes as extra argument a directory where to look for .so-s

ENGINES="gforth-fast gforth-itc"

GFORTH_VERSION=$($GFORTH_DITC --version 2>&1 | cut -f2 -d' ')

LIBCCNAMED=lib/gforth/current/$machine/libcc-named/.libs

if [ ! -f $SRC/configure ]
then
    (cd $SRC; ./autogen.sh)
fi

rm -rf $LIBS
mkdir -p $LIBS

if [ ! -f $TOOLCHAIN/sysroot/usr/lib/libsoil2.a ]
then
    cp $TOOLCHAIN/sysroot/usr/lib/libsoil.so $LIBS
fi
cp .libs/libtypeset.so $LIBS
cp $TOOLCHAIN/sysroot/usr/lib/libopus.so $LIBS
cp $(find $TOOLCHAIN/$TARGET -name libc++_shared.so) $LIBS

EXTRAS=""
EXTRADIRS=""
for i in $@
do
    EXTRAS+=" -with-extras=$i"
    EXTRADIRS+=" $i"
done

. ./AndroidManifest.xml.in >AndroidManifest.xml

if [ "$1" != "--no-gforthgz" ]
then
    mkdir -p build/debian/sdcard/gforth/$machine/gforth/site-forth
    (cd build
	if [ "$1" != "--no-config" ]
	then
	    echo -n "$machine: configure" 1>&3
	    $SRC/configure --host=$TARGET --with-cross=android --with-ditc=$GFORTH_DITC --prefix= --datarootdir=/sdcard --libdir=/sdcard/gforth/$machine --libexecdir=/lib --includedir=$PWD/include --enable-lib --disable-version $EXTRAS || exit 1
	fi
	echo -n " make" 1>&3
	make -j$nprocs || exit 1
	make prefix=$TOOLCHAIN/sysroot/usr install-include
	rm -rf debian/sdcard
	echo -n " extras" 1>&3
	if [ "$1" != "--no-config" ]; then make extras || exit 1; fi
	echo -n " debdist" 1>&3
	mkdir -p debian/sdcard/gforth/current/doc
	cp doc/gforth.txt debian/sdcard/gforth/current/doc
	make setup-debdist || exit 1) || exit 1
    if [ "$1" == "--no-config" ]
    then
	CONFIG=no; shift
    fi
    
    mkdir -p res/raw
    cp *.{fs,fi,png,jpg} build/debian/sdcard/gforth/$machine/gforth/site-forth
    (cd build/debian/sdcard
     mkdir -p gforth/home gforth/site-forth gforth/current/minos2/fonts
     cp /usr/share/fonts/truetype/emoji/fa-merged-900.ttf gforth/current/minos2/fonts
     gforth archive.fs gforth/home/ gforth/site-forth/ $(find gforth/current -type f) $(find gforth/site-forth -type f)) | gzip -9 >res/raw/gforth
    (cd build/debian/sdcard
     rm gforth/$machine/lib*
     rm -rf gforth/$machine/gforth/current/$machine/libcc-named
     gforth archive.fs $machine/gforth/site-forth/ $(find gforth/$machine/gforth -type f)) | gzip -9 >$LIBS/libgforth-${machine}gz.so
else
    shift
fi

SHA256=$(sha256sum res/raw/gforth | cut -f1 -d' ')
SHA256ARCH=$(sha256sum $LIBS/libgforth-${machine}gz.so | cut -f1 -d' ')

for i in $ENGINES
do
    sed -e "s/sha256sum-sha256sum-sha256sum-sha256sum-sha256sum-sha256sum-sha2/$SHA256/" -e "s/sha256archsum-sha256archsum-sha256archsum-sha256archsum-sha256ar/$SHA256ARCH/" build/engine/.libs/lib$i.so >$LIBS/lib$i.so
done

FULLLIBS=$PWD/$LIBS
LIBCC=build
for i in $LIBCC $*
do
    (cd $i; test -d shlibs && cp shlibs/*/.libs/*.so $FULLLIBS)
    for j in $LIBCCNAMED .libs
    do
	for k in $(cd $i/$j; echo *.so)
	do
	    cp $i/$j/$k $LIBS
	done
    done
    shift
done

for i in $LIBS/*.so
do
    echo "strip $i: $(stat --print=%s $i) -> $($TARGET-strip $i && stat --print=%s $i)"
done

#copy resources

for i in $EXTRADIRS
do
    test -d $i/res && (cd $i/res; tar cf - .) | (cd res; tar xf -)
    test -d $i/src && (cd $i/src; tar cf - .) | (cd src; tar xf -)
done

echo -n " gradle " 1>&3

#ant build
#ant debug
#ant release
#cp bin/Gforth-release.apk bin/Gforth.apk
#cp bin/Gforth-release.apk bin/Gforth-$(date +%Y%m%d).apk

#gradle build – get gradlew and put the script right here
./gradlew build
./gradlew bundle
cp build/outputs/apk/release/gnu.gforth-release.apk bin/Gforth.apk
cp build/outputs/apk/release/gnu.gforth-release.apk bin/Gforth-$(date +%Y%m%d).apk

printf '\e[32msuccess!\e[0m\n' 1>&3
