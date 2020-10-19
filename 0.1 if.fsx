// operators && and || ('and' and 'or')
// They have the usual short-circuit behavior 

// if...then...else is an expression, not a statement
// Thus, each branch of the if expression must produce a value (all of same type)

let num = 3

let sign = 
   if num > 0 then "positive"
   elif num < 0 then "negative"
   else "zero"

//elif is a suggar for else if, both works