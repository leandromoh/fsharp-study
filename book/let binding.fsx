// let is the single most important keyword you will use in F# programming it’s used to define data,
// computed values, and functions. The left of a let binding is often a simple identifier,
// but it can also be a pattern.

// Within function definitions, you can outscope values by declaring another value of the same name.
// For example

let powerOfFourPlusTwo n =
 let n = n * n
 let n = n * n
 let n = n + 2
 n

// This code is equivalent to:

let powerOfFourPlusTwo n =
 let n1 = n * n
 let n2 = n1 * n1
 let n3 = n2 + 2
 n3

let powerOfFourPlusTwoTimesSix n =
    let n =
        let n = n * n
        let n = n * n
        n + 2
    let n = n * 6
    n
