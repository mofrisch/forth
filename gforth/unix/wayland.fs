\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< int constants >===-----
#0	constant WL_DISPLAY_SYNC
#1	constant WL_DISPLAY_GET_REGISTRY
#1	constant WL_DISPLAY_ERROR_SINCE_VERSION
#1	constant WL_DISPLAY_DELETE_ID_SINCE_VERSION
#1	constant WL_DISPLAY_SYNC_SINCE_VERSION
#1	constant WL_DISPLAY_GET_REGISTRY_SINCE_VERSION
#0	constant WL_REGISTRY_BIND
#1	constant WL_REGISTRY_GLOBAL_SINCE_VERSION
#1	constant WL_REGISTRY_GLOBAL_REMOVE_SINCE_VERSION
#1	constant WL_REGISTRY_BIND_SINCE_VERSION
#1	constant WL_CALLBACK_DONE_SINCE_VERSION
#0	constant WL_COMPOSITOR_CREATE_SURFACE
#1	constant WL_COMPOSITOR_CREATE_REGION
#1	constant WL_COMPOSITOR_CREATE_SURFACE_SINCE_VERSION
#1	constant WL_COMPOSITOR_CREATE_REGION_SINCE_VERSION
#0	constant WL_SHM_POOL_CREATE_BUFFER
#1	constant WL_SHM_POOL_DESTROY
#2	constant WL_SHM_POOL_RESIZE
#1	constant WL_SHM_POOL_CREATE_BUFFER_SINCE_VERSION
#1	constant WL_SHM_POOL_DESTROY_SINCE_VERSION
#1	constant WL_SHM_POOL_RESIZE_SINCE_VERSION
#0	constant WL_SHM_CREATE_POOL
#1	constant WL_SHM_FORMAT_SINCE_VERSION
#1	constant WL_SHM_CREATE_POOL_SINCE_VERSION
#0	constant WL_BUFFER_DESTROY
#1	constant WL_BUFFER_RELEASE_SINCE_VERSION
#1	constant WL_BUFFER_DESTROY_SINCE_VERSION
#0	constant WL_DATA_OFFER_ACCEPT
#1	constant WL_DATA_OFFER_RECEIVE
#2	constant WL_DATA_OFFER_DESTROY
#3	constant WL_DATA_OFFER_FINISH
#4	constant WL_DATA_OFFER_SET_ACTIONS
#1	constant WL_DATA_OFFER_OFFER_SINCE_VERSION
#3	constant WL_DATA_OFFER_SOURCE_ACTIONS_SINCE_VERSION
#3	constant WL_DATA_OFFER_ACTION_SINCE_VERSION
#1	constant WL_DATA_OFFER_ACCEPT_SINCE_VERSION
#1	constant WL_DATA_OFFER_RECEIVE_SINCE_VERSION
#1	constant WL_DATA_OFFER_DESTROY_SINCE_VERSION
#3	constant WL_DATA_OFFER_FINISH_SINCE_VERSION
#3	constant WL_DATA_OFFER_SET_ACTIONS_SINCE_VERSION
#0	constant WL_DATA_SOURCE_OFFER
#1	constant WL_DATA_SOURCE_DESTROY
#2	constant WL_DATA_SOURCE_SET_ACTIONS
#1	constant WL_DATA_SOURCE_TARGET_SINCE_VERSION
#1	constant WL_DATA_SOURCE_SEND_SINCE_VERSION
#1	constant WL_DATA_SOURCE_CANCELLED_SINCE_VERSION
#3	constant WL_DATA_SOURCE_DND_DROP_PERFORMED_SINCE_VERSION
#3	constant WL_DATA_SOURCE_DND_FINISHED_SINCE_VERSION
#3	constant WL_DATA_SOURCE_ACTION_SINCE_VERSION
#1	constant WL_DATA_SOURCE_OFFER_SINCE_VERSION
#1	constant WL_DATA_SOURCE_DESTROY_SINCE_VERSION
#3	constant WL_DATA_SOURCE_SET_ACTIONS_SINCE_VERSION
#0	constant WL_DATA_DEVICE_START_DRAG
#1	constant WL_DATA_DEVICE_SET_SELECTION
#2	constant WL_DATA_DEVICE_RELEASE
#1	constant WL_DATA_DEVICE_DATA_OFFER_SINCE_VERSION
#1	constant WL_DATA_DEVICE_ENTER_SINCE_VERSION
#1	constant WL_DATA_DEVICE_LEAVE_SINCE_VERSION
#1	constant WL_DATA_DEVICE_MOTION_SINCE_VERSION
#1	constant WL_DATA_DEVICE_DROP_SINCE_VERSION
#1	constant WL_DATA_DEVICE_SELECTION_SINCE_VERSION
#1	constant WL_DATA_DEVICE_START_DRAG_SINCE_VERSION
#1	constant WL_DATA_DEVICE_SET_SELECTION_SINCE_VERSION
#2	constant WL_DATA_DEVICE_RELEASE_SINCE_VERSION
#0	constant WL_DATA_DEVICE_MANAGER_CREATE_DATA_SOURCE
#1	constant WL_DATA_DEVICE_MANAGER_GET_DATA_DEVICE
#1	constant WL_DATA_DEVICE_MANAGER_CREATE_DATA_SOURCE_SINCE_VERSION
#1	constant WL_DATA_DEVICE_MANAGER_GET_DATA_DEVICE_SINCE_VERSION
#0	constant WL_SHELL_GET_SHELL_SURFACE
#1	constant WL_SHELL_GET_SHELL_SURFACE_SINCE_VERSION
#0	constant WL_SHELL_SURFACE_PONG
#1	constant WL_SHELL_SURFACE_MOVE
#2	constant WL_SHELL_SURFACE_RESIZE
#3	constant WL_SHELL_SURFACE_SET_TOPLEVEL
#4	constant WL_SHELL_SURFACE_SET_TRANSIENT
#5	constant WL_SHELL_SURFACE_SET_FULLSCREEN
#6	constant WL_SHELL_SURFACE_SET_POPUP
#7	constant WL_SHELL_SURFACE_SET_MAXIMIZED
#8	constant WL_SHELL_SURFACE_SET_TITLE
#9	constant WL_SHELL_SURFACE_SET_CLASS
#1	constant WL_SHELL_SURFACE_PING_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_CONFIGURE_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_POPUP_DONE_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_PONG_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_MOVE_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_RESIZE_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_TOPLEVEL_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_TRANSIENT_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_FULLSCREEN_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_POPUP_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_MAXIMIZED_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_TITLE_SINCE_VERSION
#1	constant WL_SHELL_SURFACE_SET_CLASS_SINCE_VERSION
#0	constant WL_SURFACE_DESTROY
#1	constant WL_SURFACE_ATTACH
#2	constant WL_SURFACE_DAMAGE
#3	constant WL_SURFACE_FRAME
#4	constant WL_SURFACE_SET_OPAQUE_REGION
#5	constant WL_SURFACE_SET_INPUT_REGION
#6	constant WL_SURFACE_COMMIT
#7	constant WL_SURFACE_SET_BUFFER_TRANSFORM
#8	constant WL_SURFACE_SET_BUFFER_SCALE
#9	constant WL_SURFACE_DAMAGE_BUFFER
#1	constant WL_SURFACE_ENTER_SINCE_VERSION
#1	constant WL_SURFACE_LEAVE_SINCE_VERSION
#1	constant WL_SURFACE_DESTROY_SINCE_VERSION
#1	constant WL_SURFACE_ATTACH_SINCE_VERSION
#1	constant WL_SURFACE_DAMAGE_SINCE_VERSION
#1	constant WL_SURFACE_FRAME_SINCE_VERSION
#1	constant WL_SURFACE_SET_OPAQUE_REGION_SINCE_VERSION
#1	constant WL_SURFACE_SET_INPUT_REGION_SINCE_VERSION
#1	constant WL_SURFACE_COMMIT_SINCE_VERSION
#2	constant WL_SURFACE_SET_BUFFER_TRANSFORM_SINCE_VERSION
#3	constant WL_SURFACE_SET_BUFFER_SCALE_SINCE_VERSION
#4	constant WL_SURFACE_DAMAGE_BUFFER_SINCE_VERSION
#0	constant WL_SEAT_GET_POINTER
#1	constant WL_SEAT_GET_KEYBOARD
#2	constant WL_SEAT_GET_TOUCH
#3	constant WL_SEAT_RELEASE
#1	constant WL_SEAT_CAPABILITIES_SINCE_VERSION
#2	constant WL_SEAT_NAME_SINCE_VERSION
#1	constant WL_SEAT_GET_POINTER_SINCE_VERSION
#1	constant WL_SEAT_GET_KEYBOARD_SINCE_VERSION
#1	constant WL_SEAT_GET_TOUCH_SINCE_VERSION
#5	constant WL_SEAT_RELEASE_SINCE_VERSION
#6	constant WL_POINTER_AXIS_SOURCE_WHEEL_TILT_SINCE_VERSION
#0	constant WL_POINTER_SET_CURSOR
#1	constant WL_POINTER_RELEASE
#1	constant WL_POINTER_ENTER_SINCE_VERSION
#1	constant WL_POINTER_LEAVE_SINCE_VERSION
#1	constant WL_POINTER_MOTION_SINCE_VERSION
#1	constant WL_POINTER_BUTTON_SINCE_VERSION
#1	constant WL_POINTER_AXIS_SINCE_VERSION
#5	constant WL_POINTER_FRAME_SINCE_VERSION
#5	constant WL_POINTER_AXIS_SOURCE_SINCE_VERSION
#5	constant WL_POINTER_AXIS_STOP_SINCE_VERSION
#5	constant WL_POINTER_AXIS_DISCRETE_SINCE_VERSION
#1	constant WL_POINTER_SET_CURSOR_SINCE_VERSION
#3	constant WL_POINTER_RELEASE_SINCE_VERSION
#0	constant WL_KEYBOARD_RELEASE
#1	constant WL_KEYBOARD_KEYMAP_SINCE_VERSION
#1	constant WL_KEYBOARD_ENTER_SINCE_VERSION
#1	constant WL_KEYBOARD_LEAVE_SINCE_VERSION
#1	constant WL_KEYBOARD_KEY_SINCE_VERSION
#1	constant WL_KEYBOARD_MODIFIERS_SINCE_VERSION
#4	constant WL_KEYBOARD_REPEAT_INFO_SINCE_VERSION
#3	constant WL_KEYBOARD_RELEASE_SINCE_VERSION
#0	constant WL_TOUCH_RELEASE
#1	constant WL_TOUCH_DOWN_SINCE_VERSION
#1	constant WL_TOUCH_UP_SINCE_VERSION
#1	constant WL_TOUCH_MOTION_SINCE_VERSION
#1	constant WL_TOUCH_FRAME_SINCE_VERSION
#1	constant WL_TOUCH_CANCEL_SINCE_VERSION
#6	constant WL_TOUCH_SHAPE_SINCE_VERSION
#6	constant WL_TOUCH_ORIENTATION_SINCE_VERSION
#3	constant WL_TOUCH_RELEASE_SINCE_VERSION
#0	constant WL_OUTPUT_RELEASE
#1	constant WL_OUTPUT_GEOMETRY_SINCE_VERSION
#1	constant WL_OUTPUT_MODE_SINCE_VERSION
#2	constant WL_OUTPUT_DONE_SINCE_VERSION
#2	constant WL_OUTPUT_SCALE_SINCE_VERSION
#3	constant WL_OUTPUT_RELEASE_SINCE_VERSION
#0	constant WL_REGION_DESTROY
#1	constant WL_REGION_ADD
#2	constant WL_REGION_SUBTRACT
#1	constant WL_REGION_DESTROY_SINCE_VERSION
#1	constant WL_REGION_ADD_SINCE_VERSION
#1	constant WL_REGION_SUBTRACT_SINCE_VERSION
#0	constant WL_SUBCOMPOSITOR_DESTROY
#1	constant WL_SUBCOMPOSITOR_GET_SUBSURFACE
#1	constant WL_SUBCOMPOSITOR_DESTROY_SINCE_VERSION
#1	constant WL_SUBCOMPOSITOR_GET_SUBSURFACE_SINCE_VERSION
#0	constant WL_SUBSURFACE_DESTROY
#1	constant WL_SUBSURFACE_SET_POSITION
#2	constant WL_SUBSURFACE_PLACE_ABOVE
#3	constant WL_SUBSURFACE_PLACE_BELOW
#4	constant WL_SUBSURFACE_SET_SYNC
#5	constant WL_SUBSURFACE_SET_DESYNC
#1	constant WL_SUBSURFACE_DESTROY_SINCE_VERSION
#1	constant WL_SUBSURFACE_SET_POSITION_SINCE_VERSION
#1	constant WL_SUBSURFACE_PLACE_ABOVE_SINCE_VERSION
#1	constant WL_SUBSURFACE_PLACE_BELOW_SINCE_VERSION
#1	constant WL_SUBSURFACE_SET_SYNC_SINCE_VERSION
#1	constant WL_SUBSURFACE_SET_DESYNC_SINCE_VERSION
#1	constant WL_EGL_PLATFORM

