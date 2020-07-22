\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library gps
s" gps" add-lib
s" a" vararg$ $!
\c #include <gps.h>

\ ----===< int constants >===-----
#9	constant GPSD_API_MAJOR_VERSION
#0	constant GPSD_API_MINOR_VERSION
#140	constant MAXCHANNELS
#4	constant MAXUSERDEVS
#128	constant GPS_PATH_MAX
#0	constant MODE_NOT_SEEN
#1	constant MODE_NO_FIX
#2	constant MODE_2D
#3	constant MODE_3D
#64	constant GLONASS_PRN_OFFSET
#33	constant RTCM2_WORDS_MAX
#18	constant MAXCORRECTIONS
#10	constant MAXSTATIONS
#31	constant MAXHEALTH
#0	constant NAVSYSTEM_GPS
#1	constant NAVSYSTEM_GLONASS
#2	constant NAVSYSTEM_GALILEO
#3	constant NAVSYSTEM_UNKNOWN
#0	constant HEALTH_NORMAL
#1	constant HEALTH_UNMONITORED
#2	constant HEALTH_NOINFO
#3	constant HEALTH_DONOTUSE
#-1	constant SNR_BAD
#64	constant RTCM3_MAX_SATELLITES
#31	constant RTCM3_MAX_DESCRIPTOR
#32	constant RTCM3_MAX_ANNOUNCEMENTS
#181000	constant AIS_LON3_NOT_AVAILABLE
#91000	constant AIS_LAT3_NOT_AVAILABLE
#1810000	constant AIS_LON4_NOT_AVAILABLE
#910000	constant AIS_LAT4_NOT_AVAILABLE
#360	constant DAC1FID32_CDIR_NOT_AVAILABLE
#127	constant DAC1FID32_CSPEED_NOT_AVAILABLE
#0	constant DAC200FID24_GAUGE_ID_UNKNOWN
#0	constant DAC200FID24_GAUGE_LEVEL_UNKNOWN
#7	constant DAC1FID17_ID_LENGTH
#0	constant DAC1FID17_IDTYPE_MMSI
#1	constant DAC1FID17_IDTYPE_IMO
#2	constant DAC1FID17_IDTYPE_CALLSIGN
#3	constant DAC1FID17_IDTYPE_OTHER
#360	constant DAC1FID17_COURSE_NOT_AVAILABLE
#255	constant DAC1FID17_SPEED_NOT_AVAILABLE
#0	constant GNSSID_GPS
#1	constant GNSSID_SBAS
#2	constant GNSSID_GAL
#3	constant GNSSID_BD
#4	constant GNSSID_IMES
#5	constant GNSSID_QZSS
#6	constant GNSSID_GLO
#7	constant GNSSID_IRNSS
#8	constant GNSSID_CNT
#0	constant SAT_HEALTH_UNK
#1	constant SAT_HEALTH_OK
#2	constant SAT_HEALTH_BAD
#64500	constant LOCKMAX
#1	constant SAT_ACQUIRED
#2	constant SAT_CODE_TRACK
#4	constant SAT_CARR_TRACK
#8	constant SAT_DATA_SYNC
#16	constant SAT_FRAME_SYNC
#32	constant SAT_EPHEMERIS
#64	constant SAT_FIX_USED
#512	constant HEXDATA_MAX
#1	constant SEEN_GPS
#2	constant SEEN_RTCM2
#4	constant SEEN_RTCM3
#8	constant SEEN_AIS
#1	constant WATCH_ENABLE
#2	constant WATCH_DISABLE
#16	constant WATCH_JSON
#32	constant WATCH_NMEA
#64	constant WATCH_RARE
#128	constant WATCH_RAW
#256	constant WATCH_SCALED
#512	constant WATCH_TIMING
#2048	constant WATCH_DEVICE
#4096	constant WATCH_SPLIT24
#8192	constant WATCH_PPS
#65536	constant WATCH_NEWSTYLE
#42	constant SET_HIGH_BIT
#0	constant STATUS_NO_FIX
#1	constant STATUS_FIX
#2	constant STATUS_DGPS_FIX
#3	constant STATUS_RTK_FIX
#4	constant STATUS_RTK_FLT
#5	constant STATUS_DR
#6	constant STATUS_GNSSDR
#7	constant STATUS_TIME
#8	constant STATUS_SIM
#9	constant STATUS_PPS_FIX
#-1	constant NL_NOSERVICE
#-2	constant NL_NOHOST
#-3	constant NL_NOPROTO
#-4	constant NL_NOSOCK
#-5	constant NL_NOSOCKOPT
#-6	constant NL_NOCONNECT
#-7	constant SHM_NOSHARED
#-8	constant SHM_NOATTACH
#-9	constant DBUS_FAILURE

\ ----===< long constants >===-----
#2.	2constant ONLINE_SET
#4.	2constant TIME_SET
#8.	2constant TIMERR_SET
#16.	2constant LATLON_SET
#32.	2constant ALTITUDE_SET
#64.	2constant SPEED_SET
#128.	2constant TRACK_SET
#256.	2constant CLIMB_SET
#512.	2constant STATUS_SET
#1024.	2constant MODE_SET
#2048.	2constant DOP_SET
#4096.	2constant HERR_SET
#8192.	2constant VERR_SET
#16384.	2constant ATTITUDE_SET
#32768.	2constant SATELLITE_SET
#65536.	2constant SPEEDERR_SET
#131072.	2constant TRACKERR_SET
#262144.	2constant CLIMBERR_SET
#524288.	2constant DEVICE_SET
#1048576.	2constant DEVICELIST_SET
#2097152.	2constant DEVICEID_SET
#4194304.	2constant RTCM2_SET
#8388608.	2constant RTCM3_SET
#16777216.	2constant AIS_SET
#33554432.	2constant PACKET_SET
#67108864.	2constant SUBFRAME_SET
#134217728.	2constant GST_SET
#268435456.	2constant VERSION_SET
#536870912.	2constant POLICY_SET
#1073741824.	2constant LOGMESSAGE_SET
#2147483648.	2constant ERROR_SET
#4294967296.	2constant TOFF_SET
#8589934592.	2constant PPS_SET
#17179869184.	2constant NAVDATA_SET
#34359738368.	2constant OSCILLATOR_SET
#68719476736.	2constant ECEF_SET
#137438953472.	2constant VECEF_SET
#274877906944.	2constant MAGNETIC_TRACK_SET
#549755813888.	2constant RAW_SET
#1099511627776.	2constant NED_SET
#2199023255552.	2constant VNED_SET
#600720818176.	2constant UNION_SET

