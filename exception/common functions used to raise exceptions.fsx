failwith "message"                // throws a generic System.Exception
invalidArg "paramName" "message"  // throws an ArgumentException
nullArg "paramName" "message"     // throws a NullArgumentException
invalidOp "message"               // throws an InvalidOperationException

// printf style formatting
failwithf "Operation '%d' failed at time %O" 5 DateTime.Now 