\ --------===< enums >===---------
#0	constant WL_DISPLAY_ERROR_INVALID_OBJECT
#1	constant WL_DISPLAY_ERROR_INVALID_METHOD
#2	constant WL_DISPLAY_ERROR_NO_MEMORY
#3	constant WL_DISPLAY_ERROR_IMPLEMENTATION
#0	constant WL_SHM_ERROR_INVALID_FORMAT
#1	constant WL_SHM_ERROR_INVALID_STRIDE
#2	constant WL_SHM_ERROR_INVALID_FD
#0	constant WL_SHM_FORMAT_ARGB8888
#1	constant WL_SHM_FORMAT_XRGB8888
#538982467	constant WL_SHM_FORMAT_C8
#943867730	constant WL_SHM_FORMAT_RGB332
#944916290	constant WL_SHM_FORMAT_BGR233
#842093144	constant WL_SHM_FORMAT_XRGB4444
#842089048	constant WL_SHM_FORMAT_XBGR4444
#842094674	constant WL_SHM_FORMAT_RGBX4444
#842094658	constant WL_SHM_FORMAT_BGRX4444
#842093121	constant WL_SHM_FORMAT_ARGB4444
#842089025	constant WL_SHM_FORMAT_ABGR4444
#842088786	constant WL_SHM_FORMAT_RGBA4444
#842088770	constant WL_SHM_FORMAT_BGRA4444
#892424792	constant WL_SHM_FORMAT_XRGB1555
#892420696	constant WL_SHM_FORMAT_XBGR1555
#892426322	constant WL_SHM_FORMAT_RGBX5551
#892426306	constant WL_SHM_FORMAT_BGRX5551
#892424769	constant WL_SHM_FORMAT_ARGB1555
#892420673	constant WL_SHM_FORMAT_ABGR1555
#892420434	constant WL_SHM_FORMAT_RGBA5551
#892420418	constant WL_SHM_FORMAT_BGRA5551
#909199186	constant WL_SHM_FORMAT_RGB565
#909199170	constant WL_SHM_FORMAT_BGR565
#875710290	constant WL_SHM_FORMAT_RGB888
#875710274	constant WL_SHM_FORMAT_BGR888
#875709016	constant WL_SHM_FORMAT_XBGR8888
#875714642	constant WL_SHM_FORMAT_RGBX8888
#875714626	constant WL_SHM_FORMAT_BGRX8888
#875708993	constant WL_SHM_FORMAT_ABGR8888
#875708754	constant WL_SHM_FORMAT_RGBA8888
#875708738	constant WL_SHM_FORMAT_BGRA8888
#808669784	constant WL_SHM_FORMAT_XRGB2101010
#808665688	constant WL_SHM_FORMAT_XBGR2101010
#808671314	constant WL_SHM_FORMAT_RGBX1010102
#808671298	constant WL_SHM_FORMAT_BGRX1010102
#808669761	constant WL_SHM_FORMAT_ARGB2101010
#808665665	constant WL_SHM_FORMAT_ABGR2101010
#808665426	constant WL_SHM_FORMAT_RGBA1010102
#808665410	constant WL_SHM_FORMAT_BGRA1010102
#1448695129	constant WL_SHM_FORMAT_YUYV
#1431918169	constant WL_SHM_FORMAT_YVYU
#1498831189	constant WL_SHM_FORMAT_UYVY
#1498765654	constant WL_SHM_FORMAT_VYUY
#1448433985	constant WL_SHM_FORMAT_AYUV
#842094158	constant WL_SHM_FORMAT_NV12
#825382478	constant WL_SHM_FORMAT_NV21
#909203022	constant WL_SHM_FORMAT_NV16
#825644622	constant WL_SHM_FORMAT_NV61
#961959257	constant WL_SHM_FORMAT_YUV410
#961893977	constant WL_SHM_FORMAT_YVU410
#825316697	constant WL_SHM_FORMAT_YUV411
#825316953	constant WL_SHM_FORMAT_YVU411
#842093913	constant WL_SHM_FORMAT_YUV420
#842094169	constant WL_SHM_FORMAT_YVU420
#909202777	constant WL_SHM_FORMAT_YUV422
#909203033	constant WL_SHM_FORMAT_YVU422
#875713881	constant WL_SHM_FORMAT_YUV444
#875714137	constant WL_SHM_FORMAT_YVU444
#538982482	constant WL_SHM_FORMAT_R8
#540422482	constant WL_SHM_FORMAT_R16
#943212370	constant WL_SHM_FORMAT_RG88
#943215175	constant WL_SHM_FORMAT_GR88
#842221394	constant WL_SHM_FORMAT_RG1616
#842224199	constant WL_SHM_FORMAT_GR1616
#1211388504	constant WL_SHM_FORMAT_XRGB16161616F
#1211384408	constant WL_SHM_FORMAT_XBGR16161616F
#1211388481	constant WL_SHM_FORMAT_ARGB16161616F
#1211384385	constant WL_SHM_FORMAT_ABGR16161616F
#1448434008	constant WL_SHM_FORMAT_XYUV8888
#875713878	constant WL_SHM_FORMAT_VUY888
#808670550	constant WL_SHM_FORMAT_VUY101010
#808530521	constant WL_SHM_FORMAT_Y210
#842084953	constant WL_SHM_FORMAT_Y212
#909193817	constant WL_SHM_FORMAT_Y216
#808531033	constant WL_SHM_FORMAT_Y410
#842085465	constant WL_SHM_FORMAT_Y412
#909194329	constant WL_SHM_FORMAT_Y416
#808670808	constant WL_SHM_FORMAT_XVYU2101010
#909334104	constant WL_SHM_FORMAT_XVYU12_16161616
#942954072	constant WL_SHM_FORMAT_XVYU16161616
#810299481	constant WL_SHM_FORMAT_Y0L0
#810299480	constant WL_SHM_FORMAT_X0L0
#843853913	constant WL_SHM_FORMAT_Y0L2
#843853912	constant WL_SHM_FORMAT_X0L2
#942691673	constant WL_SHM_FORMAT_YUV420_8BIT
#808539481	constant WL_SHM_FORMAT_YUV420_10BIT
#943805016	constant WL_SHM_FORMAT_XRGB8888_A8
#943800920	constant WL_SHM_FORMAT_XBGR8888_A8
#943806546	constant WL_SHM_FORMAT_RGBX8888_A8
#943806530	constant WL_SHM_FORMAT_BGRX8888_A8
#943798354	constant WL_SHM_FORMAT_RGB888_A8
#943798338	constant WL_SHM_FORMAT_BGR888_A8
#943797586	constant WL_SHM_FORMAT_RGB565_A8
#943797570	constant WL_SHM_FORMAT_BGR565_A8
#875714126	constant WL_SHM_FORMAT_NV24
#842290766	constant WL_SHM_FORMAT_NV42
#808530512	constant WL_SHM_FORMAT_P210
#808530000	constant WL_SHM_FORMAT_P010
#842084432	constant WL_SHM_FORMAT_P012
#909193296	constant WL_SHM_FORMAT_P016
#0	constant WL_DATA_OFFER_ERROR_INVALID_FINISH
#1	constant WL_DATA_OFFER_ERROR_INVALID_ACTION_MASK
#2	constant WL_DATA_OFFER_ERROR_INVALID_ACTION
#3	constant WL_DATA_OFFER_ERROR_INVALID_OFFER
#0	constant WL_DATA_SOURCE_ERROR_INVALID_ACTION_MASK
#1	constant WL_DATA_SOURCE_ERROR_INVALID_SOURCE
#0	constant WL_DATA_DEVICE_ERROR_ROLE
#0	constant WL_DATA_DEVICE_MANAGER_DND_ACTION_NONE
#1	constant WL_DATA_DEVICE_MANAGER_DND_ACTION_COPY
#2	constant WL_DATA_DEVICE_MANAGER_DND_ACTION_MOVE
#4	constant WL_DATA_DEVICE_MANAGER_DND_ACTION_ASK
#0	constant WL_SHELL_ERROR_ROLE
#0	constant WL_SHELL_SURFACE_RESIZE_NONE
#1	constant WL_SHELL_SURFACE_RESIZE_TOP
#2	constant WL_SHELL_SURFACE_RESIZE_BOTTOM
#4	constant WL_SHELL_SURFACE_RESIZE_LEFT
#5	constant WL_SHELL_SURFACE_RESIZE_TOP_LEFT
#6	constant WL_SHELL_SURFACE_RESIZE_BOTTOM_LEFT
#8	constant WL_SHELL_SURFACE_RESIZE_RIGHT
#9	constant WL_SHELL_SURFACE_RESIZE_TOP_RIGHT
#10	constant WL_SHELL_SURFACE_RESIZE_BOTTOM_RIGHT
#1	constant WL_SHELL_SURFACE_TRANSIENT_INACTIVE
#0	constant WL_SHELL_SURFACE_FULLSCREEN_METHOD_DEFAULT
#1	constant WL_SHELL_SURFACE_FULLSCREEN_METHOD_SCALE
#2	constant WL_SHELL_SURFACE_FULLSCREEN_METHOD_DRIVER
#3	constant WL_SHELL_SURFACE_FULLSCREEN_METHOD_FILL
#0	constant WL_SURFACE_ERROR_INVALID_SCALE
#1	constant WL_SURFACE_ERROR_INVALID_TRANSFORM
#1	constant WL_SEAT_CAPABILITY_POINTER
#2	constant WL_SEAT_CAPABILITY_KEYBOARD
#4	constant WL_SEAT_CAPABILITY_TOUCH
#0	constant WL_POINTER_ERROR_ROLE
#0	constant WL_POINTER_BUTTON_STATE_RELEASED
#1	constant WL_POINTER_BUTTON_STATE_PRESSED
#0	constant WL_POINTER_AXIS_VERTICAL_SCROLL
#1	constant WL_POINTER_AXIS_HORIZONTAL_SCROLL
#0	constant WL_POINTER_AXIS_SOURCE_WHEEL
#1	constant WL_POINTER_AXIS_SOURCE_FINGER
#2	constant WL_POINTER_AXIS_SOURCE_CONTINUOUS
#3	constant WL_POINTER_AXIS_SOURCE_WHEEL_TILT
#0	constant WL_KEYBOARD_KEYMAP_FORMAT_NO_KEYMAP
#1	constant WL_KEYBOARD_KEYMAP_FORMAT_XKB_V1
#0	constant WL_KEYBOARD_KEY_STATE_RELEASED
#1	constant WL_KEYBOARD_KEY_STATE_PRESSED
#0	constant WL_OUTPUT_SUBPIXEL_UNKNOWN
#1	constant WL_OUTPUT_SUBPIXEL_NONE
#2	constant WL_OUTPUT_SUBPIXEL_HORIZONTAL_RGB
#3	constant WL_OUTPUT_SUBPIXEL_HORIZONTAL_BGR
#4	constant WL_OUTPUT_SUBPIXEL_VERTICAL_RGB
#5	constant WL_OUTPUT_SUBPIXEL_VERTICAL_BGR
#0	constant WL_OUTPUT_TRANSFORM_NORMAL
#1	constant WL_OUTPUT_TRANSFORM_90
#2	constant WL_OUTPUT_TRANSFORM_180
#3	constant WL_OUTPUT_TRANSFORM_270
#4	constant WL_OUTPUT_TRANSFORM_FLIPPED
#5	constant WL_OUTPUT_TRANSFORM_FLIPPED_90
#6	constant WL_OUTPUT_TRANSFORM_FLIPPED_180
#7	constant WL_OUTPUT_TRANSFORM_FLIPPED_270
#1	constant WL_OUTPUT_MODE_CURRENT
#2	constant WL_OUTPUT_MODE_PREFERRED
#0	constant WL_SUBCOMPOSITOR_ERROR_BAD_SURFACE
#0	constant WL_SUBSURFACE_ERROR_BAD_SURFACE