\ ---===< float constants >===----
299792.458000e0	fconstant GPS_AMBIGUITY_MODULUS
599584.916000e0	fconstant GLONASS_AMBIGUITY_MODULUS
0.100000e0	fconstant MESSAGE_INTERVAL_UNITS
60000.000000e0	fconstant AIS_LATLON3_DIV
600000.000000e0	fconstant AIS_LATLON4_DIV
3.280840e0	fconstant METERS_TO_FEET
0.000621e0	fconstant METERS_TO_MILES
0.546807e0	fconstant METERS_TO_FATHOMS
1.150779e0	fconstant KNOTS_TO_MPH
1.852000e0	fconstant KNOTS_TO_KPH
0.514444e0	fconstant KNOTS_TO_MPS
3.600000e0	fconstant MPS_TO_KPH
2.236936e0	fconstant MPS_TO_MPH
1.943844e0	fconstant MPS_TO_KNOTS
3.141593e0	fconstant GPS_PI
57.295780e0	fconstant RAD_2_DEG
0.017453e0	fconstant DEG_2_RAD
0.693147e0	fconstant GPS_LN2
6378137.000000e0	fconstant WGS84A
298.257224e0	fconstant WGS84F
6356752.314245e0	fconstant WGS84B
0.006694e0	fconstant WGS84E
0.006739e0	fconstant WGS84E2
299792458.000000e0	fconstant CLIGHT

\ --------===< enums >===---------
#0	constant reserved
#1	constant correct
#2	constant widelane
#3	constant uncertain
#0	constant reserved_code
#1	constant p
#2	constant ca
#3	constant l2c

\ -------===< structs >===--------
\ gps_fix_t
begin-structure gps_fix_t
	drop 16 4 +field gps_fix_t-mode
	drop 96 8 +field gps_fix_t-track
	drop 128 8 +field gps_fix_t-climb
	drop 64 8 +field gps_fix_t-altitude
	drop 344 8 +field gps_fix_t-dgps_age
	drop 352 4 +field gps_fix_t-dgps_station
	drop 0 16 +field gps_fix_t-time
	drop 160 8 +field gps_fix_t-geoid_sep
	drop 256 48 +field gps_fix_t-NED
	drop 112 8 +field gps_fix_t-speed
	drop 72 8 +field gps_fix_t-altHAE
	drop 32 8 +field gps_fix_t-latitude
	drop 120 8 +field gps_fix_t-eps
	drop 176 8 +field gps_fix_t-magnetic_var
	drop 24 8 +field gps_fix_t-ept
	drop 136 8 +field gps_fix_t-epc
	drop 184 8 +field gps_fix_t-depth
	drop 304 40 +field gps_fix_t-datum
	drop 104 8 +field gps_fix_t-epd
	drop 88 8 +field gps_fix_t-epv
	drop 48 8 +field gps_fix_t-longitude
	drop 56 8 +field gps_fix_t-epx
	drop 40 8 +field gps_fix_t-epy
	drop 144 8 +field gps_fix_t-eph
	drop 80 8 +field gps_fix_t-altMSL
	drop 152 8 +field gps_fix_t-sep
	drop 168 8 +field gps_fix_t-magnetic_track
	drop 192 64 +field gps_fix_t-ecef
drop 360 end-structure
\ gps_fix_t_NED
begin-structure gps_fix_t_NED
	drop 8 8 +field gps_fix_t_NED-relPosE
	drop 40 8 +field gps_fix_t_NED-velD
	drop 0 8 +field gps_fix_t_NED-relPosN
	drop 32 8 +field gps_fix_t_NED-velE
	drop 24 8 +field gps_fix_t_NED-velN
	drop 16 8 +field gps_fix_t_NED-relPosD
drop 48 end-structure
\ gps_fix_t_ecef
begin-structure gps_fix_t_ecef
	drop 0 8 +field gps_fix_t_ecef-x
	drop 56 8 +field gps_fix_t_ecef-vAcc
	drop 8 8 +field gps_fix_t_ecef-y
	drop 24 8 +field gps_fix_t_ecef-pAcc
	drop 16 8 +field gps_fix_t_ecef-z
	drop 32 8 +field gps_fix_t_ecef-vx
	drop 40 8 +field gps_fix_t_ecef-vy
	drop 48 8 +field gps_fix_t_ecef-vz
drop 64 end-structure
\ gst_t
begin-structure gst_t
	drop 40 8 +field gst_t-smajor_orientation
	drop 0 16 +field gst_t-utctime
	drop 16 8 +field gst_t-rms_deviation
	drop 24 8 +field gst_t-smajor_deviation
	drop 32 8 +field gst_t-sminor_deviation
	drop 48 8 +field gst_t-lat_err_deviation
	drop 56 8 +field gst_t-lon_err_deviation
	drop 64 8 +field gst_t-alt_err_deviation
drop 72 end-structure
\ rtcm2_t
begin-structure rtcm2_t
	drop 24 4 +field rtcm2_t-stathlth
	drop 32 748 +field rtcm2_t-conhealth
	drop 8 8 +field rtcm2_t-zcount
	drop 4 4 +field rtcm2_t-length
	drop 32 48 +field rtcm2_t-reference
	drop 32 12 +field rtcm2_t-gpstime
	drop 32 124 +field rtcm2_t-message
	drop 20 4 +field rtcm2_t-seqnum
	drop 32 124 +field rtcm2_t-words
	drop 32 32 +field rtcm2_t-xmitter
	drop 32 488 +field rtcm2_t-almanac
	drop 0 4 +field rtcm2_t-type
	drop 16 4 +field rtcm2_t-refstaid
	drop 32 584 +field rtcm2_t-glonass_ranges
	drop 32 584 +field rtcm2_t-gps_ranges
	drop 32 32 +field rtcm2_t-ecef
