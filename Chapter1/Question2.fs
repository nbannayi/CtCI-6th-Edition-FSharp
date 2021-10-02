module question_1_2

/// Given two strings return true if one is a permutation of the other, else false.
let isPermutation str1 str2 =
    str1
    |> Seq.sort = (str2 |> Seq.sort)
