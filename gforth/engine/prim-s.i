LABEL(paren_docol) /* (docol) ( -- R:a_retaddr ) S0 -- S0  */
/* run-time routine for colon definitions */
NAME("(docol)")
{
DEF_CA
Cell * a_retaddr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
rp += -1;
{
#ifdef DEBUG
    {
      CFA_TO_NAME(CFA);
      debugp(stderr,"%08lx: call %08lx %.*s\n",(Cell)ip,(Cell)CFA,
	     len,name);
    }
#endif
a_retaddr = (Cell *)IP;
SET_IP((Xt *)PFA(CFA));
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_retaddr=", vm_out); printarg_a_(a_retaddr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_retaddr,rp[0]);
LABEL2(paren_docol)
NAME1("l2-paren_docol")
NEXT_P1_5;
LABEL3(paren_docol)
NAME1("l3-paren_docol")
DO_GOTO;
}

LABEL(paren_docon) /* (docon) ( -- w ) S0 -- S0  */
/* run-time routine for constants */
NAME("(docon)")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = *(Cell *)PFA(CFA);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(paren_docon)
NAME1("l2-paren_docon")
NEXT_P1_5;
LABEL3(paren_docon)
NAME1("l3-paren_docon")
DO_GOTO;
}

LABEL(paren_dovar) /* (dovar) ( -- a_body ) S0 -- S0  */
/* run-time routine for variables and CREATEd words */
NAME("(dovar)")
{
DEF_CA
Cell * a_body;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
a_body = PFA(CFA);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_body=", vm_out); printarg_a_(a_body);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_body,sp[0]);
LABEL2(paren_dovar)
NAME1("l2-paren_dovar")
NEXT_P1_5;
LABEL3(paren_dovar)
NAME1("l3-paren_dovar")
DO_GOTO;
}

LABEL(paren_douser) /* (douser) ( -- a_user ) S0 -- S0  */
/* run-time routine for constants */
NAME("(douser)")
{
DEF_CA
Cell * a_user;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
a_user = (Cell *)(((Address)up)+*(Cell *)PFA(CFA));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_user=", vm_out); printarg_a_(a_user);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_user,sp[0]);
LABEL2(paren_douser)
NAME1("l2-paren_douser")
NEXT_P1_5;
LABEL3(paren_douser)
NAME1("l3-paren_douser")
DO_GOTO;
}

LABEL(paren_dodefer) /* (dodefer) ( -- ) S0 -- S0  */
/* run-time routine for deferred words */
NAME("(dodefer)")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
ip=IP; /* undo any ip updating that may have been performed by NEXT_P0 */
SUPER_END; /* !! probably unnecessary and may lead to measurement errors */
VM_JUMP(EXEC1(*(Xt *)PFA(CFA)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(paren_dodefer)
LABEL3(paren_dodefer)
DO_GOTO;
}

LABEL(paren_field) /* (dofield) ( n1 -- n2 ) S0 -- S0  */
/* run-time routine for fields */
NAME("(dofield)")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 + *(Cell *)PFA(CFA);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(paren_field)
NAME1("l2-paren_field")
NEXT_P1_5;
LABEL3(paren_field)
NAME1("l3-paren_field")
DO_GOTO;
}

LABEL(paren_doval) /* (dovalue) ( -- w ) S0 -- S0  */
/* run-time routine for constants */
NAME("(dovalue)")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = *(Cell *)PFA(CFA);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(paren_doval)
NAME1("l2-paren_doval")
NEXT_P1_5;
LABEL3(paren_doval)
NAME1("l3-paren_doval")
DO_GOTO;
}

LABEL(paren_dodoes) /* (dodoes) ( -- a_body ) S0 -- S0  */
/*  */
NAME("(dodoes)")
{
DEF_CA
Cell * a_body;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
a_body = PFA(CFA);
ip=IP; /* undo any ip updating that may have been performed by NEXT_P0 */
SUPER_END; /* !! probably unnecessary and may lead to measurement errors */
VM_JUMP(EXEC1(EXTRA_CODEXT(CFA)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_body=", vm_out); printarg_a_(a_body);
fputc('\n', vm_out);
}
#endif
vm_a_2Cell(a_body,sp[0]);
LABEL2(paren_dodoes)
LABEL3(paren_dodoes)
DO_GOTO;
}

LABEL(paren_doabicode) /* (doabicode) ( ... -- ...) S0 -- S0  */
/* run-time routine for @code{ABI-code} definitions */
NAME("(doabicode)")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
abifunc *f = (abifunc *)PFA(CFA);
Float *fp_mem = fp;
sp = (*f)(sp, &fp_mem);
fp = fp_mem;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(paren_doabicode)
NAME1("l2-paren_doabicode")
NEXT_P1_5;
LABEL3(paren_doabicode)
NAME1("l3-paren_doabicode")
DO_GOTO;
}

LABEL(paren_do_semicolon_abi_code) /* (do;abicode) ( ... -- ... ) S0 -- S0  */
/* run-time routine for @code{;abi-code}-defined words */
NAME("(do;abicode)")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
Float *fp_mem = fp;
Address body = (Address)PFA(CFA);
semiabifunc *f = (semiabifunc *)EXTRA_CODE(CFA);
sp = (*f)(sp, &fp_mem, body);
fp = fp_mem;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(paren_do_semicolon_abi_code)
NAME1("l2-paren_do_semicolon_abi_code")
NEXT_P1_5;
LABEL3(paren_do_semicolon_abi_code)
NAME1("l3-paren_do_semicolon_abi_code")
DO_GOTO;
}

GROUPADD(10)
GROUP( control, 10)
LABEL(noop) /* noop ( -- ) S0 -- S0  */
/*  */
NAME("noop")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(noop)
NAME1("l2-noop")
NEXT_P1_5;
LABEL3(noop)
NAME1("l3-noop")
DO_GOTO;
}

LABEL(call) /* call ( #a_callee -- R:a_retaddr ) S0 -- S0  */
/* Call callee (a variant of docol with inline argument). */
NAME("call")
{
DEF_CA
MAYBE_UNUSED Cell * a_callee;
Cell * a_retaddr;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397760 ),a_callee);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_callee=", vm_out); printarg_a_(a_callee);
}
#endif
INC_IP(1);
rp += -1;
{
#ifdef DEBUG
    {
      CFA_TO_NAME((((Cell *)a_callee)-2));
      debugp(stderr,"%08lx: call %08lx %.*s\n",(Cell)ip,(Cell)a_callee,
	     len,name);
    }
#endif
a_retaddr = (Cell *)IP;
SET_IP((Xt *)a_callee);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_retaddr=", vm_out); printarg_a_(a_retaddr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_retaddr,rp[0]);
LABEL2(call)
NAME1("l2-call")
NEXT_P1_5;
LABEL3(call)
NAME1("l3-call")
DO_GOTO;
}

LABEL(execute) /* execute ( xt -- ) S0 -- S0  */
/* Perform the semantics represented by the execution token, @i{xt}. */
NAME("execute")
{
DEF_CA
MAYBE_UNUSED Xt xt;
NEXT_P0;
vm_Cell2xt(sp[0],xt);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" xt=", vm_out); printarg_xt(xt);
}
#endif
sp += 1;
{
#ifdef DEBUG
debugp(stderr, "execute %08x\n", xt);
#endif
ip=IP;
SUPER_END;
VM_JUMP(EXEC1(xt));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(execute)
LABEL3(execute)
DO_GOTO;
}

LABEL(perform) /* perform ( a_addr -- ) S0 -- S0  */
/* @code{@@ execute}. */
NAME("perform")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
/* and pfe */
ip=IP;
SUPER_END;
VM_JUMP(EXEC1(*(Xt *)a_addr));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(perform)
LABEL3(perform)
DO_GOTO;
}

LABEL(semis) /* ;s ( R:w -- ) S0 -- S0  */
/* The primitive compiled by @code{EXIT}. */
NAME(";s")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(rp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
rp += 1;
{
SET_IP((Xt *)w);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(semis)
NAME1("l2-semis")
NEXT_P1_5;
LABEL3(semis)
NAME1("l3-semis")
DO_GOTO;
}

LABEL(execute_semis) /* execute-;s ( xt R:w -- ) S0 -- S0  */
/* The primitive compiled by @code{EXECUTE-EXIT}. */
NAME("execute-;s")
{
DEF_CA
MAYBE_UNUSED Xt xt;
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2xt(sp[0],xt);
vm_Cell2w(rp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" xt=", vm_out); printarg_xt(xt);
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
rp += 1;
{
#ifdef DEBUG
debugp(stderr, "execute-;s %08x\n", xt);
#endif
SET_IP((Xt *)w);
SUPER_END;
VM_JUMP(EXEC1(xt));
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(execute_semis)
LABEL3(execute_semis)
DO_GOTO;
}

LABEL(unloop) /* unloop ( R:w1 R:w2 -- ) S0 -- S0  */
/*  */
NAME("unloop")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[1],w1);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
rp += 2;
{
/* !! alias for 2rdrop */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(unloop)
NAME1("l2-unloop")
NEXT_P1_5;
LABEL3(unloop)
NAME1("l3-unloop")
DO_GOTO;
}

LABEL(lit_perform) /* lit-perform ( #a_addr -- ) S0 -- S0  */
/*  */
NAME("lit-perform")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397761 ),a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
INC_IP(1);
{
ip=IP;
SUPER_END;
VM_JUMP(EXEC1(*(Xt *)a_addr));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(lit_perform)
LABEL3(lit_perform)
DO_GOTO;
}

LABEL(extra_xt) /* does-xt ( #a_cfa -- a_body ) S0 -- S0  */
/*  */
NAME("does-xt")
{
DEF_CA
MAYBE_UNUSED Cell * a_cfa;
Cell * a_body;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397762 ),a_cfa);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_cfa=", vm_out); printarg_a_(a_cfa);
}
#endif
INC_IP(1);
sp += -1;
{
a_body = PFA(a_cfa);
#ifdef DEBUG
    {
      CFA_TO_NAME(a_cfa);
      debugp(stderr,"%08lx: does %08lx %.*s exec %p\n",
	     (Cell)ip,(Cell)a_cfa,len,name,EXTRA_CODE(a_cfa));
    }
#endif
SUPER_END;
VM_JUMP(EXEC1(EXTRA_CODEXT(a_cfa)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_body=", vm_out); printarg_a_(a_body);
fputc('\n', vm_out);
}
#endif
vm_a_2Cell(a_body,sp[0]);
LABEL2(extra_xt)
LABEL3(extra_xt)
DO_GOTO;
}

GROUPADD(9)
#ifdef HAS_GLOCALS
LABEL(branch_lp_plus_store_number) /* branch-lp+!# ( #a_target #nlocals -- ) S0 -- S0  */
/*  */
NAME("branch-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397763 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397764 ),nlocals);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
}
#endif
INC_IP(2);
{
/* this will probably not be used */
lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(branch_lp_plus_store_number)
NAME1("l2-branch_lp_plus_store_number")
NEXT_P1_5;
LABEL3(branch_lp_plus_store_number)
NAME1("l3-branch_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
LABEL(branch) /* branch ( #a_target -- ) S0 -- S0  */
/*  */
NAME("branch")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397765 ),a_target);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
}
#endif
INC_IP(1);
{
SET_IP((Xt *)a_target);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(branch)
NAME1("l2-branch")
NEXT_P1_5;
LABEL3(branch)
NAME1("l3-branch")
DO_GOTO;
}

LABEL(question_branch) /* ?branch ( #a_target f -- ) S0 -- S0  */
/*  */
NAME("?branch")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Bool f;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397766 ),a_target);
vm_Cell2f(sp[0],f);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" f=", vm_out); printarg_f(f);
}
#endif
INC_IP(1);
sp += 1;
{
 if (f==0) {
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(question_branch)
NAME1("l2-question_branch")
NEXT_P1_5;
LABEL3(question_branch)
NAME1("l3-question_branch")
DO_GOTO;
}

GROUPADD(2)
#ifdef HAS_GLOCALS
LABEL(question_branch_lp_plus_store_number) /* ?branch-lp+!# ( #a_target #nlocals f -- ) S0 -- S0  */
/*  */
NAME("?branch-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Bool f;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397767 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397768 ),nlocals);
vm_Cell2f(sp[0],f);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" f=", vm_out); printarg_f(f);
}
#endif
INC_IP(2);
sp += 1;
{
	if (f==0) {
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(question_branch_lp_plus_store_number)
NAME1("l2-question_branch_lp_plus_store_number")
NEXT_P1_5;
LABEL3(question_branch_lp_plus_store_number)
NAME1("l3-question_branch_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
LABEL(question_dupe_question_branch) /* ?dup-?branch ( #a_target f -- S:... ) S0 -- S0  */
/* The run-time procedure compiled by @code{?DUP-IF}. */
NAME("?dup-?branch")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Bool f;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397769 ),a_target);
vm_Cell2f(sp[0],f);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" f=", vm_out); printarg_f(f);
}
#endif
INC_IP(1);
sp += 1;
{
if (f==0) {
  SET_IP((Xt *)a_target);
} else {
  sp--;
  sp[0]=f;
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(question_dupe_question_branch)
NAME1("l2-question_dupe_question_branch")
NEXT_P1_5;
LABEL3(question_dupe_question_branch)
NAME1("l3-question_dupe_question_branch")
DO_GOTO;
}

LABEL(question_dupe_zero_equals_question_branch) /* ?dup-0=-?branch ( #a_target f -- S:... ) S0 -- S0  */
/* The run-time procedure compiled by @code{?DUP-0=-IF}. */
NAME("?dup-0=-?branch")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Bool f;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397770 ),a_target);
vm_Cell2f(sp[0],f);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" f=", vm_out); printarg_f(f);
}
#endif
INC_IP(1);
sp += 1;
{
if (f!=0) {
  sp--;
  sp[0]=f;
  SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(question_dupe_zero_equals_question_branch)
NAME1("l2-question_dupe_zero_equals_question_branch")
NEXT_P1_5;
LABEL3(question_dupe_zero_equals_question_branch)
NAME1("l3-question_dupe_zero_equals_question_branch")
DO_GOTO;
}

GROUPADD(2)
#endif
LABEL(paren_next) /* (next) ( #a_target R:n1 -- R:n2 ) S0 -- S0  */
/*  */
NAME("(next)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397771 ),a_target);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(1);
{
n2=n1-1;
 if (n1) {
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_next)
NAME1("l2-paren_next")
NEXT_P1_5;
LABEL3(paren_next)
NAME1("l3-paren_next")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_next_lp_plus_store_number) /* (next)-lp+!# ( #a_target #nlocals R:n1 -- R:n2 ) S0 -- S0  */
/*  */
NAME("(next)-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397772 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397773 ),nlocals);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
{
n2=n1-1;
	if (n1) {
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_next_lp_plus_store_number)
NAME1("l2-paren_next_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_next_lp_plus_store_number)
NAME1("l3-paren_next_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
LABEL(paren_loop) /* (loop) ( #a_target R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(loop)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397774 ),a_target);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(1);
{
n2=n1+1;
 if (n2 != nlimit) {
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_loop)
NAME1("l2-paren_loop")
NEXT_P1_5;
LABEL3(paren_loop)
NAME1("l3-paren_loop")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_loop_lp_plus_store_number) /* (loop)-lp+!# ( #a_target #nlocals R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(loop)-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397775 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397776 ),nlocals);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
{
n2=n1+1;
	if (n2 != nlimit) {
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_loop_lp_plus_store_number)
NAME1("l2-paren_loop_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_loop_lp_plus_store_number)
NAME1("l3-paren_loop_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
LABEL(paren_plus_loop) /* (+loop) ( #a_target n R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(+loop)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397777 ),a_target);
vm_Cell2n(sp[0],n);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" n=", vm_out); printarg_n(n);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(1);
sp += 1;
{
/* !! check this thoroughly */
/* sign bit manipulation and test: (x^y)<0 is equivalent to (x<0) != (y<0) */
/* dependent upon two's complement arithmetic */
Cell olddiff = n1-nlimit;
n2=n1+n;	
 if (((olddiff^(olddiff+n))    /* the limit is not crossed */
     &(olddiff^n))	       /* OR it is a wrap-around effect */
    >=0) { /* & is used to avoid having two branches for gforth-native */
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_plus_loop)
NAME1("l2-paren_plus_loop")
NEXT_P1_5;
LABEL3(paren_plus_loop)
NAME1("l3-paren_plus_loop")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_plus_loop_lp_plus_store_number) /* (+loop)-lp+!# ( #a_target #nlocals n R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(+loop)-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397778 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397779 ),nlocals);
vm_Cell2n(sp[0],n);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" n=", vm_out); printarg_n(n);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
sp += 1;
{
/* !! check this thoroughly */
/* sign bit manipulation and test: (x^y)<0 is equivalent to (x<0) != (y<0) */
/* dependent upon two's complement arithmetic */
Cell olddiff = n1-nlimit;
n2=n1+n;	
	if (((olddiff^(olddiff+n))    /* the limit is not crossed */
     &(olddiff^n))	       /* OR it is a wrap-around effect */
    >=0) { /* & is used to avoid having two branches for gforth-native */
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_plus_loop_lp_plus_store_number)
NAME1("l2-paren_plus_loop_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_plus_loop_lp_plus_store_number)
NAME1("l3-paren_plus_loop_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
LABEL(paren_minus_loop) /* (-loop) ( #a_target u R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(-loop)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397780 ),a_target);
vm_Cell2u(sp[0],u);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" u=", vm_out); printarg_u(u);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(1);
sp += 1;
{
UCell olddiff = n1-nlimit;
n2=n1-u;
 if (olddiff>u) {
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_minus_loop)
NAME1("l2-paren_minus_loop")
NEXT_P1_5;
LABEL3(paren_minus_loop)
NAME1("l3-paren_minus_loop")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_minus_loop_lp_plus_store_number) /* (-loop)-lp+!# ( #a_target #nlocals u R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(-loop)-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397781 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397782 ),nlocals);
vm_Cell2u(sp[0],u);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" u=", vm_out); printarg_u(u);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
sp += 1;
{
UCell olddiff = n1-nlimit;
n2=n1-u;
	if (olddiff>u) {
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_minus_loop_lp_plus_store_number)
NAME1("l2-paren_minus_loop_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_minus_loop_lp_plus_store_number)
NAME1("l3-paren_minus_loop_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
LABEL(paren_slash_loop) /* (/loop)# ( #u #a_target R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(/loop)#")
{
DEF_CA
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2u(IMM_ARG(IPTOS,305397783 ),u);
vm_Cell2a_(IMM_ARG(IP[1],305397784 ),a_target);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
{
n2=n1+u;
 if (n2-nlimit>=u) {
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_slash_loop)
NAME1("l2-paren_slash_loop")
NEXT_P1_5;
LABEL3(paren_slash_loop)
NAME1("l3-paren_slash_loop")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_slash_loop_lp_plus_store_number) /* (/loop)#-lp+!# ( #u #a_target #nlocals R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/*  */
NAME("(/loop)#-lp+!#")
{
DEF_CA
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2u(IMM_ARG(IPTOS,305397785 ),u);
vm_Cell2a_(IMM_ARG(IP[1],305397786 ),a_target);
vm_Cell2n(IMM_ARG(IP[2],305397787 ),nlocals);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(3);
{
n2=n1+u;
	if (n2-nlimit>=u) {
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_slash_loop_lp_plus_store_number)
NAME1("l2-paren_slash_loop_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_slash_loop_lp_plus_store_number)
NAME1("l3-paren_slash_loop_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
LABEL(paren_symmetric_plus_loop) /* (s+loop) ( #a_target n R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/* The run-time procedure compiled by S+LOOP. It loops until the index
crosses the boundary between limit and limit-sign(n). I.e. a symmetric
version of (+LOOP). */
NAME("(s+loop)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397788 ),a_target);
vm_Cell2n(sp[0],n);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" n=", vm_out); printarg_n(n);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(1);
sp += 1;
{
/* !! check this thoroughly */
Cell diff = n1-nlimit;
Cell newdiff = diff+n;
if (n<0) {
    diff = -diff;
    newdiff = -newdiff;
}
n2=n1+n;
 if (((~diff)|newdiff)<0) { /* use | to avoid two branches for gforth-native */
 SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_symmetric_plus_loop)
NAME1("l2-paren_symmetric_plus_loop")
NEXT_P1_5;
LABEL3(paren_symmetric_plus_loop)
NAME1("l3-paren_symmetric_plus_loop")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_GLOCALS
LABEL(paren_symmetric_plus_loop_lp_plus_store_number) /* (s+loop)-lp+!# ( #a_target #nlocals n R:nlimit R:n1 -- R:nlimit R:n2 ) S0 -- S0  */
/* The run-time procedure compiled by S+LOOP. It loops until the index
crosses the boundary between limit and limit-sign(n). I.e. a symmetric
version of (+LOOP). */
NAME("(s+loop)-lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlocals;
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397789 ),a_target);
vm_Cell2n(IMM_ARG(IP[1],305397790 ),nlocals);
vm_Cell2n(sp[0],n);
vm_Cell2n(rp[1],nlimit);
vm_Cell2n(rp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlocals=", vm_out); printarg_n(nlocals);
fputs(" n=", vm_out); printarg_n(n);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
INC_IP(2);
sp += 1;
{
/* !! check this thoroughly */
Cell diff = n1-nlimit;
Cell newdiff = diff+n;
if (n<0) {
    diff = -diff;
    newdiff = -newdiff;
}
n2=n1+n;
	if (((~diff)|newdiff)<0) { /* use | to avoid two branches for gforth-native */
	lp += nlocals;
ALIVE_DEBUGGING(lp[-1]);
SET_IP((Xt *)a_target);
/* 0=0 */
}
/* 0=0 */
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,rp[0]);
LABEL2(paren_symmetric_plus_loop_lp_plus_store_number)
NAME1("l2-paren_symmetric_plus_loop_lp_plus_store_number")
NEXT_P1_5;
LABEL3(paren_symmetric_plus_loop_lp_plus_store_number)
NAME1("l3-paren_symmetric_plus_loop_lp_plus_store_number")
DO_GOTO;
}

GROUPADD(1)
#endif
GROUPADD(0)
#endif
LABEL(paren_for) /* (for) ( ncount -- R:nlimit R:ncount ) S0 -- S0  */
/*  */
NAME("(for)")
{
DEF_CA
MAYBE_UNUSED Cell ncount;
Cell nlimit;
NEXT_P0;
vm_Cell2n(sp[0],ncount);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ncount=", vm_out); printarg_n(ncount);
}
#endif
sp += 1;
rp += -2;
{
/* or (for) = >r -- collides with unloop! */
nlimit=0;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nlimit,rp[1]);
vm_n2Cell(ncount,rp[0]);
LABEL2(paren_for)
NAME1("l2-paren_for")
NEXT_P1_5;
LABEL3(paren_for)
NAME1("l3-paren_for")
DO_GOTO;
}

LABEL(paren_do) /* (do) ( nlimit nstart -- R:nlimit R:nstart ) S0 -- S0  */
/*  */
NAME("(do)")
{
DEF_CA
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell nstart;
NEXT_P0;
vm_Cell2n(sp[1],nlimit);
vm_Cell2n(sp[0],nstart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" nstart=", vm_out); printarg_n(nstart);
}
#endif
sp += 2;
rp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nlimit,rp[1]);
vm_n2Cell(nstart,rp[0]);
LABEL2(paren_do)
NAME1("l2-paren_do")
NEXT_P1_5;
LABEL3(paren_do)
NAME1("l3-paren_do")
DO_GOTO;
}

LABEL(paren_question_do) /* (?do) ( #a_target nlimit nstart -- R:nlimit R:nstart ) S0 -- S0  */
/*  */
NAME("(?do)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell nstart;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397791 ),a_target);
vm_Cell2n(sp[1],nlimit);
vm_Cell2n(sp[0],nstart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" nstart=", vm_out); printarg_n(nstart);
}
#endif
INC_IP(1);
sp += 2;
rp += -2;
{
if (nstart == nlimit) {
    SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nlimit,rp[1]);
vm_n2Cell(nstart,rp[0]);
LABEL2(paren_question_do)
NAME1("l2-paren_question_do")
NEXT_P1_5;
LABEL3(paren_question_do)
NAME1("l3-paren_question_do")
DO_GOTO;
}

GROUPADD(3)
#ifdef HAS_XCONDS
LABEL(paren_plus_do) /* (+do) ( #a_target nlimit nstart -- R:nlimit R:nstart ) S0 -- S0  */
/*  */
NAME("(+do)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell nstart;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397792 ),a_target);
vm_Cell2n(sp[1],nlimit);
vm_Cell2n(sp[0],nstart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" nstart=", vm_out); printarg_n(nstart);
}
#endif
INC_IP(1);
sp += 2;
rp += -2;
{
if (nstart >= nlimit) {
  SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nlimit,rp[1]);
vm_n2Cell(nstart,rp[0]);
LABEL2(paren_plus_do)
NAME1("l2-paren_plus_do")
NEXT_P1_5;
LABEL3(paren_plus_do)
NAME1("l3-paren_plus_do")
DO_GOTO;
}

LABEL(paren_u_plus_do) /* (u+do) ( #a_target ulimit ustart -- R:ulimit R:ustart ) S0 -- S0  */
/*  */
NAME("(u+do)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED UCell ulimit;
MAYBE_UNUSED UCell ustart;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397793 ),a_target);
vm_Cell2u(sp[1],ulimit);
vm_Cell2u(sp[0],ustart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" ulimit=", vm_out); printarg_u(ulimit);
fputs(" ustart=", vm_out); printarg_u(ustart);
}
#endif
INC_IP(1);
sp += 2;
rp += -2;
{
if (ustart >= ulimit) {
  SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(ulimit,rp[1]);
vm_u2Cell(ustart,rp[0]);
LABEL2(paren_u_plus_do)
NAME1("l2-paren_u_plus_do")
NEXT_P1_5;
LABEL3(paren_u_plus_do)
NAME1("l3-paren_u_plus_do")
DO_GOTO;
}

LABEL(paren_minus_do) /* (-do) ( #a_target nlimit nstart -- R:nlimit R:nstart ) S0 -- S0  */
/*  */
NAME("(-do)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED Cell nlimit;
MAYBE_UNUSED Cell nstart;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397794 ),a_target);
vm_Cell2n(sp[1],nlimit);
vm_Cell2n(sp[0],nstart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" nlimit=", vm_out); printarg_n(nlimit);
fputs(" nstart=", vm_out); printarg_n(nstart);
}
#endif
INC_IP(1);
sp += 2;
rp += -2;
{
if (nstart <= nlimit) {
SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nlimit,rp[1]);
vm_n2Cell(nstart,rp[0]);
LABEL2(paren_minus_do)
NAME1("l2-paren_minus_do")
NEXT_P1_5;
LABEL3(paren_minus_do)
NAME1("l3-paren_minus_do")
DO_GOTO;
}

LABEL(paren_u_minus_do) /* (u-do) ( #a_target ulimit ustart -- R:ulimit R:ustart ) S0 -- S0  */
/*  */
NAME("(u-do)")
{
DEF_CA
MAYBE_UNUSED Cell * a_target;
MAYBE_UNUSED UCell ulimit;
MAYBE_UNUSED UCell ustart;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397795 ),a_target);
vm_Cell2u(sp[1],ulimit);
vm_Cell2u(sp[0],ustart);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_target=", vm_out); printarg_a_(a_target);
fputs(" ulimit=", vm_out); printarg_u(ulimit);
fputs(" ustart=", vm_out); printarg_u(ustart);
}
#endif
INC_IP(1);
sp += 2;
rp += -2;
{
if (ustart <= ulimit) {
SET_IP((Xt *)a_target);
}
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(ulimit,rp[1]);
vm_u2Cell(ustart,rp[0]);
LABEL2(paren_u_minus_do)
NAME1("l2-paren_u_minus_do")
NEXT_P1_5;
LABEL3(paren_u_minus_do)
NAME1("l3-paren_u_minus_do")
DO_GOTO;
}

LABEL(paren_try) /* (try) ( ... #a_recovery -- R:a_recovery R:a_sp R:c_op R:f_fp R:c_lp R:a_oldhandler ) S0 -- S0  */
/*  */
NAME("(try)")
{
DEF_CA
MAYBE_UNUSED Cell * a_recovery;
Cell * a_sp;
Char * c_op;
Float * f_fp;
Char * c_lp;
Cell * a_oldhandler;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397796 ),a_recovery);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_recovery=", vm_out); printarg_a_(a_recovery);
}
#endif
INC_IP(1);
{
a_oldhandler = SPs->handler;
a_sp = sp;
c_op = op;
f_fp = fp;
c_lp = lp;
SPs->handler = rp-6;
SPs->first_throw = ~0;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_sp=", vm_out); printarg_a_(a_sp);
fputs(" c_op=", vm_out); printarg_c_(c_op);
fputs(" f_fp=", vm_out); printarg_f_(f_fp);
fputs(" c_lp=", vm_out); printarg_c_(c_lp);
fputs(" a_oldhandler=", vm_out); printarg_a_(a_oldhandler);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
rp += -6;
vm_a_2Cell(a_recovery,rp[5]);
vm_a_2Cell(a_sp,rp[4]);
vm_c_2Cell(c_op,rp[3]);
vm_f_2Cell(f_fp,rp[2]);
vm_c_2Cell(c_lp,rp[1]);
vm_a_2Cell(a_oldhandler,rp[0]);
LABEL2(paren_try)
NAME1("l2-paren_try")
NEXT_P1_5;
LABEL3(paren_try)
NAME1("l3-paren_try")
DO_GOTO;
}

LABEL(uncatch) /* uncatch ( R:a_recovery R:a_sp R:c_op R:f_fp R:c_lp R:a_oldhandler -- ) S0 -- S0  */
/*  */
NAME("uncatch")
{
DEF_CA
MAYBE_UNUSED Cell * a_recovery;
MAYBE_UNUSED Cell * a_sp;
MAYBE_UNUSED Char * c_op;
MAYBE_UNUSED Float * f_fp;
MAYBE_UNUSED Char * c_lp;
MAYBE_UNUSED Cell * a_oldhandler;
NEXT_P0;
vm_Cell2a_(rp[5],a_recovery);
vm_Cell2a_(rp[4],a_sp);
vm_Cell2c_(rp[3],c_op);
vm_Cell2f_(rp[2],f_fp);
vm_Cell2c_(rp[1],c_lp);
vm_Cell2a_(rp[0],a_oldhandler);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_recovery=", vm_out); printarg_a_(a_recovery);
fputs(" a_sp=", vm_out); printarg_a_(a_sp);
fputs(" c_op=", vm_out); printarg_c_(c_op);
fputs(" f_fp=", vm_out); printarg_f_(f_fp);
fputs(" c_lp=", vm_out); printarg_c_(c_lp);
fputs(" a_oldhandler=", vm_out); printarg_a_(a_oldhandler);
}
#endif
rp += 6;
{
SPs->handler = a_oldhandler;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(uncatch)
NAME1("l2-uncatch")
NEXT_P1_5;
LABEL3(uncatch)
NAME1("l3-uncatch")
DO_GOTO;
}

LABEL(fast_throw) /* fast-throw ( ... wball -- ... wball ) S0 -- S0  */
/* Lightweight @code{throw} variant: only for non-zero balls, and
does not store a backtrace or deal with missing @code{catch}. */
NAME("fast-throw")
{
DEF_CA
MAYBE_UNUSED Cell wball;
NEXT_P0;
vm_Cell2w(sp[0],wball);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wball=", vm_out); printarg_w(wball);
}
#endif
sp += 1;
{
rp = SPs->handler;
lp = (Address)rp[1];
fp = (Float *)rp[2];
op = (Char *)rp[3];
sp = (Cell *)rp[4];
SET_IP((Xt *)rp[5]);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
sp += -1;
vm_w2Cell(wball,sp[0]);
LABEL2(fast_throw)
NAME1("l2-fast_throw")
NEXT_P1_5;
LABEL3(fast_throw)
NAME1("l3-fast_throw")
DO_GOTO;
}

LABEL(pushwrap) /* pushwrap ( ... #a_recovery -- R:a_recovery R:a_sp R:c_op R:f_fp R:c_lp R:a_oldhandler ) S0 -- S0  */
/*  */
NAME("pushwrap")
{
DEF_CA
MAYBE_UNUSED Cell * a_recovery;
Cell * a_sp;
Char * c_op;
Float * f_fp;
Char * c_lp;
Cell * a_oldhandler;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397797 ),a_recovery);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_recovery=", vm_out); printarg_a_(a_recovery);
}
#endif
INC_IP(1);
{
a_oldhandler = SPs->wraphandler;
a_sp = sp;
c_op = op;
f_fp = fp;
c_lp = lp;
SPs->wraphandler = rp;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_sp=", vm_out); printarg_a_(a_sp);
fputs(" c_op=", vm_out); printarg_c_(c_op);
fputs(" f_fp=", vm_out); printarg_f_(f_fp);
fputs(" c_lp=", vm_out); printarg_c_(c_lp);
fputs(" a_oldhandler=", vm_out); printarg_a_(a_oldhandler);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
rp += -6;
vm_a_2Cell(a_recovery,rp[5]);
vm_a_2Cell(a_sp,rp[4]);
vm_c_2Cell(c_op,rp[3]);
vm_f_2Cell(f_fp,rp[2]);
vm_c_2Cell(c_lp,rp[1]);
vm_a_2Cell(a_oldhandler,rp[0]);
LABEL2(pushwrap)
NAME1("l2-pushwrap")
NEXT_P1_5;
LABEL3(pushwrap)
NAME1("l3-pushwrap")
DO_GOTO;
}