drop 784 end-structure
\ gps_rangesat_t
begin-structure gps_rangesat_t
	drop 16 8 +field gps_rangesat_t-prc
	drop 0 4 +field gps_rangesat_t-ident
	drop 8 4 +field gps_rangesat_t-iod
	drop 4 4 +field gps_rangesat_t-udre
	drop 24 8 +field gps_rangesat_t-rrc
drop 32 end-structure
\ consat_t
begin-structure consat_t
	drop 8 4 +field consat_t-health
	drop 12 4 +field consat_t-snr
	drop 17 1 +field consat_t-new_data
	drop 16 1 +field consat_t-health_en
	drop 4 1 +field consat_t-iodl
	drop 20 4 +field consat_t-tou
	drop 0 4 +field consat_t-ident
	drop 18 1 +field consat_t-los_warning
drop 24 end-structure
\ station_t
begin-structure station_t
	drop 32 4 +field station_t-health
	drop 0 8 +field station_t-latitude
	drop 36 4 +field station_t-station_id
	drop 24 8 +field station_t-frequency
	drop 8 8 +field station_t-longitude
	drop 16 4 +field station_t-range
	drop 40 4 +field station_t-bitrate
drop 48 end-structure
\ glonass_rangesat_t
begin-structure glonass_rangesat_t
	drop 12 1 +field glonass_rangesat_t-change
	drop 16 8 +field glonass_rangesat_t-prc
	drop 0 4 +field glonass_rangesat_t-ident
	drop 4 4 +field glonass_rangesat_t-udre
	drop 8 4 +field glonass_rangesat_t-tod
	drop 24 8 +field glonass_rangesat_t-rrc
drop 32 end-structure
\ rtcm3_rtk_hdr
begin-structure rtcm3_rtk_hdr
	drop 16 1 +field rtcm3_rtk_hdr-sync
	drop 18 2 +field rtcm3_rtk_hdr-satcount
	drop 20 1 +field rtcm3_rtk_hdr-smoothing
	drop 0 4 +field rtcm3_rtk_hdr-station_id
	drop 24 4 +field rtcm3_rtk_hdr-interval
	drop 8 8 +field rtcm3_rtk_hdr-tow
drop 32 end-structure
\ rtcm3_basic_rtk
begin-structure rtcm3_basic_rtk
	drop 0 1 +field rtcm3_basic_rtk-indicator
	drop 4 4 +field rtcm3_basic_rtk-channel
	drop 16 8 +field rtcm3_basic_rtk-rangediff
	drop 8 8 +field rtcm3_basic_rtk-pseudorange
	drop 24 1 +field rtcm3_basic_rtk-locktime
drop 32 end-structure
\ rtcm3_extended_rtk
begin-structure rtcm3_extended_rtk
	drop 0 1 +field rtcm3_extended_rtk-indicator
	drop 4 4 +field rtcm3_extended_rtk-channel
	drop 16 8 +field rtcm3_extended_rtk-rangediff
	drop 8 8 +field rtcm3_extended_rtk-pseudorange
	drop 24 1 +field rtcm3_extended_rtk-locktime
	drop 32 8 +field rtcm3_extended_rtk-CNR
	drop 25 1 +field rtcm3_extended_rtk-ambiguity
drop 40 end-structure
\ rtcm3_network_rtk_header
begin-structure rtcm3_network_rtk_header
	drop 28 1 +field rtcm3_network_rtk_header-satcount
	drop 0 4 +field rtcm3_network_rtk_header-network_id
	drop 4 4 +field rtcm3_network_rtk_header-subnetwork_id
	drop 20 4 +field rtcm3_network_rtk_header-master_id
	drop 8 8 +field rtcm3_network_rtk_header-time
	drop 16 1 +field rtcm3_network_rtk_header-multimesg
	drop 24 4 +field rtcm3_network_rtk_header-aux_id
drop 32 end-structure
\ rtcm3_correction_diff
begin-structure rtcm3_correction_diff
	drop 8 1 +field rtcm3_correction_diff-nonsync
	drop 16 8 +field rtcm3_correction_diff-geometric_diff
	drop 24 1 +field rtcm3_correction_diff-iode
	drop 32 8 +field rtcm3_correction_diff-ionospheric_diff
	drop 0 1 +field rtcm3_correction_diff-ident
	drop 4 4 +field rtcm3_correction_diff-ambiguity
drop 40 end-structure
\ rtcm3_t
begin-structure rtcm3_t
	drop 8 5664 +field rtcm3_t-rtcmtypes
	drop 0 4 +field rtcm3_t-type
	drop 4 4 +field rtcm3_t-length
drop 5672 end-structure
\ rtcm3_t_rtcmtypes
begin-structure rtcm3_t_rtcmtypes
	drop 0 5664 +field rtcm3_t_rtcmtypes-rtcm3_1011
	drop 0 5664 +field rtcm3_t_rtcmtypes-rtcm3_1012
	drop 0 2592 +field rtcm3_t_rtcmtypes-rtcm3_1001
	drop 0 208 +field rtcm3_t_rtcmtypes-rtcm3_1013
	drop 0 48 +field rtcm3_t_rtcmtypes-rtcm3_1014
	drop 0 3104 +field rtcm3_t_rtcmtypes-rtcm3_1002
	drop 0 4640 +field rtcm3_t_rtcmtypes-rtcm3_1003
	drop 0 2592 +field rtcm3_t_rtcmtypes-rtcm3_1015
	drop 0 5664 +field rtcm3_t_rtcmtypes-rtcm3_1004
	drop 0 2592 +field rtcm3_t_rtcmtypes-rtcm3_1016
	drop 0 40 +field rtcm3_t_rtcmtypes-rtcm3_1005
	drop 0 2592 +field rtcm3_t_rtcmtypes-rtcm3_1017
	drop 0 160 +field rtcm3_t_rtcmtypes-rtcm3_1029
	drop 0 48 +field rtcm3_t_rtcmtypes-rtcm3_1006
	drop 0 120 +field rtcm3_t_rtcmtypes-rtcm3_1019
	drop 0 40 +field rtcm3_t_rtcmtypes-rtcm3_1007
	drop 0 72 +field rtcm3_t_rtcmtypes-rtcm3_1008
	drop 0 2592 +field rtcm3_t_rtcmtypes-rtcm3_1009
	drop 0 104 +field rtcm3_t_rtcmtypes-rtcm3_1020
	drop 0 1024 +field rtcm3_t_rtcmtypes-data
	drop 0 136 +field rtcm3_t_rtcmtypes-rtcm3_1033
	drop 0 3104 +field rtcm3_t_rtcmtypes-rtcm3_1010
