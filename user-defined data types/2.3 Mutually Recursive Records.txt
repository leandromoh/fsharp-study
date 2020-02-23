// Defining mutually recursive records is done with the and keyword. 
// This lets you link 2 or more record types together.

// Create a Person type and use the Address type that is not defined
type Person =
  { Name: string
    Age: int
    Address: Address }

// Define the Address type which is used in the Person record
and Address =
  { Line1: string
    Line2: string
    PostCode: string
    Occupant: Person }