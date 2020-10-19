// Local functions can be defined in terms of any values and parameters that happen to be in scope. 
// Local functions are said to capture the values they depend on

let powerOfFour n =
    let powerOfTwo x = x * x
    powerOfTwo n * powerOfTwo n

printfn "%d" <| powerOfFour 2

// or using parameterless local function

let powerOfFour n =
    let powerOfN() = n * n
    powerOfN() * powerOfN()

printfn "%d" <| powerOfFour 2