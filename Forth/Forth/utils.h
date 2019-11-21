//
//  utils.h
//  Forth
//
//  Created by Moritz Frisch on 21.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//

#ifndef utils_h
#define utils_h

#include <stdio.h>

int next_char( void );
int skip_space( void );
void terminate( char *msg );
char *word( void );
char *to_pad(char *str);

#endif /* utils_h */