\ -------===< structs >===--------
\ wl_display_listener
begin-structure wl_display_listener
	drop 0 8 +field wl_display_listener-error
	drop 8 8 +field wl_display_listener-delete_id
drop 16 end-structure
\ wl_registry_listener
begin-structure wl_registry_listener
	drop 8 8 +field wl_registry_listener-global_remove
	drop 0 8 +field wl_registry_listener-global
drop 16 end-structure
\ wl_callback_listener
begin-structure wl_callback_listener
	drop 0 8 +field wl_callback_listener-done
drop 8 end-structure
\ wl_shm_listener
begin-structure wl_shm_listener
	drop 0 8 +field wl_shm_listener-format
drop 8 end-structure
\ wl_buffer_listener
begin-structure wl_buffer_listener
	drop 0 8 +field wl_buffer_listener-release
drop 8 end-structure
\ wl_data_offer_listener
begin-structure wl_data_offer_listener
	drop 0 8 +field wl_data_offer_listener-offer
	drop 8 8 +field wl_data_offer_listener-source_actions
	drop 16 8 +field wl_data_offer_listener-action
drop 24 end-structure
\ wl_data_source_listener
begin-structure wl_data_source_listener
	drop 16 8 +field wl_data_source_listener-cancelled
	drop 32 8 +field wl_data_source_listener-dnd_finished
	drop 0 8 +field wl_data_source_listener-target
	drop 8 8 +field wl_data_source_listener-send
	drop 24 8 +field wl_data_source_listener-dnd_drop_performed
	drop 40 8 +field wl_data_source_listener-action
