#include <libcc.h>
#include <freetype-gl.h>
#ifdef __gnu_linux__
#undef stderr
extern struct _IO_FILE *stderr;
#endif
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_new_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)vector_new(x.spx[0]);
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_delete_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  vector_delete((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_get_an_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)vector_get((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_front_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)vector_front((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_back_a_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)vector_back((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_contains_aaa_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=vector_contains((void *)(x.spx[2]),(void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_empty_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=vector_empty((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_size_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=vector_size((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_reserve_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  vector_reserve((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_capacity_a_n(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=vector_capacity((void *)(x.spx[0]));
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_shrink_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  vector_shrink((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_clear_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  vector_clear((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_set_ana_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  vector_set((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_erase_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  vector_erase((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_erase_range_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  vector_erase_range((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_push_back_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  vector_push_back((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_pop_back_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  vector_pop_back((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_resize_an_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  vector_resize((void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_insert_ana_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  vector_insert((void *)(x.spx[2]),x.spx[1],(void *)(x.spx[0]));
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_insert_data_anan_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  vector_insert_data((void *)(x.spx[3]),x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 4;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_push_back_data_aan_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  vector_push_back_data((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_vector_sort_aa_v(GFORTH_ARGS)
{
  ARGN(1,-1);
  vector_sort((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_new_nnn_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)texture_atlas_new(x.spx[2],x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_delete_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  texture_atlas_delete((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
#define texture_atlas_get_regionp(self, w, h, x) { ivec4* _x=x; *_x=texture_atlas_get_region(self,w,h); }
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_get_regionp_anna_v(GFORTH_ARGS)
{
  ARGN(3,-1);
  texture_atlas_get_regionp((void *)(x.spx[3]),x.spx[2],x.spx[1],(void *)(x.spx[0]));
  x.spx += 4;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_set_region_annnnan_v(GFORTH_ARGS)
{
  ARGN(6,-1);
  texture_atlas_set_region((void *)(x.spx[6]),x.spx[5],x.spx[4],x.spx[3],x.spx[2],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 7;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_clear_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  texture_atlas_clear((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_atlas_enlarge_texture_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  texture_atlas_enlarge_texture((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_default_mode_n_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  texture_font_default_mode(x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_library_new__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)texture_library_new();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_new_from_file_ars_a(GFORTH_ARGS)
{
  ARGN(2,0);
  x.spx[2]=(Cell)texture_font_new_from_file((void *)(x.spx[2]),x.fpx[0],gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_new_from_memory_aran_a(GFORTH_ARGS)
{
  ARGN(2,0);
  x.spx[2]=(Cell)texture_font_new_from_memory((void *)(x.spx[2]),x.fpx[0],(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_clone_ar_a(GFORTH_ARGS)
{
  ARGN(0,0);
  x.spx[0]=(Cell)texture_font_clone((void *)(x.spx[0]),x.fpx[0]);
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_close_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  texture_font_close((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_delete_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  texture_font_delete((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_load_face_ar_n(GFORTH_ARGS)
{
  ARGN(0,0);
  x.spx[0]=texture_font_load_face((void *)(x.spx[0]),x.fpx[0]);
  x.fpx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_get_glyph_aa_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)texture_font_get_glyph((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_find_glyph_as_a(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=(Cell)texture_font_find_glyph((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_index_glyph_aau_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=texture_font_index_glyph((void *)(x.spx[2]),(void *)(x.spx[1]),x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_load_glyph_as_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=texture_font_load_glyph((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_get_glyph_gi_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)texture_font_get_glyph_gi((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_find_glyph_gi_au_a(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.spx[1]=(Cell)texture_font_find_glyph_gi((void *)(x.spx[1]),x.spx[0]);
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_load_glyph_gi_auu_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=texture_font_load_glyph_gi((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_load_glyphs_as_n(GFORTH_ARGS)
{
  ARGN(2,-1);
  x.spx[2]=texture_font_load_glyphs((void *)(x.spx[2]),gforth_str2c((Char*)x.spx[1],x.spx[0]));
  x.spx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_enlarge_atlas_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  texture_font_enlarge_atlas((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_enlarge_glyphs_arr_v(GFORTH_ARGS)
{
  ARGN(0,1);
  texture_font_enlarge_glyphs((void *)(x.spx[0]),x.fpx[1],x.fpx[0]);
  x.spx += 1;
  x.fpx += 2;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_font_enlarge_texture_ann_v(GFORTH_ARGS)
{
  ARGN(2,-1);
  texture_font_enlarge_texture((void *)(x.spx[2]),x.spx[1],x.spx[0]);
  x.spx += 3;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_glyph_get_kerning_aa_r(GFORTH_ARGS)
{
  ARGN(1,-1);
  x.fpx[-1]=texture_glyph_get_kerning((void *)(x.spx[1]),(void *)(x.spx[0]));
  x.spx += 2;
  x.fpx += -1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_glyph_new__a(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(Cell)texture_glyph_new();
  x.spx += -1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_texture_glyph_delete_a_v(GFORTH_ARGS)
{
  ARGN(0,-1);
  texture_glyph_delete((void *)(x.spx[0]));
  x.spx += 1;
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_freetype_gl_errstr_n_a(GFORTH_ARGS)
{
  ARGN(0,-1);
  x.spx[0]=(Cell)freetype_gl_errstr(x.spx[0]);
  return x;
}
gforth_stackpointers libgffreetype_gl_LTX_gforth_c_freetype_gl_errno__n(GFORTH_ARGS)
{
  ARGN(-1,-1);
  x.spx[-1]=(freetype_gl_errno);
  x.spx += -1;
  return x;
}
hash_128 gflibcc_hash_freetype_gl = "\x24\x70\xC3\xDA\xBC\xC6\xB8\x3B\xC4\xC8\xD0\xA5\x54\x8F\x6F\x73";
