open System
//example showing how to use complete active patterns
printfn "Active Pattern Examples"

//these are just names that we use later on in a pattern to reference the functions to call if a case matches
let (|Foo|Bar|Baz|Blern|) input = 
    //attempt to parse a bool
    let success, res = Boolean.TryParse input
    if success then Foo(res)
    else
        //attempt to parse and int
        let success, res = Int32.TryParse input
        if success then Bar(res)
        else
            //attempt to parse a float
            let success, res = Double.TryParse input
            if success then Baz(res)
            else Blern(input)

//function to print ther results given by the pattern
let printInputWithType input = 
    match input with
    | Foo b -> printfn "Boolean: %b" b
    | Bar i -> printfn "Int: %i" i
    | Baz f -> printfn "Float %f" f
    | Blern s -> printfn "String: %s" s

//print up some results
printInputWithType "true"
printInputWithType "12"
printInputWithType "-12.1"

//now we try some incomplete active patterns
printfn "Incomplete active pattern examples"
open System.Text.RegularExpressions

//definition of an incomplete active pattern
let (|Regexp|_|) regexPattern input = 
    //create and try to match the regex
    let regex = new Regex(regexPattern)
    let regexMatch = regex.Match(input)
    //return either some or none
    if regexMatch.Success then
        Some regexMatch.Value
    else
        None

//function to print the results by pattern matching over different instances of the incomplete active pattern
let printInputWithType' input = 
    match input with
    | Regexp "$true|false^" s -> printfn "Boolean: %s" s
    | Regexp @"$-?\d+^" s -> printfn "Integer: %s" s
    | Regexp "$-?\d+\.\d*^" s -> printfn "Floating point: %s" s
    | _ -> printfn "String: %s" input 

printInputWithType' "true"
printInputWithType' "12"
printInputWithType' "-12.1"

printfn "\nPress return to exit"
ignore(Console.ReadLine())