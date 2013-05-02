printfn "Demonstration of mutable record types"

type Couple = {her: string; mutable him: string}

let theCouple = {her = "Elizabeth Taylor"; him = "Nicky Hilton"}

//function to change the contents of the record over time
let changeCouple() = 
    printfn "%A" theCouple
    theCouple.him <- "Michael Wilding"
    printfn "%A" theCouple
    theCouple.him <- "Michael Todd"
    printfn "%A" theCouple
    theCouple.him <- "Eddie Fisher"
    printfn "%A" theCouple
    theCouple.him <- "Richard Burton"
    printfn "%A" theCouple
    theCouple.him <- "Richard Burton"
    printfn "%A" theCouple
    theCouple.him <- "John Warner"
    printfn "%A" theCouple
    theCouple.him <- "Larry Fortensky"
    printfn "%A" theCouple

changeCouple()

printf "Press return to quit"
System.Console.ReadLine() |> ignore