drop 5664 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1013
begin-structure rtcm3_t_rtcmtypes_rtcm3_1013
	drop 4 2 +field rtcm3_t_rtcmtypes_rtcm3_1013-mjd
	drop 14 192 +field rtcm3_t_rtcmtypes_rtcm3_1013-announcements
	drop 0 4 +field rtcm3_t_rtcmtypes_rtcm3_1013-station_id
	drop 13 1 +field rtcm3_t_rtcmtypes_rtcm3_1013-ncount
	drop 8 4 +field rtcm3_t_rtcmtypes_rtcm3_1013-sod
	drop 12 1 +field rtcm3_t_rtcmtypes_rtcm3_1013-leapsecs
drop 208 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1012
begin-structure rtcm3_t_rtcmtypes_rtcm3_1012
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1012-header
drop 5664 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1011
begin-structure rtcm3_t_rtcmtypes_rtcm3_1011
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1011-header
drop 5664 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1010
begin-structure rtcm3_t_rtcmtypes_rtcm3_1010
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1010-header
drop 3104 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1009
begin-structure rtcm3_t_rtcmtypes_rtcm3_1009
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1009-header
drop 2592 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1008
begin-structure rtcm3_t_rtcmtypes_rtcm3_1008
	drop 4 32 +field rtcm3_t_rtcmtypes_rtcm3_1008-descriptor
	drop 36 4 +field rtcm3_t_rtcmtypes_rtcm3_1008-setup_id
	drop 0 4 +field rtcm3_t_rtcmtypes_rtcm3_1008-station_id
	drop 40 32 +field rtcm3_t_rtcmtypes_rtcm3_1008-serial
drop 72 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1007
begin-structure rtcm3_t_rtcmtypes_rtcm3_1007
	drop 4 32 +field rtcm3_t_rtcmtypes_rtcm3_1007-descriptor
	drop 36 4 +field rtcm3_t_rtcmtypes_rtcm3_1007-setup_id
	drop 0 4 +field rtcm3_t_rtcmtypes_rtcm3_1007-station_id
drop 40 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1002
begin-structure rtcm3_t_rtcmtypes_rtcm3_1002
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1002-header
drop 3104 end-structure
\ rtcm3_t_rtcmtypes_rtcm3_1001
begin-structure rtcm3_t_rtcmtypes_rtcm3_1001
	drop 0 32 +field rtcm3_t_rtcmtypes_rtcm3_1001-header
	drop 32 2560 +field rtcm3_t_rtcmtypes_rtcm3_1001-rtk_data
drop 2592 end-structure
\ rtcm3_1001_t
begin-structure rtcm3_1001_t
	drop 8 32 +field rtcm3_1001_t-L1
	drop 0 4 +field rtcm3_1001_t-ident
drop 40 end-structure
\ rtcm3_1002_t
begin-structure rtcm3_1002_t
	drop 8 40 +field rtcm3_1002_t-L1
	drop 0 4 +field rtcm3_1002_t-ident
drop 48 end-structure
\ rtcm3_1003_t
begin-structure rtcm3_1003_t
	drop 0 32 +field rtcm3_1003_t-header
	drop 32 4608 +field rtcm3_1003_t-rtk_data
drop 4640 end-structure
\ rtcm3_1003_t_rtk_data
begin-structure rtcm3_1003_t_rtk_data
	drop 8 32 +field rtcm3_1003_t_rtk_data-L1
	drop 0 4 +field rtcm3_1003_t_rtk_data-ident
	drop 40 32 +field rtcm3_1003_t_rtk_data-L2
drop 72 end-structure
\ rtcm3_1004_t
begin-structure rtcm3_1004_t
	drop 0 32 +field rtcm3_1004_t-header
	drop 32 5632 +field rtcm3_1004_t-rtk_data
drop 5664 end-structure
\ rtcm3_1004_t_rtk_data
begin-structure rtcm3_1004_t_rtk_data
	drop 8 40 +field rtcm3_1004_t_rtk_data-L1
	drop 0 4 +field rtcm3_1004_t_rtk_data-ident
	drop 48 40 +field rtcm3_1004_t_rtk_data-L2
drop 88 end-structure
\ rtcm3_1005_t
begin-structure rtcm3_1005_t
	drop 16 8 +field rtcm3_1005_t-ecef_x
	drop 0 4 +field rtcm3_1005_t-station_id
	drop 9 1 +field rtcm3_1005_t-single_receiver
	drop 24 8 +field rtcm3_1005_t-ecef_y
	drop 32 8 +field rtcm3_1005_t-ecef_z
	drop 4 4 +field rtcm3_1005_t-system
	drop 8 1 +field rtcm3_1005_t-reference_station
drop 40 end-structure
\ rtcm3_1006_t
begin-structure rtcm3_1006_t
	drop 16 8 +field rtcm3_1006_t-ecef_x
	drop 0 4 +field rtcm3_1006_t-station_id
	drop 9 1 +field rtcm3_1006_t-single_receiver
	drop 24 8 +field rtcm3_1006_t-ecef_y
	drop 32 8 +field rtcm3_1006_t-ecef_z
	drop 4 4 +field rtcm3_1006_t-system
	drop 40 8 +field rtcm3_1006_t-height
	drop 8 1 +field rtcm3_1006_t-reference_station
drop 48 end-structure
\ rtcm3_1009_t
begin-structure rtcm3_1009_t
	drop 8 32 +field rtcm3_1009_t-L1
	drop 0 4 +field rtcm3_1009_t-ident
drop 40 end-structure
\ rtcm3_1010_t
begin-structure rtcm3_1010_t
	drop 8 40 +field rtcm3_1010_t-L1
	drop 0 4 +field rtcm3_1010_t-ident