LABEL(dropwrap) /* dropwrap ( R:a_recovery R:a_sp R:c_op R:f_fp R:c_lp R:a_oldhandler -- ) S0 -- S0  */
/*  */
NAME("dropwrap")
{
DEF_CA
MAYBE_UNUSED Cell * a_recovery;
MAYBE_UNUSED Cell * a_sp;
MAYBE_UNUSED Char * c_op;
MAYBE_UNUSED Float * f_fp;
MAYBE_UNUSED Char * c_lp;
MAYBE_UNUSED Cell * a_oldhandler;
NEXT_P0;
vm_Cell2a_(rp[5],a_recovery);
vm_Cell2a_(rp[4],a_sp);
vm_Cell2c_(rp[3],c_op);
vm_Cell2f_(rp[2],f_fp);
vm_Cell2c_(rp[1],c_lp);
vm_Cell2a_(rp[0],a_oldhandler);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_recovery=", vm_out); printarg_a_(a_recovery);
fputs(" a_sp=", vm_out); printarg_a_(a_sp);
fputs(" c_op=", vm_out); printarg_c_(c_op);
fputs(" f_fp=", vm_out); printarg_f_(f_fp);
fputs(" c_lp=", vm_out); printarg_c_(c_lp);
fputs(" a_oldhandler=", vm_out); printarg_a_(a_oldhandler);
}
#endif
rp += 6;
{
SPs->wraphandler = a_oldhandler;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(dropwrap)
NAME1("l2-dropwrap")
NEXT_P1_5;
LABEL3(dropwrap)
NAME1("l3-dropwrap")
DO_GOTO;
}

LABEL(exit_wrap) /* exit-wrap ( ... -- ... ) S0 -- S0  */
/*  */
NAME("exit-wrap")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
rp = SPs->wraphandler;
SPs->wraphandler = (Cell *)rp[-6];
lp = (Address)rp[-5];
fp = (Float *)rp[-4];
op = (Char *)rp[-3];
sp = (Cell *)rp[-2];
SET_IP((Xt *)rp[-1]);
}
SUPER_END;

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(exit_wrap)
NAME1("l2-exit_wrap")
NEXT_P1_5;
LABEL3(exit_wrap)
NAME1("l3-exit_wrap")
DO_GOTO;
}

GROUPADD(10)
#endif
LABEL(i) /* i ( R:n -- R:n n ) S0 -- S0  */
/*  */
NAME("i")
{
DEF_CA
MAYBE_UNUSED Cell n;
NEXT_P0;
vm_Cell2n(rp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(i)
NAME1("l2-i")
NEXT_P1_5;
LABEL3(i)
NAME1("l3-i")
DO_GOTO;
}

LABEL(i_tick) /* i' ( R:w R:w2 -- R:w R:w2 w ) S0 -- S0  */
/*  */
NAME("i'")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[1],w);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(i_tick)
NAME1("l2-i_tick")
NEXT_P1_5;
LABEL3(i_tick)
NAME1("l3-i_tick")
DO_GOTO;
}

LABEL(j) /* j ( R:w R:w1 R:w2 -- w R:w R:w1 R:w2 ) S0 -- S0  */
/*  */
NAME("j")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[2],w);
vm_Cell2w(rp[1],w1);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(j)
NAME1("l2-j")
NEXT_P1_5;
LABEL3(j)
NAME1("l3-j")
DO_GOTO;
}

LABEL(k) /* k ( R:w R:w1 R:w2 R:w3 R:w4 -- w R:w R:w1 R:w2 R:w3 R:w4 ) S0 -- S0  */
/*  */
NAME("k")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(rp[4],w);
vm_Cell2w(rp[3],w1);
vm_Cell2w(rp[2],w2);
vm_Cell2w(rp[1],w3);
vm_Cell2w(rp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(k)
NAME1("l2-k")
NEXT_P1_5;
LABEL3(k)
NAME1("l3-k")
DO_GOTO;
}

GROUPADD(4)
GROUP( strings, 54)
LABEL(move) /* move ( c_from c_to ucount -- ) S0 -- S0  */
/* Copy the contents of @i{ucount} aus at @i{c-from} to
@i{c-to}. @code{move} works correctly even if the two areas overlap. */
NAME("move")
{
DEF_CA
MAYBE_UNUSED Char * c_from;
MAYBE_UNUSED Char * c_to;
MAYBE_UNUSED UCell ucount;
NEXT_P0;
vm_Cell2c_(sp[2],c_from);
vm_Cell2c_(sp[1],c_to);
vm_Cell2u(sp[0],ucount);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_from=", vm_out); printarg_c_(c_from);
fputs(" c_to=", vm_out); printarg_c_(c_to);
fputs(" ucount=", vm_out); printarg_u(ucount);
}
#endif
sp += 3;
{
/* !! note that the standard specifies addr, not c-addr */
memmove(c_to,c_from,ucount);
/* make an Ifdef for bsd and others? */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(move)
NAME1("l2-move")
NEXT_P1_5;
LABEL3(move)
NAME1("l3-move")
DO_GOTO;
}

LABEL(c_move) /* cmove ( c_from c_to u -- ) S0 -- S0  */
/* Copy the contents of @i{ucount} characters from data space at
@i{c-from} to @i{c-to}. The copy proceeds @code{char}-by-@code{char}
from low address to high address; i.e., for overlapping areas it is
safe if @i{c-to}<=@i{c-from}. */
NAME("cmove")
{
DEF_CA
MAYBE_UNUSED Char * c_from;
MAYBE_UNUSED Char * c_to;
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2c_(sp[2],c_from);
vm_Cell2c_(sp[1],c_to);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_from=", vm_out); printarg_c_(c_from);
fputs(" c_to=", vm_out); printarg_c_(c_to);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 3;
{
cmove(c_from,c_to,u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(c_move)
NAME1("l2-c_move")
NEXT_P1_5;
LABEL3(c_move)
NAME1("l3-c_move")
DO_GOTO;
}

LABEL(c_move_up) /* cmove> ( c_from c_to u -- ) S0 -- S0  */
/* Copy the contents of @i{ucount} characters from data space at
@i{c-from} to @i{c-to}. The copy proceeds @code{char}-by-@code{char}
from high address to low address; i.e., for overlapping areas it is
safe if @i{c-to}>=@i{c-from}. */
NAME("cmove>")
{
DEF_CA
MAYBE_UNUSED Char * c_from;
MAYBE_UNUSED Char * c_to;
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2c_(sp[2],c_from);
vm_Cell2c_(sp[1],c_to);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_from=", vm_out); printarg_c_(c_from);
fputs(" c_to=", vm_out); printarg_c_(c_to);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 3;
{
cmove_up(c_from,c_to,u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(c_move_up)
NAME1("l2-c_move_up")
NEXT_P1_5;
LABEL3(c_move_up)
NAME1("l3-c_move_up")
DO_GOTO;
}

LABEL(fill) /* fill ( c_addr u c -- ) S0 -- S0  */
/* Store @i{c} in @i{u} chars starting at @i{c-addr}. */
NAME("fill")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Char c;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2c(sp[0],c);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" c=", vm_out); printarg_c(c);
}
#endif
sp += 3;
{
memset(c_addr,c,u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(fill)
NAME1("l2-fill")
NEXT_P1_5;
LABEL3(fill)
NAME1("l3-fill")
DO_GOTO;
}

LABEL(compare) /* compare ( c_addr1 u1 c_addr2 u2 -- n ) S0 -- S0  */
/* Compare two strings lexicographically. If they are equal, @i{n} is 0; if
the first string is smaller, @i{n} is -1; if the first string is larger, @i{n}
is 1. Currently this is based on the machine's character
comparison. In the future, this may change to consider the current
locale and its collation order. */
NAME("compare")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char * c_addr2;
MAYBE_UNUSED UCell u2;
Cell n;
NEXT_P0;
vm_Cell2c_(sp[3],c_addr1);
vm_Cell2u(sp[2],u1);
vm_Cell2c_(sp[1],c_addr2);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 3;
{
/* close ' to keep fontify happy */ 
n = compare(c_addr1, u1, c_addr2, u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(compare)
NAME1("l2-compare")
NEXT_P1_5;
LABEL3(compare)
NAME1("l3-compare")
DO_GOTO;
}

LABEL(toupper) /* toupper ( c1 -- c2 ) S0 -- S0  */
/* If @i{c1} is a lower-case character (in the current locale), @i{c2}
is the equivalent upper-case character. All other characters are unchanged. */
NAME("toupper")
{
DEF_CA
MAYBE_UNUSED Char c1;
Char c2;
NEXT_P0;
vm_Cell2c(sp[0],c1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c1=", vm_out); printarg_c(c1);
}
#endif
{
c2 = toupper(c1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c2=", vm_out); printarg_c(c2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c2Cell(c2,sp[0]);
LABEL2(toupper)
NAME1("l2-toupper")
NEXT_P1_5;
LABEL3(toupper)
NAME1("l3-toupper")
DO_GOTO;
}

LABEL(capscompare) /* capscompare ( c_addr1 u1 c_addr2 u2 -- n ) S0 -- S0  */
/* Compare two strings lexicographically. If they are equal, @i{n} is 0; if
the first string is smaller, @i{n} is -1; if the first string is larger, @i{n}
is 1. Currently this is based on the machine's character
comparison. In the future, this may change to consider the current
locale and its collation order. */
NAME("capscompare")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char * c_addr2;
MAYBE_UNUSED UCell u2;
Cell n;
NEXT_P0;
vm_Cell2c_(sp[3],c_addr1);
vm_Cell2u(sp[2],u1);
vm_Cell2c_(sp[1],c_addr2);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 3;
{
/* close ' to keep fontify happy */ 
n = capscompare(c_addr1, u1, c_addr2, u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(capscompare)
NAME1("l2-capscompare")
NEXT_P1_5;
LABEL3(capscompare)
NAME1("l3-capscompare")
DO_GOTO;
}

LABEL(slash_string) /* /string ( c_addr1 u1 n -- c_addr2 u2 ) S0 -- S0  */
/* Adjust the string specified by @i{c-addr1, u1} to remove @i{n}
characters from the start of the string. */
NAME("/string")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell n;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr1);
vm_Cell2u(sp[1],u1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
c_addr2 = c_addr1+n;
u2 = u1-n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(slash_string)
NAME1("l2-slash_string")
NEXT_P1_5;
LABEL3(slash_string)
NAME1("l3-slash_string")
DO_GOTO;
}

LABEL(safe_slash_string) /* safe/string ( c_addr1 u1 n -- c_addr2 u2 ) S0 -- S0  */
/* Adjust the string specified by @i{c-addr1, u1} to remove @i{n}
characters from the start of the string.  Clamps on overflow */
NAME("safe/string")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell n;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr1);
vm_Cell2u(sp[1],u1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
c_addr2 = c_addr1+n;
u2 = u1-n;
if(n>=0) {
  if(u2>u1) { c_addr2 += u2; u2 = 0; }
} else {
  if(u2<u1) { c_addr2 += u2+1; u2 = -1; }
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(safe_slash_string)
NAME1("l2-safe_slash_string")
NEXT_P1_5;
LABEL3(safe_slash_string)
NAME1("l3-safe_slash_string")
DO_GOTO;
}

GROUPADD(9)
GROUP( arith, 63)
LABEL(lit) /* lit ( #w -- w ) S0 -- S0  */
/*  */
NAME("lit")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(IMM_ARG(IPTOS,305397798 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(1);
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(lit)
NAME1("l2-lit")
NEXT_P1_5;
LABEL3(lit)
NAME1("l3-lit")
DO_GOTO;
}

LABEL(plus) /* + ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("+")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
n = n1+n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(plus)
NAME1("l2-plus")
NEXT_P1_5;
LABEL3(plus)
NAME1("l3-plus")
DO_GOTO;
}

LABEL(lit_plus) /* lit+ ( n1 #n2 -- n ) S0 -- S0  */
/*  */
NAME("lit+")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[0],n1);
vm_Cell2n(IMM_ARG(IPTOS,305397799 ),n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
INC_IP(1);
{
#ifdef DEBUG
debugp(stderr, "lit+ %08x\n", n2);
#endif
n=n1+n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(lit_plus)
NAME1("l2-lit_plus")
NEXT_P1_5;
LABEL3(lit_plus)
NAME1("l3-lit_plus")
DO_GOTO;
}

LABEL(under_plus) /* under+ ( n1 n2 n3 -- n n2 ) S0 -- S0  */
/* add @i{n3} to @i{n1} (giving @i{n}) */
NAME("under+")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
MAYBE_UNUSED Cell n3;
Cell n;
NEXT_P0;
vm_Cell2n(sp[2],n1);
vm_Cell2n(sp[1],n2);
vm_Cell2n(sp[0],n3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
}
#endif
sp += 1;
{
n = n1+n3;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[1]);
LABEL2(under_plus)
NAME1("l2-under_plus")
NEXT_P1_5;
LABEL3(under_plus)
NAME1("l3-under_plus")
DO_GOTO;
}

LABEL(minus) /* - ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("-")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
n = n1-n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(minus)
NAME1("l2-minus")
NEXT_P1_5;
LABEL3(minus)
NAME1("l3-minus")
DO_GOTO;
}

LABEL(negate) /* negate ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("negate")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
/* use minus as alias */
n2 = -n1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(negate)
NAME1("l2-negate")
NEXT_P1_5;
LABEL3(negate)
NAME1("l3-negate")
DO_GOTO;
}

LABEL(one_plus) /* 1+ ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("1+")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1+1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(one_plus)
NAME1("l2-one_plus")
NEXT_P1_5;
LABEL3(one_plus)
NAME1("l3-one_plus")
DO_GOTO;
}

LABEL(one_minus) /* 1- ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("1-")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1-1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(one_minus)
NAME1("l2-one_minus")
NEXT_P1_5;
LABEL3(one_minus)
NAME1("l3-one_minus")
DO_GOTO;
}

LABEL(max) /* max ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("max")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (n1<n2)
  n = n2;
else
  n = n1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(max)
NAME1("l2-max")
NEXT_P1_5;
LABEL3(max)
NAME1("l3-max")
DO_GOTO;
}

LABEL(min) /* min ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("min")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (n1<n2)
  n = n1;
else
  n = n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(min)
NAME1("l2-min")
NEXT_P1_5;
LABEL3(min)
NAME1("l3-min")
DO_GOTO;
}

LABEL(abs) /* abs ( n -- u ) S0 -- S0  */
/*  */
NAME("abs")
{
DEF_CA
MAYBE_UNUSED Cell n;
UCell u;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
if (n<0)
  u = -n;
else
  u = n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(abs)
NAME1("l2-abs")
NEXT_P1_5;
LABEL3(abs)
NAME1("l3-abs")
DO_GOTO;
}

LABEL(star) /* * ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("*")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
n = n1*n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(star)
NAME1("l2-star")
NEXT_P1_5;
LABEL3(star)
NAME1("l3-star")
DO_GOTO;
}

LABEL(slash_f) /* /f ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("/f")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n=n1/n2;
if ((n1^n2)<0 && (n1%n2 != 0))
  n--;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(slash_f)
NAME1("l2-slash_f")
NEXT_P1_5;
LABEL3(slash_f)
NAME1("l3-slash_f")
DO_GOTO;
}

LABEL(modf) /* modf ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("modf")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n = n1%n2;
if ((Cell)((n1^n2) < 0) && (Cell)(n != 0))
  n += n2; 
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(modf)
NAME1("l2-modf")
NEXT_P1_5;
LABEL3(modf)
NAME1("l3-modf")
DO_GOTO;
}

LABEL(slash_mod_f) /* /modf ( n1 n2 -- n3 n4 ) S0 -- S0  */
/* n3 is the modulus, n4 the quotient */
NAME("/modf")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n3;
Cell n4;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n4 = n1/n2;
n3 = n1%n2;
if ((n1^n2)<0 && n3!=0) {
  n4 -= 1;
  n3 += n2;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n3=", vm_out); printarg_n(n3);
fputs(" n4=", vm_out); printarg_n(n4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n3,sp[1]);
vm_n2Cell(n4,sp[0]);
LABEL2(slash_mod_f)
NAME1("l2-slash_mod_f")
NEXT_P1_5;
LABEL3(slash_mod_f)
NAME1("l3-slash_mod_f")
DO_GOTO;
}

LABEL(star_slash_mod_f) /* x/modf ( n1 n2 n3 -- n4 n5 ) S0 -- S0  */
/* n1*n2=n3*n5+n4, with the intermediate result (n1*n2) being
double; n4 is the modulus, n5 the quotient */
NAME("*/modf")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
MAYBE_UNUSED Cell n3;
Cell n4;
Cell n5;
NEXT_P0;
vm_Cell2n(sp[2],n1);
vm_Cell2n(sp[1],n2);
vm_Cell2n(sp[0],n3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_MUL
DCell d = mmul(n1,n2);
#else
DCell d = (DCell)n1 * (DCell)n2;
#endif
#ifdef ASM_SM_SLASH_REM
SAVE_DIVISOR(n3);
ASM_SM_SLASH_REM(DLO(d), DHI(d), n3, n4, n5);
if ((DHI(d)^n3)<0 && n4!=0) {
  if (CHECK_DIVISION && n5 == CELL_MIN)
    throw(BALL_RESULTRANGE);
  n5--;
  n4 += n3;
}
#else
DCell r = fmdiv(d,n3);
n4=DHI(r);
n5=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n4=", vm_out); printarg_n(n4);
fputs(" n5=", vm_out); printarg_n(n5);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n4,sp[1]);
vm_n2Cell(n5,sp[0]);
LABEL2(star_slash_mod_f)
NAME1("l2-star_slash_mod_f")
NEXT_P1_5;
LABEL3(star_slash_mod_f)
NAME1("l3-star_slash_mod_f")
DO_GOTO;
}

LABEL(star_slash_f) /* x/f ( n1 n2 n3 -- n4 ) S0 -- S0  */
/* n4=(n1*n2)/n3, with the intermediate result being double */
NAME("*/f")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
MAYBE_UNUSED Cell n3;
Cell n4;
NEXT_P0;
vm_Cell2n(sp[2],n1);
vm_Cell2n(sp[1],n2);
vm_Cell2n(sp[0],n3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
}
#endif
sp += 2;
{
#ifdef BUGGY_LL_MUL
DCell d = mmul(n1,n2);
#else
DCell d = (DCell)n1 * (DCell)n2;
#endif
#ifdef ASM_SM_SLASH_REM
Cell remainder;
SAVE_DIVISOR(n3);
ASM_SM_SLASH_REM(DLO(d), DHI(d), n3, remainder, n4);
if ((DHI(d)^n3)<0 && remainder!=0) {
  if (CHECK_DIVISION && n4 == CELL_MIN)
    throw(BALL_RESULTRANGE);
  n4--;
}
#else
DCell r = fmdiv(d,n3);
n4=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n4=", vm_out); printarg_n(n4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n4,sp[0]);
LABEL2(star_slash_f)
NAME1("l2-star_slash_f")
NEXT_P1_5;
LABEL3(star_slash_f)
NAME1("l3-star_slash_f")
DO_GOTO;
}

LABEL(slash_s) /* /s ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("/s")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n = n1/n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(slash_s)
NAME1("l2-slash_s")
NEXT_P1_5;
LABEL3(slash_s)
NAME1("l3-slash_s")
DO_GOTO;
}

LABEL(mod_s) /* mods ( n1 n2 -- n ) S0 -- S0  */
/*  */
NAME("mods")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n = n1%n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(mod_s)
NAME1("l2-mod_s")
NEXT_P1_5;
LABEL3(mod_s)
NAME1("l3-mod_s")
DO_GOTO;
}

LABEL(slash_mod_s) /* /mods ( n1 n2 -- n3 n4 ) S0 -- S0  */
/* n3 is the remainder, n4 the quotient */
NAME("/mods")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Cell n3;
Cell n4;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
{
if (CHECK_DIVISION_SW && n2 == -1 && n1 == CELL_MIN)
  throw(BALL_RESULTRANGE);
if (CHECK_DIVISION_SW && n2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(n2);
n4 = n1/n2;
n3 = n1%n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n3=", vm_out); printarg_n(n3);
fputs(" n4=", vm_out); printarg_n(n4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n3,sp[1]);
vm_n2Cell(n4,sp[0]);
LABEL2(slash_mod_s)
NAME1("l2-slash_mod_s")
NEXT_P1_5;
LABEL3(slash_mod_s)
NAME1("l3-slash_mod_s")
DO_GOTO;
}

LABEL(star_slash_mod_s) /* x/mods ( n1 n2 n3 -- n4 n5 ) S0 -- S0  */
/* n1*n2=n3*n5+n4, with the intermediate result (n1*n2) being double;
n4 is the remainder, n5 the quotient */
NAME("*/mods")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
MAYBE_UNUSED Cell n3;
Cell n4;
Cell n5;
NEXT_P0;
vm_Cell2n(sp[2],n1);
vm_Cell2n(sp[1],n2);
vm_Cell2n(sp[0],n3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_MUL
DCell d = mmul(n1,n2);
#else
DCell d = (DCell)n1 * (DCell)n2;
#endif
#ifdef ASM_SM_SLASH_REM
SAVE_DIVISOR(n3);
ASM_SM_SLASH_REM(DLO(d), DHI(d), n3, n4, n5);
#else
DCell r = smdiv(d,n3);
n4=DHI(r);
n5=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n4=", vm_out); printarg_n(n4);
fputs(" n5=", vm_out); printarg_n(n5);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n4,sp[1]);
vm_n2Cell(n5,sp[0]);
LABEL2(star_slash_mod_s)
NAME1("l2-star_slash_mod_s")
NEXT_P1_5;
LABEL3(star_slash_mod_s)
NAME1("l3-star_slash_mod_s")
DO_GOTO;
}

LABEL(star_slash_s) /* x/s ( n1 n2 n3 -- n4 ) S0 -- S0  */
/* n4=(n1*n2)/n3, with the intermediate result being double */
NAME("*/s")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
MAYBE_UNUSED Cell n3;
Cell n4;
NEXT_P0;
vm_Cell2n(sp[2],n1);
vm_Cell2n(sp[1],n2);
vm_Cell2n(sp[0],n3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
}
#endif
sp += 2;
{
#ifdef BUGGY_LL_MUL
DCell d = mmul(n1,n2);
#else
DCell d = (DCell)n1 * (DCell)n2;
#endif
#ifdef ASM_SM_SLASH_REM
Cell remainder;
SAVE_DIVISOR(n3);
ASM_SM_SLASH_REM(DLO(d), DHI(d), n3, remainder, n4);
#else
DCell r = smdiv(d,n3);
n4=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n4=", vm_out); printarg_n(n4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n4,sp[0]);
LABEL2(star_slash_s)
NAME1("l2-star_slash_s")
NEXT_P1_5;
LABEL3(star_slash_s)
NAME1("l3-star_slash_s")
DO_GOTO;
}

LABEL(two_star) /* 2* ( n1 -- n2 ) S0 -- S0  */
/* Shift left by 1; also works on unsigned numbers */
NAME("2*")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = 2*n1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(two_star)
NAME1("l2-two_star")
NEXT_P1_5;
LABEL3(two_star)
NAME1("l3-two_star")
DO_GOTO;
}

LABEL(two_slash) /* 2/ ( n1 -- n2 ) S0 -- S0  */
/* Arithmetic shift right by 1.  For signed numbers this is a floored
division by 2 (note that @code{/} not necessarily floors). */
NAME("2/")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1>>1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(two_slash)
NAME1("l2-two_slash")
NEXT_P1_5;
LABEL3(two_slash)
NAME1("l3-two_slash")
DO_GOTO;
}

LABEL(f_m_slash_mod) /* fm/mod ( d1 n1 -- n2 n3 ) S0 -- S0  */
/* Floored division: @i{d1} = @i{n3}*@i{n1}+@i{n2}, @i{n1}>@i{n2}>=0 or 0>=@i{n2}>@i{n1}. */
NAME("fm/mod")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED Cell n1;
Cell n2;
Cell n3;
NEXT_P0;
vm_twoCell2d(sp[2], sp[1], d1)
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
sp += 1;
{
#ifdef ASM_SM_SLASH_REM
  SAVE_DIVISOR(n1);
  ASM_SM_SLASH_REM(DLO(d1), DHI(d1), n1, n2, n3);
  if ((DHI(d1)^n1)<0 && n2!=0) {
    if (CHECK_DIVISION && n3 == CELL_MIN)
      throw(BALL_RESULTRANGE);
    n3--;
    n2 += n1;
  }
#else /* !defined(ASM_SM_SLASH_REM) */
  DCell r = fmdiv(d1,n1);
  n2=DHI(r);
  n3=DLO(r);
#endif /* !defined(ASM_SM_SLASH_REM) */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[1]);
vm_n2Cell(n3,sp[0]);
LABEL2(f_m_slash_mod)
NAME1("l2-f_m_slash_mod")
NEXT_P1_5;
LABEL3(f_m_slash_mod)
NAME1("l3-f_m_slash_mod")
DO_GOTO;
}

LABEL(s_m_slash_rem) /* sm/rem ( d1 n1 -- n2 n3 ) S0 -- S0  */
/* Symmetric division: @i{d1} = @i{n3}*@i{n1}+@i{n2}, sign(@i{n2})=sign(@i{d1}) or 0. */
NAME("sm/rem")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED Cell n1;
Cell n2;
Cell n3;
NEXT_P0;
vm_twoCell2d(sp[2], sp[1], d1)
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
sp += 1;
{
#ifdef ASM_SM_SLASH_REM
SAVE_DIVISOR(n1);
ASM_SM_SLASH_REM(DLO(d1), DHI(d1), n1, n2, n3);
#else /* !defined(ASM_SM_SLASH_REM) */
DCell r = smdiv(d1,n1);
n2=DHI(r);
n3=DLO(r);
#endif /* !defined(ASM_SM_SLASH_REM) */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputs(" n3=", vm_out); printarg_n(n3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[1]);
vm_n2Cell(n3,sp[0]);
LABEL2(s_m_slash_rem)
NAME1("l2-s_m_slash_rem")
NEXT_P1_5;
LABEL3(s_m_slash_rem)
NAME1("l3-s_m_slash_rem")
DO_GOTO;
}

LABEL(m_star) /* m* ( n1 n2 -- d ) S0 -- S0  */
/*  */
NAME("m*")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
DCell d;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
{
d = mmul(n1,n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d=", vm_out); printarg_d(d);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d, sp[1], sp[0])
LABEL2(m_star)
NAME1("l2-m_star")
NEXT_P1_5;
LABEL3(m_star)
NAME1("l3-m_star")
DO_GOTO;
}

LABEL(u_m_star) /* um* ( u1 u2 -- ud ) S0 -- S0  */
/*  */
NAME("um*")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UDCell ud;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
{
/* use u* as alias */
ud = ummul(u1,u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[1], sp[0])
LABEL2(u_m_star)
NAME1("l2-u_m_star")
NEXT_P1_5;
LABEL3(u_m_star)
NAME1("l3-u_m_star")
DO_GOTO;
}

LABEL(u_m_slash_mod) /* um/mod ( ud u1 -- u2 u3 ) S0 -- S0  */
/* ud=u3*u1+u2, 0<=u2<u1 */
NAME("um/mod")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED UCell u1;
UCell u2;
UCell u3;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
sp += 1;
{
#ifdef ASM_UM_SLASH_MOD
SAVE_DIVISOR(u1);
ASM_UM_SLASH_MOD(DLO(ud), DHI(ud), u1, u2, u3);
#else /* !defined(ASM_UM_SLASH_MOD) */
UDCell r = umdiv(ud,u1);
u2=DHI(r);
u3=DLO(r);
#endif /* !defined(ASM_UM_SLASH_MOD) */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputs(" u3=", vm_out); printarg_u(u3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[1]);
vm_u2Cell(u3,sp[0]);
LABEL2(u_m_slash_mod)
NAME1("l2-u_m_slash_mod")
NEXT_P1_5;
LABEL3(u_m_slash_mod)
NAME1("l3-u_m_slash_mod")
DO_GOTO;
}

LABEL(u_slash_stage2m) /* u/-stage2m ( u1 a_reci -- uquotient ) S0 -- S0  */
/* @i{Uquotient} is the result of dividing @i{u1} by the divisor represented
by @i{a-reci}, which was computed by @code{u/-stage1m}. */
NAME("u/-stage2m")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell * a_reci;
UCell uquotient;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
sp += 1;
{
stagediv_t *reci = (stagediv_t *)a_reci;
uquotient = uslashstage2(u1,reci);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" uquotient=", vm_out); printarg_u(uquotient);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(uquotient,sp[0]);
LABEL2(u_slash_stage2m)
NAME1("l2-u_slash_stage2m")
NEXT_P1_5;
LABEL3(u_slash_stage2m)
NAME1("l3-u_slash_stage2m")
DO_GOTO;
}

LABEL(u_mod_stage2m) /* umod-stage2m ( u1 a_reci -- umodulus ) S0 -- S0  */
/* @i{Umodulus} is the remainder of dividing @i{u1} by the divisor represented
by @i{a-reci}, which was computed by @code{u/-stage1m}. */
NAME("umod-stage2m")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell * a_reci;
UCell umodulus;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
sp += 1;
{
stagediv_t *reci = (stagediv_t *)a_reci;
UCell uquotient = uslashstage2(u1,reci);
umodulus = u1 - uquotient*reci->divisor;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" umodulus=", vm_out); printarg_u(umodulus);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(umodulus,sp[0]);
LABEL2(u_mod_stage2m)
NAME1("l2-u_mod_stage2m")
NEXT_P1_5;
LABEL3(u_mod_stage2m)
NAME1("l3-u_mod_stage2m")
DO_GOTO;
}

LABEL(u_slash_mod_stage2m) /* u/mod-stage2m ( u1 a_reci -- umodulus uquotient ) S0 -- S0  */
/* @i{Uquotient} is the quotient and @i{umodulus} is the remainder of
dividing @i{u1} by the divisor represented by @i{a-reci}, which was
computed by @code{u/-stage1m}. */
NAME("u/mod-stage2m")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell * a_reci;
UCell umodulus;
UCell uquotient;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
{
stagediv_t *reci = (stagediv_t *)a_reci;
uquotient = uslashstage2(u1,reci);
umodulus = u1 - uquotient*reci->divisor;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" umodulus=", vm_out); printarg_u(umodulus);
fputs(" uquotient=", vm_out); printarg_u(uquotient);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(umodulus,sp[1]);
vm_u2Cell(uquotient,sp[0]);
LABEL2(u_slash_mod_stage2m)
NAME1("l2-u_slash_mod_stage2m")
NEXT_P1_5;
LABEL3(u_slash_mod_stage2m)
NAME1("l3-u_slash_mod_stage2m")
DO_GOTO;
}

LABEL(slash_f_stage2m) /* /f-stage2m ( n1 a_reci -- nquotient ) S0 -- S0  */
/* @i{Nquotient} is the result of dividing @i{n1} by the divisor represented
by @i{a-reci}, which was computed by @code{/f-stage1m}. */
NAME("/f-stage2m")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell * a_reci;
Cell nquotient;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
sp += 1;
{
nquotient = slashfstage2(n1,((stagediv_t *)a_reci));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" nquotient=", vm_out); printarg_n(nquotient);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nquotient,sp[0]);
LABEL2(slash_f_stage2m)
NAME1("l2-slash_f_stage2m")
NEXT_P1_5;
LABEL3(slash_f_stage2m)
NAME1("l3-slash_f_stage2m")
DO_GOTO;
}

LABEL(mod_f_stage2m) /* modf-stage2m ( n1 a_reci -- umodulus ) S0 -- S0  */
/* @i{Umodulus} is the remainder of dividing @i{n1} by the divisor represented
by @i{a-reci}, which was computed by @code{/f-stage1m}. */
NAME("modf-stage2m")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell * a_reci;
UCell umodulus;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
sp += 1;
{
stagediv_t *reci = (stagediv_t *)a_reci;
Cell nquotient = slashfstage2(n1,reci);
umodulus = n1 - nquotient*reci->divisor;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" umodulus=", vm_out); printarg_u(umodulus);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(umodulus,sp[0]);
LABEL2(mod_f_stage2m)
NAME1("l2-mod_f_stage2m")
NEXT_P1_5;
LABEL3(mod_f_stage2m)
NAME1("l3-mod_f_stage2m")
DO_GOTO;
}

