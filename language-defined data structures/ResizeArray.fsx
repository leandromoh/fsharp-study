// System.Collections.Generic.List<'T>, which, 
// although named List, is better described as a resizable array
//has the following type alias for this purpose:

type ResizeArray<'T> = System.Collections.Generic.List<'T>

// Example

let names = new ResizeArray<string>()

for name in ["Claire"; "Sophie"; "Jane"] do
 names.Add(name);

printfn "%s" names.[2]