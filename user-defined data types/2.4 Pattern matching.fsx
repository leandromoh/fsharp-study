type Person = {First:string; Last:string}

let person = {First="john"; Last="doe"}

match person with 
| {First="john"}  -> printfn "It is john" 
| _  -> printfn "Not john"

let { First = f; Last = l } = person

printfn "My name is %s %s" f l
printfn "My name is %s %s" person.First person.Last