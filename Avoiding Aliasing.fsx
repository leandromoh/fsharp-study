// Like all mutable objects, two names referring to mutable 
// record values may refer to the same storage
// location—this is called aliasing. 
// Aliasing of mutable data can lead to problems in understanding code

type Cell = { mutable id : int }

let cellx = { id = 3 } 
let celly = cellx // same location
let cellz = { cellx with id = cellx.id }

cellx.id <- 8

printfn "%A" cellx.id // 8
printfn "%A" celly.id // 8
printfn "%A" cellz.id // 3

printfn "%b" <| obj.ReferenceEquals(cellx, celly) //true
printfn "%b" <| obj.ReferenceEquals(celly, cellz) //false