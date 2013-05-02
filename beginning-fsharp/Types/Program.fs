open System;

let pair = true, false

let b1, _ = pair //ignores the second value
let _, b2 = pair //ignores the first value

printfn "%A" pair
printfn "%A" b1
printfn "%A" b2

//tuple aliasing
type Name = string
type FullName = string * string

let fullNameToString(x: FullName) = 
    let first, second = x in first + " " + second
    
    
printfn "%A" (fullNameToString ("Roger", "Dodger"))

//record types
//organization with unique fields
type Org1 = {boss: string; lackeys: string list}
let rainbow = {boss = "Jefferey"; lackeys = ["Zippy"; "George"; "Bungle"]}

printfn "%A" rainbow

//define two organizations with overlapping fields
type Org2 = {chief: string; underlings: string list}
type Org3 = {chief: string;  indians: string list}

//create an instance of org2
let (thePlayers: Org2) = {chief = "Peter Quince"; underlings = ["Francis Flute"; "Robin Starveling"; "Tom Snout"; "Snug"]}

printfn "%A\n" thePlayers.chief
printfn "%A" thePlayers.underlings

//create an instance of Org3
let (wayneManor: Org3) = {chief = "Batman"; indians = ["Robin"; "Alfred"]}

printfn "%A\n" wayneManor.indians

//create a modified instance of the type (since in f# everythign is immutable)
let wayneManor' = {wayneManor with indians = ["Alfred"]}

printfn "%A\n" wayneManor.indians
printfn "%A\n" wayneManor'.indians

//Pattern mwatching with fields
type Couple = {him: string; her: string}

//list of couples
let couples = [ {him= "Bob"; her= "Alice"}; {him= "Rhett"; her= "Scarlett"}; {him= "Brad"; her= "Angelina"}];

let rec findBob l = 
    match l with
    | {him = x; her = "Alice"} :: tail -> x
    | _ :: tail -> findBob tail
    | [] -> failwith "Couldn't find bob"

printfn "%A" (findBob couples)

//we need a when guard here because you can only use literal values for pattern matching
let rec findPartner soughtHer l = 
    match l with
    | {him = x; her = her} :: tail when her = soughtHer -> x
    | _ :: tail -> findPartner soughtHer tail
    | [] -> failwith "Couldn't find him"

printfn "%A" (findPartner "Scarlett" couples)

//prevents us from exiting right away when running in visual studio
Console.WriteLine "Press return to quit"
ignore(Console.ReadLine())
