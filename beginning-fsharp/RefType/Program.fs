printfn "A demonstration about using the ref keyword"

let totalArray() = 
    //define an array literal
    let array = [| 1; 2; 3|]

    //define a counter
    let total = ref 0

    //loop over the array
    for x in array do
        //keep a running total
        total := !total + x
    printfn "Total: %i" !total

totalArray()

//an example showing how to use ref to share values between functions
//the functions themselves are exposed as a tuple
let inc, dec, show = 
    //define the shared state
    let n = ref 0
    //a function to increment
    let inc() =
        n := !n + 1
    //function to decrement
    let dec() =
        n := !n - 1
    //function to show the current state
    let show() =
        printfn "%i" !n

    //return the functions to the top level
    inc, dec, show

//test the functions
inc()
inc()
dec()
show()
printf "Press return to quit"
System.Console.ReadLine() |> ignore