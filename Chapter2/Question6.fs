module question_2_6

/// Check if a passed list is a palindrome. 
let palindrome lst =
    lst = (lst |> List.rev)