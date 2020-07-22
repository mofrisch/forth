INST_ADDR(paren_docol),
INST_ADDR(paren_docon),
INST_ADDR(paren_dovar),
INST_ADDR(paren_douser),
INST_ADDR(paren_dodefer),
INST_ADDR(paren_field),
INST_ADDR(paren_doval),
INST_ADDR(paren_dodoes),
INST_ADDR(paren_doabicode),
INST_ADDR(paren_do_semicolon_abi_code),
GROUPADD(10)
GROUP( control, 10)
INST_ADDR(noop),
INST_ADDR(call),
INST_ADDR(execute),
INST_ADDR(perform),
INST_ADDR(semis),
INST_ADDR(execute_semis),
INST_ADDR(unloop),
INST_ADDR(lit_perform),
INST_ADDR(extra_xt),
GROUPADD(9)
#ifdef HAS_GLOCALS
INST_ADDR(branch_lp_plus_store_number),
GROUPADD(1)
#endif
INST_ADDR(branch),
INST_ADDR(question_branch),
GROUPADD(2)
#ifdef HAS_GLOCALS
INST_ADDR(question_branch_lp_plus_store_number),
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
INST_ADDR(question_dupe_question_branch),
INST_ADDR(question_dupe_zero_equals_question_branch),
GROUPADD(2)
#endif
INST_ADDR(paren_next),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_next_lp_plus_store_number),
GROUPADD(1)
#endif
INST_ADDR(paren_loop),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_loop_lp_plus_store_number),
GROUPADD(1)
#endif
INST_ADDR(paren_plus_loop),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_plus_loop_lp_plus_store_number),
GROUPADD(1)
#endif
GROUPADD(0)
#ifdef HAS_XCONDS
INST_ADDR(paren_minus_loop),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_minus_loop_lp_plus_store_number),
GROUPADD(1)
#endif
INST_ADDR(paren_slash_loop),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_slash_loop_lp_plus_store_number),
GROUPADD(1)
#endif
INST_ADDR(paren_symmetric_plus_loop),
GROUPADD(1)
#ifdef HAS_GLOCALS
INST_ADDR(paren_symmetric_plus_loop_lp_plus_store_number),
GROUPADD(1)
#endif
GROUPADD(0)
#endif
INST_ADDR(paren_for),
INST_ADDR(paren_do),
INST_ADDR(paren_question_do),
GROUPADD(3)
#ifdef HAS_XCONDS
INST_ADDR(paren_plus_do),
INST_ADDR(paren_u_plus_do),
INST_ADDR(paren_minus_do),
INST_ADDR(paren_u_minus_do),
INST_ADDR(paren_try),
INST_ADDR(uncatch),
INST_ADDR(fast_throw),
INST_ADDR(pushwrap),
INST_ADDR(dropwrap),
INST_ADDR(exit_wrap),
GROUPADD(10)
#endif
INST_ADDR(i),
INST_ADDR(i_tick),
INST_ADDR(j),
INST_ADDR(k),
GROUPADD(4)
GROUP( strings, 54)
INST_ADDR(move),
INST_ADDR(c_move),
INST_ADDR(c_move_up),
INST_ADDR(fill),
INST_ADDR(compare),
INST_ADDR(toupper),
INST_ADDR(capscompare),
INST_ADDR(slash_string),
INST_ADDR(safe_slash_string),
GROUPADD(9)
GROUP( arith, 63)
INST_ADDR(lit),
INST_ADDR(plus),
INST_ADDR(lit_plus),
INST_ADDR(under_plus),
INST_ADDR(minus),
INST_ADDR(negate),
INST_ADDR(one_plus),
INST_ADDR(one_minus),
INST_ADDR(max),
INST_ADDR(min),
INST_ADDR(abs),
INST_ADDR(star),
INST_ADDR(slash_f),
INST_ADDR(modf),
INST_ADDR(slash_mod_f),
INST_ADDR(star_slash_mod_f),
INST_ADDR(star_slash_f),
INST_ADDR(slash_s),
INST_ADDR(mod_s),
INST_ADDR(slash_mod_s),
INST_ADDR(star_slash_mod_s),
INST_ADDR(star_slash_s),
INST_ADDR(two_star),
INST_ADDR(two_slash),
INST_ADDR(f_m_slash_mod),
INST_ADDR(s_m_slash_rem),
INST_ADDR(m_star),
INST_ADDR(u_m_star),
INST_ADDR(u_m_slash_mod),
INST_ADDR(u_slash_stage2m),
INST_ADDR(u_mod_stage2m),
INST_ADDR(u_slash_mod_stage2m),
INST_ADDR(slash_f_stage2m),
INST_ADDR(mod_f_stage2m),
INST_ADDR(slash_mod_f_stage2m),
INST_ADDR(m_plus),
INST_ADDR(d_plus),
INST_ADDR(d_minus),
INST_ADDR(d_negate),
INST_ADDR(d_two_star),
INST_ADDR(d_two_slash),
INST_ADDR(and),
INST_ADDR(or),
INST_ADDR(x_or),
INST_ADDR(invert),
INST_ADDR(r_shift),
INST_ADDR(l_shift),
INST_ADDR(umax),
INST_ADDR(umin),
INST_ADDR(mux),
INST_ADDR(select),
INST_ADDR(dlshift),
INST_ADDR(drshift),
INST_ADDR(rol),
INST_ADDR(ror),
INST_ADDR(drol),
INST_ADDR(dror),
INST_ADDR(du_slash_mod),
INST_ADDR(u_slash),
INST_ADDR(umod),
INST_ADDR(u_slash_mod),
INST_ADDR(u_star_slash_mod),
INST_ADDR(u_star_slash),
INST_ADDR(ar_shift),
INST_ADDR(darshift),
GROUPADD(65)
GROUP( compare, 128)
INST_ADDR(zero_equals),
INST_ADDR(zero_not_equals),
INST_ADDR(zero_less_than),
INST_ADDR(zero_greater_than),
INST_ADDR(zero_less_or_equal),
INST_ADDR(zero_greater_or_equal),
INST_ADDR(equals),
INST_ADDR(not_equals),
INST_ADDR(less_than),
INST_ADDR(greater_than),
INST_ADDR(less_or_equal),
INST_ADDR(greater_or_equal),
INST_ADDR(u_equals),
INST_ADDR(u_not_equals),
INST_ADDR(u_less_than),
INST_ADDR(u_greater_than),
INST_ADDR(u_less_or_equal),
INST_ADDR(u_greater_or_equal),
GROUPADD(18)
#ifdef HAS_DCOMPS
INST_ADDR(d_equals),
INST_ADDR(d_not_equals),
INST_ADDR(d_less_than),
INST_ADDR(d_greater_than),
INST_ADDR(d_less_or_equal),
INST_ADDR(d_greater_or_equal),
INST_ADDR(d_zero_equals),
INST_ADDR(d_zero_not_equals),
INST_ADDR(d_zero_less_than),
INST_ADDR(d_zero_greater_than),
INST_ADDR(d_zero_less_or_equal),
INST_ADDR(d_zero_greater_or_equal),
INST_ADDR(d_u_equals),
INST_ADDR(d_u_not_equals),
INST_ADDR(d_u_less_than),
INST_ADDR(d_u_greater_than),
INST_ADDR(d_u_less_or_equal),
INST_ADDR(d_u_greater_or_equal),
GROUPADD(18)
#endif
INST_ADDR(within),
GROUPADD(1)
GROUP( stack, 165)
INST_ADDR(useraddr),
INST_ADDR(up_store),
INST_ADDR(sp_fetch),
INST_ADDR(sp_store),
INST_ADDR(rp_fetch),
INST_ADDR(rp_store),
GROUPADD(6)
#ifdef HAS_FLOATING
INST_ADDR(fp_fetch),
INST_ADDR(fp_store),
GROUPADD(2)
#endif
INST_ADDR(to_r),
INST_ADDR(r_from),
INST_ADDR(rdrop),
INST_ADDR(two_to_r),
INST_ADDR(two_r_from),
INST_ADDR(two_r_fetch),
INST_ADDR(two_r_drop),
INST_ADDR(over),
INST_ADDR(drop),
INST_ADDR(swap),
INST_ADDR(dupe),
INST_ADDR(rote),
INST_ADDR(not_rote),
INST_ADDR(nip),
INST_ADDR(tuck),
INST_ADDR(question_dupe),
INST_ADDR(pick),
INST_ADDR(third),
INST_ADDR(fourth),
INST_ADDR(two_drop),
INST_ADDR(two_dupe),
INST_ADDR(two_over),
INST_ADDR(two_swap),
INST_ADDR(two_rote),
INST_ADDR(two_nip),
INST_ADDR(two_tuck),
INST_ADDR(user_fetch),
INST_ADDR(sps_fetch),
GROUPADD(28)
GROUP( memory, 201)
INST_ADDR(fetch),
INST_ADDR(lit_fetch),
INST_ADDR(store),
INST_ADDR(plus_store),
INST_ADDR(c_fetch),
INST_ADDR(c_store),
INST_ADDR(two_store),
INST_ADDR(two_fetch),
INST_ADDR(cell_plus),
INST_ADDR(cells),
INST_ADDR(char_plus),
INST_ADDR(paren_chars),
INST_ADDR(count),
INST_ADDR(cell_divide),
INST_ADDR(cell_minus),
INST_ADDR(one_plus_store),
GROUPADD(16)
GROUP( compiler, 217)
GROUPADD(0)
#ifdef HAS_F83HEADERSTRING
INST_ADDR(paren_f83find),
GROUPADD(1)
#else /* 218 */
INST_ADDR(paren_listlfind),
GROUPADD(1)
#ifdef HAS_HASH
INST_ADDR(paren_hashlfind),
INST_ADDR(paren_tablelfind),
INST_ADDR(paren_hashkey1),
INST_ADDR(paren_hashkey2),
INST_ADDR(hashkey2),
GROUPADD(5)
#endif
GROUPADD(0)
#endif
INST_ADDR(paren_parse_white),
INST_ADDR(scan),
INST_ADDR(skip),
INST_ADDR(aligned),
INST_ADDR(f_aligned),
INST_ADDR(threading_method),
INST_ADDR(debugging_method),
GROUPADD(7)
GROUP( hostos, 231)
INST_ADDR(paren_key_file),
INST_ADDR(key_q_file),
INST_ADDR(stdin),
INST_ADDR(stdout),
INST_ADDR(stderr),
INST_ADDR(term_prep_q),
GROUPADD(6)
#ifdef HAS_OS
INST_ADDR(paren_form),
INST_ADDR(isatty),
INST_ADDR(isfg),
INST_ADDR(wcwidth),
INST_ADDR(flush_icache),
INST_ADDR(paren_bye),
INST_ADDR(paren_system),
INST_ADDR(getenv),
INST_ADDR(open_pipe),
INST_ADDR(close_pipe),
INST_ADDR(time_and_date),
INST_ADDR(paren_ms),
INST_ADDR(heap_allocate),
INST_ADDR(heap_free),
INST_ADDR(heap_resize),
INST_ADDR(strerror),
INST_ADDR(strsignal),
INST_ADDR(call_c),
INST_ADDR(call_c_direct),
INST_ADDR(get_gforth_pointers),
GROUPADD(20)
#endif
GROUPADD(0)
#ifdef HAS_FILE
INST_ADDR(close_file),
INST_ADDR(open_file),
INST_ADDR(create_file),
INST_ADDR(delete_file),
INST_ADDR(rename_file),
INST_ADDR(file_position),
INST_ADDR(reposition_file),
INST_ADDR(file_size),
INST_ADDR(resize_file),
INST_ADDR(read_file),
INST_ADDR(paren_read_line),
GROUPADD(11)
#endif
INST_ADDR(write_file),
INST_ADDR(emit_file),
GROUPADD(2)
#ifdef HAS_FILE
INST_ADDR(flush_file),
INST_ADDR(file_status),
INST_ADDR(file_eof_query),
INST_ADDR(open_dir),
INST_ADDR(read_dir),
INST_ADDR(close_dir),
INST_ADDR(match_file),
INST_ADDR(set_dir),
INST_ADDR(get_dir),
INST_ADDR(equals_mkdir),
GROUPADD(10)
#endif
INST_ADDR(newline),
GROUPADD(1)
#ifdef HAS_OS
INST_ADDR(utime),
INST_ADDR(cputime),
INST_ADDR(ntime),
INST_ADDR(paren_ns),
GROUPADD(4)
#endif
GROUPADD(0)
#ifdef HAS_FLOATING
GROUPADD(0)
GROUP( floating, 285)
INST_ADDR(f_equals),
INST_ADDR(f_not_equals),
INST_ADDR(f_less_than),
INST_ADDR(f_greater_than),
INST_ADDR(f_less_or_equal),
INST_ADDR(f_greater_or_equal),
INST_ADDR(f_zero_equals),
INST_ADDR(f_zero_not_equals),
INST_ADDR(f_zero_less_than),
INST_ADDR(f_zero_greater_than),
INST_ADDR(f_zero_less_or_equal),
INST_ADDR(f_zero_greater_or_equal),
INST_ADDR(s_to_f),
INST_ADDR(d_to_f),
INST_ADDR(f_to_d),
INST_ADDR(f_to_s),
INST_ADDR(f_store),
INST_ADDR(f_fetch),
INST_ADDR(d_f_fetch),
INST_ADDR(d_f_store),
INST_ADDR(s_f_fetch),
INST_ADDR(s_f_store),
INST_ADDR(f_plus),
INST_ADDR(f_minus),
INST_ADDR(f_star),
INST_ADDR(f_slash),
INST_ADDR(f_star_star),
INST_ADDR(fm_star),
INST_ADDR(fm_slash),
INST_ADDR(fm_star_slash),
INST_ADDR(fm_square),
INST_ADDR(f_negate),
INST_ADDR(f_drop),
INST_ADDR(f_dupe),
INST_ADDR(f_swap),
INST_ADDR(f_over),
INST_ADDR(f_rote),
INST_ADDR(f_nip),
INST_ADDR(f_tuck),
INST_ADDR(float_plus),
INST_ADDR(floats),
INST_ADDR(floor),
INST_ADDR(f_round),
INST_ADDR(f_max),
INST_ADDR(f_min),
INST_ADDR(represent),
INST_ADDR(to_float),
INST_ADDR(f_abs),
INST_ADDR(f_a_cos),
INST_ADDR(f_a_sine),
INST_ADDR(f_a_tan),
INST_ADDR(f_a_tan_two),
INST_ADDR(f_cos),
INST_ADDR(f_e_x_p),
INST_ADDR(f_e_x_p_m_one),
INST_ADDR(f_l_n),
INST_ADDR(f_l_n_p_one),
INST_ADDR(f_log),
INST_ADDR(f_a_log),
INST_ADDR(f_sine),
INST_ADDR(f_sine_cos),
INST_ADDR(f_square_root),
INST_ADDR(f_tan),
INST_ADDR(f_cinch),
INST_ADDR(f_cosh),
INST_ADDR(f_tan_h),
INST_ADDR(f_a_cinch),
INST_ADDR(f_a_cosh),
INST_ADDR(f_a_tan_h),
INST_ADDR(s_floats),
INST_ADDR(d_floats),
INST_ADDR(s_f_aligned),
INST_ADDR(d_f_aligned),
INST_ADDR(v_star),
INST_ADDR(faxpy),
INST_ADDR(to_float1),
INST_ADDR(float_divide),
INST_ADDR(sfloat_divide),
INST_ADDR(dfloat_divide),
INST_ADDR(f_not_rote),
INST_ADDR(flit),
GROUPADD(81)
#endif
GROUPADD(0)
#ifdef HAS_GLOCALS
GROUPADD(0)
GROUP( locals, 366)
INST_ADDR(fetch_local_number),
INST_ADDR(fetch_local_zero),
INST_ADDR(fetch_local_four),
INST_ADDR(fetch_local_eight),
INST_ADDR(fetch_local_twelve),
GROUPADD(5)
#ifdef HAS_FLOATING
INST_ADDR(f_fetch_local_number),
INST_ADDR(f_fetch_local_zero),
INST_ADDR(f_fetch_local_eight),
GROUPADD(3)
#endif
INST_ADDR(laddr_number),
INST_ADDR(lp_plus_store_number),
INST_ADDR(lp_minus),
INST_ADDR(lp_plus),
INST_ADDR(lp_plus_two),
INST_ADDR(lp_store),
INST_ADDR(to_l),
GROUPADD(7)
#ifdef HAS_FLOATING
INST_ADDR(f_to_l),
INST_ADDR(fpick),
INST_ADDR(fthird),
INST_ADDR(ffourth),
GROUPADD(4)
#endif
GROUPADD(0)
#endif
GROUPADD(0)
#ifdef HAS_OS
GROUPADD(0)
GROUP( syslib, 385)
INST_ADDR(open_lib),
INST_ADDR(lib_sym),
INST_ADDR(wcall),
INST_ADDR(u_w_fetch),
INST_ADDR(s_w_fetch),
INST_ADDR(w_store),
INST_ADDR(u_l_fetch),
INST_ADDR(s_l_fetch),
INST_ADDR(l_store),
INST_ADDR(lib_error),
INST_ADDR(w_store_be),
INST_ADDR(l_store_be),
INST_ADDR(w_store_le),
INST_ADDR(l_store_le),
INST_ADDR(w_fetch_be),
INST_ADDR(l_fetch_be),
INST_ADDR(w_fetch_le),
INST_ADDR(l_fetch_le),
INST_ADDR(close_lib),
GROUPADD(19)
#endif
GROUPADD(0)
GROUP( 64bit, 404)
GROUPADD(0)
#ifdef HAS_64BIT
INST_ADDR(x_store),
INST_ADDR(u_x_fetch),
INST_ADDR(s_x_fetch),
INST_ADDR(b_e_x_store),
INST_ADDR(l_e_x_store),
INST_ADDR(b_e_u_x_fetch),
INST_ADDR(l_e_u_x_fetch),
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( memory, 411)
INST_ADDR(xd_store),
INST_ADDR(u_xd_fetch),
INST_ADDR(s_xd_fetch),
INST_ADDR(b_e_xd_store),
INST_ADDR(l_e_xd_store),
INST_ADDR(b_e_u_xd_fetch),
INST_ADDR(l_e_u_xd_fetch),
INST_ADDR(wordswap),
INST_ADDR(longswap),
INST_ADDR(extralongswap),
INST_ADDR(extralongdswap),
INST_ADDR(char_sext),
INST_ADDR(word_sext),
INST_ADDR(long_sext),
INST_ADDR(to_pow2),
INST_ADDR(log2),
GROUPADD(16)
GROUP( atomic, 427)
INST_ADDR(store_fetch),
INST_ADDR(add_store_fetch),
INST_ADDR(question_store_fetch),
INST_ADDR(barrier),
GROUPADD(4)
GROUP( peephole, 431)
GROUPADD(0)
#ifdef HAS_PEEPHOLE
INST_ADDR(compile_prim1),
INST_ADDR(finish_code),
INST_ADDR(forget_dyncode),
INST_ADDR(decompile_prim),
INST_ADDR(tag_offsets),
INST_ADDR(finish_code_barrier),
GROUPADD(6)
#endif
GROUPADD(0)
GROUP( primitive_centric, 437)
INST_ADDR(abi_call),
INST_ADDR(semi_abi_code_exec),
INST_ADDR(lit_execute),
GROUPADD(3)
GROUP( object_pointer, 440)
GROUPADD(0)
#ifdef HAS_OBJECTS
INST_ADDR(to_o),
INST_ADDR(o_restore),
INST_ADDR(o_lit_plus),
INST_ADDR(o_lit_exec),
INST_ADDR(x_lit_exec),
INST_ADDR(u_lit_exec),
INST_ADDR(u_lit_plus),
GROUPADD(7)
#endif
GROUPADD(0)
GROUP( static_super, 447)
GROUPADD(0)
GROUP( end, 447)
