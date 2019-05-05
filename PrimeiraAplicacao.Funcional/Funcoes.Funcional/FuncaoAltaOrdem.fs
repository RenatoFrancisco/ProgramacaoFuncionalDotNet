module FuncaoAltaOrdem

let executarAcaoSobreElementos lista acao =
    lista |> List.iter acao

let imprimirNomes nomes = executarAcaoSobreElementos nomes (printfn "Olá %s")
 
let imprimirDobroDeUmNumero numero = printfn "%i." (numero * 2)

let imprimirDobroDosNumeros numeros =  executarAcaoSobreElementos numeros (fun numero -> printfn "%i." (numero *2))

let multiplicarEImprimirNumero multiplicador numero = printfn "%i." (numero * multiplicador)

let imprimirListaDeNumeros multiplicador numeros =
    executarAcaoSobreElementos numeros
        (multiplicarEImprimirNumero multiplicador)

let multiplicarEImprimirNumeroCurrying multiplicador = 
    let imprimirNumero numero =
        printfn "%i." (numero * multiplicador)
    
    imprimirNumero


