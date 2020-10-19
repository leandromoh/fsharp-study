// 'T list and list<'T> both syntaxe works for generic types 
// In general, the style TypeName<'T> is preferred for F# types, 
// for historical reasons, the style 'T TypeName is used for list, option, reference, and array types.

let rec map<'T, 'U> (f : 'T -> 'U) (l : 'T list) =
 match l with
 | h :: t -> f h :: map f t
 | [] -> []

printfn "%A" <| map (fun x -> x * x) [ 1..10 ]

// <'T, 'U> is optional

let rec map (f : 'T -> 'U) (l : 'T list) =

// as well type arguments (in this case)

let rec map f l =