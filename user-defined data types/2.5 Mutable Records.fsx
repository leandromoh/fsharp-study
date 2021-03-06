// A record is immutable by default, and mutable if one or more of its fields is labeled mutable. 
// This means that record fields can be updated using the <- destructive assignment operator
// Mutable fields are generally used for records that implement the internal state of objects

type Person = {mutable Age: int; Name:string}

let p = {Name="john"; Age=0}

for i in 5..10 do
    p.Age <- i
    printfn "My name is %s and I am %d" p.Name p.Age