LABEL(slash_mod_f_stage2m) /* /modf-stage2m ( n1 a_reci -- umodulus nquotient ) S0 -- S0  */
/* @i{Nquotient} is the quotient and @i{umodulus} is the remainder of
dividing @i{n1} by the divisor represented by @i{a-reci}, which was
computed by @code{/f-stage1m}. */
NAME("/modf-stage2m")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell * a_reci;
UCell umodulus;
Cell nquotient;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2a_(sp[0],a_reci);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" a_reci=", vm_out); printarg_a_(a_reci);
}
#endif
{
stagediv_t *reci = (stagediv_t *)a_reci;
nquotient = slashfstage2(n1,reci);
umodulus = n1 - nquotient*reci->divisor;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" umodulus=", vm_out); printarg_u(umodulus);
fputs(" nquotient=", vm_out); printarg_n(nquotient);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(umodulus,sp[1]);
vm_n2Cell(nquotient,sp[0]);
LABEL2(slash_mod_f_stage2m)
NAME1("l2-slash_mod_f_stage2m")
NEXT_P1_5;
LABEL3(slash_mod_f_stage2m)
NAME1("l3-slash_mod_f_stage2m")
DO_GOTO;
}

LABEL(m_plus) /* m+ ( d1 n -- d2 ) S0 -- S0  */
/*  */
NAME("m+")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED Cell n;
DCell d2;
NEXT_P0;
vm_twoCell2d(sp[2], sp[1], d1)
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_ADD
DLO_IS(d2, DLO(d1)+n);
DHI_IS(d2, DHI(d1) - (n<0) + (DLO(d2)<DLO(d1)));
#else
d2 = d1+n;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d2=", vm_out); printarg_d(d2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d2, sp[1], sp[0])
LABEL2(m_plus)
NAME1("l2-m_plus")
NEXT_P1_5;
LABEL3(m_plus)
NAME1("l3-m_plus")
DO_GOTO;
}

LABEL(d_plus) /* d+ ( ud1 ud2 -- ud ) S0 -- S0  */
/*  */
NAME("d+")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
UDCell ud;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 2;
{
ud=dadd(ud1,ud2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[1], sp[0])
LABEL2(d_plus)
NAME1("l2-d_plus")
NEXT_P1_5;
LABEL3(d_plus)
NAME1("l3-d_plus")
DO_GOTO;
}

LABEL(d_minus) /* d- ( d1 d2 -- d ) S0 -- S0  */
/*  */
NAME("d-")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
DCell d;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 2;
{
#ifdef BUGGY_LL_ADD
DLO_IS(d, DLO(d1) - DLO(d2));
DHI_IS(d, DHI(d1)-DHI(d2)-(DLO(d1)<DLO(d2)));
#else
d = d1-d2;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d=", vm_out); printarg_d(d);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d, sp[1], sp[0])
LABEL2(d_minus)
NAME1("l2-d_minus")
NEXT_P1_5;
LABEL3(d_minus)
NAME1("l3-d_minus")
DO_GOTO;
}

LABEL(d_negate) /* dnegate ( d1 -- d2 ) S0 -- S0  */
/*  */
NAME("dnegate")
{
DEF_CA
MAYBE_UNUSED DCell d1;
DCell d2;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d1)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
}
#endif
{
/* use dminus as alias */
#ifdef BUGGY_LL_ADD
d2 = dnegate(d1);
#else
d2 = -d1;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d2=", vm_out); printarg_d(d2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d2, sp[1], sp[0])
LABEL2(d_negate)
NAME1("l2-d_negate")
NEXT_P1_5;
LABEL3(d_negate)
NAME1("l3-d_negate")
DO_GOTO;
}

LABEL(d_two_star) /* d2* ( d1 -- d2 ) S0 -- S0  */
/* Shift left by 1; also works on unsigned numbers */
NAME("d2*")
{
DEF_CA
MAYBE_UNUSED DCell d1;
DCell d2;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d1)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
}
#endif
{
d2 = DLSHIFT(d1,1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d2=", vm_out); printarg_d(d2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d2, sp[1], sp[0])
LABEL2(d_two_star)
NAME1("l2-d_two_star")
NEXT_P1_5;
LABEL3(d_two_star)
NAME1("l3-d_two_star")
DO_GOTO;
}

LABEL(d_two_slash) /* d2/ ( d1 -- d2 ) S0 -- S0  */
/* Arithmetic shift right by 1.  For signed numbers this is a floored
division by 2. */
NAME("d2/")
{
DEF_CA
MAYBE_UNUSED DCell d1;
DCell d2;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d1)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
}
#endif
{
#ifdef BUGGY_LL_SHIFT
DHI_IS(d2, DHI(d1)>>1);
DLO_IS(d2, (DLO(d1)>>1) | (DHI(d1)<<(CELL_BITS-1)));
#else
d2 = d1>>1;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d2=", vm_out); printarg_d(d2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d2, sp[1], sp[0])
LABEL2(d_two_slash)
NAME1("l2-d_two_slash")
NEXT_P1_5;
LABEL3(d_two_slash)
NAME1("l3-d_two_slash")
DO_GOTO;
}

LABEL(and) /* and ( w1 w2 -- w ) S0 -- S0  */
/*  */
NAME("and")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
Cell w;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 1;
{
w = w1&w2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(and)
NAME1("l2-and")
NEXT_P1_5;
LABEL3(and)
NAME1("l3-and")
DO_GOTO;
}

LABEL(or) /* or ( w1 w2 -- w ) S0 -- S0  */
/*  */
NAME("or")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
Cell w;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 1;
{
w = w1|w2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(or)
NAME1("l2-or")
NEXT_P1_5;
LABEL3(or)
NAME1("l3-or")
DO_GOTO;
}

LABEL(x_or) /* xor ( w1 w2 -- w ) S0 -- S0  */
/*  */
NAME("xor")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
Cell w;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 1;
{
w = w1^w2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(x_or)
NAME1("l2-x_or")
NEXT_P1_5;
LABEL3(x_or)
NAME1("l3-x_or")
DO_GOTO;
}

LABEL(invert) /* invert ( w1 -- w2 ) S0 -- S0  */
/*  */
NAME("invert")
{
DEF_CA
MAYBE_UNUSED Cell w1;
Cell w2;
NEXT_P0;
vm_Cell2w(sp[0],w1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
}
#endif
{
w2 = ~w1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w2=", vm_out); printarg_w(w2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w2,sp[0]);
LABEL2(invert)
NAME1("l2-invert")
NEXT_P1_5;
LABEL3(invert)
NAME1("l3-invert")
DO_GOTO;
}

LABEL(r_shift) /* rshift ( u1 n -- u2 ) S0 -- S0  */
/* Logical shift right by @i{n} bits. */
NAME("rshift")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell n;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
#ifdef BROKEN_SHIFT
  u2 = rshift(u1, n);
#else
  u2 = u1 >> n;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(r_shift)
NAME1("l2-r_shift")
NEXT_P1_5;
LABEL3(r_shift)
NAME1("l3-r_shift")
DO_GOTO;
}

LABEL(l_shift) /* lshift ( u1 n -- u2 ) S0 -- S0  */
/*  */
NAME("lshift")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell n;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
#ifdef BROKEN_SHIFT
  u2 = lshift(u1, n);
#else
  u2 = u1 << n;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(l_shift)
NAME1("l2-l_shift")
NEXT_P1_5;
LABEL3(l_shift)
NAME1("l3-l_shift")
DO_GOTO;
}

LABEL(umax) /* umax ( u1 u2 -- u ) S0 -- S0  */
/*  */
NAME("umax")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
if (u1<u2)
  u = u2;
else
  u = u1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(umax)
NAME1("l2-umax")
NEXT_P1_5;
LABEL3(umax)
NAME1("l3-umax")
DO_GOTO;
}

LABEL(umin) /* umin ( u1 u2 -- u ) S0 -- S0  */
/*  */
NAME("umin")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
if (u1<u2)
  u = u1;
else
  u = u2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(umin)
NAME1("l2-umin")
NEXT_P1_5;
LABEL3(umin)
NAME1("l3-umin")
DO_GOTO;
}

LABEL(mux) /* mux ( u1 u2 u3 -- u ) S0 -- S0  */
/* multiplex @i{u1} for 1 bits in @i{u3}, @i{u2} for 0 bits in @i{u3} into @i{u} */
NAME("mux")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
MAYBE_UNUSED UCell u3;
UCell u;
NEXT_P0;
vm_Cell2u(sp[2],u1);
vm_Cell2u(sp[1],u2);
vm_Cell2u(sp[0],u3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
fputs(" u3=", vm_out); printarg_u(u3);
}
#endif
sp += 2;
{
u = (u3 & u1) | (~u3 & u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(mux)
NAME1("l2-mux")
NEXT_P1_5;
LABEL3(mux)
NAME1("l3-mux")
DO_GOTO;
}

LABEL(select) /* select ( u1 u2 f -- u ) S0 -- S0  */
/* select @i{u1} if @i{f} is true, @i{u2} if false. */
NAME("select")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
MAYBE_UNUSED Bool f;
UCell u;
NEXT_P0;
vm_Cell2u(sp[2],u1);
vm_Cell2u(sp[1],u2);
vm_Cell2f(sp[0],f);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
fputs(" f=", vm_out); printarg_f(f);
}
#endif
sp += 2;
{
u = f ? u1 : u2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(select)
NAME1("l2-select")
NEXT_P1_5;
LABEL3(select)
NAME1("l3-select")
DO_GOTO;
}

LABEL(dlshift) /* dlshift ( ud1 u -- ud2 ) S0 -- S0  */
/* double arithmetic shift left */
NAME("dlshift")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UCell u;
UDCell ud2;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud1)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_SHIFT
if(u>=CELL_BITS) {
  u &= CELL_BITS-1;
  DHI_IS(ud2, (DLO(ud1) << u));
  DLO_IS(ud2, 0);
} else {
  DHI_IS(ud2, ((DHI(ud1) << u) | (DLO(ud1) >> (CELL_BITS-u))));
  DLO_IS(ud2, (DLO(ud1) << u));
}
#else
  ud2 = ud1 << u;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud2=", vm_out); printarg_ud(ud2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud2, sp[1], sp[0])
LABEL2(dlshift)
NAME1("l2-dlshift")
NEXT_P1_5;
LABEL3(dlshift)
NAME1("l3-dlshift")
DO_GOTO;
}

LABEL(drshift) /* drshift ( ud1 u -- ud2 ) S0 -- S0  */
/* double logic shift right */
NAME("drshift")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UCell u;
UDCell ud2;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud1)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_SHIFT
if(u>=CELL_BITS) {
  u &= CELL_BITS-1;
  DHI_IS(ud2, 0);
  DLO_IS(ud2, (DHI(ud1) >> u));
} else {
  DHI_IS(ud2, (DHI(ud1) >> u));
  DLO_IS(ud2, ((DLO(ud1) >> u) | (DHI(ud1) << (CELL_BITS-u))));
}
#else
  ud2 = ud1 >> u;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud2=", vm_out); printarg_ud(ud2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud2, sp[1], sp[0])
LABEL2(drshift)
NAME1("l2-drshift")
NEXT_P1_5;
LABEL3(drshift)
NAME1("l3-drshift")
DO_GOTO;
}

LABEL(rol) /* rol ( u1 u -- u2 ) S0 -- S0  */
/* rotate left */
NAME("rol")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
u2 = (u1 << u) | (u1 >> (CELL_BITS-u));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(rol)
NAME1("l2-rol")
NEXT_P1_5;
LABEL3(rol)
NAME1("l3-rol")
DO_GOTO;
}

LABEL(ror) /* ror ( u1 u -- u2 ) S0 -- S0  */
/* rotate right */
NAME("ror")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
u2 = (u1 >> u) | (u1 << (CELL_BITS-u));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(ror)
NAME1("l2-ror")
NEXT_P1_5;
LABEL3(ror)
NAME1("l3-ror")
DO_GOTO;
}

LABEL(drol) /* drol ( ud1 u -- ud2 ) S0 -- S0  */
/* rotate left */
NAME("drol")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UCell u;
UDCell ud2;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud1)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_SHIFT
unsigned int u1 = u & (CELL_BITS-1);
UCell uh, ul;
uh=u1 ? ((DHI(ud1) << u1) | ((UCell)(DLO(ud1)) >> (CELL_BITS-u1))) : DHI(ud1);
ul=u1 ? ((DLO(ud1) << u1) | ((UCell)(DHI(ud1)) >> (CELL_BITS-u1))) : DLO(ud1);
if(u & CELL_BITS) {
  DHI_IS(ud2, ul);
  DLO_IS(ud2, uh);
} else {
  DHI_IS(ud2, uh);
  DLO_IS(ud2, ul);
}
#else
u &= 2*CELL_BITS-1;
ud2 = (ud1 << u) | (ud1 >> (2*CELL_BITS-u));
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud2=", vm_out); printarg_ud(ud2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud2, sp[1], sp[0])
LABEL2(drol)
NAME1("l2-drol")
NEXT_P1_5;
LABEL3(drol)
NAME1("l3-drol")
DO_GOTO;
}

LABEL(dror) /* dror ( ud1 u -- ud2 ) S0 -- S0  */
/* rotate right */
NAME("dror")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UCell u;
UDCell ud2;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud1)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_SHIFT
unsigned int u1 = u & (CELL_BITS-1);
UCell uh, ul;
uh=u1 ? (((UCell)(DHI(ud1)) >> u1) | (DLO(ud1) << (CELL_BITS-u1))) : DHI(ud1);
ul=u1 ? (((UCell)(DLO(ud1)) >> u1) | (DHI(ud1) << (CELL_BITS-u1))) : DLO(ud1);
if(u & CELL_BITS) {
  DHI_IS(ud2, ul);
  DLO_IS(ud2, uh);
} else {
  DHI_IS(ud2, uh);
  DLO_IS(ud2, ul);
}
#else
u &= 2*CELL_BITS-1;
ud2 = (ud1 >> u) | (ud1 << (2*CELL_BITS-u));
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud2=", vm_out); printarg_ud(ud2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud2, sp[1], sp[0])
LABEL2(dror)
NAME1("l2-dror")
NEXT_P1_5;
LABEL3(dror)
NAME1("l3-dror")
DO_GOTO;
}

LABEL(du_slash_mod) /* du/mod ( d u -- n u1 ) S0 -- S0  */
/* d=n*u+u1, 0<=u1<u; PolyForth style mixed division */
NAME("du/mod")
{
DEF_CA
MAYBE_UNUSED DCell d;
MAYBE_UNUSED UCell u;
Cell n;
UCell u1;
NEXT_P0;
vm_twoCell2d(sp[2], sp[1], d)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
Cell up = DHI(d);
Cell correct = -(up < 0);
up += correct & u;
DHI_IS(d, up);
#ifdef ASM_UM_SLASH_MOD
SAVE_DIVISOR(u);
ASM_UM_SLASH_MOD(DLO(d), DHI(d), u, n, u1);
#else /* !defined(ASM_UM_SLASH_MOD) */
{
UDCell r = umdiv(*(UDCell*)&d,u);
n=DHI(r);
u1=DLO(r);
}
#endif /* !defined(ASM_UM_SLASH_MOD) */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputs(" u1=", vm_out); printarg_u(u1);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[1]);
vm_u2Cell(u1,sp[0]);
LABEL2(du_slash_mod)
NAME1("l2-du_slash_mod")
NEXT_P1_5;
LABEL3(du_slash_mod)
NAME1("l3-du_slash_mod")
DO_GOTO;
}

LABEL(u_slash) /* u/ ( u1 u2 -- u ) S0 -- S0  */
/*  */
NAME("u/")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && u2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(u2);
u = u1/u2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(u_slash)
NAME1("l2-u_slash")
NEXT_P1_5;
LABEL3(u_slash)
NAME1("l3-u_slash")
DO_GOTO;
}

LABEL(umod) /* umod ( u1 u2 -- u ) S0 -- S0  */
/*  */
NAME("umod")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
if (CHECK_DIVISION_SW && u2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(u2);
u = u1%u2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(umod)
NAME1("l2-umod")
NEXT_P1_5;
LABEL3(umod)
NAME1("l3-umod")
DO_GOTO;
}

LABEL(u_slash_mod) /* u/mod ( u1 u2 -- u3 u4 ) S0 -- S0  */
/* u3 is the modulus, u4 the quotient */
NAME("u/mod")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u3;
UCell u4;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
{
if (CHECK_DIVISION_SW && u2 == 0)
  throw(BALL_DIVZERO);
SAVE_DIVISOR(u2);
u4 = u1/u2;
u3 = u1%u2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u3=", vm_out); printarg_u(u3);
fputs(" u4=", vm_out); printarg_u(u4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u3,sp[1]);
vm_u2Cell(u4,sp[0]);
LABEL2(u_slash_mod)
NAME1("l2-u_slash_mod")
NEXT_P1_5;
LABEL3(u_slash_mod)
NAME1("l3-u_slash_mod")
DO_GOTO;
}

LABEL(u_star_slash_mod) /* ux/mod ( u1 u2 u3 -- u4 u5 ) S0 -- S0  */
/* u1*u2=u3*u5+u4, with the intermediate result (u1*u2) being double. */
NAME("u*/mod")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
MAYBE_UNUSED UCell u3;
UCell u4;
UCell u5;
NEXT_P0;
vm_Cell2u(sp[2],u1);
vm_Cell2u(sp[1],u2);
vm_Cell2u(sp[0],u3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
fputs(" u3=", vm_out); printarg_u(u3);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_MUL
UDCell ud = ummul(u1,u2);
#else
UDCell ud = (UDCell)u1 * (UDCell)u2;
#endif
#ifdef ASM_UM_SLASH_MOD
SAVE_DIVISOR(u3);
ASM_UM_SLASH_MOD(DLO(ud), DHI(ud), u3, u4, u5);
#else
UDCell r = umdiv(ud,u3);
u4=DHI(r);
u5=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u4=", vm_out); printarg_u(u4);
fputs(" u5=", vm_out); printarg_u(u5);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u4,sp[1]);
vm_u2Cell(u5,sp[0]);
LABEL2(u_star_slash_mod)
NAME1("l2-u_star_slash_mod")
NEXT_P1_5;
LABEL3(u_star_slash_mod)
NAME1("l3-u_star_slash_mod")
DO_GOTO;
}

LABEL(u_star_slash) /* ux/ ( u1 u2 u3 -- u4 ) S0 -- S0  */
/* u4=(u1*u2)/u3, with the intermediate result being double. */
NAME("u*/")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
MAYBE_UNUSED UCell u3;
UCell u4;
NEXT_P0;
vm_Cell2u(sp[2],u1);
vm_Cell2u(sp[1],u2);
vm_Cell2u(sp[0],u3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
fputs(" u3=", vm_out); printarg_u(u3);
}
#endif
sp += 2;
{
#ifdef BUGGY_LL_MUL
UDCell ud = ummul(u1,u2);
#else
UDCell ud = (UDCell)u1 * (UDCell)u2;
#endif
#ifdef ASM_SM_SLASH_REM
UCell remainder;
SAVE_DIVISOR(u3);
ASM_UM_SLASH_MOD(DLO(ud), DHI(ud), u3, remainder, u4);
#else
UDCell r = umdiv(ud,u3);
u4=DLO(r);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u4=", vm_out); printarg_u(u4);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u4,sp[0]);
LABEL2(u_star_slash)
NAME1("l2-u_star_slash")
NEXT_P1_5;
LABEL3(u_star_slash)
NAME1("l3-u_star_slash")
DO_GOTO;
}

LABEL(ar_shift) /* arshift ( n1 n -- n2 ) S0 -- S0  */
/* signed shift right by @i{n} bits. */
NAME("arshift")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
n2 = n1 >> n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(ar_shift)
NAME1("l2-ar_shift")
NEXT_P1_5;
LABEL3(ar_shift)
NAME1("l3-ar_shift")
DO_GOTO;
}

LABEL(darshift) /* darshift ( d1 u -- d2 ) S0 -- S0  */
/* double arithmetic shift right */
NAME("darshift")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED UCell u;
DCell d2;
NEXT_P0;
vm_twoCell2d(sp[2], sp[1], d1)
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_SHIFT
if(u>=CELL_BITS) {
  u &= CELL_BITS-1;
  DHI_IS(d2, 0);
  DLO_IS(d2, (DHI(d1) >> u));
} else {
  DHI_IS(d2, (DHI(d1) >> u));
  DLO_IS(d2, ((DLO(d1) >> u) | (DHI(d1) << (CELL_BITS-u))));
}
#else
  d2 = d1 >> u;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d2=", vm_out); printarg_d(d2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d2, sp[1], sp[0])
LABEL2(darshift)
NAME1("l2-darshift")
NEXT_P1_5;
LABEL3(darshift)
NAME1("l3-darshift")
DO_GOTO;
}

GROUPADD(65)
GROUP( compare, 128)
LABEL(zero_equals) /* 0= ( n -- f ) S0 -- S0  */
/*  */
NAME("0=")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n==0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_equals)
NAME1("l2-zero_equals")
NEXT_P1_5;
LABEL3(zero_equals)
NAME1("l3-zero_equals")
DO_GOTO;
}

LABEL(zero_not_equals) /* 0<> ( n -- f ) S0 -- S0  */
/*  */
NAME("0<>")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n!=0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_not_equals)
NAME1("l2-zero_not_equals")
NEXT_P1_5;
LABEL3(zero_not_equals)
NAME1("l3-zero_not_equals")
DO_GOTO;
}

LABEL(zero_less_than) /* 0< ( n -- f ) S0 -- S0  */
/*  */
NAME("0<")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n<0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_less_than)
NAME1("l2-zero_less_than")
NEXT_P1_5;
LABEL3(zero_less_than)
NAME1("l3-zero_less_than")
DO_GOTO;
}

LABEL(zero_greater_than) /* 0> ( n -- f ) S0 -- S0  */
/*  */
NAME("0>")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n>0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_greater_than)
NAME1("l2-zero_greater_than")
NEXT_P1_5;
LABEL3(zero_greater_than)
NAME1("l3-zero_greater_than")
DO_GOTO;
}

LABEL(zero_less_or_equal) /* 0<= ( n -- f ) S0 -- S0  */
/*  */
NAME("0<=")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n<=0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_less_or_equal)
NAME1("l2-zero_less_or_equal")
NEXT_P1_5;
LABEL3(zero_less_or_equal)
NAME1("l3-zero_less_or_equal")
DO_GOTO;
}

LABEL(zero_greater_or_equal) /* 0>= ( n -- f ) S0 -- S0  */
/*  */
NAME("0>=")
{
DEF_CA
MAYBE_UNUSED Cell n;
Bool f;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
{
f = FLAG(n>=0);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(zero_greater_or_equal)
NAME1("l2-zero_greater_or_equal")
NEXT_P1_5;
LABEL3(zero_greater_or_equal)
NAME1("l3-zero_greater_or_equal")
DO_GOTO;
}

LABEL(equals) /* = ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME("=")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1==n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(equals)
NAME1("l2-equals")
NEXT_P1_5;
LABEL3(equals)
NAME1("l3-equals")
DO_GOTO;
}

LABEL(not_equals) /* <> ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME("<>")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1!=n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(not_equals)
NAME1("l2-not_equals")
NEXT_P1_5;
LABEL3(not_equals)
NAME1("l3-not_equals")
DO_GOTO;
}

LABEL(less_than) /* < ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME("<")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1<n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(less_than)
NAME1("l2-less_than")
NEXT_P1_5;
LABEL3(less_than)
NAME1("l3-less_than")
DO_GOTO;
}

LABEL(greater_than) /* > ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME(">")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1>n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(greater_than)
NAME1("l2-greater_than")
NEXT_P1_5;
LABEL3(greater_than)
NAME1("l3-greater_than")
DO_GOTO;
}

LABEL(less_or_equal) /* <= ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME("<=")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1<=n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(less_or_equal)
NAME1("l2-less_or_equal")
NEXT_P1_5;
LABEL3(less_or_equal)
NAME1("l3-less_or_equal")
DO_GOTO;
}

LABEL(greater_or_equal) /* >= ( n1 n2 -- f ) S0 -- S0  */
/*  */
NAME(">=")
{
DEF_CA
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Bool f;
NEXT_P0;
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 1;
{
f = FLAG(n1>=n2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(greater_or_equal)
NAME1("l2-greater_or_equal")
NEXT_P1_5;
LABEL3(greater_or_equal)
NAME1("l3-greater_or_equal")
DO_GOTO;
}

LABEL(u_equals) /* u= ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u=")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1==u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_equals)
NAME1("l2-u_equals")
NEXT_P1_5;
LABEL3(u_equals)
NAME1("l3-u_equals")
DO_GOTO;
}

LABEL(u_not_equals) /* u<> ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u<>")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1!=u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_not_equals)
NAME1("l2-u_not_equals")
NEXT_P1_5;
LABEL3(u_not_equals)
NAME1("l3-u_not_equals")
DO_GOTO;
}

LABEL(u_less_than) /* u< ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u<")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1<u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_less_than)
NAME1("l2-u_less_than")
NEXT_P1_5;
LABEL3(u_less_than)
NAME1("l3-u_less_than")
DO_GOTO;
}

LABEL(u_greater_than) /* u> ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u>")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1>u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_greater_than)
NAME1("l2-u_greater_than")
NEXT_P1_5;
LABEL3(u_greater_than)
NAME1("l3-u_greater_than")
DO_GOTO;
}

LABEL(u_less_or_equal) /* u<= ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u<=")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1<=u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_less_or_equal)
NAME1("l2-u_less_or_equal")
NEXT_P1_5;
LABEL3(u_less_or_equal)
NAME1("l3-u_less_or_equal")
DO_GOTO;
}

LABEL(u_greater_or_equal) /* u>= ( u1 u2 -- f ) S0 -- S0  */
/*  */
NAME("u>=")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
Bool f;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 1;
{
f = FLAG(u1>=u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(u_greater_or_equal)
NAME1("l2-u_greater_or_equal")
NEXT_P1_5;
LABEL3(u_greater_or_equal)
NAME1("l3-u_greater_or_equal")
DO_GOTO;
}

GROUPADD(18)
#ifdef HAS_DCOMPS
LABEL(d_equals) /* d= ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d=")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.lo==d2.lo && d1.hi==d2.hi);
#else
f = FLAG(d1==d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_equals)
NAME1("l2-d_equals")
NEXT_P1_5;
LABEL3(d_equals)
NAME1("l3-d_equals")
DO_GOTO;
}

LABEL(d_not_equals) /* d<> ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d<>")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.lo!=d2.lo || d1.hi!=d2.hi);
#else
f = FLAG(d1!=d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_not_equals)
NAME1("l2-d_not_equals")
NEXT_P1_5;
LABEL3(d_not_equals)
NAME1("l3-d_not_equals")
DO_GOTO;
}

LABEL(d_less_than) /* d< ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d<")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.hi==d2.hi ? d1.lo<d2.lo : d1.hi<d2.hi);
#else
f = FLAG(d1<d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_less_than)
NAME1("l2-d_less_than")
NEXT_P1_5;
LABEL3(d_less_than)
NAME1("l3-d_less_than")
DO_GOTO;
}

LABEL(d_greater_than) /* d> ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d>")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.hi==d2.hi ? d1.lo>d2.lo : d1.hi>d2.hi);
#else
f = FLAG(d1>d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_greater_than)
NAME1("l2-d_greater_than")
NEXT_P1_5;
LABEL3(d_greater_than)
NAME1("l3-d_greater_than")
DO_GOTO;
}

LABEL(d_less_or_equal) /* d<= ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d<=")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.hi==d2.hi ? d1.lo<=d2.lo : d1.hi<=d2.hi);
#else
f = FLAG(d1<=d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_less_or_equal)
NAME1("l2-d_less_or_equal")
NEXT_P1_5;
LABEL3(d_less_or_equal)
NAME1("l3-d_less_or_equal")
DO_GOTO;
}

LABEL(d_greater_or_equal) /* d>= ( d1 d2 -- f ) S0 -- S0  */
/*  */
NAME("d>=")
{
DEF_CA
MAYBE_UNUSED DCell d1;
MAYBE_UNUSED DCell d2;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[3], sp[2], d1)
vm_twoCell2d(sp[1], sp[0], d2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d1=", vm_out); printarg_d(d1);
fputs(" d2=", vm_out); printarg_d(d2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d1.hi==d2.hi ? d1.lo>=d2.lo : d1.hi>=d2.hi);
#else
f = FLAG(d1>=d2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_greater_or_equal)
NAME1("l2-d_greater_or_equal")
NEXT_P1_5;
LABEL3(d_greater_or_equal)
NAME1("l3-d_greater_or_equal")
DO_GOTO;
}

LABEL(d_zero_equals) /* d0= ( d -- f ) S0 -- S0  */
/*  */
NAME("d0=")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.lo==DZERO.lo && d.hi==DZERO.hi);
#else
f = FLAG(d==DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_equals)
NAME1("l2-d_zero_equals")
NEXT_P1_5;
LABEL3(d_zero_equals)
NAME1("l3-d_zero_equals")
DO_GOTO;
}

LABEL(d_zero_not_equals) /* d0<> ( d -- f ) S0 -- S0  */
/*  */
NAME("d0<>")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.lo!=DZERO.lo || d.hi!=DZERO.hi);
#else
f = FLAG(d!=DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_not_equals)
NAME1("l2-d_zero_not_equals")
NEXT_P1_5;
LABEL3(d_zero_not_equals)
NAME1("l3-d_zero_not_equals")
DO_GOTO;
}

LABEL(d_zero_less_than) /* d0< ( d -- f ) S0 -- S0  */
/*  */
NAME("d0<")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.hi==DZERO.hi ? d.lo<DZERO.lo : d.hi<DZERO.hi);
#else
f = FLAG(d<DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_less_than)
NAME1("l2-d_zero_less_than")
NEXT_P1_5;
LABEL3(d_zero_less_than)
NAME1("l3-d_zero_less_than")
DO_GOTO;
}

LABEL(d_zero_greater_than) /* d0> ( d -- f ) S0 -- S0  */
/*  */
NAME("d0>")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.hi==DZERO.hi ? d.lo>DZERO.lo : d.hi>DZERO.hi);
#else
f = FLAG(d>DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_greater_than)
NAME1("l2-d_zero_greater_than")
NEXT_P1_5;
LABEL3(d_zero_greater_than)
NAME1("l3-d_zero_greater_than")
DO_GOTO;
}

LABEL(d_zero_less_or_equal) /* d0<= ( d -- f ) S0 -- S0  */
/*  */
NAME("d0<=")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.hi==DZERO.hi ? d.lo<=DZERO.lo : d.hi<=DZERO.hi);
#else
f = FLAG(d<=DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_less_or_equal)
NAME1("l2-d_zero_less_or_equal")
NEXT_P1_5;
LABEL3(d_zero_less_or_equal)
NAME1("l3-d_zero_less_or_equal")
DO_GOTO;
}

LABEL(d_zero_greater_or_equal) /* d0>= ( d -- f ) S0 -- S0  */
/*  */
NAME("d0>=")
{
DEF_CA
MAYBE_UNUSED DCell d;
Bool f;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 1;
{
#ifdef BUGGY_LL_CMP
f = FLAG(d.hi==DZERO.hi ? d.lo>=DZERO.lo : d.hi>=DZERO.hi);
#else
f = FLAG(d>=DZERO);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_zero_greater_or_equal)
NAME1("l2-d_zero_greater_or_equal")
NEXT_P1_5;
LABEL3(d_zero_greater_or_equal)
NAME1("l3-d_zero_greater_or_equal")
DO_GOTO;
}

