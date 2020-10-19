// multiple methods with the same name, 
// and various uses of methods are distinguished by name, 
// number of arguments, and argument types

type Math() =

    // different number of arguments
    member x.Sum(a: int, b: int, c: int) = a + b + c

    member x.Sum(a: int, b: int) = a + b

    // same number of arguments but different type
    member x.Sum(a: double, b: double) = a + b
