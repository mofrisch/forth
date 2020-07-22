\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library soil2
s" soil2" add-lib
e? os-type s" linux-android" string-prefix? [IF]
    s" EGL" add-lib
    s" GLESv2" add-lib
    s" m" add-lib
[THEN]
\c #include <SOIL2.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ --------===< enums >===---------
#0	constant SOIL_LOAD_AUTO
#1	constant SOIL_LOAD_L
#2	constant SOIL_LOAD_LA
#3	constant SOIL_LOAD_RGB
#4	constant SOIL_LOAD_RGBA
#0	constant SOIL_CREATE_NEW_ID
#1	constant SOIL_FLAG_POWER_OF_TWO
#2	constant SOIL_FLAG_MIPMAPS
#4	constant SOIL_FLAG_TEXTURE_REPEATS
#8	constant SOIL_FLAG_MULTIPLY_ALPHA
#16	constant SOIL_FLAG_INVERT_Y
#32	constant SOIL_FLAG_COMPRESS_TO_DXT
#64	constant SOIL_FLAG_DDS_LOAD_DIRECT
#128	constant SOIL_FLAG_NTSC_SAFE_RGB
#256	constant SOIL_FLAG_CoCg_Y
#512	constant SOIL_FLAG_TEXTURE_RECTANGLE
#1024	constant SOIL_FLAG_PVR_LOAD_DIRECT
#2048	constant SOIL_FLAG_ETC1_LOAD_DIRECT
#4096	constant SOIL_FLAG_GL_MIPMAPS
#8192	constant SOIL_FLAG_SRGB_COLOR_SPACE
#0	constant SOIL_SAVE_TYPE_TGA
#1	constant SOIL_SAVE_TYPE_BMP
#2	constant SOIL_SAVE_TYPE_PNG
#3	constant SOIL_SAVE_TYPE_DDS
#4	constant SOIL_SAVE_TYPE_JPG
#0	constant SOIL_HDR_RGBE
#1	constant SOIL_HDR_RGBdivA
#2	constant SOIL_HDR_RGBdivA2

\ ------===< functions >===-------
c-function SOIL_load_OGL_texture SOIL_load_OGL_texture s n u u -- u	( filename force_channels reuse_texture_ID flags -- )
c-function SOIL_load_OGL_cubemap SOIL_load_OGL_cubemap s s s s s s n u u -- u	( x_pos_file x_neg_file y_pos_file y_neg_file z_pos_file z_neg_file force_channels reuse_texture_ID flags -- )
c-function SOIL_load_OGL_single_cubemap SOIL_load_OGL_single_cubemap s s n u u -- u	( filename face_order force_channels reuse_texture_ID flags -- )
c-function SOIL_load_OGL_HDR_texture SOIL_load_OGL_HDR_texture s n n u u -- u	( filename fake_HDR_format rescale_to_max reuse_texture_ID flags -- )
c-function SOIL_load_OGL_texture_from_memory SOIL_load_OGL_texture_from_memory a n n u u -- u	( buffer buffer_length force_channels reuse_texture_ID flags -- )
c-function SOIL_load_OGL_cubemap_from_memory SOIL_load_OGL_cubemap_from_memory a n a n a n a n a n a n n u u -- u	( x_pos_buffer x_pos_buffer_length x_neg_buffer x_neg_buffer_length y_pos_buffer y_pos_buffer_length y_neg_buffer y_neg_buffer_length z_pos_buffer z_pos_buffer_length z_neg_buffer z_neg_buffer_length force_channels reuse_texture_ID flags -- )
c-function SOIL_load_OGL_single_cubemap_from_memory SOIL_load_OGL_single_cubemap_from_memory a n s n u u -- u	( buffer buffer_length face_order force_channels reuse_texture_ID flags -- )
c-function SOIL_create_OGL_texture SOIL_create_OGL_texture a a a n u u -- u	( data width height channels reuse_texture_ID flags -- )
c-function SOIL_create_OGL_single_cubemap SOIL_create_OGL_single_cubemap a n n n s u u -- u	( data width height channels face_order reuse_texture_ID flags -- )
c-function SOIL_save_screenshot SOIL_save_screenshot s n n n n n -- n	( filename image_type x y width height -- )
c-function SOIL_load_image SOIL_load_image s a a a n -- a	( filename width height channels force_channels -- )
c-function SOIL_load_image_from_memory SOIL_load_image_from_memory a n a a a n -- a	( buffer buffer_length width height channels force_channels -- )
c-function SOIL_save_image_quality SOIL_save_image_quality s n n n n a n -- n	( filename image_type width height channels data quality -- )
c-function SOIL_save_image SOIL_save_image s n n n n a -- n	( filename image_type width height channels data -- )
c-function SOIL_free_image_data SOIL_free_image_data a -- void	( img_data -- )
c-function SOIL_last_result SOIL_last_result  -- s	( -- )
c-function SOIL_GL_GetProcAddress SOIL_GL_GetProcAddress s -- a	( proc -- )
c-function SOIL_GL_ExtensionSupported SOIL_GL_ExtensionSupported s -- n	( extension -- )
c-function SOIL_direct_load_DDS SOIL_direct_load_DDS s u n n -- u	( filename reuse_texture_ID flags loading_as_cubemap -- )
c-function SOIL_direct_load_DDS_from_memory SOIL_direct_load_DDS_from_memory a n u n n -- u	( buffer buffer_length reuse_texture_ID flags loading_as_cubemap -- )
c-function SOIL_direct_load_PVR SOIL_direct_load_PVR s u n n -- u	( filename reuse_texture_ID flags loading_as_cubemap -- )
c-function SOIL_direct_load_PVR_from_memory SOIL_direct_load_PVR_from_memory a n u n n -- u	( buffer buffer_length reuse_texture_ID flags loading_as_cubemap -- )
c-function SOIL_direct_load_ETC1 SOIL_direct_load_ETC1 s u n -- u	( filename reuse_texture_ID flags -- )
c-function SOIL_direct_load_ETC1_from_memory SOIL_direct_load_ETC1_from_memory a n u n -- u	( buffer buffer_length reuse_texture_ID flags -- )

\ ----===< postfix >===-----
end-c-library
