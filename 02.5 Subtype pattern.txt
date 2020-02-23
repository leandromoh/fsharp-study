// You can match on subtypes, using the :? operator, which gives you a crude polymorphism
// This checks at compile time for subclasses of a parent class (in this case, Object).

open System
open System.Windows.Forms

let x = new obj()
let y = 
    match x with 
    | :? int -> printfn "matched an int"
    | :? DateTime -> printfn "matched a datetime"
    | _ -> printfn "another type"

let RegisterControl(control:Control) =
    match control with
    | :? Button as button -> button.Text <- "Registered."
    | :? CheckBox as checkbox -> checkbox.Text <- "Registered."
    | _ -> ()