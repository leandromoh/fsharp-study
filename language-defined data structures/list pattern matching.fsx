let oneToEleven =  [ 1..11 ]

let rec sum1 list = 
    match list with 
    | [] -> 0
    | head::tail -> head + sum1 tail


// Mutable data is often hidden behind an encapsulation boundary

let sum2 list =
    let mutable count = 0
    for e in list do
        count <- count + e
    count

printfn "%A" <| sum1 oneToEleven // 66
printfn "%A" <| sum2 oneToEleven // 66