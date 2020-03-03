// You can combine multiple patterns on one line, with OR logic and AND logic

let filter123 x =
    match x with 
    | 1 | 2 | 3 -> printfn "Found 1, 2, or 3!" 
    | x -> printfn "%d" x

let detectZeroOR point =
    match point with
    | (0, 0) -> printfn "Both are zero."
    | (0, _) | (_, 0) -> printfn "One zero found."
    | _ -> printfn "Both nonzero."

let detectZeroAND point =
    match point with
    | (0, 0) -> printfn "Both values zero."
    | (var1, var2) & (0, _) -> printfn "First value is 0 in (%d, %d)" var1 var2
    | (var1, var2)  & (_, 0) -> printfn "Second value is 0 in (%d, %d)" var1 var2
    | _ -> printfn "Both nonzero."

for x in 1..9 do filter123 x

detectZeroOR (0, 0)
detectZeroOR (1, 0)
detectZeroOR (0, 10)
detectZeroOR (10, 15)

detectZeroAND (0, 0)
detectZeroAND (1, 0)
detectZeroAND (0, 10)
detectZeroAND (10, 15)