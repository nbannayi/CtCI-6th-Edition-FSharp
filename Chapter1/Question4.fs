module question_1_4

open System

/// Return true if passed string is a permutation of a palindrome.
/// Ignore casing and non-letter characters.
let isPalindromePermutation (str: string) =

    // Filter out non-chars and convert to lower case, then count each letter. 
    let charBreakdown =
        str
        |> Seq.filter (fun c -> c |> Char.IsLetter)
        |> Seq.map (fun c -> Char.ToLower(c))
        |> Seq.countBy (fun c -> c)

    // Find key value pairs of even counts of letters.
    let noEvenLetters =
        charBreakdown
        |> Seq.filter (fun (_,v) -> v % 2 = 0)
        |> Seq.length

    // A palindrome has even letter counts equal or one less than total number
    // of unique letter counts.
    noEvenLetters >= (charBreakdown |> Seq.length) - 1