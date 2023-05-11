open System.Collections.Generic


//dictionary
let dictionary = new Dictionary<string, int>()

dictionary["a"] <- 10
dictionary["b"] <- 20
dictionary["b"] = 10

let newArr = dictionary
printfn "%A" newArr["a"]
 
 //tuples
let atuple = (10, 20., "Asap" )
let (a,b,c) = atuple
System.Console.WriteLine(a)
System.Console.WriteLine(b)
System.Console.WriteLine(c) 

//records

//declaring record type
type person = {firstName:string; lastName:string; Age:int}

//assigning values to record types using the direct approach
let User =  {firstName = "asap"; 
lastName = "dasty"; Age = 20}

//assiging values to records using inference type

let customer: person = {person.firstName = "asap"; 
  person.lastName ="dasty"; person.Age = 20}

//changing the value of the assigned records
let changeUserData =  
    {customer with Age =30; firstName = "asap dasty"; lastName = ""}