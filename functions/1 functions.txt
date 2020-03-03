// we can define function with explict types for argument as well return type

let even (x: int) : bool = x % 2 = 0

// we do not need specify the arguments type, the compiler attempts to infer the type from the function body

let even x = x % 2 = 0

// a function body can contain definitions of local variables and functions
// you must use indentation to define scope level inside functions
// final expression of a function is its return value

let cylinderVolume radius length =
    // Define a local value pi.
    let pi = 3.14159
    length * pi * radius * radius