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
    0