module Pie

open System

let convertDataRow (str:string) =
    let cells = List.ofSeq(str.Split(','))
    match cells with
    | lbl::num::_ ->
        let numI = Int32.Parse(num)    
        (lbl, numI)
        | _ -> failwith "incorect data"

let rec processLines lines =
    match lines with
    | [] -> []
    | head::tail ->
    let processedTail = processLines(tail)
    let singleLine = convertDataRow head
    singleLine::processedTail


let rec countSum lines =
    match lines with
    | [] -> 0
    | (_, num)::tail ->
    let rest = countSum tail
    num + rest

let show (str:string) =
    let (success, num) = Int32.TryParse(str)
    if success then
        Console.WriteLine("Succeeded: {0}", num)
    else
        Console.WriteLine("failed")

let showResults data sum =
    for (lbl, num) in data do
        let perc = int(float(num)/sum * 100.0)
        Console.WriteLine("{0, -10} has {1,8} pts: {2}%", lbl, num, perc)

let printSquares msg n1 n2 =
    let printOne n=
        let square = n * n
        printfn "%s %d is %d" msg n square
    printOne n1
    printOne n2;;