drop 48 end-structure
\ rtcm3_1011_t
begin-structure rtcm3_1011_t
	drop 8 40 +field rtcm3_1011_t-L1
	drop 0 4 +field rtcm3_1011_t-ident
	drop 48 40 +field rtcm3_1011_t-L2
drop 88 end-structure
\ rtcm3_1012_t
begin-structure rtcm3_1012_t
	drop 8 40 +field rtcm3_1012_t-L1
	drop 0 4 +field rtcm3_1012_t-ident
	drop 48 40 +field rtcm3_1012_t-L2
drop 88 end-structure
\ rtcm3_1013_t
begin-structure rtcm3_1013_t
	drop 2 1 +field rtcm3_1013_t-sync
	drop 0 2 +field rtcm3_1013_t-id
	drop 4 2 +field rtcm3_1013_t-interval
drop 6 end-structure
\ rtcm3_1014_t
begin-structure rtcm3_1014_t
	drop 0 4 +field rtcm3_1014_t-network_id
	drop 4 4 +field rtcm3_1014_t-subnetwork_id
	drop 12 4 +field rtcm3_1014_t-master_id
	drop 8 4 +field rtcm3_1014_t-stationcount
	drop 24 8 +field rtcm3_1014_t-d_lat
	drop 32 8 +field rtcm3_1014_t-d_lon
	drop 40 8 +field rtcm3_1014_t-d_alt
	drop 16 4 +field rtcm3_1014_t-aux_id
drop 48 end-structure
\ rtcm3_1015_t
begin-structure rtcm3_1015_t
	drop 32 2560 +field rtcm3_1015_t-corrections
	drop 0 32 +field rtcm3_1015_t-header
drop 2592 end-structure
\ rtcm3_1016_t
begin-structure rtcm3_1016_t
	drop 32 2560 +field rtcm3_1016_t-corrections
	drop 0 32 +field rtcm3_1016_t-header
drop 2592 end-structure
\ rtcm3_1017_t
begin-structure rtcm3_1017_t
	drop 32 2560 +field rtcm3_1017_t-corrections
	drop 0 32 +field rtcm3_1017_t-header
drop 2592 end-structure
\ rtcm3_1019_t
begin-structure rtcm3_1019_t
	drop 88 4 +field rtcm3_1019_t-C_sub_is
	drop 96 4 +field rtcm3_1019_t-C_sub_rc
	drop 80 4 +field rtcm3_1019_t-C_sub_ic
	drop 8 1 +field rtcm3_1019_t-sv_accuracy
	drop 4 4 +field rtcm3_1019_t-week
	drop 104 4 +field rtcm3_1019_t-omegadot
	drop 108 4 +field rtcm3_1019_t-t_sub_GD
	drop 112 1 +field rtcm3_1019_t-sv_health
	drop 114 1 +field rtcm3_1019_t-fit_interval
	drop 28 4 +field rtcm3_1019_t-t_sub_oc
	drop 40 4 +field rtcm3_1019_t-a_sub_f0
	drop 0 4 +field rtcm3_1019_t-ident
	drop 52 4 +field rtcm3_1019_t-delta_sub_n
	drop 36 4 +field rtcm3_1019_t-a_sub_f1
	drop 76 4 +field rtcm3_1019_t-t_sub_oe
	drop 32 4 +field rtcm3_1019_t-a_sub_f2
	drop 72 4 +field rtcm3_1019_t-sqrt_sub_A
	drop 100 4 +field rtcm3_1019_t-argument_of_perigee
	drop 68 4 +field rtcm3_1019_t-C_sub_us
	drop 60 4 +field rtcm3_1019_t-C_sub_uc
	drop 12 4 +field rtcm3_1019_t-code
	drop 56 4 +field rtcm3_1019_t-M_sub_0
	drop 44 4 +field rtcm3_1019_t-iodc
	drop 84 4 +field rtcm3_1019_t-OMEGA_sub_0
	drop 92 4 +field rtcm3_1019_t-i_sub_0
	drop 16 8 +field rtcm3_1019_t-idot
	drop 24 1 +field rtcm3_1019_t-iode
	drop 113 1 +field rtcm3_1019_t-p_data
	drop 48 4 +field rtcm3_1019_t-C_sub_rs
	drop 64 4 +field rtcm3_1019_t-e
drop 120 end-structure
\ rtcm3_1020_t
begin-structure rtcm3_1020_t
	drop 64 4 +field rtcm3_1020_t-tau_n_of_t_sub_b
	drop 56 4 +field rtcm3_1020_t-gamma_sub_n_of_t_sub_b
	drop 44 4 +field rtcm3_1020_t-z_sub_n_t_of_t_sub_b
	drop 14 1 +field rtcm3_1020_t-t_sub_b
	drop 20 4 +field rtcm3_1020_t-x_sub_n_t_of_t_sub_b
	drop 32 4 +field rtcm3_1020_t-y_sub_n_t_of_t_sub_b
	drop 72 4 +field rtcm3_1020_t-E_sub_n
	drop 68 4 +field rtcm3_1020_t-M_delta_tau_sub_n
	drop 6 1 +field rtcm3_1020_t-C_sub_n
	drop 48 4 +field rtcm3_1020_t-z_sub_n_t_of_t_sub_b_prime_prime
	drop 36 4 +field rtcm3_1020_t-y_sub_n_t_of_t_sub_b_prime_prime
	drop 24 4 +field rtcm3_1020_t-x_sub_n_t_of_t_sub_b_prime_prime
	drop 7 1 +field rtcm3_1020_t-health_avAilability_indicator
	drop 96 4 +field rtcm3_1020_t-M_tau_sub_GPS
	drop 0 4 +field rtcm3_1020_t-ident
	drop 10 2 +field rtcm3_1020_t-t_sub_k
	drop 80 1 +field rtcm3_1020_t-additioinal_data_availability
	drop 12 1 +field rtcm3_1020_t-msb_of_B_sub_n
	drop 100 1 +field rtcm3_1020_t-M_l_sub_n
	drop 40 4 +field rtcm3_1020_t-z_sub_n_t_of_t_sub_b_prime
	drop 16 4 +field rtcm3_1020_t-x_sub_n_t_of_t_sub_b_prime
	drop 28 4 +field rtcm3_1020_t-y_sub_n_t_of_t_sub_b_prime
	drop 8 1 +field rtcm3_1020_t-P1
	drop 13 1 +field rtcm3_1020_t-P2
	drop 52 1 +field rtcm3_1020_t-P3
	drop 76 1 +field rtcm3_1020_t-MP4
	drop 84 4 +field rtcm3_1020_t-N_sup_A
	drop 79 1 +field rtcm3_1020_t-MM
	drop 78 1 +field rtcm3_1020_t-MN_sub_T
	drop 77 1 +field rtcm3_1020_t-MF_sub_T
	drop 60 1 +field rtcm3_1020_t-MP
	drop 4 2 +field rtcm3_1020_t-channel
	drop 88 4 +field rtcm3_1020_t-tau_sub_c
	drop 92 4 +field rtcm3_1020_t-M_N_sub_4
	drop 61 1 +field rtcm3_1020_t-Ml_n
