module NumberTheoryExtensions =

let factorize i =
    let lim = int (sqrt (float i))
    let rec check j =
        if j > lim  then None
        elif (i %  j) = 0 then Some (i / j, j)
        else check (j + 1)
    check 2

type System.Int32 with
    member i.IsPrime = (factorize i).IsNone
    member i.TryFactorize() = factorize i
    static member Even i = i % 2 = 0

// The IsPrime extension property and the TryFactorize extension method are then available 
// for use in conjunction with int32 values whenever the NumberTheoryExtensions module has been opened.

printfn "%A" (2 + 1).IsPrime
printfn "%A" <| Int32.Even 5
printfn "%A" <| (6093704 + 11).TryFactorize()

// Intrinsic type extensions must be defined in the same file and in the same namespace or module 
// as the type they're extending. Any other definition will result in them being optional type extensions.

// Intrinsic type extensions are compiled as members of the type they augment, and appear on the type when the type is examined by reflection.

// Optional type extension is an extension that appears outside the original module, namespace, or assembly of the type being extended.

// Optional extensions do not appear on the extended type when examined by reflection. 
// Optional extensions must be in modules, and they're only in scope when the module that contains the extension is open or is otherwise in scope.

// Optional extension members are compiled to static members for which the object instance is passed implicitly as the first parameter. 

// Intrinsic and optional type extensions can define any member type (methods, properties, etc)
// Extended members can be static or instance members.

Modules can also be extended in F#

open FSharp.Collections

module List =
    let pair item1 item2 = [ item1; item2 ]

printfn "%A" <| List.pair 1 3 // [1; 3]
