// To define an enum you use exactly the same syntax as a union type with empty cases, 
// except that you must specify a constant value for each case, 
// and the constants must all be of the same type 
// (strings are not allowed, only int's or compatible types such bytes and chars).

type SizeUnion = Small | Medium | Large         // union
type ColorEnum = Red=0 | Yellow=1 | Blue=2      // enum

let red = ColorEnum.Red  // Ok
let redInt = int ColorEnum.Red  
let redAgain:ColorEnum = enum redInt // cast to a specified enum type 
let yellowAgain = enum<ColorEnum>(1) // or create directly