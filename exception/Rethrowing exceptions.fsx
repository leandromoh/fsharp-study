// If needed, you can call the 'reraise()' function in a catch handler 
// to propagate the same exception up the call chain. 
// This is the same as the C# throw keyword.

let divide x y=
    try
        x / y                      
    with
    | :? System.DivideByZeroException as ex -> 
          printfn "%s" ex.Message
          reraise()

//test
divide 7 2 |> printfn "%d" // 3
divide 1 0 |> printfn "%d" // Unhandled Exception