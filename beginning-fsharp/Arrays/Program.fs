//define an array literal
let rhymeArray = [| "Went to the market"; "Stayed home"; "had roast beef"; "had none"|]

//unpack the array into identifiers
let firstPiggy = rhymeArray.[0]
let secondPiggy = rhymeArray.[1]
let thirdPiggy = rhymeArray.[2]
let fourthPiggy = rhymeArray.[3]

//update the elements
rhymeArray.[0] <- "Wee,"
rhymeArray.[1] <- "wee,"