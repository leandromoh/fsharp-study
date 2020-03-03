// Sometimes you want to match the individual components of the value and also the whole thing. 
// You can use the as keyword for this.

let f x = (x * x, x + x)

match f 3 with 
    // binding to three values: x, y and t
    | (x,y) as t -> 
        printfn "x=%A and y=%A" x y
        printfn "The whole tuple is %A" t