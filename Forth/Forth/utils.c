//
//  utils.c
//  Forth
//
//  Created by Moritz Frisch on 21.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//

#include "utils.h"
#include "forth.h"

int next_char(void) {
    static int last_char;
    if( last_char == '\n' ) print_ok(); // ok> prompt
    last_char = fgetc( stdin );
    return last_char == EOF ? 0 : last_char;
}

int skip_space(void) {
    int ch;
    while( ( ch=next_char() ) && isspace( ch ) );
    return ch;
}

void terminate(char *msg) {
    fprintf(stderr, "terminated: %s\n", msg);
    exit(1);
}

char *word(void) {
    static char buffer[256], *end = buffer + sizeof(buffer) - 1;
    char *p=buffer, ch;
    if(!(ch=skip_space())) return 0;
    *p ++ = ch;
    while(p<end && (ch=next_char()) && !isspace(ch)) *p++=ch;
    *p=0;
    return buffer;
}
