// A flexible type is equivalent to a generic type that has a constraint 
// that limits the allowed types to types that are compatible with the 
// base or interface type. That is, the following two lines of code are equivalent.

#SomeType
'T when 'T :> SomeType

// Flexible types are useful specifically when the automatic conversion 
// to types higher in the type hierarchy does not occur but you still 
// want to enable your functionality to work with any type in the 
// hierarchy or any type that implements an interface.

let iterate1 (f : unit -> seq<int>) =
    for e in f() do printfn "%d" e

let iterate2 (f : unit -> #seq<int>) =
    for e in f() do printfn "%d" e



let receive1 (l : seq<int>) =
    for e in l do printfn "%d" e
    l

let receive2 (l : 'T :> seq<int>) =
    for e in l do printfn "%d" e
    l

let receive3<'T when 'T :> seq<int>> (l : 'T)  =
    for e in l do printfn "%d" e
    l

let receive4 (l : 'T when 'T :> seq<int>)  =
    for e in l do printfn "%d" e
    l

let receive5 (l : #seq<int>)  =
    for e in l do printfn "%d" e
    l


// Passing a function that takes a list requires a cast.
iterate1 (fun () -> [1] :> seq<int>)

// Passing a function that takes a list to the version that specifies a
// flexible type as the return value is OK as is.
iterate2 (fun () -> [1])

receive1 [2] |> ignore
receive2 [2] |> ignore
receive3 [2] |> ignore
receive4 [2] |> ignore
receive5 [2] |> ignore