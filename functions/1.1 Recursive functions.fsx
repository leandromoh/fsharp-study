// recursive functions require that you specify the rec keyword following the let keyword

let rec fib n = 
    if n < 2 then 1 
    else fib (n - 1) + fib (n - 2)