LABEL(d_u_equals) /* du= ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du=")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.lo==ud2.lo && ud1.hi==ud2.hi);
#else
f = FLAG(ud1==ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_equals)
NAME1("l2-d_u_equals")
NEXT_P1_5;
LABEL3(d_u_equals)
NAME1("l3-d_u_equals")
DO_GOTO;
}

LABEL(d_u_not_equals) /* du<> ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du<>")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.lo!=ud2.lo || ud1.hi!=ud2.hi);
#else
f = FLAG(ud1!=ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_not_equals)
NAME1("l2-d_u_not_equals")
NEXT_P1_5;
LABEL3(d_u_not_equals)
NAME1("l3-d_u_not_equals")
DO_GOTO;
}

LABEL(d_u_less_than) /* du< ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du<")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.hi==ud2.hi ? ud1.lo<ud2.lo : ud1.hi<ud2.hi);
#else
f = FLAG(ud1<ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_less_than)
NAME1("l2-d_u_less_than")
NEXT_P1_5;
LABEL3(d_u_less_than)
NAME1("l3-d_u_less_than")
DO_GOTO;
}

LABEL(d_u_greater_than) /* du> ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du>")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.hi==ud2.hi ? ud1.lo>ud2.lo : ud1.hi>ud2.hi);
#else
f = FLAG(ud1>ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_greater_than)
NAME1("l2-d_u_greater_than")
NEXT_P1_5;
LABEL3(d_u_greater_than)
NAME1("l3-d_u_greater_than")
DO_GOTO;
}

LABEL(d_u_less_or_equal) /* du<= ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du<=")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.hi==ud2.hi ? ud1.lo<=ud2.lo : ud1.hi<=ud2.hi);
#else
f = FLAG(ud1<=ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_less_or_equal)
NAME1("l2-d_u_less_or_equal")
NEXT_P1_5;
LABEL3(d_u_less_or_equal)
NAME1("l3-d_u_less_or_equal")
DO_GOTO;
}

LABEL(d_u_greater_or_equal) /* du>= ( ud1 ud2 -- f ) S0 -- S0  */
/*  */
NAME("du>=")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
MAYBE_UNUSED UDCell ud2;
Bool f;
NEXT_P0;
vm_twoCell2ud(sp[3], sp[2], ud1)
vm_twoCell2ud(sp[1], sp[0], ud2)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
fputs(" ud2=", vm_out); printarg_ud(ud2);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_CMP
f = FLAG(ud1.hi==ud2.hi ? ud1.lo>=ud2.lo : ud1.hi>=ud2.hi);
#else
f = FLAG(ud1>=ud2);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(d_u_greater_or_equal)
NAME1("l2-d_u_greater_or_equal")
NEXT_P1_5;
LABEL3(d_u_greater_or_equal)
NAME1("l3-d_u_greater_or_equal")
DO_GOTO;
}

GROUPADD(18)
#endif
LABEL(within) /* within ( u1 u2 u3 -- f ) S0 -- S0  */
/* u2<u3 and u1 in [u2,u3) or: u2>=u3 and u1 not in [u3,u2).  This works for
unsigned and signed numbers (but not a mixture).  Another way to think
about this word is to consider the numbers as a circle (wrapping
around from @code{max-u} to 0 for unsigned, and from @code{max-n} to
min-n for signed numbers); now consider the range from u2 towards
increasing numbers up to and excluding u3 (giving an empty range if
u2=u3); if u1 is in this range, @code{within} returns true. */
NAME("within")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
MAYBE_UNUSED UCell u3;
Bool f;
NEXT_P0;
vm_Cell2u(sp[2],u1);
vm_Cell2u(sp[1],u2);
vm_Cell2u(sp[0],u3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
fputs(" u3=", vm_out); printarg_u(u3);
}
#endif
sp += 2;
{
f = FLAG(u1-u2 < u3-u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(within)
NAME1("l2-within")
NEXT_P1_5;
LABEL3(within)
NAME1("l3-within")
DO_GOTO;
}

GROUPADD(1)
GROUP( stack, 165)
LABEL(useraddr) /* useraddr ( #u -- a_addr ) S0 -- S0  */
/*  */
NAME("useraddr")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell * a_addr;
NEXT_P0;
vm_Cell2u(IMM_ARG(IPTOS,305397800 ),u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
INC_IP(1);
sp += -1;
{
a_addr = (Cell *)(((Address)up)+u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(useraddr)
NAME1("l2-useraddr")
NEXT_P1_5;
LABEL3(useraddr)
NAME1("l3-useraddr")
DO_GOTO;
}

LABEL(up_store) /* up! ( a_addr -- ) S0 -- S0  */
/*  */
NAME("up!")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
gforth_UP=up=(user_area*)a_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(up_store)
NAME1("l2-up_store")
NEXT_P1_5;
LABEL3(up_store)
NAME1("l3-up_store")
DO_GOTO;
}

LABEL(sp_fetch) /* sp@ ( S:... -- a_addr ) S0 -- S0  */
/*  */
NAME("sp@")
{
DEF_CA
Cell * a_addr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
a_addr = sp;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
sp += -1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(sp_fetch)
NAME1("l2-sp_fetch")
NEXT_P1_5;
LABEL3(sp_fetch)
NAME1("l3-sp_fetch")
DO_GOTO;
}

LABEL(sp_store) /* sp! ( a_addr -- S:... ) S0 -- S0  */
/*  */
NAME("sp!")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
sp = a_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(sp_store)
NAME1("l2-sp_store")
NEXT_P1_5;
LABEL3(sp_store)
NAME1("l3-sp_store")
DO_GOTO;
}

LABEL(rp_fetch) /* rp@ ( -- a_addr ) S0 -- S0  */
/*  */
NAME("rp@")
{
DEF_CA
Cell * a_addr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
a_addr = rp;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(rp_fetch)
NAME1("l2-rp_fetch")
NEXT_P1_5;
LABEL3(rp_fetch)
NAME1("l3-rp_fetch")
DO_GOTO;
}

LABEL(rp_store) /* rp! ( a_addr -- ) S0 -- S0  */
/*  */
NAME("rp!")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
rp = a_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(rp_store)
NAME1("l2-rp_store")
NEXT_P1_5;
LABEL3(rp_store)
NAME1("l3-rp_store")
DO_GOTO;
}

GROUPADD(6)
#ifdef HAS_FLOATING
LABEL(fp_fetch) /* fp@ ( f:... -- f_addr ) S0 -- S0  */
/*  */
NAME("fp@")
{
DEF_CA
Float * f_addr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
f_addr = fp;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f_addr=", vm_out); printarg_f_(f_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f_2Cell(f_addr,sp[0]);
LABEL2(fp_fetch)
NAME1("l2-fp_fetch")
NEXT_P1_5;
LABEL3(fp_fetch)
NAME1("l3-fp_fetch")
DO_GOTO;
}

LABEL(fp_store) /* fp! ( f_addr -- f:... ) S0 -- S0  */
/*  */
NAME("fp!")
{
DEF_CA
MAYBE_UNUSED Float * f_addr;
NEXT_P0;
vm_Cell2f_(sp[0],f_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" f_addr=", vm_out); printarg_f_(f_addr);
}
#endif
sp += 1;
{
fp = f_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(fp_store)
NAME1("l2-fp_store")
NEXT_P1_5;
LABEL3(fp_store)
NAME1("l3-fp_store")
DO_GOTO;
}

GROUPADD(2)
#endif
LABEL(to_r) /* >r ( w -- R:w ) S0 -- S0  */
/*  */
NAME(">r")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
rp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,rp[0]);
LABEL2(to_r)
NAME1("l2-to_r")
NEXT_P1_5;
LABEL3(to_r)
NAME1("l3-to_r")
DO_GOTO;
}

LABEL(r_from) /* r> ( R:w -- w ) S0 -- S0  */
/*  */
NAME("r>")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(rp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += -1;
rp += 1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(r_from)
NAME1("l2-r_from")
NEXT_P1_5;
LABEL3(r_from)
NAME1("l3-r_from")
DO_GOTO;
}

LABEL(rdrop) /* rdrop ( R:w -- ) S0 -- S0  */
/*  */
NAME("rdrop")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(rp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
rp += 1;
{
ALIVE_DEBUGGING(w);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(rdrop)
NAME1("l2-rdrop")
NEXT_P1_5;
LABEL3(rdrop)
NAME1("l3-rdrop")
DO_GOTO;
}

LABEL(two_to_r) /* 2>r ( w1 w2 -- R:w1 R:w2 ) S0 -- S0  */
/*  */
NAME("2>r")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 2;
rp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,rp[1]);
vm_w2Cell(w2,rp[0]);
LABEL2(two_to_r)
NAME1("l2-two_to_r")
NEXT_P1_5;
LABEL3(two_to_r)
NAME1("l3-two_to_r")
DO_GOTO;
}

LABEL(two_r_from) /* 2r> ( R:w1 R:w2 -- w1 w2 ) S0 -- S0  */
/*  */
NAME("2r>")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[1],w1);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -2;
rp += 2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_r_from)
NAME1("l2-two_r_from")
NEXT_P1_5;
LABEL3(two_r_from)
NAME1("l3-two_r_from")
DO_GOTO;
}

LABEL(two_r_fetch) /* 2r@ ( R:w1 R:w2 -- R:w1 R:w2 w1 w2 ) S0 -- S0  */
/*  */
NAME("2r@")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[1],w1);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_r_fetch)
NAME1("l2-two_r_fetch")
NEXT_P1_5;
LABEL3(two_r_fetch)
NAME1("l3-two_r_fetch")
DO_GOTO;
}

LABEL(two_r_drop) /* 2rdrop ( R:w1 R:w2 -- ) S0 -- S0  */
/*  */
NAME("2rdrop")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(rp[1],w1);
vm_Cell2w(rp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
rp += 2;
{
ALIVE_DEBUGGING(w1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(two_r_drop)
NAME1("l2-two_r_drop")
NEXT_P1_5;
LABEL3(two_r_drop)
NAME1("l3-two_r_drop")
DO_GOTO;
}

LABEL(over) /* over ( w1 w2 -- w1 w2 w1 ) S0 -- S0  */
/*  */
NAME("over")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[0]);
LABEL2(over)
NAME1("l2-over")
NEXT_P1_5;
LABEL3(over)
NAME1("l3-over")
DO_GOTO;
}

LABEL(drop) /* drop ( w -- ) S0 -- S0  */
/*  */
NAME("drop")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
{
ALIVE_DEBUGGING(w);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(drop)
NAME1("l2-drop")
NEXT_P1_5;
LABEL3(drop)
NAME1("l3-drop")
DO_GOTO;
}

LABEL(swap) /* swap ( w1 w2 -- w2 w1 ) S0 -- S0  */
/*  */
NAME("swap")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w2,sp[1]);
vm_w2Cell(w1,sp[0]);
LABEL2(swap)
NAME1("l2-swap")
NEXT_P1_5;
LABEL3(swap)
NAME1("l3-swap")
DO_GOTO;
}

LABEL(dupe) /* dup ( w -- w w ) S0 -- S0  */
/*  */
NAME("dup")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(dupe)
NAME1("l2-dupe")
NEXT_P1_5;
LABEL3(dupe)
NAME1("l3-dupe")
DO_GOTO;
}

LABEL(rote) /* rot ( w1 w2 w3 -- w2 w3 w1 ) S0 -- S0  */
/*  */
NAME("rot")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
NEXT_P0;
vm_Cell2w(sp[2],w1);
vm_Cell2w(sp[1],w2);
vm_Cell2w(sp[0],w3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w2,sp[2]);
vm_w2Cell(w3,sp[1]);
vm_w2Cell(w1,sp[0]);
LABEL2(rote)
NAME1("l2-rote")
NEXT_P1_5;
LABEL3(rote)
NAME1("l3-rote")
DO_GOTO;
}

LABEL(not_rote) /* -rot ( w1 w2 w3 -- w3 w1 w2 ) S0 -- S0  */
/*  */
NAME("-rot")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
NEXT_P0;
vm_Cell2w(sp[2],w1);
vm_Cell2w(sp[1],w2);
vm_Cell2w(sp[0],w3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w3,sp[2]);
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(not_rote)
NAME1("l2-not_rote")
NEXT_P1_5;
LABEL3(not_rote)
NAME1("l3-not_rote")
DO_GOTO;
}

LABEL(nip) /* nip ( w1 w2 -- w2 ) S0 -- S0  */
/*  */
NAME("nip")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w2,sp[0]);
LABEL2(nip)
NAME1("l2-nip")
NEXT_P1_5;
LABEL3(nip)
NAME1("l3-nip")
DO_GOTO;
}

LABEL(tuck) /* tuck ( w1 w2 -- w2 w1 w2 ) S0 -- S0  */
/*  */
NAME("tuck")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w2,sp[2]);
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(tuck)
NAME1("l2-tuck")
NEXT_P1_5;
LABEL3(tuck)
NAME1("l3-tuck")
DO_GOTO;
}

LABEL(question_dupe) /* ?dup ( w -- S:... w ) S0 -- S0  */
/* Actually the stack effect is: @code{( w -- 0 | w w )}.  It performs a
@code{dup} if w is nonzero. */
NAME("?dup")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
{
if (w!=0) {
  *--sp = w;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
sp += -1;
vm_w2Cell(w,sp[0]);
LABEL2(question_dupe)
NAME1("l2-question_dupe")
NEXT_P1_5;
LABEL3(question_dupe)
NAME1("l3-question_dupe")
DO_GOTO;
}

LABEL(pick) /* pick ( S:... u -- S:... w ) S0 -- S0  */
/* Actually the stack effect is @code{ x0 ... xu u -- x0 ... xu x0 }. */
NAME("pick")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell w;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
w = sp[u];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
sp += -1;
vm_w2Cell(w,sp[0]);
LABEL2(pick)
NAME1("l2-pick")
NEXT_P1_5;
LABEL3(pick)
NAME1("l3-pick")
DO_GOTO;
}

LABEL(third) /* third ( w1 w2 w3 -- w1 w2 w3 w1 ) S0 -- S0  */
/*  */
NAME("third")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
NEXT_P0;
vm_Cell2w(sp[2],w1);
vm_Cell2w(sp[1],w2);
vm_Cell2w(sp[0],w3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[0]);
LABEL2(third)
NAME1("l2-third")
NEXT_P1_5;
LABEL3(third)
NAME1("l3-third")
DO_GOTO;
}

LABEL(fourth) /* fourth ( w1 w2 w3 w4 -- w1 w2 w3 w4 w1 ) S0 -- S0  */
/*  */
NAME("fourth")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(sp[3],w1);
vm_Cell2w(sp[2],w2);
vm_Cell2w(sp[1],w3);
vm_Cell2w(sp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
sp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[0]);
LABEL2(fourth)
NAME1("l2-fourth")
NEXT_P1_5;
LABEL3(fourth)
NAME1("l3-fourth")
DO_GOTO;
}

LABEL(two_drop) /* 2drop ( w1 w2 -- ) S0 -- S0  */
/*  */
NAME("2drop")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += 2;
{
ALIVE_DEBUGGING(w1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(two_drop)
NAME1("l2-two_drop")
NEXT_P1_5;
LABEL3(two_drop)
NAME1("l3-two_drop")
DO_GOTO;
}

LABEL(two_dupe) /* 2dup ( w1 w2 -- w1 w2 w1 w2 ) S0 -- S0  */
/*  */
NAME("2dup")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
NEXT_P0;
vm_Cell2w(sp[1],w1);
vm_Cell2w(sp[0],w2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
}
#endif
sp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_dupe)
NAME1("l2-two_dupe")
NEXT_P1_5;
LABEL3(two_dupe)
NAME1("l3-two_dupe")
DO_GOTO;
}

LABEL(two_over) /* 2over ( w1 w2 w3 w4 -- w1 w2 w3 w4 w1 w2 ) S0 -- S0  */
/*  */
NAME("2over")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(sp[3],w1);
vm_Cell2w(sp[2],w2);
vm_Cell2w(sp[1],w3);
vm_Cell2w(sp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
sp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_over)
NAME1("l2-two_over")
NEXT_P1_5;
LABEL3(two_over)
NAME1("l3-two_over")
DO_GOTO;
}

LABEL(two_swap) /* 2swap ( w1 w2 w3 w4 -- w3 w4 w1 w2 ) S0 -- S0  */
/*  */
NAME("2swap")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(sp[3],w1);
vm_Cell2w(sp[2],w2);
vm_Cell2w(sp[1],w3);
vm_Cell2w(sp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w3,sp[3]);
vm_w2Cell(w4,sp[2]);
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_swap)
NAME1("l2-two_swap")
NEXT_P1_5;
LABEL3(two_swap)
NAME1("l3-two_swap")
DO_GOTO;
}

LABEL(two_rote) /* 2rot ( w1 w2 w3 w4 w5 w6 -- w3 w4 w5 w6 w1 w2 ) S0 -- S0  */
/*  */
NAME("2rot")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
MAYBE_UNUSED Cell w5;
MAYBE_UNUSED Cell w6;
NEXT_P0;
vm_Cell2w(sp[5],w1);
vm_Cell2w(sp[4],w2);
vm_Cell2w(sp[3],w3);
vm_Cell2w(sp[2],w4);
vm_Cell2w(sp[1],w5);
vm_Cell2w(sp[0],w6);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
fputs(" w5=", vm_out); printarg_w(w5);
fputs(" w6=", vm_out); printarg_w(w6);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w3,sp[5]);
vm_w2Cell(w4,sp[4]);
vm_w2Cell(w5,sp[3]);
vm_w2Cell(w6,sp[2]);
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_rote)
NAME1("l2-two_rote")
NEXT_P1_5;
LABEL3(two_rote)
NAME1("l3-two_rote")
DO_GOTO;
}

LABEL(two_nip) /* 2nip ( w1 w2 w3 w4 -- w3 w4 ) S0 -- S0  */
/*  */
NAME("2nip")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(sp[3],w1);
vm_Cell2w(sp[2],w2);
vm_Cell2w(sp[1],w3);
vm_Cell2w(sp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
sp += 2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w3,sp[1]);
vm_w2Cell(w4,sp[0]);
LABEL2(two_nip)
NAME1("l2-two_nip")
NEXT_P1_5;
LABEL3(two_nip)
NAME1("l3-two_nip")
DO_GOTO;
}

LABEL(two_tuck) /* 2tuck ( w1 w2 w3 w4 -- w3 w4 w1 w2 w3 w4 ) S0 -- S0  */
/*  */
NAME("2tuck")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell w3;
MAYBE_UNUSED Cell w4;
NEXT_P0;
vm_Cell2w(sp[3],w1);
vm_Cell2w(sp[2],w2);
vm_Cell2w(sp[1],w3);
vm_Cell2w(sp[0],w4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" w3=", vm_out); printarg_w(w3);
fputs(" w4=", vm_out); printarg_w(w4);
}
#endif
sp += -2;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w3,sp[5]);
vm_w2Cell(w4,sp[4]);
vm_w2Cell(w1,sp[3]);
vm_w2Cell(w2,sp[2]);
vm_w2Cell(w3,sp[1]);
vm_w2Cell(w4,sp[0]);
LABEL2(two_tuck)
NAME1("l2-two_tuck")
NEXT_P1_5;
LABEL3(two_tuck)
NAME1("l3-two_tuck")
DO_GOTO;
}

LABEL(user_fetch) /* user@ ( #u -- w ) S0 -- S0  */
/*  */
NAME("user@")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell w;
NEXT_P0;
vm_Cell2u(IMM_ARG(IPTOS,305397801 ),u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
INC_IP(1);
sp += -1;
{
w = *(Cell *)(((Address)up)+u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(user_fetch)
NAME1("l2-user_fetch")
NEXT_P1_5;
LABEL3(user_fetch)
NAME1("l3-user_fetch")
DO_GOTO;
}

LABEL(sps_fetch) /* sps@ ( -- w ) S0 -- S0  */
/*  */
NAME("sps@")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = (Cell)SPs;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(sps_fetch)
NAME1("l2-sps_fetch")
NEXT_P1_5;
LABEL3(sps_fetch)
NAME1("l3-sps_fetch")
DO_GOTO;
}

GROUPADD(28)
GROUP( memory, 201)
LABEL(fetch) /* @ ( a_addr -- w ) S0 -- S0  */
/* @i{w} is the cell stored at @i{a_addr}. */
NAME("@")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
Cell w;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
{
w = *a_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch)
NAME1("l2-fetch")
NEXT_P1_5;
LABEL3(fetch)
NAME1("l3-fetch")
DO_GOTO;
}

LABEL(lit_fetch) /* lit@ ( #a_addr -- w ) S0 -- S0  */
/*  */
NAME("lit@")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
Cell w;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397802 ),a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
INC_IP(1);
sp += -1;
{
w = *a_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(lit_fetch)
NAME1("l2-lit_fetch")
NEXT_P1_5;
LABEL3(lit_fetch)
NAME1("l3-lit_fetch")
DO_GOTO;
}

LABEL(store) /* ! ( w a_addr -- ) S0 -- S0  */
/* Store @i{w} into the cell at @i{a-addr}. */
NAME("!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 2;
{
*a_addr = w;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(store)
NAME1("l2-store")
NEXT_P1_5;
LABEL3(store)
NAME1("l3-store")
DO_GOTO;
}

LABEL(plus_store) /* +! ( n a_addr -- ) S0 -- S0  */
/* Add @i{n} to the cell at @i{a-addr}. */
NAME("+!")
{
DEF_CA
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2n(sp[1],n);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 2;
{
*a_addr += n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(plus_store)
NAME1("l2-plus_store")
NEXT_P1_5;
LABEL3(plus_store)
NAME1("l3-plus_store")
DO_GOTO;
}

LABEL(c_fetch) /* c@ ( c_addr -- c ) S0 -- S0  */
/* @i{c} is the char stored at @i{c_addr}. */
NAME("c@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Char c;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
c = *c_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c=", vm_out); printarg_c(c);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c2Cell(c,sp[0]);
LABEL2(c_fetch)
NAME1("l2-c_fetch")
NEXT_P1_5;
LABEL3(c_fetch)
NAME1("l3-c_fetch")
DO_GOTO;
}

LABEL(c_store) /* c! ( c c_addr -- ) S0 -- S0  */
/* Store @i{c} into the char at @i{c-addr}. */
NAME("c!")
{
DEF_CA
MAYBE_UNUSED Char c;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2c(sp[1],c);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c=", vm_out); printarg_c(c);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
*c_addr = c;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(c_store)
NAME1("l2-c_store")
NEXT_P1_5;
LABEL3(c_store)
NAME1("l3-c_store")
DO_GOTO;
}

LABEL(two_store) /* 2! ( w1 w2 a_addr -- ) S0 -- S0  */
/* Store @i{w2} into the cell at @i{c-addr} and @i{w1} into the next cell. */
NAME("2!")
{
DEF_CA
MAYBE_UNUSED Cell w1;
MAYBE_UNUSED Cell w2;
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2w(sp[2],w1);
vm_Cell2w(sp[1],w2);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 3;
{
a_addr[0] = w2;
a_addr[1] = w1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(two_store)
NAME1("l2-two_store")
NEXT_P1_5;
LABEL3(two_store)
NAME1("l3-two_store")
DO_GOTO;
}

LABEL(two_fetch) /* 2@ ( a_addr -- w1 w2 ) S0 -- S0  */
/* @i{w2} is the content of the cell stored at @i{a-addr}, @i{w1} is
the content of the next cell. */
NAME("2@")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
Cell w1;
Cell w2;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += -1;
{
w2 = a_addr[0];
w1 = a_addr[1];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w1=", vm_out); printarg_w(w1);
fputs(" w2=", vm_out); printarg_w(w2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w1,sp[1]);
vm_w2Cell(w2,sp[0]);
LABEL2(two_fetch)
NAME1("l2-two_fetch")
NEXT_P1_5;
LABEL3(two_fetch)
NAME1("l3-two_fetch")
DO_GOTO;
}

LABEL(cell_plus) /* cell+ ( a_addr1 -- a_addr2 ) S0 -- S0  */
/* @code{1 cells +} */
NAME("cell+")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr1;
Cell * a_addr2;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr1=", vm_out); printarg_a_(a_addr1);
}
#endif
{
a_addr2 = a_addr1+1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr2=", vm_out); printarg_a_(a_addr2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr2,sp[0]);
LABEL2(cell_plus)
NAME1("l2-cell_plus")
NEXT_P1_5;
LABEL3(cell_plus)
NAME1("l3-cell_plus")
DO_GOTO;
}

LABEL(cells) /* cells ( n1 -- n2 ) S0 -- S0  */
/*  @i{n2} is the number of address units of @i{n1} cells. */
NAME("cells")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 * sizeof(Cell);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(cells)
NAME1("l2-cells")
NEXT_P1_5;
LABEL3(cells)
NAME1("l3-cells")
DO_GOTO;
}

LABEL(char_plus) /* char+ ( c_addr1 -- c_addr2 ) S0 -- S0  */
/* @code{1 chars +}. */
NAME("char+")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
Char * c_addr2;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
}
#endif
{
c_addr2 = c_addr1 + 1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[0]);
LABEL2(char_plus)
NAME1("l2-char_plus")
NEXT_P1_5;
LABEL3(char_plus)
NAME1("l3-char_plus")
DO_GOTO;
}

LABEL(paren_chars) /* (chars) ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("(chars)")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 * sizeof(Char);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(paren_chars)
NAME1("l2-paren_chars")
NEXT_P1_5;
LABEL3(paren_chars)
NAME1("l3-paren_chars")
DO_GOTO;
}

LABEL(count) /* count ( c_addr1 -- c_addr2 u ) S0 -- S0  */
/* @i{c-addr2} is the first character and @i{u} the length of the
counted string at @i{c-addr1}. */
NAME("count")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
Char * c_addr2;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
}
#endif
sp += -1;
{
u = *c_addr1;
c_addr2 = c_addr1+1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u,sp[0]);
LABEL2(count)
NAME1("l2-count")
NEXT_P1_5;
LABEL3(count)
NAME1("l3-count")
DO_GOTO;
}

LABEL(cell_divide) /* cell/ ( n1 -- n2 ) S0 -- S0  */
/* @i{n2} is the number of cells that fit into @i{n1} */
NAME("cell/")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 >> (sizeof(Cell) == 8 ? 3 : 2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(cell_divide)
NAME1("l2-cell_divide")
NEXT_P1_5;
LABEL3(cell_divide)
NAME1("l3-cell_divide")
DO_GOTO;
}

LABEL(cell_minus) /* cell- ( a_addr1 -- a_addr2 ) S0 -- S0  */
/* @code{1 cells -} */
NAME("cell-")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr1;
Cell * a_addr2;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr1=", vm_out); printarg_a_(a_addr1);
}
#endif
{
a_addr2 = a_addr1-1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr2=", vm_out); printarg_a_(a_addr2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr2,sp[0]);
LABEL2(cell_minus)
NAME1("l2-cell_minus")
NEXT_P1_5;
LABEL3(cell_minus)
NAME1("l3-cell_minus")
DO_GOTO;
}

LABEL(one_plus_store) /* inc# ( #a_addr -- ) S0 -- S0  */
/*  */
NAME("inc#")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397803 ),a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
INC_IP(1);
{
*a_addr += 1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(one_plus_store)
NAME1("l2-one_plus_store")
NEXT_P1_5;
LABEL3(one_plus_store)
NAME1("l3-one_plus_store")
DO_GOTO;
}

GROUPADD(16)
GROUP( compiler, 217)
GROUPADD(0)
#ifdef HAS_F83HEADERSTRING
LABEL(paren_f83find) /* (f83find) ( c_addr u f83name1 -- f83name2 ) S0 -- S0  */
/*  */
NAME("(f83find)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED struct F83Name * f83name1;
struct F83Name * f83name2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2f83name(sp[0],f83name1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" f83name1=", vm_out); printarg_f83name(f83name1);
}
#endif
sp += 2;
{
for (; f83name1 != NULL; f83name1 = (struct F83Name *)(f83name1->next))
  if ((UCell)F83NAME_COUNT(f83name1)==u &&
      memcasecmp(c_addr, f83name1->name, u)== 0 /* or inline? */)
    break;
f83name2=f83name1;
#ifdef DEBUG
fprintf(stderr, "F83find ");
fwrite(c_addr, u, 1, stderr);
fprintf(stderr, " found %08x\n", f83name2); 
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f83name2=", vm_out); printarg_f83name(f83name2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f83name2Cell(f83name2,sp[0]);
LABEL2(paren_f83find)
NAME1("l2-paren_f83find")
NEXT_P1_5;
LABEL3(paren_f83find)
NAME1("l3-paren_f83find")
DO_GOTO;
}

GROUPADD(1)
#else /* 218 */
LABEL(paren_listlfind) /* (listlfind) ( c_addr u longname1 -- longname2 ) S0 -- S0  */
/*  */
NAME("(listlfind)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED struct Longname * longname1;
struct Longname * longname2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2longname(sp[0],longname1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" longname1=", vm_out); printarg_longname(longname1);
}
#endif
sp += 2;
{
longname2=listlfind(c_addr, u, longname1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" longname2=", vm_out); printarg_longname(longname2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_longname2Cell(longname2,sp[0]);
LABEL2(paren_listlfind)
NAME1("l2-paren_listlfind")
NEXT_P1_5;
LABEL3(paren_listlfind)
NAME1("l3-paren_listlfind")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_HASH
LABEL(paren_hashlfind) /* (hashlfind) ( c_addr u a_addr -- longname2 ) S0 -- S0  */
/*  */
NAME("(hashlfind)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell * a_addr;
struct Longname * longname2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 2;
{
longname2 = hashlfind(c_addr, u, a_addr);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" longname2=", vm_out); printarg_longname(longname2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_longname2Cell(longname2,sp[0]);
LABEL2(paren_hashlfind)
NAME1("l2-paren_hashlfind")
NEXT_P1_5;
LABEL3(paren_hashlfind)
NAME1("l3-paren_hashlfind")
DO_GOTO;
}

LABEL(paren_tablelfind) /* (tablelfind) ( c_addr u a_addr -- longname2 ) S0 -- S0  */
/* A case-sensitive variant of @code{(hashfind)} */
NAME("(tablelfind)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell * a_addr;
struct Longname * longname2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 2;
{
longname2 = tablelfind(c_addr, u, a_addr);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" longname2=", vm_out); printarg_longname(longname2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_longname2Cell(longname2,sp[0]);
LABEL2(paren_tablelfind)
NAME1("l2-paren_tablelfind")
NEXT_P1_5;
LABEL3(paren_tablelfind)
NAME1("l3-paren_tablelfind")
DO_GOTO;
}

LABEL(paren_hashkey1) /* (hashkey1) ( c_addr u ubits -- ukey ) S0 -- S0  */
/* ukey is the hash key for the string c_addr u fitting in ubits bits */
NAME("(hashkey1)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED UCell ubits;
UCell ukey;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2u(sp[0],ubits);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" ubits=", vm_out); printarg_u(ubits);
}
#endif
sp += 2;
{
ukey = hashkey1(c_addr, u, ubits);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ukey=", vm_out); printarg_u(ukey);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(ukey,sp[0]);
LABEL2(paren_hashkey1)
NAME1("l2-paren_hashkey1")
NEXT_P1_5;
LABEL3(paren_hashkey1)
NAME1("l3-paren_hashkey1")
DO_GOTO;
}

LABEL(paren_hashkey2) /* (hashkey2) ( c_addr u ubits -- ukey ) S0 -- S0  */
/* A faster replacement for @code{(hashkey1)} */
NAME("(hashkey2)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED UCell ubits;
UCell ukey;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2u(sp[0],ubits);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" ubits=", vm_out); printarg_u(ubits);
}
#endif
sp += 2;
{
ukey = hashkey2a(c_addr,u) >> (8*sizeof(UCell) - ubits);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ukey=", vm_out); printarg_u(ukey);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(ukey,sp[0]);
LABEL2(paren_hashkey2)
NAME1("l2-paren_hashkey2")
NEXT_P1_5;
LABEL3(paren_hashkey2)
NAME1("l3-paren_hashkey2")
DO_GOTO;
}

LABEL(hashkey2) /* hashkey2 ( c_addr u f a_addr -- ) S0 -- S0  */
/* Compute a 128 bit hash key of the string c_addr u, starting with the
key in a_addr.  If f is true, compute case insensitive. */
NAME("hashkey2")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Bool f;
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2c_(sp[3],c_addr);
vm_Cell2u(sp[2],u);
vm_Cell2f(sp[1],f);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" f=", vm_out); printarg_f(f);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 4;
{
hashkey2(c_addr, u, f ? 0x2020202020202020LL : 0LL, (hash128*)a_addr);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(hashkey2)
NAME1("l2-hashkey2")
NEXT_P1_5;
LABEL3(hashkey2)
NAME1("l3-hashkey2")
DO_GOTO;
}

GROUPADD(5)
#endif
GROUPADD(0)
#endif
LABEL(paren_parse_white) /* (parse-white) ( c_addr1 u1 -- c_addr2 u2 ) S0 -- S0  */
/*  */
NAME("(parse-white)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr1);
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
struct Cellpair r=parse_white(c_addr1, u1);
c_addr2 = (Char *)(r.n1);
u2 = r.n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(paren_parse_white)
NAME1("l2-paren_parse_white")
NEXT_P1_5;
LABEL3(paren_parse_white)
NAME1("l3-paren_parse_white")
DO_GOTO;
}

LABEL(scan) /* scan ( c_addr1 u1 c -- c_addr2 u2 ) S0 -- S0  */
/* Skip all characters not equal to c.  The result starts with c or is empty. */
NAME("scan")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char c;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr1);
vm_Cell2u(sp[1],u1);
vm_Cell2c(sp[0],c);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c=", vm_out); printarg_c(c);
}
#endif
sp += 1;
{
for (c_addr2=c_addr1; c_addr2!=c_addr1+u1 && *c_addr2 != c; c_addr2++)
  ;
u2 = (c_addr1+u1)-c_addr2;
#if 0
Char *c_addr3=memchr(c_addr1, c, u1);
if (u2!=0 && c_addr3!=c_addr2)
  fprintf(stderr,"\nscan: %p %ld %d -- %p %ld (memchr -> %p)",c_addr1,u1,c,c_addr2,u2,c_addr3);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(scan)
NAME1("l2-scan")
NEXT_P1_5;
LABEL3(scan)
NAME1("l3-scan")
DO_GOTO;
}

