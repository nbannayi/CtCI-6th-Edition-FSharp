module question_1_6

/// Perform simple compression on a string.
let compress (str: string) =

    // Insert a space between each chunk of contiguous letters.
    let chunked =
        ("", str) ||> Seq.fold(fun state input ->
            if state.EndsWith(string input) then (sprintf "%s%c" state input) else (sprintf "%s %c" state input)
        ) in chunked.Split(' ')
    |> Array.skip 1

    // Convert each chunk to a count and letter string abd concatenate.
    |> Array.map (fun c -> sprintf "%c%d" c.[0] (c |> String.length))
    |> Array.reduce (+)

    // Return compressed version if shorter, else original version.
    |> function | s when s.Length >= str.Length -> str | s -> s