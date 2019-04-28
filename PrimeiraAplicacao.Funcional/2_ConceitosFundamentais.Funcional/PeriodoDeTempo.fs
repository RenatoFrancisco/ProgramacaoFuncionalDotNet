module PeriodoDeTempo
open System

type Periodo = { DataInicial: DateTime; DataFinal: DateTime }

let adicionarDias periodo dias = {
    DataInicial = periodo.DataInicial.AddDays dias
    DataFinal = periodo.DataFinal.AddDays dias
}

let verificarSeDataEstaEntreOPeriodo periodo (data: DateTime) =
    data.CompareTo periodo.DataInicial >= 0 &&
    data.CompareTo periodo.DataFinal <= 0

let exemploDeUsoExpressao numero = 
    let resultado =
        if numero % 2 = 0 then 2 else 0
    printf "%i" resultado
    