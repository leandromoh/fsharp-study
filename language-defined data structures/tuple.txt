// tuples are immutable and support structural equality, hashing, and comparison

// t1 has type int*int

let t1 = (2,3) 

//explicit type of tuple variable

let t2 : int * string = (2, "hello")

// it's the comma you need, not the parentheses
// but it's a good practice to keep them around the values you are matching against

let t3 = 1, 2

// create arbitrary tuples as needed

let z = 1, true, "hello", 3.14   // "construct"
let z1, z2, z3, z4 = z           // "deconstruct"

// if you don't need some of the values, you can use the "don't care" symbol (the underscore) as a placeholder

let _,z5,_,z6 = z     // ignore 1st and 3rd elements