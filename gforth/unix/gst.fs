\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library gst
s" gstreamer-1.0" add-lib
s" gstgl-1.0" add-lib
8 to callback#
s" a 0" vararg$ $!
\c #define GST_USE_UNSTABLE_API
\c #include <gst/gst.h>
\c #include <gst/gl/gl.h>
\c #include <gst/gl/egl/gstgldisplay_egl.h>
\c #include <gst/gl/x11/gstgldisplay_x11.h>

\ ----===< int constants >===-----
#1	constant GST_VERSION_MAJOR
#16	constant GST_VERSION_MINOR
#2	constant GST_VERSION_MICRO
#0	constant GST_VERSION_NANO
#8	constant GST_EVENT_NUM_SHIFT
#8	constant GST_QUERY_NUM_SHIFT
#-1	constant GST_TOC_REPEAT_COUNT_INFINITE
#0	constant GST_URI_NO_PORT
#0	constant GST_SEQNUM_INVALID
#0	constant GST_GROUP_ID_INVALID
#-1	constant GST_VALUE_LESS_THAN
#0	constant GST_VALUE_EQUAL
#1	constant GST_VALUE_GREATER_THAN
#2	constant GST_VALUE_UNORDERED
#1	constant GST_GL_HAVE_OPENGL
#1	constant GST_GL_HAVE_GLES2
#1	constant GST_GL_HAVE_GLES3
#1	constant GST_GL_HAVE_GLES3EXT3_H
#1	constant GST_GL_HAVE_WINDOW_X11
#0	constant GST_GL_HAVE_WINDOW_COCOA
#0	constant GST_GL_HAVE_WINDOW_WIN32
#1	constant GST_GL_HAVE_WINDOW_WAYLAND
#0	constant GST_GL_HAVE_WINDOW_ANDROID
#0	constant GST_GL_HAVE_WINDOW_DISPMANX
#0	constant GST_GL_HAVE_WINDOW_EAGL
#0	constant GST_GL_HAVE_WINDOW_VIV_FB
#1	constant GST_GL_HAVE_WINDOW_GBM
#1	constant GST_GL_HAVE_PLATFORM_EGL
#1	constant GST_GL_HAVE_PLATFORM_GLX
#0	constant GST_GL_HAVE_PLATFORM_WGL
#0	constant GST_GL_HAVE_PLATFORM_CGL
#0	constant GST_GL_HAVE_PLATFORM_EAGL
#1	constant GST_GL_HAVE_DMABUF
#0	constant GST_GL_HAVE_VIV_DIRECTVIV
#1	constant GST_GL_HAVE_GLEGLIMAGEOES
#1	constant GST_GL_HAVE_GLCHAR
#1	constant GST_GL_HAVE_GLSIZEIPTR
#1	constant GST_GL_HAVE_GLINTPTR
#1	constant GST_GL_HAVE_GLSYNC
#1	constant GST_GL_HAVE_GLUINT64
#1	constant GST_GL_HAVE_GLINT64
#1	constant GST_GL_HAVE_EGLATTRIB
#1	constant GST_GL_HAVE_EGLUINT64KHR
#8	constant GST_GL_ALLOCATION_PARAMS_ALLOC_FLAG_VIDEO

\ --------===< enums >===---------
#16384	constant GST_BIN_FLAG_NO_RESYNC
#32768	constant GST_BIN_FLAG_STREAMS_AWARE
#524288	constant GST_BIN_FLAG_LAST
#16	constant GST_BUFFER_FLAG_LIVE
#32	constant GST_BUFFER_FLAG_DECODE_ONLY
#64	constant GST_BUFFER_FLAG_DISCONT
#128	constant GST_BUFFER_FLAG_RESYNC
#256	constant GST_BUFFER_FLAG_CORRUPTED
#512	constant GST_BUFFER_FLAG_MARKER
#1024	constant GST_BUFFER_FLAG_HEADER
#2048	constant GST_BUFFER_FLAG_GAP
#4096	constant GST_BUFFER_FLAG_DROPPABLE
#8192	constant GST_BUFFER_FLAG_DELTA_UNIT
#16384	constant GST_BUFFER_FLAG_TAG_MEMORY
#32768	constant GST_BUFFER_FLAG_SYNC_AFTER
#65536	constant GST_BUFFER_FLAG_NON_DROPPABLE
#1048576	constant GST_BUFFER_FLAG_LAST
#0	constant GST_BUFFER_COPY_NONE
#1	constant GST_BUFFER_COPY_FLAGS
#2	constant GST_BUFFER_COPY_TIMESTAMPS
#4	constant GST_BUFFER_COPY_META
#8	constant GST_BUFFER_COPY_MEMORY
#16	constant GST_BUFFER_COPY_MERGE
#32	constant GST_BUFFER_COPY_DEEP
#0	constant GST_BUFFER_POOL_ACQUIRE_FLAG_NONE
#1	constant GST_BUFFER_POOL_ACQUIRE_FLAG_KEY_UNIT
#2	constant GST_BUFFER_POOL_ACQUIRE_FLAG_DONTWAIT
#4	constant GST_BUFFER_POOL_ACQUIRE_FLAG_DISCONT
#65536	constant GST_BUFFER_POOL_ACQUIRE_FLAG_LAST
#16	constant GST_BUS_FLUSHING
#32	constant GST_BUS_FLAG_LAST
#0	constant GST_BUS_DROP
#1	constant GST_BUS_PASS
#2	constant GST_BUS_ASYNC
#16	constant GST_CAPS_FLAG_ANY
#0	constant GST_CAPS_INTERSECT_ZIG_ZAG
#1	constant GST_CAPS_INTERSECT_FIRST
#0	constant GST_CLOCK_OK
#1	constant GST_CLOCK_EARLY
#2	constant GST_CLOCK_UNSCHEDULED
#3	constant GST_CLOCK_BUSY
#4	constant GST_CLOCK_BADTIME
#5	constant GST_CLOCK_ERROR
#6	constant GST_CLOCK_UNSUPPORTED
#7	constant GST_CLOCK_DONE
#0	constant GST_CLOCK_ENTRY_SINGLE
#1	constant GST_CLOCK_ENTRY_PERIODIC
#16	constant GST_CLOCK_FLAG_CAN_DO_SINGLE_SYNC
#32	constant GST_CLOCK_FLAG_CAN_DO_SINGLE_ASYNC
#64	constant GST_CLOCK_FLAG_CAN_DO_PERIODIC_SYNC
#128	constant GST_CLOCK_FLAG_CAN_DO_PERIODIC_ASYNC
#256	constant GST_CLOCK_FLAG_CAN_SET_RESOLUTION
#512	constant GST_CLOCK_FLAG_CAN_SET_MASTER
#1024	constant GST_CLOCK_FLAG_NEEDS_STARTUP_SYNC
#4096	constant GST_CLOCK_FLAG_LAST
#1	constant GST_DEBUG_GRAPH_SHOW_MEDIA_TYPE
#2	constant GST_DEBUG_GRAPH_SHOW_CAPS_DETAILS
#4	constant GST_DEBUG_GRAPH_SHOW_NON_DEFAULT_PARAMS
#8	constant GST_DEBUG_GRAPH_SHOW_STATES
#16	constant GST_DEBUG_GRAPH_SHOW_FULL_PARAMS
#15	constant GST_DEBUG_GRAPH_SHOW_ALL
#-1	constant GST_DEBUG_GRAPH_SHOW_VERBOSE
#0	constant GST_STATE_VOID_PENDING
#1	constant GST_STATE_NULL
#2	constant GST_STATE_READY
#3	constant GST_STATE_PAUSED
#4	constant GST_STATE_PLAYING
#0	constant GST_STATE_CHANGE_FAILURE
#1	constant GST_STATE_CHANGE_SUCCESS
#2	constant GST_STATE_CHANGE_ASYNC
#3	constant GST_STATE_CHANGE_NO_PREROLL
#10	constant GST_STATE_CHANGE_NULL_TO_READY
#19	constant GST_STATE_CHANGE_READY_TO_PAUSED
#28	constant GST_STATE_CHANGE_PAUSED_TO_PLAYING
#35	constant GST_STATE_CHANGE_PLAYING_TO_PAUSED
#26	constant GST_STATE_CHANGE_PAUSED_TO_READY
#17	constant GST_STATE_CHANGE_READY_TO_NULL
#9	constant GST_STATE_CHANGE_NULL_TO_NULL
#18	constant GST_STATE_CHANGE_READY_TO_READY
#27	constant GST_STATE_CHANGE_PAUSED_TO_PAUSED
#36	constant GST_STATE_CHANGE_PLAYING_TO_PLAYING
#16	constant GST_ELEMENT_FLAG_LOCKED_STATE
#32	constant GST_ELEMENT_FLAG_SINK
#64	constant GST_ELEMENT_FLAG_SOURCE
#128	constant GST_ELEMENT_FLAG_PROVIDE_CLOCK
#256	constant GST_ELEMENT_FLAG_REQUIRE_CLOCK
#512	constant GST_ELEMENT_FLAG_INDEXABLE
#16384	constant GST_ELEMENT_FLAG_LAST
#1	constant GST_CORE_ERROR_FAILED
#2	constant GST_CORE_ERROR_TOO_LAZY
#3	constant GST_CORE_ERROR_NOT_IMPLEMENTED
#4	constant GST_CORE_ERROR_STATE_CHANGE
#5	constant GST_CORE_ERROR_PAD
#6	constant GST_CORE_ERROR_THREAD
#7	constant GST_CORE_ERROR_NEGOTIATION
#8	constant GST_CORE_ERROR_EVENT
#9	constant GST_CORE_ERROR_SEEK
#10	constant GST_CORE_ERROR_CAPS
#11	constant GST_CORE_ERROR_TAG
#12	constant GST_CORE_ERROR_MISSING_PLUGIN
#13	constant GST_CORE_ERROR_CLOCK
#14	constant GST_CORE_ERROR_DISABLED
#15	constant GST_CORE_ERROR_NUM_ERRORS
#1	constant GST_LIBRARY_ERROR_FAILED
#2	constant GST_LIBRARY_ERROR_TOO_LAZY
#3	constant GST_LIBRARY_ERROR_INIT
#4	constant GST_LIBRARY_ERROR_SHUTDOWN
#5	constant GST_LIBRARY_ERROR_SETTINGS
#6	constant GST_LIBRARY_ERROR_ENCODE
#7	constant GST_LIBRARY_ERROR_NUM_ERRORS
#1	constant GST_RESOURCE_ERROR_FAILED
#2	constant GST_RESOURCE_ERROR_TOO_LAZY
#3	constant GST_RESOURCE_ERROR_NOT_FOUND
#4	constant GST_RESOURCE_ERROR_BUSY
#5	constant GST_RESOURCE_ERROR_OPEN_READ
#6	constant GST_RESOURCE_ERROR_OPEN_WRITE
#7	constant GST_RESOURCE_ERROR_OPEN_READ_WRITE
#8	constant GST_RESOURCE_ERROR_CLOSE
#9	constant GST_RESOURCE_ERROR_READ
#10	constant GST_RESOURCE_ERROR_WRITE
#11	constant GST_RESOURCE_ERROR_SEEK
#12	constant GST_RESOURCE_ERROR_SYNC
#13	constant GST_RESOURCE_ERROR_SETTINGS
#14	constant GST_RESOURCE_ERROR_NO_SPACE_LEFT
#15	constant GST_RESOURCE_ERROR_NOT_AUTHORIZED
#16	constant GST_RESOURCE_ERROR_NUM_ERRORS
#1	constant GST_STREAM_ERROR_FAILED
#2	constant GST_STREAM_ERROR_TOO_LAZY
#3	constant GST_STREAM_ERROR_NOT_IMPLEMENTED
#4	constant GST_STREAM_ERROR_TYPE_NOT_FOUND
#5	constant GST_STREAM_ERROR_WRONG_TYPE
#6	constant GST_STREAM_ERROR_CODEC_NOT_FOUND
#7	constant GST_STREAM_ERROR_DECODE
#8	constant GST_STREAM_ERROR_ENCODE
#9	constant GST_STREAM_ERROR_DEMUX
#10	constant GST_STREAM_ERROR_MUX
#11	constant GST_STREAM_ERROR_FORMAT
#12	constant GST_STREAM_ERROR_DECRYPT
#13	constant GST_STREAM_ERROR_DECRYPT_NOKEY
#14	constant GST_STREAM_ERROR_NUM_ERRORS
#1	constant GST_EVENT_TYPE_UPSTREAM
#2	constant GST_EVENT_TYPE_DOWNSTREAM
#4	constant GST_EVENT_TYPE_SERIALIZED
#8	constant GST_EVENT_TYPE_STICKY
#16	constant GST_EVENT_TYPE_STICKY_MULTI
#0	constant GST_EVENT_UNKNOWN
#2563	constant GST_EVENT_FLUSH_START
#5127	constant GST_EVENT_FLUSH_STOP
#10254	constant GST_EVENT_STREAM_START
#12814	constant GST_EVENT_CAPS
#17934	constant GST_EVENT_SEGMENT
#19230	constant GST_EVENT_STREAM_COLLECTION
#20510	constant GST_EVENT_TAG
#23054	constant GST_EVENT_BUFFERSIZE
#25630	constant GST_EVENT_SINK_MESSAGE
#26894	constant GST_EVENT_STREAM_GROUP_DONE
#28174	constant GST_EVENT_EOS
#30750	constant GST_EVENT_TOC
#33310	constant GST_EVENT_PROTECTION
#38406	constant GST_EVENT_SEGMENT_DONE
#40966	constant GST_EVENT_GAP
#48641	constant GST_EVENT_QOS
#51201	constant GST_EVENT_SEEK
#53761	constant GST_EVENT_NAVIGATION
#56321	constant GST_EVENT_LATENCY
#58881	constant GST_EVENT_STEP
#61441	constant GST_EVENT_RECONFIGURE
#64001	constant GST_EVENT_TOC_SELECT
#66561	constant GST_EVENT_SELECT_STREAMS
#69121	constant GST_EVENT_CUSTOM_UPSTREAM
#71686	constant GST_EVENT_CUSTOM_DOWNSTREAM
#74242	constant GST_EVENT_CUSTOM_DOWNSTREAM_OOB
#76830	constant GST_EVENT_CUSTOM_DOWNSTREAM_STICKY
#79367	constant GST_EVENT_CUSTOM_BOTH
#81923	constant GST_EVENT_CUSTOM_BOTH_OOB
#0	constant GST_STREAM_FLAG_NONE
#1	constant GST_STREAM_FLAG_SPARSE
#2	constant GST_STREAM_FLAG_SELECT
#4	constant GST_STREAM_FLAG_UNSELECT
#0	constant GST_QOS_TYPE_OVERFLOW
#1	constant GST_QOS_TYPE_UNDERFLOW
#2	constant GST_QOS_TYPE_THROTTLE
#0	constant GST_ITERATOR_DONE
#1	constant GST_ITERATOR_OK
#2	constant GST_ITERATOR_RESYNC
#3	constant GST_ITERATOR_ERROR
#0	constant GST_ITERATOR_ITEM_SKIP
#1	constant GST_ITERATOR_ITEM_PASS
#2	constant GST_ITERATOR_ITEM_END
#0	constant GST_MESSAGE_UNKNOWN
#1	constant GST_MESSAGE_EOS
#2	constant GST_MESSAGE_ERROR
#4	constant GST_MESSAGE_WARNING
#8	constant GST_MESSAGE_INFO
#16	constant GST_MESSAGE_TAG
#32	constant GST_MESSAGE_BUFFERING
#64	constant GST_MESSAGE_STATE_CHANGED
#128	constant GST_MESSAGE_STATE_DIRTY
#256	constant GST_MESSAGE_STEP_DONE
#512	constant GST_MESSAGE_CLOCK_PROVIDE
#1024	constant GST_MESSAGE_CLOCK_LOST
#2048	constant GST_MESSAGE_NEW_CLOCK
#4096	constant GST_MESSAGE_STRUCTURE_CHANGE
#8192	constant GST_MESSAGE_STREAM_STATUS
#16384	constant GST_MESSAGE_APPLICATION
#32768	constant GST_MESSAGE_ELEMENT
#65536	constant GST_MESSAGE_SEGMENT_START
#131072	constant GST_MESSAGE_SEGMENT_DONE
#262144	constant GST_MESSAGE_DURATION_CHANGED
#524288	constant GST_MESSAGE_LATENCY
#1048576	constant GST_MESSAGE_ASYNC_START
#2097152	constant GST_MESSAGE_ASYNC_DONE
#4194304	constant GST_MESSAGE_REQUEST_STATE
#8388608	constant GST_MESSAGE_STEP_START
#16777216	constant GST_MESSAGE_QOS
#33554432	constant GST_MESSAGE_PROGRESS
#67108864	constant GST_MESSAGE_TOC
#134217728	constant GST_MESSAGE_RESET_TIME
#268435456	constant GST_MESSAGE_STREAM_START
#536870912	constant GST_MESSAGE_NEED_CONTEXT
#1073741824	constant GST_MESSAGE_HAVE_CONTEXT
#-2147483648	constant GST_MESSAGE_EXTENDED
#-2147483647	constant GST_MESSAGE_DEVICE_ADDED
#-2147483646	constant GST_MESSAGE_DEVICE_REMOVED
#-2147483645	constant GST_MESSAGE_PROPERTY_NOTIFY
#-2147483644	constant GST_MESSAGE_STREAM_COLLECTION
#-2147483643	constant GST_MESSAGE_STREAMS_SELECTED
#-2147483642	constant GST_MESSAGE_REDIRECT
#-2147483641	constant GST_MESSAGE_DEVICE_CHANGED
#-1	constant GST_MESSAGE_ANY
#0	constant GST_STRUCTURE_CHANGE_TYPE_PAD_LINK
#1	constant GST_STRUCTURE_CHANGE_TYPE_PAD_UNLINK
#0	constant GST_STREAM_STATUS_TYPE_CREATE
#1	constant GST_STREAM_STATUS_TYPE_ENTER
#2	constant GST_STREAM_STATUS_TYPE_LEAVE
#3	constant GST_STREAM_STATUS_TYPE_DESTROY
#8	constant GST_STREAM_STATUS_TYPE_START
#9	constant GST_STREAM_STATUS_TYPE_PAUSE
#10	constant GST_STREAM_STATUS_TYPE_STOP
#0	constant GST_PROGRESS_TYPE_START
#1	constant GST_PROGRESS_TYPE_CONTINUE
#2	constant GST_PROGRESS_TYPE_COMPLETE
#3	constant GST_PROGRESS_TYPE_CANCELED
#4	constant GST_PROGRESS_TYPE_ERROR
#2	constant GST_MEMORY_FLAG_READONLY
#16	constant GST_MEMORY_FLAG_NO_SHARE
#32	constant GST_MEMORY_FLAG_ZERO_PREFIXED
#64	constant GST_MEMORY_FLAG_ZERO_PADDED
#128	constant GST_MEMORY_FLAG_PHYSICALLY_CONTIGUOUS
#256	constant GST_MEMORY_FLAG_NOT_MAPPABLE
#1048576	constant GST_MEMORY_FLAG_LAST
#1	constant GST_MAP_READ
#2	constant GST_MAP_WRITE
#65536	constant GST_MAP_FLAG_LAST
#0	constant GST_META_FLAG_NONE
#1	constant GST_META_FLAG_READONLY
#2	constant GST_META_FLAG_POOLED
#4	constant GST_META_FLAG_LOCKED
#65536	constant GST_META_FLAG_LAST
#1	constant GST_MINI_OBJECT_FLAG_LOCKABLE
#2	constant GST_MINI_OBJECT_FLAG_LOCK_READONLY
#4	constant GST_MINI_OBJECT_FLAG_MAY_BE_LEAKED
#16	constant GST_MINI_OBJECT_FLAG_LAST
#1	constant GST_LOCK_FLAG_READ
#2	constant GST_LOCK_FLAG_WRITE
#4	constant GST_LOCK_FLAG_EXCLUSIVE
#256	constant GST_LOCK_FLAG_LAST
#1	constant GST_OBJECT_FLAG_MAY_BE_LEAKED
#16	constant GST_OBJECT_FLAG_LAST
#0	constant GST_PAD_UNKNOWN
#1	constant GST_PAD_SRC
#2	constant GST_PAD_SINK
#0	constant GST_PAD_MODE_NONE
#1	constant GST_PAD_MODE_PUSH
#2	constant GST_PAD_MODE_PULL
#0	constant GST_PAD_LINK_OK
#-1	constant GST_PAD_LINK_WRONG_HIERARCHY
#-2	constant GST_PAD_LINK_WAS_LINKED
#-3	constant GST_PAD_LINK_WRONG_DIRECTION
#-4	constant GST_PAD_LINK_NOFORMAT
#-5	constant GST_PAD_LINK_NOSCHED
#-6	constant GST_PAD_LINK_REFUSED
#102	constant GST_FLOW_CUSTOM_SUCCESS_2
#101	constant GST_FLOW_CUSTOM_SUCCESS_1
#100	constant GST_FLOW_CUSTOM_SUCCESS
#0	constant GST_FLOW_OK
#-1	constant GST_FLOW_NOT_LINKED
#-2	constant GST_FLOW_FLUSHING
#-3	constant GST_FLOW_EOS
#-4	constant GST_FLOW_NOT_NEGOTIATED
#-5	constant GST_FLOW_ERROR
#-6	constant GST_FLOW_NOT_SUPPORTED
#-100	constant GST_FLOW_CUSTOM_ERROR
#-101	constant GST_FLOW_CUSTOM_ERROR_1
#-102	constant GST_FLOW_CUSTOM_ERROR_2
#0	constant GST_PAD_LINK_CHECK_NOTHING
#1	constant GST_PAD_LINK_CHECK_HIERARCHY
#2	constant GST_PAD_LINK_CHECK_TEMPLATE_CAPS
#4	constant GST_PAD_LINK_CHECK_CAPS
#8	constant GST_PAD_LINK_CHECK_NO_RECONFIGURE
#5	constant GST_PAD_LINK_CHECK_DEFAULT
#0	constant GST_PAD_PROBE_TYPE_INVALID
#1	constant GST_PAD_PROBE_TYPE_IDLE
#2	constant GST_PAD_PROBE_TYPE_BLOCK
#16	constant GST_PAD_PROBE_TYPE_BUFFER
#32	constant GST_PAD_PROBE_TYPE_BUFFER_LIST
#64	constant GST_PAD_PROBE_TYPE_EVENT_DOWNSTREAM
#128	constant GST_PAD_PROBE_TYPE_EVENT_UPSTREAM
#256	constant GST_PAD_PROBE_TYPE_EVENT_FLUSH
#512	constant GST_PAD_PROBE_TYPE_QUERY_DOWNSTREAM
#1024	constant GST_PAD_PROBE_TYPE_QUERY_UPSTREAM
#4096	constant GST_PAD_PROBE_TYPE_PUSH
#8192	constant GST_PAD_PROBE_TYPE_PULL
#3	constant GST_PAD_PROBE_TYPE_BLOCKING
#112	constant GST_PAD_PROBE_TYPE_DATA_DOWNSTREAM
#128	constant GST_PAD_PROBE_TYPE_DATA_UPSTREAM
#240	constant GST_PAD_PROBE_TYPE_DATA_BOTH
#114	constant GST_PAD_PROBE_TYPE_BLOCK_DOWNSTREAM
#130	constant GST_PAD_PROBE_TYPE_BLOCK_UPSTREAM
#192	constant GST_PAD_PROBE_TYPE_EVENT_BOTH
#1536	constant GST_PAD_PROBE_TYPE_QUERY_BOTH
#1776	constant GST_PAD_PROBE_TYPE_ALL_BOTH
#12288	constant GST_PAD_PROBE_TYPE_SCHEDULING
#0	constant GST_PAD_PROBE_DROP
#1	constant GST_PAD_PROBE_OK
#2	constant GST_PAD_PROBE_REMOVE
#3	constant GST_PAD_PROBE_PASS
#4	constant GST_PAD_PROBE_HANDLED
#16	constant GST_PAD_FLAG_BLOCKED
#32	constant GST_PAD_FLAG_FLUSHING
#64	constant GST_PAD_FLAG_EOS
#128	constant GST_PAD_FLAG_BLOCKING
#256	constant GST_PAD_FLAG_NEED_PARENT
#512	constant GST_PAD_FLAG_NEED_RECONFIGURE
#1024	constant GST_PAD_FLAG_PENDING_EVENTS
#2048	constant GST_PAD_FLAG_FIXED_CAPS
#4096	constant GST_PAD_FLAG_PROXY_CAPS
#8192	constant GST_PAD_FLAG_PROXY_ALLOCATION
#16384	constant GST_PAD_FLAG_PROXY_SCHEDULING
#32768	constant GST_PAD_FLAG_ACCEPT_INTERSECT
#65536	constant GST_PAD_FLAG_ACCEPT_TEMPLATE
#1048576	constant GST_PAD_FLAG_LAST
#524288	constant GST_PIPELINE_FLAG_FIXED_CLOCK
#8388608	constant GST_PIPELINE_FLAG_LAST
#0	constant GST_PLUGIN_ERROR_MODULE
#1	constant GST_PLUGIN_ERROR_DEPENDENCIES
#2	constant GST_PLUGIN_ERROR_NAME_MISMATCH
#16	constant GST_PLUGIN_FLAG_CACHED
#32	constant GST_PLUGIN_FLAG_BLACKLISTED
#0	constant GST_PLUGIN_DEPENDENCY_FLAG_NONE
#1	constant GST_PLUGIN_DEPENDENCY_FLAG_RECURSE
#2	constant GST_PLUGIN_DEPENDENCY_FLAG_PATHS_ARE_DEFAULT_ONLY
#4	constant GST_PLUGIN_DEPENDENCY_FLAG_FILE_NAME_IS_SUFFIX
#8	constant GST_PLUGIN_DEPENDENCY_FLAG_FILE_NAME_IS_PREFIX
#16	constant GST_PLUGIN_DEPENDENCY_FLAG_PATHS_ARE_RELATIVE_TO_EXE
#1	constant GST_QUERY_TYPE_UPSTREAM
#2	constant GST_QUERY_TYPE_DOWNSTREAM
#4	constant GST_QUERY_TYPE_SERIALIZED
#0	constant GST_QUERY_UNKNOWN
#2563	constant GST_QUERY_POSITION
#5123	constant GST_QUERY_DURATION
#7683	constant GST_QUERY_LATENCY
#10243	constant GST_QUERY_JITTER
#12803	constant GST_QUERY_RATE
#15363	constant GST_QUERY_SEEKING
#17923	constant GST_QUERY_SEGMENT
#20483	constant GST_QUERY_CONVERT
#23043	constant GST_QUERY_FORMATS
#28163	constant GST_QUERY_BUFFERING
#30723	constant GST_QUERY_CUSTOM
#33283	constant GST_QUERY_URI
#35846	constant GST_QUERY_ALLOCATION
#38401	constant GST_QUERY_SCHEDULING
#40963	constant GST_QUERY_ACCEPT_CAPS
#43523	constant GST_QUERY_CAPS
#46086	constant GST_QUERY_DRAIN
#48643	constant GST_QUERY_CONTEXT
#51202	constant GST_QUERY_BITRATE
#0	constant GST_BUFFERING_STREAM
#1	constant GST_BUFFERING_DOWNLOAD
#2	constant GST_BUFFERING_TIMESHIFT
#3	constant GST_BUFFERING_LIVE
#1	constant GST_SCHEDULING_FLAG_SEEKABLE
#2	constant GST_SCHEDULING_FLAG_SEQUENTIAL
#4	constant GST_SCHEDULING_FLAG_BANDWIDTH_LIMITED
#0	constant GST_SEEK_TYPE_NONE
#1	constant GST_SEEK_TYPE_SET
#2	constant GST_SEEK_TYPE_END
#0	constant GST_SEEK_FLAG_NONE
#1	constant GST_SEEK_FLAG_FLUSH
#2	constant GST_SEEK_FLAG_ACCURATE
#4	constant GST_SEEK_FLAG_KEY_UNIT
#8	constant GST_SEEK_FLAG_SEGMENT
#16	constant GST_SEEK_FLAG_TRICKMODE
#16	constant GST_SEEK_FLAG_SKIP
#32	constant GST_SEEK_FLAG_SNAP_BEFORE
#64	constant GST_SEEK_FLAG_SNAP_AFTER
#96	constant GST_SEEK_FLAG_SNAP_NEAREST
#128	constant GST_SEEK_FLAG_TRICKMODE_KEY_UNITS
#256	constant GST_SEEK_FLAG_TRICKMODE_NO_AUDIO
#0	constant GST_SEGMENT_FLAG_NONE
#1	constant GST_SEGMENT_FLAG_RESET
#16	constant GST_SEGMENT_FLAG_TRICKMODE
#16	constant GST_SEGMENT_FLAG_SKIP
#8	constant GST_SEGMENT_FLAG_SEGMENT
#128	constant GST_SEGMENT_FLAG_TRICKMODE_KEY_UNITS
#256	constant GST_SEGMENT_FLAG_TRICKMODE_NO_AUDIO
#0	constant GST_CLOCK_TYPE_REALTIME
#1	constant GST_CLOCK_TYPE_MONOTONIC
#2	constant GST_CLOCK_TYPE_OTHER
#0	constant GST_TAG_MERGE_UNDEFINED
#1	constant GST_TAG_MERGE_REPLACE_ALL
#2	constant GST_TAG_MERGE_REPLACE
#3	constant GST_TAG_MERGE_APPEND
#4	constant GST_TAG_MERGE_PREPEND
#5	constant GST_TAG_MERGE_KEEP
#6	constant GST_TAG_MERGE_KEEP_ALL
#7	constant GST_TAG_MERGE_COUNT
#0	constant GST_TAG_FLAG_UNDEFINED
#1	constant GST_TAG_FLAG_META
#2	constant GST_TAG_FLAG_ENCODED
#3	constant GST_TAG_FLAG_DECODED
#4	constant GST_TAG_FLAG_COUNT
#0	constant GST_TAG_SCOPE_STREAM
#1	constant GST_TAG_SCOPE_GLOBAL
#0	constant GST_TASK_STARTED
#1	constant GST_TASK_STOPPED
#2	constant GST_TASK_PAUSED
#1	constant GST_TOC_SCOPE_GLOBAL
#2	constant GST_TOC_SCOPE_CURRENT
#-3	constant GST_TOC_ENTRY_TYPE_ANGLE
#-2	constant GST_TOC_ENTRY_TYPE_VERSION
#-1	constant GST_TOC_ENTRY_TYPE_EDITION
#0	constant GST_TOC_ENTRY_TYPE_INVALID
#1	constant GST_TOC_ENTRY_TYPE_TITLE
#2	constant GST_TOC_ENTRY_TYPE_TRACK
#3	constant GST_TOC_ENTRY_TYPE_CHAPTER
#0	constant GST_TOC_LOOP_NONE
#1	constant GST_TOC_LOOP_FORWARD
#2	constant GST_TOC_LOOP_REVERSE
#3	constant GST_TOC_LOOP_PING_PONG
#0	constant GST_TYPE_FIND_NONE
#1	constant GST_TYPE_FIND_MINIMUM
#50	constant GST_TYPE_FIND_POSSIBLE
#80	constant GST_TYPE_FIND_LIKELY
#99	constant GST_TYPE_FIND_NEARLY_CERTAIN
#100	constant GST_TYPE_FIND_MAXIMUM
#0	constant GST_URI_ERROR_UNSUPPORTED_PROTOCOL
#1	constant GST_URI_ERROR_BAD_URI
#2	constant GST_URI_ERROR_BAD_STATE
#3	constant GST_URI_ERROR_BAD_REFERENCE
#0	constant GST_URI_UNKNOWN
#1	constant GST_URI_SINK
#2	constant GST_URI_SRC
#0	constant GST_SEARCH_MODE_EXACT
#1	constant GST_SEARCH_MODE_BEFORE
#2	constant GST_SEARCH_MODE_AFTER
#0	constant GST_PARSE_ERROR_SYNTAX
#1	constant GST_PARSE_ERROR_NO_SUCH_ELEMENT
#2	constant GST_PARSE_ERROR_NO_SUCH_PROPERTY
#3	constant GST_PARSE_ERROR_LINK
#4	constant GST_PARSE_ERROR_COULD_NOT_SET_PROPERTY
#5	constant GST_PARSE_ERROR_EMPTY_BIN
#6	constant GST_PARSE_ERROR_EMPTY
#7	constant GST_PARSE_ERROR_DELAYED_LINK
#0	constant GST_PARSE_FLAG_NONE
#1	constant GST_PARSE_FLAG_FATAL_ERRORS
#2	constant GST_PARSE_FLAG_NO_SINGLE_ELEMENT_BINS
#4	constant GST_PARSE_FLAG_PLACE_IN_BIN
#0	constant GST_GL_API_NONE
#1	constant GST_GL_API_OPENGL
#2	constant GST_GL_API_OPENGL3
#32768	constant GST_GL_API_GLES1
#65536	constant GST_GL_API_GLES2
#4294967295	constant GST_GL_API_ANY
#0	constant GST_GL_PLATFORM_NONE
#1	constant GST_GL_PLATFORM_EGL
#2	constant GST_GL_PLATFORM_GLX
#4	constant GST_GL_PLATFORM_WGL
#8	constant GST_GL_PLATFORM_CGL
#16	constant GST_GL_PLATFORM_EAGL
#4294967295	constant GST_GL_PLATFORM_ANY
#0	constant GST_GL_DISPLAY_TYPE_NONE
#1	constant GST_GL_DISPLAY_TYPE_X11
#2	constant GST_GL_DISPLAY_TYPE_WAYLAND
#4	constant GST_GL_DISPLAY_TYPE_COCOA
#8	constant GST_GL_DISPLAY_TYPE_WIN32
#16	constant GST_GL_DISPLAY_TYPE_DISPMANX
#32	constant GST_GL_DISPLAY_TYPE_EGL
#64	constant GST_GL_DISPLAY_TYPE_VIV_FB
#128	constant GST_GL_DISPLAY_TYPE_GBM
#4294967295	constant GST_GL_DISPLAY_TYPE_ANY
#0	constant GST_GL_CONTEXT_ERROR_FAILED
#1	constant GST_GL_CONTEXT_ERROR_WRONG_CONFIG
#2	constant GST_GL_CONTEXT_ERROR_WRONG_API
#3	constant GST_GL_CONTEXT_ERROR_OLD_LIBS
#4	constant GST_GL_CONTEXT_ERROR_CREATE_CONTEXT
#5	constant GST_GL_CONTEXT_ERROR_RESOURCE_UNAVAILABLE
#0	constant GST_GL_WINDOW_ERROR_FAILED
#1	constant GST_GL_WINDOW_ERROR_OLD_LIBS
#2	constant GST_GL_WINDOW_ERROR_RESOURCE_UNAVAILABLE
#1	constant GST_GL_UPLOAD_DONE
#-1	constant GST_GL_UPLOAD_ERROR
#-2	constant GST_GL_UPLOAD_UNSUPPORTED
#-3	constant GST_GL_UPLOAD_RECONFIGURE
#-100	constant GST_GL_UPLOAD_UNSHARED_GL_CONTEXT

