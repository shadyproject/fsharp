printfn "Examples of calling static methods from other .NET libraries"

open System.IO

if File.Exists("test.txt") then
    printfn "Text file test.txt is preset"
else
    printfn "Text file test.txt could not be found"



printfn "Press return to exit"
System.Console.ReadLine() |> ignore
