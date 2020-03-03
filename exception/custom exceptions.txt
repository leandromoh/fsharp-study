// F# exceptions are always subtypes of the .NET type System.Exception

exception MyFSharpError1 of string
exception MyFSharpError2 of string * int