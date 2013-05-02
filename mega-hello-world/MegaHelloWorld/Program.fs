(*
Mega Hello World
Takes two command line arguments and prints them to the screen
along with the current time
*)
open System;

//fibbonacci sequence
let rec fibUpTo max = if max < 2 then 1 else fibUpTo(max - 2) + fibUpTo(max - 1)

let isMultipleOf3 x = (x % 3 = 0)
let isMultipleOf5 x = ( x % 5 = 0)

let sumOf3And5 = 
    [
        for n in 1 .. 999 do
            if isMultipleOf5 n then yield n
            elif isMultipleOf3 n then yield n
    ]

let answer = List.sum sumOf3And5

let countVowels (str:string) = 
    let charList = List.ofSeq str
    
    let accFunc (As, Es, Is, Os, Us) letter = 
        if letter = 'a' then (As + 1, Es, Is, Os, Us)
        elif letter = 'e' then (As, Es + 1, Is, Os, Us)
        elif letter = 'i' then (As, Es, Is + 1, Os, Us)
        elif letter = 'o' then (As, Es, Is, Os + 1, Us)
        elif letter = 'u' then (As, Es, Is, Os, Us + 1)
        else (As, Es, Is, Os, Us)
        
    List.fold accFunc (0, 0, 0, 0, 0) charList



let primesUnder max = 
    [
        for n in 1 .. max do
            let factorsOfN = 
                [
                    for i in 1 .. n do
                        if n % i = 0 then
                            yield i
                ]
                
            //n is prime if its only factors are 1 and n
            if List.length factorsOfN = 2 then
                yield n
    ]
    

[<EntryPoint>]
let main (args: string[]) = 
    if args.Length <> 2 then
        failwith "Error: Expected arguments <thing1> and <thing2>"
        
    let greeting, thing = args.[0], args.[1]
    let timeOfDay = DateTime.Now.ToString("hh:mm tt")
        
    printfn "%s, %s at %s" greeting thing timeOfDay
        
    //program exit code
    0