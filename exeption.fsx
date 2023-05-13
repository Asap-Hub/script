open System

exception Error of string * int
exception Error2 of string * int * int

let function1 x y = 
    try
        if x = y then raise (Error($"value are equal", x))
        else raise (Error2("values are not equal", x, y))
    with
        | Error(string, x) -> printfn $"{string}: {x}"
        | Error2(string, x, y) -> printfn $"{string}: {x} {y}"
        | _ -> ()

function1 12 1
function1 1 1