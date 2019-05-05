namespace Modulos

[<RequireQualifiedAccess>]
module FuncoesDeEscrita =
    let escrever nome =z printfn "Seu nome é: %s" nome


module FuncoesDeEscritaDeNumero =
    let escrever idade = printfn "Sua idade é: %i" idade

namespace OutroNamespace
open Modulos

module FuncoesDeEscritasUtilizandoOutrosModulos =
    let escrever nome idade = 
        FuncoesDeEscrita.escrever nome
        FuncoesDeEscritaDeNumero.escrever idade
    


