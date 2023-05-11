let squar x:int = x*x

let squared = (squar 10)
printfn "%A" (squared)
System.Console.WriteLine(squared)

let a = [|squared,20,24|]

printf "%A" (squared*2)
System.Console.WriteLine(squared*2)

let input = System.Console.ReadLine()
printfn "Input value was: %A" input
System.Console.Write(input)