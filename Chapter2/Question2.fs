module question_2_2

// Return kth to last element of a list.
let kthToLast k (lst: List<_>) =
    let k' = lst.Length - k
    if k' < 0 then
        failwith "Number of list elements exceeded."
    else
        lst.[k']