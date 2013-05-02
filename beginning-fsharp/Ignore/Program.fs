//example on calling functions and ignoring their values
//we actually do this all the time in the previous examples

let getShorty() = "Shorty"

//first way is to ignore the value return3ed wiuth the _ shorthand
let _ = getShorty()

//second way is to use the ignore keyword
ignore(getShorty())

//third way uses the pass forward operator
getShorty() |> ignore


//standard epilogue for running code inside VS
printfn "%s" "Press return to exit"
System.Console.ReadLine() |> ignore