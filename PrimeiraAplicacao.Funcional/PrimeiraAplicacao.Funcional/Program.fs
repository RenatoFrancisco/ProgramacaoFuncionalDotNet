// Learn more about F# at http://fsharp.org

open System

let olaMundo() = 
    printfn "Olá mundo!"

let elevaNumeroAoQuadrado numero = numero * numero;

let somaQuadradoNumerosAteDez = 
    [1..10] 
    |> List.map elevaNumeroAoQuadrado 
    |> List.sum

[<EntryPoint>]
let main argv =
    olaMundo()
    0 // return an integer exit code
