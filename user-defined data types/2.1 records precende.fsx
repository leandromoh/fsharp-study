// if two or more record types has the same signature, 
// the most recently declared type take precedence over those of the previously declared type
// to avoid ambiguity, you can explicitly specify the record type, as in the following code

type Point   = { X: float; Y: float; Z: float }
type Point3D = { X: float; Y: float; Z: float }

let myPoint3D  = {       X = 1.0; Y = 1.0; Z = 0.0; }
let myPoint1   = { Point.X = 1.0; Y = 1.0; Z = 0.0; }

// or

let myPoint2 = { Point.X = 1.0; Point.Y = 1.0; Point.Z = 0.0; }

// or using explicit type annotation for the whole value

let myPoint3 = ({ X = 1.0; Y = 1.0; Z = 0.0; } : Point)