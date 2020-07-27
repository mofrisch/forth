// this file is in the public domain
%module sdl2
%insert("include")
%{
// #define DECLSPEC
// #define SDLCALL
// #define SDL_PRINTF_FORMAT_STRING

#include <SDL2/SDL.h>
#include <SDL2/SDL_log.h>
#include <SDL2/SDL_main.h>
#include <SDL2/SDL_revision.h>
#include <SDL2/SDL_version.h>
%}

%apply int { Uint32 };

#define DECLSPEC
#define SDLCALL
#define SDL_PRINTF_FORMAT_STRING
#define SDL_PRINTF_VARARG_FUNC( fmtargnumber )

%include <SDL2/SDL.h>
%include <SDL2/SDL_log.h>
%include <SDL2/SDL_main.h>
%include <SDL2/SDL_revision.h>
%include <SDL2/SDL_version.h>
