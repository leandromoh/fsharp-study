// try...finally guarantees to run the finally clause both when an exception
// is thrown and when the expression evaluates normally.
// The "finally" clause must always return unit, 
// so any non-unit values will be flagged by the compiler.

let f x = 
    try
        if x then "ok" else failwith "fail"
    finally
        printf "this will always be printed"
