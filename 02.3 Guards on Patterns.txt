// you can test as part of the pattern match using an additional when clause
// these clauses are known as "guards"

open System

let elementsAreEqual tuple =
    match tuple with
    | (x,y) when x = y -> printfn "both parts are the same"
    | (x,y) when x <> y -> printfn "both parts are different"

let isAM date = 
    match date: DateTime with 
    | x when x.Hour <= 12 -> printfn "AM"
    | _ ->  printfn "PM"

elementsAreEqual (0,0)
elementsAreEqual (0,2)
elementsAreEqual (2,0)

isAM DateTime.Now