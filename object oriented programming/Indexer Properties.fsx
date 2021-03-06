open System.Collections.Generic

type SparseVector(items : seq<int * float>) =
    let elems = new Dictionary<_, _>()
    do items |> Seq.iter (fun (k, v) -> elems.Add(k, v))
    /// This defines an indexer property
    member t.Item
        with get(idx) =
            if elems.ContainsKey(idx) then elems.[idx]
            else 0.0

let v = SparseVector [(3, 547.0)];;

printfn "%f" v.[4] // 0.0
printfn "%f" v.[3] // 547.0

// You can also use indexer properties as mutable setter properties 
// with the syntax expr.[expr] <- expr