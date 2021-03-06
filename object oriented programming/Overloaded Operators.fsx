// When you name a static member (+), 
// then that is really shorthand for the name op_Addition, 
// which is the .NET standard encoded name for addition operators.

type Vector2DWithOperators(dx : float,dy : float) =
    member x.DX = dx
    member x.DY = dy

    static member (+) (v1 : Vector2DWithOperators, v2 : Vector2DWithOperators) =
        Vector2DWithOperators(v1.DX + v2.DX, v1.DY + v2.DY)

    static member (-) (v1 : Vector2DWithOperators, v2 : Vector2DWithOperators) =
        Vector2DWithOperators (v1.DX - v2.DX, v1.DY - v2.DY)

let v1 = new Vector2DWithOperators (3.0, 4.0)
let v2 = v1 + v1

printfn "%A" v2 // {dx = 6; dy = 8}