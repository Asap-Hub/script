let square x = x*x + 1

square 0

printfn "%A" (square 2)


let add x y = 
    let z = x + y
    z

let result = add 1 2

System.Console.WriteLine(result)