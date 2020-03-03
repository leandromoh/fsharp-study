open System.Collections.Generic
open System.Diagnostics

let memoize (f : 'T -> 'U) =
    let t = new Dictionary<'T, 'U>(HashIdentity.Structural)
    fun n ->
        if t.ContainsKey n then t.[n]
        else let res = f n
             t.Add (n, res)
             res

let rec fibFast =
    memoize (fun n -> 
             printfn "calculating fib of %d" n
             if n <= 2 then 1 else fibFast (n - 1) + fibFast (n - 2))

let rec fibNotFast n =
    memoize (fun n -> if n <= 2 then 1 else fibNotFast (n - 1) + fibNotFast (n - 2)) n
    
fibFast 5 |> ignore
fibFast 5 |> ignore
fibFast 5 |> ignore

// outputs once

calculating fib of 5
calculating fib of 4
calculating fib of 3
calculating fib of 2
calculating fib of 1