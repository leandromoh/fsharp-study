// try...with is just an expression, and it may return a result in both branches

exception Error1 of string
exception Error2 of string * int
exception ForbiddenParam of string

let safeDivision x y =
   try
      Some (x / y)
   with
      | :? System.DivideByZeroException -> printfn "Division by zero!"; None

let function1 x y =
   try
      if x = 4 then raise (ForbiddenParam("you shall not pass")) 
      if x = y then raise (Error1("equals"))
      elif x > y then failwith "greater" 
      else raise (Error2("lower", y))
   with
      | Failure(str) -> printfn "Failure %s" str
      | Error1(str) -> printfn "Error1 %s" str
      | Error2(str, i) -> printfn "Error2 %s %d" str i
      | ex -> printfn "Generic exception catched! %s" <| ex.GetType().Name


safeDivision 2 1 |> printfn "%A" // Some 2
safeDivision 2 0 |> printfn "%A" // None

printfn ""

function1 10 10 // Error1 equals
function1 9 2   // Failure greater
function1 1 2   // Error2 lower 2
function1 4 2   // Generic exception catched! ForbiddenParam