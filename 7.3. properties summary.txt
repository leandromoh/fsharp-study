// get property
    member x.Color = color

// alternative syntax for get property
    member x.Color with get() = color

// set property
    member x.Color with set (c) = color <- c

// if you define just get you have a get only property
// if you define just set you have a set only property
// if you define both     you have a get set  property

// instead of define a get set separately

    member x.Color with get() = color
    member x.Color with set (c) = color <- c

// there is the alternative syntax, that also enforces a single property name

    member x.Color
        with get() = _color
        and set(c) = _color <- c