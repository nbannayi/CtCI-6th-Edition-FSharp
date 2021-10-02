module question_1_1

/// Return true if passed string only contains unique chars, false otherwise.
let isUnique str =
    str
    |> Seq.countBy (fun c -> c)
    |> Seq.exists (fun (_,v) -> v > 1)
    |> not