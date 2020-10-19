// You can use named arguments with all dot-notation method calls. 
// Code written using named arguments is often much more
// readable and maintainable than code relying on argument position

open System.Collections.Generic

let d = Dictionary<_, _>()

d.Add("five",  5)
d.Add(key = "six", value = 6)

// named arguments must appear after the positional arguments
// d.Add(key = "seven", 7)  does not compile

d.Add("seven", value = 7)

d.Add(value = 8, key = "eight")

for e in d do
  printfn "%A - %d" e.Key e.Value