LABEL(skip) /* skip ( c_addr1 u1 c -- c_addr2 u2 ) S0 -- S0  */
/* Skip all characters equal to c.  The result starts with the first
non-c character, or it is empty. */
NAME("skip")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char c;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr1);
vm_Cell2u(sp[1],u1);
vm_Cell2c(sp[0],c);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c=", vm_out); printarg_c(c);
}
#endif
sp += 1;
{
for (c_addr2=c_addr1; c_addr2!=c_addr1+u1 && *c_addr2 == c; c_addr2++)
  ;
u2 = (c_addr1+u1)-c_addr2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(skip)
NAME1("l2-skip")
NEXT_P1_5;
LABEL3(skip)
NAME1("l3-skip")
DO_GOTO;
}

LABEL(aligned) /* aligned ( c_addr -- a_addr ) S0 -- S0  */
/*  @i{a-addr} is the first aligned address greater than or equal to @i{c-addr}. */
NAME("aligned")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Cell * a_addr;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
a_addr = (Cell *)((((Cell)c_addr)+(sizeof(Cell)-1))&(-sizeof(Cell)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(aligned)
NAME1("l2-aligned")
NEXT_P1_5;
LABEL3(aligned)
NAME1("l3-aligned")
DO_GOTO;
}

LABEL(f_aligned) /* faligned ( c_addr -- f_addr ) S0 -- S0  */
/*  @i{f-addr} is the first float-aligned address greater than or equal to @i{c-addr}. */
NAME("faligned")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Float * f_addr;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
f_addr = (Float *)((((Cell)c_addr)+(sizeof(Float)-1))&(-sizeof(Float)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f_addr=", vm_out); printarg_f_(f_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f_2Cell(f_addr,sp[0]);
LABEL2(f_aligned)
NAME1("l2-f_aligned")
NEXT_P1_5;
LABEL3(f_aligned)
NAME1("l3-f_aligned")
DO_GOTO;
}

LABEL(threading_method) /* threading-method ( -- n ) S0 -- S0  */
/* 0 if the engine is direct threaded. Note that this may change during
the lifetime of an image. */
NAME("threading-method")
{
DEF_CA
Cell n;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
#if defined(DOUBLY_INDIRECT)
n=2;
#else
# if defined(DIRECT_THREADED)
n=0;
# else
n=1;
# endif
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(threading_method)
NAME1("l2-threading_method")
NEXT_P1_5;
LABEL3(threading_method)
NAME1("l3-threading_method")
DO_GOTO;
}

LABEL(debugging_method) /* debugging-method ( -- n ) S0 -- S0  */
/* true if the engine supports debugging */
NAME("debugging-method")
{
DEF_CA
Cell n;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
#if defined(GFORTH_DEBUGGING)
n=-1;
#else
n=0;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(debugging_method)
NAME1("l2-debugging_method")
NEXT_P1_5;
LABEL3(debugging_method)
NAME1("l3-debugging_method")
DO_GOTO;
}

GROUPADD(7)
GROUP( hostos, 231)
LABEL(paren_key_file) /* (key-file) ( wfileid -- n ) S0 -- S0  */
/* Read one character @i{n} from @i{wfileid}.  This word disables
buffering for @i{wfileid}.  If you want to read characters from a
terminal in non-canonical (raw) mode, you have to put the terminal in
non-canonical mode yourself (using the C interface); the exception is
@code{stdin}: Gforth automatically puts it into non-canonical mode.  If
an error occurred, a negative ior is returned instead of a positive byte. */
NAME("(key-file)")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Cell n;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
#ifdef HAS_FILE
fflush(stdout);
n = key((FILE*)wfileid);
#else
n = key(stdin);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(paren_key_file)
NAME1("l2-paren_key_file")
NEXT_P1_5;
LABEL3(paren_key_file)
NAME1("l3-paren_key_file")
DO_GOTO;
}

LABEL(key_q_file) /* key?-file ( wfileid -- f ) S0 -- S0  */
/* @i{f} is true if at least one character can be read from @i{wfileid}
without blocking.  If you also want to use @code{read-file} or
@code{read-line} on the file, you have to call @code{key?-file} or
@code{key-file} first (these two words disable buffering). */
NAME("key?-file")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Bool f;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
#ifdef HAS_FILE
fflush(stdout);
f = key_query((FILE*)wfileid);
#else
f = key_query(stdin);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(key_q_file)
NAME1("l2-key_q_file")
NEXT_P1_5;
LABEL3(key_q_file)
NAME1("l3-key_q_file")
DO_GOTO;
}

LABEL(stdin) /* stdin ( -- wfileid ) S0 -- S0  */
/* The standard input file of the Gforth process. */
NAME("stdin")
{
DEF_CA
Cell wfileid;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
wfileid = (Cell)stdin;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[0]);
LABEL2(stdin)
NAME1("l2-stdin")
NEXT_P1_5;
LABEL3(stdin)
NAME1("l3-stdin")
DO_GOTO;
}

LABEL(stdout) /* stdout ( -- wfileid ) S0 -- S0  */
/* The standard output file of the Gforth process. */
NAME("stdout")
{
DEF_CA
Cell wfileid;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
wfileid = (Cell)stdout;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[0]);
LABEL2(stdout)
NAME1("l2-stdout")
NEXT_P1_5;
LABEL3(stdout)
NAME1("l3-stdout")
DO_GOTO;
}

LABEL(stderr) /* stderr ( -- wfileid ) S0 -- S0  */
/* The standard error output file of the Gforth process. */
NAME("stderr")
{
DEF_CA
Cell wfileid;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
wfileid = (Cell)stderr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[0]);
LABEL2(stderr)
NAME1("l2-stderr")
NEXT_P1_5;
LABEL3(stderr)
NAME1("l3-stderr")
DO_GOTO;
}

LABEL(term_prep_q) /* term-prep? ( -- f ) S0 -- S0  */
/*  */
NAME("term-prep?")
{
DEF_CA
Bool f;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
f=FLAG(terminal_prepped);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(term_prep_q)
NAME1("l2-term_prep_q")
NEXT_P1_5;
LABEL3(term_prep_q)
NAME1("l3-term_prep_q")
DO_GOTO;
}

GROUPADD(6)
#ifdef HAS_OS
LABEL(paren_form) /* (form) ( -- urows ucols ) S0 -- S0  */
/* The number of lines and columns in the terminal. These numbers may
change with the window size.  Note that it depends on the OS whether
this reflects the actual size and changes with the window size
(currently only on Unix-like OSs).  On other OSs you just get a
default, and can tell Gforth the terminal size by setting the
environment variables @code{COLUMNS} and @code{LINES} before starting
Gforth. */
NAME("(form)")
{
DEF_CA
UCell urows;
UCell ucols;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -2;
{
/* we could block SIGWINCH here to get a consistent size, but I don't
 think this is necessary or always beneficial */
urows=rows;
ucols=cols;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" urows=", vm_out); printarg_u(urows);
fputs(" ucols=", vm_out); printarg_u(ucols);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(urows,sp[1]);
vm_u2Cell(ucols,sp[0]);
LABEL2(paren_form)
NAME1("l2-paren_form")
NEXT_P1_5;
LABEL3(paren_form)
NAME1("l3-paren_form")
DO_GOTO;
}

LABEL(isatty) /* isatty ( wfileid -- f ) S0 -- S0  */
/* checks if fd is a (pseudo-)terminal */
NAME("isatty")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Bool f;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
f = FLAG(isatty( fileno((FILE*)wfileid) ));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(isatty)
NAME1("l2-isatty")
NEXT_P1_5;
LABEL3(isatty)
NAME1("l3-isatty")
DO_GOTO;
}

LABEL(isfg) /* isfg ( wfileid -- f ) S0 -- S0  */
/* check if fd is controlled by us (we are the foreground process) */
NAME("isfg")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Bool f;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
pid_t fg = tcgetpgrp( fileno((FILE*)wfileid) );
if (fg == -1) {
   f=-1; // non-terminal file, is ours
} else
   f=FLAG(fg == getpgrp());
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(isfg)
NAME1("l2-isfg")
NEXT_P1_5;
LABEL3(isfg)
NAME1("l3-isfg")
DO_GOTO;
}

LABEL(wcwidth) /* wcwidth ( u -- n ) S0 -- S0  */
/* The number of fixed-width characters per unicode character u */
NAME("wcwidth")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell n;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
n = wcwidth(u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(wcwidth)
NAME1("l2-wcwidth")
NEXT_P1_5;
LABEL3(wcwidth)
NAME1("l3-wcwidth")
DO_GOTO;
}

LABEL(flush_icache) /* flush-icache ( c_addr u -- ) S0 -- S0  */
/* Make sure that the instruction cache of the processor (if there is
one) does not contain stale data at @i{c-addr} and @i{u} bytes
afterwards. @code{END-CODE} performs a @code{flush-icache}
automatically. Caveat: @code{flush-icache} might not work on your
installation; this is usually the case if direct threading is not
supported on your machine (take a look at your @file{machine.h}) and
your machine has a separate instruction cache. In such cases,
@code{flush-icache} does nothing instead of flushing the instruction
cache. */
NAME("flush-icache")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 2;
{
FLUSH_ICACHE((caddr_t)c_addr,u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(flush_icache)
NAME1("l2-flush_icache")
NEXT_P1_5;
LABEL3(flush_icache)
NAME1("l3-flush_icache")
DO_GOTO;
}

LABEL(paren_bye) /* (bye) ( n -- ) S0 -- S0  */
/*  */
NAME("(bye)")
{
DEF_CA
MAYBE_UNUSED Cell n;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
SUPER_END;
gforth_FP=fp;
gforth_SP=sp;
gforth_RP=rp;
gforth_LP=lp;
return (Label *)n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(paren_bye)
NAME1("l2-paren_bye")
NEXT_P1_5;
LABEL3(paren_bye)
NAME1("l3-paren_bye")
DO_GOTO;
}

LABEL(paren_system) /* (system) ( c_addr u -- wretval wior ) S0 -- S0  */
/*  */
NAME("(system)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell wretval;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
wretval = gforth_system(c_addr, u);  
wior = IOR(wretval==-1 || (wretval==127 && errno != 0));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wretval=", vm_out); printarg_w(wretval);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wretval,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(paren_system)
NAME1("l2-paren_system")
NEXT_P1_5;
LABEL3(paren_system)
NAME1("l3-paren_system")
DO_GOTO;
}

LABEL(getenv) /* getenv ( c_addr1 u1 -- c_addr2 u2 ) S0 -- S0  */
/* The string @i{c-addr1 u1} specifies an environment variable. The string @i{c-addr2 u2}
is the host operating system's expansion of that environment variable. If the
environment variable does not exist, @i{c-addr2 u2} specifies a string 0 characters
in length. */
NAME("getenv")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr1);
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
/* close ' to keep fontify happy */
char * string = cstr(c_addr1,u1);
c_addr2 = (Char *)getenv(string);
u2 = (c_addr2 == NULL ? 0 : strlen((char *)c_addr2));
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(getenv)
NAME1("l2-getenv")
NEXT_P1_5;
LABEL3(getenv)
NAME1("l3-getenv")
DO_GOTO;
}

LABEL(open_pipe) /* open-pipe ( c_addr u wfam -- wfileid wior ) S0 -- S0  */
/*  */
NAME("open-pipe")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell wfam;
Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2w(sp[0],wfam);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" wfam=", vm_out); printarg_w(wfam);
}
#endif
sp += 1;
{
char * string = cstr(c_addr,u);
fflush(stdout);
wfileid=(Cell)popen(string,pfileattr[wfam]); /* ~ expansion of 1st arg? */
wior = IOR(wfileid==0); /* !! the man page says that errno is not set reliably */
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(open_pipe)
NAME1("l2-open_pipe")
NEXT_P1_5;
LABEL3(open_pipe)
NAME1("l3-open_pipe")
DO_GOTO;
}

LABEL(close_pipe) /* close-pipe ( wfileid -- wretval wior ) S0 -- S0  */
/*  */
NAME("close-pipe")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Cell wretval;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += -1;
{
wretval = pclose((FILE *)wfileid);
wior = IOR(wretval==-1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wretval=", vm_out); printarg_w(wretval);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wretval,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(close_pipe)
NAME1("l2-close_pipe")
NEXT_P1_5;
LABEL3(close_pipe)
NAME1("l3-close_pipe")
DO_GOTO;
}

LABEL(time_and_date) /* time&date ( -- nsec nmin nhour nday nmonth nyear ) S0 -- S0  */
/* Report the current time of day. Seconds, minutes and hours are numbered from 0.
Months are numbered from 1. */
NAME("time&date")
{
DEF_CA
Cell nsec;
Cell nmin;
Cell nhour;
Cell nday;
Cell nmonth;
Cell nyear;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -6;
{
time_t now;
struct tm ltime;
time(&now);
localtime_r(&now, &ltime); /* thread save version */
nyear =ltime.tm_year+1900;
nmonth=ltime.tm_mon+1;
nday  =ltime.tm_mday;
nhour =ltime.tm_hour;
nmin  =ltime.tm_min;
nsec  =ltime.tm_sec;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" nsec=", vm_out); printarg_n(nsec);
fputs(" nmin=", vm_out); printarg_n(nmin);
fputs(" nhour=", vm_out); printarg_n(nhour);
fputs(" nday=", vm_out); printarg_n(nday);
fputs(" nmonth=", vm_out); printarg_n(nmonth);
fputs(" nyear=", vm_out); printarg_n(nyear);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(nsec,sp[5]);
vm_n2Cell(nmin,sp[4]);
vm_n2Cell(nhour,sp[3]);
vm_n2Cell(nday,sp[2]);
vm_n2Cell(nmonth,sp[1]);
vm_n2Cell(nyear,sp[0]);
LABEL2(time_and_date)
NAME1("l2-time_and_date")
NEXT_P1_5;
LABEL3(time_and_date)
NAME1("l3-time_and_date")
DO_GOTO;
}

LABEL(paren_ms) /* (ms) ( u -- ) S0 -- S0  */
/* Wait at least @i{n} milli-second. */
NAME("(ms)")
{
DEF_CA
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
gforth_ms(u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(paren_ms)
NAME1("l2-paren_ms")
NEXT_P1_5;
LABEL3(paren_ms)
NAME1("l3-paren_ms")
DO_GOTO;
}

LABEL(heap_allocate) /* heap-allocate ( u -- a_addr wior ) S0 -- S0  */
/* Allocate @i{u} address units of contiguous data space. The initial
contents of the data space is undefined. If the allocation is successful,
@i{a-addr} is the start address of the allocated region and @i{wior}
is 0. If the allocation fails, @i{a-addr} is undefined and @i{wior}
is a non-zero I/O result code. */
NAME("heap-allocate")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell * a_addr;
Cell wior;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += -1;
{
a_addr = (Cell *)malloc_l(u?u:1);
wior = IOR(a_addr==NULL);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(heap_allocate)
NAME1("l2-heap_allocate")
NEXT_P1_5;
LABEL3(heap_allocate)
NAME1("l3-heap_allocate")
DO_GOTO;
}

LABEL(heap_free) /* heap-free ( a_addr -- wior ) S0 -- S0  */
/* Return the region of data space starting at @i{a-addr} to the system.
The region must originally have been obtained using @code{allocate} or
@code{resize}. If the operational is successful, @i{wior} is 0.
If the operation fails, @i{wior} is a non-zero I/O result code. */
NAME("heap-free")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
Cell wior;
NEXT_P0;
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
{
free_l(a_addr);
wior = 0;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(heap_free)
NAME1("l2-heap_free")
NEXT_P1_5;
LABEL3(heap_free)
NAME1("l3-heap_free")
DO_GOTO;
}

LABEL(heap_resize) /* heap-resize ( a_addr1 u -- a_addr2 wior ) S0 -- S0  */
/* Change the size of the allocated area at @i{a-addr1} to @i{u}
address units, possibly moving the contents to a different
area. @i{a-addr2} is the address of the resulting area.
If the operation is successful, @i{wior} is 0.
If the operation fails, @i{wior} is a non-zero
I/O result code. If @i{a-addr1} is 0, Gforth's (but not the Standard)
@code{resize} @code{allocate}s @i{u} address units. */
NAME("heap-resize")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr1;
MAYBE_UNUSED UCell u;
Cell * a_addr2;
Cell wior;
NEXT_P0;
vm_Cell2a_(sp[1],a_addr1);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr1=", vm_out); printarg_a_(a_addr1);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
/* the following check is not necessary on most OSs, but it is needed
   on SunOS 4.1.2. */
/* close ' to keep fontify happy */
if (a_addr1==NULL)
  a_addr2 = (Cell *)malloc_l(u);
else
  a_addr2 = (Cell *)realloc_l(a_addr1, (u ? u : 1));
wior = IOR(a_addr2==NULL);	/* !! Define a return code */
if(wior)
  a_addr2 = a_addr1; /* in case of an error, keep a_addr1 */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr2=", vm_out); printarg_a_(a_addr2);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr2,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(heap_resize)
NAME1("l2-heap_resize")
NEXT_P1_5;
LABEL3(heap_resize)
NAME1("l3-heap_resize")
DO_GOTO;
}

LABEL(strerror) /* strerror ( n -- c_addr u ) S0 -- S0  */
/*  */
NAME("strerror")
{
DEF_CA
MAYBE_UNUSED Cell n;
Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += -1;
{
c_addr = (Char *)strerror(n);
u = strlen((char *)c_addr);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[1]);
vm_u2Cell(u,sp[0]);
LABEL2(strerror)
NAME1("l2-strerror")
NEXT_P1_5;
LABEL3(strerror)
NAME1("l3-strerror")
DO_GOTO;
}

LABEL(strsignal) /* strsignal ( n -- c_addr u ) S0 -- S0  */
/*  */
NAME("strsignal")
{
DEF_CA
MAYBE_UNUSED Cell n;
Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += -1;
{
c_addr = (Char *)strsignal(n);
u = strlen((char *)c_addr);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[1]);
vm_u2Cell(u,sp[0]);
LABEL2(strsignal)
NAME1("l2-strsignal")
NEXT_P1_5;
LABEL3(strsignal)
NAME1("l3-strsignal")
DO_GOTO;
}

LABEL(call_c) /* call-c ( ... w -- ... ) S0 -- S0  */
/* Call the C function pointed to by @i{w}. The C function has to
access the stack itself. The stack pointers are exported into a ptrpair
structure passed to the C function, and returned in that form. */
NAME("call-c")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
{
ptrpair x;
IF_fpTOS(fp[0]=fpTOS);
x.fpx=fp;
x.spx=sp;
x=((ptrpair (*)(ptrpair, void*))(w))(x, (void*)w);
sp=x.spx;
fp=x.fpx;
IF_fpTOS(fpTOS=fp[0]);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(call_c)
NAME1("l2-call_c")
NEXT_P1_5;
LABEL3(call_c)
NAME1("l3-call_c")
DO_GOTO;
}

LABEL(call_c_direct) /* call-c# ( ... #a_addr -- ... ) S0 -- S0  */
/* Call the C function pointed to by the inline argument @i{w}. The C function
has to access the stack itself. The stack pointers are exported into a ptrpair
structure passed to the C function, and returned in that form. */
NAME("call-c#")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397804 ),a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
INC_IP(1);
{
ptrpair x;
IF_fpTOS(fp[0]=fpTOS);
x.fpx=fp;
x.spx=sp;
x=((ptrpair (*)(ptrpair, void*))(*a_addr))(x, a_addr);
sp=x.spx;
fp=x.fpx;
IF_fpTOS(fpTOS=fp[0]);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(call_c_direct)
NAME1("l2-call_c_direct")
NEXT_P1_5;
LABEL3(call_c_direct)
NAME1("l3-call_c_direct")
DO_GOTO;
}

LABEL(get_gforth_pointers) /* gforth-pointers ( -- a_addr ) S0 -- S0  */
/*  */
NAME("gforth-pointers")
{
DEF_CA
Cell * a_addr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
a_addr = (Cell*)gforth_pointers;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(get_gforth_pointers)
NAME1("l2-get_gforth_pointers")
NEXT_P1_5;
LABEL3(get_gforth_pointers)
NAME1("l3-get_gforth_pointers")
DO_GOTO;
}

GROUPADD(20)
#endif
GROUPADD(0)
#ifdef HAS_FILE
LABEL(close_file) /* close-file ( wfileid -- wior ) S0 -- S0  */
/*  */
NAME("close-file")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
wior = IOR(fclose((FILE *)wfileid)==EOF);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(close_file)
NAME1("l2-close_file")
NEXT_P1_5;
LABEL3(close_file)
NAME1("l3-close_file")
DO_GOTO;
}

LABEL(open_file) /* open-file ( c_addr u wfam -- wfileid wior ) S0 -- S0  */
/*  */
NAME("open-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell wfam;
Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2w(sp[0],wfam);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" wfam=", vm_out); printarg_w(wfam);
}
#endif
sp += 1;
{
char * string = tilde_cstr(c_addr,u);
wfileid = opencreate_file(string, wfam, 0, &wior);
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(open_file)
NAME1("l2-open_file")
NEXT_P1_5;
LABEL3(open_file)
NAME1("l3-open_file")
DO_GOTO;
}

LABEL(create_file) /* create-file ( c_addr u wfam -- wfileid wior ) S0 -- S0  */
/*  */
NAME("create-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell wfam;
Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2w(sp[0],wfam);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" wfam=", vm_out); printarg_w(wfam);
}
#endif
sp += 1;
{
char * string = tilde_cstr(c_addr,u);
wfileid = opencreate_file(string, wfam, O_CREAT|O_TRUNC, &wior);
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfileid=", vm_out); printarg_w(wfileid);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfileid,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(create_file)
NAME1("l2-create_file")
NEXT_P1_5;
LABEL3(create_file)
NAME1("l3-create_file")
DO_GOTO;
}

LABEL(delete_file) /* delete-file ( c_addr u -- wior ) S0 -- S0  */
/*  */
NAME("delete-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
char * string = tilde_cstr(c_addr,u);
wior = IOR(unlink(string)==-1);
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(delete_file)
NAME1("l2-delete_file")
NEXT_P1_5;
LABEL3(delete_file)
NAME1("l3-delete_file")
DO_GOTO;
}

LABEL(rename_file) /* rename-file ( c_addr1 u1 c_addr2 u2 -- wior ) S0 -- S0  */
/* Rename file @i{c_addr1 u1} to new name @i{c_addr2 u2} */
NAME("rename-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char * c_addr2;
MAYBE_UNUSED UCell u2;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[3],c_addr1);
vm_Cell2u(sp[2],u1);
vm_Cell2c_(sp[1],c_addr2);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 3;
{
wior = rename_file(c_addr1, u1, c_addr2, u2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(rename_file)
NAME1("l2-rename_file")
NEXT_P1_5;
LABEL3(rename_file)
NAME1("l3-rename_file")
DO_GOTO;
}

LABEL(file_position) /* file-position ( wfileid -- ud wior ) S0 -- S0  */
/*  */
NAME("file-position")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
UDCell ud;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += -2;
{
/* !! use tell and lseek? */
ud = OFF2UD(ftello((FILE *)wfileid));
wior = IOR(UD2OFF(ud)==-1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[2], sp[1])
vm_w2Cell(wior,sp[0]);
LABEL2(file_position)
NAME1("l2-file_position")
NEXT_P1_5;
LABEL3(file_position)
NAME1("l3-file_position")
DO_GOTO;
}

LABEL(reposition_file) /* reposition-file ( ud wfileid -- wior ) S0 -- S0  */
/*  */
NAME("reposition-file")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += 2;
{
wior = IOR(fseeko((FILE *)wfileid, UD2OFF(ud), SEEK_SET)==-1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(reposition_file)
NAME1("l2-reposition_file")
NEXT_P1_5;
LABEL3(reposition_file)
NAME1("l3-reposition_file")
DO_GOTO;
}

LABEL(file_size) /* file-size ( wfileid -- ud wior ) S0 -- S0  */
/*  */
NAME("file-size")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
UDCell ud;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += -2;
{
struct stat buf;
wior = IOR(fstat(fileno((FILE *)wfileid), &buf)==-1);
if (wior==0 && (S_ISREG(buf.st_mode) || S_ISDIR(buf.st_mode)))
  ud = OFF2UD(buf.st_size);
else {
  ud = OFF2UD(0);
  wior = -2057; /* wrong file type */
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[2], sp[1])
vm_w2Cell(wior,sp[0]);
LABEL2(file_size)
NAME1("l2-file_size")
NEXT_P1_5;
LABEL3(file_size)
NAME1("l3-file_size")
DO_GOTO;
}

LABEL(resize_file) /* resize-file ( ud wfileid -- wior ) S0 -- S0  */
/*  */
NAME("resize-file")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += 2;
{
wior = IOR(ftruncate(fileno((FILE *)wfileid), UD2OFF(ud))==-1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(resize_file)
NAME1("l2-resize_file")
NEXT_P1_5;
LABEL3(resize_file)
NAME1("l3-resize_file")
DO_GOTO;
}

LABEL(read_file) /* read-file ( c_addr u1 wfileid -- u2 wior ) S0 -- S0  */
/*  */
NAME("read-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell wfileid;
UCell u2;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u1);
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += 1;
{
/* !! fread does not guarantee enough */
u2 = 0;
do {
  u2 += fread(c_addr+u2, sizeof(Char), u1-u2, (FILE *)wfileid);
  if (u2>0)
    gf_regetc((FILE *)wfileid);
  if((wior = FILEIO(u2<u1 && ferror((FILE *)wfileid))))
    clearerr((FILE *)wfileid);
} while(wior==TOIOR(EINTR));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(read_file)
NAME1("l2-read_file")
NEXT_P1_5;
LABEL3(read_file)
NAME1("l3-read_file")
DO_GOTO;
}

LABEL(paren_read_line) /* (read-line) ( c_addr u1 wfileid -- u2 flag u3 wior ) S0 -- S0  */
/*  */
NAME("(read-line)")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell wfileid;
UCell u2;
Bool flag;
UCell u3;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u1);
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += -1;
{
struct Cellquad r = read_line(c_addr, u1, (FILE *)wfileid);
u2   = r.n1;
flag = r.n2;
u3   = r.n3;
wior = r.n4;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputs(" flag=", vm_out); printarg_f(flag);
fputs(" u3=", vm_out); printarg_u(u3);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[3]);
vm_f2Cell(flag,sp[2]);
vm_u2Cell(u3,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(paren_read_line)
NAME1("l2-paren_read_line")
NEXT_P1_5;
LABEL3(paren_read_line)
NAME1("l3-paren_read_line")
DO_GOTO;
}

GROUPADD(11)
#endif
LABEL(write_file) /* write-file ( c_addr u1 wfileid -- wior ) S0 -- S0  */
/*  */
NAME("write-file")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u1);
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += 2;
{
/* !! fwrite does not guarantee enough */
#ifdef HAS_FILE
UCell u2 = 0;
do {
  u2 += fwrite(c_addr+u2, sizeof(Char), u1-u2, (FILE *)wfileid);
  if((wior = FILEIO(u2<u1 && ferror((FILE *)wfileid))))
    clearerr((FILE *)wfileid);
} while(wior==TOIOR(EINTR));
#else
TYPE(c_addr, u1);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(write_file)
NAME1("l2-write_file")
NEXT_P1_5;
LABEL3(write_file)
NAME1("l3-write_file")
DO_GOTO;
}

LABEL(emit_file) /* emit-file ( c wfileid -- wior ) S0 -- S0  */
/*  */
NAME("emit-file")
{
DEF_CA
MAYBE_UNUSED Char c;
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2c(sp[1],c);
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c=", vm_out); printarg_c(c);
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
sp += 1;
{
#ifdef HAS_FILE
do {
  wior = FILEIO(putc(c, (FILE *)wfileid)==EOF);
  if (wior)
    clearerr((FILE *)wfileid);
} while(wior==TOIOR(EINTR));
#else
PUTC(c);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(emit_file)
NAME1("l2-emit_file")
NEXT_P1_5;
LABEL3(emit_file)
NAME1("l3-emit_file")
DO_GOTO;
}

GROUPADD(2)
#ifdef HAS_FILE
LABEL(flush_file) /* flush-file ( wfileid -- wior ) S0 -- S0  */
/*  */
NAME("flush-file")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
wior = IOR(fflush((FILE *) wfileid)==EOF);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(flush_file)
NAME1("l2-flush_file")
NEXT_P1_5;
LABEL3(flush_file)
NAME1("l3-flush_file")
DO_GOTO;
}

LABEL(file_status) /* file-status ( c_addr u -- wfam wior ) S0 -- S0  */
/*  */
NAME("file-status")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell wfam;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
struct Cellpair r = file_status(c_addr, u);
wfam = r.n1;
wior = r.n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wfam=", vm_out); printarg_w(wfam);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wfam,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(file_status)
NAME1("l2-file_status")
NEXT_P1_5;
LABEL3(file_status)
NAME1("l3-file_status")
DO_GOTO;
}

LABEL(file_eof_query) /* file-eof? ( wfileid -- flag ) S0 -- S0  */
/*  */
NAME("file-eof?")
{
DEF_CA
MAYBE_UNUSED Cell wfileid;
Bool flag;
NEXT_P0;
vm_Cell2w(sp[0],wfileid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wfileid=", vm_out); printarg_w(wfileid);
}
#endif
{
flag = FLAG(feof((FILE *) wfileid));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" flag=", vm_out); printarg_f(flag);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(flag,sp[0]);
LABEL2(file_eof_query)
NAME1("l2-file_eof_query")
NEXT_P1_5;
LABEL3(file_eof_query)
NAME1("l3-file_eof_query")
DO_GOTO;
}

LABEL(open_dir) /* open-dir ( c_addr u -- wdirid wior ) S0 -- S0  */
/* Open the directory specified by @i{c-addr, u}
and return @i{dir-id} for futher access to it. */
NAME("open-dir")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell wdirid;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
char * string = tilde_cstr(c_addr,u);
wdirid = (Cell)opendir(string);
wior =  IOR(wdirid == 0);
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wdirid=", vm_out); printarg_w(wdirid);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wdirid,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(open_dir)
NAME1("l2-open_dir")
NEXT_P1_5;
LABEL3(open_dir)
NAME1("l3-open_dir")
DO_GOTO;
}

LABEL(read_dir) /* read-dir ( c_addr u1 wdirid -- u2 flag wior ) S0 -- S0  */
/* Attempt to read the next entry from the directory specified
by @i{dir-id} to the buffer of length @i{u1} at address @i{c-addr}. 
If the attempt fails because there is no more entries,
@i{ior}=0, @i{flag}=0, @i{u2}=0, and the buffer is unmodified.
If the attempt to read the next entry fails because of any other reason, 
return @i{ior}<>0.
If the attempt succeeds, store file name to the buffer at @i{c-addr}
and return @i{ior}=0, @i{flag}=true and @i{u2} equal to the size of the file name.
If the length of the file name is greater than @i{u1}, 
store first @i{u1} characters from file name into the buffer and
indicate "name too long" with @i{ior}, @i{flag}=true, and @i{u2}=@i{u1}. */
NAME("read-dir")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell wdirid;
UCell u2;
Bool flag;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u1);
vm_Cell2w(sp[0],wdirid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" wdirid=", vm_out); printarg_w(wdirid);
}
#endif
{
struct dirent * dresult;
dresult=readdir((DIR *)wdirid);
wior = 0;
flag = -1;
if(dresult == NULL) {
  u2 = 0;
  flag = 0;
} else {
  u2 = strlen((char *)dresult->d_name);
  if(u2 > u1) {
    u2 = u1;
    wior = -512-ENAMETOOLONG;
  }
  memmove(c_addr, dresult->d_name, u2);
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputs(" flag=", vm_out); printarg_f(flag);
fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[2]);
vm_f2Cell(flag,sp[1]);
vm_w2Cell(wior,sp[0]);
LABEL2(read_dir)
NAME1("l2-read_dir")
NEXT_P1_5;
LABEL3(read_dir)
NAME1("l3-read_dir")
DO_GOTO;
}

