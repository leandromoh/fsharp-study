// Class definition

// both access modifiers above are public by default
// every non-static member must have a self-identifier
// no requirement to use a particular word for self-identifier (e.g., this, self, me)
// you can create objects by using a new expression, with or without the optional new keyword

type CustomerName(firstName: string, age: int) = 
    member x.FirstName = firstName
    member x.Age = age

let x =  new CustomerName ("bob", 30) 
let y =      CustomerName ("frank", 22) 

printfn "%A %A" x.FirstName x.Age // bob 30
printfn "%A %A" y.FirstName y.Age // frank 22