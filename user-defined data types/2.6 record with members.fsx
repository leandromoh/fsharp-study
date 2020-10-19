type Vector2D =
 { DX : float; DY : float }

 // instance property 
 member v.Length = sqrt(v.DX * v.DX + v.DY * v.DY)
 // instance method
 member v.Scale k = { DX = k * v.DX; DY = k * v.DY }
 // static property
 static member Zero = { DX = 0.0; DY = 0.0 }
 // static method
 static member ConstX dx = { DX = dx; DY = 0.0 }

// v is the self-identifier, you can call it this, self, or whatever you fit 
// implementation of a property such as Length is executed each time the 
// property is invoked; in other words, properties are syntactic sugar for method calls
// Like functions, method members can take arguments in either tupled or iterated “curried” form