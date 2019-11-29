//
//  forth.c
//  Forth
//
//  Created by Moritz Frisch on 29.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//

#include <stdio.h>
#include <ctype.h>

const int WORD_LENGTH=32;

char key(){
    return getchar();
}

// return the first non whitespace character or else 0

char skip_space(){
    char c=key();
    while(isspace(c)){
        c=key();
    }
    return c;
}


// get the next word, return 0 if only whitespace EOF is left
// \-comments are stripped, (-comments will be handled as forth words

char *word() {
    static char buffer[WORD_LENGTH];
    char *end = buffer+sizeof(buffer)-1;
    char *p=buffer;
    
    char c=skip_space();
    
    if(c==EOF) return 0;
    
    // skip comments starting with \ till end of line
    // unless \ is followed by non whitespace
    if(c=='\\') {
        c=key();
        if(isspace(c)){
            while(c!='\n') c=key();
        }
        else {
            *p++='\\';
        }
    }
    
    while(!isspace(c) && p<end) {
        *p++=c;
        c=key();
    }
    
    *p=0;
    return buffer;
}

// get a word, try to find it in the dictionary, else conmvert it
// to a number, else fail

int interpret(){
    char *w = word();
    if(!w) return 0;
    printf("%s\n",w);
    return 1;
}

// "quit" is an odd name to start the program, but it's tradition

void quit(){
    // reset everything
    while(interpret());
}

int main(int argc, char *argv[]) {
    printf("Hi!\n");
    quit();
}

