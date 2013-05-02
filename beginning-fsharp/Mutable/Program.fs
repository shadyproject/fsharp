printfn "%s" "Mutable variable examples"

//using mutable variables
let mutable phrase = "how can I be sure,"

printfn "%s" phrase

//update the phrase
phrase <- "In a world that's constantly changing"

printfn "%s" phrase

//note that this doesnt work, since you can't redefine types with mutable variables
//let mutable one = "one"
//one <- 1

//demonstration of redefining mutable varibales inside different scopes
printfn "Scope differences for mutable variables"

let redfineX() = 
    let x = "One"
    printfn "Redefining:\r\nx = %s" x
    if true then
        //note the different indentation levels, and therefor scopes
        let x = "Two"
        printfn "x = %s" x
    printfn "x = %s" x

let mutableX() = 
    let mutable x = "One"
    printfn "Mutating:\r\nx = %s" x
    if true then
        x <- "two"
        printfn "x = %s" x
    printfn "x = %s" x //the value is still the same, even though we are back in the original scope

//run the demos
redfineX()
mutableX()

//this doesn't compile, as mutable variables cannot be captured by closures
//let mutableY() = 
//    let mutable y = "One"
//    printfn "Mutating:\r\ny = %s" y
//    let f() = 
//        y <- "two"
//        printfn "y = %s" y
//    f()
//    printfn "y = %s " y

printfn "Press return to quit"
System.Console.ReadLine() |> ignore