\ -------===< structs >===--------
\ _GstBin
begin-structure _GstBin
	drop 0 264 +field _GstBin-element
	drop 308 4 +field _GstBin-state_dirty
	drop 312 4 +field _GstBin-clock_dirty
	drop 280 4 +field _GstBin-children_cookie
	drop 304 4 +field _GstBin-polling
	drop 344 32 +field _GstBin-_gst_reserved
	drop 288 8 +field _GstBin-child_bus
	drop 320 8 +field _GstBin-provided_clock
	drop 328 8 +field _GstBin-clock_provider
	drop 336 8 +field _GstBin-priv
	drop 296 8 +field _GstBin-messages
	drop 264 4 +field _GstBin-numchildren
	drop 272 8 +field _GstBin-children
drop 376 end-structure
\ _GstBinClass
begin-structure _GstBinClass
	drop 512 8 +field _GstBinClass-add_element
	drop 520 8 +field _GstBinClass-remove_element
	drop 496 8 +field _GstBinClass-element_added
	drop 544 8 +field _GstBinClass-deep_element_added
	drop 560 16 +field _GstBinClass-_gst_reserved
	drop 504 8 +field _GstBinClass-element_removed
	drop 536 8 +field _GstBinClass-do_latency
	drop 552 8 +field _GstBinClass-deep_element_removed
	drop 488 8 +field _GstBinClass-pool
	drop 528 8 +field _GstBinClass-handle_message
	drop 0 488 +field _GstBinClass-parent_class
drop 576 end-structure
\ _GstBuffer
begin-structure _GstBuffer
	drop 80 8 +field _GstBuffer-dts
	drop 88 8 +field _GstBuffer-duration
	drop 104 8 +field _GstBuffer-offset_end
	drop 0 64 +field _GstBuffer-mini_object
	drop 96 8 +field _GstBuffer-offset
	drop 64 8 +field _GstBuffer-pool
	drop 72 8 +field _GstBuffer-pts
drop 112 end-structure
\ _GstParentBufferMeta
begin-structure _GstParentBufferMeta
	drop 16 8 +field _GstParentBufferMeta-buffer
	drop 0 16 +field _GstParentBufferMeta-parent
drop 24 end-structure
\ _GstReferenceTimestampMeta
begin-structure _GstReferenceTimestampMeta
	drop 32 8 +field _GstReferenceTimestampMeta-duration
	drop 16 8 +field _GstReferenceTimestampMeta-reference
	drop 0 16 +field _GstReferenceTimestampMeta-parent
	drop 24 8 +field _GstReferenceTimestampMeta-timestamp
drop 40 end-structure
\ _GstBufferPoolAcquireParams
begin-structure _GstBufferPoolAcquireParams
	drop 16 8 +field _GstBufferPoolAcquireParams-stop
	drop 32 32 +field _GstBufferPoolAcquireParams-_gst_reserved
	drop 0 4 +field _GstBufferPoolAcquireParams-format
	drop 8 8 +field _GstBufferPoolAcquireParams-start
	drop 24 4 +field _GstBufferPoolAcquireParams-flags
drop 64 end-structure
\ _GstBufferPool
begin-structure _GstBufferPool
	drop 104 32 +field _GstBufferPool-_gst_reserved
	drop 88 4 +field _GstBufferPool-flushing
	drop 96 8 +field _GstBufferPool-priv
	drop 0 88 +field _GstBufferPool-object
drop 136 end-structure
\ _GstBufferPoolClass
begin-structure _GstBufferPoolClass
	drop 208 8 +field _GstBufferPoolClass-stop
	drop 216 8 +field _GstBufferPoolClass-acquire_buffer
	drop 224 8 +field _GstBufferPoolClass-alloc_buffer
	drop 232 8 +field _GstBufferPoolClass-reset_buffer
	drop 240 8 +field _GstBufferPoolClass-release_buffer
	drop 248 8 +field _GstBufferPoolClass-free_buffer
	drop 272 16 +field _GstBufferPoolClass-_gst_reserved
	drop 256 8 +field _GstBufferPoolClass-flush_start
	drop 264 8 +field _GstBufferPoolClass-flush_stop
	drop 0 184 +field _GstBufferPoolClass-object_class
	drop 200 8 +field _GstBufferPoolClass-start
	drop 184 8 +field _GstBufferPoolClass-get_options
	drop 192 8 +field _GstBufferPoolClass-set_config
drop 288 end-structure
\ _GstBus
begin-structure _GstBus
	drop 96 32 +field _GstBus-_gst_reserved
	drop 88 8 +field _GstBus-priv
	drop 0 88 +field _GstBus-object
drop 128 end-structure
\ _GstBusClass
begin-structure _GstBusClass
	drop 200 32 +field _GstBusClass-_gst_reserved
	drop 184 8 +field _GstBusClass-message
	drop 192 8 +field _GstBusClass-sync_message
	drop 0 184 +field _GstBusClass-parent_class
drop 232 end-structure
\ _GstCaps
begin-structure _GstCaps
	drop 0 64 +field _GstCaps-mini_object
drop 64 end-structure
\ _GstStaticCaps
begin-structure _GstStaticCaps
	drop 16 32 +field _GstStaticCaps-_gst_reserved
	drop 0 8 +field _GstStaticCaps-caps
	drop 8 8 +field _GstStaticCaps-string
drop 48 end-structure
\ _GstChildProxyInterface
begin-structure _GstChildProxyInterface
	drop 32 8 +field _GstChildProxyInterface-get_children_count
	drop 40 8 +field _GstChildProxyInterface-child_added
	drop 56 32 +field _GstChildProxyInterface-_gst_reserved
	drop 48 8 +field _GstChildProxyInterface-child_removed
	drop 0 16 +field _GstChildProxyInterface-parent
	drop 16 8 +field _GstChildProxyInterface-get_child_by_name
	drop 24 8 +field _GstChildProxyInterface-get_child_by_index
drop 88 end-structure
\ _GstClockEntry
begin-structure _GstClockEntry
	drop 0 4 +field _GstClockEntry-refcount
	drop 48 8 +field _GstClockEntry-func
	drop 40 4 +field _GstClockEntry-status
	drop 80 32 +field _GstClockEntry-_gst_reserved
	drop 24 8 +field _GstClockEntry-time
	drop 72 4 +field _GstClockEntry-unscheduled
	drop 32 8 +field _GstClockEntry-interval
	drop 8 8 +field _GstClockEntry-clock
	drop 16 4 +field _GstClockEntry-type
	drop 56 8 +field _GstClockEntry-user_data
	drop 64 8 +field _GstClockEntry-destroy_data
	drop 76 4 +field _GstClockEntry-woken_up
drop 112 end-structure
\ _GstClock
begin-structure _GstClock
	drop 96 32 +field _GstClock-_gst_reserved
	drop 88 8 +field _GstClock-priv
	drop 0 88 +field _GstClock-object
drop 128 end-structure
\ _GstClockClass
begin-structure _GstClockClass
	drop 184 8 +field _GstClockClass-change_resolution
	drop 192 8 +field _GstClockClass-get_resolution
	drop 200 8 +field _GstClockClass-get_internal_time
	drop 232 32 +field _GstClockClass-_gst_reserved
	drop 208 8 +field _GstClockClass-wait
	drop 216 8 +field _GstClockClass-wait_async
	drop 0 184 +field _GstClockClass-parent_class
	drop 224 8 +field _GstClockClass-unschedule
drop 264 end-structure
\ _GstTimedValue
begin-structure _GstTimedValue
	drop 8 8 +field _GstTimedValue-value
	drop 0 8 +field _GstTimedValue-timestamp
drop 16 end-structure
\ _GstControlSource
begin-structure _GstControlSource
	drop 104 32 +field _GstControlSource-_gst_reserved
	drop 88 8 +field _GstControlSource-get_value
	drop 0 88 +field _GstControlSource-parent
	drop 96 8 +field _GstControlSource-get_value_array
drop 136 end-structure
\ _GstControlSourceClass
begin-structure _GstControlSourceClass
	drop 184 32 +field _GstControlSourceClass-_gst_reserved
	drop 0 184 +field _GstControlSourceClass-parent_class
drop 216 end-structure
\ _GstDevice
begin-structure _GstDevice
	drop 96 32 +field _GstDevice-_gst_reserved
	drop 88 8 +field _GstDevice-priv
	drop 0 88 +field _GstDevice-parent
drop 128 end-structure
\ _GstDeviceClass
begin-structure _GstDeviceClass
	drop 184 8 +field _GstDeviceClass-create_element
	drop 192 8 +field _GstDeviceClass-reconfigure_element
	drop 200 32 +field _GstDeviceClass-_gst_reserved
	drop 0 184 +field _GstDeviceClass-parent_class
drop 232 end-structure
\ _GstDeviceMonitor
begin-structure _GstDeviceMonitor
	drop 96 32 +field _GstDeviceMonitor-_gst_reserved
	drop 88 8 +field _GstDeviceMonitor-priv
	drop 0 88 +field _GstDeviceMonitor-parent
drop 128 end-structure
\ _GstDeviceMonitorClass
begin-structure _GstDeviceMonitorClass
	drop 184 32 +field _GstDeviceMonitorClass-_gst_reserved
	drop 0 184 +field _GstDeviceMonitorClass-parent_class
drop 216 end-structure
\ _GstDeviceProvider
begin-structure _GstDeviceProvider
	drop 104 32 +field _GstDeviceProvider-_gst_reserved
	drop 88 8 +field _GstDeviceProvider-devices
	drop 96 8 +field _GstDeviceProvider-priv
	drop 0 88 +field _GstDeviceProvider-parent
drop 136 end-structure
\ _GstDeviceProviderClass
begin-structure _GstDeviceProviderClass
	drop 208 8 +field _GstDeviceProviderClass-stop
	drop 224 32 +field _GstDeviceProviderClass-_gst_reserved
	drop 216 8 +field _GstDeviceProviderClass-metadata
	drop 192 8 +field _GstDeviceProviderClass-probe
	drop 0 184 +field _GstDeviceProviderClass-parent_class
	drop 184 8 +field _GstDeviceProviderClass-factory
	drop 200 8 +field _GstDeviceProviderClass-start
drop 256 end-structure
\ _GstElement
begin-structure _GstElement
	drop 144 8 +field _GstElement-bus
	drop 152 8 +field _GstElement-clock
	drop 184 8 +field _GstElement-pads
	drop 140 4 +field _GstElement-last_return
	drop 104 16 +field _GstElement-state_cond
	drop 160 8 +field _GstElement-base_time
	drop 120 4 +field _GstElement-state_cookie
	drop 224 4 +field _GstElement-pads_cookie
	drop 132 4 +field _GstElement-next_state
	drop 128 4 +field _GstElement-current_state
	drop 124 4 +field _GstElement-target_state
	drop 192 2 +field _GstElement-numsrcpads
	drop 200 8 +field _GstElement-srcpads
	drop 240 24 +field _GstElement-_gst_reserved
	drop 208 2 +field _GstElement-numsinkpads
	drop 216 8 +field _GstElement-sinkpads
	drop 136 4 +field _GstElement-pending_state
	drop 232 8 +field _GstElement-contexts
	drop 88 16 +field _GstElement-state_lock
	drop 168 8 +field _GstElement-start_time
	drop 0 88 +field _GstElement-object
	drop 176 2 +field _GstElement-numpads
drop 264 end-structure
\ _GstElementClass
begin-structure _GstElementClass
	drop 296 8 +field _GstElementClass-provide_clock
	drop 0 184 +field _GstElementClass-parent_class
	drop 208 4 +field _GstElementClass-numpadtemplates
	drop 200 8 +field _GstElementClass-padtemplates
	drop 288 8 +field _GstElementClass-set_bus
	drop 336 8 +field _GstElementClass-set_context
	drop 192 8 +field _GstElementClass-elementfactory
	drop 212 4 +field _GstElementClass-pad_templ_cookie
	drop 328 8 +field _GstElementClass-post_message
	drop 264 8 +field _GstElementClass-set_state
	drop 256 8 +field _GstElementClass-get_state
	drop 248 8 +field _GstElementClass-release_pad
	drop 216 8 +field _GstElementClass-pad_added
	drop 344 144 +field _GstElementClass-_gst_reserved
	drop 240 8 +field _GstElementClass-request_new_pad
	drop 224 8 +field _GstElementClass-pad_removed
	drop 184 8 +field _GstElementClass-metadata
	drop 272 8 +field _GstElementClass-change_state
	drop 280 8 +field _GstElementClass-state_changed
	drop 304 8 +field _GstElementClass-set_clock
	drop 320 8 +field _GstElementClass-query
	drop 312 8 +field _GstElementClass-send_event
	drop 232 8 +field _GstElementClass-no_more_pads
drop 488 end-structure
\ _GstEvent
begin-structure _GstEvent
	drop 80 4 +field _GstEvent-seqnum
	drop 0 64 +field _GstEvent-mini_object
	drop 64 4 +field _GstEvent-type
	drop 72 8 +field _GstEvent-timestamp
drop 88 end-structure
\ _GstProxyPad
begin-structure _GstProxyPad
	drop 520 8 +field _GstProxyPad-priv
	drop 0 520 +field _GstProxyPad-pad
drop 528 end-structure
\ _GstProxyPadClass
begin-structure _GstProxyPadClass
	drop 232 8 +field _GstProxyPadClass-_gst_reserved
	drop 0 232 +field _GstProxyPadClass-parent_class
drop 240 end-structure
\ _GstGhostPad
begin-structure _GstGhostPad
	drop 528 8 +field _GstGhostPad-priv
	drop 0 528 +field _GstGhostPad-pad
drop 536 end-structure
\ _GstGhostPadClass
begin-structure _GstGhostPadClass
	drop 240 32 +field _GstGhostPadClass-_gst_reserved
	drop 0 240 +field _GstGhostPadClass-parent_class
drop 272 end-structure
\ _GstIterator
begin-structure _GstIterator
	drop 24 8 +field _GstIterator-resync
	drop 56 8 +field _GstIterator-lock
	drop 0 8 +field _GstIterator-copy
	drop 72 8 +field _GstIterator-master_cookie
	drop 88 32 +field _GstIterator-_gst_reserved
	drop 32 8 +field _GstIterator-free
	drop 64 4 +field _GstIterator-cookie
	drop 16 8 +field _GstIterator-item
	drop 48 8 +field _GstIterator-type
	drop 80 4 +field _GstIterator-size
	drop 8 8 +field _GstIterator-next
	drop 40 8 +field _GstIterator-pushed
drop 120 end-structure
\ _GstMessage
begin-structure _GstMessage
	drop 96 8 +field _GstMessage-lock
	drop 104 16 +field _GstMessage-cond
	drop 80 8 +field _GstMessage-src
	drop 88 4 +field _GstMessage-seqnum
	drop 0 64 +field _GstMessage-mini_object
	drop 64 4 +field _GstMessage-type
	drop 72 8 +field _GstMessage-timestamp
drop 120 end-structure
\ _GstMemory
begin-structure _GstMemory
	drop 0 64 +field _GstMemory-mini_object
	drop 80 8 +field _GstMemory-maxsize
	drop 88 8 +field _GstMemory-align
	drop 96 8 +field _GstMemory-offset
	drop 104 8 +field _GstMemory-size
	drop 64 8 +field _GstMemory-allocator
	drop 72 8 +field _GstMemory-parent
drop 112 end-structure
\ GstMapInfo
begin-structure GstMapInfo
	drop 16 8 +field GstMapInfo-data
	drop 72 32 +field GstMapInfo-_gst_reserved
	drop 0 8 +field GstMapInfo-memory
	drop 32 8 +field GstMapInfo-maxsize
	drop 24 8 +field GstMapInfo-size
	drop 40 32 +field GstMapInfo-user_data
	drop 8 4 +field GstMapInfo-flags
drop 104 end-structure
\ _GstMeta
begin-structure _GstMeta
	drop 8 8 +field _GstMeta-info
	drop 0 4 +field _GstMeta-flags
drop 16 end-structure
\ GstMetaTransformCopy
begin-structure GstMetaTransformCopy
	drop 8 8 +field GstMetaTransformCopy-offset
	drop 16 8 +field GstMetaTransformCopy-size
	drop 0 4 +field GstMetaTransformCopy-region
drop 24 end-structure
\ _GstMetaInfo
begin-structure _GstMetaInfo
	drop 24 8 +field _GstMetaInfo-init_func
	drop 40 8 +field _GstMetaInfo-transform_func
	drop 8 8 +field _GstMetaInfo-type
	drop 16 8 +field _GstMetaInfo-size
	drop 0 8 +field _GstMetaInfo-api
	drop 32 8 +field _GstMetaInfo-free_func
drop 48 end-structure
\ _GstMiniObject
begin-structure _GstMiniObject
	drop 8 4 +field _GstMiniObject-refcount
	drop 24 8 +field _GstMiniObject-copy
	drop 32 8 +field _GstMiniObject-dispose
	drop 40 8 +field _GstMiniObject-free
	drop 56 8 +field _GstMiniObject-priv_pointer
	drop 0 8 +field _GstMiniObject-type
	drop 16 4 +field _GstMiniObject-flags
	drop 48 4 +field _GstMiniObject-priv_uint
	drop 12 4 +field _GstMiniObject-lockstate
drop 64 end-structure
\ _GstObject
begin-structure _GstObject
	drop 24 8 +field _GstObject-lock
	drop 72 8 +field _GstObject-last_sync
	drop 32 8 +field _GstObject-name
	drop 80 8 +field _GstObject-_gst_reserved
	drop 64 8 +field _GstObject-control_rate
	drop 0 24 +field _GstObject-object
	drop 40 8 +field _GstObject-parent
	drop 48 4 +field _GstObject-flags
	drop 56 8 +field _GstObject-control_bindings
drop 88 end-structure
\ _GstObjectClass
begin-structure _GstObjectClass
	drop 152 32 +field _GstObjectClass-_gst_reserved
	drop 136 8 +field _GstObjectClass-path_string_separator
	drop 144 8 +field _GstObjectClass-deep_notify
	drop 0 136 +field _GstObjectClass-parent_class
drop 184 end-structure
\ _GstPadProbeInfo
begin-structure _GstPadProbeInfo
	drop 16 8 +field _GstPadProbeInfo-data
	drop 8 8 +field _GstPadProbeInfo-id
	drop 24 8 +field _GstPadProbeInfo-offset
	drop 0 4 +field _GstPadProbeInfo-type
	drop 32 4 +field _GstPadProbeInfo-size
	drop 40 32 +field _GstPadProbeInfo-ABI
drop 72 end-structure
\ _GstPadProbeInfo_ABI
begin-structure _GstPadProbeInfo_ABI
	drop 0 32 +field _GstPadProbeInfo_ABI-_gst_reserved
	drop 0 4 +field _GstPadProbeInfo_ABI-abi
drop 32 end-structure
\ _GstPadProbeInfo_ABI_abi
begin-structure _GstPadProbeInfo_ABI_abi
	drop 0 4 +field _GstPadProbeInfo_ABI_abi-flow_ret
drop 4 end-structure
\ _GstPad
begin-structure _GstPad
	drop 344 8 +field _GstPad-chainlistfunc
	drop 112 16 +field _GstPad-stream_rec_lock
	drop 128 8 +field _GstPad-task
	drop 472 4 +field _GstPad-num_probes
	drop 136 16 +field _GstPad-block_cond
	drop 384 8 +field _GstPad-getrangenotify
	drop 312 8 +field _GstPad-unlinknotify
	drop 288 8 +field _GstPad-linknotify
	drop 256 8 +field _GstPad-activatemodenotify
	drop 232 8 +field _GstPad-activatenotify
	drop 440 8 +field _GstPad-querynotify
	drop 464 8 +field _GstPad-iterintlinknotify
	drop 216 8 +field _GstPad-activatefunc
	drop 320 8 +field _GstPad-chainfunc
	drop 296 8 +field _GstPad-unlinkfunc
	drop 272 8 +field _GstPad-linkfunc
	drop 448 8 +field _GstPad-iterintlinkfunc
	drop 264 8 +field _GstPad-peer
	drop 152 56 +field _GstPad-probes
	drop 392 8 +field _GstPad-eventfunc
	drop 432 8 +field _GstPad-querydata
	drop 104 4 +field _GstPad-direction
	drop 352 8 +field _GstPad-chainlistdata
	drop 408 8 +field _GstPad-eventnotify
	drop 360 8 +field _GstPad-chainlistnotify
	drop 336 8 +field _GstPad-chainnotify
	drop 368 8 +field _GstPad-getrangefunc
	drop 240 8 +field _GstPad-activatemodefunc
	drop 224 8 +field _GstPad-activatedata
	drop 328 8 +field _GstPad-chaindata
	drop 88 8 +field _GstPad-element_private
	drop 96 8 +field _GstPad-padtemplate
	drop 304 8 +field _GstPad-unlinkdata
	drop 280 8 +field _GstPad-linkdata
	drop 456 8 +field _GstPad-iterintlinkdata
	drop 480 8 +field _GstPad-priv
	drop 400 8 +field _GstPad-eventdata
	drop 476 4 +field _GstPad-num_blocked
	drop 0 88 +field _GstPad-object
	drop 376 8 +field _GstPad-getrangedata
	drop 248 8 +field _GstPad-activatemodedata
	drop 424 8 +field _GstPad-queryfunc
	drop 208 4 +field _GstPad-mode
	drop 416 8 +field _GstPad-offset
	drop 488 32 +field _GstPad-ABI
drop 520 end-structure
\ _GstPad_ABI
begin-structure _GstPad_ABI
	drop 0 32 +field _GstPad_ABI-_gst_reserved
	drop 0 16 +field _GstPad_ABI-abi
drop 32 end-structure
\ _GstPad_ABI_abi
begin-structure _GstPad_ABI_abi
	drop 8 8 +field _GstPad_ABI_abi-eventfullfunc
	drop 0 4 +field _GstPad_ABI_abi-last_flowret
drop 16 end-structure
\ _GstPadClass
begin-structure _GstPadClass
	drop 200 32 +field _GstPadClass-_gst_reserved
	drop 0 184 +field _GstPadClass-parent_class
	drop 184 8 +field _GstPadClass-linked
	drop 192 8 +field _GstPadClass-unlinked
drop 232 end-structure
\ _GstParamSpecFraction
begin-structure _GstParamSpecFraction
	drop 76 4 +field _GstParamSpecFraction-min_den
	drop 0 72 +field _GstParamSpecFraction-parent_instance
	drop 80 4 +field _GstParamSpecFraction-max_num
	drop 88 4 +field _GstParamSpecFraction-def_num
	drop 84 4 +field _GstParamSpecFraction-max_den
	drop 92 4 +field _GstParamSpecFraction-def_den
	drop 72 4 +field _GstParamSpecFraction-min_num
drop 96 end-structure
\ _GstParamSpecArray
begin-structure _GstParamSpecArray
	drop 0 72 +field _GstParamSpecArray-parent_instance
	drop 72 8 +field _GstParamSpecArray-element_spec
drop 80 end-structure
\ _GstPipeline
begin-structure _GstPipeline
	drop 392 8 +field _GstPipeline-delay
	drop 408 32 +field _GstPipeline-_gst_reserved
	drop 384 8 +field _GstPipeline-stream_time
	drop 376 8 +field _GstPipeline-fixed_clock
	drop 400 8 +field _GstPipeline-priv
	drop 0 376 +field _GstPipeline-bin
drop 440 end-structure
\ _GstPipelineClass
begin-structure _GstPipelineClass
	drop 576 32 +field _GstPipelineClass-_gst_reserved
	drop 0 576 +field _GstPipelineClass-parent_class
drop 608 end-structure
\ _GstPluginDesc
begin-structure _GstPluginDesc
	drop 8 8 +field _GstPluginDesc-name
	drop 80 32 +field _GstPluginDesc-_gst_reserved
	drop 0 4 +field _GstPluginDesc-major_version
	drop 4 4 +field _GstPluginDesc-minor_version
	drop 24 8 +field _GstPluginDesc-plugin_init
	drop 32 8 +field _GstPluginDesc-version
	drop 40 8 +field _GstPluginDesc-license
	drop 48 8 +field _GstPluginDesc-source
	drop 56 8 +field _GstPluginDesc-package
	drop 16 8 +field _GstPluginDesc-description
	drop 64 8 +field _GstPluginDesc-origin
	drop 72 8 +field _GstPluginDesc-release_datetime
drop 112 end-structure
\ GstPollFD
begin-structure GstPollFD
	drop 4 4 +field GstPollFD-idx
	drop 0 4 +field GstPollFD-fd
drop 8 end-structure
\ _GstPresetInterface
begin-structure _GstPresetInterface
	drop 80 32 +field _GstPresetInterface-_gst_reserved
	drop 32 8 +field _GstPresetInterface-load_preset
	drop 40 8 +field _GstPresetInterface-save_preset
	drop 48 8 +field _GstPresetInterface-rename_preset
	drop 56 8 +field _GstPresetInterface-delete_preset
	drop 64 8 +field _GstPresetInterface-set_meta
	drop 72 8 +field _GstPresetInterface-get_meta
	drop 0 16 +field _GstPresetInterface-parent
	drop 24 8 +field _GstPresetInterface-get_property_names
	drop 16 8 +field _GstPresetInterface-get_preset_names
drop 112 end-structure
\ _GstQuery
begin-structure _GstQuery
	drop 0 64 +field _GstQuery-mini_object
	drop 64 4 +field _GstQuery-type
drop 72 end-structure
\ _GstRegistry
begin-structure _GstRegistry
	drop 88 8 +field _GstRegistry-priv
	drop 0 88 +field _GstRegistry-object
drop 96 end-structure
\ _GstRegistryClass
begin-structure _GstRegistryClass
	drop 0 184 +field _GstRegistryClass-parent_class
drop 184 end-structure
\ _GstSegment
begin-structure _GstSegment
	drop 56 8 +field _GstSegment-stop
	drop 16 8 +field _GstSegment-applied_rate
	drop 72 8 +field _GstSegment-position
	drop 88 32 +field _GstSegment-_gst_reserved
	drop 64 8 +field _GstSegment-time
	drop 80 8 +field _GstSegment-duration
	drop 40 8 +field _GstSegment-offset
	drop 0 4 +field _GstSegment-flags
	drop 8 8 +field _GstSegment-rate
	drop 24 4 +field _GstSegment-format
	drop 48 8 +field _GstSegment-start
	drop 32 8 +field _GstSegment-base
drop 120 end-structure
\ _GstStructure
begin-structure _GstStructure
	drop 8 4 +field _GstStructure-name
	drop 0 8 +field _GstStructure-type
drop 16 end-structure
\ _GstSystemClock
begin-structure _GstSystemClock
	drop 136 32 +field _GstSystemClock-_gst_reserved
	drop 128 8 +field _GstSystemClock-priv
	drop 0 128 +field _GstSystemClock-clock
drop 168 end-structure
\ _GstSystemClockClass
begin-structure _GstSystemClockClass
	drop 264 32 +field _GstSystemClockClass-_gst_reserved
	drop 0 264 +field _GstSystemClockClass-parent_class
drop 296 end-structure
\ _GstTagList
begin-structure _GstTagList
	drop 0 64 +field _GstTagList-mini_object
drop 64 end-structure
\ _GstTagSetterInterface
begin-structure _GstTagSetterInterface
	drop 0 16 +field _GstTagSetterInterface-g_iface
drop 16 end-structure
\ _GstTask
begin-structure _GstTask
	drop 96 16 +field _GstTask-cond
	drop 112 8 +field _GstTask-lock
	drop 120 8 +field _GstTask-func
	drop 152 8 +field _GstTask-thread
	drop 168 32 +field _GstTask-_gst_reserved
	drop 144 4 +field _GstTask-running
	drop 160 8 +field _GstTask-priv
	drop 0 88 +field _GstTask-object
	drop 128 8 +field _GstTask-user_data
	drop 88 4 +field _GstTask-state
	drop 136 8 +field _GstTask-notify
drop 200 end-structure
\ _GstTaskClass
begin-structure _GstTaskClass
	drop 192 32 +field _GstTaskClass-_gst_reserved
	drop 184 8 +field _GstTaskClass-pool
	drop 0 184 +field _GstTaskClass-parent_class
drop 224 end-structure
\ _GstTaskPool
begin-structure _GstTaskPool
	drop 96 32 +field _GstTaskPool-_gst_reserved
	drop 0 88 +field _GstTaskPool-object
	drop 88 8 +field _GstTaskPool-pool
drop 128 end-structure
\ _GstTaskPoolClass
begin-structure _GstTaskPoolClass
	drop 200 8 +field _GstTaskPoolClass-push
	drop 216 32 +field _GstTaskPoolClass-_gst_reserved
	drop 184 8 +field _GstTaskPoolClass-prepare
	drop 192 8 +field _GstTaskPoolClass-cleanup
	drop 208 8 +field _GstTaskPoolClass-join
	drop 0 184 +field _GstTaskPoolClass-parent_class
drop 248 end-structure
\ _GstTocSetterInterface
begin-structure _GstTocSetterInterface
	drop 0 16 +field _GstTocSetterInterface-g_iface
drop 16 end-structure
\ _GstTypeFind
begin-structure _GstTypeFind
	drop 16 8 +field _GstTypeFind-data
	drop 32 32 +field _GstTypeFind-_gst_reserved
	drop 24 8 +field _GstTypeFind-get_length
	drop 8 8 +field _GstTypeFind-suggest
	drop 0 8 +field _GstTypeFind-peek
drop 64 end-structure
\ _GstURIHandlerInterface
begin-structure _GstURIHandlerInterface
	drop 24 8 +field _GstURIHandlerInterface-get_protocols
	drop 16 8 +field _GstURIHandlerInterface-get_type
	drop 0 16 +field _GstURIHandlerInterface-parent
	drop 32 8 +field _GstURIHandlerInterface-get_uri
	drop 40 8 +field _GstURIHandlerInterface-set_uri
drop 48 end-structure
\ _GstValueTable
begin-structure _GstValueTable
	drop 32 32 +field _GstValueTable-_gst_reserved
	drop 0 8 +field _GstValueTable-type
	drop 16 8 +field _GstValueTable-serialize
	drop 24 8 +field _GstValueTable-deserialize
	drop 8 8 +field _GstValueTable-compare
drop 64 end-structure
\ _GstGLDisplay
begin-structure _GstGLDisplay
	drop 120 8 +field _GstGLDisplay-event_source
	drop 128 8 +field _GstGLDisplay-priv
	drop 0 88 +field _GstGLDisplay-object
	drop 88 4 +field _GstGLDisplay-type
	drop 104 8 +field _GstGLDisplay-main_context
	drop 96 8 +field _GstGLDisplay-windows
	drop 112 8 +field _GstGLDisplay-main_loop
drop 136 end-structure
\ _GstGLDisplayClass
begin-structure _GstGLDisplayClass
	drop 184 8 +field _GstGLDisplayClass-get_handle
	drop 192 8 +field _GstGLDisplayClass-create_window
	drop 200 32 +field _GstGLDisplayClass-_padding
	drop 0 184 +field _GstGLDisplayClass-object_class
drop 232 end-structure
\ _GstGLContext
begin-structure _GstGLContext
	drop 88 8 +field _GstGLContext-display
	drop 120 32 +field _GstGLContext-_reserved
	drop 96 8 +field _GstGLContext-window
	drop 112 8 +field _GstGLContext-priv
	drop 104 8 +field _GstGLContext-gl_vtable
	drop 0 88 +field _GstGLContext-parent
drop 152 end-structure
\ _GstGLContextClass
begin-structure _GstGLContextClass
	drop 0 184 +field _GstGLContextClass-parent_class
	drop 264 8 +field _GstGLContextClass-check_feature
	drop 248 8 +field _GstGLContextClass-destroy_context
	drop 240 8 +field _GstGLContextClass-create_context
	drop 208 8 +field _GstGLContextClass-get_gl_platform
	drop 192 8 +field _GstGLContextClass-get_gl_context
	drop 184 8 +field _GstGLContextClass-get_current_context
	drop 256 8 +field _GstGLContextClass-swap_buffers
	drop 280 32 +field _GstGLContextClass-_reserved
	drop 232 8 +field _GstGLContextClass-choose_format
	drop 200 8 +field _GstGLContextClass-get_gl_api
	drop 272 8 +field _GstGLContextClass-get_gl_platform_version
	drop 224 8 +field _GstGLContextClass-activate
	drop 216 8 +field _GstGLContextClass-get_proc_address
drop 312 end-structure
\ _GstGLWindow
begin-structure _GstGLWindow
	drop 112 4 +field _GstGLWindow-is_drawing
	drop 168 8 +field _GstGLWindow-resize
	drop 200 8 +field _GstGLWindow-main_context
	drop 104 8 +field _GstGLWindow-context_ref
	drop 184 8 +field _GstGLWindow-resize_notify
	drop 160 8 +field _GstGLWindow-close_notify
	drop 136 8 +field _GstGLWindow-draw_notify
	drop 120 8 +field _GstGLWindow-draw
	drop 192 4 +field _GstGLWindow-queue_resize
	drop 216 32 +field _GstGLWindow-_reserved
	drop 96 8 +field _GstGLWindow-display
	drop 176 8 +field _GstGLWindow-resize_data
	drop 208 8 +field _GstGLWindow-priv
	drop 152 8 +field _GstGLWindow-close_data
	drop 144 8 +field _GstGLWindow-close
	drop 0 88 +field _GstGLWindow-parent
	drop 128 8 +field _GstGLWindow-draw_data
	drop 88 8 +field _GstGLWindow-lock
