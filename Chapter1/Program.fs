// Test harness for Cracking the Coding Interview 6th Ed. Chapter 1 solutions
// on Arrays and Strings.

// Proper unit tests to follow when I get round to it!

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv =

    // Question 1 Is Unique:
    let str = "abcdefghijklmno"
    printfn "isUnique %s: %b" str (question_1_1.isUnique str)

    // Question 2 Check Permutation:
    let str1, str2 = "abcde", "eddcba"
    printfn "isPermutation %s %s: %b" str1 str2 (question_1_2.isPermutation str1 str2)

    // Question 3 URlify:
    let str = "Mr John Smith      "
    printfn "URLify %s: %s" str (question_1_3.URLify str)

    // Question 4 Palindrome Permutation:
    let str = "Tact Coa"
    printfn "isPalindromePermutation %s: %b" str (question_1_4.isPalindromePermutation str1)

    // Question 5 One Away:
    let str1, str2 = "pale", "bale"
    printfn "isOneAway %s %s: %b" str1 str2 (question_1_5.isOneAway str1 str2)

    // Question 6 String Compression:
    let str = "abccCCCCaaa"
    printfn "compress %s: %A" str (question_1_6.compress str)

    // Question 7 Rotate Matrix:
    let mat = [| [|1; 2; 3|]; [|4; 5; 6|]; [|7; 8; 9|] |]
    printfn "rotateMatrix %A: %A" mat (question_1_7.rotateMatrix mat)

    // Question 8 Zero Matrix:
    let mat = [| [|9; 6; 8; 8|]; [|8; 0; 9; 2|]; [|1; 2; 3; 4|]; [|8; 1; 9; 0|] |]
    printfn "zeroMatrix %A: %A" mat (question_1_8.zeroMatrix mat)
    
    // Question 9 String Rotation:
    let str1, str2 = "waterbottle", "erbottlewat"
    printfn "isStringRotation %s %s: %b" str1 str2 (question_1_9.isStringRotation str1 str2)
    0