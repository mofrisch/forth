//
//  main.c
//  Forth
//
//  Created by Moritz Frisch on 19.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//  Based on "Andreas Forth Course" by Andreas Klimas
//


#include "forth.h"

static cell stack[STACK_SIZE];
cell *stack_end=stack+STACK_SIZE;
static cell *sp=stack-1;

typedef struct XT {
    struct XT *next;
    char *name;
    void (*primitive)(void);
} XT;

static XT *dict;

void print_ok(void) { // print data stack, than ok>
    cell *s;
    for(s=stack;s<=sp;s++) printf("%ld ", *s);
    printf("ok> ");
}

int next_char(void) {
    static int last_char;
    if(last_char=='\n') print_ok(); // ok> prompt
    last_char=fgetc(stdin);
    return last_char==EOF?0:last_char;
}

int skip_space(void) {
    int ch;
    while((ch=next_char()) && isspace(ch));
    return ch;
}

void terminate(char *msg) {
    fprintf(stderr, "terminated: %s\n", msg);
    exit(1);
}

char *word(void) {
    static char buffer[256], *end=buffer+sizeof(buffer)-1;
    char *p=buffer, ch;
    if(!(ch=skip_space())) return 0;
    *p++=ch;
    while(p<end && (ch=next_char()) && !isspace(ch)) *p++=ch;
    *p=0;
    return buffer;
}



void push(cell value) {
    if(sp==stack_end) terminate("Data stack overflow");
    *++sp=value;
}
cell pop(void) {
    if(sp<stack) terminate("Data stack underrun");
    return *sp--;
}



XT *find(char *w) {
    XT *xt;
    
    for( xt=dict; xt; xt=xt->next ) {
        if( !strcmp( xt->name, w ) ) {
            return xt;
        }
    }

    return 0;
}

void add_word(char *name, void (*primitive)(void)) {
    XT *xt = calloc( 1, sizeof( XT ) );
    xt->next = dict;
    dict = xt;
    xt->name = strdup(name);
    xt->primitive = primitive;
}

void p_drop(void) {pop();}


 void p_words(void) {
    XT *w;
    for(w=dict;w;w=w->next) printf("%s ", w->name);
    printf("\n");
}

void p_dot(void) {
    printf("%ld ", pop());
}

void p_mul(void) {
    cell v1 = pop();
    *sp *= v1;
}

static void p_add(void) {
    cell v1 = pop();
    *sp += v1;
}

static void p_hello_world(void) {
    printf("Hello World\n");
}

void register_primitives(void) {
    add_word("+", p_add);
    add_word("*", p_mul);
    add_word("hello", p_hello_world);
    add_word("drop", p_drop);
    add_word("words", p_words);
    add_word(".", p_dot);
}



void interpret(char *w) {
    XT * _XT;
    
    if((_XT=find(w))) {
        _XT->primitive();
    }
    else { // not found, may be a number
        char *end;
        long number=strtol(w, &end, 0);
        if(*end) terminate("word not found");
        else push(number);
    }
}

int main(int argc, const char * argv[]) {
    
    register_primitives();

    char *current;
    while(( current = word() )) {
        interpret(current);
    }
    
    return 0;
}
