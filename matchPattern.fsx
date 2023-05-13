open System

let input = Console.ReadLine() |> int

 

let checkValue input = 
    match input with 
    | 1 -> printfn "the values input: %A" input
    | 2 -> printfn "the values input was: %A" input
    | _ -> printfn "number out of range %A" input

checkValue input |> int.ToString
    

// pattern match with function expression

let checkZeroAnd = function 
    | (0, 0) -> "Both values were Zero"
    | (var1,var2) & (0, _) -> $"first values is {var1} and second value is {var2}"
    | (var1, var2) & (_,0)-> $"first value is {var1} and second value is {var2}"
    | _ -> "no zero:zero"


checkZeroAnd (0,0)
checkZeroAnd(0,1)
checkZeroAnd(1,0)
checkZeroAnd(1,1)