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

FILE* src;
static cell stack[STACK_SIZE];
static cell *stack_end = stack+STACK_SIZE-1;
static cell *sp = stack-1;

typedef struct XT {
    struct XT *next;
    char *name;
    void (*primitive)(void);
    struct XT **data;
    int has_literal;
} XT;

static XT *dictionary;
static XT *macros;
static XT **definitions=&dictionary;
static XT **ip;
static XT *latest;

static XT **r_base[RETURN_STACK_SIZE];
static XT ***r_end=r_base+RETURN_STACK_SIZE-1;
static XT ***rp=r_base-1;

static XT *current_xt;
static XT *xt_dup, *xt_drop, *xt_interpreting, *xt_word, *xt_bye, *xt_lit, *xt_leave, *xt_branch, *xt_0branch, *xt_1branch;

static int is_compile_mode;

static XT *code_base[CODE_SIZE];
static XT **code=code_base;
static XT **code_end=code_base+CODE_SIZE-1;

static XT *compile(XT *xt);
static void interpreting(char *w);


static void print_ok(void) {
    cell *s;
    printf("[ ");
    for(s = stack; s <= sp; s++) {
        printf("%lld ", *s);
    }
    printf(is_compile_mode ? "] # " : "] ok> ");
}

void print_banner() {
    printf("moForth v0.0\n");
    print_ok();
}

static int next_char(void) {
    
    static char current, lookahead;
    
    if( (current == '\n') && (src == stdin)) {
        print_ok();
    }
    
    current=fgetc(src);
    
    if(current=='\\' ) {
        lookahead=fgetc(src);
        if(isspace(lookahead)) {
            while(lookahead != '\n') {
                lookahead=fgetc(src);
            }
            current='\n';
        }
    }
    
    if(current=='(' ) {
        lookahead=fgetc(src);
        if(isspace(lookahead)) {
            while(lookahead != ')') {
                lookahead=fgetc(src);
            }
            current=' ';
        }
    }
    
    if( src != stdin && current == EOF) {
        src = stdin;
        current=fgetc(src);
    }
    
    return current;
}

int skip_space(void) {
    int ch;
    while( ( ch=next_char() ) && isspace(ch) );
    return ch;
}



void terminate(char *msg) {
    fprintf(stderr, "terminated: %s\n", msg);
    exit(1);
}

char *word(void) {
    static char buffer[256], *end = buffer+sizeof(buffer)-1;
    char *p=buffer, ch;
    if ( !( ch=skip_space() ) ) return 0;
    
    *p++ = ch;
    
    
    if( ch == '"' ) {
        while( p < end && ( ch = next_char() ) && ch != '"' )
            *p++ = ch;
    }
    else {
        while( p<end && (ch=next_char()) && !isspace(ch))
            *p++=ch;
    }
    *p = 0;
    return buffer;
}

char *to_pad(char *str) {
    static char scratch[1024];
    long len=strlen(str);
    if( len > sizeof(scratch)-1 ) len = sizeof(scratch)-1;
    memcpy(scratch, str, len);
    scratch[len]=0; // zero byte at string end
    return scratch;
}


static void clean_stack() {
    sp = stack-1;
}

static int error( const char *msg, const char * fn, const char* file, int line) {
    clean_stack();
    printf("error: %s in %s (%s:%d)\n", msg, fn, file, line);
    return 1;
}

static void sp_push(cell value) {
    if (sp != stack_end) *++sp=value;
    else ERROR("stack overflow");
}

static cell sp_pop(void) {
    if (sp >= stack) return *sp--;
    else return ERROR("stack underflow");
}

static void rp_push(XT **ip) {
    if( rp == r_end ) {
        terminate("return stack overflow");
    }
    else {
        *++rp=ip;
    }
}

static XT **rp_pop( void ) {
    if( rp < r_base ) {
        terminate("return stack underrun");
        return 0;
    }
    else {
        return *rp--;
    }
}

static XT *find(XT *dict, char *word) {
    for(; dict; dict=dict->next ) {
        if( !strcasecmp( dict->name, word ) ) {
            return dict;
        }
    }
    return 0;
}

static XT* add_word(char *name, void (*primitive)(void)) {
    XT *_xt = calloc(1, sizeof(XT));
    _xt->next = *definitions;
    *definitions = _xt;
    _xt->name = strdup(name);
    _xt->primitive = primitive;
    _xt->data = code;
    return latest = _xt;
}



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
    if (sp >= stack) printf("%lld ", sp_pop());
}