drop 248 end-structure
\ _GstGLWindowClass
begin-structure _GstGLWindowClass
	drop 0 184 +field _GstGLWindowClass-parent_class
	drop 272 8 +field _GstGLWindowClass-set_preferred_size
	drop 264 8 +field _GstGLWindowClass-handle_events
	drop 200 8 +field _GstGLWindowClass-get_window_handle
	drop 192 8 +field _GstGLWindowClass-set_window_handle
	drop 280 8 +field _GstGLWindowClass-show
	drop 232 8 +field _GstGLWindowClass-send_message
	drop 208 8 +field _GstGLWindowClass-draw
	drop 288 8 +field _GstGLWindowClass-set_render_rectangle
	drop 296 8 +field _GstGLWindowClass-queue_resize
	drop 240 8 +field _GstGLWindowClass-send_message_async
	drop 304 8 +field _GstGLWindowClass-controls_viewport
	drop 312 24 +field _GstGLWindowClass-_reserved
	drop 184 8 +field _GstGLWindowClass-get_display
	drop 216 8 +field _GstGLWindowClass-run
	drop 248 8 +field _GstGLWindowClass-open
	drop 224 8 +field _GstGLWindowClass-quit
	drop 256 8 +field _GstGLWindowClass-close
drop 336 end-structure
\ _GstGLShader
begin-structure _GstGLShader
	drop 96 8 +field _GstGLShader-priv
	drop 104 32 +field _GstGLShader-_padding
	drop 0 88 +field _GstGLShader-parent
	drop 88 8 +field _GstGLShader-context
drop 136 end-structure
\ _GstGLShaderClass
begin-structure _GstGLShaderClass
	drop 0 184 +field _GstGLShaderClass-parent_class
drop 184 end-structure
\ _GstGLUpload
begin-structure _GstGLUpload
	drop 104 32 +field _GstGLUpload-_reserved
	drop 96 8 +field _GstGLUpload-priv
	drop 0 88 +field _GstGLUpload-parent
	drop 88 8 +field _GstGLUpload-context
drop 136 end-structure
\ _GstGLUploadClass
begin-structure _GstGLUploadClass
	drop 184 32 +field _GstGLUploadClass-_padding
	drop 0 184 +field _GstGLUploadClass-object_class
drop 216 end-structure
\ _GstGLMemory
begin-structure _GstGLMemory
	drop 224 4 +field _GstGLMemory-tex_id
	drop 228 4 +field _GstGLMemory-tex_target
	drop 428 8 +field _GstGLMemory-tex_scaling
	drop 0 224 +field _GstGLMemory-mem
	drop 424 4 +field _GstGLMemory-plane
	drop 440 4 +field _GstGLMemory-unpack_length
	drop 448 32 +field _GstGLMemory-_padding
	drop 232 4 +field _GstGLMemory-tex_format
	drop 240 152 +field _GstGLMemory-info
	drop 436 4 +field _GstGLMemory-texture_wrapped
	drop 444 4 +field _GstGLMemory-tex_width
	drop 392 32 +field _GstGLMemory-valign
drop 480 end-structure
\ _GstGLVideoAllocationParams
begin-structure _GstGLVideoAllocationParams
	drop 120 8 +field _GstGLVideoAllocationParams-v_info
	drop 144 4 +field _GstGLVideoAllocationParams-target
	drop 128 4 +field _GstGLVideoAllocationParams-plane
	drop 152 32 +field _GstGLVideoAllocationParams-_padding
	drop 148 4 +field _GstGLVideoAllocationParams-tex_format
	drop 0 120 +field _GstGLVideoAllocationParams-parent
	drop 136 8 +field _GstGLVideoAllocationParams-valign
drop 184 end-structure
\ _GstGLMemoryAllocator
begin-structure _GstGLMemoryAllocator
	drop 216 32 +field _GstGLMemoryAllocator-_padding
	drop 0 216 +field _GstGLMemoryAllocator-parent
drop 248 end-structure
\ _GstGLMemoryAllocatorClass
begin-structure _GstGLMemoryAllocatorClass
	drop 320 8 +field _GstGLMemoryAllocatorClass-copy
	drop 328 8 +field _GstGLMemoryAllocatorClass-unmap
	drop 336 32 +field _GstGLMemoryAllocatorClass-_padding
	drop 312 8 +field _GstGLMemoryAllocatorClass-map
	drop 0 312 +field _GstGLMemoryAllocatorClass-parent_class
drop 368 end-structure
\ _GstGLBufferPool
begin-structure _GstGLBufferPool
	drop 0 136 +field _GstGLBufferPool-bufferpool
	drop 144 8 +field _GstGLBufferPool-priv
	drop 152 32 +field _GstGLBufferPool-_padding
	drop 136 8 +field _GstGLBufferPool-context
drop 184 end-structure
\ _GstGLBufferPoolClass
begin-structure _GstGLBufferPoolClass
	drop 288 32 +field _GstGLBufferPoolClass-_padding
	drop 0 288 +field _GstGLBufferPoolClass-parent_class
drop 320 end-structure
\ _GstGLFramebuffer
begin-structure _GstGLFramebuffer
	drop 96 4 +field _GstGLFramebuffer-fbo_id
	drop 104 8 +field _GstGLFramebuffer-attachments
	drop 112 32 +field _GstGLFramebuffer-_padding
	drop 144 8 +field _GstGLFramebuffer-priv
	drop 0 88 +field _GstGLFramebuffer-object
	drop 88 8 +field _GstGLFramebuffer-context
drop 152 end-structure
\ _GstGLFramebufferClass
begin-structure _GstGLFramebufferClass
	drop 184 32 +field _GstGLFramebufferClass-_padding
	drop 0 184 +field _GstGLFramebufferClass-object_class
drop 216 end-structure
\ _GstGLFilter
begin-structure _GstGLFilter
	drop 968 8 +field _GstGLFilter-fbo
	drop 648 152 +field _GstGLFilter-in_info
	drop 1008 4 +field _GstGLFilter-valid_attributes
	drop 956 4 +field _GstGLFilter-out_texture_target
	drop 952 4 +field _GstGLFilter-in_texture_target
	drop 1020 4 +field _GstGLFilter-vertex_buffer
	drop 992 8 +field _GstGLFilter-outbuf
	drop 984 8 +field _GstGLFilter-inbuf
	drop 1016 4 +field _GstGLFilter-vbo_indices
	drop 960 8 +field _GstGLFilter-out_caps
	drop 1028 4 +field _GstGLFilter-draw_attr_texture_loc
	drop 976 4 +field _GstGLFilter-gl_result
	drop 800 152 +field _GstGLFilter-out_info
	drop 1024 4 +field _GstGLFilter-draw_attr_position_loc
	drop 1032 32 +field _GstGLFilter-_padding
	drop 1000 8 +field _GstGLFilter-default_shader
	drop 1012 4 +field _GstGLFilter-vao
	drop 0 648 +field _GstGLFilter-parent
drop 1064 end-structure
\ _GstGLFilterClass
begin-structure _GstGLFilterClass
	drop 912 8 +field _GstGLFilterClass-transform_internal_caps
	drop 880 8 +field _GstGLFilterClass-set_caps
	drop 888 8 +field _GstGLFilterClass-filter
	drop 920 32 +field _GstGLFilterClass-_padding
	drop 904 8 +field _GstGLFilterClass-init_fbo
	drop 0 880 +field _GstGLFilterClass-parent_class
	drop 896 8 +field _GstGLFilterClass-filter_texture
drop 952 end-structure
\ _GstGLSyncMeta
begin-structure _GstGLSyncMeta
	drop 32 8 +field _GstGLSyncMeta-set_sync
	drop 72 8 +field _GstGLSyncMeta-wait_cpu_gl
	drop 24 8 +field _GstGLSyncMeta-data
	drop 80 8 +field _GstGLSyncMeta-copy
	drop 48 8 +field _GstGLSyncMeta-wait
	drop 56 8 +field _GstGLSyncMeta-wait_gl
	drop 88 8 +field _GstGLSyncMeta-free
	drop 64 8 +field _GstGLSyncMeta-wait_cpu
	drop 40 8 +field _GstGLSyncMeta-set_sync_gl
	drop 0 16 +field _GstGLSyncMeta-parent
	drop 16 8 +field _GstGLSyncMeta-context
	drop 96 8 +field _GstGLSyncMeta-free_gl
drop 104 end-structure
\ _GstGLDisplayEGL
begin-structure _GstGLDisplayEGL
	drop 136 8 +field _GstGLDisplayEGL-display
	drop 144 4 +field _GstGLDisplayEGL-foreign_display
	drop 152 32 +field _GstGLDisplayEGL-_padding
	drop 0 136 +field _GstGLDisplayEGL-parent
drop 184 end-structure
\ _GstGLDisplayEGLClass
begin-structure _GstGLDisplayEGLClass
	drop 232 32 +field _GstGLDisplayEGLClass-_padding
	drop 0 232 +field _GstGLDisplayEGLClass-object_class
drop 264 end-structure
\ _GstGLDisplayX11
begin-structure _GstGLDisplayX11
	drop 144 8 +field _GstGLDisplayX11-display
	drop 160 4 +field _GstGLDisplayX11-foreign_display
	drop 136 8 +field _GstGLDisplayX11-name
	drop 168 32 +field _GstGLDisplayX11-_padding
	drop 0 136 +field _GstGLDisplayX11-parent
	drop 152 8 +field _GstGLDisplayX11-xcb_connection
drop 200 end-structure
\ _GstGLDisplayX11Class
begin-structure _GstGLDisplayX11Class
	drop 232 32 +field _GstGLDisplayX11Class-_padding
	drop 0 232 +field _GstGLDisplayX11Class-object_class
drop 264 end-structure

\ --===< function pointers >===---
c-funptr _GstBinClass-element_added() {((struct _GstBinClass*)ptr)->element_added} a a -- void	( bin child -- )
c-funptr _GstBinClass-element_removed() {((struct _GstBinClass*)ptr)->element_removed} a a -- void	( bin child -- )
c-funptr _GstBinClass-add_element() {((struct _GstBinClass*)ptr)->add_element} a a -- n	( bin element -- )
c-funptr _GstBinClass-remove_element() {((struct _GstBinClass*)ptr)->remove_element} a a -- n	( bin element -- )
c-funptr _GstBinClass-handle_message() {((struct _GstBinClass*)ptr)->handle_message} a a -- void	( bin message -- )
c-funptr _GstBinClass-do_latency() {((struct _GstBinClass*)ptr)->do_latency} a -- n	( bin -- )
c-funptr _GstBinClass-deep_element_added() {((struct _GstBinClass*)ptr)->deep_element_added} a a a -- void	( bin sub_bin child -- )
c-funptr _GstBinClass-deep_element_removed() {((struct _GstBinClass*)ptr)->deep_element_removed} a a a -- void	( bin sub_bin child -- )
c-funptr _GstBufferPoolClass-get_options() {((struct _GstBufferPoolClass*)ptr)->get_options} a -- a	( pool -- )
c-funptr _GstBufferPoolClass-set_config() {((struct _GstBufferPoolClass*)ptr)->set_config} a a -- n	( pool config -- )
c-funptr _GstBufferPoolClass-start() {((struct _GstBufferPoolClass*)ptr)->start} a -- n	( pool -- )
c-funptr _GstBufferPoolClass-stop() {((struct _GstBufferPoolClass*)ptr)->stop} a -- n	( pool -- )
c-funptr _GstBufferPoolClass-acquire_buffer() {((struct _GstBufferPoolClass*)ptr)->acquire_buffer} a a a -- n	( pool buffer params -- )
c-funptr _GstBufferPoolClass-alloc_buffer() {((struct _GstBufferPoolClass*)ptr)->alloc_buffer} a a a -- n	( pool buffer params -- )
c-funptr _GstBufferPoolClass-reset_buffer() {((struct _GstBufferPoolClass*)ptr)->reset_buffer} a a -- void	( pool buffer -- )
c-funptr _GstBufferPoolClass-release_buffer() {((struct _GstBufferPoolClass*)ptr)->release_buffer} a a -- void	( pool buffer -- )
c-funptr _GstBufferPoolClass-free_buffer() {((struct _GstBufferPoolClass*)ptr)->free_buffer} a a -- void	( pool buffer -- )
c-funptr _GstBufferPoolClass-flush_start() {((struct _GstBufferPoolClass*)ptr)->flush_start} a -- void	( pool -- )
c-funptr _GstBufferPoolClass-flush_stop() {((struct _GstBufferPoolClass*)ptr)->flush_stop} a -- void	( pool -- )
c-funptr _GstBusClass-message() {((struct _GstBusClass*)ptr)->message} a a -- void	( bus message -- )
c-funptr _GstBusClass-sync_message() {((struct _GstBusClass*)ptr)->sync_message} a a -- void	( bus message -- )
c-funptr _GstChildProxyInterface-get_child_by_name() {((struct _GstChildProxyInterface*)ptr)->get_child_by_name} a s -- a	( parent name -- )
c-funptr _GstChildProxyInterface-get_child_by_index() {((struct _GstChildProxyInterface*)ptr)->get_child_by_index} a u -- a	( parent index -- )
c-funptr _GstChildProxyInterface-get_children_count() {((struct _GstChildProxyInterface*)ptr)->get_children_count} a -- u	( parent -- )
c-funptr _GstChildProxyInterface-child_added() {((struct _GstChildProxyInterface*)ptr)->child_added} a a s -- void	( parent child name -- )
c-funptr _GstChildProxyInterface-child_removed() {((struct _GstChildProxyInterface*)ptr)->child_removed} a a s -- void	( parent child name -- )
c-funptr _GstClockClass-change_resolution() {((struct _GstClockClass*)ptr)->change_resolution} a ud ud -- ud	( clock old_resolution new_resolution -- )
c-funptr _GstClockClass-get_resolution() {((struct _GstClockClass*)ptr)->get_resolution} a -- ud	( clock -- )
c-funptr _GstClockClass-get_internal_time() {((struct _GstClockClass*)ptr)->get_internal_time} a -- ud	( clock -- )
c-funptr _GstClockClass-wait() {((struct _GstClockClass*)ptr)->wait} a a a -- n	( clock entry jitter -- )
c-funptr _GstClockClass-wait_async() {((struct _GstClockClass*)ptr)->wait_async} a a -- n	( clock entry -- )
c-funptr _GstClockClass-unschedule() {((struct _GstClockClass*)ptr)->unschedule} a a -- void	( clock entry -- )
c-funptr _GstDeviceClass-create_element() {((struct _GstDeviceClass*)ptr)->create_element} a s -- a	( device name -- )
c-funptr _GstDeviceClass-reconfigure_element() {((struct _GstDeviceClass*)ptr)->reconfigure_element} a a -- n	( device element -- )
c-funptr _GstDeviceProviderClass-probe() {((struct _GstDeviceProviderClass*)ptr)->probe} a -- a	( provider -- )
c-funptr _GstDeviceProviderClass-start() {((struct _GstDeviceProviderClass*)ptr)->start} a -- n	( provider -- )
c-funptr _GstDeviceProviderClass-stop() {((struct _GstDeviceProviderClass*)ptr)->stop} a -- void	( provider -- )
c-funptr _GstElementClass-pad_added() {((struct _GstElementClass*)ptr)->pad_added} a a -- void	( element pad -- )
c-funptr _GstElementClass-pad_removed() {((struct _GstElementClass*)ptr)->pad_removed} a a -- void	( element pad -- )
c-funptr _GstElementClass-no_more_pads() {((struct _GstElementClass*)ptr)->no_more_pads} a -- void	( element -- )
c-funptr _GstElementClass-request_new_pad() {((struct _GstElementClass*)ptr)->request_new_pad} a a s a -- a	( element templ name caps -- )
c-funptr _GstElementClass-release_pad() {((struct _GstElementClass*)ptr)->release_pad} a a -- void	( element pad -- )
c-funptr _GstElementClass-get_state() {((struct _GstElementClass*)ptr)->get_state} a a a ud -- n	( element state pending timeout -- )
c-funptr _GstElementClass-set_state() {((struct _GstElementClass*)ptr)->set_state} a n -- n	( element state -- )
c-funptr _GstElementClass-change_state() {((struct _GstElementClass*)ptr)->change_state} a n -- n	( element transition -- )
c-funptr _GstElementClass-state_changed() {((struct _GstElementClass*)ptr)->state_changed} a n n n -- void	( element oldstate newstate pending -- )
c-funptr _GstElementClass-set_bus() {((struct _GstElementClass*)ptr)->set_bus} a a -- void	( element bus -- )
c-funptr _GstElementClass-provide_clock() {((struct _GstElementClass*)ptr)->provide_clock} a -- a	( element -- )
c-funptr _GstElementClass-set_clock() {((struct _GstElementClass*)ptr)->set_clock} a a -- n	( element clock -- )
c-funptr _GstElementClass-send_event() {((struct _GstElementClass*)ptr)->send_event} a a -- n	( element event -- )
c-funptr _GstElementClass-query() {((struct _GstElementClass*)ptr)->query} a a -- n	( element query -- )
c-funptr _GstElementClass-post_message() {((struct _GstElementClass*)ptr)->post_message} a a -- n	( element message -- )
c-funptr _GstElementClass-set_context() {((struct _GstElementClass*)ptr)->set_context} a a -- void	( element context -- )
c-funptr _GstObjectClass-deep_notify() {((struct _GstObjectClass*)ptr)->deep_notify} a a a -- void	( object orig pspec -- )
c-funptr _GstPadClass-linked() {((struct _GstPadClass*)ptr)->linked} a a -- void	( pad peer -- )
c-funptr _GstPadClass-unlinked() {((struct _GstPadClass*)ptr)->unlinked} a a -- void	( pad peer -- )
c-funptr _GstPresetInterface-get_preset_names() {((struct _GstPresetInterface*)ptr)->get_preset_names} a -- a	( preset -- )
c-funptr _GstPresetInterface-get_property_names() {((struct _GstPresetInterface*)ptr)->get_property_names} a -- a	( preset -- )
c-funptr _GstPresetInterface-load_preset() {((struct _GstPresetInterface*)ptr)->load_preset} a s -- n	( preset name -- )
c-funptr _GstPresetInterface-save_preset() {((struct _GstPresetInterface*)ptr)->save_preset} a s -- n	( preset name -- )
c-funptr _GstPresetInterface-rename_preset() {((struct _GstPresetInterface*)ptr)->rename_preset} a s s -- n	( preset old_name new_name -- )
c-funptr _GstPresetInterface-delete_preset() {((struct _GstPresetInterface*)ptr)->delete_preset} a s -- n	( preset name -- )
c-funptr _GstPresetInterface-set_meta() {((struct _GstPresetInterface*)ptr)->set_meta} a s s s -- n	( preset name tag value -- )
c-funptr _GstPresetInterface-get_meta() {((struct _GstPresetInterface*)ptr)->get_meta} a s s a -- n	( preset name tag value -- )
c-funptr _GstTaskPoolClass-prepare() {((struct _GstTaskPoolClass*)ptr)->prepare} a a -- void	( pool error -- )
c-funptr _GstTaskPoolClass-cleanup() {((struct _GstTaskPoolClass*)ptr)->cleanup} a -- void	( pool -- )
c-funptr _GstTaskPoolClass-push() {((struct _GstTaskPoolClass*)ptr)->push} a a a a -- a	( pool func user_data error -- )
c-funptr _GstTaskPoolClass-join() {((struct _GstTaskPoolClass*)ptr)->join} a a -- void	( pool id -- )
c-funptr _GstTypeFind-peek() {((struct _GstTypeFind*)ptr)->peek} a d u -- a	( data offset size -- )
c-funptr _GstTypeFind-suggest() {((struct _GstTypeFind*)ptr)->suggest} a u a -- void	( data probability caps -- )
c-funptr _GstTypeFind-get_length() {((struct _GstTypeFind*)ptr)->get_length} a -- ud	( data -- )
c-funptr _GstURIHandlerInterface-get_type() {((struct _GstURIHandlerInterface*)ptr)->get_type} u -- n	( type -- )
c-funptr _GstURIHandlerInterface-get_protocols() {((struct _GstURIHandlerInterface*)ptr)->get_protocols} u -- a	( type -- )
c-funptr _GstURIHandlerInterface-get_uri() {((struct _GstURIHandlerInterface*)ptr)->get_uri} a -- a	( handler -- )
c-funptr _GstURIHandlerInterface-set_uri() {((struct _GstURIHandlerInterface*)ptr)->set_uri} a s a -- n	( handler uri error -- )
c-funptr _GstGLDisplayClass-get_handle() {((struct _GstGLDisplayClass*)ptr)->get_handle} a -- u	( display -- )
c-funptr _GstGLDisplayClass-create_window() {((struct _GstGLDisplayClass*)ptr)->create_window} a -- a	( display -- )
c-funptr _GstGLContextClass-get_current_context() {((struct _GstGLContextClass*)ptr)->get_current_context}  -- u	( <noname> -- )
c-funptr _GstGLContextClass-get_gl_context() {((struct _GstGLContextClass*)ptr)->get_gl_context} a -- u	( context -- )
c-funptr _GstGLContextClass-get_gl_api() {((struct _GstGLContextClass*)ptr)->get_gl_api} a -- n	( context -- )
c-funptr _GstGLContextClass-get_gl_platform() {((struct _GstGLContextClass*)ptr)->get_gl_platform} a -- n	( context -- )
c-funptr _GstGLContextClass-get_proc_address() {((struct _GstGLContextClass*)ptr)->get_proc_address} n s -- a	( gl_api name -- )
c-funptr _GstGLContextClass-activate() {((struct _GstGLContextClass*)ptr)->activate} a n -- n	( context activate -- )
c-funptr _GstGLContextClass-choose_format() {((struct _GstGLContextClass*)ptr)->choose_format} a a -- n	( context error -- )
c-funptr _GstGLContextClass-create_context() {((struct _GstGLContextClass*)ptr)->create_context} a n a a -- n	( context gl_api other_context error -- )
c-funptr _GstGLContextClass-destroy_context() {((struct _GstGLContextClass*)ptr)->destroy_context} a -- void	( context -- )
c-funptr _GstGLContextClass-swap_buffers() {((struct _GstGLContextClass*)ptr)->swap_buffers} a -- void	( context -- )
c-funptr _GstGLContextClass-check_feature() {((struct _GstGLContextClass*)ptr)->check_feature} a s -- n	( context feature -- )
c-funptr _GstGLContextClass-get_gl_platform_version() {((struct _GstGLContextClass*)ptr)->get_gl_platform_version} a a a -- void	( context major minor -- )
c-funptr _GstGLWindowClass-get_display() {((struct _GstGLWindowClass*)ptr)->get_display} a -- u	( window -- )
c-funptr _GstGLWindowClass-set_window_handle() {((struct _GstGLWindowClass*)ptr)->set_window_handle} a u -- void	( window handle -- )
c-funptr _GstGLWindowClass-get_window_handle() {((struct _GstGLWindowClass*)ptr)->get_window_handle} a -- u	( window -- )
c-funptr _GstGLWindowClass-draw() {((struct _GstGLWindowClass*)ptr)->draw} a -- void	( window -- )
c-funptr _GstGLWindowClass-run() {((struct _GstGLWindowClass*)ptr)->run} a -- void	( window -- )
c-funptr _GstGLWindowClass-quit() {((struct _GstGLWindowClass*)ptr)->quit} a -- void	( window -- )
c-funptr _GstGLWindowClass-send_message() {((struct _GstGLWindowClass*)ptr)->send_message} a a a -- void	( window callback data -- )
c-funptr _GstGLWindowClass-send_message_async() {((struct _GstGLWindowClass*)ptr)->send_message_async} a a a a -- void	( window callback data destroy -- )
c-funptr _GstGLWindowClass-open() {((struct _GstGLWindowClass*)ptr)->open} a a -- n	( window error -- )
c-funptr _GstGLWindowClass-close() {((struct _GstGLWindowClass*)ptr)->close} a -- void	( window -- )
c-funptr _GstGLWindowClass-handle_events() {((struct _GstGLWindowClass*)ptr)->handle_events} a n -- void	( window handle_events -- )
c-funptr _GstGLWindowClass-set_preferred_size() {((struct _GstGLWindowClass*)ptr)->set_preferred_size} a n n -- void	( window width height -- )
c-funptr _GstGLWindowClass-show() {((struct _GstGLWindowClass*)ptr)->show} a -- void	( window -- )
c-funptr _GstGLWindowClass-set_render_rectangle() {((struct _GstGLWindowClass*)ptr)->set_render_rectangle} a n n n n -- n	( window x y width height -- )
c-funptr _GstGLWindowClass-queue_resize() {((struct _GstGLWindowClass*)ptr)->queue_resize} a -- void	( window -- )
c-funptr _GstGLWindowClass-controls_viewport() {((struct _GstGLWindowClass*)ptr)->controls_viewport} a -- n	( window -- )
c-funptr _GstGLFilterClass-set_caps() {((struct _GstGLFilterClass*)ptr)->set_caps} a a a -- n	( filter incaps outcaps -- )
c-funptr _GstGLFilterClass-filter() {((struct _GstGLFilterClass*)ptr)->filter} a a a -- n	( filter inbuf outbuf -- )
c-funptr _GstGLFilterClass-filter_texture() {((struct _GstGLFilterClass*)ptr)->filter_texture} a a a -- n	( filter in_tex out_tex -- )
c-funptr _GstGLFilterClass-init_fbo() {((struct _GstGLFilterClass*)ptr)->init_fbo} a -- n	( filter -- )
c-funptr _GstGLFilterClass-transform_internal_caps() {((struct _GstGLFilterClass*)ptr)->transform_internal_caps} a n a a -- a	( filter direction caps filter_caps -- )
c-funptr _GstGLSyncMeta-set_sync() {((struct _GstGLSyncMeta*)ptr)->set_sync} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-set_sync_gl() {((struct _GstGLSyncMeta*)ptr)->set_sync_gl} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-wait() {((struct _GstGLSyncMeta*)ptr)->wait} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-wait_gl() {((struct _GstGLSyncMeta*)ptr)->wait_gl} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-wait_cpu() {((struct _GstGLSyncMeta*)ptr)->wait_cpu} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-wait_cpu_gl() {((struct _GstGLSyncMeta*)ptr)->wait_cpu_gl} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-copy() {((struct _GstGLSyncMeta*)ptr)->copy} a a a a -- void	( src sbuffer dest dbuffer -- )
c-funptr _GstGLSyncMeta-free() {((struct _GstGLSyncMeta*)ptr)->free} a a -- void	( sync context -- )
c-funptr _GstGLSyncMeta-free_gl() {((struct _GstGLSyncMeta*)ptr)->free_gl} a a -- void	( sync context -- )

\ ------===< callbacks >===-------
c-callback reshapeCallback: u u a -- void
c-callback drawCallback: u u u a -- void
c-callback GstBufferForeachMetaFunc: a a a -- n	( buffer meta user_data -- )
c-callback GstBufferListFunc: a u a -- n	( buffer idx user_data -- )
c-callback GstBusSyncHandler: a a a -- n	( bus message user_data -- )
c-callback GstBusFunc: a a a -- n	( bus message user_data -- )
c-callback GstCapsForeachFunc: a a a -- n	( features structure user_data -- )
c-callback GstCapsMapFunc: a a a -- n	( features structure user_data -- )
c-callback GstCapsFilterMapFunc: a a a -- n	( features structure user_data -- )
c-callback GstClockCallback: a ud a a -- n	( clock time id user_data -- )
c-callback GstControlSourceGetValue: a ud a -- n	( self timestamp value -- )
c-callback GstControlSourceGetValueArray: a ud ud u a -- n	( self timestamp interval n_values values -- )
c-callback GstElementForeachPadFunc: a a a -- n	( element pad user_data -- )
c-callback GstElementCallAsyncFunc: a a -- void	( element user_data -- )
c-callback GstIteratorCopyFunction: a a -- void	( it copy -- )
c-callback GstIteratorItemFunction: a a -- n	( it item -- )
c-callback GstIteratorNextFunction: a a -- n	( it result -- )
c-callback GstIteratorResyncFunction: a -- void	( it -- )
c-callback GstIteratorFreeFunction: a -- void	( it -- )
c-callback GstIteratorForeachFunction: a a -- void	( item user_data -- )
c-callback GstIteratorFoldFunction: a a a -- n	( item ret user_data -- )
c-callback GstMemoryMapFunction: a u n -- a	( mem maxsize flags -- )
c-callback GstMemoryMapFullFunction: a a u -- a	( mem info maxsize -- )
c-callback GstMemoryUnmapFunction: a -- void	( mem -- )
c-callback GstMemoryUnmapFullFunction: a a -- void	( mem info -- )
c-callback GstMemoryCopyFunction: a n n -- a	( mem offset size -- )
c-callback GstMemoryShareFunction: a n n -- a	( mem offset size -- )
c-callback GstMemoryIsSpanFunction: a a a -- n	( mem1 mem2 offset -- )
c-callback GstMetaInitFunction: a a a -- n	( meta params buffer -- )
c-callback GstMetaFreeFunction: a a -- void	( meta buffer -- )
c-callback GstMetaTransformFunction: a a a n a -- n	( transbuf meta buffer type data -- )
c-callback GstMiniObjectCopyFunction: a -- a	( obj -- )
c-callback GstMiniObjectDisposeFunction: a -- n	( obj -- )
c-callback GstMiniObjectFreeFunction: a -- void	( obj -- )
c-callback GstMiniObjectNotify: a a -- void	( user_data obj -- )
c-callback GstPadActivateFunction: a a -- n	( pad parent -- )
c-callback GstPadActivateModeFunction: a a n n -- n	( pad parent mode active -- )
c-callback GstPadChainFunction: a a a -- n	( pad parent buffer -- )
c-callback GstPadChainListFunction: a a a -- n	( pad parent list -- )
c-callback GstPadGetRangeFunction: a a ud u a -- n	( pad parent offset length buffer -- )
c-callback GstPadEventFunction: a a a -- n	( pad parent event -- )
c-callback GstPadEventFullFunction: a a a -- n	( pad parent event -- )
c-callback GstPadIterIntLinkFunction: a a -- a	( pad parent -- )
c-callback GstPadQueryFunction: a a a -- n	( pad parent query -- )
c-callback GstPadLinkFunction: a a a -- n	( pad parent peer -- )
c-callback GstPadUnlinkFunction: a a -- void	( pad parent -- )
c-callback GstPadForwardFunction: a a -- n	( pad user_data -- )
c-callback GstPadProbeCallback: a a a -- n	( pad info user_data -- )
c-callback GstPadStickyEventsForeachFunction: a a a -- n	( pad event user_data -- )
c-callback GstPluginInitFunc: a -- n	( plugin -- )
c-callback GstPluginInitFullFunc: a a -- n	( plugin user_data -- )
c-callback GstPluginFilter: a a -- n	( plugin user_data -- )
c-callback GstStructureForeachFunc: n a a -- n	( field_id value user_data -- )
c-callback GstStructureMapFunc: n a a -- n	( field_id value user_data -- )
c-callback GstStructureFilterMapFunc: n a a -- n	( field_id value user_data -- )
c-callback GstTagForeachFunc: a s a -- void	( list tag user_data -- )
c-callback GstTagMergeFunc: a a -- void	( dest src -- )
c-callback GstTaskFunction: a -- void	( user_data -- )
c-callback GstTaskThreadFunc: a a a -- void	( task thread user_data -- )
c-callback GstTaskPoolFunction: a -- void	( user_data -- )
c-callback GstTypeFindFunction: a a -- void	( find user_data -- )
c-callback GstValueCompareFunc: a a -- n	( value1 value2 -- )
c-callback GstValueSerializeFunc: a -- a	( value1 -- )
c-callback GstValueDeserializeFunc: a s -- n	( dest s -- )
c-callback GstGLContextThreadFunc: a a -- void	( context data -- )
c-callback GstGLWindowCB: a -- void	( data -- )
c-callback GstGLWindowResizeCB: a u u -- void	( data width height -- )
c-callback GstGLFramebufferFunc: a -- n	( stuff -- )
c-callback GstGLFilterRenderFunc: a a a -- n	( filter in_tex user_data -- )

