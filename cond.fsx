open System

System.Console.WriteLine("Please Enter A values")

let input = Console.ReadLine()

let number:int  = int input

if number < 5 then
    printfn "Values is less than 5: %A"  number
    elif number >= 5 || number <= 10 then
        printfn "values is with the range of 5 and 10%A" number

    elif number > 10 || number <=100 then
        printfn "values is less than 10 but within 100 %A" number 

    else printfn "number is About Range %A" number