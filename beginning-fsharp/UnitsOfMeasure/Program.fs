open System
//demos about units of measure
[<Measure>] type liter
[<Measure>] type pint

let vol1 = 2.5<liter>
let vol2 = 2.5<pint>

//doesn't work
//let newVol = vol1 + vol2

let ratio = 1.0<liter> / 1.76056338<pint>

//convert pints to litres
let pintsToLiters pints = 
    pints * ratio

//this works, unlike above
let newVol = (pintsToLiters vol2)

printfn "%A pints is %A liters" vol1 newVol

printfn "Press return to exit"
ignore(Console.ReadLine)