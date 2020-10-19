// Extension methods (sometimes called "C# style extension members") can be declared in F# as a static member method on a class.

// C#-style extension members are declared as an (attributed) static method in an (attributed) class. 

// C#-style extension members can only be instance methods; i.e., they can’t be static and can’t be properties.

namespace Extensions

open System.Runtime.CompilerServices

[<Extension>]
type IEnumerableExtensions =
    [<Extension>]
    static member inline Sum(xs: IEnumerable<'T>) = Seq.sum xs

// C#-style extension methods can constrain the generic type parameters to either a particular instantiation or some other generic constraint

// Normal F# extensions can’t operate on constrained types like this, 
// which sometimes makes a mix of F# and C# extensions useful when designing “Fluent” APIs

// Example method above constrains the generic type of the input to be summable.