// when using pattern matching against one parameter function
// we can simplify definition dramatically by using the function keyword

// this code

let isEven value = 
    match value with 
    | x when (x % 2) = 0 -> true
    | _ -> false

[2..10] |> List.map (fun i ->
        match i with 
        | 2 | 3 | 5 | 7 -> sprintf "%i is prime" i
        | _ -> sprintf "%i is not prime" i
        )

// could be rewritten as

let isEven = function 
| x when (x % 2) = 0 -> true
| _ -> false

[2..10] |> List.map (function 
        | 2 | 3 | 5 | 7 -> printf "prime"
        | _ -> printf "not prime"
        )

// A minor drawback of function compared 
// with match..with is that you can't see 
// the original input value and have to 
// rely on value bindings in the pattern