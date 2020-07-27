.( <---) cr
.( Enhanced Require 0.0.0)

variable dict_start   here dict_start !

: .dict ( -- )
   ." : " here dict_start @ - . ." Bytes " cr
;

: require2 
   here dict_start !
   require
   .dict
;

.dict