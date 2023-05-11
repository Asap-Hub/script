let ifStatement abool = 
    if abool then
                40
        else 
        0
ifStatement false  


let checkBool abool = if abool then 42 else 0

let result = checkBool true

System.Console.WriteLine(result)

//ignore expression

let square x = x*x
let result1 = square 5

square 5

printfn "%A" result1

square 5 |> ignore