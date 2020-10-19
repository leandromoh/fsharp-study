// The Dynamic Lookup Operator
// Much like C# 4.0 has the ability to do dynamic lookup, 
// F# also has the same capability, although in a different capacity.
// The language has support for a dynamic 
// lookup get operator ( ? ) and set operator ( ?<- ), 
// but note that I said support and not actual implementation.
// The actual implementation is up to you and how you // want to use it. 

open System.Reflection

let (?) (this : 'Source) (prop : string) : 'Result =
  let p = this.GetType().GetProperty(prop)
  p.GetValue(this, null) :?> 'Result

let (?<-) (this : 'Source) (property : string) (value : 'Value) =
  this.GetType().GetProperty(property).SetValue(this, value, null)

printfn "equal %b" ("foo".Length = "foo"?Length) // true

// http://codebetter.com/matthewpodwysocki/2010/02/05/using-and-abusing-the-f-dynamic-lookup-operator/