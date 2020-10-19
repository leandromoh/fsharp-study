// interfaces doesn’t have any constructors
// This is how F# infers that it’s an object interface type.

// You can specify multiple parameters in two ways: F#-style and .NET-style. 
// Both will compile the same way for .NET consumers, but
// F#-style   will force F# callers to use F#-style parameter application and 
// .NET-style will force F# callers to use tupled argument application.

type IMultiply =
   abstract member Multiply : int -> int -> int   // F#-style

type ISum =
   abstract member Sum : a: int * b: int -> int   // .NET-style

type SomeClass1(x: int, y: float) =

   interface IMultiply with
      member this.Multiply a b = 
      let c = a * b
      printfn "%d" c
      c

   interface ISum with
      member this.Sum (a: int, b: int) =
        let c = a + b
        printfn "%d" c
        c

let x1 = new SomeClass1(1, 2.0)
(x1 :> IMultiply).Multiply 2 3 // 6
(x1 :> ISum).Sum(2, 3)         // 5