// Another form of record construction can be useful when want to change some of the field values of an existing record. 
// This form of the record expression is called the copy and update record expression.
// This expression form doesn’t mutate the values of a record, even if the fields of the original record are mutable.

type Point3D = {X : float; Y : float; Z : float}

let p1 = {X = 3.0; Y = 4.0; Z = 5.0}
let p2 = {p1 with Y = 0.0; Z = 0.0} 

printfn "%A" p2 //  {X = 3.0; Y = 0.0; Z = 0.0;}