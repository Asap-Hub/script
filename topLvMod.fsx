//top level  components of module
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