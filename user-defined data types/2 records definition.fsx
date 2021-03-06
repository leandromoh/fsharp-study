// Records represent simple aggregates of named values, optionally with members. 
// They can either be structs or reference types. They are reference types by default.
// Compiler automatically generates structural equality and structural comparison for records
// Record fields are automatically exposed as properties

// Labels are separated by semicolons when defined on the same line.
type Point = { X: float; Y: float; Z: float; }

// You can define labels on their own line without a semicolon.
type Customer = 
    { First: string
      Last: string
      SSN: uint32
      AccountNumber: uint32 }

// You can set values in expressions known as record expressions. 
// The compiler infers the type from the labels used 
// (if the labels are sufficiently distinct from those of other record types)

let myRecord = { X = 1.0; Y = 1.0; Z = -1.0; } // myRecord is a Point variable