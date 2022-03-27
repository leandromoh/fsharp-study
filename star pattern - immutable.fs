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

let printChar c times =
    for _ in 1 .. times do
        printf "%c" c

let rec printLine spacesInc starInc times spaces star =
    if times <= 0 then
        spaces, star
    else
        printChar ' ' spaces
        printChar '*' star
        printfn ""
        printLine spacesInc starInc (times-1) (spaces + spacesInc) (star + starInc) 

[<EntryPoint>]
let main args =
    let spaces, star = 5, 1
    let spaces, star = printLine -1 +2 5 spaces star 
    let spaces, star = printLine +1 -2 6 spaces star 
    0

