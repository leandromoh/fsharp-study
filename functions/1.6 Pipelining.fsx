let sum a b = a + b
let square a = a * a

// apply 2 to square, then sum 3, then print 7

let x = 2 |> square |> sum 3 
printfn "%d" x

// or simply

2 |> square |> sum 3 |> printfn "%d" // 7

// also works for tuples when function has more than 1 parameter

(2,3) ||> sum |> printfn "%d" // 5

// there is also a right to left pipe

let y = sum <|| (2,3) // 5

// which may replace parenteses, doing

let z = sum 3 <| sum 4 6  // 13

// instead of

let z = sum 3 (sum 4 6)  // 13

// note: sadly, <| operator is left associativity what means that 

let x = sum 3 <| sum 4 <| sum 5 5

// give us an error, because it evaluates to 

let x = (((sum 3) sum 4) sum 5 5)

// instead of 

let x = (sum 3 (sum 4 (sum 5 5)))

// so an alternative way is write

let x = sum 3 << sum 4 <| sum 5 5