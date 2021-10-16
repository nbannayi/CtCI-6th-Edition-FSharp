// Test harness for Cracking the Coding Interview 6th Ed. Chapter 2 solutions
// on Linked Lists.

// Proper unit tests to follow when I get round to it! 

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv =

    // Question 1 Remove Dups:
    let lst = [1; 1; 1; 2; 3; 3; 4; 5; 5]
    printfn "removeDups %A: %A" lst (question_2_1.removeDups lst)

    // Question 2 Return Kth to Last:
    let lst = ['A'; 'B'; 'C'; 'D']
    printfn "kthToLast %A: %A" lst (lst |> question_2_2.kthToLast 3)

    // Question 3 Delete Middle Node:
    let lst, node  = ['#'; '%'; '@'; '&'], '@'
    printfn "deleteMiddleNode %A %A: %A" node lst (lst |> question_2_3.deleteMiddleNode node)

    // Question 4 Partition:
    let lst, node = [3; 5; 8; 5; 10; 2; 1], 5
    printfn "partition %A %A: %A" node lst (lst |> question_2_4.partition node)

    // Question 5 Sum Lists:
    let n1, n2 = [7; 1; 6], [5; 9; 2]
    printfn "sumLists: %A %A: %d" n1 n2 ((n1,n2) ||> question_2_5.sumLists)

    // Question 6 Palindrome:
    let lst = [1; 2; 3; 2; 1]
    printfn "palindrome %A: %b" lst (lst |> question_2_6.palindrome)

    // Question 7 Intersection:
    let lst1, lst2 = [1; 2; 3; 4], [1; 5; 6; 7]
    printfn "intersection %A %A: %b" lst1 lst2 ((lst1,lst2) ||> question_2_7.intersection)

    // Question 8 Loop Detection:
    let lst = ['A'; 'B'; 'C'; 'D'; 'E'; 'C']
    printfn "loopDetection %A: %A" lst (lst |> question_2_8.loopDetection)
    0