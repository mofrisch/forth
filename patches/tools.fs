variable user-include    
false user-include !

: current-file ( -- u addr )
  included-files dup @ swap $@ nip + $@ 
;

: in ( "name" -- )
  (name) dup 0<> if
    2dup included $make user-include $!
  else 
    user-include @ if
      user-include $@ included
    else
      ." no current file"
    then 
    2drop
  then
;