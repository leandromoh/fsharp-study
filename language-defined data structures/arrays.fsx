// F# directly supports N-dimensional array values that are stored flat—that.
// Types for 2 dimensions values are written such as in int[,] and these types also support slicing syntax.
// Arrays are mutable, fixed-sized and zero-based sequences of the same data type.

let AOlympians = [| "Aphrodite"; "Apollo"; "Ares"; "Artemis"; "Athena" |];; // string []

let godOfWar = AOlympians.[2] //Ares

// since arrays are mutable, we can change the value at any index using the destructive assignment operator

AOlympians.[2] <- "Kratos"

// You can use ranges like in Ruby

let OneToTen = [|1..10|];; // [|1; 2; 3; 4; 5; 6; 7; 8; 9; 10|]

let OneToTenByTwos = [|1..2..10|];; // [|1; 3; 5; 7; 9|]

let FiveToOne = [|5..-1..1|];; // [|5; 4; 3; 2; 1|]

// You can create new arrays from slices of an existing array using an index range

AOlympians.[1..2] //  [| "Apollo"; "Ares" |]
AOlympians.[..2]  //  [| "Aphrodite"; "Apollo"; "Ares" |]
AOlympians.[3..]  //  [| "Artemis"; "Athena" |]

let arr = [|for i in 0 .. 5 -> (i, i * i)|];; // [|(0, 0); (1, 1); (2, 4); (3, 9); (4, 16); (5, 25)|]