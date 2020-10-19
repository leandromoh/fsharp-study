// Partial Active Patterns
// let you explicitly ignore some possible results
// by returning an option. Their definition uses a 
// special case of _ for the unmatched case.

// Partial Active Patterns can be used as a form of
// testing, whether the input falls into a specific 
// category in the input space while ignoring other options.

let (|Integer|_|) (str:string) =
  match System.Int32.TryParse(str) with
  | (true, i) -> Some i
  | _ -> None

let (|Float|_|) (str: string) =
  let mutable floatvalue = 0.0
  if System.Double.TryParse(str, &floatvalue) then Some(floatvalue)
  else None

let parseNumeric str =
   match str with
     | Integer i -> printfn "%d : Integer" i
     | Float f -> printfn "%f : Floating point" f
     | _ -> printfn "%s : Not matched." str

parseNumeric "1.1"
parseNumeric "0"
parseNumeric "0.0"
parseNumeric "10"
parseNumeric "Something else"


// can return values

open System.Text.RegularExpressions

let (|ParseRegex|_|) regex str =
   let m = Regex(regex).Match(str)
   if m.Success
   then Some (List.tail [ for x in m.Groups -> x.Value ])
   else None

let parseDate str =
   match str with
     | ParseRegex "(\d{1,2})/(\d{1,2})/(\d{1,2})$" [Integer m; Integer d; Integer y]
          -> new System.DateTime(y + 2000, m, d)
     | ParseRegex "(\d{1,2})/(\d{1,2})/(\d{3,4})" [Integer m; Integer d; Integer y]
          -> new System.DateTime(y, m, d)
     | ParseRegex "(\d{1,4})-(\d{1,2})-(\d{1,2})" [Integer y; Integer m; Integer d]
          -> new System.DateTime(y, m, d)
     | _ -> new System.DateTime()

let dt1 = parseDate "12/22/08"
let dt2 = parseDate "1/1/2009"
let dt3 = parseDate "2008-1-15"
let dt4 = parseDate "1995-12-28"
