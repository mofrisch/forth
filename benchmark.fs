.( Benchmark Tools)

2variable bench
variable expression   0 expression !


: start-bench
   utime bench 2!
;

: stop-bench
   utime bench 2@ d- ( 2dup d. ) d>f 1000e f/ f. ." ms" cr
;

: included-bench ( addr u -- )
    utime bench !
    included s" main" evaluate
    utime bench 2@ d- 2dup d. d>f 1e6 f/ f.
;


: bench  ( -- )
   
   s" ../forth/num/mpz_bench.fs" included-bench
;

: b(  
   ')' parse  
   expression @ 0= if 
      $make expression !
   else
      expression $!
   then
   expression $@ type
   start-bench
   expression $@ evaluate
   stop-bench
;

b( 10000 fct zdrop )
