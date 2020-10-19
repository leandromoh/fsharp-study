// The try-with and the try-finally expressions are distinct 
// and cannot be combined directly into a single expression. 
// Instead, you will have to nest them as circumstances require.

exception InnerError of string
exception OuterError of string

let func1 x y =
   try
      try
         if x = y then raise (InnerError("inner error"))
         else raise (OuterError("outer error"))
      with
         | InnerError(str) -> printfn "Error:%s" str
   finally
      printfn "From the finally block."

let func2 x y =
   try
      func1 x y
   with
      | OuterError(str) -> printfn "Error: %s" str

func2 100 150
func2 100 100

// outputs

// From the finally block.
// Error: outer error
// Error:inner error
// From the finally block.