static void p_mul(void) {
    ARGUMENTS_LESS(2) else {
        cell v1 = *sp--;
        *sp *= v1;
    }
}

static void p_add(void) {
    ARGUMENTS_LESS(2) else {
        cell v1 = *sp--;
        *sp += v1;
    }
}

static void p_sub(void) {
    ARGUMENTS_LESS(2) else {
        cell v1 = *sp--;
        *sp -= v1;
    }
}

static void p_div(void) {
    ARGUMENTS_LESS(2) else {
        cell v1 = *sp--;
        *sp /= v1;
    }
}

static void p_equals(void) {
    ARGUMENTS_LESS(2) else {
        cell v1 = *sp--;
        if (v1 == *sp--) *sp-- = -1; else *sp-- = 0;
    }
}

static void p_invert(void) {
    ARGUMENTS_LESS(1) else *sp = -!*sp;
}

static void p_hello_world(void) {
    printf("Hello World\n");
}

static void p_bye() {
    exit(0);
}

static void p_type(void){
    fputs((void*)sp_pop(), stdout);
}
static void p_cr(void){
    fputc('\n', stdout);
}

static void p_docol(void) {
    rp_push(ip);
    ip = current_xt->data;
}

static void p_colon(void) {
    char *w = word();
    add_word(strdup(w), p_docol);
    is_compile_mode = 1;
}

static void p_semis(void) {
    compile(xt_leave);
    is_compile_mode = 0;
}

static void p_leave(void) {
    ip = rp_pop();
}

static void p_lit(void) {
    sp_push( (cell) *ip++);
}

static void p_branch(void) {
    ip= (void*) *ip;
}

static void p_0branch(void) {
    if( sp_pop() ) {
        ip++;
    }
    else {
        ip = (void*) *ip;
    }
}

static void p_1branch(void) {
    if( sp_pop() ) {
        ip = (void*) *ip;
    }
    else {
        ip++;
    }
}

static void p_word(void) {
    sp_push((cell)word());
}

static void p_interpreting(void) {
    interpreting((void*)sp_pop());
}

static void p_dup(void){
    cell t= *sp;
    sp_push(t);
}

static void p_swap(void) {
    ARGUMENTS_LESS(2) else {
        cell t = *sp;
        *sp = sp[-1];
        sp[-1] = t;
    }
}

static void p_if(void) {
    compile(xt_0branch);
    sp_push( (cell) code++);
}

static void p_else(void) {
    XT ***dest = (void*) sp_pop();
    compile(xt_branch);
    sp_push( (cell) code++);
    *dest = code;
}

static void p_then(void) {
    XT ***dest= (void*) sp_pop();
    *dest = code;
}

static void p_begin(void) {
    sp_push( (cell) code);
}

static void p_while(void) {
    compile(xt_1branch);
    *code++ = (void*) sp_pop();
}

static void p_again(void) {
    compile(xt_branch);
    *code++= (void*) sp_pop();
}

static void p_exit(void) {
    ip = rp_pop();
}

static void p_dis(void) {
    XT **ip= (void*) sp_pop();
    for(; (*ip)->primitive!=p_leave;ip++) {
        XT *xt=*ip;
        if(xt->has_literal) {
            printf("%p %s %p\n", ip, xt->name, ip[1]);
            ip++;
        } else {
            printf("%p %s\n", ip, xt->name);
        }
    }
}

static void p_tick(void) {
    char *w=word();
    XT *xt=find(dictionary, w);
    if(xt) sp_push((cell)xt);
    else   ERROR("word not found");
}

static void p_see(void) {
    p_tick();
    XT *xt = (XT*) (*sp);
    *sp = (cell) xt->data;
    p_dis();
}

static void p_execute(void) {
    XT *cur=current_xt;
    current_xt=(void*)sp_pop();
    current_xt->primitive();
    current_xt=cur;
}

static void p_xt_to_name(void) {
    *sp=(cell)((XT*)*sp)->name;
}

static void p_xt_to_data(void) {
    *sp=(cell)((XT*)*sp)->data;
}

static void p_dots(void) {
    cell *s;
    for(s = stack; s <= sp; s++) {
        printf("%lld ", *s);
    }
    printf("\n");
}

static void p_depth(void) {
    sp_push(sp-stack+1);
}

static void p_over(void) {
    ARGUMENTS_LESS(2) else {
        cell t = sp[-1];
        sp_push(t);
    }
}

