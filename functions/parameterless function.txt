// All functions that does not take parameters, should be declared to take one argument of type Unit 
// let functionName () = 42. 
// It will then be called as functionName (). 
// The unit type has only one value, which is ()

let randomInt() = System.Random().Next(1,10) // define function

printfn "%A" <| randomInt() // x
printfn "%A" <| randomInt() // y

let random = System.Random().Next(1,10); // define value

printfn "%A" <| random // z
printfn "%A" <| random // z