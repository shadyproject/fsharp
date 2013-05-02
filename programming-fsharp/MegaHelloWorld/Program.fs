// Learn more about F# at http://fsharp.net

(*
    MegaHelloWorld
    Take two command line arguments
    Print them to the console with the current date and time
*)

open System

[<EntryPoint>]
let main (args: string[]) = 
    if args.Length <> 2 then
        failwith "Error: Expected arguments <greeting> and <thing>"
    let greeting, thing = args.[0], args.[1]
    let timeOfDay =  DateTime.Now.ToString("hh:mm tt")
    
    printfn "%s, %s at %s" greeting, thing, timeOfDay
    
    //program exit code
    0