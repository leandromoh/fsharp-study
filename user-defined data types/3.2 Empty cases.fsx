// The label for a union case does not need to have any type after it. 
// The following are all valid union types:

type Result = 
  | Success                  // no string needed for success state
  | ErrorMessage of string   // error message needed 

// If all the cases are empty, then we have an 'enum style' union:

type Size = Small | Medium | Large
type Answer = Yes | No | Maybe