drop 48 end-structure
\ wl_data_device_listener
begin-structure wl_data_device_listener
	drop 24 8 +field wl_data_device_listener-motion
	drop 32 8 +field wl_data_device_listener-drop
	drop 8 8 +field wl_data_device_listener-enter
	drop 16 8 +field wl_data_device_listener-leave
	drop 0 8 +field wl_data_device_listener-data_offer
	drop 40 8 +field wl_data_device_listener-selection
drop 48 end-structure
\ wl_shell_surface_listener
begin-structure wl_shell_surface_listener
	drop 16 8 +field wl_shell_surface_listener-popup_done
	drop 0 8 +field wl_shell_surface_listener-ping
	drop 8 8 +field wl_shell_surface_listener-configure
drop 24 end-structure
\ wl_surface_listener
begin-structure wl_surface_listener
	drop 0 8 +field wl_surface_listener-enter
	drop 8 8 +field wl_surface_listener-leave
drop 16 end-structure
\ wl_seat_listener
begin-structure wl_seat_listener
	drop 0 8 +field wl_seat_listener-capabilities
	drop 8 8 +field wl_seat_listener-name
drop 16 end-structure
\ wl_pointer_listener
begin-structure wl_pointer_listener
	drop 16 8 +field wl_pointer_listener-motion
	drop 40 8 +field wl_pointer_listener-frame
	drop 48 8 +field wl_pointer_listener-axis_source
	drop 24 8 +field wl_pointer_listener-button
	drop 0 8 +field wl_pointer_listener-enter
	drop 32 8 +field wl_pointer_listener-axis
	drop 8 8 +field wl_pointer_listener-leave
	drop 56 8 +field wl_pointer_listener-axis_stop
	drop 64 8 +field wl_pointer_listener-axis_discrete
drop 72 end-structure
\ wl_keyboard_listener
begin-structure wl_keyboard_listener
	drop 32 8 +field wl_keyboard_listener-modifiers
	drop 8 8 +field wl_keyboard_listener-enter
	drop 24 8 +field wl_keyboard_listener-key
	drop 40 8 +field wl_keyboard_listener-repeat_info
	drop 16 8 +field wl_keyboard_listener-leave
	drop 0 8 +field wl_keyboard_listener-keymap
