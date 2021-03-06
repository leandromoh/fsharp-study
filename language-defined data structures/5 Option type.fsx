// A very common situation is when you want to represent missing or invalid values
// Now let’s look at a particular union type, the Option type. 
// It is so common and so useful that it is actually built into the language.

type Option<'a> =       // use a generic definition 
   | Some of 'a           // valid value
   | None                 // missing

// The option type is used in the same way as any union type in construction, by specifying one of the two cases, the Some case or the None case:

let validInt = Some 1
let invalidInt = None

[1;2;3;4]  |> List.tryFind (fun x-> x = 3)  // Some 3
[1;2;3;4]  |> List.tryFind (fun x-> x = 10) // None

let doubleMaybeInt x = 
 match x with 
 | Some i -> Some(i * 2)
 | None -> None

// more compact version written using map function of Option module

let doubleMaybeInt x = Option.map (fun v -> v * 2) x