(* prints
     *
    ***
   *****
  *******
 *********
***********
 *********
  *******
   *****
    ***
     *
*)

let mutable spaces = 5
let mutable star = 1

let printChar c times =
    for _ in 1 .. times do
        printf "%c" c

let printLine times spaceInc starInc =
    for _ in 1 .. times do
        printChar ' ' spaces
        printChar '*' star
        printfn ""
        spaces <- spaces + spaceInc
        star <- star + starInc

[<EntryPoint>]
let main args =
    printLine 5 -1 +2
    printLine 6 +1 -2
    0
