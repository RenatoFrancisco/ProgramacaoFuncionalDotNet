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
    