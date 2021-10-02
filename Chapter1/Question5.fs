module question_1_5

open System

/// Return true if one input string is one or zero character edits (insert, delete or amend)
/// away from the other.
let isOneAway (str1: string) (str2: string) =

    // Firstly order two input strings by length.
    let s1, s2 = if str1.Length > str2.Length then str1,str2 else str2,str1

    // For strings with only 1 change, align the letters then compare each one for
    // changes and count the differences.
    match Math.Abs(s1.Length - s2.Length) with 
    | l when l > 1 -> false
    | _ ->
        let s2 =
            if s1.Length <> s2.Length then
               let insIndex =
                    Seq.zip s1 s2
                    |> Seq.tryFindIndex (fun (c1,c2) -> c1 <> c2)
                    |> Option.defaultValue -1
               if insIndex > 0 then s2.Insert(insIndex, " ") else s2 + " "
             else
                s2
        Seq.zip s1 s2 |> Seq.filter (fun (c1,c2) -> c1 <> c2) |> Seq.length <= 1  