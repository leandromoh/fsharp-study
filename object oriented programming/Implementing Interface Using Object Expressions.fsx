// Object expressions must give definitions for all unimplemented 
// abstract members and can’t add other members.

// syntax:

// { new Type optional-arguments with
//      member-definitions
//   optional-extra-interface-definitions }


type ISum =
    abstract Sum : int -> int -> int

let sumObj =
    {new ISum with
          member x.Sum a b = a + b }

sumObj.Sum 3 5 |> printf "%d" // 8