# no interpreter here
function fail {
    printf '\e[0;31;49mGforth postinstall failed!\e[0m\n'
    exit 1
}
printf "\e[0;32;49mGforth postinstall started\e[0m\n"
./gforthmi.sh || fail
printf "\e[0;32;49mGforth image generated, now fixing paths\e[0m\n"
./gforth fixpath.fs gforth-fast.exe ".:/usr/local" ".;$1" || fail
./gforth fixpath.fs gforth-ditc.exe ".:/usr/local" ".;$1" || fail
./gforth fixpath.fs gforth-itc.exe ".:/usr/local" ".;$1" || fail
./gforth-fast fixpath.fs gforth.exe ".:/usr/local" ".;$1" || fail
printf "\e[0;32;49mGforth postinstall succeeded, press key to exit\e[0m\n"
./gforth unix/pthread.fs -e "event: :>bye bye ; : test stacksize4 newtask4 activate 61 1 DO 1000 ms i . LOOP cr <event :>bye [ up@ ]L event> ; test key cr bye"
