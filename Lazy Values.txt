// Lazy expressions are expressions that are not evaluated immediately, 
// but are instead evaluated when the result is needed. 
// This can help to improve the performance of your code.
// lazy keyword is an alias for FSharp.Control.Lazy<'T> type
// To force the expressions to be performed, you call the method Force.
// Force causes the execution to be performed only one time. 
// Subsequent calls to Force return the same result, but do not execute any code.


let sixtyWithSideEffect = lazy (printfn "Hello world"; 30 + 30);;

sixtyWithSideEffect.Force() |> printfn "%d" // prints Hello world 60
sixtyWithSideEffect.Force() |> printfn "%d" // prints 60