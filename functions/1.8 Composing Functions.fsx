// When you want to pipe the output of one function 
// into another you can use the pipelining operation
// or you can use the composition operation, ">>"

let square a = a * a
let double b = b * 2

let squareThenDouble = square >> double
printfn "%d" (squareThenDouble 3) // 18 similar to 3 |> square |> double

// the same way, we could do

let squareThenDouble = double << square 