open System

let pesos = [ "unidade"; "dezena"; "centena"; "milhar" ]
printfn "digite um numero: "
let valor = "1234" // Console.ReadLine()

let mutable i = 0
while i <= valor.Length do
    printfn $"{pesos[i]} = {valor[valor.Length - i - 1]}"
    i <- i + 1
