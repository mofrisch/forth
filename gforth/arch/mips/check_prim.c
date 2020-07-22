/* Check primitive agains non-relocatable MIPS instruction blacklist

  Authors: David Kühling, Anton Ertl, Bernd Paysan
  Copyright (C) 2010,2017,2019 Free Software Foundation, Inc.

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
/* return non-zero if given primitive is non-relocatable (or has other
 * problems when used in dynamic superinstructions) */
int check_prim(char *start, int len)
{
   typedef unsigned instruction;

   static struct instcmp_t {
      instruction mask;
      instruction value;
   } blacklist[] = {
      { 0xFC000000, 0x08000000}, /* J */
      { 0xFC000000, 0x0C000000}, /* JAL */
      /* HI/LO register reads must be separated from writes by two instruction
	 slots.  We can blacklist either only writes or only reads.
	 Blacklisting only MFLO, MFHI is sufficient and the shortest
	 solution. */
      { 0xFFFF07FF, 0x00000010}, /* MFHI */
      { 0xFFFF07FF, 0x00000012}  /* MFLO */
   };
   int n = sizeof(blacklist) / sizeof(struct instcmp_t);
   const instruction *inst = (const instruction*)start;

   for (; len >= 0; len -= sizeof(instruction), inst++)
   {
      int i;
      for (i = 0; i < n; i++)
      {
	 if ((*inst&blacklist[i].mask) == blacklist[i].value)
	    return 1;
      }
   }

   return 0;
}
