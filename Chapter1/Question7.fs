module question_1_7

/// Rotate square matrix 90 degrees.
let rotateMatrix matrix =

    // Reversing order of array of arrays then transposing does a 90 degree rotation.
    matrix
    |> Array.rev
    |> Array.transpose