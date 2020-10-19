let oddPrimes = [3; 5; 7; 11]
let morePrimes = [13; 17]
let primes = 2 :: (oddPrimes @ morePrimes) //  [2; 3; 5; 7; 11; 13; 17]


// F# lists are immutable, and they are represented in memory as linked lists
// The cons :: and append @ operations don’t modify the original lists
// List module contains functions common helper functions

// List.filter
// List.map
// List.iter

[1;2;3] |> List.map (fun x -> x * x * x) // [1; 8; 27]