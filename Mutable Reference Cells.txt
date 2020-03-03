// ref cells are essentially implemented by a very simple record (FSharp.Core.Ref<'T>) that contains a mutable record field
// use the ref operator before a value to create a new reference cell that encapsulates the value
// you can then change the underlying value because it is mutable.
// a reference cell holds an actual value; it is not just an address.
// when you create a reference cell by using the ref operator, 
// you create a copy of the underlying value as an encapsulated mutable value.
// you can dereference a reference cell by using the ! (bang) operator.

let x = ref 1
printfn "%d" !x // 1
x := 3
printfn "%d" !x // 3

// A notable difference between ref and mutable is that let mutable stores the
// mutable value on the stack (as a mutable variable in C#) while ref stores the
// mutable value in a field of a heap-allocated record.
// Thanks to this, mutable values that use ref can be aliased - meaning that you can create two values that reference the same mutable value

let a = ref 5  // allocates a new record on the heap
let b = a      // b references the same record
b := 10        // modifies the value of 'a' as well!
printfn "%d %d" !a !b // 10 10


let mutable c = 5 // mutable value on the stack
let mutable d = c // new mutable value initialized to current value of 'a'
d <- 10           // modifies the value of 'b' only!

printfn "%d %d" c d // 5 10

// another difference is that mutables are easy to use and efficient (no wrapping), 
// but could not be captured in lambdas until F# 4.0. 
// Ref cells can be captured, but are verbose and less efficient
// When using F# 4.0 you don't need to use ref cells as much as with previous versions of F#, 
// as a single “let mutable” can usually be used as an alternative.