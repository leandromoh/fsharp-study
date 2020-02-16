let even x = x % 2 = 0 
let checkSumIsEven a b = even (a + b)

// since all functions in F# have really one parameter (curried function), function types are pretty straight
// the type before the symbol -> is the type of its single parameter, and the type after -> is the return type
// that is, the type of the function even above is: int -> bool

// checkSumIsEven function, which receive two int parameters and returns a bool, has type int -> int -> bool
// the -> symbol is right associative, what means that
// int -> int -> bool is exactly the same as (int -> (int -> bool))

// therefore checkSumIsEven is in fact a function that receveis an int, 
// then return another function that also receveis an int and returns a bool

// it makes function signature simple because we can read the last type as the return type
// and the previous as parameters type, even if indeed everything is curried