// expression is used to iterate in a loop over a range of values of a loop variable.
// the return type for the body-expression must be unit.

  for i = 1 to 10 do
    printfn "%d" i

  for i = 10 downto 1 do
    printfn "%d" i

  for i in 1..2..10 do
    printfn "%d" i

  let mutable i = 0
  while i < 10 do
    printfn "%d " i
    i <- i + 1