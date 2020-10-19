// you cannot define an infix function in F#, just a custom infix operator

let sum a b = a + b
let sum4 = sum 4
let sum5 = (+) 5
let (!) (s: string) = s.ToUpper() 

printf "%d" <| sum4 4
printf "%d" <| sum5 5
printf "%d" <| (+) 6 6
printf "%d" <| 6 + 6
printf "%s" <| !"hello world"