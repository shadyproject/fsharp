printfn "Some examples of control flow"

let lb = System.Environment.NewLine

//We aren't forced to use an else here, since we are doing this in an imperative fashion
if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Sunday then
    printfn "Sunday Playlist: Lazy On A Sunday Afternoon - Queen"
    
//although if the else expression is of type unit, we can use one if we want
if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Monday then
    printfn "Monday Playlist: Blue Monday - New Order"
else
    printfn "Alt Playlist: Fell in Love with a Girl - White Stripes"

//uses whitespace as an "else" clause, even though its more of a fall through
if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Tuesday then
    printfn "Tuesday Playlist: Ruby Tuesday - Rolling Stones"
printfn "Everyday Playlist: Eight Days a Week - The Beatles"

if System.DateTime.Now.DayOfWeek = System.DayOfWeek.Friday then
    printfn "Friday Playlist: Friday I'm In Love - The Cure"
    printfn "Friday Playlist: View From the Afternoon - Arctic Monkeys"

//now lets play around with some iteration
let words = [| "red"; "lorry"; "yellow"; "lorry" |]

//use a for loop to print each element
for word in words do
    printfn "%s" word

//another usage of the for loop
let haiku = [| "Green"; "frog"; "Is"; "your"; "body"; "also"; "fresly"; "painted?" |]

for index = 0 to Array.length haiku - 1 do
    printf "%s " haiku.[index]
    
printf "%s" lb

//a for loop with downto
let anotherHaiku = [| "watching."; "been"; "have"; "children"; "three"; "my"; "realize"; "and"; "ant"; "an"; "kill"; "I" |]

for index = Array.length anotherHaiku - 1 downto 0 do
    printf "%s " anotherHaiku.[index]
    
printf "%s" lb

//and now a while loop
let yetAnotherHaiku = ref [ "An"; "old"; "pond"; "A"; "frog"; "jumps"; "in-"; "The"; "sound"; "of"; "water"]

while (List.length !yetAnotherHaiku > 0) do
    printf "%s " (List.head !yetAnotherHaiku)
    yetAnotherHaiku := List.tail !yetAnotherHaiku

printf "%s" lb

printfn "Press return to exit"
System.Console.ReadLine() |> ignore
