open System.Collections.Generic

let lookupName nm (dict : Dictionary<string, string>) =
 let mutable res = ""
 let exists = dict.TryGetValue(nm, &res)
 if exists then Some res 
 else None

let capitals = new Dictionary<string, string>(HashIdentity.Structural)

capitals.["USA"] <- "Washington"
capitals.["Bangladesh"] <- "Dhaka"

for kvp in capitals do
    printfn "%s has capital %s" kvp.Key kvp.Value

printfn "%A" <| lookupName "USA" capitals // Some "Washington"
printfn "%A" <| lookupName "Brazil" capitals // None
printfn "%A" <| capitals.TryGetValue("Australia") // (false, null)