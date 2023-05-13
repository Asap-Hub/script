open System


module topLevelModule =
    let add x y = x + y 
    let substract x y = x - y

module calculate = 
    let mult x y =  x * y
    let divide  x y = x / y

// printfn "%" (add 2 3)
// printfn "%" calculate.mult 2 3
// printfn "%" calculate.divide 3 5
//local module
module mathematics =
     let add x y = x + y
     let subtract x y = x - y
    
let result = mathematics.add 1 2
let sub = mathematics.subtract 20 10

open mathematics

mathematics.add 2 3
mathematics.subtract 20 30