static void p_pick(void) {
    cell n = sp_pop();
    if ( sp > stack+n-2 ) {
        cell t = sp[-n+1];
        sp_push(t);
    } else ERROR("too few arguments");
}

static void p_rot(void) {
    ARGUMENTS_LESS(3) else {
        cell t = sp[-2];
        sp[-2] = sp[-1];
        sp[-1] = *sp;
        *sp = t;
    }
}

static void p_2swap() {
    ARGUMENTS_LESS(4) else {
        cell t3 = sp[-3];
        cell t2 = sp[-2];
        sp[-3]=sp[-1];
        sp[-2]=*sp;
        sp[-1]=t3;
        *sp=t2;
    }
}

static void p_key() {
    int ch=fgetc(src);
    sp_push((cell) ch);
}

static void p_emit() {
    
}

static void register_primitives(void) {
    add_word("+", p_add);
    add_word("-", p_sub);
    add_word("*", p_mul);
    add_word("/", p_div);
    
    add_word("=", p_equals);
    add_word("invert", p_invert);
    add_word("key", p_key);
    
    xt_drop = add_word("drop", p_drop);
    xt_dup=add_word("dup", p_dup);
    add_word("swap", p_swap);
    add_word(".s", p_dots);
    add_word(".", p_dot);
    add_word("depth", p_depth);
    add_word("over", p_over);
    add_word("pick", p_pick);
    add_word("rot", p_rot);
    add_word("2swap", p_2swap);
    
    add_word("words", p_words);
    add_word("type", p_type);
    
    add_word("cr", p_cr);
    add_word(":", p_colon);
    xt_bye = add_word("bye", p_bye);
    xt_leave=add_word("leave", p_leave);
    
    xt_lit=add_word("lit", p_lit);
    latest->has_literal=1;
    xt_0branch=add_word("0branch", p_0branch);
    latest->has_literal=1;
    xt_1branch=add_word("1branch", p_1branch);
    latest->has_literal=1;
    xt_branch=add_word("branch", p_branch);
    latest->has_literal=1;
    xt_word=add_word("word", p_word);
    xt_interpreting=add_word("interpreting", p_interpreting);
    
    add_word("exit", p_exit);
    add_word("'", p_tick);
    add_word("execute", p_execute);
    add_word("see", p_see);
    add_word("dis", p_dis);
    add_word("xt>data", p_xt_to_data);
    add_word("xt>name", p_xt_to_name);
    add_word("hello", p_hello_world);
    
    definitions=&macros;
    add_word(";", p_semis);
    add_word("if", p_if);
    add_word("then", p_then);
    add_word("else", p_else);
    add_word("begin", p_begin);
    add_word("while", p_while);
    add_word("again", p_again);
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
    if( *w == '"' ) {
        literal( (cell) strdup(w+1) );
    }
    else if(( current_xt = find(macros, w) )) {
        current_xt->primitive();
    }
    else if(( current_xt=find(dictionary, w) )) {
        *code++ = current_xt;
    }
    else {
        char *end;
        long number=strtol(w, &end, 0);
        if ( *end ) {
            ERROR("word not found");
        }
        else {
            literal(number);
        }
    }
}

static void interpreting(char *w) {
    if( is_compile_mode ) {
        return compiling(w);
    }
    if( *w=='"' ) {
        sp_push( (cell) to_pad(w+1));
    }
    else if(( current_xt = find(dictionary, w) )) {
        current_xt->primitive();
    }
    else {
        char *end;
        long number = strtol(w, &end, 0);
        if( *end ) {
            ERROR("word not found");
        }
        else {
            sp_push(number);
        }
    }
}

static void vm(void) {
    for(;;) {
        current_xt = *ip++;
        current_xt->primitive();
    }
}

int main(int argc, char *argv[]) {
    
    register_primitives();
    print_banner();
    if(argc == 2) {
        src = fopen(argv[1], "r");
        if(!src) src = stdin;
    }
    else {
        src = stdin;
    }
    /* we compile interpreting by hand */
    
    add_word("shell", p_docol); // define a new high level word
    XT **begin = code;
    compile(xt_word);
    compile(xt_dup);
    compile(xt_0branch); // if top of stack is null
    XT **here = code++; // forward jump reference
    compile(xt_interpreting);
    compile(xt_branch);
    *code++ = (void*) begin; // Loop back
    *here = (void*) code; // resolve reference
    *code++ = xt_drop;
    *code++ = xt_bye; // leave VM

    ip=begin; // set instruction pointer
    
    vm(); // and run the vm
    fclose(src);
    return 0;
}

