let containers = [
  43
  3
  4
  10
  21
  44
  4
  6
  47
  41
  34
  17
  17
  44
  36
  31
  46
  9
  27
  38
]

// Finding all the combinations
let rec solve used containers_list fridge total = seq {
    match containers_list with 
    | container::tail ->
        // Below 150
        if container + total < fridge then 
            yield! solve (container::used) tail fridge (container + total)
        // 150
        elif container + total = fridge then 
            yield container::used |> List.toArray
        // Above 150
        elif container + total < fridge then 
            yield! solve (container::used) tail fridge (container + total)
        yield! solve used tail fridge total
    | _ -> ()
}

let result = solve [] containers 150 0 |> Seq.toArray
// Number of combinations
result.Length |> printfn "%d"