LABEL(close_dir) /* close-dir ( wdirid -- wior ) S0 -- S0  */
/* Close the directory specified by @i{dir-id}. */
NAME("close-dir")
{
DEF_CA
MAYBE_UNUSED Cell wdirid;
Cell wior;
NEXT_P0;
vm_Cell2w(sp[0],wdirid);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" wdirid=", vm_out); printarg_w(wdirid);
}
#endif
{
wior = IOR(closedir((DIR *)wdirid));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(close_dir)
NAME1("l2-close_dir")
NEXT_P1_5;
LABEL3(close_dir)
NAME1("l3-close_dir")
DO_GOTO;
}

LABEL(match_file) /* filename-match ( c_addr1 u1 c_addr2 u2 -- flag ) S0 -- S0  */
/* match the file name @var{c_addr1 u1} with the pattern @var{c_addr2 u2}.
Patterns match char by char except for the special characters '*' and '?',
which are wildcards for several ('*') or one ('?') character. */
NAME("filename-match")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Char * c_addr2;
MAYBE_UNUSED UCell u2;
Bool flag;
NEXT_P0;
vm_Cell2c_(sp[3],c_addr1);
vm_Cell2u(sp[2],u1);
vm_Cell2c_(sp[1],c_addr2);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 3;
{
char * string = cstr(c_addr1, u1);
char * pattern = cstr(c_addr2, u2);
flag = FLAG(!fnmatch(pattern, string, 0));
free_l(string);
free_l(pattern);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" flag=", vm_out); printarg_f(flag);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(flag,sp[0]);
LABEL2(match_file)
NAME1("l2-match_file")
NEXT_P1_5;
LABEL3(match_file)
NAME1("l3-match_file")
DO_GOTO;
}

LABEL(set_dir) /* set-dir ( c_addr u -- wior ) S0 -- S0  */
/* Change the current directory to @i{c-addr, u}.
Return an error if this is not possible */
NAME("set-dir")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
char * string = tilde_cstr(c_addr, u);
wior = IOR(chdir(string));
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(set_dir)
NAME1("l2-set_dir")
NEXT_P1_5;
LABEL3(set_dir)
NAME1("l3-set_dir")
DO_GOTO;
}

LABEL(get_dir) /* get-dir ( c_addr1 u1 -- c_addr2 u2 ) S0 -- S0  */
/* Store the current directory in the buffer specified by @i{c-addr1, u1}.
If the buffer size is not sufficient, return 0 0 */
NAME("get-dir")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
Char * c_addr2;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr1);
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
c_addr2 = (Char *)getcwd((char *)c_addr1, u1);
if(c_addr2 != NULL) {
  u2 = strlen((char *)c_addr2);
} else {
  u2 = 0;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr2=", vm_out); printarg_c_(c_addr2);
fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr2,sp[1]);
vm_u2Cell(u2,sp[0]);
LABEL2(get_dir)
NAME1("l2-get_dir")
NEXT_P1_5;
LABEL3(get_dir)
NAME1("l3-get_dir")
DO_GOTO;
}

LABEL(equals_mkdir) /* =mkdir ( c_addr u wmode -- wior ) S0 -- S0  */
/* Create directory @i{c-addr u} with mode @i{wmode}. */
NAME("=mkdir")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Cell wmode;
Cell wior;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2w(sp[0],wmode);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" wmode=", vm_out); printarg_w(wmode);
}
#endif
sp += 2;
{
char * string = tilde_cstr(c_addr,u);
wior = IOR(mkdir(string,wmode));
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(equals_mkdir)
NAME1("l2-equals_mkdir")
NEXT_P1_5;
LABEL3(equals_mkdir)
NAME1("l3-equals_mkdir")
DO_GOTO;
}

GROUPADD(10)
#endif
LABEL(newline) /* newline ( -- c_addr u ) S0 -- S0  */
/* String containing the newline sequence of the host OS */
NAME("newline")
{
DEF_CA
Char * c_addr;
UCell u;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -2;
{
static const char newline[] = {
#if DIRSEP=='/'
/* Unix */
'\n'
#else
/* DOS, Win, OS/2 */
'\r','\n'
#endif
};
c_addr=(Char *)newline;
u=sizeof(newline);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[1]);
vm_u2Cell(u,sp[0]);
LABEL2(newline)
NAME1("l2-newline")
NEXT_P1_5;
LABEL3(newline)
NAME1("l3-newline")
DO_GOTO;
}

GROUPADD(1)
#ifdef HAS_OS
LABEL(utime) /* utime ( -- dtime ) S0 -- S0  */
/* Report the current time in microseconds since some epoch. */
NAME("utime")
{
DEF_CA
DCell dtime;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -2;
{
struct timeval time1;
gettimeofday(&time1,NULL);
dtime = timeval2us(&time1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" dtime=", vm_out); printarg_d(dtime);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(dtime, sp[1], sp[0])
LABEL2(utime)
NAME1("l2-utime")
NEXT_P1_5;
LABEL3(utime)
NAME1("l3-utime")
DO_GOTO;
}

LABEL(cputime) /* cputime ( -- duser dsystem ) S0 -- S0  */
/* duser and dsystem are the respective user- and system-level CPU
times used since the start of the Forth system (excluding child
processes), in microseconds (the granularity may be much larger,
however).  On platforms without the getrusage call, it reports elapsed
time (since some epoch) for duser and 0 for dsystem. */
NAME("cputime")
{
DEF_CA
DCell duser;
DCell dsystem;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -4;
{
#ifdef HAVE_GETRUSAGE
struct rusage usage;
getrusage(RUSAGE_SELF, &usage);
duser = timeval2us(&usage.ru_utime);
dsystem = timeval2us(&usage.ru_stime);
#else
struct timeval time1;
gettimeofday(&time1,NULL);
duser = timeval2us(&time1);
dsystem = DZERO;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" duser=", vm_out); printarg_d(duser);
fputs(" dsystem=", vm_out); printarg_d(dsystem);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(duser, sp[3], sp[2])
vm_d2twoCell(dsystem, sp[1], sp[0])
LABEL2(cputime)
NAME1("l2-cputime")
NEXT_P1_5;
LABEL3(cputime)
NAME1("l3-cputime")
DO_GOTO;
}

LABEL(ntime) /* ntime ( -- dtime ) S0 -- S0  */
/* Report the current time in nanoseconds since some epoch. */
NAME("ntime")
{
DEF_CA
DCell dtime;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -2;
{
struct timespec time1;
#ifdef HAVE_CLOCK_GETTIME
clock_gettime(CLOCK_REALTIME,&time1);
#else
struct timeval time2;
gettimeofday(&time2,NULL);
time1.tv_sec = time2.tv_sec;
time1.tv_nsec = time2.tv_usec*1000;
#endif
dtime = timespec2ns(&time1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" dtime=", vm_out); printarg_d(dtime);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(dtime, sp[1], sp[0])
LABEL2(ntime)
NAME1("l2-ntime")
NEXT_P1_5;
LABEL3(ntime)
NAME1("l3-ntime")
DO_GOTO;
}

LABEL(paren_ns) /* (ns) ( uns nsec -- wior ) S0 -- S0  */
/* Wait for usec+uns, values precomputed in Forth */
NAME("(ns)")
{
DEF_CA
MAYBE_UNUSED UCell uns;
MAYBE_UNUSED Cell nsec;
Cell wior;
NEXT_P0;
vm_Cell2u(sp[1],uns);
vm_Cell2n(sp[0],nsec);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" uns=", vm_out); printarg_u(uns);
fputs(" nsec=", vm_out); printarg_n(nsec);
}
#endif
sp += 1;
{
if(nsec >= 0) {
#if HAVE_PSELECT
  struct timespec tout = { nsec, uns };
  wior=IOR(pselect(0, NULL, NULL, NULL, &tout, NULL) < 0);
#else
  struct timeval tout = { nsec, uns/1000 };
  wior=IOR(select(0, NULL, NULL, NULL, &tout) < 0);
#endif
} else {
  wior = 0;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" wior=", vm_out); printarg_w(wior);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(wior,sp[0]);
LABEL2(paren_ns)
NAME1("l2-paren_ns")
NEXT_P1_5;
LABEL3(paren_ns)
NAME1("l3-paren_ns")
DO_GOTO;
}

GROUPADD(4)
#endif
GROUPADD(0)
#ifdef HAS_FLOATING
GROUPADD(0)
GROUP( floating, 285)
LABEL(f_equals) /* f= ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f=")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1==r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_equals)
NAME1("l2-f_equals")
NEXT_P1_5;
LABEL3(f_equals)
NAME1("l3-f_equals")
DO_GOTO;
}

LABEL(f_not_equals) /* f<> ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f<>")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1!=r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_not_equals)
NAME1("l2-f_not_equals")
NEXT_P1_5;
LABEL3(f_not_equals)
NAME1("l3-f_not_equals")
DO_GOTO;
}

LABEL(f_less_than) /* f< ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f<")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1<r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_less_than)
NAME1("l2-f_less_than")
NEXT_P1_5;
LABEL3(f_less_than)
NAME1("l3-f_less_than")
DO_GOTO;
}

LABEL(f_greater_than) /* f> ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f>")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1>r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_greater_than)
NAME1("l2-f_greater_than")
NEXT_P1_5;
LABEL3(f_greater_than)
NAME1("l3-f_greater_than")
DO_GOTO;
}

LABEL(f_less_or_equal) /* f<= ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f<=")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1<=r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_less_or_equal)
NAME1("l2-f_less_or_equal")
NEXT_P1_5;
LABEL3(f_less_or_equal)
NAME1("l3-f_less_or_equal")
DO_GOTO;
}

LABEL(f_greater_or_equal) /* f>= ( r1 r2 -- f ) S0 -- S0  */
/*  */
NAME("f>=")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Bool f;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
sp += -1;
fp += 2;
{
f = FLAG(r1>=r2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_greater_or_equal)
NAME1("l2-f_greater_or_equal")
NEXT_P1_5;
LABEL3(f_greater_or_equal)
NAME1("l3-f_greater_or_equal")
DO_GOTO;
}

LABEL(f_zero_equals) /* f0= ( r -- f ) S0 -- S0  */
/*  */
NAME("f0=")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r==0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_equals)
NAME1("l2-f_zero_equals")
NEXT_P1_5;
LABEL3(f_zero_equals)
NAME1("l3-f_zero_equals")
DO_GOTO;
}

LABEL(f_zero_not_equals) /* f0<> ( r -- f ) S0 -- S0  */
/*  */
NAME("f0<>")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r!=0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_not_equals)
NAME1("l2-f_zero_not_equals")
NEXT_P1_5;
LABEL3(f_zero_not_equals)
NAME1("l3-f_zero_not_equals")
DO_GOTO;
}

LABEL(f_zero_less_than) /* f0< ( r -- f ) S0 -- S0  */
/*  */
NAME("f0<")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r<0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_less_than)
NAME1("l2-f_zero_less_than")
NEXT_P1_5;
LABEL3(f_zero_less_than)
NAME1("l3-f_zero_less_than")
DO_GOTO;
}

LABEL(f_zero_greater_than) /* f0> ( r -- f ) S0 -- S0  */
/*  */
NAME("f0>")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r>0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_greater_than)
NAME1("l2-f_zero_greater_than")
NEXT_P1_5;
LABEL3(f_zero_greater_than)
NAME1("l3-f_zero_greater_than")
DO_GOTO;
}

LABEL(f_zero_less_or_equal) /* f0<= ( r -- f ) S0 -- S0  */
/*  */
NAME("f0<=")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r<=0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_less_or_equal)
NAME1("l2-f_zero_less_or_equal")
NEXT_P1_5;
LABEL3(f_zero_less_or_equal)
NAME1("l3-f_zero_less_or_equal")
DO_GOTO;
}

LABEL(f_zero_greater_or_equal) /* f0>= ( r -- f ) S0 -- S0  */
/*  */
NAME("f0>=")
{
DEF_CA
MAYBE_UNUSED Float r;
Bool f;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
f = FLAG(r>=0.);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(f_zero_greater_or_equal)
NAME1("l2-f_zero_greater_or_equal")
NEXT_P1_5;
LABEL3(f_zero_greater_or_equal)
NAME1("l3-f_zero_greater_or_equal")
DO_GOTO;
}

LABEL(s_to_f) /* s>f ( n -- r ) S0 -- S0  */
/*  */
NAME("s>f")
{
DEF_CA
MAYBE_UNUSED Cell n;
Float r;
NEXT_P0;
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
fp += -1;
{
r = n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(s_to_f)
NAME1("l2-s_to_f")
NEXT_P1_5;
LABEL3(s_to_f)
NAME1("l3-s_to_f")
DO_GOTO;
}

LABEL(d_to_f) /* d>f ( d -- r ) S0 -- S0  */
/*  */
NAME("d>f")
{
DEF_CA
MAYBE_UNUSED DCell d;
Float r;
NEXT_P0;
vm_twoCell2d(sp[1], sp[0], d)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" d=", vm_out); printarg_d(d);
}
#endif
sp += 2;
fp += -1;
{
#ifdef BUGGY_LL_D2F
extern double ldexp(double x, int exp);
if (DHI(d)<0) {
#ifdef BUGGY_LL_ADD
  DCell d2=dnegate(d);
#else
  DCell d2=-d;
#endif
  r = -(ldexp((Float)DHI(d2),CELL_BITS) + (Float)DLO(d2));
} else
  r = ldexp((Float)DHI(d),CELL_BITS) + (Float)DLO(d);
#else
r = d;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(d_to_f)
NAME1("l2-d_to_f")
NEXT_P1_5;
LABEL3(d_to_f)
NAME1("l3-d_to_f")
DO_GOTO;
}

LABEL(f_to_d) /* f>d ( r -- d ) S0 -- S0  */
/*  */
NAME("f>d")
{
DEF_CA
MAYBE_UNUSED Float r;
DCell d;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -2;
fp += 1;
{
extern DCell double2ll(Float r);
d = double2ll(r);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d=", vm_out); printarg_d(d);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d, sp[1], sp[0])
LABEL2(f_to_d)
NAME1("l2-f_to_d")
NEXT_P1_5;
LABEL3(f_to_d)
NAME1("l3-f_to_d")
DO_GOTO;
}

LABEL(f_to_s) /* f>s ( r -- n ) S0 -- S0  */
/*  */
NAME("f>s")
{
DEF_CA
MAYBE_UNUSED Float r;
Cell n;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
sp += -1;
fp += 1;
{
n = (Cell)r;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(f_to_s)
NAME1("l2-f_to_s")
NEXT_P1_5;
LABEL3(f_to_s)
NAME1("l3-f_to_s")
DO_GOTO;
}

LABEL(f_store) /* f! ( r f_addr -- ) S0 -- S0  */
/* Store @i{r} into the float at address @i{f-addr}. */
NAME("f!")
{
DEF_CA
MAYBE_UNUSED Float r;
MAYBE_UNUSED Float * f_addr;
NEXT_P0;
vm_Float2r(fp[0],r);
vm_Cell2f_(sp[0],f_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
fputs(" f_addr=", vm_out); printarg_f_(f_addr);
}
#endif
sp += 1;
fp += 1;
{
*f_addr = r;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(f_store)
NAME1("l2-f_store")
NEXT_P1_5;
LABEL3(f_store)
NAME1("l3-f_store")
DO_GOTO;
}

LABEL(f_fetch) /* f@ ( f_addr -- r ) S0 -- S0  */
/* @i{r} is the float at address @i{f-addr}. */
NAME("f@")
{
DEF_CA
MAYBE_UNUSED Float * f_addr;
Float r;
NEXT_P0;
vm_Cell2f_(sp[0],f_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" f_addr=", vm_out); printarg_f_(f_addr);
}
#endif
sp += 1;
fp += -1;
{
r = *f_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(f_fetch)
NAME1("l2-f_fetch")
NEXT_P1_5;
LABEL3(f_fetch)
NAME1("l3-f_fetch")
DO_GOTO;
}

LABEL(d_f_fetch) /* df@ ( df_addr -- r ) S0 -- S0  */
/* Fetch the double-precision IEEE floating-point value @i{r} from the address @i{df-addr}. */
NAME("df@")
{
DEF_CA
MAYBE_UNUSED DFloat * df_addr;
Float r;
NEXT_P0;
vm_Cell2df_(sp[0],df_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" df_addr=", vm_out); printarg_df_(df_addr);
}
#endif
sp += 1;
fp += -1;
{
#ifdef IEEE_FP
r = *df_addr;
#else
!! df@
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(d_f_fetch)
NAME1("l2-d_f_fetch")
NEXT_P1_5;
LABEL3(d_f_fetch)
NAME1("l3-d_f_fetch")
DO_GOTO;
}

LABEL(d_f_store) /* df! ( r df_addr -- ) S0 -- S0  */
/* Store @i{r} as double-precision IEEE floating-point value to the
address @i{df-addr}. */
NAME("df!")
{
DEF_CA
MAYBE_UNUSED Float r;
MAYBE_UNUSED DFloat * df_addr;
NEXT_P0;
vm_Float2r(fp[0],r);
vm_Cell2df_(sp[0],df_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
fputs(" df_addr=", vm_out); printarg_df_(df_addr);
}
#endif
sp += 1;
fp += 1;
{
#ifdef IEEE_FP
*df_addr = r;
#else
!! df!
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(d_f_store)
NAME1("l2-d_f_store")
NEXT_P1_5;
LABEL3(d_f_store)
NAME1("l3-d_f_store")
DO_GOTO;
}

LABEL(s_f_fetch) /* sf@ ( sf_addr -- r ) S0 -- S0  */
/* Fetch the single-precision IEEE floating-point value @i{r} from the address @i{sf-addr}. */
NAME("sf@")
{
DEF_CA
MAYBE_UNUSED SFloat * sf_addr;
Float r;
NEXT_P0;
vm_Cell2sf_(sp[0],sf_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" sf_addr=", vm_out); printarg_sf_(sf_addr);
}
#endif
sp += 1;
fp += -1;
{
#ifdef IEEE_FP
r = *sf_addr;
#else
!! sf@
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(s_f_fetch)
NAME1("l2-s_f_fetch")
NEXT_P1_5;
LABEL3(s_f_fetch)
NAME1("l3-s_f_fetch")
DO_GOTO;
}

LABEL(s_f_store) /* sf! ( r sf_addr -- ) S0 -- S0  */
/* Store @i{r} as single-precision IEEE floating-point value to the
address @i{sf-addr}. */
NAME("sf!")
{
DEF_CA
MAYBE_UNUSED Float r;
MAYBE_UNUSED SFloat * sf_addr;
NEXT_P0;
vm_Float2r(fp[0],r);
vm_Cell2sf_(sp[0],sf_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
fputs(" sf_addr=", vm_out); printarg_sf_(sf_addr);
}
#endif
sp += 1;
fp += 1;
{
#ifdef IEEE_FP
*sf_addr = r;
#else
!! sf!
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(s_f_store)
NAME1("l2-s_f_store")
NEXT_P1_5;
LABEL3(s_f_store)
NAME1("l3-s_f_store")
DO_GOTO;
}

LABEL(f_plus) /* f+ ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("f+")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
r3 = r1+r2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_plus)
NAME1("l2-f_plus")
NEXT_P1_5;
LABEL3(f_plus)
NAME1("l3-f_plus")
DO_GOTO;
}

LABEL(f_minus) /* f- ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("f-")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
r3 = r1-r2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_minus)
NAME1("l2-f_minus")
NEXT_P1_5;
LABEL3(f_minus)
NAME1("l3-f_minus")
DO_GOTO;
}

LABEL(f_star) /* f* ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("f*")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
r3 = r1*r2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_star)
NAME1("l2-f_star")
NEXT_P1_5;
LABEL3(f_star)
NAME1("l3-f_star")
DO_GOTO;
}

LABEL(f_slash) /* f/ ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("f/")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
r3 = r1/r2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_slash)
NAME1("l2-f_slash")
NEXT_P1_5;
LABEL3(f_slash)
NAME1("l3-f_slash")
DO_GOTO;
}

LABEL(f_star_star) /* f** ( r1 r2 -- r3 ) S0 -- S0  */
/* @i{r3} is @i{r1} raised to the @i{r2}th power. */
NAME("f**")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
CLOBBER_TOS_WORKAROUND_START;
r3 = pow(r1,r2);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_star_star)
NAME1("l2-f_star_star")
NEXT_P1_5;
LABEL3(f_star_star)
NAME1("l3-f_star_star")
DO_GOTO;
}

LABEL(fm_star) /* fm* ( r1 n -- r2 ) S0 -- S0  */
/*  */
NAME("fm*")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Cell n;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
r2 = r1*n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(fm_star)
NAME1("l2-fm_star")
NEXT_P1_5;
LABEL3(fm_star)
NAME1("l3-fm_star")
DO_GOTO;
}

LABEL(fm_slash) /* fm/ ( r1 n -- r2 ) S0 -- S0  */
/*  */
NAME("fm/")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Cell n;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
vm_Cell2n(sp[0],n);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" n=", vm_out); printarg_n(n);
}
#endif
sp += 1;
{
r2 = r1/n;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(fm_slash)
NAME1("l2-fm_slash")
NEXT_P1_5;
LABEL3(fm_slash)
NAME1("l3-fm_slash")
DO_GOTO;
}

LABEL(fm_star_slash) /* fmx/ ( r1 n1 n2 -- r2 ) S0 -- S0  */
/*  */
NAME("fm*/")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Cell n1;
MAYBE_UNUSED Cell n2;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
vm_Cell2n(sp[1],n1);
vm_Cell2n(sp[0],n2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" n1=", vm_out); printarg_n(n1);
fputs(" n2=", vm_out); printarg_n(n2);
}
#endif
sp += 2;
{
r2 = (r1*n1)/n2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(fm_star_slash)
NAME1("l2-fm_star_slash")
NEXT_P1_5;
LABEL3(fm_star_slash)
NAME1("l3-fm_star_slash")
DO_GOTO;
}

LABEL(fm_square) /* f**2 ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("f**2")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
r2 = r1*r1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(fm_square)
NAME1("l2-fm_square")
NEXT_P1_5;
LABEL3(fm_square)
NAME1("l3-fm_square")
DO_GOTO;
}

LABEL(f_negate) /* fnegate ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fnegate")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
r2 = - r1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_negate)
NAME1("l2-f_negate")
NEXT_P1_5;
LABEL3(f_negate)
NAME1("l3-f_negate")
DO_GOTO;
}

LABEL(f_drop) /* fdrop ( r -- ) S0 -- S0  */
/*  */
NAME("fdrop")
{
DEF_CA
MAYBE_UNUSED Float r;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
fp += 1;
{
ALIVE_DEBUGGING(r);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(f_drop)
NAME1("l2-f_drop")
NEXT_P1_5;
LABEL3(f_drop)
NAME1("l3-f_drop")
DO_GOTO;
}

LABEL(f_dupe) /* fdup ( r -- r r ) S0 -- S0  */
/*  */
NAME("fdup")
{
DEF_CA
MAYBE_UNUSED Float r;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
fp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(f_dupe)
NAME1("l2-f_dupe")
NEXT_P1_5;
LABEL3(f_dupe)
NAME1("l3-f_dupe")
DO_GOTO;
}

LABEL(f_swap) /* fswap ( r1 r2 -- r2 r1 ) S0 -- S0  */
/*  */
NAME("fswap")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[1]);
vm_r2Float(r1,fp[0]);
LABEL2(f_swap)
NAME1("l2-f_swap")
NEXT_P1_5;
LABEL3(f_swap)
NAME1("l3-f_swap")
DO_GOTO;
}

LABEL(f_over) /* fover ( r1 r2 -- r1 r2 r1 ) S0 -- S0  */
/*  */
NAME("fover")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r1,fp[0]);
LABEL2(f_over)
NAME1("l2-f_over")
NEXT_P1_5;
LABEL3(f_over)
NAME1("l3-f_over")
DO_GOTO;
}

LABEL(f_rote) /* frot ( r1 r2 r3 -- r2 r3 r1 ) S0 -- S0  */
/*  */
NAME("frot")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
MAYBE_UNUSED Float r3;
NEXT_P0;
vm_Float2r(fp[2],r1);
vm_Float2r(fp[1],r2);
vm_Float2r(fp[0],r3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
fputs(" r3=", vm_out); printarg_r(r3);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[2]);
vm_r2Float(r3,fp[1]);
vm_r2Float(r1,fp[0]);
LABEL2(f_rote)
NAME1("l2-f_rote")
NEXT_P1_5;
LABEL3(f_rote)
NAME1("l3-f_rote")
DO_GOTO;
}

LABEL(f_nip) /* fnip ( r1 r2 -- r2 ) S0 -- S0  */
/*  */
NAME("fnip")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_nip)
NAME1("l2-f_nip")
NEXT_P1_5;
LABEL3(f_nip)
NAME1("l3-f_nip")
DO_GOTO;
}

LABEL(f_tuck) /* ftuck ( r1 r2 -- r2 r1 r2 ) S0 -- S0  */
/*  */
NAME("ftuck")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[2]);
vm_r2Float(r1,fp[1]);
vm_r2Float(r2,fp[0]);
LABEL2(f_tuck)
NAME1("l2-f_tuck")
NEXT_P1_5;
LABEL3(f_tuck)
NAME1("l3-f_tuck")
DO_GOTO;
}

LABEL(float_plus) /* float+ ( f_addr1 -- f_addr2 ) S0 -- S0  */
/* @code{1 floats +}. */
NAME("float+")
{
DEF_CA
MAYBE_UNUSED Float * f_addr1;
Float * f_addr2;
NEXT_P0;
vm_Cell2f_(sp[0],f_addr1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" f_addr1=", vm_out); printarg_f_(f_addr1);
}
#endif
{
f_addr2 = f_addr1+1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f_addr2=", vm_out); printarg_f_(f_addr2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f_2Cell(f_addr2,sp[0]);
LABEL2(float_plus)
NAME1("l2-float_plus")
NEXT_P1_5;
LABEL3(float_plus)
NAME1("l3-float_plus")
DO_GOTO;
}

LABEL(floats) /* floats ( n1 -- n2 ) S0 -- S0  */
/* @i{n2} is the number of address units of @i{n1} floats. */
NAME("floats")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1*sizeof(Float);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(floats)
NAME1("l2-floats")
NEXT_P1_5;
LABEL3(floats)
NAME1("l3-floats")
DO_GOTO;
}

LABEL(floor) /* floor ( r1 -- r2 ) S0 -- S0  */
/* Round towards the next smaller integral value, i.e., round toward negative infinity. */
NAME("floor")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
/* !! unclear wording */
CLOBBER_TOS_WORKAROUND_START;
r2 = floor(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(floor)
NAME1("l2-floor")
NEXT_P1_5;
LABEL3(floor)
NAME1("l3-floor")
DO_GOTO;
}

LABEL(f_round) /* fround ( r1 -- r2 ) S0 -- S0  */
/* Round to the nearest integral value. */
NAME("fround")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = rint(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_round)
NAME1("l2-f_round")
NEXT_P1_5;
LABEL3(f_round)
NAME1("l3-f_round")
DO_GOTO;
}

LABEL(f_max) /* fmax ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("fmax")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
if (r1<r2)
  r3 = r2;
else
  r3 = r1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_max)
NAME1("l2-f_max")
NEXT_P1_5;
LABEL3(f_max)
NAME1("l3-f_max")
DO_GOTO;
}

LABEL(f_min) /* fmin ( r1 r2 -- r3 ) S0 -- S0  */
/*  */
NAME("fmin")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
if (r1<r2)
  r3 = r1;
else
  r3 = r2;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_min)
NAME1("l2-f_min")
NEXT_P1_5;
LABEL3(f_min)
NAME1("l3-f_min")
DO_GOTO;
}

LABEL(represent) /* represent ( r c_addr u -- n f1 f2 ) S0 -- S0  */
/*  */
NAME("represent")
{
DEF_CA
MAYBE_UNUSED Float r;
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Cell n;
Bool f1;
Bool f2;
NEXT_P0;
vm_Float2r(fp[0],r);
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += -1;
fp += 1;
{
#ifdef ECVT_FLAG
char sig[0x40];
size_t siglen;
int flag;
int decpt;
if (isnan(r)) {
  flag=0;
  decpt=0;
  strncpy(sig, "nan", 0x3f); /* normalize nan output */
} else {
  ecvt_r(r, u, &decpt, &flag, sig, 0x3f);
}
n=(r==0. ? 1 : decpt);
flag=signbit(r); /* not all ecvt()s do this as desired */
f1=FLAG(flag!=0);
f2=FLAG(isdigit((unsigned)(sig[0]))!=0);
siglen=strlen((char *)sig);
if (siglen>u) /* happens in glibc-2.1.3 if 999.. is rounded up */
  siglen=u;
if (!f2) /* workaround Cygwin trailing 0s for Inf and Nan */
  for (; sig[siglen-1]=='0'; siglen--);
    ;
memmove(c_addr,sig,siglen);
memset(c_addr+siglen,f2?'0':' ',u-siglen);
#else
struct Cellpair fs = represent(r, c_addr, u, &n);
f1 = fs.n1;
f2 = fs.n2;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputs(" f1=", vm_out); printarg_f(f1);
fputs(" f2=", vm_out); printarg_f(f2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[2]);
vm_f2Cell(f1,sp[1]);
vm_f2Cell(f2,sp[0]);
LABEL2(represent)
NAME1("l2-represent")
NEXT_P1_5;
LABEL3(represent)
NAME1("l3-represent")
DO_GOTO;
}

LABEL(to_float) /* >float ( c_addr u -- f:... flag ) S0 -- S0  */
/* Actual stack effect: ( c_addr u -- r t | f ).  Attempt to convert the
character string @i{c-addr u} to internal floating-point
representation. If the string represents a valid floating-point number,
@i{r} is placed on the floating-point stack and @i{flag} is
true. Otherwise, @i{flag} is false. A string of blanks is a special
case and represents the floating-point number 0. */
NAME(">float")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
Bool flag;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr);
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
Float r;
flag = to_float(c_addr, u, &r, '.');
if (flag) {
  fp--;
  fp[0]=r;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" flag=", vm_out); printarg_f(flag);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(flag,sp[0]);
LABEL2(to_float)
NAME1("l2-to_float")
NEXT_P1_5;
LABEL3(to_float)
NAME1("l3-to_float")
DO_GOTO;
}

LABEL(f_abs) /* fabs ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fabs")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
r2 = fabs(r1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_abs)
NAME1("l2-f_abs")
NEXT_P1_5;
LABEL3(f_abs)
NAME1("l3-f_abs")
DO_GOTO;
}

LABEL(f_a_cos) /* facos ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("facos")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = acos(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_cos)
NAME1("l2-f_a_cos")
NEXT_P1_5;
LABEL3(f_a_cos)
NAME1("l3-f_a_cos")
DO_GOTO;
}

LABEL(f_a_sine) /* fasin ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fasin")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = asin(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_sine)
NAME1("l2-f_a_sine")
NEXT_P1_5;
LABEL3(f_a_sine)
NAME1("l3-f_a_sine")
DO_GOTO;
}

LABEL(f_a_tan) /* fatan ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fatan")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = atan(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_tan)
NAME1("l2-f_a_tan")
NEXT_P1_5;
LABEL3(f_a_tan)
NAME1("l3-f_a_tan")
DO_GOTO;
}

LABEL(f_a_tan_two) /* fatan2 ( r1 r2 -- r3 ) S0 -- S0  */
/* @i{r1/r2}=tan(@i{r3}). ANS Forth does not require, but probably
intends this to be the inverse of @code{fsincos}. In gforth it is. */
NAME("fatan2")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[1],r1);
vm_Float2r(fp[0],r2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
}
#endif
fp += 1;
{
CLOBBER_TOS_WORKAROUND_START;
r3 = atan2(r1,r2);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[0]);
LABEL2(f_a_tan_two)
NAME1("l2-f_a_tan_two")
NEXT_P1_5;
LABEL3(f_a_tan_two)
NAME1("l3-f_a_tan_two")
DO_GOTO;
}

LABEL(f_cos) /* fcos ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fcos")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = cos(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_cos)
NAME1("l2-f_cos")
NEXT_P1_5;
LABEL3(f_cos)
NAME1("l3-f_cos")
DO_GOTO;
}

LABEL(f_e_x_p) /* fexp ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fexp")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = exp(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_e_x_p)
NAME1("l2-f_e_x_p")
NEXT_P1_5;
LABEL3(f_e_x_p)
NAME1("l3-f_e_x_p")
DO_GOTO;
}

LABEL(f_e_x_p_m_one) /* fexpm1 ( r1 -- r2 ) S0 -- S0  */
/* @i{r2}=@i{e}**@i{r1}@minus{}1 */
NAME("fexpm1")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
#ifdef HAVE_EXPM1
extern double
#ifdef NeXT
              const
