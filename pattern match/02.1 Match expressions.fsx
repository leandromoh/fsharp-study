(*
match [something] with 
| pattern1 [ when condition ] -> result-expression1
| pattern2 [ when condition ] -> result-expression2
| pattern3 [ when condition ] -> result-expression3
*)

// order patterns are defined is important! They are tested in a top-down way
// if the pattern is the wildcard _, it will always match. Usually it is used as default case (last position)
// match..with is an expression, what forces that all branches must evaluate to the same type
// match expressions can appear anywhere an expression can be used
// because it is an expression, there must always be some branch that matches
// when none of the patterns matchs, you get a runtime error (MatchFailureException)

// x receives "a"

let x = 
    match 1 with 
    | 1 -> "a"
    | 2 -> "b"  
    | _ -> "z" 