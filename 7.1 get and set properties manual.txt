type Box(color: string, size: int) =
    let mutable _color = color
    let mutable _size = size  

// Property that has both get and set defined
    member x.Color
        with get() = _color
        and set(c) = _color <- c

// Alternative syntax for a property that has get and set
    member x.Size = _size
    member x.Size with set (s) = _size <- s

let printBox (x: Box) = printfn "%A %A" x.Color x.Size

let x = Box ("green", 5)

printBox x // "green" 5

x.Color <- "blue"
x.Size <- 8

printBox x // "blue" 8