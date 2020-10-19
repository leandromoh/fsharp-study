// Single-case discriminated unions (DU) are often used to create type-safe abstractions with pattern matching support:

// Define union type
type OrderId = OrderId of int

// Create a discriminated union value
let orderId = OrderId 12

// Use pattern matching to deconstruct single-case DU
let (OrderId id) = orderId

// Deconstruct in the parameter of a function
let printOrderId (OrderId orderId) =
   printfn "The orderId is %i" orderId
   
printOrderId orderId  // prints: The orderId is 12
printfn "%d" id       // prints: 12