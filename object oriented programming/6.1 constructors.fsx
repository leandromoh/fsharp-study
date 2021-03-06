// classes always have parentheses after the class name (the primary constructor)
// the primary constructor is embedded into the class declaration itself, not a separate method
// constructor parameters automatically become immutable private fields
// constructor parameters types definition are optional if the compiler can use type inference from usage
// constructor signatures always take tuple values as their only parameter

// additional constructors may be added using the new keyword
// additional constructors must invoke the primary constructor

type MyClass1(x: int, y: int) =
   new() = 
     printfn "empty constructor called"
     MyClass1(0, 0)

   member this.X = x
   member this.Y = y
   
let obj1 = MyClass1 (1, 3)
printfn "%d %d" obj1.X obj1.Y // prints 1 3

let obj2 = MyClass1 ()        // prints empty constructor called
printfn "%d %d" obj2.X obj2.Y // prints 0 0