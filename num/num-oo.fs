require ../gforth/oof.fs
require z.fs

object class num \ "object" is the parent class
method + ( x y -- )
method getValue
method print
method copy
class;

num class int
   cell var value
   how:
      : init ( z -- )  
         value z! ;
      : getValue
         value z@ ;
      : + ( a -- )
         self getValue ~~ swap -rot ~~ z+ value z! drop self ~~ ;
      : print 
         getValue (z.) ;
      : copy
         value @ ;
class;

num class rat
   cell var value
   how:
      : init ( q -- )
         qdup value swap ! drop ;
      : + ( num -- )
         ;
class;

z 1 int : a
z 2 int : b
a copy b + 
a print
b print