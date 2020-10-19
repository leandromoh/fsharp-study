// use language constructs such as "use val = expr" to ensure that the resource is closed at the end of the lexical scope where object is active

let myWriteStringToFile() =
    use outp = File.CreateText("playlist.txt")
    outp.WriteLine("Enchanted")
    outp.WriteLine("Put your records on")

// This is equivalent to the following:

let myWriteStringToFile () =
    let outp = File.CreateText("playlist.txt")
    try 
        outp.WriteLine("Enchanted")
        outp.WriteLine("Put your records on")
    finally
       (outp :> System.IDisposable).Dispose()

// where IDisposable is defined like:

namespace System
    type IDisposable =
        abstract Dispose : unit -> unit