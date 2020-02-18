// type [typename] = [existingType]

type ComplexNumber = float * float
type ProductCode = string
type CustomerId = int
type AdditionFunction = int -> int -> int
type ComplexAdditionFunction = ComplexNumber -> ComplexNumber -> ComplexNumber

// Type abbreviations are useful to provide documentation and avoid writing a signature repeatedly
// In the above examples, ComplexNumber and AdditionFunction demonstrate this
// Another use is to provide some degree of decoupling between the usage of a type and the actual implementation of a type
// I could easily change CustomerId to be a string without changing a lot of code
// Since it is just an alias type, we could use an explicit int anywhere we used a CustomerId, for example