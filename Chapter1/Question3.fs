module question_1_3

/// Turn string into a URL by replacing spaces with %20.
let URLify (str: string) =
    str.Trim().Replace(" ","%20")