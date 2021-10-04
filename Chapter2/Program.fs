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
    0