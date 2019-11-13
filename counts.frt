: counts ( limit counter -- )
    DO I . LOOP
;

: odd ( n -- f )
    2 mod 
;

: avalanche ( n -- )
    BEGIN
        dup 2 mod
            IF 3 * 1+ 
            ELSE 2/ 
            THEN 
        dup . dup
    1 = UNTIL
    drop
;

: range ( n1 n2 -- )
    swap
    DO
    I .
    I 50 >= IF LEAVE THEN
    LOOP
;

: star ( -- )
    ." *"
;

: stars ( n -- n )
dup 0 do star loop
;

: box ( n1 n2 -- )
page swap 0 do stars cr loop drop
;

: /box ( height width -- )
page swap 0 do dup i - spaces stars cr loop drop
;



: midline ( n -- )
    star 2 * 1 - spaces star cr
;

: firstline ( n -- )
    spaces star cr
;

: line ( n current -- )
    swap  over - 1- spaces star
    dup 0= IF
    cr drop else
    2* 1- spaces star cr then
;

: diamond ( n -- )
    page
    dup 0 do 
        dup i line
    loop
    dup 1 > if 
        dup 2- 0 swap do
            dup i line
        -1 +loop
    then
    drop
;

: sigma ( n -- n )
    dup 0 do i + loop
;

: two ( n -- n n )
    dup
;

: ramp ( n -- )
    dup 0 do 
        dup i swap 2 / < if 
        i 1+ 7 min . else 
        dup  i - 7 min . then 
    loop drop
;