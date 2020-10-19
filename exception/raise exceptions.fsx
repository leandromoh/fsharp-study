raise (InvalidOperationException("message"))
raise (MyFSharpError1 "message")

// or using pipelining

raise <| InvalidOperationException("message")