drop 104 end-structure
\ rtcm3_1029_t
begin-structure rtcm3_1029_t
	drop 4 2 +field rtcm3_1029_t-mjd
	drop 24 8 +field rtcm3_1029_t-unicode_units
	drop 0 4 +field rtcm3_1029_t-station_id
	drop 16 8 +field rtcm3_1029_t-len
	drop 8 4 +field rtcm3_1029_t-sod
	drop 32 128 +field rtcm3_1029_t-text
drop 160 end-structure
\ rtcm3_1033_t
begin-structure rtcm3_1033_t
	drop 4 32 +field rtcm3_1033_t-descriptor
	drop 36 4 +field rtcm3_1033_t-setup_id
	drop 0 4 +field rtcm3_1033_t-station_id
	drop 72 32 +field rtcm3_1033_t-receiver
	drop 40 32 +field rtcm3_1033_t-serial
	drop 104 32 +field rtcm3_1033_t-firmware
drop 136 end-structure
\ almanac_t
begin-structure almanac_t
	drop 88 8 +field almanac_t-d_af0
	drop 40 8 +field almanac_t-d_M0
	drop 128 4 +field almanac_t-sqrtA
	drop 104 8 +field almanac_t-d_af1
	drop 72 8 +field almanac_t-d_omega
	drop 56 8 +field almanac_t-d_Omega0
	drop 16 1 +field almanac_t-svh
	drop 120 8 +field almanac_t-d_eccentricity
	drop 152 8 +field almanac_t-d_Omegad
	drop 0 1 +field almanac_t-sv
	drop 48 4 +field almanac_t-Omega0
	drop 64 4 +field almanac_t-omega
	drop 18 2 +field almanac_t-deltai
	drop 144 2 +field almanac_t-Omegad
	drop 80 2 +field almanac_t-af0
	drop 96 2 +field almanac_t-af1
	drop 136 8 +field almanac_t-d_sqrtA
	drop 32 4 +field almanac_t-M0
	drop 24 8 +field almanac_t-d_deltai
	drop 8 8 +field almanac_t-l_toa
	drop 1 1 +field almanac_t-toa
	drop 112 2 +field almanac_t-e
drop 160 end-structure
\ subframe_t
begin-structure subframe_t
	drop 24 160 +field subframe_t-sub5
	drop 24 24 +field subframe_t-sub4_17
	drop 24 184 +field subframe_t-sub4_18
	drop 1 1 +field subframe_t-data_id
	drop 24 48 +field subframe_t-sub5_25
	drop 0 1 +field subframe_t-subframe_num
	drop 18 1 +field subframe_t-antispoof
	drop 8 8 +field subframe_t-l_TOW17
	drop 20 4 +field subframe_t-is_almanac
	drop 17 1 +field subframe_t-alert
	drop 24 88 +field subframe_t-sub1
	drop 3 1 +field subframe_t-tSVID
	drop 2 1 +field subframe_t-pageid
	drop 16 1 +field subframe_t-integrity
	drop 24 128 +field subframe_t-sub2
	drop 4 4 +field subframe_t-TOW17
	drop 24 34 +field subframe_t-sub4_13
	drop 24 41 +field subframe_t-sub4_25
	drop 24 128 +field subframe_t-sub3
	drop 24 160 +field subframe_t-sub4
drop 208 end-structure
\ route_info
begin-structure route_info
	drop 36 128 +field route_info-waypoints
	drop 16 4 +field route_info-day
	drop 28 4 +field route_info-duration
	drop 32 4 +field route_info-waycount
	drop 4 4 +field route_info-sender
	drop 8 4 +field route_info-rtype
	drop 12 4 +field route_info-month
	drop 20 4 +field route_info-hour
	drop 24 4 +field route_info-minute
	drop 0 4 +field route_info-linkage
drop 164 end-structure
\ waypoint_t
begin-structure waypoint_t
	drop 0 4 +field waypoint_t-lon
	drop 4 4 +field waypoint_t-lat
drop 8 end-structure
\ ais_t
begin-structure ais_t
	drop 8 4 +field ais_t-mmsi
	drop 16 192 +field ais_t-type8
	drop 16 64 +field ais_t-type20
	drop 16 44 +field ais_t-type9
	drop 16 84 +field ais_t-type21
	drop 16 4 +field ais_t-type10
	drop 16 40 +field ais_t-type22
	drop 16 36 +field ais_t-type23
	drop 16 168 +field ais_t-type12
	drop 16 72 +field ais_t-type24
	drop 16 40 +field ais_t-type25
	drop 16 161 +field ais_t-type14
	drop 16 160 +field ais_t-type26
	drop 4 4 +field ais_t-repeat
	drop 16 32 +field ais_t-type15
	drop 16 28 +field ais_t-type27
	drop 16 24 +field ais_t-type16
	drop 16 112 +field ais_t-type17
	drop 16 48 +field ais_t-type1
	drop 16 48 +field ais_t-type18
	drop 0 4 +field ais_t-type
	drop 16 96 +field ais_t-type19
	drop 16 48 +field ais_t-type4
	drop 16 112 +field ais_t-type5
	drop 16 272 +field ais_t-type6
	drop 16 32 +field ais_t-type7
