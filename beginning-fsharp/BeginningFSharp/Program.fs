open System

let multiplesOf3 = [0 .. 3 .. 30]
let reverse = [9 .. -1 .. 0]
printfn "%A" multiplesOf3
printfn "%A" reverse
    
let squares 
    = seq {for x in 1 .. 10 -> x *x}
printfn "%A" squares

let lower = seq {for x in 'A' .. 'Z' -> x.ToString().ToLower()}
printfn "%A" lower

let evens n = 
    seq {for x in 1 .. n do 
            if x % 2 = 0 then yield x}
            
printfn "%A" (evens 10)

let squarePoints n =
    seq { for x in 1 .. n do
            for y in 1 .. n do
                yield x, y}
                
printfn "%A" (squarePoints 3)
                    

Console.WriteLine("Press Return to quit")
ignore(Console.ReadLine())