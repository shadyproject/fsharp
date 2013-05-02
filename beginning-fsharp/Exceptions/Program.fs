//demo of exceptions and exception handling
printfn "Exception handling demo"

//define an exception (union type)
exception WrongSecond of int

//list of prime numbers
let primes = [2;3;5;7;11;13;17;19;23;29;31;37;41;43;47;53;59]

//function to test if the current second is prime
let testSecond() = 
    try
        let currentSecond = System.DateTime.Now.Second in
        //test to see if the current second is in the list of primes
        if List.exists (fun x -> x = currentSecond) primes then
            failwith "A Prime Second"
        else
            raise (WrongSecond currentSecond)
    with
    //catch the wrong second exception
    WrongSecond x ->
        printfn "The current second was %i which is not prime" x

testSecond()

printfn "Press return to exit"
ignore(System.Console.ReadLine)