drop 288 end-structure
\ cargo_t
begin-structure cargo_t
	drop 0 4 +field cargo_t-code
	drop 4 4 +field cargo_t-subtype
drop 8 end-structure
\ tidal_t
begin-structure tidal_t
	drop 0 4 +field tidal_t-lon
	drop 24 4 +field tidal_t-cdir
	drop 12 4 +field tidal_t-from_min
	drop 16 4 +field tidal_t-to_hour
	drop 28 4 +field tidal_t-cspeed
	drop 8 4 +field tidal_t-from_hour
	drop 20 4 +field tidal_t-to_min
	drop 4 4 +field tidal_t-lat
drop 32 end-structure
\ gauge_t
begin-structure gauge_t
	drop 4 4 +field gauge_t-level
	drop 0 4 +field gauge_t-id
drop 8 end-structure
\ target_id
begin-structure target_id
	drop 0 4 +field target_id-imo
	drop 0 8 +field target_id-callsign
	drop 0 4 +field target_id-mmsi
	drop 0 8 +field target_id-other
drop 8 end-structure
\ target_t
begin-structure target_t
	drop 16 4 +field target_t-lon
	drop 4 8 +field target_t-id
	drop 24 4 +field target_t-second
	drop 0 4 +field target_t-idtype
	drop 28 4 +field target_t-speed
	drop 12 4 +field target_t-lat
	drop 20 4 +field target_t-course
drop 32 end-structure
\ satellite_t
begin-structure satellite_t
	drop 35 1 +field satellite_t-freqid
	drop 36 1 +field satellite_t-health
	drop 0 8 +field satellite_t-ss
	drop 16 8 +field satellite_t-elevation
	drop 33 1 +field satellite_t-svid
	drop 34 1 +field satellite_t-sigid
	drop 8 1 +field satellite_t-used
	drop 24 8 +field satellite_t-azimuth
	drop 32 1 +field satellite_t-gnssid
	drop 10 2 +field satellite_t-PRN
drop 40 end-structure
\ attitude_t
begin-structure attitude_t
	drop 40 8 +field attitude_t-acc_z
	drop 154 1 +field attitude_t-roll_st
	drop 96 8 +field attitude_t-mag_x
	drop 144 8 +field attitude_t-yaw
	drop 104 8 +field attitude_t-mag_y
	drop 128 8 +field attitude_t-roll
	drop 112 8 +field attitude_t-mag_z
	drop 153 1 +field attitude_t-pitch_st
	drop 88 8 +field attitude_t-mag_len
	drop 80 8 +field attitude_t-heading
	drop 48 8 +field attitude_t-depth
	drop 155 1 +field attitude_t-yaw_st
	drop 56 8 +field attitude_t-dip
	drop 120 8 +field attitude_t-pitch
	drop 152 1 +field attitude_t-mag_st
	drop 64 8 +field attitude_t-gyro_x
	drop 0 16 +field attitude_t-mtime
	drop 16 8 +field attitude_t-acc_len
	drop 72 8 +field attitude_t-gyro_y
	drop 24 8 +field attitude_t-acc_x
	drop 32 8 +field attitude_t-acc_y
	drop 136 8 +field attitude_t-temp
drop 160 end-structure
\ navdata_t
begin-structure navdata_t
	drop 96 4 +field navdata_t-compass_status
	drop 108 4 +field navdata_t-crosstrack_status
	drop 8 8 +field navdata_t-compass_heading
	drop 56 8 +field navdata_t-depth
	drop 48 8 +field navdata_t-water_temp
	drop 32 8 +field navdata_t-air_temp
	drop 40 8 +field navdata_t-air_pressure
	drop 24 8 +field navdata_t-compass_variation
	drop 16 8 +field navdata_t-compass_deviation
	drop 0 4 +field navdata_t-version
	drop 104 4 +field navdata_t-log_trip
	drop 64 8 +field navdata_t-depth_offset
	drop 88 8 +field navdata_t-crosstrack_error
	drop 100 4 +field navdata_t-log_cumulative
	drop 80 8 +field navdata_t-wind_dir
	drop 72 8 +field navdata_t-wind_speed
drop 112 end-structure
\ dop_t
begin-structure dop_t
	drop 16 8 +field dop_t-pdop
	drop 0 8 +field dop_t-xdop
	drop 8 8 +field dop_t-ydop
	drop 40 8 +field dop_t-tdop
	drop 48 8 +field dop_t-gdop
	drop 24 8 +field dop_t-hdop
	drop 32 8 +field dop_t-vdop
drop 56 end-structure
\ rawdata_t
begin-structure rawdata_t
	drop 16 12320 +field rawdata_t-meas
	drop 0 16 +field rawdata_t-mtime
drop 12336 end-structure
\ meas_t
begin-structure meas_t
	drop 16 8 +field meas_t-codephase
	drop 6 4 +field meas_t-obs_code
	drop 1 1 +field meas_t-svid
	drop 40 8 +field meas_t-deltarange
	drop 72 8 +field meas_t-c2c
	drop 56 4 +field meas_t-locktime
	drop 64 8 +field meas_t-l2c
	drop 4 1 +field meas_t-freqid
	drop 48 8 +field meas_t-doppler
	drop 0 1 +field meas_t-gnssid
	drop 2 1 +field meas_t-sigid
	drop 24 8 +field meas_t-carrierphase
	drop 3 1 +field meas_t-snr
	drop 5 1 +field meas_t-lli
	drop 32 8 +field meas_t-pseudorange
	drop 80 4 +field meas_t-satstat
drop 88 end-structure
\ version_t
begin-structure version_t
	drop 136 128 +field version_t-remote
	drop 64 64 +field version_t-rev
	drop 132 4 +field version_t-proto_minor
	drop 0 64 +field version_t-release
	drop 128 4 +field version_t-proto_major