drop 48 end-structure
\ wl_touch_listener
begin-structure wl_touch_listener
	drop 16 8 +field wl_touch_listener-motion
	drop 24 8 +field wl_touch_listener-frame
	drop 48 8 +field wl_touch_listener-orientation
	drop 32 8 +field wl_touch_listener-cancel
	drop 0 8 +field wl_touch_listener-down
	drop 40 8 +field wl_touch_listener-shape
	drop 8 8 +field wl_touch_listener-up
drop 56 end-structure
\ wl_output_listener
begin-structure wl_output_listener
	drop 16 8 +field wl_output_listener-done
	drop 0 8 +field wl_output_listener-geometry
	drop 24 8 +field wl_output_listener-scale
	drop 8 8 +field wl_output_listener-mode
drop 32 end-structure
\ wl_cursor_image
begin-structure wl_cursor_image
	drop 8 4 +field wl_cursor_image-hotspot_x
	drop 12 4 +field wl_cursor_image-hotspot_y
	drop 16 4 +field wl_cursor_image-delay
	drop 4 4 +field wl_cursor_image-height
	drop 0 4 +field wl_cursor_image-width
drop 20 end-structure
\ wl_cursor
begin-structure wl_cursor
	drop 0 4 +field wl_cursor-image_count
	drop 16 8 +field wl_cursor-name
	drop 8 8 +field wl_cursor-images
drop 24 end-structure

\ --===< function pointers >===---
c-callback wl_display_listener-error: a a a u s -- void	( data wl_display object_id code message -- )
c-callback wl_display_listener-delete_id: a a u -- void	( data wl_display id -- )
c-callback wl_registry_listener-global: a a u s u -- void	( data wl_registry name interface version -- )
c-callback wl_registry_listener-global_remove: a a u -- void	( data wl_registry name -- )
c-callback wl_callback_listener-done: a a u -- void	( data wl_callback callback_data -- )
c-callback wl_shm_listener-format: a a u -- void	( data wl_shm format -- )
c-callback wl_buffer_listener-release: a a -- void	( data wl_buffer -- )
c-callback wl_data_offer_listener-offer: a a s -- void	( data wl_data_offer mime_type -- )
c-callback wl_data_offer_listener-source_actions: a a u -- void	( data wl_data_offer source_actions -- )
c-callback wl_data_offer_listener-action: a a u -- void	( data wl_data_offer dnd_action -- )
c-callback wl_data_source_listener-target: a a s -- void	( data wl_data_source mime_type -- )
c-callback wl_data_source_listener-send: a a s n -- void	( data wl_data_source mime_type fd -- )
c-callback wl_data_source_listener-cancelled: a a -- void	( data wl_data_source -- )
c-callback wl_data_source_listener-dnd_drop_performed: a a -- void	( data wl_data_source -- )
c-callback wl_data_source_listener-dnd_finished: a a -- void	( data wl_data_source -- )
c-callback wl_data_source_listener-action: a a u -- void	( data wl_data_source dnd_action -- )
c-callback wl_data_device_listener-data_offer: a a a -- void	( data wl_data_device id -- )
c-callback wl_data_device_listener-enter: a a u a n n a -- void	( data wl_data_device serial surface x y id -- )
c-callback wl_data_device_listener-leave: a a -- void	( data wl_data_device -- )
c-callback wl_data_device_listener-motion: a a u n n -- void	( data wl_data_device time x y -- )
c-callback wl_data_device_listener-drop: a a -- void	( data wl_data_device -- )
c-callback wl_data_device_listener-selection: a a a -- void	( data wl_data_device id -- )
c-callback wl_shell_surface_listener-ping: a a u -- void	( data wl_shell_surface serial -- )
c-callback wl_shell_surface_listener-configure: a a u n n -- void	( data wl_shell_surface edges width height -- )
c-callback wl_shell_surface_listener-popup_done: a a -- void	( data wl_shell_surface -- )
c-callback wl_surface_listener-enter: a a a -- void	( data wl_surface output -- )
c-callback wl_surface_listener-leave: a a a -- void	( data wl_surface output -- )
c-callback wl_seat_listener-capabilities: a a u -- void	( data wl_seat capabilities -- )
c-callback wl_seat_listener-name: a a s -- void	( data wl_seat name -- )
c-callback wl_pointer_listener-enter: a a u a n n -- void	( data wl_pointer serial surface surface_x surface_y -- )
c-callback wl_pointer_listener-leave: a a u a -- void	( data wl_pointer serial surface -- )
c-callback wl_pointer_listener-motion: a a u n n -- void	( data wl_pointer time surface_x surface_y -- )
c-callback wl_pointer_listener-button: a a u u u u -- void	( data wl_pointer serial time button state -- )
c-callback wl_pointer_listener-axis: a a u u n -- void	( data wl_pointer time axis value -- )
c-callback wl_pointer_listener-frame: a a -- void	( data wl_pointer -- )
c-callback wl_pointer_listener-axis_source: a a u -- void	( data wl_pointer axis_source -- )
c-callback wl_pointer_listener-axis_stop: a a u u -- void	( data wl_pointer time axis -- )
c-callback wl_pointer_listener-axis_discrete: a a u n -- void	( data wl_pointer axis discrete -- )
c-callback wl_keyboard_listener-keymap: a a u n u -- void	( data wl_keyboard format fd size -- )
c-callback wl_keyboard_listener-enter: a a u a a -- void	( data wl_keyboard serial surface keys -- )
c-callback wl_keyboard_listener-leave: a a u a -- void	( data wl_keyboard serial surface -- )
c-callback wl_keyboard_listener-key: a a u u u u -- void	( data wl_keyboard serial time key state -- )
c-callback wl_keyboard_listener-modifiers: a a u u u u u -- void	( data wl_keyboard serial mods_depressed mods_latched mods_locked group -- )
c-callback wl_keyboard_listener-repeat_info: a a n n -- void	( data wl_keyboard rate delay -- )
c-callback wl_touch_listener-down: a a u u a n n n -- void	( data wl_touch serial time surface id x y -- )
c-callback wl_touch_listener-up: a a u u n -- void	( data wl_touch serial time id -- )
c-callback wl_touch_listener-motion: a a u n n n -- void	( data wl_touch time id x y -- )
c-callback wl_touch_listener-frame: a a -- void	( data wl_touch -- )
c-callback wl_touch_listener-cancel: a a -- void	( data wl_touch -- )
c-callback wl_touch_listener-shape: a a n n n -- void	( data wl_touch id major minor -- )
c-callback wl_touch_listener-orientation: a a n n -- void	( data wl_touch id orientation -- )
c-callback wl_output_listener-geometry: a a n n n n n s s n -- void	( data wl_output x y physical_width physical_height subpixel make model transform -- )
c-callback wl_output_listener-mode: a a u n n n -- void	( data wl_output flags width height refresh -- )
c-callback wl_output_listener-done: a a -- void	( data wl_output -- )
c-callback wl_output_listener-scale: a a n -- void	( data wl_output factor -- )

