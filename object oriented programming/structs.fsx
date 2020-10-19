// It's occasionally useful to direct the F# compiler to use a .NET struct (value type) representation for small,
// generally immutable objects. You can do this by adding a Struct attribute to a class type

[<Struct>]
type Vector2DStruct(dx : float, dy : float) =
 member v.DX = dx
 member v.DY = dy
 member v.Length = sqrt (dx * dx + dy * dy

// Structures cannot participate in inheritance, cannot contain let or do bindings, 
// and cannot recursively contain fields of their own type 
// (although they can contain reference cells that reference their own type)

// Because structures do not allow let bindings, you must declare fields in structures 
// by using the val keyword. The val keyword defines a field and its type but does not 
// allow initialization. Instead, val declarations are initialized to zero or null. 

// In Point2D, two immutable values are defined.
// It also has a member which computes a distance between itself and another Point2D.
// Point2D has an explicit constructor.
// You can create zero-initialized instances of Point2D, or you can
// pass in arguments to initialize the values.

type Point2D =
    struct
        val X: float
        val Y: float
        new(x: float, y: float) = { X = x; Y = y }

        member this.GetDistanceFrom(p: Point2D) =
            let dX = (p.X - this.X) ** 2.0
            let dY = (p.Y - this.Y) ** 2.0
            
            dX + dY
            |> sqrt
    end