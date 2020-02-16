type Box(color: string, size: int) =
    let mutable _size = size

// Property that has get only
    member x.Color1 = color

// Alternative syntax for property that has get only
    member x.Color2 with get() = color

// Property that has set only
    member x.Size with set (s) = _size <- s

let x = Box ("green", 5)

printfn "%A %A" x.Color1 x.Color2 // "green" "green"

x.Size <- 5
x.Size <- 8

// No way to print Size property since it is set only