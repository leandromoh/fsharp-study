// In isWordSlow, internal table is rebuilt every time the function isCapitalSlow is applied
// somewhat defeating the point of having an internal table in the first place

let isWordFast (words : string list) =
 printfn "lazy computation x"
 let wordTable = Set.ofList words
 fun word -> wordTable.Contains(word)
 
let isWordSlow (words : string list) word =
 printfn "lazy computation y"
 let wordTable = Set.ofList words
 wordTable.Contains(word)
 

let cities = ["London"; "Paris"; "Warsaw"; "Tokyo"]
let isCapitalFast = isWordFast cities

printfn "%b" <| isCapitalFast "Paris"
printfn "%b" <| isCapitalFast "Rio de Janeiro"

printfn "%b" <| isWordFast cities "Paris"
printfn "%b" <| isWordFast cities "Rio de Janeiro"

let isCapitalSlow = isWordSlow cities

printfn "%b" <| isCapitalSlow "Paris"
printfn "%b" <| isCapitalSlow "Rio de Janeiro"

printfn "%b" <| isWordSlow cities "Paris"
printfn "%b" <| isWordSlow cities "Rio de Janeiro"

// bonus: we can re-write isWordFast function more terse, using "point-free style"

let isWordFast (words : string list) =
 printfn "lazy computation x"
 let wordTable = Set.ofList words
 wordTable.Contains