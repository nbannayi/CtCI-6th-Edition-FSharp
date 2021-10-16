module question_2_5

/// Add two lists by digit.
let sumLists (n1: int list) (n2: int list) =
    if (n1 |> List.length) <> (n2 |> List.length) then
        failwith "Lists must be same size."
    else
        (n1, n2)
        ||> List.zip
        |> List.mapi (fun i (l,r) -> 10.**(float i)*float (l+r))
        |> List.sum
        |> int

