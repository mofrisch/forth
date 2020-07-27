\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library sdl2
s" sdl2" add-lib
\c #define DECLSPEC
\c #define SDLCALL
\c #define SDL_PRINTF_FORMAT_STRING
\c #define SDL_PRINTF_VARARG_FUNC( fmtargnumber )
\c #include <SDL2/SDL.h>
\c #include <SDL2/SDL_log.h>
\c #include <SDL2/SDL_main.h>
\c #include <SDL2/SDL_revision.h>
\c #include <SDL2/SDL_version.h>

\ ----===< int constants >===-----
#1	constant SDL_INIT_TIMER
#16	constant SDL_INIT_AUDIO
#32	constant SDL_INIT_VIDEO
#512	constant SDL_INIT_JOYSTICK
#4096	constant SDL_INIT_HAPTIC
#8192	constant SDL_INIT_GAMECONTROLLER
#16384	constant SDL_INIT_EVENTS
#32768	constant SDL_INIT_SENSOR
#1048576	constant SDL_INIT_NOPARACHUTE
#62001	constant SDL_INIT_EVERYTHING
#4096	constant SDL_MAX_LOG_MESSAGE
#13609	constant SDL_REVISION_NUMBER
#2	constant SDL_MAJOR_VERSION
#0	constant SDL_MINOR_VERSION
#12	constant SDL_PATCHLEVEL
#2012	constant SDL_COMPILEDVERSION

\ --------===< enums >===---------
#0	constant SDL_LOG_CATEGORY_APPLICATION
#1	constant SDL_LOG_CATEGORY_ERROR
#2	constant SDL_LOG_CATEGORY_ASSERT
#3	constant SDL_LOG_CATEGORY_SYSTEM
#4	constant SDL_LOG_CATEGORY_AUDIO
#5	constant SDL_LOG_CATEGORY_VIDEO
#6	constant SDL_LOG_CATEGORY_RENDER
#7	constant SDL_LOG_CATEGORY_INPUT
#8	constant SDL_LOG_CATEGORY_TEST
#9	constant SDL_LOG_CATEGORY_RESERVED1
#10	constant SDL_LOG_CATEGORY_RESERVED2
#11	constant SDL_LOG_CATEGORY_RESERVED3
#12	constant SDL_LOG_CATEGORY_RESERVED4
#13	constant SDL_LOG_CATEGORY_RESERVED5
#14	constant SDL_LOG_CATEGORY_RESERVED6
#15	constant SDL_LOG_CATEGORY_RESERVED7
#16	constant SDL_LOG_CATEGORY_RESERVED8
#17	constant SDL_LOG_CATEGORY_RESERVED9
#18	constant SDL_LOG_CATEGORY_RESERVED10
#19	constant SDL_LOG_CATEGORY_CUSTOM
#1	constant SDL_LOG_PRIORITY_VERBOSE
#2	constant SDL_LOG_PRIORITY_DEBUG
#3	constant SDL_LOG_PRIORITY_INFO
#4	constant SDL_LOG_PRIORITY_WARN
#5	constant SDL_LOG_PRIORITY_ERROR
#6	constant SDL_LOG_PRIORITY_CRITICAL
#7	constant SDL_NUM_LOG_PRIORITIES

\ -------===< structs >===--------
\ SDL_version
begin-structure SDL_version
	drop 0 1 +field SDL_version-major
	drop 1 1 +field SDL_version-minor
	drop 2 1 +field SDL_version-patch
drop 3 end-structure

\ ------===< callbacks >===-------
c-callback SDL_LogOutputFunction: a n n s -- void	( userdata category priority message -- )
c-callback SDL_main_func: n a -- n	( argc argv -- )

\ ------===< functions >===-------
c-function SDL_Init SDL_Init n -- n	( flags -- )
c-function SDL_InitSubSystem SDL_InitSubSystem n -- n	( flags -- )
c-function SDL_QuitSubSystem SDL_QuitSubSystem n -- void	( flags -- )
c-function SDL_WasInit SDL_WasInit n -- n	( flags -- )
c-function SDL_Quit SDL_Quit  -- void	( -- )
c-function SDL_LogSetAllPriority SDL_LogSetAllPriority n -- void	( priority -- )
c-function SDL_LogSetPriority SDL_LogSetPriority n n -- void	( category priority -- )
c-function SDL_LogGetPriority SDL_LogGetPriority n -- n	( category -- )
c-function SDL_LogResetPriorities SDL_LogResetPriorities  -- void	( -- )
c-function SDL_Log SDL_Log s ... -- void	( fmt <noname> -- )
c-function SDL_LogVerbose SDL_LogVerbose n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogDebug SDL_LogDebug n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogInfo SDL_LogInfo n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogWarn SDL_LogWarn n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogError SDL_LogError n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogCritical SDL_LogCritical n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogMessage SDL_LogMessage n n s ... -- void	( category priority fmt <noname> -- )
c-function SDL_LogMessageV SDL_LogMessageV n n s n -- void	( category priority fmt ap -- )
c-function SDL_LogGetOutputFunction SDL_LogGetOutputFunction a a -- void	( callback userdata -- )
c-function SDL_LogSetOutputFunction SDL_LogSetOutputFunction a a -- void	( callback userdata -- )
c-function SDL_main SDL_main n a -- n	( argc argv -- )
c-function SDL_SetMainReady SDL_SetMainReady  -- void	( -- )
c-function SDL_GetVersion SDL_GetVersion a -- void	( ver -- )
c-function SDL_GetRevision SDL_GetRevision  -- s	( -- )
c-function SDL_GetRevisionNumber SDL_GetRevisionNumber  -- n	( -- )

\ ----===< postfix >===-----
end-c-library
