\ location+sensor services

require jni-helper.fs

also jni

jni-class: android/location/Location

jni-method: getAccuracy getAccuracy ()F
jni-method: getBearing getBearing ()F
jni-method: getAltitude getAltitude ()D
jni-method: getLatitude getLatitude ()D
jni-method: getLongitude getLongitude ()D
jni-method: getProvider getProvider ()Ljava/lang/String;
jni-method: getSpeed getSpeed ()F
jni-method: getTime getTime ()J

jni-class: android/location/LocationManager

jni-method: getAllProviders getAllProviders ()Ljava/util/List;
jni-method: getProviders getProviders (Z)Ljava/util/List;
jni-method: lm-getProvider getProvider (Ljava/lang/String;)Landroid/location/LocationProvider;
jni-method: getLastKnownLocation getLastKnownLocation (Ljava/lang/String;)Landroid/location/Location;

jni-class: android/hardware/Sensor

-1 Constant TYPE_ALL
$01 Constant TYPE_ACCELEROMETER
$02 Constant TYPE_MAGNETIC_FIELD
$03 Constant TYPE_ORIENTATION \ deprecated API-8
$04 Constant TYPE_GYROSCOPE
$05 Constant TYPE_LIGHT
$06 Constant TYPE_PRESSURE
$07 Constant TYPE_TEMPERATURE \ deprecated API-14
$08 Constant TYPE_PROXIMITY
$09 Constant TYPE_GRAVITY
$0A Constant TYPE_LINEAR_ACCELERATION
$0B Constant TYPE_ROTATION_VECTOR
$0C Constant TYPE_RELATIVE_HUMIDITY
$0D Constant TYPE_AMBIENT_TEMPERATURE
$0E Constant TYPE_MAGNETIC_FIELD_UNCALIBRATED
$0F Constant TYPE_GAME_ROTATION_VECTOR
$10 Constant TYPE_GYROSCOPE_UNCALIBRATED
$11 Constant TYPE_SIGNIFICANT_MOTION
$12 Constant TYPE_STEP_DETECTOR
$13 Constant TYPE_STEP_COUNTER
$14 Constant TYPE_GEOMAGNETIC_ROTATION_VECTOR

0 Constant SENSOR_DELAY_FASTEST
1 Constant SENSOR_DELAY_GAME
2 Constant SENSOR_DELAY_UI
3 Constant SENSOR_DELAY_NORMAL

jni-method: getName getName ()Ljava/lang/String;
jni-method: getResolution getResolution ()F
jni-method: sensor-getType getType ()I
jni-method: getPower getPower ()F

jni-class: android/hardware/SensorManager

jni-method: getSensorList getSensorList (I)Ljava/util/List;
jni-method: getDefaultSensor getDefaultSensor (I)Landroid/hardware/Sensor;

jni-class: android/hardware/SensorEvent

jni-field: se-accuracy accuracy I
jni-field: se-sensor sensor Landroid/hardware/Sensor;
jni-field: se-timestamp timestamp J
jni-field: se-values values [F

gforth-class:

jni-field: startgps startgps Ljava/lang/Runnable;
jni-field: stopgps stopgps Ljava/lang/Runnable;
jni-field: startsensor startsensor Ljava/lang/Runnable;
jni-field: stopsensor stopsensor Ljava/lang/Runnable;
jni-field: argsensor argsensor Landroid/hardware/Sensor;
jni-field: locationManager locationManager Landroid/location/LocationManager;
jni-field: sensorManager sensorManager Landroid/hardware/SensorManager;

also android

: start-gps ( -- )
    "android.permission.ACCESS_COARSE_LOCATION"
    "android.permission.ACCESS_FINE_LOCATION"
    "android.permission.ACCESS_LOCATION_EXTRA_COMMANDS"
    3 ask-permissions
    ['] startgps post-it ;

: stop-gps ( -- ) ['] stopgps post-it ;

: start-sensor ( type delayus -- )
    clazz >o
    argj0 2>r
    0 to argj0
    sensorManager >o getDefaultSensor dup ref> to argsensor ]ref
    ['] startsensor post-it
    2r> to argj0
    o> ;

: stop-sensor ( type -- )
    clazz >o
    sensorManager >o getDefaultSensor dup ref> to argsensor ]ref o>
    ['] stopsensor post-it ;

[IFUNDEF] .deg
    : .2 ( n -- ) s>d <# # # #> type ;
    : fsplit ( r -- r n )  fdup floor fdup f>s f- ;
    : .deg ( degree -- )
	fdup f0< IF ." -" fnegate THEN
	fsplit 0 .r '°' xemit  60e f*
	fsplit .2   ''' xemit  60e f*
	fsplit .2   '"' xemit 100e f*
	f>s .2 ;
[THEN]

: .location ( -- )  location >o
    o 0= IF  ." unknown" cr
    ELSE
	getProvider dup .jstring ]ref
	." Lat: " getLatitude .deg cr
	." Lon: " getLongitude .deg cr
	." Alt: " getAltitude 7 1 0 f.rdp cr
	." Spd: " getSpeed 8 2 0 f.rdp cr
	." Dir: " getBearing 8 2 0 f.rdp cr
	." Tme: " getTime d. cr
	." Acc: " getAccuracy 8 2 0 f.rdp cr
    THEN
    o> ;

: .sensor ( -- )  sensor >o
    o 0= IF  ." unknown"
    ELSE
	se-sensor >o getName .jstring space ref>
	se-values [f@ bounds DO  I sf@ 10 4 0 f.rdp 1 sfloats +LOOP
    THEN cr o> ;

: .sensors ( -- )  clazz >o sensorManager >o TYPE_ALL getSensorList >o
    [: cr sensor-getType . getName .jstring ;] o l-map ref> ref> o> ;

previous previous