\ ------===< functions >===-------
c-function wl_event_queue_destroy wl_event_queue_destroy a -- void	( queue -- )
c-function wl_proxy_marshal wl_proxy_marshal a u ... -- void	( p opcode <noname> -- )
c-function wl_proxy_marshal_array wl_proxy_marshal_array a u a -- void	( p opcode args -- )
c-function wl_proxy_create wl_proxy_create a a -- a	( factory interface -- )
c-function wl_proxy_create_wrapper wl_proxy_create_wrapper a -- a	( proxy -- )
c-function wl_proxy_wrapper_destroy wl_proxy_wrapper_destroy a -- void	( proxy_wrapper -- )
c-function wl_proxy_marshal_constructor wl_proxy_marshal_constructor a u a ... -- a	( proxy opcode interface <noname> -- )
c-function wl_proxy_marshal_constructor_versioned wl_proxy_marshal_constructor_versioned a u a u ... -- a	( proxy opcode interface version <noname> -- )
c-function wl_proxy_marshal_array_constructor wl_proxy_marshal_array_constructor a u a a -- a	( proxy opcode args interface -- )
c-function wl_proxy_marshal_array_constructor_versioned wl_proxy_marshal_array_constructor_versioned a u a a u -- a	( proxy opcode args interface version -- )
c-function wl_proxy_destroy wl_proxy_destroy a -- void	( proxy -- )
c-function wl_proxy_add_listener wl_proxy_add_listener a a a -- n	( proxy implementation data -- )
c-function wl_proxy_get_listener wl_proxy_get_listener a -- a	( proxy -- )
c-function wl_proxy_add_dispatcher wl_proxy_add_dispatcher a a a a -- n	( proxy dispatcher_func dispatcher_data data -- )
c-function wl_proxy_set_user_data wl_proxy_set_user_data a a -- void	( proxy user_data -- )
c-function wl_proxy_get_user_data wl_proxy_get_user_data a -- a	( proxy -- )
c-function wl_proxy_get_version wl_proxy_get_version a -- u	( proxy -- )
c-function wl_proxy_get_id wl_proxy_get_id a -- u	( proxy -- )
c-function wl_proxy_set_tag wl_proxy_set_tag a a -- void	( proxy tag -- )
c-function wl_proxy_get_tag wl_proxy_get_tag a -- a	( proxy -- )
c-function wl_proxy_get_class wl_proxy_get_class a -- s	( proxy -- )
c-function wl_proxy_set_queue wl_proxy_set_queue a a -- void	( proxy queue -- )
c-function wl_display_connect wl_display_connect s -- a	( name -- )
c-function wl_display_connect_to_fd wl_display_connect_to_fd n -- a	( fd -- )
c-function wl_display_disconnect wl_display_disconnect a -- void	( display -- )
c-function wl_display_get_fd wl_display_get_fd a -- n	( display -- )
c-function wl_display_dispatch wl_display_dispatch a -- n	( display -- )
c-function wl_display_dispatch_queue wl_display_dispatch_queue a a -- n	( display queue -- )
c-function wl_display_dispatch_queue_pending wl_display_dispatch_queue_pending a a -- n	( display queue -- )
c-function wl_display_dispatch_pending wl_display_dispatch_pending a -- n	( display -- )
c-function wl_display_get_error wl_display_get_error a -- n	( display -- )
c-function wl_display_get_protocol_error wl_display_get_protocol_error a a a -- u	( display interface id -- )
c-function wl_display_flush wl_display_flush a -- n	( display -- )
c-function wl_display_roundtrip_queue wl_display_roundtrip_queue a a -- n	( display queue -- )
c-function wl_display_roundtrip wl_display_roundtrip a -- n	( display -- )
c-function wl_display_create_queue wl_display_create_queue a -- a	( display -- )
c-function wl_display_prepare_read_queue wl_display_prepare_read_queue a a -- n	( display queue -- )
c-function wl_display_prepare_read wl_display_prepare_read a -- n	( display -- )
c-function wl_display_cancel_read wl_display_cancel_read a -- void	( display -- )
c-function wl_display_read_events wl_display_read_events a -- n	( display -- )
c-function wl_log_set_handler_client wl_log_set_handler_client a -- void	( handler -- )
c-function wl_display_add_listener wl_display_add_listener a a a -- n	( wl_display listener data -- )
c-function wl_display_set_user_data wl_display_set_user_data a a -- void	( wl_display user_data -- )
c-function wl_display_get_user_data wl_display_get_user_data a -- a	( wl_display -- )
c-function wl_display_get_version wl_display_get_version a -- u	( wl_display -- )
c-function wl_display_sync wl_display_sync a -- a	( wl_display -- )
c-function wl_display_get_registry wl_display_get_registry a -- a	( wl_display -- )
c-function wl_registry_add_listener wl_registry_add_listener a a a -- n	( wl_registry listener data -- )
c-function wl_registry_set_user_data wl_registry_set_user_data a a -- void	( wl_registry user_data -- )
c-function wl_registry_get_user_data wl_registry_get_user_data a -- a	( wl_registry -- )
c-function wl_registry_get_version wl_registry_get_version a -- u	( wl_registry -- )
c-function wl_registry_destroy wl_registry_destroy a -- void	( wl_registry -- )
c-function wl_registry_bind wl_registry_bind a u a u -- a	( wl_registry name interface version -- )
c-function wl_callback_add_listener wl_callback_add_listener a a a -- n	( wl_callback listener data -- )
c-function wl_callback_set_user_data wl_callback_set_user_data a a -- void	( wl_callback user_data -- )
c-function wl_callback_get_user_data wl_callback_get_user_data a -- a	( wl_callback -- )
c-function wl_callback_get_version wl_callback_get_version a -- u	( wl_callback -- )
c-function wl_callback_destroy wl_callback_destroy a -- void	( wl_callback -- )
c-function wl_compositor_set_user_data wl_compositor_set_user_data a a -- void	( wl_compositor user_data -- )
c-function wl_compositor_get_user_data wl_compositor_get_user_data a -- a	( wl_compositor -- )
c-function wl_compositor_get_version wl_compositor_get_version a -- u	( wl_compositor -- )
c-function wl_compositor_destroy wl_compositor_destroy a -- void	( wl_compositor -- )
c-function wl_compositor_create_surface wl_compositor_create_surface a -- a	( wl_compositor -- )
c-function wl_compositor_create_region wl_compositor_create_region a -- a	( wl_compositor -- )
c-function wl_shm_pool_set_user_data wl_shm_pool_set_user_data a a -- void	( wl_shm_pool user_data -- )
c-function wl_shm_pool_get_user_data wl_shm_pool_get_user_data a -- a	( wl_shm_pool -- )
c-function wl_shm_pool_get_version wl_shm_pool_get_version a -- u	( wl_shm_pool -- )
c-function wl_shm_pool_create_buffer wl_shm_pool_create_buffer a n n n n u -- a	( wl_shm_pool offset width height stride format -- )
c-function wl_shm_pool_destroy wl_shm_pool_destroy a -- void	( wl_shm_pool -- )
c-function wl_shm_pool_resize wl_shm_pool_resize a n -- void	( wl_shm_pool size -- )
c-function wl_shm_add_listener wl_shm_add_listener a a a -- n	( wl_shm listener data -- )
c-function wl_shm_set_user_data wl_shm_set_user_data a a -- void	( wl_shm user_data -- )
c-function wl_shm_get_user_data wl_shm_get_user_data a -- a	( wl_shm -- )
c-function wl_shm_get_version wl_shm_get_version a -- u	( wl_shm -- )
c-function wl_shm_destroy wl_shm_destroy a -- void	( wl_shm -- )
c-function wl_shm_create_pool wl_shm_create_pool a n n -- a	( wl_shm fd size -- )
c-function wl_buffer_add_listener wl_buffer_add_listener a a a -- n	( wl_buffer listener data -- )
c-function wl_buffer_set_user_data wl_buffer_set_user_data a a -- void	( wl_buffer user_data -- )
c-function wl_buffer_get_user_data wl_buffer_get_user_data a -- a	( wl_buffer -- )
c-function wl_buffer_get_version wl_buffer_get_version a -- u	( wl_buffer -- )
c-function wl_buffer_destroy wl_buffer_destroy a -- void	( wl_buffer -- )
c-function wl_data_offer_add_listener wl_data_offer_add_listener a a a -- n	( wl_data_offer listener data -- )
c-function wl_data_offer_set_user_data wl_data_offer_set_user_data a a -- void	( wl_data_offer user_data -- )
c-function wl_data_offer_get_user_data wl_data_offer_get_user_data a -- a	( wl_data_offer -- )
c-function wl_data_offer_get_version wl_data_offer_get_version a -- u	( wl_data_offer -- )
c-function wl_data_offer_accept wl_data_offer_accept a u s -- void	( wl_data_offer serial mime_type -- )
c-function wl_data_offer_receive wl_data_offer_receive a s n -- void	( wl_data_offer mime_type fd -- )
c-function wl_data_offer_destroy wl_data_offer_destroy a -- void	( wl_data_offer -- )
c-function wl_data_offer_finish wl_data_offer_finish a -- void	( wl_data_offer -- )
c-function wl_data_offer_set_actions wl_data_offer_set_actions a u u -- void	( wl_data_offer dnd_actions preferred_action -- )
c-function wl_data_source_add_listener wl_data_source_add_listener a a a -- n	( wl_data_source listener data -- )
c-function wl_data_source_set_user_data wl_data_source_set_user_data a a -- void	( wl_data_source user_data -- )
c-function wl_data_source_get_user_data wl_data_source_get_user_data a -- a	( wl_data_source -- )
c-function wl_data_source_get_version wl_data_source_get_version a -- u	( wl_data_source -- )
c-function wl_data_source_offer wl_data_source_offer a s -- void	( wl_data_source mime_type -- )
c-function wl_data_source_destroy wl_data_source_destroy a -- void	( wl_data_source -- )
c-function wl_data_source_set_actions wl_data_source_set_actions a u -- void	( wl_data_source dnd_actions -- )
c-function wl_data_device_add_listener wl_data_device_add_listener a a a -- n	( wl_data_device listener data -- )
c-function wl_data_device_set_user_data wl_data_device_set_user_data a a -- void	( wl_data_device user_data -- )
c-function wl_data_device_get_user_data wl_data_device_get_user_data a -- a	( wl_data_device -- )
c-function wl_data_device_get_version wl_data_device_get_version a -- u	( wl_data_device -- )
c-function wl_data_device_destroy wl_data_device_destroy a -- void	( wl_data_device -- )
c-function wl_data_device_start_drag wl_data_device_start_drag a a a a u -- void	( wl_data_device source origin icon serial -- )
c-function wl_data_device_set_selection wl_data_device_set_selection a a u -- void	( wl_data_device source serial -- )
c-function wl_data_device_release wl_data_device_release a -- void	( wl_data_device -- )
c-function wl_data_device_manager_set_user_data wl_data_device_manager_set_user_data a a -- void	( wl_data_device_manager user_data -- )
c-function wl_data_device_manager_get_user_data wl_data_device_manager_get_user_data a -- a	( wl_data_device_manager -- )
c-function wl_data_device_manager_get_version wl_data_device_manager_get_version a -- u	( wl_data_device_manager -- )
c-function wl_data_device_manager_destroy wl_data_device_manager_destroy a -- void	( wl_data_device_manager -- )
c-function wl_data_device_manager_create_data_source wl_data_device_manager_create_data_source a -- a	( wl_data_device_manager -- )
c-function wl_data_device_manager_get_data_device wl_data_device_manager_get_data_device a a -- a	( wl_data_device_manager seat -- )
c-function wl_shell_set_user_data wl_shell_set_user_data a a -- void	( wl_shell user_data -- )
c-function wl_shell_get_user_data wl_shell_get_user_data a -- a	( wl_shell -- )
c-function wl_shell_get_version wl_shell_get_version a -- u	( wl_shell -- )
c-function wl_shell_destroy wl_shell_destroy a -- void	( wl_shell -- )
c-function wl_shell_get_shell_surface wl_shell_get_shell_surface a a -- a	( wl_shell surface -- )
c-function wl_shell_surface_add_listener wl_shell_surface_add_listener a a a -- n	( wl_shell_surface listener data -- )
c-function wl_shell_surface_set_user_data wl_shell_surface_set_user_data a a -- void	( wl_shell_surface user_data -- )
c-function wl_shell_surface_get_user_data wl_shell_surface_get_user_data a -- a	( wl_shell_surface -- )
c-function wl_shell_surface_get_version wl_shell_surface_get_version a -- u	( wl_shell_surface -- )
c-function wl_shell_surface_destroy wl_shell_surface_destroy a -- void	( wl_shell_surface -- )
c-function wl_shell_surface_pong wl_shell_surface_pong a u -- void	( wl_shell_surface serial -- )
c-function wl_shell_surface_move wl_shell_surface_move a a u -- void	( wl_shell_surface seat serial -- )
c-function wl_shell_surface_set_toplevel wl_shell_surface_set_toplevel a -- void	( wl_shell_surface -- )
c-function wl_shell_surface_set_transient wl_shell_surface_set_transient a a n n u -- void	( wl_shell_surface parent x y flags -- )
c-function wl_shell_surface_set_fullscreen wl_shell_surface_set_fullscreen a u u a -- void	( wl_shell_surface method framerate output -- )
c-function wl_shell_surface_set_popup wl_shell_surface_set_popup a a u a n n u -- void	( wl_shell_surface seat serial parent x y flags -- )
c-function wl_shell_surface_set_maximized wl_shell_surface_set_maximized a a -- void	( wl_shell_surface output -- )
c-function wl_shell_surface_set_title wl_shell_surface_set_title a s -- void	( wl_shell_surface title -- )
c-function wl_shell_surface_set_class wl_shell_surface_set_class a s -- void	( wl_shell_surface class_ -- )
c-function wl_surface_add_listener wl_surface_add_listener a a a -- n	( wl_surface listener data -- )
c-function wl_surface_set_user_data wl_surface_set_user_data a a -- void	( wl_surface user_data -- )
c-function wl_surface_get_user_data wl_surface_get_user_data a -- a	( wl_surface -- )
c-function wl_surface_get_version wl_surface_get_version a -- u	( wl_surface -- )
c-function wl_surface_destroy wl_surface_destroy a -- void	( wl_surface -- )
c-function wl_surface_attach wl_surface_attach a a n n -- void	( wl_surface buffer x y -- )
c-function wl_surface_damage wl_surface_damage a n n n n -- void	( wl_surface x y width height -- )
c-function wl_surface_frame wl_surface_frame a -- a	( wl_surface -- )
c-function wl_surface_set_opaque_region wl_surface_set_opaque_region a a -- void	( wl_surface region -- )
c-function wl_surface_set_input_region wl_surface_set_input_region a a -- void	( wl_surface region -- )
c-function wl_surface_commit wl_surface_commit a -- void	( wl_surface -- )
c-function wl_surface_set_buffer_transform wl_surface_set_buffer_transform a n -- void	( wl_surface transform -- )
c-function wl_surface_set_buffer_scale wl_surface_set_buffer_scale a n -- void	( wl_surface scale -- )
c-function wl_surface_damage_buffer wl_surface_damage_buffer a n n n n -- void	( wl_surface x y width height -- )
c-function wl_seat_add_listener wl_seat_add_listener a a a -- n	( wl_seat listener data -- )
c-function wl_seat_set_user_data wl_seat_set_user_data a a -- void	( wl_seat user_data -- )
c-function wl_seat_get_user_data wl_seat_get_user_data a -- a	( wl_seat -- )
c-function wl_seat_get_version wl_seat_get_version a -- u	( wl_seat -- )
c-function wl_seat_destroy wl_seat_destroy a -- void	( wl_seat -- )
c-function wl_seat_get_pointer wl_seat_get_pointer a -- a	( wl_seat -- )
c-function wl_seat_get_keyboard wl_seat_get_keyboard a -- a	( wl_seat -- )
c-function wl_seat_get_touch wl_seat_get_touch a -- a	( wl_seat -- )
c-function wl_seat_release wl_seat_release a -- void	( wl_seat -- )
c-function wl_pointer_add_listener wl_pointer_add_listener a a a -- n	( wl_pointer listener data -- )
c-function wl_pointer_set_user_data wl_pointer_set_user_data a a -- void	( wl_pointer user_data -- )
c-function wl_pointer_get_user_data wl_pointer_get_user_data a -- a	( wl_pointer -- )
c-function wl_pointer_get_version wl_pointer_get_version a -- u	( wl_pointer -- )
c-function wl_pointer_destroy wl_pointer_destroy a -- void	( wl_pointer -- )
c-function wl_pointer_set_cursor wl_pointer_set_cursor a u a n n -- void	( wl_pointer serial surface hotspot_x hotspot_y -- )
c-function wl_pointer_release wl_pointer_release a -- void	( wl_pointer -- )
c-function wl_keyboard_add_listener wl_keyboard_add_listener a a a -- n	( wl_keyboard listener data -- )
c-function wl_keyboard_set_user_data wl_keyboard_set_user_data a a -- void	( wl_keyboard user_data -- )
c-function wl_keyboard_get_user_data wl_keyboard_get_user_data a -- a	( wl_keyboard -- )
c-function wl_keyboard_get_version wl_keyboard_get_version a -- u	( wl_keyboard -- )
c-function wl_keyboard_destroy wl_keyboard_destroy a -- void	( wl_keyboard -- )
c-function wl_keyboard_release wl_keyboard_release a -- void	( wl_keyboard -- )
c-function wl_touch_add_listener wl_touch_add_listener a a a -- n	( wl_touch listener data -- )
c-function wl_touch_set_user_data wl_touch_set_user_data a a -- void	( wl_touch user_data -- )
c-function wl_touch_get_user_data wl_touch_get_user_data a -- a	( wl_touch -- )
c-function wl_touch_get_version wl_touch_get_version a -- u	( wl_touch -- )
c-function wl_touch_destroy wl_touch_destroy a -- void	( wl_touch -- )
c-function wl_touch_release wl_touch_release a -- void	( wl_touch -- )
c-function wl_output_add_listener wl_output_add_listener a a a -- n	( wl_output listener data -- )
c-function wl_output_set_user_data wl_output_set_user_data a a -- void	( wl_output user_data -- )
c-function wl_output_get_user_data wl_output_get_user_data a -- a	( wl_output -- )
c-function wl_output_get_version wl_output_get_version a -- u	( wl_output -- )
c-function wl_output_destroy wl_output_destroy a -- void	( wl_output -- )
c-function wl_output_release wl_output_release a -- void	( wl_output -- )
c-function wl_region_set_user_data wl_region_set_user_data a a -- void	( wl_region user_data -- )
c-function wl_region_get_user_data wl_region_get_user_data a -- a	( wl_region -- )
c-function wl_region_get_version wl_region_get_version a -- u	( wl_region -- )
c-function wl_region_destroy wl_region_destroy a -- void	( wl_region -- )
c-function wl_region_add wl_region_add a n n n n -- void	( wl_region x y width height -- )
c-function wl_region_subtract wl_region_subtract a n n n n -- void	( wl_region x y width height -- )
c-function wl_subcompositor_set_user_data wl_subcompositor_set_user_data a a -- void	( wl_subcompositor user_data -- )
c-function wl_subcompositor_get_user_data wl_subcompositor_get_user_data a -- a	( wl_subcompositor -- )
c-function wl_subcompositor_get_version wl_subcompositor_get_version a -- u	( wl_subcompositor -- )
c-function wl_subcompositor_destroy wl_subcompositor_destroy a -- void	( wl_subcompositor -- )
c-function wl_subcompositor_get_subsurface wl_subcompositor_get_subsurface a a a -- a	( wl_subcompositor surface parent -- )
c-function wl_subsurface_set_user_data wl_subsurface_set_user_data a a -- void	( wl_subsurface user_data -- )
c-function wl_subsurface_get_user_data wl_subsurface_get_user_data a -- a	( wl_subsurface -- )
c-function wl_subsurface_get_version wl_subsurface_get_version a -- u	( wl_subsurface -- )
c-function wl_subsurface_destroy wl_subsurface_destroy a -- void	( wl_subsurface -- )
c-function wl_subsurface_set_position wl_subsurface_set_position a n n -- void	( wl_subsurface x y -- )
c-function wl_subsurface_place_above wl_subsurface_place_above a a -- void	( wl_subsurface sibling -- )
c-function wl_subsurface_place_below wl_subsurface_place_below a a -- void	( wl_subsurface sibling -- )
c-function wl_subsurface_set_sync wl_subsurface_set_sync a -- void	( wl_subsurface -- )
c-function wl_subsurface_set_desync wl_subsurface_set_desync a -- void	( wl_subsurface -- )
c-function wl_egl_window_create wl_egl_window_create a n n -- a	( surface width height -- )
c-function wl_egl_window_destroy wl_egl_window_destroy a -- void	( egl_window -- )
c-function wl_egl_window_resize wl_egl_window_resize a n n n n -- void	( egl_window width height dx dy -- )
c-function wl_egl_window_get_attached_size wl_egl_window_get_attached_size a a a -- void	( egl_window width height -- )
c-function wl_cursor_theme_load wl_cursor_theme_load s n a -- a	( name size shm -- )
c-function wl_cursor_theme_destroy wl_cursor_theme_destroy a -- void	( theme -- )
c-function wl_cursor_theme_get_cursor wl_cursor_theme_get_cursor a s -- a	( theme name -- )
c-function wl_cursor_image_get_buffer wl_cursor_image_get_buffer a -- a	( image -- )
c-function wl_cursor_frame wl_cursor_frame a u -- n	( cursor time -- )
c-function wl_cursor_frame_and_duration wl_cursor_frame_and_duration a u a -- n	( cursor time duration -- )
