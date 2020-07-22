#!/bin/bash

NDK=${NDK-17c}
LIBT=${LIBT-2.4.6}
CPU=$(uname -p)
CCVER=${CCVER-4.9}

function get_ndk {
    if [ ! -d ~/proj/android-ndk-r$NDK ]
    then
	(cd ~/Downloads
	 wget -c http://dl.google.com/android/repository/android-ndk-r$NDK-linux-$CPU.zip
	 mkdir -p ~/proj
	 cd ~/proj
	 unzip ~/Downloads/android-ndk-r$NDK-linux-$CPU.zip)
    fi
}

function get_libtool {
    if [ ! -d ~/proj/libtool-$LIBT ]
    then
	(cd ~/Downloads
	 wget -c http://ftpmirror.gnu.org/libtool/libtool-$LIBT.tar.gz
	 mkdir -p ~/proj
	 cd ~/proj
	 tar zxvf ~/Downloads/libtool-$LIBT.tar.gz)
    fi
}

function set_abix {
    unset ABIX
    unset ARCHX
    ARCH=$i
    ABI=""
    case $i in
	arm)
	    ABI=-linux-androideabi
	    ARCHX=$i
	    ARCHY=$i
	    API=21
	    ;;
	aarch64)
	    ABI=-linux-android
	    ARCH=arm64
	    ARCHX=arm64
	    ARCHY=$i
	    API=21
	    ;;
	mipsel)
	    ARCH=${i%el}
	    ABI=-linux-android
	    ARCHX=${i%el}
	    ARCHY=$i
	    API=19
	    ;;
	mips64el)
	    ARCH=${i%el}
	    ABI=-linux-android
	    ARCHX=${i%el}
	    ARCHY=$i
	    API=21
	    ;;
	x86)
	    ARCHX=$i
	    ABIX=-linux-android
	    ARCHY=i686
	    API=21
	    ;;
	x86_64)
	    ABIX=-linux-android
	    ARCHX=$i
	    ARCHY=$i
	    API=21
	    ;;
    esac
    ABIX=${ABIX-$ABI}
}

function gen_toolchain {
    for i in arm aarch64 x86 x86_64 #mipsel mips64el
    do
	set_abix
	mkdir -p ~/proj/android-toolchain-$ARCH
	(cd ~/proj/android-toolchain-$ARCH
	 ~/proj/android-ndk-r$NDK/build/tools/make_standalone_toolchain.py --arch $ARCHX --api $API --install-dir $PWD --force)
	cp stddef.h ~/proj/android-toolchain-$ARCH/include/c++/4.9.x/*-linux-android*/
    done
}

function gen_libtool {
    for i in arm aarch64 x86 x86_64 #mipsel mips64el
    do
	set_abix
	PREFIX=$HOME/proj/android-toolchain-$ARCH
	(cd ~/proj/libtool-$LIBT
	 ./configure --host=$ARCHY$ABIX --program-prefix=$ARCHY$ABIX- --prefix=$PREFIX --includedir=$PREFIX/sysroot/usr/include --libdir=$PREFIX/sysroot/usr/lib host_alias=$ARCHY$ABIX build_alias=$CPU-linux-gnu
	 make && make install && make clean
	)
    done
}

function gen_libs {
    for i in arm arm64 386 amd64 #mips
    do
	(cd ../../$i/android
	 ./genlibs.sh)
    done
}

function add_path {
    cat <<EOF
Add the following line to your .bashrc:
PATH=\$PATH:\$(echo ~/proj/android-toolchain-{arm,arm64,x86,x86_64}/bin | tr ' ' ':')
EOF
}

if [ "$1" = "" ]
then
    get_ndk
    get_libtool
    gen_toolchain
    gen_libtool
    gen_libs
    add_path
else
    while [ "$1" != "" ]
    do
	eval $1
	shift
    done
fi
