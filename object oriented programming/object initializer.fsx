open System.Windows.Forms

let form = new Form(Visible = true, TopMost = true, Text = "Welcome to F#")

// The constructor for the System.Windows.Forms.Form class takes no arguments, so in this case the
// named arguments indicate set operations for the given properties. The code is shorthand for this:

open System.Windows.Forms

let form =
 let tmp = new Form()
 tmp.Visible <- true
 tmp.TopMost <- true
 tmp.Text <- "Welcome to F#"
 tmp

// you can mix constructor arguments and property settings in constructor call
// properties are setted after constructor was called

type LabelInfo(size: double) =
    let mutable _size = size
    let mutable text = "" // the default
    let mutable font = "Arial"
    member x.Text with get() = text and set v = text <- v
    member x.Font with get() = font and set v = font <- v
    member x.Size with get() = _size and set v = _size <- v

let x = LabelInfo(size = 4.0, Text = "foo")
printfn "%s %s %f" x.Text x.Font x.Size // foo arial 4.0

let y = LabelInfo(size = 4.0, Text = "foo", Size = 5.)
printfn "%s %s %f" y.Text y.Font y.Size // foo arial 5.0

