require ../num/fr.fs
require ../num/n.fs

variable n1 
variable n2 
variable n3
\ variable eps
\ fr 1e-19 eps !

\ : fr 1e-19
\   fr 1e-19 frdup ;

nz 23 n1 !
nq 1/3 n2 !
nfr 2.01 n3 !




tests Initialization
t( nz 1 ntype z_type = )
t( nq 1/2 ntype q_type = )
t( nfr 2.01 ntype fr_type = )
t( 8 c_type = )
t( n1 @ nvalue  z 23 z= )
t( n2 @ nvalue q 1/3 q= )
t( n3 @ nvalue fr 2.01 fr 1e-19 fr~abs )
t( n1 @ q_type ntype! n1 @ ntype q_type = ) 
t( n1 @ z_type ntype! n1 @ ntype z_type = ) 
t( n1 @ z 3 nvalue! n1 @ nvalue z 3 z= )
t( n1 @ z 23 nvalue! n1 @ nvalue z 23 z= )
totals

tests Printing
t( nz 12 n. cr true )
t( nq 1/7 n. cr true )
totals

tests Operators
t( nz 17 nfr 3.4 nbefore 2swap 2drop fr 3.4 fr 1e-19 fr~abs  swap z 17 z= and )
t( nz 12 nz 13 opz+ nvalue z 25 z= )
t( nq 1/3 nq 1/2 opq+ nvalue q 5/6 q= )
t( nfr 1.2 nfr 1.3 opfr+ nvalue fr 2.5 fr 1e-19 fr~abs )
t( nz 12 nz 13 opz- nvalue z -1 z= )
t( nq 1/3 nq 1/2 opq- nvalue q -1/6 q= )
t( nfr 1.2 nfr 1.3 opfr- nvalue fr -0.1 fr 1e-19 fr~abs )
t( nz 12 nz 13 opz* nvalue z 156 z= )
t( nq 1/3 nq 1/2 opq* nvalue q 1/6 q= )
t( nfr 1.2 nfr 1.3 opfr* nvalue fr 1.56 fr 1e-19 fr~abs )
totals

tests nop
t( nz 1 nz 2 z_type add_op nop nvalue z 3 z= )
t( nz 1 nz 2 z_type sub_op nop nvalue z -1 z= )
t( nz 1 nz 2 z_type mul_op nop nvalue z 2 z= )
t( nq 1/2 nq 1/2 q_type add_op nop nvalue q 1/1 q= )
t( nq 1/2 nq 1/2 q_type sub_op nop nvalue q 0/1 q= )
t( nq 1/2 nq 1/2 q_type mul_op nop nvalue q 1/4 q= )
t( nfr 2.0 nfr 0.5 fr_type add_op nop nvalue fr 2.5 fr 1e-19 fr~abs )
t( nfr 2.0 nfr 0.5 fr_type sub_op nop nvalue fr 1.5 fr 1e-19 fr~abs )
t( nfr 2.0 nfr 0.5 fr_type mul_op nop nvalue fr 1.0 fr 1e-19 fr~abs )
totals

tests conversion
t( nz 21 nz>q dup nvalue q 21/1 q= swap ntype q_type = and )
t( nz 21 nz>fr dup nvalue fr 21 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nq 1/2 nq>fr dup nvalue fr 0.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nz 65 q_type nconvert dup nvalue q 65/1 q= swap ntype q_type = and )
t( nz 73 fr_type nconvert dup nvalue fr 73 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nq 1/3 fr_type nconvert dup nvalue q 1/3 q>fr fr 1e-19 fr~abs swap ntype fr_type = and )
t( nz 34 nz 35 ncommon-type z_type = swap nvalue z 35 z= rot drop and )
t( nz 23 nq 1/7 ncommon-type q_type = nip swap nvalue q 23/1 q= and )
t( nq 1/8 nz 17 ncommon-type q_type = swap nvalue q 17/1 q= rot drop and )
t( nz 56 nfr 9.01 ncommon-type fr_type = nip swap nvalue fr 56 fr 1e-19 fr~abs and )
t( nq 1/2 nfr 3.14 ncommon-type fr_type = nip swap nvalue fr 0.5 fr 1e-19 fr~abs and )
t( nfr 4.5 nz 37 ncommon-type fr_type = swap nvalue fr 37 fr 1e-19 fr~abs rot drop and )
t( nfr 17.3 nq 1/3 ncommon-type fr_type = swap nvalue q 1/3 q>fr fr 1e-19 fr~abs rot drop and )
totals

tests arithmetics
t( nz 17 nz 13 n+ dup nvalue z 30 z= swap ntype z_type = and )
t( nz 35 nq 1/2 n+ dup nvalue q 71/2 q= swap ntype q_type = and )
t( nq 1/3 nz 36 n+ dup nvalue q 109/3 q= swap ntype q_type = and )
t( nz 41 nfr 2.5 n+ dup nvalue fr 43.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 3.5 nz 42 n+ dup nvalue fr 45.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nq 1/2 nfr 0.5 n+ dup nvalue fr 1 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 0.5 nq 1/2 n+ dup nvalue fr 1 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 1.1 nfr 2.2 n+ dup nvalue fr 3.3 fr 1e-19 fr~abs swap ntype fr_type = and )

t( nz 17 nz 13 n- dup nvalue z 4 z= swap ntype z_type = and )
t( nz 35 nq 1/2 n- dup nvalue q 69/2 q= swap ntype q_type = and )
t( nq 1/3 nz 36 n- dup nvalue q -107/3 q= swap ntype q_type = and )
t( nz 41 nfr 2.5 n- dup nvalue fr 38.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 3.5 nz 42 n- dup nvalue fr -38.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nq 1/2 nfr 0.5 n- dup nvalue fr 0 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 0.5 nq 1/2 n- dup nvalue fr 0 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 1.1 nfr 2.2 n- dup nvalue fr -1.1 fr 1e-19 fr~abs swap ntype fr_type = and )

t( nz 17 nz 13 n* dup nvalue z 221 z= swap ntype z_type = and )
t( nz 35 nq 1/2 n* dup nvalue q 35/2 q= swap ntype q_type = and )
t( nq 1/3 nz 36 n* dup nvalue q 12/1 q= swap ntype q_type = and )
t( nz 41 nfr 2.5 n* dup nvalue fr 102.5 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 3.5 nz 42 n* dup nvalue fr 147 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nq 1/2 nfr 0.5 n* dup nvalue fr 0.25 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 0.5 nq 1/2 n* dup nvalue fr 0.25 fr 1e-19 fr~abs swap ntype fr_type = and )
t( nfr 1.1 nfr 2.2 n* dup nvalue fr 2.42 fr 1e-19 fr~abs swap ntype fr_type = and )
totals




cr

