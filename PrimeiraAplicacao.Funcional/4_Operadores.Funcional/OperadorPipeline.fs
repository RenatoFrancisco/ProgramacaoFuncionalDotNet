module OperadorPipeline

let multiplicaPor2 numero = numero * 2

let dobrarValoresDeUmaListaComOperador() =
    [0..10]
    |> List.filter (fun numero -> numero < 5)
    |> List.map multiplicaPor2

let retorno = dobrarValoresDeUmaListaComOperador()

let somarCom10 numero = numero + 10
let somarCom2 numero = numero + 2

let variasOperacoes valor1 valor2 =
    valor1 + valor2
    |> somarCom10
    |> somarCom2
    |> multiplicaPor2

let retorno1 = variasOperacoes 2 3

let exemploInverso valor1 valor2 =
    somarCom10 <| valor1 + valor2

let retorno2 = exemploInverso 2 3