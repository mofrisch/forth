//
//  forth.h
//  Forth
//
//  Created by Moritz Frisch on 19.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//

#ifndef forth_h
#define forth_h

#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <string.h>


#define cell long long
#define STACK_SIZE 256
#define RETURN_STACK_SIZE 128
#define CODE_SIZE 65536
#define SYMBOL_SIZE 256

#define ERROR(MSG) error(MSG,__func__,__FILE__,__LINE__)
#define ARG_ERROR(N) ERROR(N " argument(s) needed")
#define ARGUMENTS_LESS(N) if ( S <= stack+N-2 ) ARG_ERROR(#N);
#endif /* forth_h */
