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
static cell *sp = stack-1;

static XT *dictionary;
static XT *macros;
static XT **definitions;
static XT **ip;

static XT **r_base[RETURN_STACK_SIZE];
static XT ***r_end=r_base+RETURN_STACK_SIZE-1;
static XT ***rp=r_base-1;

static XT *current_xt;
static XT *xt_dup, *xt_drop, *xt_interpreting, *xt_word, *xt_bye, *xt_lit, *xt_leave, *xt_branch, *xt_0branch;

static int is_compile_mode;

static XT *code_base[CODE_SIZE];
static XT **code=code_base;
static XT **code_end=code_base+CODE_SIZE-1;


void print_ok(void) {
    cell *s;
    for(s = stack; s <= sp; s++) {
        printf("%lld ", *s);
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

static void sp_push(cell value) {
    if(sp == stack_end) {
        error("Data stack overflow");
    }
    else {
        *++sp=value;
    }
}

static cell sp_pop(void) {
    if(sp < stack) {
        error("Data stack underrun");
        return 0;
    }
    else {
        return *sp--;
    }
}

static void rp_push(XT **ip) {
    if(rp==r_end) terminate("return stack overflow");
    *++rp=ip;
}
static XT **rp_pop(void) {
    if(rp<r_base) terminate("return stack underrun");
    return *rp--;
}

static XT *find(XT *dict, char *word) {
    for(; dict; dict=dict->next ) {
        if( !strcmp( dict->name, word ) ) {
            return dict;
        }
    }
    return 0;
}

static XT* add_word(char *name, void (*primitive)(void)) {
    XT *_xt = calloc( 1, sizeof( XT ) );
    _xt->next = *definitions;
    *definitions = _xt;
    _xt->name = strdup(name);
    _xt->primitive = primitive;
    _xt->data = code;
    return _xt;
}

static XT *compile(XT *xt) ;
static void interpreting(char *w) ;

static void p_drop( void ) {
    sp_pop();
}

static void p_words( void ) {
    XT *_xt;
    for( _xt = dictionary; _xt; _xt = _xt->next ) {
        printf("%s ", _xt->name);
    }
    printf("\n");
}

static void p_dot(void) {
    printf("%lld \n", sp_pop());
}

static void p_mul(void) {
    cell v1 = sp_pop();
    *sp *= v1;
}

static void p_add(void) {
    cell v1 = sp_pop();
    *sp += v1;
}

static void p_hello_world(void) {
    printf("Hello World\n");
}

static void p_bye() {
    exit(0);
}

static void p_type(void){ // course02
    fputs((void*)sp_pop(), stdout);
}
static void p_cr(void){ // course02, newline
    fputc('\n', stdout);
}

static void p_docol(void) {
    rp_push(ip);
    ip=current_xt->data;
}

static void p_colon(void) {
    char *w=word();
    add_word(strdup(w), p_docol);
    is_compile_mode=1;
}

static void p_semis(void) {
    compile(xt_leave);
    is_compile_mode=0;
}

static void p_leave(void) {
    ip=rp_pop();
}

static void p_lit(void) {
    sp_push((cell)*ip++);
}

static void p_branch(void) {
    ip=(void*)*ip;
}

static void p_0branch(void) {
    if(sp_pop()) ip++;
    else         ip=(void*)*ip;
}

static void p_word(void) {
    sp_push((cell)word());
}

static void p_interpreting(void) {
    interpreting((void*)sp_pop());
}

static void p_dup(void){
    cell t=*sp; sp_push(t);
}

static void register_primitives(void) {
    add_word("+", p_add);
    add_word("*", p_mul);
    add_word("hello", p_hello_world);
    xt_drop = add_word("drop", p_drop);
    xt_dup=add_word("dup", p_dup);
    add_word("words", p_words);
    add_word("type", p_type);
    add_word(".", p_dot);
    add_word("cr", p_cr);
    add_word(":", p_colon);
    xt_bye = add_word("bye", p_bye);
    xt_leave=add_word("leave", p_leave);
    xt_lit=add_word("lit", p_lit);
    xt_0branch=add_word("0branch", p_0branch);
    xt_branch=add_word("branch", p_branch);
    xt_word=add_word("word", p_word);
    xt_interpreting=add_word("interpreting", p_interpreting);
    
    definitions=&macros;
    add_word(";", p_semis);
    definitions=&dictionary;
    
}

static XT *compile(XT *xt) {
    if(code>=code_end) terminate("code space full");
    return *code++=xt;
}

static void literal(cell value) {
    compile(xt_lit);
    *code++=(XT*)value;
}

static void compiling(char *w) {

    if(*w=='"') {
        literal((cell)strdup(w+1));
    } else if((current_xt=find(macros, w))) { // if word is a macro execute it immediatly
        current_xt->primitive();
    } else if((current_xt=find(dictionary, w))) { // if word is in regular dictionary, compile it
        *code++=current_xt;
    } else { // not found, may be a number
        char *end;
        long long number=strtol(w, &end, 0);
        if(*end) terminate("word not found");
        else literal(number); // compile a number literal
    }
}
static void interpreting(char *w) {
    if(is_compile_mode) return compiling(w);

    if(*w=='"') { // +course02: string handling
        sp_push((cell)to_pad(w+1));
    } else if((current_xt=find(dictionary, w))) {
        current_xt->primitive();
    } else { // not found, may be a number
        char *end;
        long number=strtol(w, &end, 0);
        if(*end) terminate("word not found");
        else sp_push(number);
    }
}
static void vm(void) {
    for(;;) {
        current_xt=*ip++;
        current_xt->primitive();
    }
}

int main() {
    register_primitives();

    /* we compile interpreting by hand */
    add_word("shell", p_docol); // define a new high level word
    XT **begin=code;
    compile(xt_word);
    compile(xt_dup);
    compile(xt_0branch); // if top of stack is null
    XT **here=code++; // forward jump reference
    compile(xt_interpreting);
    compile(xt_branch);
    *code++=(void*)begin; // Loop back
    *here=(void*)code; // resolve reference
    *code++=xt_drop;
    *code++=xt_bye; // leave VM

    ip=begin; // set instruction pointer
    vm(); // and run the vm

    return 0;
}