\ ------===< functions >===-------
c-function gst_init gst_init a a -- void	( argc argv -- )
c-function gst_init_check gst_init_check a a a -- n	( argc argv err -- )
c-function gst_is_initialized gst_is_initialized  -- n	( -- )
c-function gst_init_get_option_group gst_init_get_option_group  -- a	( -- )
c-function gst_deinit gst_deinit  -- void	( -- )
c-function gst_version gst_version a a a a -- void	( major minor micro nano -- )
c-function gst_version_string gst_version_string  -- a	( -- )
c-function gst_segtrap_is_enabled gst_segtrap_is_enabled  -- n	( -- )
c-function gst_segtrap_set_enabled gst_segtrap_set_enabled n -- void	( enabled -- )
c-function gst_registry_fork_is_enabled gst_registry_fork_is_enabled  -- n	( -- )
c-function gst_registry_fork_set_enabled gst_registry_fork_set_enabled n -- void	( enabled -- )
c-function gst_update_registry gst_update_registry  -- n	( -- )
c-function gst_get_main_executable_path gst_get_main_executable_path  -- s	( -- )
c-function gst_allocator_flags_get_type gst_allocator_flags_get_type  -- u	( -- )
c-function gst_bin_flags_get_type gst_bin_flags_get_type  -- u	( -- )
c-function gst_buffer_flags_get_type gst_buffer_flags_get_type  -- u	( -- )
c-function gst_buffer_copy_flags_get_type gst_buffer_copy_flags_get_type  -- u	( -- )
c-function gst_buffer_pool_acquire_flags_get_type gst_buffer_pool_acquire_flags_get_type  -- u	( -- )
c-function gst_bus_flags_get_type gst_bus_flags_get_type  -- u	( -- )
c-function gst_bus_sync_reply_get_type gst_bus_sync_reply_get_type  -- u	( -- )
c-function gst_caps_flags_get_type gst_caps_flags_get_type  -- u	( -- )
c-function gst_caps_intersect_mode_get_type gst_caps_intersect_mode_get_type  -- u	( -- )
c-function gst_clock_return_get_type gst_clock_return_get_type  -- u	( -- )
c-function gst_clock_entry_type_get_type gst_clock_entry_type_get_type  -- u	( -- )
c-function gst_clock_flags_get_type gst_clock_flags_get_type  -- u	( -- )
c-function gst_debug_graph_details_get_type gst_debug_graph_details_get_type  -- u	( -- )
c-function gst_state_get_type gst_state_get_type  -- u	( -- )
c-function gst_state_change_return_get_type gst_state_change_return_get_type  -- u	( -- )
c-function gst_state_change_get_type gst_state_change_get_type  -- u	( -- )
c-function gst_element_flags_get_type gst_element_flags_get_type  -- u	( -- )
c-function gst_core_error_get_type gst_core_error_get_type  -- u	( -- )
c-function gst_library_error_get_type gst_library_error_get_type  -- u	( -- )
c-function gst_resource_error_get_type gst_resource_error_get_type  -- u	( -- )
c-function gst_stream_error_get_type gst_stream_error_get_type  -- u	( -- )
c-function gst_event_type_flags_get_type gst_event_type_flags_get_type  -- u	( -- )
c-function gst_event_type_get_type gst_event_type_get_type  -- u	( -- )
c-function gst_stream_flags_get_type gst_stream_flags_get_type  -- u	( -- )
c-function gst_qos_type_get_type gst_qos_type_get_type  -- u	( -- )
c-function gst_format_get_type gst_format_get_type  -- u	( -- )
c-function gst_debug_level_get_type gst_debug_level_get_type  -- u	( -- )
c-function gst_debug_color_flags_get_type gst_debug_color_flags_get_type  -- u	( -- )
c-function gst_stack_trace_flags_get_type gst_stack_trace_flags_get_type  -- u	( -- )
c-function gst_debug_color_mode_get_type gst_debug_color_mode_get_type  -- u	( -- )
c-function gst_iterator_result_get_type gst_iterator_result_get_type  -- u	( -- )
c-function gst_iterator_item_get_type gst_iterator_item_get_type  -- u	( -- )
c-function gst_memory_flags_get_type gst_memory_flags_get_type  -- u	( -- )
c-function gst_map_flags_get_type gst_map_flags_get_type  -- u	( -- )
c-function gst_message_type_get_type gst_message_type_get_type  -- u	( -- )
c-function gst_structure_change_type_get_type gst_structure_change_type_get_type  -- u	( -- )
c-function gst_stream_status_type_get_type gst_stream_status_type_get_type  -- u	( -- )
c-function gst_progress_type_get_type gst_progress_type_get_type  -- u	( -- )
c-function gst_meta_flags_get_type gst_meta_flags_get_type  -- u	( -- )
c-function gst_mini_object_flags_get_type gst_mini_object_flags_get_type  -- u	( -- )
c-function gst_lock_flags_get_type gst_lock_flags_get_type  -- u	( -- )
c-function gst_object_flags_get_type gst_object_flags_get_type  -- u	( -- )
c-function gst_pad_direction_get_type gst_pad_direction_get_type  -- u	( -- )
c-function gst_pad_mode_get_type gst_pad_mode_get_type  -- u	( -- )
c-function gst_pad_link_return_get_type gst_pad_link_return_get_type  -- u	( -- )
c-function gst_flow_return_get_type gst_flow_return_get_type  -- u	( -- )
c-function gst_pad_link_check_get_type gst_pad_link_check_get_type  -- u	( -- )
c-function gst_pad_probe_type_get_type gst_pad_probe_type_get_type  -- u	( -- )
c-function gst_pad_probe_return_get_type gst_pad_probe_return_get_type  -- u	( -- )
c-function gst_pad_flags_get_type gst_pad_flags_get_type  -- u	( -- )
c-function gst_pad_presence_get_type gst_pad_presence_get_type  -- u	( -- )
c-function gst_pad_template_flags_get_type gst_pad_template_flags_get_type  -- u	( -- )
c-function gst_parse_error_get_type gst_parse_error_get_type  -- u	( -- )
c-function gst_parse_flags_get_type gst_parse_flags_get_type  -- u	( -- )
c-function gst_pipeline_flags_get_type gst_pipeline_flags_get_type  -- u	( -- )
c-function gst_plugin_error_get_type gst_plugin_error_get_type  -- u	( -- )
c-function gst_plugin_flags_get_type gst_plugin_flags_get_type  -- u	( -- )
c-function gst_plugin_dependency_flags_get_type gst_plugin_dependency_flags_get_type  -- u	( -- )
c-function gst_rank_get_type gst_rank_get_type  -- u	( -- )
c-function gst_promise_result_get_type gst_promise_result_get_type  -- u	( -- )
c-function gst_query_type_flags_get_type gst_query_type_flags_get_type  -- u	( -- )
c-function gst_query_type_get_type gst_query_type_get_type  -- u	( -- )
c-function gst_buffering_mode_get_type gst_buffering_mode_get_type  -- u	( -- )
c-function gst_scheduling_flags_get_type gst_scheduling_flags_get_type  -- u	( -- )
c-function gst_seek_type_get_type gst_seek_type_get_type  -- u	( -- )
c-function gst_seek_flags_get_type gst_seek_flags_get_type  -- u	( -- )
c-function gst_segment_flags_get_type gst_segment_flags_get_type  -- u	( -- )
c-function gst_stream_type_get_type gst_stream_type_get_type  -- u	( -- )
c-function gst_clock_type_get_type gst_clock_type_get_type  -- u	( -- )
c-function gst_tag_merge_mode_get_type gst_tag_merge_mode_get_type  -- u	( -- )
c-function gst_tag_flag_get_type gst_tag_flag_get_type  -- u	( -- )
c-function gst_tag_scope_get_type gst_tag_scope_get_type  -- u	( -- )
c-function gst_task_state_get_type gst_task_state_get_type  -- u	( -- )
c-function gst_toc_scope_get_type gst_toc_scope_get_type  -- u	( -- )
c-function gst_toc_entry_type_get_type gst_toc_entry_type_get_type  -- u	( -- )
c-function gst_toc_loop_type_get_type gst_toc_loop_type_get_type  -- u	( -- )
c-function gst_tracer_value_scope_get_type gst_tracer_value_scope_get_type  -- u	( -- )
c-function gst_tracer_value_flags_get_type gst_tracer_value_flags_get_type  -- u	( -- )
c-function gst_type_find_probability_get_type gst_type_find_probability_get_type  -- u	( -- )
c-function gst_uri_error_get_type gst_uri_error_get_type  -- u	( -- )
c-function gst_uri_type_get_type gst_uri_type_get_type  -- u	( -- )
c-function gst_search_mode_get_type gst_search_mode_get_type  -- u	( -- )
c-function gst_atomic_queue_get_type gst_atomic_queue_get_type  -- u	( -- )
c-function gst_atomic_queue_new gst_atomic_queue_new u -- a	( initial_size -- )
c-function gst_atomic_queue_ref gst_atomic_queue_ref a -- void	( queue -- )
c-function gst_atomic_queue_unref gst_atomic_queue_unref a -- void	( queue -- )
c-function gst_atomic_queue_push gst_atomic_queue_push a a -- void	( queue data -- )
c-function gst_atomic_queue_pop gst_atomic_queue_pop a -- a	( queue -- )
c-function gst_atomic_queue_peek gst_atomic_queue_peek a -- a	( queue -- )
c-function gst_atomic_queue_length gst_atomic_queue_length a -- u	( queue -- )
c-function gst_bin_get_type gst_bin_get_type  -- u	( -- )
c-function gst_bin_new gst_bin_new s -- a	( name -- )
c-function gst_bin_add gst_bin_add a a -- n	( bin element -- )
c-function gst_bin_remove gst_bin_remove a a -- n	( bin element -- )
c-function gst_bin_get_by_name gst_bin_get_by_name a s -- a	( bin name -- )
c-function gst_bin_get_by_name_recurse_up gst_bin_get_by_name_recurse_up a s -- a	( bin name -- )
c-function gst_bin_get_by_interface gst_bin_get_by_interface a u -- a	( bin iface -- )
c-function gst_bin_iterate_elements gst_bin_iterate_elements a -- a	( bin -- )
c-function gst_bin_iterate_sorted gst_bin_iterate_sorted a -- a	( bin -- )
c-function gst_bin_iterate_recurse gst_bin_iterate_recurse a -- a	( bin -- )
c-function gst_bin_iterate_sinks gst_bin_iterate_sinks a -- a	( bin -- )
c-function gst_bin_iterate_sources gst_bin_iterate_sources a -- a	( bin -- )
c-function gst_bin_iterate_all_by_interface gst_bin_iterate_all_by_interface a u -- a	( bin iface -- )
c-function gst_bin_recalculate_latency gst_bin_recalculate_latency a -- n	( bin -- )
c-function gst_bin_set_suppressed_flags gst_bin_set_suppressed_flags a n -- void	( bin flags -- )
c-function gst_bin_get_suppressed_flags gst_bin_get_suppressed_flags a -- n	( bin -- )
c-function gst_buffer_get_type gst_buffer_get_type  -- u	( -- )
c-function gst_buffer_get_max_memory gst_buffer_get_max_memory  -- u	( -- )
c-function gst_buffer_new gst_buffer_new  -- a	( -- )
c-function gst_buffer_new_allocate gst_buffer_new_allocate a u a -- a	( allocator size params -- )
c-function gst_buffer_new_wrapped_full gst_buffer_new_wrapped_full n a u u u a a -- a	( flags data maxsize offset size user_data notify -- )
c-function gst_buffer_new_wrapped gst_buffer_new_wrapped a u -- a	( data size -- )
c-function gst_buffer_new_wrapped_bytes gst_buffer_new_wrapped_bytes a -- a	( bytes -- )
c-function gst_buffer_n_memory gst_buffer_n_memory a -- u	( buffer -- )
c-function gst_buffer_insert_memory gst_buffer_insert_memory a n a -- void	( buffer idx mem -- )
c-function gst_buffer_replace_memory_range gst_buffer_replace_memory_range a u n a -- void	( buffer idx length mem -- )
c-function gst_buffer_peek_memory gst_buffer_peek_memory a u -- a	( buffer idx -- )
c-function gst_buffer_get_memory_range gst_buffer_get_memory_range a u n -- a	( buffer idx length -- )
c-function gst_buffer_remove_memory_range gst_buffer_remove_memory_range a u n -- void	( buffer idx length -- )
c-function gst_buffer_prepend_memory gst_buffer_prepend_memory a a -- void	( buffer mem -- )
c-function gst_buffer_append_memory gst_buffer_append_memory a a -- void	( buffer mem -- )
c-function gst_buffer_replace_memory gst_buffer_replace_memory a u a -- void	( buffer idx mem -- )
c-function gst_buffer_replace_all_memory gst_buffer_replace_all_memory a a -- void	( buffer mem -- )
c-function gst_buffer_get_memory gst_buffer_get_memory a u -- a	( buffer idx -- )
c-function gst_buffer_get_all_memory gst_buffer_get_all_memory a -- a	( buffer -- )
c-function gst_buffer_remove_memory gst_buffer_remove_memory a u -- void	( buffer idx -- )
c-function gst_buffer_remove_all_memory gst_buffer_remove_all_memory a -- void	( buffer -- )
c-function gst_buffer_find_memory gst_buffer_find_memory a u u a a a -- n	( buffer offset size idx length skip -- )
c-function gst_buffer_is_memory_range_writable gst_buffer_is_memory_range_writable a u n -- n	( buffer idx length -- )
c-function gst_buffer_is_all_memory_writable gst_buffer_is_all_memory_writable a -- n	( buffer -- )
c-function gst_buffer_fill gst_buffer_fill a u a u -- u	( buffer offset src size -- )
c-function gst_buffer_extract gst_buffer_extract a u a u -- u	( buffer offset dest size -- )
c-function gst_buffer_memcmp gst_buffer_memcmp a u a u -- n	( buffer offset mem size -- )
c-function gst_buffer_memset gst_buffer_memset a u u u -- u	( buffer offset val size -- )
c-function gst_buffer_get_sizes_range gst_buffer_get_sizes_range a u n a a -- u	( buffer idx length offset maxsize -- )
c-function gst_buffer_resize_range gst_buffer_resize_range a u n n n -- n	( buffer idx length offset size -- )
c-function gst_buffer_get_sizes gst_buffer_get_sizes a a a -- u	( buffer offset maxsize -- )
c-function gst_buffer_get_size gst_buffer_get_size a -- u	( buffer -- )
c-function gst_buffer_resize gst_buffer_resize a n n -- void	( buffer offset size -- )
c-function gst_buffer_set_size gst_buffer_set_size a n -- void	( buffer size -- )
c-function gst_buffer_map_range gst_buffer_map_range a u n a n -- n	( buffer idx length info flags -- )
c-function gst_buffer_map gst_buffer_map a a n -- n	( buffer info flags -- )
c-function gst_buffer_unmap gst_buffer_unmap a a -- void	( buffer info -- )
c-function gst_buffer_extract_dup gst_buffer_extract_dup a u u a a -- void	( buffer offset size dest dest_size -- )
c-function gst_buffer_get_flags gst_buffer_get_flags a -- n	( buffer -- )
c-function gst_buffer_has_flags gst_buffer_has_flags a n -- n	( buffer flags -- )
c-function gst_buffer_set_flags gst_buffer_set_flags a n -- n	( buffer flags -- )
c-function gst_buffer_unset_flags gst_buffer_unset_flags a n -- n	( buffer flags -- )
c-function gst_buffer_ref gst_buffer_ref a -- a	( buf -- )
c-function gst_buffer_unref gst_buffer_unref a -- void	( buf -- )
\ c-function gst_clear_buffer gst_clear_buffer a -- void	( buf_ptr -- )
c-function gst_buffer_copy gst_buffer_copy a -- a	( buf -- )
c-function gst_buffer_copy_deep gst_buffer_copy_deep a -- a	( buf -- )
c-function gst_buffer_copy_into gst_buffer_copy_into a a n u u -- n	( dest src flags offset size -- )
c-function gst_buffer_replace gst_buffer_replace a a -- n	( obuf nbuf -- )
c-function gst_buffer_copy_region gst_buffer_copy_region a n u u -- a	( parent flags offset size -- )
c-function gst_buffer_append_region gst_buffer_append_region a a n n -- a	( buf1 buf2 offset size -- )
c-function gst_buffer_append gst_buffer_append a a -- a	( buf1 buf2 -- )
c-function gst_buffer_get_meta gst_buffer_get_meta a u -- a	( buffer api -- )
c-function gst_buffer_get_n_meta gst_buffer_get_n_meta a u -- u	( buffer api_type -- )
c-function gst_buffer_add_meta gst_buffer_add_meta a a a -- a	( buffer info params -- )
c-function gst_buffer_remove_meta gst_buffer_remove_meta a a -- n	( buffer meta -- )
c-function gst_buffer_iterate_meta gst_buffer_iterate_meta a a -- a	( buffer state -- )
c-function gst_buffer_iterate_meta_filtered gst_buffer_iterate_meta_filtered a a u -- a	( buffer state meta_api_type -- )
c-function gst_buffer_foreach_meta gst_buffer_foreach_meta a a a -- n	( buffer func user_data -- )
c-function gst_parent_buffer_meta_api_get_type gst_parent_buffer_meta_api_get_type  -- u	( -- )
c-function gst_parent_buffer_meta_get_info gst_parent_buffer_meta_get_info  -- a	( -- )
c-function gst_buffer_add_parent_buffer_meta gst_buffer_add_parent_buffer_meta a a -- a	( buffer ref -- )
c-function gst_reference_timestamp_meta_api_get_type gst_reference_timestamp_meta_api_get_type  -- u	( -- )
c-function gst_reference_timestamp_meta_get_info gst_reference_timestamp_meta_get_info  -- a	( -- )
c-function gst_buffer_add_reference_timestamp_meta gst_buffer_add_reference_timestamp_meta a a ud ud -- a	( buffer reference timestamp duration -- )
c-function gst_buffer_get_reference_timestamp_meta gst_buffer_get_reference_timestamp_meta a a -- a	( buffer reference -- )
c-function gst_buffer_list_ref gst_buffer_list_ref a -- a	( list -- )
c-function gst_buffer_list_unref gst_buffer_list_unref a -- void	( list -- )
\ c-function gst_clear_buffer_list gst_clear_buffer_list a -- void	( list_ptr -- )
c-function gst_buffer_list_copy gst_buffer_list_copy a -- a	( list -- )
c-function gst_buffer_list_replace gst_buffer_list_replace a a -- n	( old_list new_list -- )
c-function gst_buffer_list_take gst_buffer_list_take a a -- n	( old_list new_list -- )
c-function gst_buffer_list_get_type gst_buffer_list_get_type  -- u	( -- )
c-function gst_buffer_list_new gst_buffer_list_new  -- a	( -- )
c-function gst_buffer_list_new_sized gst_buffer_list_new_sized u -- a	( size -- )
c-function gst_buffer_list_length gst_buffer_list_length a -- u	( list -- )
c-function gst_buffer_list_get gst_buffer_list_get a u -- a	( list idx -- )
c-function gst_buffer_list_get_writable gst_buffer_list_get_writable a u -- a	( list idx -- )
c-function gst_buffer_list_insert gst_buffer_list_insert a n a -- void	( list idx buffer -- )
c-function gst_buffer_list_remove gst_buffer_list_remove a u u -- void	( list idx length -- )
c-function gst_buffer_list_foreach gst_buffer_list_foreach a a a -- n	( list func user_data -- )
c-function gst_buffer_list_copy_deep gst_buffer_list_copy_deep a -- a	( list -- )
c-function gst_buffer_list_calculate_size gst_buffer_list_calculate_size a -- u	( list -- )
c-function gst_buffer_pool_get_type gst_buffer_pool_get_type  -- u	( -- )
c-function gst_buffer_pool_new gst_buffer_pool_new  -- a	( -- )
c-function gst_buffer_pool_set_active gst_buffer_pool_set_active a n -- n	( pool active -- )
c-function gst_buffer_pool_is_active gst_buffer_pool_is_active a -- n	( pool -- )
c-function gst_buffer_pool_set_config gst_buffer_pool_set_config a a -- n	( pool config -- )
c-function gst_buffer_pool_get_config gst_buffer_pool_get_config a -- a	( pool -- )
c-function gst_buffer_pool_get_options gst_buffer_pool_get_options a -- a	( pool -- )
c-function gst_buffer_pool_has_option gst_buffer_pool_has_option a s -- n	( pool option -- )
c-function gst_buffer_pool_set_flushing gst_buffer_pool_set_flushing a n -- void	( pool flushing -- )
c-function gst_buffer_pool_config_set_params gst_buffer_pool_config_set_params a a u u u -- void	( config caps size min_buffers max_buffers -- )
c-function gst_buffer_pool_config_get_params gst_buffer_pool_config_get_params a a a a a -- n	( config caps size min_buffers max_buffers -- )
c-function gst_buffer_pool_config_set_allocator gst_buffer_pool_config_set_allocator a a a -- void	( config allocator params -- )
c-function gst_buffer_pool_config_get_allocator gst_buffer_pool_config_get_allocator a a a -- n	( config allocator params -- )
c-function gst_buffer_pool_config_n_options gst_buffer_pool_config_n_options a -- u	( config -- )
c-function gst_buffer_pool_config_add_option gst_buffer_pool_config_add_option a s -- void	( config option -- )
c-function gst_buffer_pool_config_get_option gst_buffer_pool_config_get_option a u -- s	( config index -- )
c-function gst_buffer_pool_config_has_option gst_buffer_pool_config_has_option a s -- n	( config option -- )
c-function gst_buffer_pool_config_validate_params gst_buffer_pool_config_validate_params a a u u u -- n	( config caps size min_buffers max_buffers -- )
c-function gst_buffer_pool_acquire_buffer gst_buffer_pool_acquire_buffer a a a -- n	( pool buffer params -- )
c-function gst_buffer_pool_release_buffer gst_buffer_pool_release_buffer a a -- void	( pool buffer -- )
c-function gst_bus_get_type gst_bus_get_type  -- u	( -- )
c-function gst_bus_new gst_bus_new  -- a	( -- )
c-function gst_bus_post gst_bus_post a a -- n	( bus message -- )
c-function gst_bus_have_pending gst_bus_have_pending a -- n	( bus -- )
c-function gst_bus_peek gst_bus_peek a -- a	( bus -- )
c-function gst_bus_pop gst_bus_pop a -- a	( bus -- )
c-function gst_bus_pop_filtered gst_bus_pop_filtered a n -- a	( bus types -- )
c-function gst_bus_timed_pop gst_bus_timed_pop a ud -- a	( bus timeout -- )
c-function gst_bus_timed_pop_filtered gst_bus_timed_pop_filtered a ud n -- a	( bus timeout types -- )
c-function gst_bus_set_flushing gst_bus_set_flushing a n -- void	( bus flushing -- )
c-function gst_bus_set_sync_handler gst_bus_set_sync_handler a a a a -- void	( bus func user_data notify -- )
c-function gst_bus_get_pollfd gst_bus_get_pollfd a a -- void	( bus fd -- )
c-function gst_bus_create_watch gst_bus_create_watch a -- a	( bus -- )
c-function gst_bus_add_watch_full gst_bus_add_watch_full a n a a a -- u	( bus priority func user_data notify -- )
c-function gst_bus_add_watch gst_bus_add_watch a a a -- u	( bus func user_data -- )
c-function gst_bus_remove_watch gst_bus_remove_watch a -- n	( bus -- )
c-function gst_bus_poll gst_bus_poll a n ud -- a	( bus events timeout -- )
c-function gst_bus_async_signal_func gst_bus_async_signal_func a a a -- n	( bus message data -- )
c-function gst_bus_sync_signal_handler gst_bus_sync_signal_handler a a a -- n	( bus message data -- )
c-function gst_bus_add_signal_watch gst_bus_add_signal_watch a -- void	( bus -- )
c-function gst_bus_add_signal_watch_full gst_bus_add_signal_watch_full a n -- void	( bus priority -- )
c-function gst_bus_remove_signal_watch gst_bus_remove_signal_watch a -- void	( bus -- )
c-function gst_bus_enable_sync_message_emission gst_bus_enable_sync_message_emission a -- void	( bus -- )
c-function gst_bus_disable_sync_message_emission gst_bus_disable_sync_message_emission a -- void	( bus -- )
c-function gst_caps_ref gst_caps_ref a -- a	( caps -- )
c-function gst_caps_unref gst_caps_unref a -- void	( caps -- )
\ c-function gst_clear_caps gst_clear_caps a -- void	( caps_ptr -- )
c-function gst_caps_copy gst_caps_copy a -- a	( caps -- )
c-function gst_caps_replace gst_caps_replace a a -- n	( old_caps new_caps -- )
c-function gst_caps_take gst_caps_take a a -- n	( old_caps new_caps -- )
c-function gst_caps_get_type gst_caps_get_type  -- u	( -- )
c-function gst_caps_new_empty gst_caps_new_empty  -- a	( -- )
c-function gst_caps_new_any gst_caps_new_any  -- a	( -- )
c-function gst_caps_new_empty_simple gst_caps_new_empty_simple s -- a	( media_type -- )
c-function gst_caps_new_simple gst_caps_new_simple s s ... -- a	( media_type fieldname <noname> -- )
c-function gst_caps_new_full gst_caps_new_full a ... -- a	( struct1 <noname> -- )
\ c-function gst_caps_new_full_valist gst_caps_new_full_valist a a -- a	( structure var_args -- )
c-function gst_static_caps_get_type gst_static_caps_get_type  -- u	( -- )
c-function gst_static_caps_get gst_static_caps_get a -- a	( static_caps -- )
c-function gst_static_caps_cleanup gst_static_caps_cleanup a -- void	( static_caps -- )
c-function gst_caps_append gst_caps_append a a -- void	( caps1 caps2 -- )
c-function gst_caps_append_structure gst_caps_append_structure a a -- void	( caps structure -- )
c-function gst_caps_append_structure_full gst_caps_append_structure_full a a a -- void	( caps structure features -- )
c-function gst_caps_remove_structure gst_caps_remove_structure a u -- void	( caps idx -- )
c-function gst_caps_merge gst_caps_merge a a -- a	( caps1 caps2 -- )
c-function gst_caps_merge_structure gst_caps_merge_structure a a -- a	( caps structure -- )
c-function gst_caps_merge_structure_full gst_caps_merge_structure_full a a a -- a	( caps structure features -- )
c-function gst_caps_get_size gst_caps_get_size a -- u	( caps -- )
c-function gst_caps_get_structure gst_caps_get_structure a u -- a	( caps index -- )
c-function gst_caps_steal_structure gst_caps_steal_structure a u -- a	( caps index -- )
c-function gst_caps_set_features gst_caps_set_features a u a -- void	( caps index features -- )
c-function gst_caps_set_features_simple gst_caps_set_features_simple a a -- void	( caps features -- )
c-function gst_caps_get_features gst_caps_get_features a u -- a	( caps index -- )
c-function gst_caps_copy_nth gst_caps_copy_nth a u -- a	( caps nth -- )
c-function gst_caps_truncate gst_caps_truncate a -- a	( caps -- )
c-function gst_caps_set_value gst_caps_set_value a s a -- void	( caps field value -- )
c-function gst_caps_set_simple gst_caps_set_simple a s ... -- void	( caps field <noname> -- )
\ c-function gst_caps_set_simple_valist gst_caps_set_simple_valist a s a -- void	( caps field varargs -- )
c-function gst_caps_foreach gst_caps_foreach a a a -- n	( caps func user_data -- )
c-function gst_caps_map_in_place gst_caps_map_in_place a a a -- n	( caps func user_data -- )
c-function gst_caps_filter_and_map_in_place gst_caps_filter_and_map_in_place a a a -- void	( caps func user_data -- )
c-function gst_caps_is_any gst_caps_is_any a -- n	( caps -- )
c-function gst_caps_is_empty gst_caps_is_empty a -- n	( caps -- )
c-function gst_caps_is_fixed gst_caps_is_fixed a -- n	( caps -- )
c-function gst_caps_is_always_compatible gst_caps_is_always_compatible a a -- n	( caps1 caps2 -- )
c-function gst_caps_is_subset gst_caps_is_subset a a -- n	( subset superset -- )
c-function gst_caps_is_subset_structure gst_caps_is_subset_structure a a -- n	( caps structure -- )
c-function gst_caps_is_subset_structure_full gst_caps_is_subset_structure_full a a a -- n	( caps structure features -- )
c-function gst_caps_is_equal gst_caps_is_equal a a -- n	( caps1 caps2 -- )
c-function gst_caps_is_equal_fixed gst_caps_is_equal_fixed a a -- n	( caps1 caps2 -- )
c-function gst_caps_can_intersect gst_caps_can_intersect a a -- n	( caps1 caps2 -- )
c-function gst_caps_is_strictly_equal gst_caps_is_strictly_equal a a -- n	( caps1 caps2 -- )
c-function gst_caps_intersect gst_caps_intersect a a -- a	( caps1 caps2 -- )
c-function gst_caps_intersect_full gst_caps_intersect_full a a n -- a	( caps1 caps2 mode -- )
c-function gst_caps_subtract gst_caps_subtract a a -- a	( minuend subtrahend -- )
c-function gst_caps_normalize gst_caps_normalize a -- a	( caps -- )
c-function gst_caps_simplify gst_caps_simplify a -- a	( caps -- )
c-function gst_caps_fixate gst_caps_fixate a -- a	( caps -- )
c-function gst_caps_to_string gst_caps_to_string a -- a	( caps -- )
c-function gst_caps_from_string gst_caps_from_string s -- a	( string -- )
c-function gst_caps_features_get_type gst_caps_features_get_type  -- u	( -- )
c-function gst_is_caps_features gst_is_caps_features a -- n	( obj -- )
c-function gst_caps_features_new_empty gst_caps_features_new_empty  -- a	( -- )
c-function gst_caps_features_new_any gst_caps_features_new_any  -- a	( -- )
c-function gst_caps_features_new gst_caps_features_new s ... -- a	( feature1 <noname> -- )
\ c-function gst_caps_features_new_valist gst_caps_features_new_valist s a -- a	( feature1 varargs -- )
c-function gst_caps_features_new_id gst_caps_features_new_id n ... -- a	( feature1 <noname> -- )
\ c-function gst_caps_features_new_id_valist gst_caps_features_new_id_valist n a -- a	( feature1 varargs -- )
c-function gst_caps_features_set_parent_refcount gst_caps_features_set_parent_refcount a a -- n	( features refcount -- )
c-function gst_caps_features_copy gst_caps_features_copy a -- a	( features -- )
c-function gst_caps_features_free gst_caps_features_free a -- void	( features -- )
c-function gst_caps_features_to_string gst_caps_features_to_string a -- a	( features -- )
c-function gst_caps_features_from_string gst_caps_features_from_string s -- a	( features -- )
c-function gst_caps_features_get_size gst_caps_features_get_size a -- u	( features -- )
c-function gst_caps_features_get_nth gst_caps_features_get_nth a u -- s	( features i -- )
c-function gst_caps_features_get_nth_id gst_caps_features_get_nth_id a u -- n	( features i -- )
c-function gst_caps_features_contains gst_caps_features_contains a s -- n	( features feature -- )
c-function gst_caps_features_contains_id gst_caps_features_contains_id a n -- n	( features feature -- )
c-function gst_caps_features_is_equal gst_caps_features_is_equal a a -- n	( features1 features2 -- )
c-function gst_caps_features_is_any gst_caps_features_is_any a -- n	( features -- )
c-function gst_caps_features_add gst_caps_features_add a s -- void	( features feature -- )
c-function gst_caps_features_add_id gst_caps_features_add_id a n -- void	( features feature -- )
c-function gst_caps_features_remove gst_caps_features_remove a s -- void	( features feature -- )
c-function gst_caps_features_remove_id gst_caps_features_remove_id a n -- void	( features feature -- )
c-function gst_child_proxy_get_type gst_child_proxy_get_type  -- u	( -- )
c-function gst_child_proxy_get_child_by_name gst_child_proxy_get_child_by_name a s -- a	( parent name -- )
c-function gst_child_proxy_get_children_count gst_child_proxy_get_children_count a -- u	( parent -- )
c-function gst_child_proxy_get_child_by_index gst_child_proxy_get_child_by_index a u -- a	( parent index -- )
c-function gst_child_proxy_lookup gst_child_proxy_lookup a s a a -- n	( object name target pspec -- )
c-function gst_child_proxy_get_property gst_child_proxy_get_property a s a -- void	( object name value -- )
\ c-function gst_child_proxy_get_valist gst_child_proxy_get_valist a s a -- void	( object first_property_name var_args -- )
c-function gst_child_proxy_get gst_child_proxy_get a s ... -- void	( object first_property_name <noname> -- )
c-function gst_child_proxy_set_property gst_child_proxy_set_property a s a -- void	( object name value -- )
\ c-function gst_child_proxy_set_valist gst_child_proxy_set_valist a s a -- void	( object first_property_name var_args -- )
c-function gst_child_proxy_set gst_child_proxy_set a s ... -- void	( object first_property_name <noname> -- )
c-function gst_child_proxy_child_added gst_child_proxy_child_added a a s -- void	( parent child name -- )
c-function gst_child_proxy_child_removed gst_child_proxy_child_removed a a s -- void	( parent child name -- )
c-function gst_clock_get_type gst_clock_get_type  -- u	( -- )
c-function gst_clock_set_resolution gst_clock_set_resolution a ud -- ud	( clock resolution -- )
c-function gst_clock_get_resolution gst_clock_get_resolution a -- ud	( clock -- )
c-function gst_clock_get_time gst_clock_get_time a -- ud	( clock -- )
c-function gst_clock_set_calibration gst_clock_set_calibration a ud ud ud ud -- void	( clock internal external rate_num rate_denom -- )
c-function gst_clock_get_calibration gst_clock_get_calibration a a a a a -- void	( clock internal external rate_num rate_denom -- )
c-function gst_clock_set_master gst_clock_set_master a a -- n	( clock master -- )
c-function gst_clock_get_master gst_clock_get_master a -- a	( clock -- )
c-function gst_clock_set_timeout gst_clock_set_timeout a ud -- void	( clock timeout -- )
c-function gst_clock_get_timeout gst_clock_get_timeout a -- ud	( clock -- )
c-function gst_clock_add_observation gst_clock_add_observation a ud ud a -- n	( clock slave master r_squared -- )
c-function gst_clock_add_observation_unapplied gst_clock_add_observation_unapplied a ud ud a a a a a -- n	( clock slave master r_squared internal external rate_num rate_denom -- )
c-function gst_clock_get_internal_time gst_clock_get_internal_time a -- ud	( clock -- )
c-function gst_clock_adjust_unlocked gst_clock_adjust_unlocked a ud -- ud	( clock internal -- )
c-function gst_clock_adjust_with_calibration gst_clock_adjust_with_calibration a ud ud ud ud ud -- ud	( clock internal_target cinternal cexternal cnum cdenom -- )
c-function gst_clock_unadjust_with_calibration gst_clock_unadjust_with_calibration a ud ud ud ud ud -- ud	( clock external_target cinternal cexternal cnum cdenom -- )
c-function gst_clock_unadjust_unlocked gst_clock_unadjust_unlocked a ud -- ud	( clock external -- )
c-function gst_clock_wait_for_sync gst_clock_wait_for_sync a ud -- n	( clock timeout -- )
c-function gst_clock_is_synced gst_clock_is_synced a -- n	( clock -- )
c-function gst_clock_set_synced gst_clock_set_synced a n -- void	( clock synced -- )
c-function gst_clock_new_single_shot_id gst_clock_new_single_shot_id a ud -- a	( clock time -- )
c-function gst_clock_new_periodic_id gst_clock_new_periodic_id a ud ud -- a	( clock start_time interval -- )
c-function gst_clock_id_ref gst_clock_id_ref a -- a	( id -- )
c-function gst_clock_id_unref gst_clock_id_unref a -- void	( id -- )
c-function gst_clock_id_compare_func gst_clock_id_compare_func a a -- n	( id1 id2 -- )
c-function gst_clock_id_get_clock gst_clock_id_get_clock a -- a	( id -- )
c-function gst_clock_id_uses_clock gst_clock_id_uses_clock a a -- n	( id clock -- )
c-function gst_clock_id_get_time gst_clock_id_get_time a -- ud	( id -- )
c-function gst_clock_id_wait gst_clock_id_wait a a -- n	( id jitter -- )
c-function gst_clock_id_wait_async gst_clock_id_wait_async a a a a -- n	( id func user_data destroy_data -- )
c-function gst_clock_id_unschedule gst_clock_id_unschedule a -- void	( id -- )
c-function gst_clock_single_shot_id_reinit gst_clock_single_shot_id_reinit a a ud -- n	( clock id time -- )
c-function gst_clock_periodic_id_reinit gst_clock_periodic_id_reinit a a ud ud -- n	( clock id start_time interval -- )
c-function gst_control_source_get_type gst_control_source_get_type  -- u	( -- )
c-function gst_control_source_get_value gst_control_source_get_value a ud a -- n	( self timestamp value -- )
c-function gst_control_source_get_value_array gst_control_source_get_value_array a ud ud u a -- n	( self timestamp interval n_values values -- )
c-function gst_date_time_get_type gst_date_time_get_type  -- u	( -- )
c-function gst_date_time_has_year gst_date_time_has_year a -- n	( datetime -- )
c-function gst_date_time_has_month gst_date_time_has_month a -- n	( datetime -- )
c-function gst_date_time_has_day gst_date_time_has_day a -- n	( datetime -- )
c-function gst_date_time_has_time gst_date_time_has_time a -- n	( datetime -- )
c-function gst_date_time_has_second gst_date_time_has_second a -- n	( datetime -- )
c-function gst_date_time_get_year gst_date_time_get_year a -- n	( datetime -- )
c-function gst_date_time_get_month gst_date_time_get_month a -- n	( datetime -- )
c-function gst_date_time_get_day gst_date_time_get_day a -- n	( datetime -- )
c-function gst_date_time_get_hour gst_date_time_get_hour a -- n	( datetime -- )
c-function gst_date_time_get_minute gst_date_time_get_minute a -- n	( datetime -- )
c-function gst_date_time_get_second gst_date_time_get_second a -- n	( datetime -- )
c-function gst_date_time_get_microsecond gst_date_time_get_microsecond a -- n	( datetime -- )
c-function gst_date_time_get_time_zone_offset gst_date_time_get_time_zone_offset a -- r	( datetime -- )
c-function gst_date_time_new_from_unix_epoch_local_time gst_date_time_new_from_unix_epoch_local_time d -- a	( secs -- )
c-function gst_date_time_new_from_unix_epoch_utc gst_date_time_new_from_unix_epoch_utc d -- a	( secs -- )
c-function gst_date_time_new_local_time gst_date_time_new_local_time n n n n n r -- a	( year month day hour minute seconds -- )
c-function gst_date_time_new_y gst_date_time_new_y n -- a	( year -- )
c-function gst_date_time_new_ym gst_date_time_new_ym n n -- a	( year month -- )
c-function gst_date_time_new_ymd gst_date_time_new_ymd n n n -- a	( year month day -- )
c-function gst_date_time_new gst_date_time_new r n n n n n r -- a	( tzoffset year month day hour minute seconds -- )
c-function gst_date_time_new_now_local_time gst_date_time_new_now_local_time  -- a	( -- )
c-function gst_date_time_new_now_utc gst_date_time_new_now_utc  -- a	( -- )
c-function gst_date_time_to_iso8601_string gst_date_time_to_iso8601_string a -- a	( datetime -- )
c-function gst_date_time_new_from_iso8601_string gst_date_time_new_from_iso8601_string s -- a	( string -- )
c-function gst_date_time_to_g_date_time gst_date_time_to_g_date_time a -- a	( datetime -- )
c-function gst_date_time_new_from_g_date_time gst_date_time_new_from_g_date_time a -- a	( dt -- )
c-function gst_date_time_ref gst_date_time_ref a -- a	( datetime -- )
c-function gst_date_time_unref gst_date_time_unref a -- void	( datetime -- )
c-function gst_debug_bin_to_dot_data gst_debug_bin_to_dot_data a n -- a	( bin details -- )
c-function gst_debug_bin_to_dot_file gst_debug_bin_to_dot_file a n s -- void	( bin details file_name -- )
c-function gst_debug_bin_to_dot_file_with_ts gst_debug_bin_to_dot_file_with_ts a n s -- void	( bin details file_name -- )
c-function gst_device_get_type gst_device_get_type  -- u	( -- )
c-function gst_device_create_element gst_device_create_element a s -- a	( device name -- )
c-function gst_device_get_caps gst_device_get_caps a -- a	( device -- )
c-function gst_device_get_display_name gst_device_get_display_name a -- a	( device -- )
c-function gst_device_get_device_class gst_device_get_device_class a -- a	( device -- )
c-function gst_device_get_properties gst_device_get_properties a -- a	( device -- )
c-function gst_device_reconfigure_element gst_device_reconfigure_element a a -- n	( device element -- )
c-function gst_device_has_classesv gst_device_has_classesv a a -- n	( device classes -- )
c-function gst_device_has_classes gst_device_has_classes a s -- n	( device classes -- )
c-function gst_device_monitor_get_type gst_device_monitor_get_type  -- u	( -- )
c-function gst_device_monitor_new gst_device_monitor_new  -- a	( -- )
c-function gst_device_monitor_get_bus gst_device_monitor_get_bus a -- a	( monitor -- )
c-function gst_device_monitor_get_devices gst_device_monitor_get_devices a -- a	( monitor -- )
c-function gst_device_monitor_start gst_device_monitor_start a -- n	( monitor -- )
c-function gst_device_monitor_stop gst_device_monitor_stop a -- void	( monitor -- )
c-function gst_device_monitor_add_filter gst_device_monitor_add_filter a s a -- u	( monitor classes caps -- )
c-function gst_device_monitor_remove_filter gst_device_monitor_remove_filter a u -- n	( monitor filter_id -- )
c-function gst_device_monitor_get_providers gst_device_monitor_get_providers a -- a	( monitor -- )
c-function gst_device_monitor_set_show_all_devices gst_device_monitor_set_show_all_devices a n -- void	( monitor show_all -- )
c-function gst_device_monitor_get_show_all_devices gst_device_monitor_get_show_all_devices a -- n	( monitor -- )
c-function gst_device_provider_get_type gst_device_provider_get_type  -- u	( -- )
c-function gst_device_provider_get_devices gst_device_provider_get_devices a -- a	( provider -- )
c-function gst_device_provider_start gst_device_provider_start a -- n	( provider -- )
c-function gst_device_provider_stop gst_device_provider_stop a -- void	( provider -- )
c-function gst_device_provider_can_monitor gst_device_provider_can_monitor a -- n	( provider -- )
c-function gst_device_provider_get_bus gst_device_provider_get_bus a -- a	( provider -- )
c-function gst_device_provider_device_add gst_device_provider_device_add a a -- void	( provider device -- )
c-function gst_device_provider_device_remove gst_device_provider_device_remove a a -- void	( provider device -- )
c-function gst_device_provider_get_hidden_providers gst_device_provider_get_hidden_providers a -- a	( provider -- )
c-function gst_device_provider_hide_provider gst_device_provider_hide_provider a s -- void	( provider name -- )
c-function gst_device_provider_unhide_provider gst_device_provider_unhide_provider a s -- void	( provider name -- )
c-function gst_device_provider_get_metadata gst_device_provider_get_metadata a s -- s	( provider key -- )
c-function gst_device_provider_class_set_metadata gst_device_provider_class_set_metadata a s s s s -- void	( klass longname classification description author -- )
c-function gst_device_provider_class_set_static_metadata gst_device_provider_class_set_static_metadata a s s s s -- void	( klass longname classification description author -- )
c-function gst_device_provider_class_add_metadata gst_device_provider_class_add_metadata a s s -- void	( klass key value -- )
c-function gst_device_provider_class_add_static_metadata gst_device_provider_class_add_static_metadata a s s -- void	( klass key value -- )
c-function gst_device_provider_class_get_metadata gst_device_provider_class_get_metadata a s -- s	( klass key -- )
c-function gst_device_provider_device_changed gst_device_provider_device_changed a a a -- void	( provider device changed_device -- )
c-function gst_device_provider_get_factory gst_device_provider_get_factory a -- a	( provider -- )
c-function gst_make_element_message_details gst_make_element_message_details s ... -- a	( name <noname> -- )
c-function gst_element_class_add_pad_template gst_element_class_add_pad_template a a -- void	( klass templ -- )
c-function gst_element_class_add_static_pad_template gst_element_class_add_static_pad_template a a -- void	( klass static_templ -- )
c-function gst_element_class_add_static_pad_template_with_gtype gst_element_class_add_static_pad_template_with_gtype a a u -- void	( klass static_templ pad_type -- )
c-function gst_element_class_get_pad_template gst_element_class_get_pad_template a s -- a	( element_class name -- )
c-function gst_element_class_get_pad_template_list gst_element_class_get_pad_template_list a -- a	( element_class -- )
c-function gst_element_class_set_metadata gst_element_class_set_metadata a s s s s -- void	( klass longname classification description author -- )
c-function gst_element_class_set_static_metadata gst_element_class_set_static_metadata a s s s s -- void	( klass longname classification description author -- )
c-function gst_element_class_add_metadata gst_element_class_add_metadata a s s -- void	( klass key value -- )
c-function gst_element_class_add_static_metadata gst_element_class_add_static_metadata a s s -- void	( klass key value -- )
c-function gst_element_class_get_metadata gst_element_class_get_metadata a s -- s	( klass key -- )
c-function gst_element_get_type gst_element_get_type  -- u	( -- )
c-function gst_element_provide_clock gst_element_provide_clock a -- a	( element -- )
c-function gst_element_get_clock gst_element_get_clock a -- a	( element -- )
c-function gst_element_set_clock gst_element_set_clock a a -- n	( element clock -- )
c-function gst_element_set_base_time gst_element_set_base_time a ud -- void	( element time -- )
c-function gst_element_get_base_time gst_element_get_base_time a -- ud	( element -- )
c-function gst_element_set_start_time gst_element_set_start_time a ud -- void	( element time -- )
c-function gst_element_get_start_time gst_element_get_start_time a -- ud	( element -- )
c-function gst_element_set_bus gst_element_set_bus a a -- void	( element bus -- )
c-function gst_element_get_bus gst_element_get_bus a -- a	( element -- )
c-function gst_element_set_context gst_element_set_context a a -- void	( element context -- )
c-function gst_element_get_contexts gst_element_get_contexts a -- a	( element -- )
c-function gst_element_get_context gst_element_get_context a s -- a	( element context_type -- )
c-function gst_element_get_context_unlocked gst_element_get_context_unlocked a s -- a	( element context_type -- )
c-function gst_element_add_pad gst_element_add_pad a a -- n	( element pad -- )
c-function gst_element_remove_pad gst_element_remove_pad a a -- n	( element pad -- )
c-function gst_element_no_more_pads gst_element_no_more_pads a -- void	( element -- )
c-function gst_element_get_static_pad gst_element_get_static_pad a s -- a	( element name -- )
c-function gst_element_get_request_pad gst_element_get_request_pad a s -- a	( element name -- )
c-function gst_element_request_pad gst_element_request_pad a a s a -- a	( element templ name caps -- )
c-function gst_element_release_request_pad gst_element_release_request_pad a a -- void	( element pad -- )
c-function gst_element_iterate_pads gst_element_iterate_pads a -- a	( element -- )
c-function gst_element_iterate_src_pads gst_element_iterate_src_pads a -- a	( element -- )
c-function gst_element_iterate_sink_pads gst_element_iterate_sink_pads a -- a	( element -- )
c-function gst_element_foreach_sink_pad gst_element_foreach_sink_pad a a a -- n	( element func user_data -- )
c-function gst_element_foreach_src_pad gst_element_foreach_src_pad a a a -- n	( element func user_data -- )
c-function gst_element_foreach_pad gst_element_foreach_pad a a a -- n	( element func user_data -- )
c-function gst_element_send_event gst_element_send_event a a -- n	( element event -- )
c-function gst_element_seek gst_element_seek a r u n n d n d -- n	( element rate format flags start_type start stop_type stop -- )
c-function gst_element_query gst_element_query a a -- n	( element query -- )
c-function gst_element_post_message gst_element_post_message a a -- n	( element message -- )
c-function _gst_element_error_printf _gst_element_error_printf s ... -- a	( format <noname> -- )
c-function gst_element_message_full gst_element_message_full a n n n a a s s n -- void	( element type domain code text debug file function line -- )
c-function gst_element_message_full_with_details gst_element_message_full_with_details a n n n a a s s n a -- void	( element type domain code text debug file function line structure -- )
c-function gst_element_is_locked_state gst_element_is_locked_state a -- n	( element -- )
c-function gst_element_set_locked_state gst_element_set_locked_state a n -- n	( element locked_state -- )
c-function gst_element_sync_state_with_parent gst_element_sync_state_with_parent a -- n	( element -- )
c-function gst_element_get_state gst_element_get_state a a a ud -- n	( element state pending timeout -- )
c-function gst_element_set_state gst_element_set_state a n -- n	( element state -- )
c-function gst_element_abort_state gst_element_abort_state a -- void	( element -- )
c-function gst_element_change_state gst_element_change_state a n -- n	( element transition -- )
c-function gst_element_continue_state gst_element_continue_state a n -- n	( element ret -- )
c-function gst_element_lost_state gst_element_lost_state a -- void	( element -- )
c-function gst_element_call_async gst_element_call_async a a a a -- void	( element func user_data destroy_notify -- )
c-function gst_element_get_factory gst_element_get_factory a -- a	( element -- )
c-function gst_element_add_property_notify_watch gst_element_add_property_notify_watch a s n -- n	( element property_name include_value -- )
c-function gst_element_add_property_deep_notify_watch gst_element_add_property_deep_notify_watch a s n -- n	( element property_name include_value -- )
c-function gst_element_remove_property_notify_watch gst_element_remove_property_notify_watch a n -- void	( element watch_id -- )
c-function gst_element_get_pad_template gst_element_get_pad_template a s -- a	( element name -- )
c-function gst_element_get_pad_template_list gst_element_get_pad_template_list a -- a	( element -- )
c-function gst_element_get_metadata gst_element_get_metadata a s -- s	( element key -- )
c-function gst_error_get_message gst_error_get_message n n -- a	( domain code -- )
c-function gst_stream_error_quark gst_stream_error_quark  -- n	( -- )
c-function gst_core_error_quark gst_core_error_quark  -- n	( -- )
c-function gst_resource_error_quark gst_resource_error_quark  -- n	( -- )
c-function gst_library_error_quark gst_library_error_quark  -- n	( -- )
c-function gst_event_replace gst_event_replace a a -- n	( old_event new_event -- )
c-function gst_event_steal gst_event_steal a -- a	( old_event -- )
c-function gst_event_take gst_event_take a a -- n	( old_event new_event -- )
c-function gst_event_type_get_name gst_event_type_get_name n -- s	( type -- )
c-function gst_event_type_to_quark gst_event_type_to_quark n -- n	( type -- )
c-function gst_event_type_get_flags gst_event_type_get_flags n -- n	( type -- )
c-function gst_event_ref gst_event_ref a -- a	( event -- )
c-function gst_event_unref gst_event_unref a -- void	( event -- )
\ c-function gst_clear_event gst_clear_event a -- void	( event_ptr -- )
c-function gst_event_copy gst_event_copy a -- a	( event -- )
c-function gst_event_get_type gst_event_get_type  -- u	( -- )
c-function gst_event_new_custom gst_event_new_custom n a -- a	( type structure -- )
c-function gst_event_get_structure gst_event_get_structure a -- a	( event -- )
c-function gst_event_writable_structure gst_event_writable_structure a -- a	( event -- )
c-function gst_event_has_name gst_event_has_name a s -- n	( event name -- )
c-function gst_event_get_seqnum gst_event_get_seqnum a -- u	( event -- )
c-function gst_event_set_seqnum gst_event_set_seqnum a u -- void	( event seqnum -- )
c-function gst_event_get_running_time_offset gst_event_get_running_time_offset a -- d	( event -- )
c-function gst_event_set_running_time_offset gst_event_set_running_time_offset a d -- void	( event offset -- )
c-function gst_event_new_stream_start gst_event_new_stream_start s -- a	( stream_id -- )
c-function gst_event_parse_stream_start gst_event_parse_stream_start a a -- void	( event stream_id -- )
c-function gst_event_set_stream gst_event_set_stream a a -- void	( event stream -- )
c-function gst_event_parse_stream gst_event_parse_stream a a -- void	( event stream -- )
c-function gst_event_set_stream_flags gst_event_set_stream_flags a n -- void	( event flags -- )
c-function gst_event_parse_stream_flags gst_event_parse_stream_flags a a -- void	( event flags -- )
c-function gst_event_set_group_id gst_event_set_group_id a u -- void	( event group_id -- )
c-function gst_event_parse_group_id gst_event_parse_group_id a a -- n	( event group_id -- )
c-function gst_event_new_flush_start gst_event_new_flush_start  -- a	( -- )
c-function gst_event_new_flush_stop gst_event_new_flush_stop n -- a	( reset_time -- )
c-function gst_event_parse_flush_stop gst_event_parse_flush_stop a a -- void	( event reset_time -- )
c-function gst_event_new_stream_collection gst_event_new_stream_collection a -- a	( collection -- )
c-function gst_event_parse_stream_collection gst_event_parse_stream_collection a a -- void	( event collection -- )
c-function gst_event_new_select_streams gst_event_new_select_streams a -- a	( streams -- )
c-function gst_event_parse_select_streams gst_event_parse_select_streams a a -- void	( event streams -- )
c-function gst_event_new_stream_group_done gst_event_new_stream_group_done u -- a	( group_id -- )
c-function gst_event_parse_stream_group_done gst_event_parse_stream_group_done a a -- void	( event group_id -- )
c-function gst_event_new_eos gst_event_new_eos  -- a	( -- )
c-function gst_event_new_gap gst_event_new_gap ud ud -- a	( timestamp duration -- )
c-function gst_event_parse_gap gst_event_parse_gap a a a -- void	( event timestamp duration -- )
c-function gst_event_new_caps gst_event_new_caps a -- a	( caps -- )
c-function gst_event_parse_caps gst_event_parse_caps a a -- void	( event caps -- )
c-function gst_event_new_segment gst_event_new_segment a -- a	( segment -- )
c-function gst_event_parse_segment gst_event_parse_segment a a -- void	( event segment -- )
c-function gst_event_copy_segment gst_event_copy_segment a a -- void	( event segment -- )
c-function gst_event_new_tag gst_event_new_tag a -- a	( taglist -- )
c-function gst_event_parse_tag gst_event_parse_tag a a -- void	( event taglist -- )
c-function gst_event_new_toc gst_event_new_toc a n -- a	( toc updated -- )
c-function gst_event_parse_toc gst_event_parse_toc a a a -- void	( event toc updated -- )
c-function gst_event_new_protection gst_event_new_protection s a s -- a	( system_id data origin -- )
c-function gst_event_parse_protection gst_event_parse_protection a a a a -- void	( event system_id data origin -- )
c-function gst_event_new_buffer_size gst_event_new_buffer_size u d d n -- a	( format minsize maxsize async -- )
c-function gst_event_parse_buffer_size gst_event_parse_buffer_size a a a a a -- void	( event format minsize maxsize async -- )
c-function gst_event_new_sink_message gst_event_new_sink_message s a -- a	( name msg -- )
c-function gst_event_parse_sink_message gst_event_parse_sink_message a a -- void	( event msg -- )
c-function gst_event_new_qos gst_event_new_qos n r d ud -- a	( type proportion diff timestamp -- )
c-function gst_event_parse_qos gst_event_parse_qos a a a a a -- void	( event type proportion diff timestamp -- )
c-function gst_event_new_seek gst_event_new_seek r u n n d n d -- a	( rate format flags start_type start stop_type stop -- )
c-function gst_event_parse_seek gst_event_parse_seek a a a a a a a a -- void	( event rate format flags start_type start stop_type stop -- )
c-function gst_event_set_seek_trickmode_interval gst_event_set_seek_trickmode_interval a ud -- void	( event interval -- )
c-function gst_event_parse_seek_trickmode_interval gst_event_parse_seek_trickmode_interval a a -- void	( event interval -- )
c-function gst_event_new_navigation gst_event_new_navigation a -- a	( structure -- )
c-function gst_event_new_latency gst_event_new_latency ud -- a	( latency -- )
c-function gst_event_parse_latency gst_event_parse_latency a a -- void	( event latency -- )
c-function gst_event_new_step gst_event_new_step u ud r n n -- a	( format amount rate flush intermediate -- )
c-function gst_event_parse_step gst_event_parse_step a a a a a a -- void	( event format amount rate flush intermediate -- )
c-function gst_event_new_reconfigure gst_event_new_reconfigure  -- a	( -- )
c-function gst_event_new_toc_select gst_event_new_toc_select s -- a	( uid -- )
c-function gst_event_parse_toc_select gst_event_parse_toc_select a a -- void	( event uid -- )
c-function gst_event_new_segment_done gst_event_new_segment_done u d -- a	( format position -- )
c-function gst_event_parse_segment_done gst_event_parse_segment_done a a a -- void	( event format position -- )
c-function gst_proxy_pad_get_type gst_proxy_pad_get_type  -- u	( -- )
c-function gst_proxy_pad_get_internal gst_proxy_pad_get_internal a -- a	( pad -- )
c-function gst_proxy_pad_iterate_internal_links_default gst_proxy_pad_iterate_internal_links_default a a -- a	( pad parent -- )
c-function gst_proxy_pad_chain_default gst_proxy_pad_chain_default a a a -- n	( pad parent buffer -- )
c-function gst_proxy_pad_chain_list_default gst_proxy_pad_chain_list_default a a a -- n	( pad parent list -- )
c-function gst_proxy_pad_getrange_default gst_proxy_pad_getrange_default a a ud u a -- n	( pad parent offset size buffer -- )
c-function gst_ghost_pad_get_type gst_ghost_pad_get_type  -- u	( -- )
c-function gst_ghost_pad_new gst_ghost_pad_new s a -- a	( name target -- )
c-function gst_ghost_pad_new_no_target gst_ghost_pad_new_no_target s n -- a	( name dir -- )
c-function gst_ghost_pad_new_from_template gst_ghost_pad_new_from_template s a a -- a	( name target templ -- )
c-function gst_ghost_pad_new_no_target_from_template gst_ghost_pad_new_no_target_from_template s a -- a	( name templ -- )
c-function gst_ghost_pad_get_target gst_ghost_pad_get_target a -- a	( gpad -- )
c-function gst_ghost_pad_set_target gst_ghost_pad_set_target a a -- n	( gpad newtarget -- )
c-function gst_ghost_pad_construct gst_ghost_pad_construct a -- n	( gpad -- )
c-function gst_ghost_pad_activate_mode_default gst_ghost_pad_activate_mode_default a a n n -- n	( pad parent mode active -- )
c-function gst_ghost_pad_internal_activate_mode_default gst_ghost_pad_internal_activate_mode_default a a n n -- n	( pad parent mode active -- )
c-function gst_iterator_get_type gst_iterator_get_type  -- u	( -- )
c-function gst_iterator_new gst_iterator_new u u a a a a a a a -- a	( size type lock master_cookie copy next item resync free -- )
c-function gst_iterator_new_list gst_iterator_new_list u a a a a a -- a	( type lock master_cookie list owner item -- )
c-function gst_iterator_new_single gst_iterator_new_single u a -- a	( type object -- )
c-function gst_iterator_copy gst_iterator_copy a -- a	( it -- )
c-function gst_iterator_next gst_iterator_next a a -- n	( it elem -- )
c-function gst_iterator_resync gst_iterator_resync a -- void	( it -- )
c-function gst_iterator_free gst_iterator_free a -- void	( it -- )
c-function gst_iterator_push gst_iterator_push a a -- void	( it other -- )
c-function gst_iterator_filter gst_iterator_filter a a a -- a	( it func user_data -- )
c-function gst_iterator_fold gst_iterator_fold a a a a -- n	( it func ret user_data -- )
c-function gst_iterator_foreach gst_iterator_foreach a a a -- n	( it func user_data -- )
c-function gst_iterator_find_custom gst_iterator_find_custom a a a a -- n	( it func elem user_data -- )
c-function gst_message_get_type gst_message_get_type  -- u	( -- )
c-function gst_message_type_get_name gst_message_type_get_name n -- s	( type -- )
c-function gst_message_type_to_quark gst_message_type_to_quark n -- n	( type -- )
c-function gst_message_ref gst_message_ref a -- a	( msg -- )
c-function gst_message_unref gst_message_unref a -- void	( msg -- )
\ c-function gst_clear_message gst_clear_message a -- void	( msg_ptr -- )
c-function gst_message_copy gst_message_copy a -- a	( msg -- )
c-function gst_message_replace gst_message_replace a a -- n	( old_message new_message -- )
c-function gst_message_take gst_message_take a a -- n	( old_message new_message -- )
c-function gst_message_new_custom gst_message_new_custom n a a -- a	( type src structure -- )
c-function gst_message_get_structure gst_message_get_structure a -- a	( message -- )
c-function gst_message_writable_structure gst_message_writable_structure a -- a	( message -- )
c-function gst_message_has_name gst_message_has_name a s -- n	( message name -- )
c-function gst_message_get_seqnum gst_message_get_seqnum a -- u	( message -- )
c-function gst_message_set_seqnum gst_message_set_seqnum a u -- void	( message seqnum -- )
c-function gst_message_new_eos gst_message_new_eos a -- a	( src -- )
c-function gst_message_new_error gst_message_new_error a a s -- a	( src error debug -- )
c-function gst_message_new_error_with_details gst_message_new_error_with_details a a s a -- a	( src error debug details -- )
c-function gst_message_parse_error gst_message_parse_error a a a -- void	( message gerror debug -- )
c-function gst_message_parse_error_details gst_message_parse_error_details a a -- void	( message structure -- )
c-function gst_message_new_warning gst_message_new_warning a a s -- a	( src error debug -- )
c-function gst_message_new_warning_with_details gst_message_new_warning_with_details a a s a -- a	( src error debug details -- )
c-function gst_message_parse_warning gst_message_parse_warning a a a -- void	( message gerror debug -- )
c-function gst_message_parse_warning_details gst_message_parse_warning_details a a -- void	( message structure -- )
c-function gst_message_new_info gst_message_new_info a a s -- a	( src error debug -- )
c-function gst_message_new_info_with_details gst_message_new_info_with_details a a s a -- a	( src error debug details -- )
c-function gst_message_parse_info gst_message_parse_info a a a -- void	( message gerror debug -- )
c-function gst_message_parse_info_details gst_message_parse_info_details a a -- void	( message structure -- )
c-function gst_message_new_tag gst_message_new_tag a a -- a	( src tag_list -- )
c-function gst_message_parse_tag gst_message_parse_tag a a -- void	( message tag_list -- )
c-function gst_message_new_buffering gst_message_new_buffering a n -- a	( src percent -- )
c-function gst_message_parse_buffering gst_message_parse_buffering a a -- void	( message percent -- )
c-function gst_message_set_buffering_stats gst_message_set_buffering_stats a n n n d -- void	( message mode avg_in avg_out buffering_left -- )
c-function gst_message_parse_buffering_stats gst_message_parse_buffering_stats a a a a a -- void	( message mode avg_in avg_out buffering_left -- )
c-function gst_message_new_state_changed gst_message_new_state_changed a n n n -- a	( src oldstate newstate pending -- )
c-function gst_message_parse_state_changed gst_message_parse_state_changed a a a a -- void	( message oldstate newstate pending -- )
c-function gst_message_new_state_dirty gst_message_new_state_dirty a -- a	( src -- )
c-function gst_message_new_step_done gst_message_new_step_done a u ud r n n ud n -- a	( src format amount rate flush intermediate duration eos -- )
c-function gst_message_parse_step_done gst_message_parse_step_done a a a a a a a a -- void	( message format amount rate flush intermediate duration eos -- )
c-function gst_message_new_clock_provide gst_message_new_clock_provide a a n -- a	( src clock ready -- )
c-function gst_message_parse_clock_provide gst_message_parse_clock_provide a a a -- void	( message clock ready -- )
c-function gst_message_new_clock_lost gst_message_new_clock_lost a a -- a	( src clock -- )
c-function gst_message_parse_clock_lost gst_message_parse_clock_lost a a -- void	( message clock -- )
c-function gst_message_new_new_clock gst_message_new_new_clock a a -- a	( src clock -- )
c-function gst_message_parse_new_clock gst_message_parse_new_clock a a -- void	( message clock -- )
c-function gst_message_new_application gst_message_new_application a a -- a	( src structure -- )
c-function gst_message_new_element gst_message_new_element a a -- a	( src structure -- )
c-function gst_message_new_segment_start gst_message_new_segment_start a u d -- a	( src format position -- )
c-function gst_message_parse_segment_start gst_message_parse_segment_start a a a -- void	( message format position -- )
c-function gst_message_new_segment_done gst_message_new_segment_done a u d -- a	( src format position -- )
c-function gst_message_parse_segment_done gst_message_parse_segment_done a a a -- void	( message format position -- )
c-function gst_message_new_duration_changed gst_message_new_duration_changed a -- a	( src -- )
c-function gst_message_new_latency gst_message_new_latency a -- a	( src -- )
c-function gst_message_new_async_start gst_message_new_async_start a -- a	( src -- )
c-function gst_message_new_async_done gst_message_new_async_done a ud -- a	( src running_time -- )
c-function gst_message_parse_async_done gst_message_parse_async_done a a -- void	( message running_time -- )
c-function gst_message_new_structure_change gst_message_new_structure_change a n a n -- a	( src type owner busy -- )
c-function gst_message_parse_structure_change gst_message_parse_structure_change a a a a -- void	( message type owner busy -- )
c-function gst_message_new_stream_status gst_message_new_stream_status a n a -- a	( src type owner -- )
c-function gst_message_parse_stream_status gst_message_parse_stream_status a a a -- void	( message type owner -- )
c-function gst_message_set_stream_status_object gst_message_set_stream_status_object a a -- void	( message object -- )
c-function gst_message_get_stream_status_object gst_message_get_stream_status_object a -- a	( message -- )
c-function gst_message_new_request_state gst_message_new_request_state a n -- a	( src state -- )
c-function gst_message_parse_request_state gst_message_parse_request_state a a -- void	( message state -- )
c-function gst_message_new_step_start gst_message_new_step_start a n u ud r n n -- a	( src active format amount rate flush intermediate -- )
c-function gst_message_parse_step_start gst_message_parse_step_start a a a a a a a -- void	( message active format amount rate flush intermediate -- )
c-function gst_message_new_qos gst_message_new_qos a n ud ud ud ud -- a	( src live running_time stream_time timestamp duration -- )
c-function gst_message_set_qos_values gst_message_set_qos_values a d r n -- void	( message jitter proportion quality -- )
c-function gst_message_set_qos_stats gst_message_set_qos_stats a u ud ud -- void	( message format processed dropped -- )
c-function gst_message_parse_qos gst_message_parse_qos a a a a a a -- void	( message live running_time stream_time timestamp duration -- )
c-function gst_message_parse_qos_values gst_message_parse_qos_values a a a a -- void	( message jitter proportion quality -- )
c-function gst_message_parse_qos_stats gst_message_parse_qos_stats a a a a -- void	( message format processed dropped -- )
c-function gst_message_new_progress gst_message_new_progress a n s s -- a	( src type code text -- )
c-function gst_message_parse_progress gst_message_parse_progress a a a a -- void	( message type code text -- )
c-function gst_message_new_toc gst_message_new_toc a a n -- a	( src toc updated -- )
c-function gst_message_parse_toc gst_message_parse_toc a a a -- void	( message toc updated -- )
c-function gst_message_new_reset_time gst_message_new_reset_time a ud -- a	( src running_time -- )
c-function gst_message_parse_reset_time gst_message_parse_reset_time a a -- void	( message running_time -- )
c-function gst_message_new_stream_start gst_message_new_stream_start a -- a	( src -- )
c-function gst_message_set_group_id gst_message_set_group_id a u -- void	( message group_id -- )
c-function gst_message_parse_group_id gst_message_parse_group_id a a -- n	( message group_id -- )
c-function gst_message_new_need_context gst_message_new_need_context a s -- a	( src context_type -- )
c-function gst_message_parse_context_type gst_message_parse_context_type a a -- n	( message context_type -- )
c-function gst_message_new_have_context gst_message_new_have_context a a -- a	( src context -- )
c-function gst_message_parse_have_context gst_message_parse_have_context a a -- void	( message context -- )
c-function gst_message_new_device_added gst_message_new_device_added a a -- a	( src device -- )
c-function gst_message_parse_device_added gst_message_parse_device_added a a -- void	( message device -- )
c-function gst_message_new_device_removed gst_message_new_device_removed a a -- a	( src device -- )
c-function gst_message_parse_device_removed gst_message_parse_device_removed a a -- void	( message device -- )
c-function gst_message_new_device_changed gst_message_new_device_changed a a a -- a	( src device changed_device -- )
c-function gst_message_parse_device_changed gst_message_parse_device_changed a a a -- void	( message device changed_device -- )
c-function gst_message_new_property_notify gst_message_new_property_notify a s a -- a	( src property_name val -- )
c-function gst_message_parse_property_notify gst_message_parse_property_notify a a a a -- void	( message object property_name property_value -- )
c-function gst_message_new_stream_collection gst_message_new_stream_collection a a -- a	( src collection -- )
c-function gst_message_parse_stream_collection gst_message_parse_stream_collection a a -- void	( message collection -- )
c-function gst_message_new_streams_selected gst_message_new_streams_selected a a -- a	( src collection -- )
c-function gst_message_streams_selected_add gst_message_streams_selected_add a a -- void	( message stream -- )
c-function gst_message_parse_streams_selected gst_message_parse_streams_selected a a -- void	( message collection -- )
c-function gst_message_streams_selected_get_size gst_message_streams_selected_get_size a -- u	( message -- )
c-function gst_message_streams_selected_get_stream gst_message_streams_selected_get_stream a u -- a	( message idx -- )
c-function gst_message_new_redirect gst_message_new_redirect a s a a -- a	( src location tag_list entry_struct -- )
c-function gst_message_add_redirect_entry gst_message_add_redirect_entry a s a a -- void	( message location tag_list entry_struct -- )
c-function gst_message_parse_redirect_entry gst_message_parse_redirect_entry a u a a a -- void	( message entry_index location tag_list entry_struct -- )
c-function gst_message_get_num_redirect_entries gst_message_get_num_redirect_entries a -- u	( message -- )
c-function gst_memory_get_type gst_memory_get_type  -- u	( -- )
c-function gst_memory_init gst_memory_init a n a a u u u u -- void	( mem flags allocator parent maxsize align offset size -- )
c-function gst_memory_is_type gst_memory_is_type a s -- n	( mem mem_type -- )
c-function gst_memory_ref gst_memory_ref a -- a	( memory -- )
c-function gst_memory_unref gst_memory_unref a -- void	( memory -- )
c-function gst_memory_get_sizes gst_memory_get_sizes a a a -- u	( mem offset maxsize -- )
c-function gst_memory_resize gst_memory_resize a n u -- void	( mem offset size -- )
c-function gst_memory_make_mapped gst_memory_make_mapped a a n -- a	( mem info flags -- )
c-function gst_memory_map gst_memory_map a a n -- n	( mem info flags -- )
c-function gst_memory_unmap gst_memory_unmap a a -- void	( mem info -- )
c-function gst_memory_copy gst_memory_copy a n n -- a	( mem offset size -- )
c-function gst_memory_share gst_memory_share a n n -- a	( mem offset size -- )
c-function gst_memory_is_span gst_memory_is_span a a a -- n	( mem1 mem2 offset -- )
c-function gst_meta_api_type_register gst_meta_api_type_register s a -- u	( api tags -- )
c-function gst_meta_api_type_has_tag gst_meta_api_type_has_tag u n -- n	( api tag -- )
c-function gst_meta_register gst_meta_register u s u a a a -- a	( api impl size init_func free_func transform_func -- )
c-function gst_meta_get_info gst_meta_get_info s -- a	( impl -- )
c-function gst_meta_api_type_get_tags gst_meta_api_type_get_tags u -- a	( api -- )
c-function gst_meta_get_seqnum gst_meta_get_seqnum a -- ud	( meta -- )
c-function gst_meta_compare_seqnum gst_meta_compare_seqnum a a -- n	( meta1 meta2 -- )
c-function gst_mini_object_init gst_mini_object_init a u u a a a -- void	( mini_object flags type copy_func dispose_func free_func -- )
c-function gst_mini_object_ref gst_mini_object_ref a -- a	( mini_object -- )
c-function gst_mini_object_unref gst_mini_object_unref a -- void	( mini_object -- )
\ c-function gst_clear_mini_object gst_clear_mini_object a -- void	( object_ptr -- )
c-function gst_mini_object_weak_ref gst_mini_object_weak_ref a a a -- void	( object notify data -- )
c-function gst_mini_object_weak_unref gst_mini_object_weak_unref a a a -- void	( object notify data -- )
c-function gst_mini_object_lock gst_mini_object_lock a n -- n	( object flags -- )
c-function gst_mini_object_unlock gst_mini_object_unlock a n -- void	( object flags -- )
c-function gst_mini_object_is_writable gst_mini_object_is_writable a -- n	( mini_object -- )
c-function gst_mini_object_make_writable gst_mini_object_make_writable a -- a	( mini_object -- )
c-function gst_mini_object_copy gst_mini_object_copy a -- a	( mini_object -- )
c-function gst_mini_object_set_qdata gst_mini_object_set_qdata a n a a -- void	( object quark data destroy -- )
c-function gst_mini_object_get_qdata gst_mini_object_get_qdata a n -- a	( object quark -- )
c-function gst_mini_object_steal_qdata gst_mini_object_steal_qdata a n -- a	( object quark -- )
c-function gst_mini_object_add_parent gst_mini_object_add_parent a a -- void	( object parent -- )
c-function gst_mini_object_remove_parent gst_mini_object_remove_parent a a -- void	( object parent -- )
c-function gst_mini_object_replace gst_mini_object_replace a a -- n	( olddata newdata -- )
c-function gst_mini_object_take gst_mini_object_take a a -- n	( olddata newdata -- )
c-function gst_mini_object_steal gst_mini_object_steal a -- a	( olddata -- )
c-function gst_object_get_type gst_object_get_type  -- u	( -- )
c-function gst_object_set_name gst_object_set_name a s -- n	( object name -- )
c-function gst_object_get_name gst_object_get_name a -- a	( object -- )
c-function gst_object_set_parent gst_object_set_parent a a -- n	( object parent -- )
c-function gst_object_get_parent gst_object_get_parent a -- a	( object -- )
c-function gst_object_unparent gst_object_unparent a -- void	( object -- )
c-function gst_object_has_as_parent gst_object_has_as_parent a a -- n	( object parent -- )
c-function gst_object_has_as_ancestor gst_object_has_as_ancestor a a -- n	( object ancestor -- )
c-function gst_object_has_ancestor gst_object_has_ancestor a a -- n	( object ancestor -- )
c-function gst_object_default_deep_notify gst_object_default_deep_notify a a a a -- void	( object orig pspec excluded_props -- )
c-function gst_object_ref gst_object_ref a -- a	( object -- )
c-function gst_object_unref gst_object_unref a -- void	( object -- )
\ c-function gst_clear_object gst_clear_object a -- void	( object_ptr -- )
c-function gst_object_ref_sink gst_object_ref_sink a -- a	( object -- )
c-function gst_object_replace gst_object_replace a a -- n	( oldobj newobj -- )
c-function gst_object_get_path_string gst_object_get_path_string a -- a	( object -- )
c-function gst_object_check_uniqueness gst_object_check_uniqueness a s -- n	( list name -- )
c-function gst_object_suggest_next_sync gst_object_suggest_next_sync a -- ud	( object -- )
c-function gst_object_sync_values gst_object_sync_values a ud -- n	( object timestamp -- )
c-function gst_object_has_active_control_bindings gst_object_has_active_control_bindings a -- n	( object -- )
c-function gst_object_set_control_bindings_disabled gst_object_set_control_bindings_disabled a n -- void	( object disabled -- )
c-function gst_object_set_control_binding_disabled gst_object_set_control_binding_disabled a s n -- void	( object property_name disabled -- )
c-function gst_object_add_control_binding gst_object_add_control_binding a a -- n	( object binding -- )
c-function gst_object_get_control_binding gst_object_get_control_binding a s -- a	( object property_name -- )
c-function gst_object_remove_control_binding gst_object_remove_control_binding a a -- n	( object binding -- )
c-function gst_object_get_value gst_object_get_value a s ud -- a	( object property_name timestamp -- )
c-function gst_object_get_value_array gst_object_get_value_array a s ud ud u a -- n	( object property_name timestamp interval n_values values -- )
c-function gst_object_get_g_value_array gst_object_get_g_value_array a s ud ud u a -- n	( object property_name timestamp interval n_values values -- )
c-function gst_object_get_control_rate gst_object_get_control_rate a -- ud	( object -- )
c-function gst_object_set_control_rate gst_object_set_control_rate a ud -- void	( object control_rate -- )
c-function gst_pad_mode_get_name gst_pad_mode_get_name n -- s	( mode -- )
c-function gst_flow_get_name gst_flow_get_name n -- s	( ret -- )
c-function gst_flow_to_quark gst_flow_to_quark n -- n	( ret -- )
c-function gst_pad_link_get_name gst_pad_link_get_name n -- s	( ret -- )
c-function gst_pad_probe_info_get_event gst_pad_probe_info_get_event a -- a	( info -- )
c-function gst_pad_probe_info_get_query gst_pad_probe_info_get_query a -- a	( info -- )
c-function gst_pad_probe_info_get_buffer gst_pad_probe_info_get_buffer a -- a	( info -- )
c-function gst_pad_probe_info_get_buffer_list gst_pad_probe_info_get_buffer_list a -- a	( info -- )
c-function gst_pad_get_type gst_pad_get_type  -- u	( -- )
c-function gst_pad_new gst_pad_new s n -- a	( name direction -- )
c-function gst_pad_new_from_template gst_pad_new_from_template a s -- a	( templ name -- )
c-function gst_pad_new_from_static_template gst_pad_new_from_static_template a s -- a	( templ name -- )
c-function gst_pad_get_direction gst_pad_get_direction a -- n	( pad -- )
c-function gst_pad_set_active gst_pad_set_active a n -- n	( pad active -- )
c-function gst_pad_is_active gst_pad_is_active a -- n	( pad -- )
c-function gst_pad_activate_mode gst_pad_activate_mode a n n -- n	( pad mode active -- )
c-function gst_pad_add_probe gst_pad_add_probe a n a a a -- n	( pad mask callback user_data destroy_data -- )
c-function gst_pad_remove_probe gst_pad_remove_probe a n -- void	( pad id -- )
c-function gst_pad_is_blocked gst_pad_is_blocked a -- n	( pad -- )
c-function gst_pad_is_blocking gst_pad_is_blocking a -- n	( pad -- )
c-function gst_pad_mark_reconfigure gst_pad_mark_reconfigure a -- void	( pad -- )
c-function gst_pad_needs_reconfigure gst_pad_needs_reconfigure a -- n	( pad -- )
c-function gst_pad_check_reconfigure gst_pad_check_reconfigure a -- n	( pad -- )
c-function gst_pad_set_element_private gst_pad_set_element_private a a -- void	( pad priv -- )
c-function gst_pad_get_element_private gst_pad_get_element_private a -- a	( pad -- )
c-function gst_pad_get_pad_template gst_pad_get_pad_template a -- a	( pad -- )
c-function gst_pad_store_sticky_event gst_pad_store_sticky_event a a -- n	( pad event -- )
c-function gst_pad_get_sticky_event gst_pad_get_sticky_event a n u -- a	( pad event_type idx -- )
c-function gst_pad_sticky_events_foreach gst_pad_sticky_events_foreach a a a -- void	( pad foreach_func user_data -- )
c-function gst_pad_set_activate_function_full gst_pad_set_activate_function_full a a a a -- void	( pad activate user_data notify -- )
c-function gst_pad_set_activatemode_function_full gst_pad_set_activatemode_function_full a a a a -- void	( pad activatemode user_data notify -- )
c-function gst_pad_set_chain_function_full gst_pad_set_chain_function_full a a a a -- void	( pad chain user_data notify -- )
c-function gst_pad_set_chain_list_function_full gst_pad_set_chain_list_function_full a a a a -- void	( pad chainlist user_data notify -- )
c-function gst_pad_set_getrange_function_full gst_pad_set_getrange_function_full a a a a -- void	( pad get user_data notify -- )
c-function gst_pad_set_event_function_full gst_pad_set_event_function_full a a a a -- void	( pad event user_data notify -- )
c-function gst_pad_set_event_full_function_full gst_pad_set_event_full_function_full a a a a -- void	( pad event user_data notify -- )
c-function gst_pad_set_link_function_full gst_pad_set_link_function_full a a a a -- void	( pad link user_data notify -- )
c-function gst_pad_set_unlink_function_full gst_pad_set_unlink_function_full a a a a -- void	( pad unlink user_data notify -- )
c-function gst_pad_can_link gst_pad_can_link a a -- n	( srcpad sinkpad -- )
c-function gst_pad_link gst_pad_link a a -- n	( srcpad sinkpad -- )
c-function gst_pad_link_full gst_pad_link_full a a n -- n	( srcpad sinkpad flags -- )
c-function gst_pad_unlink gst_pad_unlink a a -- n	( srcpad sinkpad -- )
c-function gst_pad_is_linked gst_pad_is_linked a -- n	( pad -- )
c-function gst_pad_get_peer gst_pad_get_peer a -- a	( pad -- )
c-function gst_pad_get_pad_template_caps gst_pad_get_pad_template_caps a -- a	( pad -- )
c-function gst_pad_get_current_caps gst_pad_get_current_caps a -- a	( pad -- )
c-function gst_pad_has_current_caps gst_pad_has_current_caps a -- n	( pad -- )
c-function gst_pad_get_allowed_caps gst_pad_get_allowed_caps a -- a	( pad -- )
c-function gst_pad_get_offset gst_pad_get_offset a -- d	( pad -- )
c-function gst_pad_set_offset gst_pad_set_offset a d -- void	( pad offset -- )
c-function gst_pad_push gst_pad_push a a -- n	( pad buffer -- )
c-function gst_pad_push_list gst_pad_push_list a a -- n	( pad list -- )
c-function gst_pad_pull_range gst_pad_pull_range a ud u a -- n	( pad offset size buffer -- )
c-function gst_pad_push_event gst_pad_push_event a a -- n	( pad event -- )
c-function gst_pad_event_default gst_pad_event_default a a a -- n	( pad parent event -- )
c-function gst_pad_get_last_flow_return gst_pad_get_last_flow_return a -- n	( pad -- )
c-function gst_pad_chain gst_pad_chain a a -- n	( pad buffer -- )
c-function gst_pad_chain_list gst_pad_chain_list a a -- n	( pad list -- )
c-function gst_pad_get_range gst_pad_get_range a ud u a -- n	( pad offset size buffer -- )
c-function gst_pad_send_event gst_pad_send_event a a -- n	( pad event -- )
c-function gst_pad_start_task gst_pad_start_task a a a a -- n	( pad func user_data notify -- )
c-function gst_pad_pause_task gst_pad_pause_task a -- n	( pad -- )
c-function gst_pad_stop_task gst_pad_stop_task a -- n	( pad -- )
c-function gst_pad_get_task_state gst_pad_get_task_state a -- n	( pad -- )
c-function gst_pad_set_iterate_internal_links_function_full gst_pad_set_iterate_internal_links_function_full a a a a -- void	( pad iterintlink user_data notify -- )
c-function gst_pad_iterate_internal_links gst_pad_iterate_internal_links a -- a	( pad -- )
c-function gst_pad_iterate_internal_links_default gst_pad_iterate_internal_links_default a a -- a	( pad parent -- )
c-function gst_pad_query gst_pad_query a a -- n	( pad query -- )
c-function gst_pad_peer_query gst_pad_peer_query a a -- n	( pad query -- )
c-function gst_pad_set_query_function_full gst_pad_set_query_function_full a a a a -- void	( pad query user_data notify -- )
c-function gst_pad_query_default gst_pad_query_default a a a -- n	( pad parent query -- )
c-function gst_pad_forward gst_pad_forward a a a -- n	( pad forward user_data -- )
c-function gst_param_spec_fraction_get_type gst_param_spec_fraction_get_type  -- u	( -- )
c-function gst_param_spec_array_get_type gst_param_spec_array_get_type  -- u	( -- )
c-function gst_param_spec_fraction gst_param_spec_fraction s s s n n n n n n n -- a	( name nick blurb min_num min_denom max_num max_denom default_num default_denom flags -- )
c-function gst_param_spec_array gst_param_spec_array s s s a n -- a	( name nick blurb element_spec flags -- )
c-function gst_pipeline_get_type gst_pipeline_get_type  -- u	( -- )
c-function gst_pipeline_new gst_pipeline_new s -- a	( name -- )
c-function gst_pipeline_get_bus gst_pipeline_get_bus a -- a	( pipeline -- )
c-function gst_pipeline_use_clock gst_pipeline_use_clock a a -- void	( pipeline clock -- )
c-function gst_pipeline_set_clock gst_pipeline_set_clock a a -- n	( pipeline clock -- )
c-function gst_pipeline_get_clock gst_pipeline_get_clock a -- a	( pipeline -- )
c-function gst_pipeline_get_pipeline_clock gst_pipeline_get_pipeline_clock a -- a	( pipeline -- )
c-function gst_pipeline_auto_clock gst_pipeline_auto_clock a -- void	( pipeline -- )
c-function gst_pipeline_set_delay gst_pipeline_set_delay a ud -- void	( pipeline delay -- )
c-function gst_pipeline_get_delay gst_pipeline_get_delay a -- ud	( pipeline -- )
c-function gst_pipeline_set_latency gst_pipeline_set_latency a ud -- void	( pipeline latency -- )
c-function gst_pipeline_get_latency gst_pipeline_get_latency a -- ud	( pipeline -- )
c-function gst_pipeline_set_auto_flush_bus gst_pipeline_set_auto_flush_bus a n -- void	( pipeline auto_flush -- )
c-function gst_pipeline_get_auto_flush_bus gst_pipeline_get_auto_flush_bus a -- n	( pipeline -- )
c-function gst_plugin_error_quark gst_plugin_error_quark  -- n	( -- )
c-function gst_plugin_get_type gst_plugin_get_type  -- u	( -- )
c-function gst_plugin_register_static gst_plugin_register_static n n s s a s s s s s -- n	( major_version minor_version name description init_func version license source package origin -- )
c-function gst_plugin_register_static_full gst_plugin_register_static_full n n s s a s s s s s a -- n	( major_version minor_version name description init_full_func version license source package origin user_data -- )
c-function gst_plugin_get_name gst_plugin_get_name a -- s	( plugin -- )
c-function gst_plugin_get_description gst_plugin_get_description a -- s	( plugin -- )
c-function gst_plugin_get_filename gst_plugin_get_filename a -- s	( plugin -- )
c-function gst_plugin_get_version gst_plugin_get_version a -- s	( plugin -- )
c-function gst_plugin_get_license gst_plugin_get_license a -- s	( plugin -- )
c-function gst_plugin_get_source gst_plugin_get_source a -- s	( plugin -- )
c-function gst_plugin_get_package gst_plugin_get_package a -- s	( plugin -- )
c-function gst_plugin_get_origin gst_plugin_get_origin a -- s	( plugin -- )
c-function gst_plugin_get_release_date_string gst_plugin_get_release_date_string a -- s	( plugin -- )
c-function gst_plugin_get_cache_data gst_plugin_get_cache_data a -- a	( plugin -- )
c-function gst_plugin_set_cache_data gst_plugin_set_cache_data a a -- void	( plugin cache_data -- )
c-function gst_plugin_is_loaded gst_plugin_is_loaded a -- n	( plugin -- )
c-function gst_plugin_load_file gst_plugin_load_file s a -- a	( filename error -- )
c-function gst_plugin_load gst_plugin_load a -- a	( plugin -- )
c-function gst_plugin_load_by_name gst_plugin_load_by_name s -- a	( name -- )
c-function gst_plugin_add_dependency gst_plugin_add_dependency a a a a n -- void	( plugin env_vars paths names flags -- )
c-function gst_plugin_add_dependency_simple gst_plugin_add_dependency_simple a s s s n -- void	( plugin env_vars paths names flags -- )
c-function gst_plugin_list_free gst_plugin_list_free a -- void	( list -- )
c-function gst_poll_new gst_poll_new n -- a	( controllable -- )
c-function gst_poll_new_timer gst_poll_new_timer  -- a	( -- )
c-function gst_poll_free gst_poll_free a -- void	( set -- )
c-function gst_poll_get_read_gpollfd gst_poll_get_read_gpollfd a a -- void	( set fd -- )
c-function gst_poll_fd_init gst_poll_fd_init a -- void	( fd -- )
c-function gst_poll_add_fd gst_poll_add_fd a a -- n	( set fd -- )
c-function gst_poll_remove_fd gst_poll_remove_fd a a -- n	( set fd -- )
c-function gst_poll_fd_ctl_write gst_poll_fd_ctl_write a a n -- n	( set fd active -- )
c-function gst_poll_fd_ctl_read gst_poll_fd_ctl_read a a n -- n	( set fd active -- )
c-function gst_poll_fd_ctl_pri gst_poll_fd_ctl_pri a a n -- n	( set fd active -- )
c-function gst_poll_fd_ignored gst_poll_fd_ignored a a -- void	( set fd -- )
c-function gst_poll_fd_has_closed gst_poll_fd_has_closed a a -- n	( set fd -- )
c-function gst_poll_fd_has_error gst_poll_fd_has_error a a -- n	( set fd -- )
c-function gst_poll_fd_can_read gst_poll_fd_can_read a a -- n	( set fd -- )
c-function gst_poll_fd_can_write gst_poll_fd_can_write a a -- n	( set fd -- )
c-function gst_poll_fd_has_pri gst_poll_fd_has_pri a a -- n	( set fd -- )
c-function gst_poll_wait gst_poll_wait a ud -- n	( set timeout -- )
c-function gst_poll_set_controllable gst_poll_set_controllable a n -- n	( set controllable -- )
c-function gst_poll_restart gst_poll_restart a -- void	( set -- )
c-function gst_poll_set_flushing gst_poll_set_flushing a n -- void	( set flushing -- )
c-function gst_poll_write_control gst_poll_write_control a -- n	( set -- )
c-function gst_poll_read_control gst_poll_read_control a -- n	( set -- )
c-function gst_preset_get_type gst_preset_get_type  -- u	( -- )
c-function gst_preset_get_preset_names gst_preset_get_preset_names a -- a	( preset -- )
c-function gst_preset_get_property_names gst_preset_get_property_names a -- a	( preset -- )
c-function gst_preset_load_preset gst_preset_load_preset a s -- n	( preset name -- )
c-function gst_preset_save_preset gst_preset_save_preset a s -- n	( preset name -- )
c-function gst_preset_rename_preset gst_preset_rename_preset a s s -- n	( preset old_name new_name -- )
c-function gst_preset_delete_preset gst_preset_delete_preset a s -- n	( preset name -- )
c-function gst_preset_set_meta gst_preset_set_meta a s s s -- n	( preset name tag value -- )
c-function gst_preset_get_meta gst_preset_get_meta a s s a -- n	( preset name tag value -- )
c-function gst_preset_set_app_dir gst_preset_set_app_dir s -- n	( app_dir -- )
c-function gst_preset_get_app_dir gst_preset_get_app_dir  -- s	( -- )
c-function gst_preset_is_editable gst_preset_is_editable a -- n	( preset -- )
c-function gst_query_type_get_name gst_query_type_get_name n -- s	( type -- )
c-function gst_query_type_to_quark gst_query_type_to_quark n -- n	( type -- )
c-function gst_query_type_get_flags gst_query_type_get_flags n -- n	( type -- )
c-function gst_query_get_type gst_query_get_type  -- u	( -- )
c-function gst_query_ref gst_query_ref a -- a	( q -- )
c-function gst_query_unref gst_query_unref a -- void	( q -- )
\ c-function gst_clear_query gst_clear_query a -- void	( query_ptr -- )
c-function gst_query_copy gst_query_copy a -- a	( q -- )
c-function gst_query_replace gst_query_replace a a -- n	( old_query new_query -- )
c-function gst_query_take gst_query_take a a -- n	( old_query new_query -- )
c-function gst_query_new_custom gst_query_new_custom n a -- a	( type structure -- )
c-function gst_query_get_structure gst_query_get_structure a -- a	( query -- )
c-function gst_query_writable_structure gst_query_writable_structure a -- a	( query -- )
c-function gst_query_new_position gst_query_new_position u -- a	( format -- )
c-function gst_query_set_position gst_query_set_position a u d -- void	( query format cur -- )
c-function gst_query_parse_position gst_query_parse_position a a a -- void	( query format cur -- )
c-function gst_query_new_duration gst_query_new_duration u -- a	( format -- )
c-function gst_query_set_duration gst_query_set_duration a u d -- void	( query format duration -- )
c-function gst_query_parse_duration gst_query_parse_duration a a a -- void	( query format duration -- )
c-function gst_query_new_latency gst_query_new_latency  -- a	( -- )
c-function gst_query_set_latency gst_query_set_latency a n ud ud -- void	( query live min_latency max_latency -- )
c-function gst_query_parse_latency gst_query_parse_latency a a a a -- void	( query live min_latency max_latency -- )
c-function gst_query_new_convert gst_query_new_convert u d u -- a	( src_format value dest_format -- )
c-function gst_query_set_convert gst_query_set_convert a u d u d -- void	( query src_format src_value dest_format dest_value -- )
c-function gst_query_parse_convert gst_query_parse_convert a a a a a -- void	( query src_format src_value dest_format dest_value -- )
c-function gst_query_new_segment gst_query_new_segment u -- a	( format -- )
c-function gst_query_set_segment gst_query_set_segment a r u d d -- void	( query rate format start_value stop_value -- )
c-function gst_query_parse_segment gst_query_parse_segment a a a a a -- void	( query rate format start_value stop_value -- )
c-function gst_query_new_seeking gst_query_new_seeking u -- a	( format -- )
c-function gst_query_set_seeking gst_query_set_seeking a u n d d -- void	( query format seekable segment_start segment_end -- )
c-function gst_query_parse_seeking gst_query_parse_seeking a a a a a -- void	( query format seekable segment_start segment_end -- )
c-function gst_query_new_formats gst_query_new_formats  -- a	( -- )
c-function gst_query_set_formats gst_query_set_formats a n ... -- void	( query n_formats <noname> -- )
c-function gst_query_set_formatsv gst_query_set_formatsv a n a -- void	( query n_formats formats -- )
c-function gst_query_parse_n_formats gst_query_parse_n_formats a a -- void	( query n_formats -- )
c-function gst_query_parse_nth_format gst_query_parse_nth_format a u a -- void	( query nth format -- )
c-function gst_query_new_buffering gst_query_new_buffering u -- a	( format -- )
c-function gst_query_set_buffering_percent gst_query_set_buffering_percent a n n -- void	( query busy percent -- )
c-function gst_query_parse_buffering_percent gst_query_parse_buffering_percent a a a -- void	( query busy percent -- )
c-function gst_query_set_buffering_stats gst_query_set_buffering_stats a n n n d -- void	( query mode avg_in avg_out buffering_left -- )
c-function gst_query_parse_buffering_stats gst_query_parse_buffering_stats a a a a a -- void	( query mode avg_in avg_out buffering_left -- )
c-function gst_query_set_buffering_range gst_query_set_buffering_range a u d d d -- void	( query format start stop estimated_total -- )
c-function gst_query_parse_buffering_range gst_query_parse_buffering_range a a a a a -- void	( query format start stop estimated_total -- )
c-function gst_query_add_buffering_range gst_query_add_buffering_range a d d -- n	( query start stop -- )
c-function gst_query_get_n_buffering_ranges gst_query_get_n_buffering_ranges a -- u	( query -- )
c-function gst_query_parse_nth_buffering_range gst_query_parse_nth_buffering_range a u a a -- n	( query index start stop -- )
c-function gst_query_new_uri gst_query_new_uri  -- a	( -- )
c-function gst_query_parse_uri gst_query_parse_uri a a -- void	( query uri -- )
c-function gst_query_set_uri gst_query_set_uri a s -- void	( query uri -- )
c-function gst_query_parse_uri_redirection gst_query_parse_uri_redirection a a -- void	( query uri -- )
c-function gst_query_set_uri_redirection gst_query_set_uri_redirection a s -- void	( query uri -- )
c-function gst_query_parse_uri_redirection_permanent gst_query_parse_uri_redirection_permanent a a -- void	( query permanent -- )
c-function gst_query_set_uri_redirection_permanent gst_query_set_uri_redirection_permanent a n -- void	( query permanent -- )
c-function gst_query_new_allocation gst_query_new_allocation a n -- a	( caps need_pool -- )
c-function gst_query_parse_allocation gst_query_parse_allocation a a a -- void	( query caps need_pool -- )
c-function gst_query_add_allocation_pool gst_query_add_allocation_pool a a u u u -- void	( query pool size min_buffers max_buffers -- )
c-function gst_query_get_n_allocation_pools gst_query_get_n_allocation_pools a -- u	( query -- )
c-function gst_query_parse_nth_allocation_pool gst_query_parse_nth_allocation_pool a u a a a a -- void	( query index pool size min_buffers max_buffers -- )
c-function gst_query_set_nth_allocation_pool gst_query_set_nth_allocation_pool a u a u u u -- void	( query index pool size min_buffers max_buffers -- )
c-function gst_query_remove_nth_allocation_pool gst_query_remove_nth_allocation_pool a u -- void	( query index -- )
c-function gst_query_add_allocation_param gst_query_add_allocation_param a a a -- void	( query allocator params -- )
c-function gst_query_get_n_allocation_params gst_query_get_n_allocation_params a -- u	( query -- )
c-function gst_query_parse_nth_allocation_param gst_query_parse_nth_allocation_param a u a a -- void	( query index allocator params -- )
c-function gst_query_set_nth_allocation_param gst_query_set_nth_allocation_param a u a a -- void	( query index allocator params -- )
c-function gst_query_remove_nth_allocation_param gst_query_remove_nth_allocation_param a u -- void	( query index -- )
c-function gst_query_add_allocation_meta gst_query_add_allocation_meta a u a -- void	( query api params -- )
c-function gst_query_get_n_allocation_metas gst_query_get_n_allocation_metas a -- u	( query -- )
c-function gst_query_parse_nth_allocation_meta gst_query_parse_nth_allocation_meta a u a -- u	( query index params -- )
c-function gst_query_remove_nth_allocation_meta gst_query_remove_nth_allocation_meta a u -- void	( query index -- )
c-function gst_query_find_allocation_meta gst_query_find_allocation_meta a u a -- n	( query api index -- )
c-function gst_query_new_scheduling gst_query_new_scheduling  -- a	( -- )
c-function gst_query_set_scheduling gst_query_set_scheduling a n n n n -- void	( query flags minsize maxsize align -- )
c-function gst_query_parse_scheduling gst_query_parse_scheduling a a a a a -- void	( query flags minsize maxsize align -- )
c-function gst_query_add_scheduling_mode gst_query_add_scheduling_mode a n -- void	( query mode -- )
c-function gst_query_get_n_scheduling_modes gst_query_get_n_scheduling_modes a -- u	( query -- )
c-function gst_query_parse_nth_scheduling_mode gst_query_parse_nth_scheduling_mode a u -- n	( query index -- )
c-function gst_query_has_scheduling_mode gst_query_has_scheduling_mode a n -- n	( query mode -- )
c-function gst_query_has_scheduling_mode_with_flags gst_query_has_scheduling_mode_with_flags a n n -- n	( query mode flags -- )
c-function gst_query_new_accept_caps gst_query_new_accept_caps a -- a	( caps -- )
c-function gst_query_parse_accept_caps gst_query_parse_accept_caps a a -- void	( query caps -- )
c-function gst_query_set_accept_caps_result gst_query_set_accept_caps_result a n -- void	( query result -- )
c-function gst_query_parse_accept_caps_result gst_query_parse_accept_caps_result a a -- void	( query result -- )
c-function gst_query_new_caps gst_query_new_caps a -- a	( filter -- )
c-function gst_query_parse_caps gst_query_parse_caps a a -- void	( query filter -- )
c-function gst_query_set_caps_result gst_query_set_caps_result a a -- void	( query caps -- )
c-function gst_query_parse_caps_result gst_query_parse_caps_result a a -- void	( query caps -- )
c-function gst_query_new_drain gst_query_new_drain  -- a	( -- )
c-function gst_query_new_context gst_query_new_context s -- a	( context_type -- )
c-function gst_query_parse_context_type gst_query_parse_context_type a a -- n	( query context_type -- )
c-function gst_query_set_context gst_query_set_context a a -- void	( query context -- )
c-function gst_query_parse_context gst_query_parse_context a a -- void	( query context -- )
c-function gst_query_new_bitrate gst_query_new_bitrate  -- a	( -- )
c-function gst_query_set_bitrate gst_query_set_bitrate a u -- void	( query nominal_bitrate -- )
c-function gst_query_parse_bitrate gst_query_parse_bitrate a a -- void	( query nominal_bitrate -- )
c-function gst_registry_get_type gst_registry_get_type  -- u	( -- )
c-function gst_registry_get gst_registry_get  -- a	( -- )
c-function gst_registry_scan_path gst_registry_scan_path a s -- n	( registry path -- )
c-function gst_registry_add_plugin gst_registry_add_plugin a a -- n	( registry plugin -- )
c-function gst_registry_remove_plugin gst_registry_remove_plugin a a -- void	( registry plugin -- )
c-function gst_registry_add_feature gst_registry_add_feature a a -- n	( registry feature -- )
c-function gst_registry_remove_feature gst_registry_remove_feature a a -- void	( registry feature -- )
c-function gst_registry_get_plugin_list gst_registry_get_plugin_list a -- a	( registry -- )
c-function gst_registry_plugin_filter gst_registry_plugin_filter a a n a -- a	( registry filter first user_data -- )
c-function gst_registry_feature_filter gst_registry_feature_filter a a n a -- a	( registry filter first user_data -- )
c-function gst_registry_get_feature_list gst_registry_get_feature_list a u -- a	( registry type -- )
c-function gst_registry_get_feature_list_by_plugin gst_registry_get_feature_list_by_plugin a s -- a	( registry name -- )
c-function gst_registry_get_feature_list_cookie gst_registry_get_feature_list_cookie a -- u	( registry -- )
c-function gst_registry_find_plugin gst_registry_find_plugin a s -- a	( registry name -- )
c-function gst_registry_find_feature gst_registry_find_feature a s u -- a	( registry name type -- )
c-function gst_registry_lookup gst_registry_lookup a s -- a	( registry filename -- )
c-function gst_registry_lookup_feature gst_registry_lookup_feature a s -- a	( registry name -- )
c-function gst_registry_check_feature_version gst_registry_check_feature_version a s u u u -- n	( registry feature_name min_major min_minor min_micro -- )
c-function gst_sample_get_type gst_sample_get_type  -- u	( -- )
c-function gst_sample_new gst_sample_new a a a a -- a	( buffer caps segment info -- )
c-function gst_sample_get_buffer gst_sample_get_buffer a -- a	( sample -- )
c-function gst_sample_get_caps gst_sample_get_caps a -- a	( sample -- )
c-function gst_sample_get_segment gst_sample_get_segment a -- a	( sample -- )
c-function gst_sample_get_info gst_sample_get_info a -- a	( sample -- )
c-function gst_sample_get_buffer_list gst_sample_get_buffer_list a -- a	( sample -- )
c-function gst_sample_set_buffer_list gst_sample_set_buffer_list a a -- void	( sample buffer_list -- )
c-function gst_sample_set_buffer gst_sample_set_buffer a a -- void	( sample buffer -- )
c-function gst_sample_set_caps gst_sample_set_caps a a -- void	( sample caps -- )
c-function gst_sample_set_segment gst_sample_set_segment a a -- void	( sample segment -- )
c-function gst_sample_set_info gst_sample_set_info a a -- n	( sample info -- )
c-function gst_sample_ref gst_sample_ref a -- a	( sample -- )
c-function gst_sample_unref gst_sample_unref a -- void	( sample -- )
c-function gst_sample_copy gst_sample_copy a -- a	( buf -- )
c-function gst_segment_get_type gst_segment_get_type  -- u	( -- )
c-function gst_segment_new gst_segment_new  -- a	( -- )
c-function gst_segment_copy gst_segment_copy a -- a	( segment -- )
c-function gst_segment_copy_into gst_segment_copy_into a a -- void	( src dest -- )
c-function gst_segment_free gst_segment_free a -- void	( segment -- )
c-function gst_segment_init gst_segment_init a u -- void	( segment format -- )
c-function gst_segment_to_stream_time_full gst_segment_to_stream_time_full a u ud a -- n	( segment format position stream_time -- )
c-function gst_segment_to_stream_time gst_segment_to_stream_time a u ud -- ud	( segment format position -- )
c-function gst_segment_position_from_stream_time_full gst_segment_position_from_stream_time_full a u ud a -- n	( segment format stream_time position -- )
c-function gst_segment_position_from_stream_time gst_segment_position_from_stream_time a u ud -- ud	( segment format stream_time -- )
c-function gst_segment_to_running_time gst_segment_to_running_time a u ud -- ud	( segment format position -- )
c-function gst_segment_to_running_time_full gst_segment_to_running_time_full a u ud a -- n	( segment format position running_time -- )
c-function gst_segment_to_position gst_segment_to_position a u ud -- ud	( segment format running_time -- )
c-function gst_segment_position_from_running_time_full gst_segment_position_from_running_time_full a u ud a -- n	( segment format running_time position -- )
c-function gst_segment_position_from_running_time gst_segment_position_from_running_time a u ud -- ud	( segment format running_time -- )
c-function gst_segment_set_running_time gst_segment_set_running_time a u ud -- n	( segment format running_time -- )
c-function gst_segment_offset_running_time gst_segment_offset_running_time a u d -- n	( segment format offset -- )
c-function gst_segment_clip gst_segment_clip a u ud ud a a -- n	( segment format start stop clip_start clip_stop -- )
c-function gst_segment_do_seek gst_segment_do_seek a r u n n ud n ud a -- n	( segment rate format flags start_type start stop_type stop update -- )
c-function gst_segment_is_equal gst_segment_is_equal a a -- n	( s0 s1 -- )
c-function gst_structure_get_type gst_structure_get_type  -- u	( -- )
c-function gst_structure_new_empty gst_structure_new_empty s -- a	( name -- )
c-function gst_structure_new_id_empty gst_structure_new_id_empty n -- a	( quark -- )
c-function gst_structure_new gst_structure_new s s ... -- a	( name firstfield <noname> -- )
\ c-function gst_structure_new_valist gst_structure_new_valist s s a -- a	( name firstfield varargs -- )
c-function gst_structure_new_id gst_structure_new_id n n ... -- a	( name_quark field_quark <noname> -- )
c-function gst_structure_new_from_string gst_structure_new_from_string s -- a	( string -- )
c-function gst_structure_copy gst_structure_copy a -- a	( structure -- )
c-function gst_structure_set_parent_refcount gst_structure_set_parent_refcount a a -- n	( structure refcount -- )
c-function gst_structure_free gst_structure_free a -- void	( structure -- )
\ c-function gst_clear_structure gst_clear_structure a -- void	( structure_ptr -- )
c-function gst_structure_get_name gst_structure_get_name a -- s	( structure -- )
c-function gst_structure_get_name_id gst_structure_get_name_id a -- n	( structure -- )
c-function gst_structure_has_name gst_structure_has_name a s -- n	( structure name -- )
c-function gst_structure_set_name gst_structure_set_name a s -- void	( structure name -- )
c-function gst_structure_id_set_value gst_structure_id_set_value a n a -- void	( structure field value -- )
c-function gst_structure_set_value gst_structure_set_value a s a -- void	( structure fieldname value -- )
c-function gst_structure_set_array gst_structure_set_array a s a -- void	( structure fieldname array -- )
c-function gst_structure_set_list gst_structure_set_list a s a -- void	( structure fieldname array -- )
c-function gst_structure_id_take_value gst_structure_id_take_value a n a -- void	( structure field value -- )
c-function gst_structure_take_value gst_structure_take_value a s a -- void	( structure fieldname value -- )
c-function gst_structure_set gst_structure_set a s ... -- void	( structure fieldname <noname> -- )
\ c-function gst_structure_set_valist gst_structure_set_valist a s a -- void	( structure fieldname varargs -- )
c-function gst_structure_id_set gst_structure_id_set a n ... -- void	( structure fieldname <noname> -- )
\ c-function gst_structure_id_set_valist gst_structure_id_set_valist a n a -- void	( structure fieldname varargs -- )
\ c-function gst_structure_get_valist gst_structure_get_valist a s a -- n	( structure first_fieldname args -- )
c-function gst_structure_get gst_structure_get a s ... -- n	( structure first_fieldname <noname> -- )
\ c-function gst_structure_id_get_valist gst_structure_id_get_valist a n a -- n	( structure first_field_id args -- )
c-function gst_structure_id_get gst_structure_id_get a n ... -- n	( structure first_field_id <noname> -- )
c-function gst_structure_id_get_value gst_structure_id_get_value a n -- a	( structure field -- )
c-function gst_structure_get_value gst_structure_get_value a s -- a	( structure fieldname -- )
c-function gst_structure_remove_field gst_structure_remove_field a s -- void	( structure fieldname -- )
c-function gst_structure_remove_fields gst_structure_remove_fields a s ... -- void	( structure fieldname <noname> -- )
\ c-function gst_structure_remove_fields_valist gst_structure_remove_fields_valist a s a -- void	( structure fieldname varargs -- )
c-function gst_structure_remove_all_fields gst_structure_remove_all_fields a -- void	( structure -- )
c-function gst_structure_get_field_type gst_structure_get_field_type a s -- u	( structure fieldname -- )
c-function gst_structure_foreach gst_structure_foreach a a a -- n	( structure func user_data -- )
c-function gst_structure_map_in_place gst_structure_map_in_place a a a -- n	( structure func user_data -- )
c-function gst_structure_filter_and_map_in_place gst_structure_filter_and_map_in_place a a a -- void	( structure func user_data -- )
c-function gst_structure_n_fields gst_structure_n_fields a -- n	( structure -- )
c-function gst_structure_nth_field_name gst_structure_nth_field_name a u -- s	( structure index -- )
c-function gst_structure_id_has_field gst_structure_id_has_field a n -- n	( structure field -- )
c-function gst_structure_id_has_field_typed gst_structure_id_has_field_typed a n u -- n	( structure field type -- )
c-function gst_structure_has_field gst_structure_has_field a s -- n	( structure fieldname -- )
c-function gst_structure_has_field_typed gst_structure_has_field_typed a s u -- n	( structure fieldname type -- )
c-function gst_structure_get_boolean gst_structure_get_boolean a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_int gst_structure_get_int a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_uint gst_structure_get_uint a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_int64 gst_structure_get_int64 a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_uint64 gst_structure_get_uint64 a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_double gst_structure_get_double a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_date gst_structure_get_date a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_date_time gst_structure_get_date_time a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_clock_time gst_structure_get_clock_time a s a -- n	( structure fieldname value -- )
c-function gst_structure_get_string gst_structure_get_string a s -- s	( structure fieldname -- )
c-function gst_structure_get_enum gst_structure_get_enum a s u a -- n	( structure fieldname enumtype value -- )
c-function gst_structure_get_fraction gst_structure_get_fraction a s a a -- n	( structure fieldname value_numerator value_denominator -- )
c-function gst_structure_get_flagset gst_structure_get_flagset a s a a -- n	( structure fieldname value_flags value_mask -- )
c-function gst_structure_get_array gst_structure_get_array a s a -- n	( structure fieldname array -- )
c-function gst_structure_get_list gst_structure_get_list a s a -- n	( structure fieldname array -- )
c-function gst_structure_to_string gst_structure_to_string a -- a	( structure -- )
c-function gst_structure_from_string gst_structure_from_string s a -- a	( string end -- )
c-function gst_structure_fixate_field_nearest_int gst_structure_fixate_field_nearest_int a s n -- n	( structure field_name target -- )
c-function gst_structure_fixate_field_nearest_double gst_structure_fixate_field_nearest_double a s r -- n	( structure field_name target -- )
c-function gst_structure_fixate_field_boolean gst_structure_fixate_field_boolean a s n -- n	( structure field_name target -- )
c-function gst_structure_fixate_field_string gst_structure_fixate_field_string a s s -- n	( structure field_name target -- )
c-function gst_structure_fixate_field_nearest_fraction gst_structure_fixate_field_nearest_fraction a s n n -- n	( structure field_name target_numerator target_denominator -- )
c-function gst_structure_fixate_field gst_structure_fixate_field a s -- n	( structure field_name -- )
c-function gst_structure_fixate gst_structure_fixate a -- void	( structure -- )
c-function gst_structure_is_equal gst_structure_is_equal a a -- n	( structure1 structure2 -- )
c-function gst_structure_is_subset gst_structure_is_subset a a -- n	( subset superset -- )
c-function gst_structure_can_intersect gst_structure_can_intersect a a -- n	( struct1 struct2 -- )
c-function gst_structure_intersect gst_structure_intersect a a -- a	( struct1 struct2 -- )
c-function gst_system_clock_get_type gst_system_clock_get_type  -- u	( -- )
c-function gst_system_clock_obtain gst_system_clock_obtain  -- a	( -- )
c-function gst_system_clock_set_default gst_system_clock_set_default a -- void	( new_clock -- )
c-function gst_tag_list_get_type gst_tag_list_get_type  -- u	( -- )
c-function gst_tag_register gst_tag_register s n u s s a -- void	( name flag type nick blurb func -- )
c-function gst_tag_register_static gst_tag_register_static s n u s s a -- void	( name flag type nick blurb func -- )
c-function gst_tag_merge_use_first gst_tag_merge_use_first a a -- void	( dest src -- )
c-function gst_tag_merge_strings_with_comma gst_tag_merge_strings_with_comma a a -- void	( dest src -- )
c-function gst_tag_exists gst_tag_exists s -- n	( tag -- )
c-function gst_tag_get_type gst_tag_get_type s -- u	( tag -- )
c-function gst_tag_get_nick gst_tag_get_nick s -- s	( tag -- )
c-function gst_tag_get_description gst_tag_get_description s -- s	( tag -- )
c-function gst_tag_get_flag gst_tag_get_flag s -- n	( tag -- )
c-function gst_tag_is_fixed gst_tag_is_fixed s -- n	( tag -- )
c-function gst_tag_list_new_empty gst_tag_list_new_empty  -- a	( -- )
c-function gst_tag_list_new gst_tag_list_new s ... -- a	( tag <noname> -- )
\ c-function gst_tag_list_new_valist gst_tag_list_new_valist a -- a	( var_args -- )
c-function gst_tag_list_set_scope gst_tag_list_set_scope a n -- void	( list scope -- )
c-function gst_tag_list_get_scope gst_tag_list_get_scope a -- n	( list -- )
c-function gst_tag_list_to_string gst_tag_list_to_string a -- a	( list -- )
c-function gst_tag_list_new_from_string gst_tag_list_new_from_string s -- a	( str -- )
c-function gst_tag_list_n_tags gst_tag_list_n_tags a -- n	( list -- )
c-function gst_tag_list_nth_tag_name gst_tag_list_nth_tag_name a u -- s	( list index -- )
c-function gst_tag_list_is_empty gst_tag_list_is_empty a -- n	( list -- )
c-function gst_tag_list_is_equal gst_tag_list_is_equal a a -- n	( list1 list2 -- )
c-function gst_tag_list_insert gst_tag_list_insert a a n -- void	( into from mode -- )
c-function gst_tag_list_merge gst_tag_list_merge a a n -- a	( list1 list2 mode -- )
c-function gst_tag_list_get_tag_size gst_tag_list_get_tag_size a s -- u	( list tag -- )
c-function gst_tag_list_add gst_tag_list_add a n s ... -- void	( list mode tag <noname> -- )
c-function gst_tag_list_add_values gst_tag_list_add_values a n s ... -- void	( list mode tag <noname> -- )
\ c-function gst_tag_list_add_valist gst_tag_list_add_valist a n s a -- void	( list mode tag var_args -- )
\ c-function gst_tag_list_add_valist_values gst_tag_list_add_valist_values a n s a -- void	( list mode tag var_args -- )
c-function gst_tag_list_add_value gst_tag_list_add_value a n s a -- void	( list mode tag value -- )
c-function gst_tag_list_remove_tag gst_tag_list_remove_tag a s -- void	( list tag -- )
c-function gst_tag_list_foreach gst_tag_list_foreach a a a -- void	( list func user_data -- )
c-function gst_tag_list_get_value_index gst_tag_list_get_value_index a s u -- a	( list tag index -- )
c-function gst_tag_list_copy_value gst_tag_list_copy_value a a s -- n	( dest list tag -- )
c-function gst_tag_list_get_boolean gst_tag_list_get_boolean a s a -- n	( list tag value -- )
c-function gst_tag_list_get_boolean_index gst_tag_list_get_boolean_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_int gst_tag_list_get_int a s a -- n	( list tag value -- )
c-function gst_tag_list_get_int_index gst_tag_list_get_int_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_uint gst_tag_list_get_uint a s a -- n	( list tag value -- )
c-function gst_tag_list_get_uint_index gst_tag_list_get_uint_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_int64 gst_tag_list_get_int64 a s a -- n	( list tag value -- )
c-function gst_tag_list_get_int64_index gst_tag_list_get_int64_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_uint64 gst_tag_list_get_uint64 a s a -- n	( list tag value -- )
c-function gst_tag_list_get_uint64_index gst_tag_list_get_uint64_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_float gst_tag_list_get_float a s a -- n	( list tag value -- )
c-function gst_tag_list_get_float_index gst_tag_list_get_float_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_double gst_tag_list_get_double a s a -- n	( list tag value -- )
c-function gst_tag_list_get_double_index gst_tag_list_get_double_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_string gst_tag_list_get_string a s a -- n	( list tag value -- )
c-function gst_tag_list_get_string_index gst_tag_list_get_string_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_peek_string_index gst_tag_list_peek_string_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_pointer gst_tag_list_get_pointer a s a -- n	( list tag value -- )
c-function gst_tag_list_get_pointer_index gst_tag_list_get_pointer_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_date gst_tag_list_get_date a s a -- n	( list tag value -- )
c-function gst_tag_list_get_date_index gst_tag_list_get_date_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_date_time gst_tag_list_get_date_time a s a -- n	( list tag value -- )
c-function gst_tag_list_get_date_time_index gst_tag_list_get_date_time_index a s u a -- n	( list tag index value -- )
c-function gst_tag_list_get_sample gst_tag_list_get_sample a s a -- n	( list tag sample -- )
c-function gst_tag_list_get_sample_index gst_tag_list_get_sample_index a s u a -- n	( list tag index sample -- )
c-function gst_tag_list_ref gst_tag_list_ref a -- a	( taglist -- )
c-function gst_tag_list_unref gst_tag_list_unref a -- void	( taglist -- )
\ c-function gst_clear_tag_list gst_clear_tag_list a -- void	( taglist_ptr -- )
c-function gst_tag_list_copy gst_tag_list_copy a -- a	( taglist -- )
c-function gst_tag_list_replace gst_tag_list_replace a a -- n	( old_taglist new_taglist -- )
c-function gst_tag_list_take gst_tag_list_take a a -- n	( old_taglist new_taglist -- )
c-function gst_tag_setter_get_type gst_tag_setter_get_type  -- u	( -- )
c-function gst_tag_setter_reset_tags gst_tag_setter_reset_tags a -- void	( setter -- )
c-function gst_tag_setter_merge_tags gst_tag_setter_merge_tags a a n -- void	( setter list mode -- )
c-function gst_tag_setter_add_tags gst_tag_setter_add_tags a n s ... -- void	( setter mode tag <noname> -- )
c-function gst_tag_setter_add_tag_values gst_tag_setter_add_tag_values a n s ... -- void	( setter mode tag <noname> -- )
\ c-function gst_tag_setter_add_tag_valist gst_tag_setter_add_tag_valist a n s a -- void	( setter mode tag var_args -- )
\ c-function gst_tag_setter_add_tag_valist_values gst_tag_setter_add_tag_valist_values a n s a -- void	( setter mode tag var_args -- )
c-function gst_tag_setter_add_tag_value gst_tag_setter_add_tag_value a n s a -- void	( setter mode tag value -- )
c-function gst_tag_setter_get_tag_list gst_tag_setter_get_tag_list a -- a	( setter -- )
c-function gst_tag_setter_set_tag_merge_mode gst_tag_setter_set_tag_merge_mode a n -- void	( setter mode -- )
c-function gst_tag_setter_get_tag_merge_mode gst_tag_setter_get_tag_merge_mode a -- n	( setter -- )
c-function gst_task_cleanup_all gst_task_cleanup_all  -- void	( -- )
c-function gst_task_get_type gst_task_get_type  -- u	( -- )
c-function gst_task_new gst_task_new a a a -- a	( func user_data notify -- )
c-function gst_task_set_lock gst_task_set_lock a a -- void	( task mutex -- )
c-function gst_task_get_pool gst_task_get_pool a -- a	( task -- )
c-function gst_task_set_pool gst_task_set_pool a a -- void	( task pool -- )
c-function gst_task_set_enter_callback gst_task_set_enter_callback a a a a -- void	( task enter_func user_data notify -- )
c-function gst_task_set_leave_callback gst_task_set_leave_callback a a a a -- void	( task leave_func user_data notify -- )
c-function gst_task_get_state gst_task_get_state a -- n	( task -- )
c-function gst_task_set_state gst_task_set_state a n -- n	( task state -- )
c-function gst_task_start gst_task_start a -- n	( task -- )
c-function gst_task_stop gst_task_stop a -- n	( task -- )
c-function gst_task_pause gst_task_pause a -- n	( task -- )
c-function gst_task_join gst_task_join a -- n	( task -- )
c-function gst_task_pool_get_type gst_task_pool_get_type  -- u	( -- )
c-function gst_task_pool_new gst_task_pool_new  -- a	( -- )
c-function gst_task_pool_prepare gst_task_pool_prepare a a -- void	( pool error -- )
c-function gst_task_pool_push gst_task_pool_push a a a a -- a	( pool func user_data error -- )
c-function gst_task_pool_join gst_task_pool_join a a -- void	( pool id -- )
c-function gst_task_pool_cleanup gst_task_pool_cleanup a -- void	( pool -- )
c-function gst_toc_get_type gst_toc_get_type  -- u	( -- )
c-function gst_toc_entry_get_type gst_toc_entry_get_type  -- u	( -- )
c-function gst_toc_new gst_toc_new n -- a	( scope -- )
c-function gst_toc_get_scope gst_toc_get_scope a -- n	( toc -- )
c-function gst_toc_set_tags gst_toc_set_tags a a -- void	( toc tags -- )
c-function gst_toc_merge_tags gst_toc_merge_tags a a n -- void	( toc tags mode -- )
c-function gst_toc_get_tags gst_toc_get_tags a -- a	( toc -- )
c-function gst_toc_append_entry gst_toc_append_entry a a -- void	( toc entry -- )
c-function gst_toc_get_entries gst_toc_get_entries a -- a	( toc -- )
c-function gst_toc_dump gst_toc_dump a -- void	( toc -- )
c-function gst_toc_entry_new gst_toc_entry_new n s -- a	( type uid -- )
c-function gst_toc_find_entry gst_toc_find_entry a s -- a	( toc uid -- )
c-function gst_toc_entry_get_entry_type gst_toc_entry_get_entry_type a -- n	( entry -- )
c-function gst_toc_entry_get_uid gst_toc_entry_get_uid a -- s	( entry -- )
c-function gst_toc_entry_append_sub_entry gst_toc_entry_append_sub_entry a a -- void	( entry subentry -- )
c-function gst_toc_entry_get_sub_entries gst_toc_entry_get_sub_entries a -- a	( entry -- )
c-function gst_toc_entry_set_tags gst_toc_entry_set_tags a a -- void	( entry tags -- )
c-function gst_toc_entry_merge_tags gst_toc_entry_merge_tags a a n -- void	( entry tags mode -- )
c-function gst_toc_entry_get_tags gst_toc_entry_get_tags a -- a	( entry -- )
c-function gst_toc_entry_is_alternative gst_toc_entry_is_alternative a -- n	( entry -- )
c-function gst_toc_entry_is_sequence gst_toc_entry_is_sequence a -- n	( entry -- )
c-function gst_toc_entry_set_start_stop_times gst_toc_entry_set_start_stop_times a d d -- void	( entry start stop -- )
c-function gst_toc_entry_get_start_stop_times gst_toc_entry_get_start_stop_times a a a -- n	( entry start stop -- )
c-function gst_toc_entry_set_loop gst_toc_entry_set_loop a n n -- void	( entry loop_type repeat_count -- )
c-function gst_toc_entry_get_loop gst_toc_entry_get_loop a a a -- n	( entry loop_type repeat_count -- )
c-function gst_toc_entry_get_toc gst_toc_entry_get_toc a -- a	( entry -- )
c-function gst_toc_entry_get_parent gst_toc_entry_get_parent a -- a	( entry -- )
c-function gst_toc_entry_type_get_nick gst_toc_entry_type_get_nick n -- s	( type -- )
c-function gst_toc_setter_get_type gst_toc_setter_get_type  -- u	( -- )
c-function gst_toc_setter_reset gst_toc_setter_reset a -- void	( setter -- )
c-function gst_toc_setter_get_toc gst_toc_setter_get_toc a -- a	( setter -- )
c-function gst_toc_setter_set_toc gst_toc_setter_set_toc a a -- void	( setter toc -- )
c-function gst_type_find_get_type gst_type_find_get_type  -- u	( -- )
c-function gst_type_find_peek gst_type_find_peek a d u -- a	( find offset size -- )
c-function gst_type_find_suggest gst_type_find_suggest a u a -- void	( find probability caps -- )
c-function gst_type_find_suggest_simple gst_type_find_suggest_simple a u s s ... -- void	( find probability media_type fieldname <noname> -- )
c-function gst_type_find_get_length gst_type_find_get_length a -- ud	( find -- )
c-function gst_type_find_register gst_type_find_register a s u a s a a a -- n	( plugin name rank func extensions possible_caps data data_notify -- )
c-function gst_type_find_factory_get_type gst_type_find_factory_get_type  -- u	( -- )
c-function gst_type_find_factory_get_list gst_type_find_factory_get_list  -- a	( -- )
c-function gst_type_find_factory_get_extensions gst_type_find_factory_get_extensions a -- a	( factory -- )
c-function gst_type_find_factory_get_caps gst_type_find_factory_get_caps a -- a	( factory -- )
c-function gst_type_find_factory_has_function gst_type_find_factory_has_function a -- n	( factory -- )
c-function gst_type_find_factory_call_function gst_type_find_factory_call_function a a -- void	( factory find -- )
c-function gst_uri_error_quark gst_uri_error_quark  -- n	( -- )
c-function gst_uri_protocol_is_valid gst_uri_protocol_is_valid s -- n	( protocol -- )
c-function gst_uri_protocol_is_supported gst_uri_protocol_is_supported n s -- n	( type protocol -- )
c-function gst_uri_is_valid gst_uri_is_valid s -- n	( uri -- )
c-function gst_uri_get_protocol gst_uri_get_protocol s -- a	( uri -- )
c-function gst_uri_has_protocol gst_uri_has_protocol s s -- n	( uri protocol -- )
c-function gst_uri_get_location gst_uri_get_location s -- a	( uri -- )
c-function gst_uri_construct gst_uri_construct s s -- a	( protocol location -- )
c-function gst_filename_to_uri gst_filename_to_uri s a -- a	( filename error -- )
c-function gst_element_make_from_uri gst_element_make_from_uri n s s a -- a	( type uri elementname error -- )
c-function gst_uri_handler_get_type gst_uri_handler_get_type  -- u	( -- )
c-function gst_uri_handler_get_uri_type gst_uri_handler_get_uri_type a -- n	( handler -- )
c-function gst_uri_handler_get_protocols gst_uri_handler_get_protocols a -- a	( handler -- )
c-function gst_uri_handler_get_uri gst_uri_handler_get_uri a -- a	( handler -- )
c-function gst_uri_handler_set_uri gst_uri_handler_set_uri a s a -- n	( handler uri error -- )
c-function gst_uri_get_type gst_uri_get_type  -- u	( -- )
c-function gst_uri_new gst_uri_new s s s u s s s -- a	( scheme userinfo host port path query fragment -- )
c-function gst_uri_new_with_base gst_uri_new_with_base a s s s u s s s -- a	( base scheme userinfo host port path query fragment -- )
c-function gst_uri_from_string gst_uri_from_string s -- a	( uri -- )
c-function gst_uri_from_string_with_base gst_uri_from_string_with_base a s -- a	( base uri -- )
c-function gst_uri_equal gst_uri_equal a a -- n	( first second -- )
c-function gst_uri_join gst_uri_join a a -- a	( base_uri ref_uri -- )
c-function gst_uri_join_strings gst_uri_join_strings s s -- a	( base_uri ref_uri -- )
c-function gst_uri_is_writable gst_uri_is_writable a -- n	( uri -- )
c-function gst_uri_make_writable gst_uri_make_writable a -- a	( uri -- )
c-function gst_uri_to_string gst_uri_to_string a -- a	( uri -- )
c-function gst_uri_is_normalized gst_uri_is_normalized a -- n	( uri -- )
c-function gst_uri_normalize gst_uri_normalize a -- n	( uri -- )
c-function gst_uri_get_scheme gst_uri_get_scheme a -- s	( uri -- )
c-function gst_uri_set_scheme gst_uri_set_scheme a s -- n	( uri scheme -- )
c-function gst_uri_get_userinfo gst_uri_get_userinfo a -- s	( uri -- )
c-function gst_uri_set_userinfo gst_uri_set_userinfo a s -- n	( uri userinfo -- )
c-function gst_uri_get_host gst_uri_get_host a -- s	( uri -- )
c-function gst_uri_set_host gst_uri_set_host a s -- n	( uri host -- )
c-function gst_uri_get_port gst_uri_get_port a -- u	( uri -- )
c-function gst_uri_set_port gst_uri_set_port a u -- n	( uri port -- )
c-function gst_uri_get_path gst_uri_get_path a -- a	( uri -- )
c-function gst_uri_set_path gst_uri_set_path a s -- n	( uri path -- )
c-function gst_uri_get_path_string gst_uri_get_path_string a -- a	( uri -- )
c-function gst_uri_set_path_string gst_uri_set_path_string a s -- n	( uri path -- )
c-function gst_uri_get_path_segments gst_uri_get_path_segments a -- a	( uri -- )
c-function gst_uri_set_path_segments gst_uri_set_path_segments a a -- n	( uri path_segments -- )
c-function gst_uri_append_path gst_uri_append_path a s -- n	( uri relative_path -- )
c-function gst_uri_append_path_segment gst_uri_append_path_segment a s -- n	( uri path_segment -- )
c-function gst_uri_get_query_string gst_uri_get_query_string a -- a	( uri -- )
c-function gst_uri_set_query_string gst_uri_set_query_string a s -- n	( uri query -- )
c-function gst_uri_get_query_table gst_uri_get_query_table a -- a	( uri -- )
c-function gst_uri_set_query_table gst_uri_set_query_table a a -- n	( uri query_table -- )
c-function gst_uri_set_query_value gst_uri_set_query_value a s s -- n	( uri query_key query_value -- )
c-function gst_uri_remove_query_key gst_uri_remove_query_key a s -- n	( uri query_key -- )
c-function gst_uri_query_has_key gst_uri_query_has_key a s -- n	( uri query_key -- )
c-function gst_uri_get_query_value gst_uri_get_query_value a s -- s	( uri query_key -- )
c-function gst_uri_get_query_keys gst_uri_get_query_keys a -- a	( uri -- )
c-function gst_uri_get_fragment gst_uri_get_fragment a -- s	( uri -- )
c-function gst_uri_set_fragment gst_uri_set_fragment a s -- n	( uri fragment -- )
c-function gst_uri_get_media_fragment_table gst_uri_get_media_fragment_table a -- a	( uri -- )
c-function gst_uri_copy gst_uri_copy a -- a	( uri -- )
c-function gst_uri_ref gst_uri_ref a -- a	( uri -- )
c-function gst_uri_unref gst_uri_unref a -- void	( uri -- )
c-function gst_util_set_value_from_string gst_util_set_value_from_string a s -- void	( value value_str -- )
c-function gst_util_set_object_arg gst_util_set_object_arg a s s -- void	( object name value -- )
c-function gst_util_set_object_array gst_util_set_object_array a s a -- n	( object name array -- )
c-function gst_util_get_object_array gst_util_get_object_array a s a -- n	( object name array -- )
c-function gst_util_dump_mem gst_util_dump_mem a u -- void	( mem size -- )
c-function gst_util_dump_buffer gst_util_dump_buffer a -- void	( buf -- )
c-function gst_util_gdouble_to_guint64 gst_util_gdouble_to_guint64 r -- ud	( value -- )
c-function gst_util_guint64_to_gdouble gst_util_guint64_to_gdouble ud -- r	( value -- )
c-function gst_util_uint64_scale gst_util_uint64_scale ud ud ud -- ud	( val num denom -- )
c-function gst_util_uint64_scale_round gst_util_uint64_scale_round ud ud ud -- ud	( val num denom -- )
c-function gst_util_uint64_scale_ceil gst_util_uint64_scale_ceil ud ud ud -- ud	( val num denom -- )
c-function gst_util_uint64_scale_int gst_util_uint64_scale_int ud n n -- ud	( val num denom -- )
c-function gst_util_uint64_scale_int_round gst_util_uint64_scale_int_round ud n n -- ud	( val num denom -- )
c-function gst_util_uint64_scale_int_ceil gst_util_uint64_scale_int_ceil ud n n -- ud	( val num denom -- )
c-function gst_util_seqnum_next gst_util_seqnum_next  -- u	( -- )
c-function gst_util_seqnum_compare gst_util_seqnum_compare u u -- n	( s1 s2 -- )
c-function gst_util_group_id_next gst_util_group_id_next  -- u	( -- )
c-function __gst_slow_read64_be __gst_slow_read64_be a -- ud	( data -- )
c-function __gst_slow_read64_le __gst_slow_read64_le a -- ud	( data -- )
c-function __gst_slow_read32_be __gst_slow_read32_be a -- u	( data -- )
c-function __gst_slow_read32_le __gst_slow_read32_le a -- u	( data -- )
c-function __gst_slow_read24_be __gst_slow_read24_be a -- u	( data -- )
c-function __gst_slow_read24_le __gst_slow_read24_le a -- u	( data -- )
c-function __gst_slow_read16_be __gst_slow_read16_be a -- u	( data -- )
c-function __gst_slow_read16_le __gst_slow_read16_le a -- u	( data -- )
c-function GFLOAT_SWAP_LE_BE GFLOAT_SWAP_LE_BE r -- r	( in -- )
c-function GDOUBLE_SWAP_LE_BE GDOUBLE_SWAP_LE_BE r -- r	( in -- )
c-function GST_READ_FLOAT_LE GST_READ_FLOAT_LE a -- r	( data -- )
c-function GST_READ_FLOAT_BE GST_READ_FLOAT_BE a -- r	( data -- )
c-function GST_READ_DOUBLE_LE GST_READ_DOUBLE_LE a -- r	( data -- )
c-function GST_READ_DOUBLE_BE GST_READ_DOUBLE_BE a -- r	( data -- )
c-function GST_WRITE_FLOAT_LE GST_WRITE_FLOAT_LE a r -- void	( data num -- )
c-function GST_WRITE_FLOAT_BE GST_WRITE_FLOAT_BE a r -- void	( data num -- )
c-function GST_WRITE_DOUBLE_LE GST_WRITE_DOUBLE_LE a r -- void	( data num -- )
c-function GST_WRITE_DOUBLE_BE GST_WRITE_DOUBLE_BE a r -- void	( data num -- )
c-function gst_object_default_error gst_object_default_error a a s -- void	( source error debug -- )
c-function gst_element_create_all_pads gst_element_create_all_pads a -- void	( element -- )
c-function gst_element_get_compatible_pad gst_element_get_compatible_pad a a a -- a	( element pad caps -- )
c-function gst_element_get_compatible_pad_template gst_element_get_compatible_pad_template a a -- a	( element compattempl -- )
c-function gst_element_state_get_name gst_element_state_get_name n -- s	( state -- )
c-function gst_element_state_change_return_get_name gst_element_state_change_return_get_name n -- s	( state_ret -- )
c-function gst_state_change_get_name gst_state_change_get_name n -- s	( transition -- )
c-function gst_element_link gst_element_link a a -- n	( src dest -- )
c-function gst_element_link_many gst_element_link_many a a ... -- n	( element_1 element_2 <noname> -- )
c-function gst_element_link_filtered gst_element_link_filtered a a a -- n	( src dest filter -- )
c-function gst_element_unlink gst_element_unlink a a -- void	( src dest -- )
c-function gst_element_unlink_many gst_element_unlink_many a a ... -- void	( element_1 element_2 <noname> -- )
c-function gst_element_link_pads gst_element_link_pads a s a s -- n	( src srcpadname dest destpadname -- )
c-function gst_element_link_pads_full gst_element_link_pads_full a s a s n -- n	( src srcpadname dest destpadname flags -- )
c-function gst_element_unlink_pads gst_element_unlink_pads a s a s -- void	( src srcpadname dest destpadname -- )
c-function gst_element_link_pads_filtered gst_element_link_pads_filtered a s a s a -- n	( src srcpadname dest destpadname filter -- )
c-function gst_element_seek_simple gst_element_seek_simple a u n d -- n	( element format seek_flags seek_pos -- )
c-function gst_element_factory_can_sink_all_caps gst_element_factory_can_sink_all_caps a a -- n	( factory caps -- )
c-function gst_element_factory_can_src_all_caps gst_element_factory_can_src_all_caps a a -- n	( factory caps -- )
c-function gst_element_factory_can_sink_any_caps gst_element_factory_can_sink_any_caps a a -- n	( factory caps -- )
c-function gst_element_factory_can_src_any_caps gst_element_factory_can_src_any_caps a a -- n	( factory caps -- )
c-function gst_element_query_position gst_element_query_position a u a -- n	( element format cur -- )
c-function gst_element_query_duration gst_element_query_duration a u a -- n	( element format duration -- )
c-function gst_element_query_convert gst_element_query_convert a u d u a -- n	( element src_format src_val dest_format dest_val -- )
c-function gst_pad_use_fixed_caps gst_pad_use_fixed_caps a -- void	( pad -- )
c-function gst_pad_get_parent_element gst_pad_get_parent_element a -- a	( pad -- )
c-function gst_pad_proxy_query_accept_caps gst_pad_proxy_query_accept_caps a a -- n	( pad query -- )
c-function gst_pad_proxy_query_caps gst_pad_proxy_query_caps a a -- n	( pad query -- )
c-function gst_pad_query_position gst_pad_query_position a u a -- n	( pad format cur -- )
c-function gst_pad_query_duration gst_pad_query_duration a u a -- n	( pad format duration -- )
c-function gst_pad_query_convert gst_pad_query_convert a u d u a -- n	( pad src_format src_val dest_format dest_val -- )
c-function gst_pad_query_caps gst_pad_query_caps a a -- a	( pad filter -- )
c-function gst_pad_query_accept_caps gst_pad_query_accept_caps a a -- n	( pad caps -- )
c-function gst_pad_link_maybe_ghosting gst_pad_link_maybe_ghosting a a -- n	( src sink -- )
c-function gst_pad_link_maybe_ghosting_full gst_pad_link_maybe_ghosting_full a a n -- n	( src sink flags -- )
c-function gst_pad_peer_query_position gst_pad_peer_query_position a u a -- n	( pad format cur -- )
c-function gst_pad_peer_query_duration gst_pad_peer_query_duration a u a -- n	( pad format duration -- )
c-function gst_pad_peer_query_convert gst_pad_peer_query_convert a u d u a -- n	( pad src_format src_val dest_format dest_val -- )
c-function gst_pad_peer_query_caps gst_pad_peer_query_caps a a -- a	( pad filter -- )
c-function gst_pad_peer_query_accept_caps gst_pad_peer_query_accept_caps a a -- n	( pad caps -- )
c-function gst_pad_create_stream_id gst_pad_create_stream_id a a s -- a	( pad parent stream_id -- )
c-function gst_pad_create_stream_id_printf gst_pad_create_stream_id_printf a a s ... -- a	( pad parent stream_id <noname> -- )
\ c-function gst_pad_create_stream_id_printf_valist gst_pad_create_stream_id_printf_valist a a s a -- a	( pad parent stream_id var_args -- )
c-function gst_pad_get_stream_id gst_pad_get_stream_id a -- a	( pad -- )
c-function gst_pad_get_stream gst_pad_get_stream a -- a	( pad -- )
c-function gst_bin_add_many gst_bin_add_many a a ... -- void	( bin element_1 <noname> -- )
c-function gst_bin_remove_many gst_bin_remove_many a a ... -- void	( bin element_1 <noname> -- )
c-function gst_bin_find_unlinked_pad gst_bin_find_unlinked_pad a n -- a	( bin direction -- )
c-function gst_bin_sync_children_states gst_bin_sync_children_states a -- n	( bin -- )
c-function gst_parse_bin_from_description gst_parse_bin_from_description s n a -- a	( bin_description ghost_unlinked_pads err -- )
c-function gst_parse_bin_from_description_full gst_parse_bin_from_description_full s n a n a -- a	( bin_description ghost_unlinked_pads context flags err -- )
c-function gst_util_get_timestamp gst_util_get_timestamp  -- ud	( -- )
c-function gst_util_array_binary_search gst_util_array_binary_search a u u a n a a -- a	( array num_elements element_size search_func mode search_data user_data -- )
c-function gst_util_greatest_common_divisor gst_util_greatest_common_divisor n n -- n	( a b -- )
c-function gst_util_greatest_common_divisor_int64 gst_util_greatest_common_divisor_int64 d d -- d	( a b -- )
c-function gst_util_fraction_to_double gst_util_fraction_to_double n n a -- void	( src_n src_d dest -- )
c-function gst_util_double_to_fraction gst_util_double_to_fraction r a a -- void	( src dest_n dest_d -- )
c-function gst_util_fraction_multiply gst_util_fraction_multiply n n n n a a -- n	( a_n a_d b_n b_d res_n res_d -- )
c-function gst_util_fraction_add gst_util_fraction_add n n n n a a -- n	( a_n a_d b_n b_d res_n res_d -- )
c-function gst_util_fraction_compare gst_util_fraction_compare n n n n -- n	( a_n a_d b_n b_d -- )
c-function gst_calculate_linear_regression gst_calculate_linear_regression a a u a a a a a -- n	( xy temp n m_num m_denom b xbase r_squared -- )
c-function gst_int_range_get_type gst_int_range_get_type  -- u	( -- )
c-function gst_int64_range_get_type gst_int64_range_get_type  -- u	( -- )
c-function gst_double_range_get_type gst_double_range_get_type  -- u	( -- )
c-function gst_fraction_range_get_type gst_fraction_range_get_type  -- u	( -- )
c-function gst_fraction_get_type gst_fraction_get_type  -- u	( -- )
c-function gst_value_list_get_type gst_value_list_get_type  -- u	( -- )
c-function gst_value_array_get_type gst_value_array_get_type  -- u	( -- )
c-function gst_bitmask_get_type gst_bitmask_get_type  -- u	( -- )
c-function gst_flagset_get_type gst_flagset_get_type  -- u	( -- )
c-function gst_g_thread_get_type gst_g_thread_get_type  -- u	( -- )
c-function gst_value_register gst_value_register a -- void	( table -- )
c-function gst_value_init_and_copy gst_value_init_and_copy a a -- void	( dest src -- )
c-function gst_value_serialize gst_value_serialize a -- a	( value -- )
c-function gst_value_deserialize gst_value_deserialize a s -- n	( dest src -- )
c-function gst_value_list_append_value gst_value_list_append_value a a -- void	( value append_value -- )
c-function gst_value_list_append_and_take_value gst_value_list_append_and_take_value a a -- void	( value append_value -- )
c-function gst_value_list_prepend_value gst_value_list_prepend_value a a -- void	( value prepend_value -- )
c-function gst_value_list_concat gst_value_list_concat a a a -- void	( dest value1 value2 -- )
c-function gst_value_list_merge gst_value_list_merge a a a -- void	( dest value1 value2 -- )
c-function gst_value_list_get_size gst_value_list_get_size a -- u	( value -- )
c-function gst_value_list_get_value gst_value_list_get_value a u -- a	( value index -- )
c-function gst_value_array_append_value gst_value_array_append_value a a -- void	( value append_value -- )
c-function gst_value_array_append_and_take_value gst_value_array_append_and_take_value a a -- void	( value append_value -- )
c-function gst_value_array_prepend_value gst_value_array_prepend_value a a -- void	( value prepend_value -- )
c-function gst_value_array_get_size gst_value_array_get_size a -- u	( value -- )
c-function gst_value_array_get_value gst_value_array_get_value a u -- a	( value index -- )
c-function gst_value_set_int_range gst_value_set_int_range a n n -- void	( value start end -- )
c-function gst_value_set_int_range_step gst_value_set_int_range_step a n n n -- void	( value start end step -- )
c-function gst_value_get_int_range_min gst_value_get_int_range_min a -- n	( value -- )
c-function gst_value_get_int_range_max gst_value_get_int_range_max a -- n	( value -- )
c-function gst_value_get_int_range_step gst_value_get_int_range_step a -- n	( value -- )
c-function gst_value_set_int64_range gst_value_set_int64_range a d d -- void	( value start end -- )
c-function gst_value_set_int64_range_step gst_value_set_int64_range_step a d d d -- void	( value start end step -- )
c-function gst_value_get_int64_range_min gst_value_get_int64_range_min a -- d	( value -- )
c-function gst_value_get_int64_range_max gst_value_get_int64_range_max a -- d	( value -- )
c-function gst_value_get_int64_range_step gst_value_get_int64_range_step a -- d	( value -- )
c-function gst_value_set_double_range gst_value_set_double_range a r r -- void	( value start end -- )
c-function gst_value_get_double_range_min gst_value_get_double_range_min a -- r	( value -- )
c-function gst_value_get_double_range_max gst_value_get_double_range_max a -- r	( value -- )
c-function gst_value_get_caps gst_value_get_caps a -- a	( value -- )
c-function gst_value_set_caps gst_value_set_caps a a -- void	( value caps -- )
c-function gst_value_get_structure gst_value_get_structure a -- a	( value -- )
c-function gst_value_set_structure gst_value_set_structure a a -- void	( value structure -- )
c-function gst_value_get_caps_features gst_value_get_caps_features a -- a	( value -- )
c-function gst_value_set_caps_features gst_value_set_caps_features a a -- void	( value features -- )
c-function gst_value_set_fraction gst_value_set_fraction a n n -- void	( value numerator denominator -- )
c-function gst_value_get_fraction_numerator gst_value_get_fraction_numerator a -- n	( value -- )
c-function gst_value_get_fraction_denominator gst_value_get_fraction_denominator a -- n	( value -- )
c-function gst_value_fraction_multiply gst_value_fraction_multiply a a a -- n	( product factor1 factor2 -- )
c-function gst_value_fraction_subtract gst_value_fraction_subtract a a a -- n	( dest minuend subtrahend -- )
c-function gst_value_set_fraction_range gst_value_set_fraction_range a a a -- void	( value start end -- )
c-function gst_value_set_fraction_range_full gst_value_set_fraction_range_full a n n n n -- void	( value numerator_start denominator_start numerator_end denominator_end -- )
c-function gst_value_get_fraction_range_min gst_value_get_fraction_range_min a -- a	( value -- )
c-function gst_value_get_fraction_range_max gst_value_get_fraction_range_max a -- a	( value -- )
c-function gst_value_get_bitmask gst_value_get_bitmask a -- ud	( value -- )
c-function gst_value_set_bitmask gst_value_set_bitmask a ud -- void	( value bitmask -- )
c-function gst_value_set_flagset gst_value_set_flagset a u u -- void	( value flags mask -- )
c-function gst_value_get_flagset_flags gst_value_get_flagset_flags a -- u	( value -- )
c-function gst_value_get_flagset_mask gst_value_get_flagset_mask a -- u	( value -- )
c-function gst_value_compare gst_value_compare a a -- n	( value1 value2 -- )
c-function gst_value_can_compare gst_value_can_compare a a -- n	( value1 value2 -- )
c-function gst_value_is_subset gst_value_is_subset a a -- n	( value1 value2 -- )
c-function gst_value_union gst_value_union a a a -- n	( dest value1 value2 -- )
c-function gst_value_can_union gst_value_can_union a a -- n	( value1 value2 -- )
c-function gst_value_intersect gst_value_intersect a a a -- n	( dest value1 value2 -- )
c-function gst_value_can_intersect gst_value_can_intersect a a -- n	( value1 value2 -- )
c-function gst_value_subtract gst_value_subtract a a a -- n	( dest minuend subtrahend -- )
c-function gst_value_can_subtract gst_value_can_subtract a a -- n	( minuend subtrahend -- )
c-function gst_value_is_fixed gst_value_is_fixed a -- n	( value -- )
c-function gst_value_fixate gst_value_fixate a a -- n	( dest src -- )
c-function gst_flagset_register gst_flagset_register u -- u	( flags_type -- )
c-function gst_parse_error_quark gst_parse_error_quark  -- n	( -- )
c-function gst_parse_context_get_type gst_parse_context_get_type  -- u	( -- )
c-function gst_parse_context_new gst_parse_context_new  -- a	( -- )
c-function gst_parse_context_get_missing_elements gst_parse_context_get_missing_elements a -- a	( context -- )
c-function gst_parse_context_free gst_parse_context_free a -- void	( context -- )
c-function gst_parse_context_copy gst_parse_context_copy a -- a	( context -- )
c-function gst_parse_launch gst_parse_launch s a -- a	( pipeline_description error -- )
c-function gst_parse_launchv gst_parse_launchv a a -- a	( argv error -- )
c-function gst_parse_launch_full gst_parse_launch_full s a n a -- a	( pipeline_description context flags error -- )
c-function gst_parse_launchv_full gst_parse_launchv_full a a n a -- a	( argv context flags error -- )
c-function gst_gl_api_to_string gst_gl_api_to_string n -- a	( api -- )
c-function gst_gl_api_from_string gst_gl_api_from_string s -- n	( api_s -- )
c-function gst_gl_platform_to_string gst_gl_platform_to_string n -- a	( platform -- )
c-function gst_gl_platform_from_string gst_gl_platform_from_string s -- n	( platform_s -- )
c-function gst_gl_display_get_type gst_gl_display_get_type  -- u	( -- )
c-function gst_gl_display_new gst_gl_display_new  -- a	( -- )
c-function gst_gl_display_get_handle gst_gl_display_get_handle a -- u	( display -- )
c-function gst_gl_display_get_handle_type gst_gl_display_get_handle_type a -- n	( display -- )
c-function gst_gl_display_filter_gl_api gst_gl_display_filter_gl_api a n -- void	( display gl_api -- )
c-function gst_gl_display_get_gl_api gst_gl_display_get_gl_api a -- n	( display -- )
c-function gst_gl_display_get_gl_api_unlocked gst_gl_display_get_gl_api_unlocked a -- n	( display -- )
c-function gst_context_set_gl_display gst_context_set_gl_display a a -- void	( context display -- )
c-function gst_context_get_gl_display gst_context_get_gl_display a a -- n	( context display -- )
c-function gst_gl_display_create_context gst_gl_display_create_context a a a a -- n	( display other_context p_context error -- )
c-function gst_gl_display_get_gl_context_for_thread gst_gl_display_get_gl_context_for_thread a a -- a	( display thread -- )
c-function gst_gl_display_add_context gst_gl_display_add_context a a -- n	( display context -- )
c-function gst_gl_display_create_window gst_gl_display_create_window a -- a	( display -- )
c-function gst_gl_display_remove_window gst_gl_display_remove_window a a -- n	( display window -- )
c-function gst_gl_display_find_window gst_gl_display_find_window a a a -- a	( display data compare_func -- )
c-function gst_gl_context_get_type gst_gl_context_get_type  -- u	( -- )
c-function gst_gl_context_error_quark gst_gl_context_error_quark  -- n	( -- )
c-function gst_gl_context_new gst_gl_context_new a -- a	( display -- )
c-function gst_gl_context_new_wrapped gst_gl_context_new_wrapped a u n n -- a	( display handle context_type available_apis -- )
c-function gst_gl_context_activate gst_gl_context_activate a n -- n	( context activate -- )
c-function gst_gl_context_get_thread gst_gl_context_get_thread a -- a	( context -- )
c-function gst_gl_context_get_current gst_gl_context_get_current  -- a	( -- )
c-function gst_gl_context_get_display gst_gl_context_get_display a -- a	( context -- )
c-function gst_gl_context_get_proc_address gst_gl_context_get_proc_address a s -- a	( context name -- )
c-function gst_gl_context_get_gl_platform gst_gl_context_get_gl_platform a -- n	( context -- )
c-function gst_gl_context_get_gl_api gst_gl_context_get_gl_api a -- n	( context -- )
c-function gst_gl_context_get_gl_context gst_gl_context_get_gl_context a -- u	( context -- )
c-function gst_gl_context_can_share gst_gl_context_can_share a a -- n	( context other_context -- )
c-function gst_gl_context_swap_buffers gst_gl_context_swap_buffers a -- void	( context -- )
c-function gst_gl_context_create gst_gl_context_create a a a -- n	( context other_context error -- )
c-function gst_gl_context_destroy gst_gl_context_destroy a -- void	( context -- )
c-function gst_gl_context_default_get_proc_address gst_gl_context_default_get_proc_address n s -- a	( gl_api name -- )
c-function gst_gl_context_get_proc_address_with_platform gst_gl_context_get_proc_address_with_platform n n s -- a	( context_type gl_api name -- )
c-function gst_gl_context_set_window gst_gl_context_set_window a a -- n	( context window -- )
c-function gst_gl_context_get_window gst_gl_context_get_window a -- a	( context -- )
c-function gst_gl_context_get_gl_version gst_gl_context_get_gl_version a a a -- void	( context maj min -- )
c-function gst_gl_context_check_gl_version gst_gl_context_check_gl_version a n n n -- n	( context api maj min -- )
c-function gst_gl_context_check_feature gst_gl_context_check_feature a s -- n	( context feature -- )
c-function gst_gl_context_get_gl_platform_version gst_gl_context_get_gl_platform_version a a a -- void	( context major minor -- )
c-function gst_gl_context_get_current_gl_context gst_gl_context_get_current_gl_context n -- u	( context_type -- )
c-function gst_gl_context_get_current_gl_api gst_gl_context_get_current_gl_api n a a -- n	( platform major minor -- )
c-function gst_gl_context_is_shared gst_gl_context_is_shared a -- n	( context -- )
c-function gst_gl_context_set_shared_with gst_gl_context_set_shared_with a a -- void	( context share -- )
c-function gst_gl_context_fill_info gst_gl_context_fill_info a a -- n	( context error -- )
c-function gst_gl_context_thread_add gst_gl_context_thread_add a a a -- void	( context func data -- )
c-function gst_gl_check_extension gst_gl_check_extension s s -- n	( name ext -- )
c-function gst_gl_ensure_element_data gst_gl_ensure_element_data a a a -- n	( element display_ptr other_context_ptr -- )
c-function gst_gl_handle_set_context gst_gl_handle_set_context a a a a -- n	( element context display other_context -- )
c-function gst_gl_handle_context_query gst_gl_handle_context_query a a a a a -- n	( element query display context other_context -- )
c-function gst_gl_query_local_gl_context gst_gl_query_local_gl_context a n a -- n	( element direction context_ptr -- )
c-function gst_gl_element_propagate_display_context gst_gl_element_propagate_display_context a a -- void	( element display -- )
c-function gst_gl_get_plane_data_size gst_gl_get_plane_data_size a a u -- u	( info align plane -- )
c-function gst_gl_get_plane_start gst_gl_get_plane_start a a u -- u	( info valign plane -- )
c-function gst_gl_value_set_texture_target_from_mask gst_gl_value_set_texture_target_from_mask a u -- n	( value target_mask -- )
c-function gst_gl_value_set_texture_target gst_gl_value_set_texture_target a u -- n	( value target -- )
c-function gst_gl_value_get_texture_target_mask gst_gl_value_get_texture_target_mask a -- u	( value -- )
c-function gst_gl_window_get_type gst_gl_window_get_type  -- u	( -- )
c-function gst_gl_window_error_quark gst_gl_window_error_quark  -- n	( -- )
c-function gst_gl_window_new gst_gl_window_new a -- a	( display -- )
c-function gst_gl_window_set_draw_callback gst_gl_window_set_draw_callback a a a a -- void	( window callback data destroy_notify -- )
c-function gst_gl_window_set_resize_callback gst_gl_window_set_resize_callback a a a a -- void	( window callback data destroy_notify -- )
c-function gst_gl_window_set_close_callback gst_gl_window_set_close_callback a a a a -- void	( window callback data destroy_notify -- )
c-function gst_gl_window_set_window_handle gst_gl_window_set_window_handle a u -- void	( window handle -- )
c-function gst_gl_window_get_window_handle gst_gl_window_get_window_handle a -- u	( window -- )
c-function gst_gl_window_run gst_gl_window_run a -- void	( window -- )
c-function gst_gl_window_quit gst_gl_window_quit a -- void	( window -- )
c-function gst_gl_window_send_message gst_gl_window_send_message a a a -- void	( window callback data -- )
c-function gst_gl_window_send_message_async gst_gl_window_send_message_async a a a a -- void	( window callback data destroy -- )
c-function gst_gl_window_handle_events gst_gl_window_handle_events a n -- void	( window handle_events -- )
c-function gst_gl_window_send_key_event gst_gl_window_send_key_event a s s -- void	( window event_type key_str -- )
c-function gst_gl_window_send_mouse_event gst_gl_window_send_mouse_event a s n r r -- void	( window event_type button posx posy -- )
c-function gst_gl_window_queue_resize gst_gl_window_queue_resize a -- void	( window -- )
c-function gst_gl_window_draw gst_gl_window_draw a -- void	( window -- )
c-function gst_gl_window_show gst_gl_window_show a -- void	( window -- )
c-function gst_gl_window_set_preferred_size gst_gl_window_set_preferred_size a n n -- void	( window width height -- )
c-function gst_gl_window_get_surface_dimensions gst_gl_window_get_surface_dimensions a a a -- void	( window width height -- )
c-function gst_gl_window_set_render_rectangle gst_gl_window_set_render_rectangle a n n n n -- n	( window x y width height -- )
c-function gst_gl_window_controls_viewport gst_gl_window_controls_viewport a -- n	( window -- )
c-function gst_gl_window_resize gst_gl_window_resize a u u -- void	( window width height -- )
c-function gst_gl_window_get_context gst_gl_window_get_context a -- a	( window -- )
c-function gst_gl_window_get_display gst_gl_window_get_display a -- u	( window -- )
c-function gst_gl_shader_get_type gst_gl_shader_get_type  -- u	( -- )
c-function gst_gl_shader_new gst_gl_shader_new a -- a	( context -- )
c-function gst_gl_shader_new_with_stages gst_gl_shader_new_with_stages a a ... -- a	( context error <noname> -- )
c-function gst_gl_shader_new_link_with_stages gst_gl_shader_new_link_with_stages a a ... -- a	( context error <noname> -- )
c-function gst_gl_shader_new_default gst_gl_shader_new_default a a -- a	( context error -- )
c-function gst_gl_shader_attach gst_gl_shader_attach a a -- n	( shader stage -- )
c-function gst_gl_shader_attach_unlocked gst_gl_shader_attach_unlocked a a -- n	( shader stage -- )
c-function gst_gl_shader_detach gst_gl_shader_detach a a -- void	( shader stage -- )
c-function gst_gl_shader_detach_unlocked gst_gl_shader_detach_unlocked a a -- void	( shader stage -- )
c-function gst_gl_shader_compile_attach_stage gst_gl_shader_compile_attach_stage a a a -- n	( shader stage error -- )
c-function gst_gl_shader_link gst_gl_shader_link a a -- n	( shader error -- )
c-function gst_gl_shader_is_linked gst_gl_shader_is_linked a -- n	( shader -- )
c-function gst_gl_shader_get_program_handle gst_gl_shader_get_program_handle a -- n	( shader -- )
c-function gst_gl_shader_release gst_gl_shader_release a -- void	( shader -- )
c-function gst_gl_shader_release_unlocked gst_gl_shader_release_unlocked a -- void	( shader -- )
c-function gst_gl_shader_use gst_gl_shader_use a -- void	( shader -- )
c-function gst_gl_context_clear_shader gst_gl_context_clear_shader a -- void	( context -- )
c-function gst_gl_shader_set_uniform_1i gst_gl_shader_set_uniform_1i a s n -- void	( shader name value -- )
c-function gst_gl_shader_set_uniform_1iv gst_gl_shader_set_uniform_1iv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_1f gst_gl_shader_set_uniform_1f a s r -- void	( shader name value -- )
c-function gst_gl_shader_set_uniform_1fv gst_gl_shader_set_uniform_1fv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_2i gst_gl_shader_set_uniform_2i a s n n -- void	( shader name v0 v1 -- )
c-function gst_gl_shader_set_uniform_2iv gst_gl_shader_set_uniform_2iv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_2f gst_gl_shader_set_uniform_2f a s r r -- void	( shader name v0 v1 -- )
c-function gst_gl_shader_set_uniform_2fv gst_gl_shader_set_uniform_2fv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_3i gst_gl_shader_set_uniform_3i a s n n n -- void	( shader name v0 v1 v2 -- )
c-function gst_gl_shader_set_uniform_3iv gst_gl_shader_set_uniform_3iv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_3f gst_gl_shader_set_uniform_3f a s r r r -- void	( shader name v0 v1 v2 -- )
c-function gst_gl_shader_set_uniform_3fv gst_gl_shader_set_uniform_3fv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_4i gst_gl_shader_set_uniform_4i a s n n n n -- void	( shader name v0 v1 v2 v3 -- )
c-function gst_gl_shader_set_uniform_4iv gst_gl_shader_set_uniform_4iv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_4f gst_gl_shader_set_uniform_4f a s r r r r -- void	( shader name v0 v1 v2 v3 -- )
c-function gst_gl_shader_set_uniform_4fv gst_gl_shader_set_uniform_4fv a s u a -- void	( shader name count value -- )
c-function gst_gl_shader_set_uniform_matrix_2fv gst_gl_shader_set_uniform_matrix_2fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_3fv gst_gl_shader_set_uniform_matrix_3fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_4fv gst_gl_shader_set_uniform_matrix_4fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_2x3fv gst_gl_shader_set_uniform_matrix_2x3fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_2x4fv gst_gl_shader_set_uniform_matrix_2x4fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_3x2fv gst_gl_shader_set_uniform_matrix_3x2fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_3x4fv gst_gl_shader_set_uniform_matrix_3x4fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_4x2fv gst_gl_shader_set_uniform_matrix_4x2fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_set_uniform_matrix_4x3fv gst_gl_shader_set_uniform_matrix_4x3fv a s n n a -- void	( shader name count transpose value -- )
c-function gst_gl_shader_get_attribute_location gst_gl_shader_get_attribute_location a s -- n	( shader name -- )
c-function gst_gl_shader_bind_attribute_location gst_gl_shader_bind_attribute_location a u s -- void	( shader index name -- )
c-function gst_gl_shader_bind_frag_data_location gst_gl_shader_bind_frag_data_location a u s -- void	( shader index name -- )
c-function gst_gl_upload_get_type gst_gl_upload_get_type  -- u	( -- )
c-function gst_gl_upload_get_input_template_caps gst_gl_upload_get_input_template_caps  -- a	( -- )
c-function gst_gl_upload_new gst_gl_upload_new a -- a	( context -- )
c-function gst_gl_upload_set_context gst_gl_upload_set_context a a -- void	( upload context -- )
c-function gst_gl_upload_transform_caps gst_gl_upload_transform_caps a a n a a -- a	( upload context direction caps filter -- )
c-function gst_gl_upload_set_caps gst_gl_upload_set_caps a a a -- n	( upload in_caps out_caps -- )
c-function gst_gl_upload_get_caps gst_gl_upload_get_caps a a a -- void	( upload in_caps out_caps -- )
c-function gst_gl_upload_propose_allocation gst_gl_upload_propose_allocation a a a -- void	( upload decide_query query -- )
c-function gst_gl_upload_perform_with_buffer gst_gl_upload_perform_with_buffer a a a -- n	( upload buffer outbuf_ptr -- )
c-function gst_gl_memory_allocator_get_type gst_gl_memory_allocator_get_type  -- u	( -- )
c-function gst_gl_video_allocation_params_get_type gst_gl_video_allocation_params_get_type  -- u	( -- )
c-function gst_gl_video_allocation_params_init_full gst_gl_video_allocation_params_init_full a u u a a a a a u a u u a a a a -- n	( params struct_size alloc_flags copy free context alloc_params v_info plane valign target tex_format wrapped_data gl_handle user_data notify -- )
c-function gst_gl_video_allocation_params_new gst_gl_video_allocation_params_new a a a u a u u -- a	( context alloc_params v_info plane valign target tex_format -- )
c-function gst_gl_video_allocation_params_new_wrapped_data gst_gl_video_allocation_params_new_wrapped_data a a a u a u u a a a -- a	( context alloc_params v_info plane valign target tex_format wrapped_data user_data notify -- )
c-function gst_gl_video_allocation_params_new_wrapped_texture gst_gl_video_allocation_params_new_wrapped_texture a a a u a u u u a a -- a	( context alloc_params v_info plane valign target tex_format tex_id user_data notify -- )
c-function gst_gl_video_allocation_params_new_wrapped_gl_handle gst_gl_video_allocation_params_new_wrapped_gl_handle a a a u a u u a a a -- a	( context alloc_params v_info plane valign target tex_format gl_handle user_data notify -- )
c-function gst_gl_video_allocation_params_free_data gst_gl_video_allocation_params_free_data a -- void	( params -- )
c-function gst_gl_video_allocation_params_copy_data gst_gl_video_allocation_params_copy_data a a -- void	( src_vid dest_vid -- )
c-function gst_gl_memory_init_once gst_gl_memory_init_once  -- void	( -- )
c-function gst_is_gl_memory gst_is_gl_memory a -- n	( mem -- )
c-function gst_gl_memory_init gst_gl_memory_init a a a a u u a a u a a a -- void	( mem allocator parent context target tex_format params info plane valign user_data notify -- )
c-function gst_gl_memory_copy_into gst_gl_memory_copy_into a u u u n n -- n	( gl_mem tex_id target tex_format width height -- )
c-function gst_gl_memory_copy_teximage gst_gl_memory_copy_teximage a u u u n n -- n	( src tex_id out_target out_tex_format out_width out_height -- )
c-function gst_gl_memory_read_pixels gst_gl_memory_read_pixels a a -- n	( gl_mem read_pointer -- )
c-function gst_gl_memory_texsubimage gst_gl_memory_texsubimage a a -- void	( gl_mem read_pointer -- )
c-function gst_gl_memory_get_texture_width gst_gl_memory_get_texture_width a -- n	( gl_mem -- )
c-function gst_gl_memory_get_texture_height gst_gl_memory_get_texture_height a -- n	( gl_mem -- )
c-function gst_gl_memory_get_texture_format gst_gl_memory_get_texture_format a -- u	( gl_mem -- )
c-function gst_gl_memory_get_texture_target gst_gl_memory_get_texture_target a -- u	( gl_mem -- )
c-function gst_gl_memory_get_texture_id gst_gl_memory_get_texture_id a -- u	( gl_mem -- )
c-function gst_gl_memory_setup_buffer gst_gl_memory_setup_buffer a a a a a u -- n	( allocator buffer params tex_formats wrapped_data n_wrapped_pointers -- )
c-function gst_gl_memory_allocator_get_default gst_gl_memory_allocator_get_default a -- a	( context -- )
c-function gst_gl_buffer_pool_get_type gst_gl_buffer_pool_get_type  -- u	( -- )
c-function gst_gl_buffer_pool_new gst_gl_buffer_pool_new a -- a	( context -- )
c-function gst_buffer_pool_config_get_gl_allocation_params gst_buffer_pool_config_get_gl_allocation_params a -- a	( config -- )
c-function gst_buffer_pool_config_set_gl_allocation_params gst_buffer_pool_config_set_gl_allocation_params a a -- void	( config params -- )
c-function gst_gl_framebuffer_get_type gst_gl_framebuffer_get_type  -- u	( -- )
c-function gst_gl_framebuffer_new gst_gl_framebuffer_new a -- a	( context -- )
c-function gst_gl_framebuffer_new_with_default_depth gst_gl_framebuffer_new_with_default_depth a u u -- a	( context width height -- )
c-function gst_gl_framebuffer_get_id gst_gl_framebuffer_get_id a -- u	( fb -- )
c-function gst_gl_framebuffer_attach gst_gl_framebuffer_attach a u a -- void	( fb attachment_point mem -- )
c-function gst_gl_framebuffer_bind gst_gl_framebuffer_bind a -- void	( fb -- )
c-function gst_gl_context_clear_framebuffer gst_gl_context_clear_framebuffer a -- void	( context -- )
c-function gst_gl_framebuffer_get_effective_dimensions gst_gl_framebuffer_get_effective_dimensions a a a -- void	( fb width height -- )
c-function gst_gl_context_check_framebuffer_status gst_gl_context_check_framebuffer_status a u -- n	( context fbo_target -- )
c-function gst_gl_framebuffer_draw_to_texture gst_gl_framebuffer_draw_to_texture a a a a -- n	( fb mem func user_data -- )
c-function gst_gl_filter_get_type gst_gl_filter_get_type  -- u	( -- )
c-function gst_gl_filter_add_rgba_pad_templates gst_gl_filter_add_rgba_pad_templates a -- void	( klass -- )
c-function gst_gl_filter_filter_texture gst_gl_filter_filter_texture a a a -- n	( filter inbuf outbuf -- )
c-function gst_gl_filter_render_to_target gst_gl_filter_render_to_target a a a a a -- n	( filter input output func data -- )
c-function gst_gl_filter_draw_fullscreen_quad gst_gl_filter_draw_fullscreen_quad a -- void	( filter -- )
c-function gst_gl_filter_render_to_target_with_shader gst_gl_filter_render_to_target_with_shader a a a a -- void	( filter input output shader -- )
c-function gst_gl_sync_meta_api_get_type gst_gl_sync_meta_api_get_type  -- u	( -- )
c-function gst_gl_sync_meta_get_info gst_gl_sync_meta_get_info  -- a	( -- )
c-function gst_buffer_add_gl_sync_meta gst_buffer_add_gl_sync_meta a a -- a	( context buffer -- )
c-function gst_buffer_add_gl_sync_meta_full gst_buffer_add_gl_sync_meta_full a a a -- a	( context buffer data -- )
c-function gst_gl_sync_meta_set_sync_point gst_gl_sync_meta_set_sync_point a a -- void	( sync_meta context -- )
c-function gst_gl_sync_meta_wait gst_gl_sync_meta_wait a a -- void	( sync_meta context -- )
c-function gst_gl_sync_meta_wait_cpu gst_gl_sync_meta_wait_cpu a a -- void	( sync_meta context -- )
c-function gst_gl_display_egl_get_type gst_gl_display_egl_get_type  -- u	( -- )
c-function gst_gl_display_egl_new gst_gl_display_egl_new  -- a	( -- )
c-function gst_gl_display_egl_new_with_egl_display gst_gl_display_egl_new_with_egl_display a -- a	( display -- )
c-function gst_gl_display_egl_from_gl_display gst_gl_display_egl_from_gl_display a -- a	( display -- )
c-function gst_gl_display_egl_get_from_native gst_gl_display_egl_get_from_native n u -- a	( type display -- )
c-function gst_gl_display_x11_get_type gst_gl_display_x11_get_type  -- u	( -- )
c-function gst_gl_display_x11_new gst_gl_display_x11_new s -- a	( name -- )
c-function gst_gl_display_x11_new_with_display gst_gl_display_x11_new_with_display a -- a	( display -- )

\ ----===< postfix >===-----
2 to callback#
end-c-library
