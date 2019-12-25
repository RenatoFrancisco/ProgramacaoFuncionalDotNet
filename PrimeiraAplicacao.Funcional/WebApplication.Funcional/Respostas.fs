module Respostas

open Dominio
open Operators

type ClienteResposta = {
    Id : int
    NomeCompleto : string
    CPF : string
    Idade : int
    Endereco : string
} with
    static member
        transformar (cliente : Cliente) =
        {
            Id = cliente.Id
            NomeCompleto = cliente.Nome ^ " " ^ cliente.Sobrenome
            CPF = cliente.CPF
            Idade = cliente.Idade
            Endereco = cliente.Endereco
        }

type CompraResposta = {
    Id : int
    ClienteResposta : ClienteResposta 
    Itens : ItemCompra list
    ValorTotal : double
}
