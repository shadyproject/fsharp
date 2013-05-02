printfn "Some Examples of Array Comprehension"

//characters
let chars = [|'1' .. '9'|]

//an array of tuples of number, square
let squares = 
    [| for x in 1 .. 9 -> x, x*x|]

printfn "%A" chars
printfn "%A" squares

//Wait for input before we quit the program
printfn " Press return to exit"
System.Console.ReadLine() |> ignore