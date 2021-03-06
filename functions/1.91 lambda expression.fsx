// A lambda expression is an unnamed function
// You define lambda expressions by using the fun keyword. 
// A lambda expression resembles a function definition
// except that instead of the = token, 
// the -> token is used to separate the argument list from the function body.

// instead of doing

let addOne n = n + 1

let doTwice f n = f (f n)

let addTwo = doTwice addOne

// we can simplify to

let addTwo = doTwice (fun n -> n + 1)