#endif
                    expm1(double);
CLOBBER_TOS_WORKAROUND_START;
r2 = expm1(r1);
#else
r2 = exp(r1)-1.;
#endif
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_e_x_p_m_one)
NAME1("l2-f_e_x_p_m_one")
NEXT_P1_5;
LABEL3(f_e_x_p_m_one)
NAME1("l3-f_e_x_p_m_one")
DO_GOTO;
}

LABEL(f_l_n) /* fln ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fln")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = log(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_l_n)
NAME1("l2-f_l_n")
NEXT_P1_5;
LABEL3(f_l_n)
NAME1("l3-f_l_n")
DO_GOTO;
}

LABEL(f_l_n_p_one) /* flnp1 ( r1 -- r2 ) S0 -- S0  */
/* @i{r2}=ln(@i{r1}+1) */
NAME("flnp1")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
#ifdef HAVE_LOG1P
extern double
#ifdef NeXT
              const
#endif
                    log1p(double);
CLOBBER_TOS_WORKAROUND_START;
r2 = log1p(r1);
#else
r2 = log(r1+1.);
#endif
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_l_n_p_one)
NAME1("l2-f_l_n_p_one")
NEXT_P1_5;
LABEL3(f_l_n_p_one)
NAME1("l3-f_l_n_p_one")
DO_GOTO;
}

LABEL(f_log) /* flog ( r1 -- r2 ) S0 -- S0  */
/* The decimal logarithm. */
NAME("flog")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = log10(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_log)
NAME1("l2-f_log")
NEXT_P1_5;
LABEL3(f_log)
NAME1("l3-f_log")
DO_GOTO;
}

LABEL(f_a_log) /* falog ( r1 -- r2 ) S0 -- S0  */
/* @i{r2}=10**@i{r1} */
NAME("falog")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
extern double pow10(double);
CLOBBER_TOS_WORKAROUND_START;
r2 = pow10(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_log)
NAME1("l2-f_a_log")
NEXT_P1_5;
LABEL3(f_a_log)
NAME1("l3-f_a_log")
DO_GOTO;
}

LABEL(f_sine) /* fsin ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fsin")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = sin(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_sine)
NAME1("l2-f_sine")
NEXT_P1_5;
LABEL3(f_sine)
NAME1("l3-f_sine")
DO_GOTO;
}

LABEL(f_sine_cos) /* fsincos ( r1 -- r2 r3 ) S0 -- S0  */
/* @i{r2}=sin(@i{r1}), @i{r3}=cos(@i{r1}) */
NAME("fsincos")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
Float r3;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
fp += -1;
{
CLOBBER_TOS_WORKAROUND_START;
sincos(r1, &r2, &r3);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputs(" r3=", vm_out); printarg_r(r3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[1]);
vm_r2Float(r3,fp[0]);
LABEL2(f_sine_cos)
NAME1("l2-f_sine_cos")
NEXT_P1_5;
LABEL3(f_sine_cos)
NAME1("l3-f_sine_cos")
DO_GOTO;
}

LABEL(f_square_root) /* fsqrt ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fsqrt")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = sqrt(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_square_root)
NAME1("l2-f_square_root")
NEXT_P1_5;
LABEL3(f_square_root)
NAME1("l3-f_square_root")
DO_GOTO;
}

LABEL(f_tan) /* ftan ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("ftan")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = tan(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_tan)
NAME1("l2-f_tan")
NEXT_P1_5;
LABEL3(f_tan)
NAME1("l3-f_tan")
DO_GOTO;
}

LABEL(f_cinch) /* fsinh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fsinh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = sinh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_cinch)
NAME1("l2-f_cinch")
NEXT_P1_5;
LABEL3(f_cinch)
NAME1("l3-f_cinch")
DO_GOTO;
}

LABEL(f_cosh) /* fcosh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fcosh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = cosh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_cosh)
NAME1("l2-f_cosh")
NEXT_P1_5;
LABEL3(f_cosh)
NAME1("l3-f_cosh")
DO_GOTO;
}

LABEL(f_tan_h) /* ftanh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("ftanh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = tanh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_tan_h)
NAME1("l2-f_tan_h")
NEXT_P1_5;
LABEL3(f_tan_h)
NAME1("l3-f_tan_h")
DO_GOTO;
}

LABEL(f_a_cinch) /* fasinh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fasinh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = asinh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_cinch)
NAME1("l2-f_a_cinch")
NEXT_P1_5;
LABEL3(f_a_cinch)
NAME1("l3-f_a_cinch")
DO_GOTO;
}

LABEL(f_a_cosh) /* facosh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("facosh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = acosh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_cosh)
NAME1("l2-f_a_cosh")
NEXT_P1_5;
LABEL3(f_a_cosh)
NAME1("l3-f_a_cosh")
DO_GOTO;
}

LABEL(f_a_tan_h) /* fatanh ( r1 -- r2 ) S0 -- S0  */
/*  */
NAME("fatanh")
{
DEF_CA
MAYBE_UNUSED Float r1;
Float r2;
NEXT_P0;
vm_Float2r(fp[0],r1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
}
#endif
{
CLOBBER_TOS_WORKAROUND_START;
r2 = atanh(r1);
CLOBBER_TOS_WORKAROUND_END;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r2=", vm_out); printarg_r(r2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r2,fp[0]);
LABEL2(f_a_tan_h)
NAME1("l2-f_a_tan_h")
NEXT_P1_5;
LABEL3(f_a_tan_h)
NAME1("l3-f_a_tan_h")
DO_GOTO;
}

LABEL(s_floats) /* sfloats ( n1 -- n2 ) S0 -- S0  */
/* @i{n2} is the number of address units of @i{n1}
single-precision IEEE floating-point numbers. */
NAME("sfloats")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1*sizeof(SFloat);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(s_floats)
NAME1("l2-s_floats")
NEXT_P1_5;
LABEL3(s_floats)
NAME1("l3-s_floats")
DO_GOTO;
}

LABEL(d_floats) /* dfloats ( n1 -- n2 ) S0 -- S0  */
/* @i{n2} is the number of address units of @i{n1}
double-precision IEEE floating-point numbers. */
NAME("dfloats")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1*sizeof(DFloat);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(d_floats)
NAME1("l2-d_floats")
NEXT_P1_5;
LABEL3(d_floats)
NAME1("l3-d_floats")
DO_GOTO;
}

LABEL(s_f_aligned) /* sfaligned ( c_addr -- sf_addr ) S0 -- S0  */
/* @i{sf-addr} is the first single-float-aligned address greater
than or equal to @i{c-addr}. */
NAME("sfaligned")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
SFloat * sf_addr;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
sf_addr = (SFloat *)((((Cell)c_addr)+(sizeof(SFloat)-1))&(-sizeof(SFloat)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" sf_addr=", vm_out); printarg_sf_(sf_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_sf_2Cell(sf_addr,sp[0]);
LABEL2(s_f_aligned)
NAME1("l2-s_f_aligned")
NEXT_P1_5;
LABEL3(s_f_aligned)
NAME1("l3-s_f_aligned")
DO_GOTO;
}

LABEL(d_f_aligned) /* dfaligned ( c_addr -- df_addr ) S0 -- S0  */
/* @i{df-addr} is the first double-float-aligned address greater
than or equal to @i{c-addr}. */
NAME("dfaligned")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
DFloat * df_addr;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
df_addr = (DFloat *)((((Cell)c_addr)+(sizeof(DFloat)-1))&(-sizeof(DFloat)));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" df_addr=", vm_out); printarg_df_(df_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_df_2Cell(df_addr,sp[0]);
LABEL2(d_f_aligned)
NAME1("l2-d_f_aligned")
NEXT_P1_5;
LABEL3(d_f_aligned)
NAME1("l3-d_f_aligned")
DO_GOTO;
}

LABEL(v_star) /* v* ( f_addr1 nstride1 f_addr2 nstride2 ucount -- r ) S0 -- S0  */
/* dot-product: r=v1*v2.  The first element of v1 is at f_addr1, the
next at f_addr1+nstride1 and so on (similar for v2). Both vectors have
ucount elements. */
NAME("v*")
{
DEF_CA
MAYBE_UNUSED Float * f_addr1;
MAYBE_UNUSED Cell nstride1;
MAYBE_UNUSED Float * f_addr2;
MAYBE_UNUSED Cell nstride2;
MAYBE_UNUSED UCell ucount;
Float r;
NEXT_P0;
vm_Cell2f_(sp[4],f_addr1);
vm_Cell2n(sp[3],nstride1);
vm_Cell2f_(sp[2],f_addr2);
vm_Cell2n(sp[1],nstride2);
vm_Cell2u(sp[0],ucount);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" f_addr1=", vm_out); printarg_f_(f_addr1);
fputs(" nstride1=", vm_out); printarg_n(nstride1);
fputs(" f_addr2=", vm_out); printarg_f_(f_addr2);
fputs(" nstride2=", vm_out); printarg_n(nstride2);
fputs(" ucount=", vm_out); printarg_u(ucount);
}
#endif
sp += 5;
fp += -1;
{
r = v_star(f_addr1, nstride1, f_addr2, nstride2, ucount);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(v_star)
NAME1("l2-v_star")
NEXT_P1_5;
LABEL3(v_star)
NAME1("l3-v_star")
DO_GOTO;
}

LABEL(faxpy) /* faxpy ( ra f_x nstridex f_y nstridey ucount -- ) S0 -- S0  */
/* vy=ra*vx+vy */
NAME("faxpy")
{
DEF_CA
MAYBE_UNUSED Float ra;
MAYBE_UNUSED Float * f_x;
MAYBE_UNUSED Cell nstridex;
MAYBE_UNUSED Float * f_y;
MAYBE_UNUSED Cell nstridey;
MAYBE_UNUSED UCell ucount;
NEXT_P0;
vm_Float2r(fp[0],ra);
vm_Cell2f_(sp[4],f_x);
vm_Cell2n(sp[3],nstridex);
vm_Cell2f_(sp[2],f_y);
vm_Cell2n(sp[1],nstridey);
vm_Cell2u(sp[0],ucount);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ra=", vm_out); printarg_r(ra);
fputs(" f_x=", vm_out); printarg_f_(f_x);
fputs(" nstridex=", vm_out); printarg_n(nstridex);
fputs(" f_y=", vm_out); printarg_f_(f_y);
fputs(" nstridey=", vm_out); printarg_n(nstridey);
fputs(" ucount=", vm_out); printarg_u(ucount);
}
#endif
sp += 5;
fp += 1;
{
faxpy(ra, f_x, nstridex, f_y, nstridey, ucount);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(faxpy)
NAME1("l2-faxpy")
NEXT_P1_5;
LABEL3(faxpy)
NAME1("l3-faxpy")
DO_GOTO;
}

LABEL(to_float1) /* >float1 ( c_addr u c -- f:... flag ) S0 -- S0  */
/* Actual stack effect: ( c_addr u c -- r t | f ).  Attempt to convert the
character string @i{c-addr u} to internal floating-point
representation, with @i{c} being the decimal separator.
If the string represents a valid floating-point number,
@i{r} is placed on the floating-point stack and @i{flag} is
true. Otherwise, @i{flag} is false. A string of blanks is a special
case and represents the floating-point number 0. */
NAME(">float1")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED UCell u;
MAYBE_UNUSED Char c;
Bool flag;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr);
vm_Cell2u(sp[1],u);
vm_Cell2c(sp[0],c);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputs(" c=", vm_out); printarg_c(c);
}
#endif
sp += 2;
{
Float r;
flag = to_float(c_addr, u, &r, c);
if (flag) {
  fp--;
  fp[0]=r;
}
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" flag=", vm_out); printarg_f(flag);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(flag,sp[0]);
LABEL2(to_float1)
NAME1("l2-to_float1")
NEXT_P1_5;
LABEL3(to_float1)
NAME1("l3-to_float1")
DO_GOTO;
}

LABEL(float_divide) /* float/ ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("float/")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 / sizeof(Float);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(float_divide)
NAME1("l2-float_divide")
NEXT_P1_5;
LABEL3(float_divide)
NAME1("l3-float_divide")
DO_GOTO;
}

LABEL(sfloat_divide) /* dfloat/ ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("dfloat/")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 / sizeof(DFloat);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(sfloat_divide)
NAME1("l2-sfloat_divide")
NEXT_P1_5;
LABEL3(sfloat_divide)
NAME1("l3-sfloat_divide")
DO_GOTO;
}

LABEL(dfloat_divide) /* sfloat/ ( n1 -- n2 ) S0 -- S0  */
/*  */
NAME("sfloat/")
{
DEF_CA
MAYBE_UNUSED Cell n1;
Cell n2;
NEXT_P0;
vm_Cell2n(sp[0],n1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n1=", vm_out); printarg_n(n1);
}
#endif
{
n2 = n1 / sizeof(SFloat);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(dfloat_divide)
NAME1("l2-dfloat_divide")
NEXT_P1_5;
LABEL3(dfloat_divide)
NAME1("l3-dfloat_divide")
DO_GOTO;
}

LABEL(f_not_rote) /* f-rot ( r1 r2 r3 -- r3 r1 r2 ) S0 -- S0  */
/*  */
NAME("f-rot")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
MAYBE_UNUSED Float r3;
NEXT_P0;
vm_Float2r(fp[2],r1);
vm_Float2r(fp[1],r2);
vm_Float2r(fp[0],r3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
fputs(" r3=", vm_out); printarg_r(r3);
}
#endif
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r3,fp[2]);
vm_r2Float(r1,fp[1]);
vm_r2Float(r2,fp[0]);
LABEL2(f_not_rote)
NAME1("l2-f_not_rote")
NEXT_P1_5;
LABEL3(f_not_rote)
NAME1("l3-f_not_rote")
DO_GOTO;
}

LABEL(flit) /* flit ( -- r1 ) S0 -- S0  */
/*  */
NAME("flit")
{
DEF_CA
Float r1;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
fp += -1;
{
r1 = *(Float*)ip;
INC_IP(sizeof(Float)/sizeof(Cell));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r1=", vm_out); printarg_r(r1);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r1,fp[0]);
LABEL2(flit)
NAME1("l2-flit")
NEXT_P1_5;
LABEL3(flit)
NAME1("l3-flit")
DO_GOTO;
}

GROUPADD(81)
#endif
GROUPADD(0)
#ifdef HAS_GLOCALS
GROUPADD(0)
GROUP( locals, 366)
LABEL(fetch_local_number) /* @local# ( #noffset -- w ) S0 -- S0  */
/*  */
NAME("@local#")
{
DEF_CA
MAYBE_UNUSED Cell noffset;
Cell w;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397805 ),noffset);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" noffset=", vm_out); printarg_n(noffset);
}
#endif
INC_IP(1);
sp += -1;
{
w = *(Cell *)(lp+noffset);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch_local_number)
NAME1("l2-fetch_local_number")
NEXT_P1_5;
LABEL3(fetch_local_number)
NAME1("l3-fetch_local_number")
DO_GOTO;
}

LABEL(fetch_local_zero) /* @local0 ( -- w ) S0 -- S0  */
/*  */
NAME("@local0")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = ((Cell *)lp)[0];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch_local_zero)
NAME1("l2-fetch_local_zero")
NEXT_P1_5;
LABEL3(fetch_local_zero)
NAME1("l3-fetch_local_zero")
DO_GOTO;
}

LABEL(fetch_local_four) /* @local1 ( -- w ) S0 -- S0  */
/*  */
NAME("@local1")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = ((Cell *)lp)[1];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch_local_four)
NAME1("l2-fetch_local_four")
NEXT_P1_5;
LABEL3(fetch_local_four)
NAME1("l3-fetch_local_four")
DO_GOTO;
}

LABEL(fetch_local_eight) /* @local2 ( -- w ) S0 -- S0  */
/*  */
NAME("@local2")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = ((Cell *)lp)[2];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch_local_eight)
NAME1("l2-fetch_local_eight")
NEXT_P1_5;
LABEL3(fetch_local_eight)
NAME1("l3-fetch_local_eight")
DO_GOTO;
}

LABEL(fetch_local_twelve) /* @local3 ( -- w ) S0 -- S0  */
/*  */
NAME("@local3")
{
DEF_CA
Cell w;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
w = ((Cell *)lp)[3];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" w=", vm_out); printarg_w(w);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_w2Cell(w,sp[0]);
LABEL2(fetch_local_twelve)
NAME1("l2-fetch_local_twelve")
NEXT_P1_5;
LABEL3(fetch_local_twelve)
NAME1("l3-fetch_local_twelve")
DO_GOTO;
}

GROUPADD(5)
#ifdef HAS_FLOATING
LABEL(f_fetch_local_number) /* f@local# ( #noffset -- r ) S0 -- S0  */
/*  */
NAME("f@local#")
{
DEF_CA
MAYBE_UNUSED Cell noffset;
Float r;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397806 ),noffset);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" noffset=", vm_out); printarg_n(noffset);
}
#endif
INC_IP(1);
fp += -1;
{
r = *(Float *)(lp+noffset);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(f_fetch_local_number)
NAME1("l2-f_fetch_local_number")
NEXT_P1_5;
LABEL3(f_fetch_local_number)
NAME1("l3-f_fetch_local_number")
DO_GOTO;
}

LABEL(f_fetch_local_zero) /* f@local0 ( -- r ) S0 -- S0  */
/*  */
NAME("f@local0")
{
DEF_CA
Float r;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
fp += -1;
{
r = ((Float *)lp)[0];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(f_fetch_local_zero)
NAME1("l2-f_fetch_local_zero")
NEXT_P1_5;
LABEL3(f_fetch_local_zero)
NAME1("l3-f_fetch_local_zero")
DO_GOTO;
}

LABEL(f_fetch_local_eight) /* f@local1 ( -- r ) S0 -- S0  */
/*  */
NAME("f@local1")
{
DEF_CA
Float r;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
fp += -1;
{
r = ((Float *)lp)[1];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r,fp[0]);
LABEL2(f_fetch_local_eight)
NAME1("l2-f_fetch_local_eight")
NEXT_P1_5;
LABEL3(f_fetch_local_eight)
NAME1("l3-f_fetch_local_eight")
DO_GOTO;
}

GROUPADD(3)
#endif
LABEL(laddr_number) /* laddr# ( #noffset -- c_addr ) S0 -- S0  */
/*  */
NAME("laddr#")
{
DEF_CA
MAYBE_UNUSED Cell noffset;
Char * c_addr;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397807 ),noffset);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" noffset=", vm_out); printarg_n(noffset);
}
#endif
INC_IP(1);
sp += -1;
{
/* this can also be used to implement lp@ */
c_addr = (Char *)(lp+noffset);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[0]);
LABEL2(laddr_number)
NAME1("l2-laddr_number")
NEXT_P1_5;
LABEL3(laddr_number)
NAME1("l3-laddr_number")
DO_GOTO;
}

LABEL(lp_plus_store_number) /* lp+!# ( #noffset -- ) S0 -- S0  */
/* used with negative immediate values it allocates memory on the
local stack, a positive immediate argument drops memory from the local
stack */
NAME("lp+!#")
{
DEF_CA
MAYBE_UNUSED Cell noffset;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397808 ),noffset);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" noffset=", vm_out); printarg_n(noffset);
}
#endif
INC_IP(1);
{
lp += noffset;
ALIVE_DEBUGGING(lp[-1]);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(lp_plus_store_number)
NAME1("l2-lp_plus_store_number")
NEXT_P1_5;
LABEL3(lp_plus_store_number)
NAME1("l3-lp_plus_store_number")
DO_GOTO;
}

LABEL(lp_minus) /* lp- ( -- ) S0 -- S0  */
/*  */
NAME("lp-")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
lp += -sizeof(Cell);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(lp_minus)
NAME1("l2-lp_minus")
NEXT_P1_5;
LABEL3(lp_minus)
NAME1("l3-lp_minus")
DO_GOTO;
}

LABEL(lp_plus) /* lp+ ( -- ) S0 -- S0  */
/*  */
NAME("lp+")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
lp += sizeof(Float);
ALIVE_DEBUGGING(lp[-1]);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(lp_plus)
NAME1("l2-lp_plus")
NEXT_P1_5;
LABEL3(lp_plus)
NAME1("l3-lp_plus")
DO_GOTO;
}

LABEL(lp_plus_two) /* lp+2 ( -- ) S0 -- S0  */
/*  */
NAME("lp+2")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
lp += 2*sizeof(Float);
ALIVE_DEBUGGING(lp[-1]);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(lp_plus_two)
NAME1("l2-lp_plus_two")
NEXT_P1_5;
LABEL3(lp_plus_two)
NAME1("l3-lp_plus_two")
DO_GOTO;
}

LABEL(lp_store) /* lp! ( c_addr -- ) S0 -- S0  */
/*  */
NAME("lp!")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 1;
{
lp = (Address)c_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(lp_store)
NAME1("l2-lp_store")
NEXT_P1_5;
LABEL3(lp_store)
NAME1("l3-lp_store")
DO_GOTO;
}

LABEL(to_l) /* >l ( w -- ) S0 -- S0  */
/*  */
NAME(">l")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(sp[0],w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
sp += 1;
{
lp -= sizeof(Cell);
*(Cell *)lp = w;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(to_l)
NAME1("l2-to_l")
NEXT_P1_5;
LABEL3(to_l)
NAME1("l3-to_l")
DO_GOTO;
}

GROUPADD(7)
#ifdef HAS_FLOATING
LABEL(f_to_l) /* f>l ( r -- ) S0 -- S0  */
/*  */
NAME("f>l")
{
DEF_CA
MAYBE_UNUSED Float r;
NEXT_P0;
vm_Float2r(fp[0],r);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r=", vm_out); printarg_r(r);
}
#endif
fp += 1;
{
lp -= sizeof(Float);
*(Float *)lp = r;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(f_to_l)
NAME1("l2-f_to_l")
NEXT_P1_5;
LABEL3(f_to_l)
NAME1("l3-f_to_l")
DO_GOTO;
}

LABEL(fpick) /* fpick ( f:... u -- f:... r ) S0 -- S0  */
/* Actually the stack effect is @code{ r0 ... ru u -- r0 ... ru r0 }. */
NAME("fpick")
{
DEF_CA
MAYBE_UNUSED UCell u;
Float r;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
r = fp[u];
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" r=", vm_out); printarg_r(r);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
fp += -1;
vm_r2Float(r,fp[0]);
LABEL2(fpick)
NAME1("l2-fpick")
NEXT_P1_5;
LABEL3(fpick)
NAME1("l3-fpick")
DO_GOTO;
}

LABEL(fthird) /* fthird ( r1 r2 r3 -- r1 r2 r3 r1 ) S0 -- S0  */
/*  */
NAME("fthird")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
MAYBE_UNUSED Float r3;
NEXT_P0;
vm_Float2r(fp[2],r1);
vm_Float2r(fp[1],r2);
vm_Float2r(fp[0],r3);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
fputs(" r3=", vm_out); printarg_r(r3);
}
#endif
fp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r1,fp[0]);
LABEL2(fthird)
NAME1("l2-fthird")
NEXT_P1_5;
LABEL3(fthird)
NAME1("l3-fthird")
DO_GOTO;
}

LABEL(ffourth) /* ffourth ( r1 r2 r3 r4 -- r1 r2 r3 r4 r1 ) S0 -- S0  */
/*  */
NAME("ffourth")
{
DEF_CA
MAYBE_UNUSED Float r1;
MAYBE_UNUSED Float r2;
MAYBE_UNUSED Float r3;
MAYBE_UNUSED Float r4;
NEXT_P0;
vm_Float2r(fp[3],r1);
vm_Float2r(fp[2],r2);
vm_Float2r(fp[1],r3);
vm_Float2r(fp[0],r4);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" r1=", vm_out); printarg_r(r1);
fputs(" r2=", vm_out); printarg_r(r2);
fputs(" r3=", vm_out); printarg_r(r3);
fputs(" r4=", vm_out); printarg_r(r4);
}
#endif
fp += -1;
{
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_r2Float(r1,fp[0]);
LABEL2(ffourth)
NAME1("l2-ffourth")
NEXT_P1_5;
LABEL3(ffourth)
NAME1("l3-ffourth")
DO_GOTO;
}

GROUPADD(4)
#endif
GROUPADD(0)
#endif
GROUPADD(0)
#ifdef HAS_OS
GROUPADD(0)
GROUP( syslib, 385)
LABEL(open_lib) /* open-lib ( c_addr1 u1 -- u2 ) S0 -- S0  */
/*  */
NAME("open-lib")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
UCell u2;
NEXT_P0;
vm_Cell2c_(sp[1],c_addr1);
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
sp += 1;
{
u2 = gforth_dlopen(c_addr1, u1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(open_lib)
NAME1("l2-open_lib")
NEXT_P1_5;
LABEL3(open_lib)
NAME1("l3-open_lib")
DO_GOTO;
}

LABEL(lib_sym) /* lib-sym ( c_addr1 u1 u2 -- u3 ) S0 -- S0  */
/*  */
NAME("lib-sym")
{
DEF_CA
MAYBE_UNUSED Char * c_addr1;
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED UCell u2;
UCell u3;
NEXT_P0;
vm_Cell2c_(sp[2],c_addr1);
vm_Cell2u(sp[1],u1);
vm_Cell2u(sp[0],u2);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr1=", vm_out); printarg_c_(c_addr1);
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" u2=", vm_out); printarg_u(u2);
}
#endif
sp += 2;
{
char * string = cstr(c_addr1, u1);
#ifdef HAVE_LIBLTDL
u3 = (UCell) lt_dlsym((lt_dlhandle)u2, string);
#elif defined(HAVE_LIBDL) || defined(HAVE_DLOPEN)
u3 = (UCell) dlsym((void*)u2,string);
#else
#  ifdef _WIN32
u3 = (Cell) GetProcAddress((HMODULE)u2, string);
#  else
#warning Define lib-sym!
u3 = 0;
#  endif
#endif
free_l(string);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u3=", vm_out); printarg_u(u3);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u3,sp[0]);
LABEL2(lib_sym)
NAME1("l2-lib_sym")
NEXT_P1_5;
LABEL3(lib_sym)
NAME1("l3-lib_sym")
DO_GOTO;
}

LABEL(wcall) /* wcall ( ... u -- ... ) S0 -- S0  */
/*  */
NAME("wcall")
{
DEF_CA
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
gforth_FP=fp;
sp=(Cell*)(SYSCALL(Cell*(*)(Cell *, void *))u)(sp, &gforth_FP);
fp=gforth_FP;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(wcall)
NAME1("l2-wcall")
NEXT_P1_5;
LABEL3(wcall)
NAME1("l3-wcall")
DO_GOTO;
}

LABEL(u_w_fetch) /* uw@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 16-bit value stored at @i{c_addr}. */
NAME("uw@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UWyde wy;
memmove((Char*)&wy, c_addr, 2);
u = wy;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(u_w_fetch)
NAME1("l2-u_w_fetch")
NEXT_P1_5;
LABEL3(u_w_fetch)
NAME1("l3-u_w_fetch")
DO_GOTO;
}

LABEL(s_w_fetch) /* sw@ ( c_addr -- n ) S0 -- S0  */
/* @i{n} is the sign-extended 16-bit value stored at @i{c_addr}. */
NAME("sw@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Cell n;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
Wyde wy;
memmove((Char*)&wy, c_addr, 2);
n = wy;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(s_w_fetch)
NAME1("l2-s_w_fetch")
NEXT_P1_5;
LABEL3(s_w_fetch)
NAME1("l3-s_w_fetch")
DO_GOTO;
}

