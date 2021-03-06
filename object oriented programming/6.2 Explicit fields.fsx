// val keyword is used to declare a location to store a value in a class or structure type, without initializing it

// val [ mutable ] [ access-modifier ] field-name : type-name

// By default, explicit fields are public while let bindings in classes are always private.
// The DefaultValue attribute is required on explicit fields in class types that have a primary constructor

type MyType() =
    let mutable myInt1 = 10
    [<DefaultValue>] val mutable myInt2 : int
    [<DefaultValue>] val mutable myString : string
    member this.SetValsAndPrint( i: int, str: string) =
       myInt1 <- i
       this.myInt2 <- i + 1
       this.myString <- str
       printfn "%d %d %s" myInt1 this.myInt2 this.myString

let myObject = new MyType()
myObject.SetValsAndPrint(11, "abc") // prints 11 12 abc

// The following line is not allowed because let bindings are private.
// myObject.myInt1 <- 20

myObject.myInt2 <- 30
myObject.myString <- "def"

printfn "%d %s" myObject.myInt2 myObject.myString // prints 30 def