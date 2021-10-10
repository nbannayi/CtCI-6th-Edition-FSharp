module question_2_4

/// Partition list into two lists with values less than and greater
/// or equal a given node.
let partition node lst =
    lst
    |> List.partition (fun l -> l < node)