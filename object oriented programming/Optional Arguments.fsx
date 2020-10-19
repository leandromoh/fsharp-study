// You declare a member argument optional by prefixing the argument name with ?. 
// Within a function implementation, an optional argument always has an option<_> type; 
// for example, an optional argument of type int appears as a value of type option<int> within the // function body. 

type LabelInfo(?text : string, ?font : string) =
    let text = defaultArg text "foo"
    let font = match font with
        | None -> "bar"
        | Some v -> v
    member x.Text = text
    member x.Font = font
    member x.Print() =
        printfn "%s %s" x.Text x.Font

    // simply passes the optional arguments through 
    // to be optional arguments of the constructor
    static member Create(?t, ?f) = 
        new LabelInfo(?text = t, ?font = f)

// val defaultArg : 'T option -> 'T-> 'T

// Optional arguments must always appear last in the set of arguments accepted by a method. 
// They're usually used as named arguments by callers. 
// At the call site, this is done using the syntax argument-name = argument-value. 
// If the argument has type T option, then argument-value must have type T

LabelInfo().Print() // foo bar

LabelInfo("hello").Print() // hello bar

LabelInfo("hello", "world").Print() // hello world

LabelInfo(font = "world").Print() // foo world

LabelInfo(text = "hello", ?font = Some "world").Print() // hello world