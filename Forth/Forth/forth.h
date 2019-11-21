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

void print_ok(void);

typedef struct XT {
    struct XT *next;
    char *name;
    void (*primitive)(void);
} XT;

#endif /* forth_h */
