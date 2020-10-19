    type 'T MyList =
    | Empty  
    | Cons of 'T * 'T MyList 
    
    let rec (++) xs ys =
        match xs, ys with
        | Empty, _ -> ys  
        | Cons (head, tail), _ -> Cons (head, tail ++ ys)
        
    let a = Cons (1, Cons (2, Empty))  
    let b = Cons (3, Cons (4, Cons (5, Empty)))
    let c = a ++ b 
    
    let (Cons (x, Cons (y, zs))) = c 
    printfn "%d" x 
    printfn "%d" y 
    printfn "%A" zs 

type 'a MyNestedList = 
| Elem of 'a  
| Nested of 'a MyNestedList list

let z = Nested [Elem 1; Nested [Elem 2; Nested [Elem 3; Elem 4]; Elem 5]; Elem 6]

printfn "%A" z