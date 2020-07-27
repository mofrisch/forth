.( Common Tools 0.0.0)
variable user-include    0 user-include !

: current-file ( -- u addr )
	included-files dup @ swap $@ nip + $@ 
;

: current-file-num ( -- n )
	included-files $@ nip
;

: .du ( n -- )       
	0  <<# #s #> type #>> 
;

: code-l:c ( line pos -- )  
	swap ." :" .du  ." :" .du 
;

: edit-cmd ( addr u -- )
	." code-insiders -g " type \ 0 0 code-l:c
;

: edit-file ( addr u -- )
	['] edit-cmd >string-execute   2dup type   2dup system   drop free throw
;

: in ( "name" | "" -- ) \ include file "name" or last file included by "name"
	(name) dup 0<> if 
  		user-include @ 0= if 
			2dup $make user-include ! 
		else
			2dup user-include $!
		then
   	2dup included
	else 
		user-include @ if
      	user-include $@ included
    	else
      	." no current file"
    	then 
   then
	2drop
;



: ed ( "name" | "" -- )
	user-include @ 0<> if
		user-include $@ edit-file
	else
		." no current file"
	then
;