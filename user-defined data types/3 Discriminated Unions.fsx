// Discriminated unions (also know as 'sum type') provide support for values that can be one of a number of named cases, 
// possibly each with different values and types. 
// They are an alternative for small object hierarchies. 
// In addition, recursive discriminated unions are used to represent tree data structures.

type Shape =
    | Rectangle of height : float * width : float
    | Circle of radius : float
    | Square of double

// Shape acts like a base type for Rectangle, Circle and Square

let rect = Rectangle(1.3, width = 10.0)
let circ = Circle (1.0)
let squar = Square(5.)

// This code shows that you can either use the named fields in the initialization, 
// or you can rely on the ordering of the fields in the declaration and just provide the values for each field in turn.
// You can mix the ordered fields and named fields, as in the construction of rectangle.