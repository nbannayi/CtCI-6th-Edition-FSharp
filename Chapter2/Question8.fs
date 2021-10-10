module question_2_8

/// Find a loop in a set of nodes.
let loopDetection lst =
    lst
    |> List.countBy (fun e -> e)
    |> List.filter (fun (_,c) -> c > 1)
    |> List.head
    |> fst