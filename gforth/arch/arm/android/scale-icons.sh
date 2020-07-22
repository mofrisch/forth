#!/bin/bash
#Author: Bernd Paysan
#Copyright (C) 2015,2019 Free Software Foundation, Inc.

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

case $1 in
    -small)
	shift
	for i in $@
	do
	    while read dpi size
	    do
		mkdir -p res/drawable-$dpi
		convert -resize ${size}x${size} $i res/drawable-$dpi/$(basename $i)
	    done <<EOF
mdpi 24
hdpi 36
xhdpi 48
xxhdpi 72
xxxhdpi 96
EOF
	done
	;;
    *)
	for i in $@
	do
	    while read dpi size
	    do
		mkdir -p res/drawable-$dpi
		convert -resize ${size}x${size} $i res/drawable-$dpi/$(basename $i)
	    done <<EOF
ldpi 32
mdpi 48
hdpi 72
xhdpi 96
xxhdpi 144
xxxhdpi 192
EOF
	done
	;;
esac