drop 264 end-structure
\ devconfig_t
begin-structure devconfig_t
	drop 992 1 +field devconfig_t-parity
	drop 132 64 +field devconfig_t-driver
	drop 968 16 +field devconfig_t-activated
	drop 988 4 +field devconfig_t-stopbits
	drop 452 512 +field devconfig_t-hexdata
	drop 1000 16 +field devconfig_t-cycle
	drop 1016 16 +field devconfig_t-mincycle
	drop 1032 4 +field devconfig_t-driver_mode
	drop 196 128 +field devconfig_t-subtype
	drop 128 4 +field devconfig_t-flags
	drop 0 128 +field devconfig_t-path
	drop 324 128 +field devconfig_t-subtype1
	drop 984 4 +field devconfig_t-baudrate
drop 1040 end-structure
\ gps_policy_t
begin-structure gps_policy_t
	drop 4 4 +field gps_policy_t-raw
	drop 9 1 +field gps_policy_t-timing
	drop 12 4 +field gps_policy_t-loglevel
	drop 144 128 +field gps_policy_t-remote
	drop 1 1 +field gps_policy_t-json
	drop 0 1 +field gps_policy_t-watcher
	drop 2 1 +field gps_policy_t-nmea
	drop 10 1 +field gps_policy_t-split24
	drop 11 1 +field gps_policy_t-pps
	drop 8 1 +field gps_policy_t-scaled
	drop 16 128 +field gps_policy_t-devpath
drop 272 end-structure
\ timedelta_t
begin-structure timedelta_t
	drop 0 16 +field timedelta_t-real
	drop 16 16 +field timedelta_t-clock
drop 32 end-structure
\ oscillator_t
begin-structure oscillator_t
	drop 0 1 +field oscillator_t-running
	drop 1 1 +field oscillator_t-reference
	drop 4 4 +field oscillator_t-delta
	drop 2 1 +field oscillator_t-disciplined
drop 8 end-structure
\ gps_data_t
begin-structure gps_data_t
	drop 0 8 +field gps_data_t-set
	drop 400 56 +field gps_data_t-dop
	drop 11576 160 +field gps_data_t-attitude
	drop 11576 784 +field gps_data_t-rtcm2
	drop 24 4 +field gps_data_t-gps_fd
	drop 7392 4184 +field gps_data_t-devices
	drop 11576 5672 +field gps_data_t-rtcm3
	drop 11576 288 +field gps_data_t-ais
	drop 456 16 +field gps_data_t-skyview_time
	drop 23976 8 +field gps_data_t-qErr
	drop 11576 12336 +field gps_data_t-raw
	drop 11576 8 +field gps_data_t-osc
	drop 480 5600 +field gps_data_t-skyview
	drop 7120 272 +field gps_data_t-policy
	drop 11576 208 +field gps_data_t-subframe
	drop 11576 72 +field gps_data_t-gst
	drop 23912 32 +field gps_data_t-toff
	drop 23984 16 +field gps_data_t-qErr_time
	drop 6080 1040 +field gps_data_t-dev
	drop 396 4 +field gps_data_t-satellites_used
	drop 11576 264 +field gps_data_t-version
	drop 32 360 +field gps_data_t-fix
	drop 24000 8 +field gps_data_t-privdata
	drop 11576 112 +field gps_data_t-navdata
	drop 392 4 +field gps_data_t-status
	drop 11576 256 +field gps_data_t-error
	drop 472 4 +field gps_data_t-satellites_visible
	drop 8 16 +field gps_data_t-online
	drop 23944 32 +field gps_data_t-pps
drop 24008 end-structure
\ gps_data_t_devices
begin-structure gps_data_t_devices
	drop 0 16 +field gps_data_t_devices-time
	drop 16 4 +field gps_data_t_devices-ndevices
	drop 24 4160 +field gps_data_t_devices-list
drop 4184 end-structure

\ ------===< functions >===-------
c-function gps_open gps_open s s a -- n	( <noname> <noname> <noname> -- )
c-function gps_close gps_close a -- n	( <noname> -- )
c-function gps_send gps_send a s ... -- n	( <noname> <noname> <noname> -- )
c-function gps_read gps_read a a n -- n	( <noname> message message_len -- )
c-function gps_unpack gps_unpack a a -- n	( <noname> <noname> -- )
c-function gps_waiting gps_waiting a n -- n	( <noname> <noname> -- )
c-function gps_stream gps_stream a u a -- n	( <noname> <noname> <noname> -- )
c-function gps_mainloop gps_mainloop a n a -- n	( <noname> <noname> <noname> -- )
c-function gps_data gps_data a -- s	( <noname> -- )
c-function gps_errstr gps_errstr n -- s	( <noname> -- )
c-function json_toff_read json_toff_read s a a -- n	( buf <noname> <noname> -- )
c-function json_pps_read json_pps_read s a a -- n	( buf <noname> <noname> -- )
c-function json_oscillator_read json_oscillator_read s a a -- n	( buf <noname> <noname> -- )
c-function libgps_trace libgps_trace n s ... -- void	( errlevel <noname> <noname> -- )
c-function gps_clear_att gps_clear_att a -- void	( <noname> -- )
c-function gps_clear_dop gps_clear_dop a -- void	( <noname> -- )
c-function gps_clear_fix gps_clear_fix a -- void	( <noname> -- )
c-function gps_merge_fix gps_merge_fix a ud a -- void	( <noname> <noname> <noname> -- )
c-function gps_enable_debug gps_enable_debug n a -- void	( <noname> <noname> -- )
c-function gps_maskdump gps_maskdump ud -- s	( <noname> -- )
c-function safe_atof safe_atof s -- r	( <noname> -- )
c-function mkgmtime mkgmtime a -- n	( <noname> -- )
\ c-function iso8601_to_timespec iso8601_to_timespec a -- n	( <noname> -- )
\ c-function now_to_iso8601 now_to_iso8601 a n -- a	( <noname> len -- )
\ c-function timespec_to_iso8601 timespec_to_iso8601 n a n -- a	( t <noname> len -- )
c-function earth_distance earth_distance r r r r -- r	( <noname> <noname> <noname> <noname> -- )
c-function earth_distance_and_bearings earth_distance_and_bearings r r r r a a -- r	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function wgs84_separation wgs84_separation r r -- r	( <noname> <noname> -- )
c-function mag_var mag_var r r -- r	( <noname> <noname> -- )
c-function datum_code_string datum_code_string n a n -- void	( code buffer len -- )

\ ----===< postfix >===-----
end-c-library
