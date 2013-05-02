open System

//Example using Type definitions and type parameters (aka generics)

//one syntax for specifying types
type 'a BinaryTree = 
    | BinaryNode of 'a BinaryTree * 'a BinaryTree
    | BinaryValue of 'a

let tree1 = BinaryNode(BinaryNode(BinaryValue 1, BinaryValue 2), BinaryNode(BinaryValue 3, BinaryValue 4))

//a different syntax for specifying types
type Tree<'a> = 
    | Node of Tree<'a> list
    | Value of 'a

let tree2 = 
    Node([ Node([Value "one"; Value "two"]); Node([Value "three"; Value "four"])])

//function to print the binary tree
let rec printBinaryTreeValues x = 
    match x with
    | BinaryNode(node1, node2) ->
        printBinaryTreeValues node1
        printBinaryTreeValues node2
    | BinaryValue x ->
        printf "%A" x

//function to print a regular tree
let rec printTreeValues x =
    match x with 
    | Node n -> List.iter printTreeValues n
    | Value x -> printf "%A" x

//print the results
printBinaryTreeValues tree1;
printfn "\n"
printTreeValues tree2

Console.WriteLine "Press return to quit"
ignore(Console.ReadLine())