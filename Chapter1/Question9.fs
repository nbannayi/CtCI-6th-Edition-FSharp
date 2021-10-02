module question_1_9

/// Establish if passed strings are rotations of each other.
let isStringRotation (str1: string) (str2: string) =

    // The key is to check if s1 is a substring of s1+s2.
    match str1, str2 with
    | s1, s2 when s1.Length < 1 && s1.Length <> s2.Length -> false
    | s1, s2 when (s2+s2).IndexOf(s1,0) > 0 -> true
    | _ -> false