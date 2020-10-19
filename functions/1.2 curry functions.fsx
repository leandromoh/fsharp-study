// Currying is the process of splitting a function with 
// multiple arguments into a nested chain of one argument functions. 
// Therefore a curried function is a function which takes its arguments
// one at a time, returning a new function at each step.
// All functions in F# are curried.

// lets define a simple function

let sum a b = a + b;

// simple call

let seven = sum 3 4

// that really is

let alsoSeven = ((sum 3) 4)

// what allow us to do something like

let plusThree = sum 3

let sevenAgain = plusThree 4