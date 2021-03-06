// private values that hold the data for properties are called backing stores
// compiler can create the backing store automatically
// use the keywords member val, omit the self-identifier, then provide an expression to initialize the property
// if the property is to be mutable, include with get, set

type MyClass(property1 : int) =
  member val Property1 = property1
  member val Property2 = "" with get, set

// automatically implemented properties are part of the initialization of a type
// so they must be included before any other member definitions
// just like let bindings and do bindings in a type definition

// the expression that initializes an automatically implemented property is only evaluated upon object initialization, 
// not every time the property is accessed
// This behavior is in contrast to the behavior of an explicitly implemented property

type MyClass() =
    let random  = new System.Random()
    member val AutoProperty = random.Next() with get, set
    member this.ExplicitProperty = random.Next()

let class1 = new MyClass()

printfn "class1.AutoProperty = %d" class1.AutoProperty         // 1853799794
printfn "class1.AutoProperty = %d" class1.AutoProperty         // 1853799794
printfn "class1.ExplicitProperty = %d" class1.ExplicitProperty // 978922705
printfn "class1.ExplicitProperty = %d" class1.ExplicitProperty // 1131210765