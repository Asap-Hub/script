open System

let values = [1..10]

for i in values do
    printfn "%A" i


for c = 1 to 10 do
    printf "%A" c    

let mutable i = 0

while i < 10 do 
printfn "%A" i
i <- i + 1


//imperative approach
let data = [1..5]

let mutable total = 0;

for i in data do 
total <- total + i

printfn "%A" i

//using the seq sum
let data2 = seq {1 ..5}
printfn "%A" data2 
let result= Seq.sum data2

printfn "Total Result:%A" result


//using the fold approach

let foldApproach = List.fold (+) 0 [1..10]

printfn "resulted list values:%A" foldApproach

List.iter(fun x -> printfn "%A" x) data
 

[for x in 1..5  do yield x*x ] 

[
    for x in 1..8 do  
        for y in 1..4 do  
            if x <> y   then yield  (x,y)  
]
