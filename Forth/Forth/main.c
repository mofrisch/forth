//
//  main.c
//  Forth
//
//  Created by Moritz Frisch on 19.11.19.
//  Copyright © 2019 Moritz Frisch. All rights reserved.
//
//  Based on "Andreas Forth Course" by Andreas Klimas
//


#include "forth.h"
#include "utils.h"

static cell stack[STACK_SIZE];
static cell *stack_end = stack+STACK_SIZE-1;
static cell *sp = stack - 1;

static XT *dict;

void print_ok(void) { // print data stack, than ok>
    cell *s;
    for(s = stack; s <= sp; s++) {
        printf("%ld ", *s);
    }
    printf("ok> ");
}

static void clean_stack() {
    sp = stack-1;
}

static void error( const char *msg) {
    clean_stack();
    printf("error: %s \n", msg);
}

static void push(cell value) {
    if(sp == stack_end) {
        error("Data stack overflow");
    }
    else {
        *++sp=value;
    }
}

static cell pop(void) {
    if(sp < stack) {
        error("Data stack underrun");
        return 0;
    }
    else {
        return *sp--;
    }
}

static XT *find(char *w) {
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

static void p_drop( void ) {
    pop();
}

static void p_words( void ) {
    XT *w;
    for( w = dict; w; w = w->next ) {
        printf("%s ", w->name);
    }
    printf("\n");
}

static void p_dot(void) {
    printf("%ld \n", pop());
}

static void p_mul(void) {
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

static void p_bye() {
    exit(0);
}

static void register_primitives(void) {
    add_word("+", p_add);
    add_word("*", p_mul);
    add_word("hello", p_hello_world);
    add_word("drop", p_drop);
    add_word("words", p_words);
    add_word(".", p_dot);
    add_word("bye", p_bye);
}

static void interpret(char *w) {
    XT * _XT;
    
    if((_XT=find(w))) {
        _XT->primitive();
    }
    else { // not found, may be a number
        char *end;
        long number=strtol(w, &end, 0);
        if(*end) error("word not found");
        else push(number);
    }
}

int main(int argc, const char *argv[]) {
    register_primitives();
    print_ok();
    char *current;
    while(( current = word() )) {
        interpret(current);
    }
    return 0;
}
