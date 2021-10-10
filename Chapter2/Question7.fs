module question_2_7

/// Determine if two lists have an intersecting element.
let intersection lst1 lst2 =
    Set.intersect (lst1 |> Set.ofList) (lst2 |> Set.ofList)
    |> Set.count > 0