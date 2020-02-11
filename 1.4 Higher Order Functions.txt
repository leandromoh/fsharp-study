// Higher-order functions are functions that take a function as a parameter or return a function.

let addOne n = n + 1

let doTwice f n = f (f n)

let x = doTwice addOne 10 // 12

// we can also use curry to do something like

let addTwo = doTwice addOne

let x = addTwo 10 // 12