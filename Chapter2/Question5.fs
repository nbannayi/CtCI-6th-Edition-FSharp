module question_2_5

let addDigit (c1, n1) (c2, n2) =
    let sum = n1 + n2
    if sum > 9 then (c1+c2+1, sum - 10) else (c1+c2, sum)

let toDigit n =
    (0, n)
