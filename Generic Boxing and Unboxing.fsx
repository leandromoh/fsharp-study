// Two useful generic functions convert any F# data to 
// and from the universal type System.Object (the F# type obj)

val box : 'T -> obj
val unbox : obj -> 'T

> let stringObj = box "abc";;
val stringObj : obj = "abc"

> (unbox<string> stringObj);;
val it : string = "abc"

> (unbox stringObj : string);;
val it : string = "abc"