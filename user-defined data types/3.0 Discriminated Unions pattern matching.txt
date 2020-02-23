type Shape =
    | Rectangle of height : float * width : float
    | Circle of radius : float
    | Square of double

let rect = Rectangle(1.3, width = 10.0)
let circ = Circle (1.0)
let squar = Square(5.)

let pi = 3.141592654

let area myShape =
    match myShape with
    | Rectangle (h, w) -> h * w
    | Circle r -> pi * r * r
    | Square s -> s * s

let printArea = area >> printfn "%A"

printArea rect  // 13.0
printArea circ  // 3.141592654
printArea squar // 25