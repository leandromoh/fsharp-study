// An interesting but rather unknown usage 
// of Active Patterns in F# is that they can 
// be used to validate and transform function arguments.

let (|Default|) onNone value =
    match value with
    | None -> onNone
    | Some e -> e

let greet (Default "random citizen" name) =
    printfn "Hello, %s!" name

greet None
greet (Some "George")

// they can also be inline

let inline (|NotNull|) v =
  match v with
  | null  -> raise (System.NullReferenceException ())
  | _     -> v

// val g : 'T -> string (requires 'T null)
let g (NotNull v) = v.ToString ()