LABEL(w_store) /* w! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 16 bits of @i{w} at @i{c_addr}. */
NAME("w!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
UWyde wy=w;
memmove(c_addr, (Char*)&wy, 2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(w_store)
NAME1("l2-w_store")
NEXT_P1_5;
LABEL3(w_store)
NAME1("l3-w_store")
DO_GOTO;
}

LABEL(u_l_fetch) /* ul@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 32-bit value stored at @i{c_addr}. */
NAME("ul@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UTetrabyte tb;
memmove((Char*)&tb, c_addr, 4);
u = tb;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(u_l_fetch)
NAME1("l2-u_l_fetch")
NEXT_P1_5;
LABEL3(u_l_fetch)
NAME1("l3-u_l_fetch")
DO_GOTO;
}

LABEL(s_l_fetch) /* sl@ ( c_addr -- n ) S0 -- S0  */
/* @i{n} is the sign-extended 32-bit value stored at @i{c_addr}. */
NAME("sl@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Cell n;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
Tetrabyte tb;
memmove((Char*)&tb, c_addr, 4);
n = tb;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(s_l_fetch)
NAME1("l2-s_l_fetch")
NEXT_P1_5;
LABEL3(s_l_fetch)
NAME1("l3-s_l_fetch")
DO_GOTO;
}

LABEL(l_store) /* l! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 32 bits of @i{w} at @i{c_addr}. */
NAME("l!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
UTetrabyte tb=w;
memmove(c_addr, (Char*)&tb, 4);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(l_store)
NAME1("l2-l_store")
NEXT_P1_5;
LABEL3(l_store)
NAME1("l3-l_store")
DO_GOTO;
}

LABEL(lib_error) /* lib-error ( -- c_addr u ) S0 -- S0  */
/* Error message for last failed @code{open-lib} or @code{lib-sym}. */
NAME("lib-error")
{
DEF_CA
Char * c_addr;
UCell u;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -2;
{
#ifdef HAVE_LIBLTDL
c_addr = (Char *)lt_dlerror();
u = (c_addr == NULL) ? 0 : strlen((char *)c_addr);
#elif defined(HAVE_LIBDL) || defined(HAVE_DLOPEN)
c_addr = (Char *)dlerror();
u = strlen((char *)c_addr);
#else
c_addr = "libltdl is not configured";
u = strlen((char *)c_addr);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[1]);
vm_u2Cell(u,sp[0]);
LABEL2(lib_error)
NAME1("l2-lib_error")
NEXT_P1_5;
LABEL3(lib_error)
NAME1("l3-lib_error")
DO_GOTO;
}

LABEL(w_store_be) /* be-w! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 16 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("be-w!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
#ifdef WORDS_BIGENDIAN
UWyde wy=w;
#else
UWyde wy=BSWAP16(w);
#endif
memmove(c_addr, (Char*)&wy, 2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(w_store_be)
NAME1("l2-w_store_be")
NEXT_P1_5;
LABEL3(w_store_be)
NAME1("l3-w_store_be")
DO_GOTO;
}

LABEL(l_store_be) /* be-l! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 32 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("be-l!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
#ifdef WORDS_BIGENDIAN
UTetrabyte tb=w;
#else
UTetrabyte tb=BSWAP32(w);
#endif
memmove(c_addr, (Char*)&tb, 4);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(l_store_be)
NAME1("l2-l_store_be")
NEXT_P1_5;
LABEL3(l_store_be)
NAME1("l3-l_store_be")
DO_GOTO;
}

LABEL(w_store_le) /* le-w! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 16 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("le-w!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
#ifndef WORDS_BIGENDIAN
UWyde wy=w;
#else
UWyde wy=BSWAP16(w);
#endif
memmove(c_addr, (Char*)&wy, 2);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(w_store_le)
NAME1("l2-w_store_le")
NEXT_P1_5;
LABEL3(w_store_le)
NAME1("l3-w_store_le")
DO_GOTO;
}

LABEL(l_store_le) /* le-l! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 32 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("le-l!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
#ifndef WORDS_BIGENDIAN
UTetrabyte tb=w;
#else
UTetrabyte tb=BSWAP32(w);
#endif
memmove(c_addr, (Char*)&tb, 4);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(l_store_le)
NAME1("l2-l_store_le")
NEXT_P1_5;
LABEL3(l_store_le)
NAME1("l3-l_store_le")
DO_GOTO;
}

LABEL(w_fetch_be) /* be-uw@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 16-bit big endian value stored at @i{c_addr}. */
NAME("be-uw@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UWyde wy;
memmove((Char*)&wy, c_addr, 2);
#ifdef WORDS_BIGENDIAN
u = wy;
#else
u = BSWAP16(wy);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(w_fetch_be)
NAME1("l2-w_fetch_be")
NEXT_P1_5;
LABEL3(w_fetch_be)
NAME1("l3-w_fetch_be")
DO_GOTO;
}

LABEL(l_fetch_be) /* be-ul@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 32-bit big endian value stored at @i{c_addr}. */
NAME("be-ul@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UTetrabyte tb;
memmove((Char*)&tb, c_addr, 4);
#ifdef WORDS_BIGENDIAN
u = tb;
#else
u = BSWAP32(tb);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(l_fetch_be)
NAME1("l2-l_fetch_be")
NEXT_P1_5;
LABEL3(l_fetch_be)
NAME1("l3-l_fetch_be")
DO_GOTO;
}

LABEL(w_fetch_le) /* le-uw@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 16-bit little endian value stored at @i{c_addr}. */
NAME("le-uw@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UWyde wy;
memmove((Char*)&wy, c_addr, 2);
#ifndef WORDS_BIGENDIAN
u = wy;
#else
u = BSWAP16(wy);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(w_fetch_le)
NAME1("l2-w_fetch_le")
NEXT_P1_5;
LABEL3(w_fetch_le)
NAME1("l3-w_fetch_le")
DO_GOTO;
}

LABEL(l_fetch_le) /* le-ul@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 32-bit little endian value stored at @i{c_addr}. */
NAME("le-ul@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UTetrabyte tb;
memmove((Char*)&tb, c_addr, 4);
#ifndef WORDS_BIGENDIAN
u = tb;
#else
u = BSWAP32(tb);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(l_fetch_le)
NAME1("l2-l_fetch_le")
NEXT_P1_5;
LABEL3(l_fetch_le)
NAME1("l3-l_fetch_le")
DO_GOTO;
}

LABEL(close_lib) /* close-lib ( u -- ) S0 -- S0  */
/*  */
NAME("close-lib")
{
DEF_CA
MAYBE_UNUSED UCell u;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
sp += 1;
{
gforth_dlclose(u);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(close_lib)
NAME1("l2-close_lib")
NEXT_P1_5;
LABEL3(close_lib)
NAME1("l3-close_lib")
DO_GOTO;
}

GROUPADD(19)
#endif
GROUPADD(0)
GROUP( 64bit, 404)
GROUPADD(0)
#ifdef HAS_64BIT
LABEL(x_store) /* x! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{w} at 64-bit-aligned @i{c_addr}. */
NAME("x!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
UOctabyte ob=w;
memmove(c_addr, (Char*)&ob, 8);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(x_store)
NAME1("l2-x_store")
NEXT_P1_5;
LABEL3(x_store)
NAME1("l3-x_store")
DO_GOTO;
}

LABEL(u_x_fetch) /* ux@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 64-bit value stored at 64-bit-aligned @i{c_addr}. */
NAME("ux@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
u = ob;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(u_x_fetch)
NAME1("l2-u_x_fetch")
NEXT_P1_5;
LABEL3(u_x_fetch)
NAME1("l3-u_x_fetch")
DO_GOTO;
}

LABEL(s_x_fetch) /* sx@ ( c_addr -- n ) S0 -- S0  */
/* @i{u} is the sign-extended 64-bit value stored at 64-bit-aligned @i{c_addr}. */
NAME("sx@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Cell n;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
Octabyte ob;
memmove((Char*)&ob, c_addr, 8);
n = ob;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(s_x_fetch)
NAME1("l2-s_x_fetch")
NEXT_P1_5;
LABEL3(s_x_fetch)
NAME1("l3-s_x_fetch")
DO_GOTO;
}

LABEL(b_e_x_store) /* be-x! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("be-x!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
UOctabyte ob;
#ifdef WORDS_BIGENDIAN
ob=w;
#else
ob=BSWAP64(w);
#endif
memmove(c_addr, (Char*)&ob, 8);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(b_e_x_store)
NAME1("l2-b_e_x_store")
NEXT_P1_5;
LABEL3(b_e_x_store)
NAME1("l3-b_e_x_store")
DO_GOTO;
}

LABEL(l_e_x_store) /* le-x! ( w c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{w} at @i{c_addr} in big endian format. */
NAME("le-x!")
{
DEF_CA
MAYBE_UNUSED Cell w;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2w(sp[1],w);
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 2;
{
UOctabyte ob;
#ifndef WORDS_BIGENDIAN
ob=w;
#else
ob=BSWAP64(w);
#endif
memmove(c_addr, (Char*)&ob, 8);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(l_e_x_store)
NAME1("l2-l_e_x_store")
NEXT_P1_5;
LABEL3(l_e_x_store)
NAME1("l3-l_e_x_store")
DO_GOTO;
}

LABEL(b_e_u_x_fetch) /* be-ux@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 64-bit big endian value stored at @i{c_addr}. */
NAME("be-ux@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
#ifdef WORDS_BIGENDIAN
u = ob;
#else
u=BSWAP64(ob);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(b_e_u_x_fetch)
NAME1("l2-b_e_u_x_fetch")
NEXT_P1_5;
LABEL3(b_e_u_x_fetch)
NAME1("l3-b_e_u_x_fetch")
DO_GOTO;
}

LABEL(l_e_u_x_fetch) /* le-ux@ ( c_addr -- u ) S0 -- S0  */
/* @i{u} is the zero-extended 64-bit little endian value stored at @i{c_addr}. */
NAME("le-ux@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UCell u;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
{
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
#ifndef WORDS_BIGENDIAN
u = ob;
#else
u=BSWAP64(ob);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u=", vm_out); printarg_u(u);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u,sp[0]);
LABEL2(l_e_u_x_fetch)
NAME1("l2-l_e_u_x_fetch")
NEXT_P1_5;
LABEL3(l_e_u_x_fetch)
NAME1("l3-l_e_u_x_fetch")
DO_GOTO;
}

GROUPADD(7)
#endif
GROUPADD(0)
GROUP( memory, 411)
LABEL(xd_store) /* xd! ( ud c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{ud} at 64-bit-aligned @i{c_addr}. */
NAME("xd!")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
#  ifdef WORDS_BIGENDIAN
UTetrabyte tb[2];
tb[0]=DHI(ud);
tb[1]=DLO(ud);
memmove(c_addr, (Char*)tb, 8);
#  else
UTetrabyte tb[2];
tb[1]=DHI(ud);
tb[0]=DLO(ud);
memmove(c_addr, (Char*)tb, 8);
#  endif
# else
UOctabyte ob=DLO(ud);
memmove(c_addr, (Char*)&ob, 8);
# endif
#else
UOctabyte ob=ud;
memmove(c_addr, (Char*)&ob, 8);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(xd_store)
NAME1("l2-xd_store")
NEXT_P1_5;
LABEL3(xd_store)
NAME1("l3-xd_store")
DO_GOTO;
}

LABEL(u_xd_fetch) /* uxd@ ( c_addr -- ud ) S0 -- S0  */
/* @i{ud} is the zero-extended 64-bit value stored at 64-bit-aligned @i{c_addr}. */
NAME("uxd@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UDCell ud;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += -1;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
memmove((Char*)tb, c_addr, 8);
#  ifdef WORDS_BIGENDIAN
D_IS(ud, tb[0], tb[1]);
#  else
D_IS(ud, tb[1], tb[0]);
#  endif
# else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
D_IS(ud, 0, ob);
# endif
#else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
ud = ob;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[1], sp[0])
LABEL2(u_xd_fetch)
NAME1("l2-u_xd_fetch")
NEXT_P1_5;
LABEL3(u_xd_fetch)
NAME1("l3-u_xd_fetch")
DO_GOTO;
}

LABEL(s_xd_fetch) /* sxd@ ( c_addr -- d ) S0 -- S0  */
/* @i{d} is the sign-extended 64-bit value stored at 64-bit-aligned @i{c_addr}. */
NAME("sxd@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
DCell d;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += -1;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
memmove((Char*)tb, c_addr, 8);
#  ifdef WORDS_BIGENDIAN
D_IS(d, tb[0], tb[1]);
#  else
D_IS(d, tb[1], tb[0]);
#  endif
# else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
D_IS(d, -(ob<0), ob);
# endif
#else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
d = ob;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" d=", vm_out); printarg_d(d);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_d2twoCell(d, sp[1], sp[0])
LABEL2(s_xd_fetch)
NAME1("l2-s_xd_fetch")
NEXT_P1_5;
LABEL3(s_xd_fetch)
NAME1("l3-s_xd_fetch")
DO_GOTO;
}

LABEL(b_e_xd_store) /* be-xd! ( ud c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{ud} at @i{c_addr} in big endian format. */
NAME("be-xd!")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
#  ifdef WORDS_BIGENDIAN
tb[0]=DHI(ud);
tb[1]=DLO(ud);
#  else
tb[0]=BSWAP32(DHI(ud));
tb[1]=BSWAP32(DLO(ud));
#  endif
memmove(c_addr, (Char*)tb, 8);
# else
UOctabyte ob;
#  ifdef WORDS_BIGENDIAN
ob=DLO(ud);
#  else
ob=BSWAP64(DLO(ud));
#  endif
memmove(c_addr, (Char*)&ob, 8);
# endif
#else
UOctabyte ob;
# ifdef WORDS_BIGENDIAN
ob=ud;
# else
ob=BSWAP64(ud);
# endif
memmove(c_addr, (Char*)&ob, 8);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(b_e_xd_store)
NAME1("l2-b_e_xd_store")
NEXT_P1_5;
LABEL3(b_e_xd_store)
NAME1("l3-b_e_xd_store")
DO_GOTO;
}

LABEL(l_e_xd_store) /* le-xd! ( ud c_addr -- ) S0 -- S0  */
/* Store the bottom 64 bits of @i{ud} at @i{c_addr} in big endian format. */
NAME("le-xd!")
{
DEF_CA
MAYBE_UNUSED UDCell ud;
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_twoCell2ud(sp[2], sp[1], ud)
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud=", vm_out); printarg_ud(ud);
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 3;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
#  ifndef WORDS_BIGENDIAN
tb[1]=DHI(ud);
tb[0]=DLO(ud);
#  else
tb[1]=BSWAP32(DHI(ud));
tb[0]=BSWAP32(DLO(ud));
#  endif
memmove(c_addr, (Char*)tb, 8);
# else
UOctabyte ob;
#  ifndef WORDS_BIGENDIAN
ob=DLO(ud);
#  else
ob=BSWAP64(DLO(ud));
#  endif
memmove(c_addr, (Char*)&ob, 8);
# endif
#else
UOctabyte ob;
# ifndef WORDS_BIGENDIAN
ob=ud;
# else
ob=BSWAP64(ud);
# endif
memmove(c_addr, (Char*)&ob, 8);
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(l_e_xd_store)
NAME1("l2-l_e_xd_store")
NEXT_P1_5;
LABEL3(l_e_xd_store)
NAME1("l3-l_e_xd_store")
DO_GOTO;
}

LABEL(b_e_u_xd_fetch) /* be-uxd@ ( c_addr -- ud ) S0 -- S0  */
/* @i{u} is the zero-extended 64-bit big endian value stored at @i{c_addr}. */
NAME("be-uxd@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UDCell ud;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += -1;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
memmove((Char*)tb, c_addr, 8);
#  ifdef WORDS_BIGENDIAN
D_IS(ud, tb[0], tb[1]);
#  else
D_IS(ud, BSWAP32(tb[0]), BSWAP32(tb[1]));
#  endif
# else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
#  ifdef WORDS_BIGENDIAN
D_IS(ud, 0, ob);
#  else
D_IS(ud, 0, BSWAP64(ob));
#  endif
# endif
#else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
# ifdef WORDS_BIGENDIAN
ud=ob;
# else
ud=BSWAP64(ob);
# endif
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[1], sp[0])
LABEL2(b_e_u_xd_fetch)
NAME1("l2-b_e_u_xd_fetch")
NEXT_P1_5;
LABEL3(b_e_u_xd_fetch)
NAME1("l3-b_e_u_xd_fetch")
DO_GOTO;
}

LABEL(l_e_u_xd_fetch) /* le-uxd@ ( c_addr -- ud ) S0 -- S0  */
/* @i{u} is the zero-extended 64-bit little endian value stored at @i{c_addr}. */
NAME("le-uxd@")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
UDCell ud;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += -1;
{
#ifdef BUGGY_LL_SIZE
# if (SIZEOF_CHAR_P == 4)
UTetrabyte tb[2];
memmove((Char*)tb, c_addr, 8);
#  ifndef WORDS_BIGENDIAN
D_IS(ud, tb[1], tb[0]);
#  else
D_IS(ud, BSWAP32(tb[1]), BSWAP32(tb[0]));
#  endif
# else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
#  ifndef WORDS_BIGENDIAN
D_IS(ud, 0, ob);
#  else
D_IS(ud, 0, BSWAP64(ob));
#  endif
# endif
#else
UOctabyte ob;
memmove((Char*)&ob, c_addr, 8);
# ifndef WORDS_BIGENDIAN
ud=ob;
# else
ud=BSWAP64(ob);
# endif
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud=", vm_out); printarg_ud(ud);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud, sp[1], sp[0])
LABEL2(l_e_u_xd_fetch)
NAME1("l2-l_e_u_xd_fetch")
NEXT_P1_5;
LABEL3(l_e_u_xd_fetch)
NAME1("l3-l_e_u_xd_fetch")
DO_GOTO;
}

LABEL(wordswap) /* w>< ( u1 -- u2 ) S0 -- S0  */
/*  */
NAME("w><")
{
DEF_CA
MAYBE_UNUSED UCell u1;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
u2=BSWAP16(u1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(wordswap)
NAME1("l2-wordswap")
NEXT_P1_5;
LABEL3(wordswap)
NAME1("l3-wordswap")
DO_GOTO;
}

LABEL(longswap) /* l>< ( u1 -- u2 ) S0 -- S0  */
/*  */
NAME("l><")
{
DEF_CA
MAYBE_UNUSED UCell u1;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
u2=BSWAP32(u1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(longswap)
NAME1("l2-longswap")
NEXT_P1_5;
LABEL3(longswap)
NAME1("l3-longswap")
DO_GOTO;
}

LABEL(extralongswap) /* x>< ( u1 -- u2 ) S0 -- S0  */
/*  */
NAME("x><")
{
DEF_CA
MAYBE_UNUSED UCell u1;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
u2=BSWAP64((uint64_t)u1);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(extralongswap)
NAME1("l2-extralongswap")
NEXT_P1_5;
LABEL3(extralongswap)
NAME1("l3-extralongswap")
DO_GOTO;
}

LABEL(extralongdswap) /* xd>< ( ud1 -- ud2 ) S0 -- S0  */
/*  */
NAME("xd><")
{
DEF_CA
MAYBE_UNUSED UDCell ud1;
UDCell ud2;
NEXT_P0;
vm_twoCell2ud(sp[1], sp[0], ud1)
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" ud1=", vm_out); printarg_ud(ud1);
}
#endif
{
#if SIZEOF_CHAR_P == 8
D_IS(ud2, 0LL, BSWAP64(DLO(ud1)));
#else
# ifdef BUGGY_LL_SWAP
D_IS(ud2, BSWAP32(DLO(ud1)), BSWAP32(DHI(ud1)));
# else
ud2=BSWAP64(ud1);
# endif
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" ud2=", vm_out); printarg_ud(ud2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_ud2twoCell(ud2, sp[1], sp[0])
LABEL2(extralongdswap)
NAME1("l2-extralongdswap")
NEXT_P1_5;
LABEL3(extralongdswap)
NAME1("l3-extralongdswap")
DO_GOTO;
}

LABEL(char_sext) /* c>s ( w1 -- n2 ) S0 -- S0  */
/*  */
NAME("c>s")
{
DEF_CA
MAYBE_UNUSED Cell w1;
Cell n2;
NEXT_P0;
vm_Cell2w(sp[0],w1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
}
#endif
{
n2=(signed char)w1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(char_sext)
NAME1("l2-char_sext")
NEXT_P1_5;
LABEL3(char_sext)
NAME1("l3-char_sext")
DO_GOTO;
}

LABEL(word_sext) /* w>s ( w1 -- n2 ) S0 -- S0  */
/*  */
NAME("w>s")
{
DEF_CA
MAYBE_UNUSED Cell w1;
Cell n2;
NEXT_P0;
vm_Cell2w(sp[0],w1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
}
#endif
{
n2=(Wyde)w1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(word_sext)
NAME1("l2-word_sext")
NEXT_P1_5;
LABEL3(word_sext)
NAME1("l3-word_sext")
DO_GOTO;
}

LABEL(long_sext) /* l>s ( w1 -- n2 ) S0 -- S0  */
/*  */
NAME("l>s")
{
DEF_CA
MAYBE_UNUSED Cell w1;
Cell n2;
NEXT_P0;
vm_Cell2w(sp[0],w1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w1=", vm_out); printarg_w(w1);
}
#endif
{
n2=(Tetrabyte)w1;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n2=", vm_out); printarg_n(n2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n2,sp[0]);
LABEL2(long_sext)
NAME1("l2-long_sext")
NEXT_P1_5;
LABEL3(long_sext)
NAME1("l3-long_sext")
DO_GOTO;
}

LABEL(to_pow2) /* >pow2 ( u1 -- u2 ) S0 -- S0  */
/*  */
NAME(">pow2")
{
DEF_CA
MAYBE_UNUSED UCell u1;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[0],u1);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
}
#endif
{
#ifdef HAVE___BUILTIN_CLZL
u2=(u1 == 1) ? u1 : // widely found bug for scanning 0
(((UCell)-1)>>__builtin_clzl(u1-1))+1;
#else
u1--;
u1 |= u1>>1;
u1 |= u1>>2;
u1 |= u1>>4;
u1 |= u1>>8;
u1 |= u1>>16;
#if SIZEOF_CHAR_P == 8
u1 |= u1>>32;
#endif
u2 = u1+1;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(to_pow2)
NAME1("l2-to_pow2")
NEXT_P1_5;
LABEL3(to_pow2)
NAME1("l3-to_pow2")
DO_GOTO;
}

LABEL(log2) /* log2 ( u -- n ) S0 -- S0  */
/* @i{N} is the rounded-down binary logarithm of @i{u}, i.e., the index of
the first set bit; if @i{u}=0, @i{n}=-1. */
NAME("log2")
{
DEF_CA
MAYBE_UNUSED UCell u;
Cell n;
NEXT_P0;
vm_Cell2u(sp[0],u);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u=", vm_out); printarg_u(u);
}
#endif
{
#ifdef HAVE___BUILTIN_CLZL
if (u==0)
   n=-1;
else
   n=(8*sizeof(long)-1)-__builtin_clzl(u);
#else /* !defined(HAVE___BUILTIN_CLZL) */
UCell s;
n = -(u==0);
#if SIZEOF_CHAR_P == 8
s = (u>0xffffffff) ? 32 : 0; n |= s; u >>= s;
#endif
s = (u>0xffff)     ? 16 : 0; n |= s; u >>= s;
s = (u>0xff)       ?  8 : 0; n |= s; u >>= s;
s = (u>0xf)        ?  4 : 0; n |= s; u >>= s;
s = (u>0x3)        ?  2 : 0; n |= s; u >>= s;
s = (u>0x1)        ?  1 : 0; n |= s;
#endif /* !defined(HAVE___BUILTIN_CLZL) */
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" n=", vm_out); printarg_n(n);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_n2Cell(n,sp[0]);
LABEL2(log2)
NAME1("l2-log2")
NEXT_P1_5;
LABEL3(log2)
NAME1("l3-log2")
DO_GOTO;
}

GROUPADD(16)
GROUP( atomic, 427)
LABEL(store_fetch) /* !@ ( u1 a_addr -- u2 ) S0 -- S0  */
/* load @var{u2} from @var{a_addr}, and store @var{u1} there, as atomic operation */
NAME("!@")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell * a_addr;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
#ifdef HAS_ATOMIC
u2 = __sync_lock_test_and_set(a_addr, u1);
#else
u2 = *a_addr;
*a_addr = u1;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(store_fetch)
NAME1("l2-store_fetch")
NEXT_P1_5;
LABEL3(store_fetch)
NAME1("l3-store_fetch")
DO_GOTO;
}

LABEL(add_store_fetch) /* +!@ ( u1 a_addr -- u2 ) S0 -- S0  */
/* load @var{u2} from @var{a_addr}, and increment this location by @var{u1}, as atomic operation */
NAME("+!@")
{
DEF_CA
MAYBE_UNUSED UCell u1;
MAYBE_UNUSED Cell * a_addr;
UCell u2;
NEXT_P0;
vm_Cell2u(sp[1],u1);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" u1=", vm_out); printarg_u(u1);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 1;
{
#ifdef HAS_ATOMIC
u2 = __sync_fetch_and_add(a_addr, u1);
#else
u2 = *a_addr;
*a_addr += u1;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" u2=", vm_out); printarg_u(u2);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(u2,sp[0]);
LABEL2(add_store_fetch)
NAME1("l2-add_store_fetch")
NEXT_P1_5;
LABEL3(add_store_fetch)
NAME1("l3-add_store_fetch")
DO_GOTO;
}

LABEL(question_store_fetch) /* ?!@ ( unew uold a_addr -- uprev ) S0 -- S0  */
/* load @var{uprev} from @var{a_addr}, compare it to @var{uold}, and if equal, store @var{unew} there, as atomic operation */
NAME("?!@")
{
DEF_CA
MAYBE_UNUSED UCell unew;
MAYBE_UNUSED UCell uold;
MAYBE_UNUSED Cell * a_addr;
UCell uprev;
NEXT_P0;
vm_Cell2u(sp[2],unew);
vm_Cell2u(sp[1],uold);
vm_Cell2a_(sp[0],a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" unew=", vm_out); printarg_u(unew);
fputs(" uold=", vm_out); printarg_u(uold);
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
sp += 2;
{
#ifdef HAS_ATOMIC
uprev = __sync_val_compare_and_swap(a_addr, uold, unew);
#else
uprev = *a_addr;
if(*a_addr == uold) *a_addr = unew;
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" uprev=", vm_out); printarg_u(uprev);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_u2Cell(uprev,sp[0]);
LABEL2(question_store_fetch)
NAME1("l2-question_store_fetch")
NEXT_P1_5;
LABEL3(question_store_fetch)
NAME1("l3-question_store_fetch")
DO_GOTO;
}

LABEL(barrier) /* barrier ( -- ) S0 -- S0  */
/* Insert a full memory barrier */
NAME("barrier")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
#ifdef HAS_ATOMIC
__sync_synchronize();
#endif
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(barrier)
NAME1("l2-barrier")
NEXT_P1_5;
LABEL3(barrier)
NAME1("l3-barrier")
DO_GOTO;
}

GROUPADD(4)
GROUP( peephole, 431)
GROUPADD(0)
#ifdef HAS_PEEPHOLE
LABEL(compile_prim1) /* compile-prim1 ( a_prim -- ) S0 -- S0  */
/* compile prim (incl. immargs) at @var{a_prim} */
NAME("compile-prim1")
{
DEF_CA
MAYBE_UNUSED Cell * a_prim;
NEXT_P0;
vm_Cell2a_(sp[0],a_prim);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_prim=", vm_out); printarg_a_(a_prim);
}
#endif
sp += 1;
{
compile_prim1(a_prim);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(compile_prim1)
NAME1("l2-compile_prim1")
NEXT_P1_5;
LABEL3(compile_prim1)
NAME1("l3-compile_prim1")
DO_GOTO;
}

LABEL(finish_code) /* finish-code ( ... -- ... ) S0 -- S0  */
/* Perform delayed steps in code generation (branch resolution, I-cache
flushing). */
NAME("finish-code")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
/* The ... above are a workaround for a bug in gcc-2.95, which fails
   to save spTOS (gforth-fast --enable-force-reg) */
finish_code();
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(finish_code)
NAME1("l2-finish_code")
NEXT_P1_5;
LABEL3(finish_code)
NAME1("l3-finish_code")
DO_GOTO;
}

LABEL(forget_dyncode) /* forget-dyncode ( c_code -- f ) S0 -- S0  */
/*  */
NAME("forget-dyncode")
{
DEF_CA
MAYBE_UNUSED Char * c_code;
Bool f;
NEXT_P0;
vm_Cell2c_(sp[0],c_code);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_code=", vm_out); printarg_c_(c_code);
}
#endif
{
f = forget_dyncode(c_code);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" f=", vm_out); printarg_f(f);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_f2Cell(f,sp[0]);
LABEL2(forget_dyncode)
NAME1("l2-forget_dyncode")
NEXT_P1_5;
LABEL3(forget_dyncode)
NAME1("l3-forget_dyncode")
DO_GOTO;
}

LABEL(decompile_prim) /* decompile-prim ( a_code -- a_prim ) S0 -- S0  */
/* a_prim is the code address of the primitive that has been
compile_prim1ed to a_code */
NAME("decompile-prim")
{
DEF_CA
MAYBE_UNUSED Cell * a_code;
Cell * a_prim;
NEXT_P0;
vm_Cell2a_(sp[0],a_code);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_code=", vm_out); printarg_a_(a_code);
}
#endif
{
a_prim = (Cell *)decompile_code((Label)a_code);
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_prim=", vm_out); printarg_a_(a_prim);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_prim,sp[0]);
LABEL2(decompile_prim)
NAME1("l2-decompile_prim")
NEXT_P1_5;
LABEL3(decompile_prim)
NAME1("l3-decompile_prim")
DO_GOTO;
}

LABEL(tag_offsets) /* tag-offsets ( -- a_addr ) S0 -- S0  */
/*  */
NAME("tag-offsets")
{
DEF_CA
Cell * a_addr;
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
sp += -1;
{
extern Cell groups[32];
a_addr = groups;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" a_addr=", vm_out); printarg_a_(a_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_a_2Cell(a_addr,sp[0]);
LABEL2(tag_offsets)
NAME1("l2-tag_offsets")
NEXT_P1_5;
LABEL3(tag_offsets)
NAME1("l3-tag_offsets")
DO_GOTO;
}

LABEL(finish_code_barrier) /* finish-code| ( ... -- ... ) S0 -- S0  */
/* Perform delayed steps in code generation (branch resolution, I-cache
flushing). */
NAME("finish-code|")
{
DEF_CA
NEXT_P0;
#ifdef VM_DEBUG
if (vm_debug) {
}
#endif
{
/* The ... above are a workaround for a bug in gcc-2.95, which fails
   to save spTOS (gforth-fast --enable-force-reg) */
finish_code_barrier();
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(finish_code_barrier)
NAME1("l2-finish_code_barrier")
NEXT_P1_5;
LABEL3(finish_code_barrier)
NAME1("l3-finish_code_barrier")
DO_GOTO;
}

GROUPADD(6)
#endif
GROUPADD(0)
GROUP( primitive_centric, 437)
LABEL(abi_call) /* abi-call ( #a_callee ... -- ... ) S0 -- S0  */
/*  */
NAME("abi-call")
{
DEF_CA
MAYBE_UNUSED Cell * a_callee;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397809 ),a_callee);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_callee=", vm_out); printarg_a_(a_callee);
}
#endif
INC_IP(1);
{
/* primitive for compiled ABI-CODE words */
abifunc *f = (abifunc *)a_callee;
Float *fp_mem = fp;
sp = (*f)(sp, &fp_mem);
fp = fp_mem;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(abi_call)
NAME1("l2-abi_call")
NEXT_P1_5;
LABEL3(abi_call)
NAME1("l3-abi_call")
DO_GOTO;
}

LABEL(semi_abi_code_exec) /* ;abi-code-exec ( #a_cfa ... -- ... ) S0 -- S0  */
/*  */
NAME(";abi-code-exec")
{
DEF_CA
MAYBE_UNUSED Cell * a_cfa;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397810 ),a_cfa);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_cfa=", vm_out); printarg_a_(a_cfa);
}
#endif
INC_IP(1);
{
/* primitive for performing ;ABI-CODE words */
Float *fp_mem = fp;
semiabifunc *f = (semiabifunc *)EXTRA_CODE(a_cfa);
Address body = (Address)PFA(a_cfa);
sp = (*f)(sp, &fp_mem, body);
fp = fp_mem;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(semi_abi_code_exec)
NAME1("l2-semi_abi_code_exec")
NEXT_P1_5;
LABEL3(semi_abi_code_exec)
NAME1("l3-semi_abi_code_exec")
DO_GOTO;
}

LABEL(lit_execute) /* lit-execute ( #a_addr -- ) S0 -- S0  */
/*  */
NAME("lit-execute")
{
DEF_CA
MAYBE_UNUSED Cell * a_addr;
NEXT_P0;
vm_Cell2a_(IMM_ARG(IPTOS,305397811 ),a_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" a_addr=", vm_out); printarg_a_(a_addr);
}
#endif
INC_IP(1);
{
/* for ;code and code words; a static superinstruction would be more general, 
   but VM_JUMP is currently not supported there */
ip=IP;
SUPER_END;
VM_JUMP(EXEC1((Xt)a_addr));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(lit_execute)
LABEL3(lit_execute)
DO_GOTO;
}

GROUPADD(3)
GROUP( object_pointer, 440)
GROUPADD(0)
#ifdef HAS_OBJECTS
LABEL(to_o) /* >o ( c_addr -- r:c_old ) S0 -- S0  */
/*  */
NAME(">o")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
Char * c_old;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
sp += 1;
rp += -1;
{
c_old = op;
op = c_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_old=", vm_out); printarg_c_(c_old);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_old,rp[0]);
LABEL2(to_o)
NAME1("l2-to_o")
NEXT_P1_5;
LABEL3(to_o)
NAME1("l3-to_o")
DO_GOTO;
}

LABEL(o_restore) /* o> ( r:c_addr -- ) S0 -- S0  */
/*  */
NAME("o>")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
NEXT_P0;
vm_Cell2c_(rp[0],c_addr);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
}
#endif
rp += 1;
{
op = c_addr;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
NEXT_P1;
LABEL2(o_restore)
NAME1("l2-o_restore")
NEXT_P1_5;
LABEL3(o_restore)
NAME1("l3-o_restore")
DO_GOTO;
}

LABEL(o_lit_plus) /* o#+ ( #w -- c_addr ) S0 -- S0  */
/*  */
NAME("o#+")
{
DEF_CA
MAYBE_UNUSED Cell w;
Char * c_addr;
NEXT_P0;
vm_Cell2w(IMM_ARG(IPTOS,305397812 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(1);
sp += -1;
{
c_addr = op + w;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[0]);
LABEL2(o_lit_plus)
NAME1("l2-o_lit_plus")
NEXT_P1_5;
LABEL3(o_lit_plus)
NAME1("l3-o_lit_plus")
DO_GOTO;
}

LABEL(o_lit_exec) /* o#exec ( #w -- ) S0 -- S0  */
/* method invocation, use index -1 of current op as vtable */
NAME("o#exec")
{
DEF_CA
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2w(IMM_ARG(IPTOS,305397813 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(1);
{
ip=IP;
SUPER_END;
VM_JUMP(EXEC1(((Xt**)op)[-1][w]));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(o_lit_exec)
LABEL3(o_lit_exec)
DO_GOTO;
}

LABEL(x_lit_exec) /* x#exec ( c_addr #w -- c_addr ) S0 -- S0  */
/* method invocation using the stack */
NAME("x#exec")
{
DEF_CA
MAYBE_UNUSED Char * c_addr;
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2c_(sp[0],c_addr);
vm_Cell2w(IMM_ARG(IPTOS,305397814 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(1);
{
ip=IP;
SUPER_END;
VM_JUMP(EXEC1(((Xt**)c_addr)[-1][w]));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(x_lit_exec)
LABEL3(x_lit_exec)
DO_GOTO;
}

LABEL(u_lit_exec) /* u#exec ( #n #w -- ) S0 -- S0  */
/* method invocation using a user address as current object */
NAME("u#exec")
{
DEF_CA
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell w;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397815 ),n);
vm_Cell2w(IMM_ARG(IP[1],305397816 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(2);
{
ip=IP;
SUPER_END;
VM_JUMP(EXEC1((*(Xt***)(((Address)up)+n))[-1][w]));
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputc('\n', vm_out);
}
#endif
LABEL2(u_lit_exec)
LABEL3(u_lit_exec)
DO_GOTO;
}

LABEL(u_lit_plus) /* u#+ ( #n #w -- c_addr ) S0 -- S0  */
/* instance variable using a user address as current object */
NAME("u#+")
{
DEF_CA
MAYBE_UNUSED Cell n;
MAYBE_UNUSED Cell w;
Char * c_addr;
NEXT_P0;
vm_Cell2n(IMM_ARG(IPTOS,305397817 ),n);
vm_Cell2w(IMM_ARG(IP[1],305397818 ),w);
#ifdef VM_DEBUG
if (vm_debug) {
fputs(" n=", vm_out); printarg_n(n);
fputs(" w=", vm_out); printarg_w(w);
}
#endif
INC_IP(2);
sp += -1;
{
c_addr = (*(Address*)(((Address)up)+n))+w;
}

#ifdef VM_DEBUG
if (vm_debug) {
fputs(" -- ", vm_out); fputs(" c_addr=", vm_out); printarg_c_(c_addr);
fputc('\n', vm_out);
}
#endif
NEXT_P1;
vm_c_2Cell(c_addr,sp[0]);
LABEL2(u_lit_plus)
NAME1("l2-u_lit_plus")
NEXT_P1_5;
LABEL3(u_lit_plus)
NAME1("l3-u_lit_plus")
DO_GOTO;
}

GROUPADD(7)
#endif
GROUPADD(0)
GROUP( static_super, 447)
GROUPADD(0)
GROUP( end, 447)
