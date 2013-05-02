//example of sum types using volumne
open System

type Volume = 
    | Liter of float
    | UsPint of float
    | ImperialPint of float
    
let vol1 = Liter 2.5
let vol2 = UsPint 2.5
let vol3 = ImperialPint (2.5)

//some functions to convert between volumns
let convertVolumeToLiter x = 
    match x with
    | Liter x -> x
    | UsPint x -> x * 0.473
    | ImperialPint x -> x * 0.568

let convertVolumeToUsPint x =
    match x with
    | Liter x -> x * 2.113
    | UsPint x -> x
    | ImperialPint x -> x * 1.201

let convertVolumeToImperialPint x =
    match x with
    | Liter x -> x * 1.760
    | UsPint x -> x * 0.833
    | ImperialPint x -> x

//function to output a volumme
let printVolumes x =
    printfn "Volume in liters = %f,
     in us pints = %f, 
     in imperial pints = %f" (convertVolumeToLiter x) (convertVolumeToUsPint x) (convertVolumeToImperialPint x)

printVolumes vol1
printVolumes vol2
printVolumes vol3

Console.WriteLine("Press Return to quit")
ignore (Console.ReadLine())