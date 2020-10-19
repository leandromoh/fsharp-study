// Complete Active Pattern definition lists all 
// possible cases and nothing else, and the body 
// returns one of the listed cases.

let (|Odd|Even|) number = 
  if number % 2 = 0
  then Even
  else Odd

match 13 with
| Odd -> printfn "is odd"
| Even -> printfn "is even" 

// can return values

let (|RGB|) (col : System.Drawing.Color) =
     RGB( col.R, col.G, col.B )

let printRGB (col: System.Drawing.Color) =
   match col with
   | RGB(r, g, b) -> printfn " Red: %d Green: %d Blue: %d" r g b