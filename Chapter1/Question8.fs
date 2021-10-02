module question_1_8 

/// Zero out rows and columns of 0 entries in passed matrix.
let zeroMatrix matrix =

    // Get rows and columns that contain 0s.
    let zr,zc =
        let zeros =
            matrix
            |> Array.mapi (fun i r ->
                r |> Array.mapi (fun j c -> if c = 0 then i,j else -1,-1))
            |> Array.collect (fun e -> e)
            |> Array.filter (fun (c,r) -> c <> -1 && r <> -1)
        zeros |> Array.map (fun (_,r) -> r) |> Array.distinct,
        zeros |> Array.map (fun (c,_) -> c) |> Array.distinct

    // Go through rows and columns and wipe out any entry with a coordinate
    // in rows or columns arrays created above.
    matrix
    |> Array.mapi (fun i r ->
        r |> Array.mapi (fun j c ->
            if zr |> Array.contains j || zc |> Array.contains i then 0 else c)) 