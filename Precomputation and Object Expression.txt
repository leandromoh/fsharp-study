open System
open System.Collections.Generic

type INameLookupService =
    abstract Contains : string -> bool

let buildSimpleNameLookup (words : string list) =
    let wordTable = HashSet<_>(words)
    {new INameLookupService with
        member t.Contains w = wordTable.Contains w}

let capitalLookup = buildSimpleNameLookup ["London"; "Paris"; "Warsaw"; "Tokyo"]

capitalLookup.Contains "Paris" |> printfn "%b" // true