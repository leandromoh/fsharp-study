// abstract classes must have [<AbstractClass>] attribute
// abstract classes are classes that leave some or all members unimplemented
// so that implementations can be provided by derived classes.
// no instances can be created of abstract class.

[<AbstractClass>]
type TextOutputSink() =
    abstract WriteChar : char -> unit
    abstract WriteString : string -> unit
    default x.WriteString s = s |> String.iter x.WriteChar


// Implementing using Object Expressions
let sink = {new TextOutputSink() with
                member x.WriteChar c = System.Console.Write(c)}

// Implementing with derivated class
type CountingOutputSinkByInheritance() =
    inherit TextOutputSink()

    let mutable count = 0

    member sink.Count = count

    default sink.WriteChar c = 
        count <- count + 1; 
        System.Console.Write c

// Creating another abstract devirated class
[<AbstractClass>]
type ByteOutputSink() =
    inherit TextOutputSink()

    /// When implemented, writes one byte to the sink
    abstract WriteByte : byte -> unit

    /// When implemented, writes multiple bytes to the sink
    abstract WriteBytes : byte[] -> unit

    default sink.WriteChar c = sink.WriteBytes(Encoding.UTF8.GetBytes [|c|])

    override sink.WriteString s = sink.WriteBytes(Encoding.UTF8.GetBytes s) 

    default sink.WriteBytes b = b |> Array.iter sink.WriteByte 