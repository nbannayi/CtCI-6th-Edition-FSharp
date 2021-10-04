module question_2_3
 
/// Delete a node from middle of list.
let deleteMiddleNode node lst =
    lst
    |> List.tryFindIndex (fun l -> l = node)
    |> function
       | Some i -> (lst |> List.take i) @ (lst |> List.skip (i+1))
       | _ -> failwith "List does not contain node."