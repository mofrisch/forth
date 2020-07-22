/* a simple sincos implementation

  Authors: Bernd Paysan, Anton Ertl
  Copyright (C) 2012,2017,2019 Free Software Foundation, Inc.

  This file is part of Gforth.

  Gforth is free software; you can redistribute it and/or
  modify it under the terms of the GNU General Public License
  as published by the Free Software Foundation, either version 3
  of the License, or (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, see http://www.gnu.org/licenses/.
*/
#include "config.h"
#include <math.h>

void sincos(double x, double *s, double *c)
{
  *s = sin(x);
  *c = cos(x);
}
