module Servicos

open Dominio
open Persistencia

module ClienteServico =
    let obterClientes() =
        obterContexto().Clientes
        
    let atualizarTabelasClientes funcaoParaObterNovosDados =
        let tabela = obterClientes()
        let dados = funcaoParaObterNovosDados tabela
        salvarTabela { tabela with Dados = dados}
 
    let incluirCliente cliente =
        atualizarTabelasClientes (fun tabela -> cliente :: tabela.Dados)

    let excluirClienteComId id (lista: Cliente list) =
        lista
        |> List.filter (fun cliente -> cliente.Id <> id)

    let excluirCliente id =
        atualizarTabelasClientes (fun tabela -> excluirClienteComId id tabela.Dados)

    let atualizarCliente cliente =
        let removeEAdiciona tabela =
                cliente ::  
                (excluirClienteComId
                    cliente.Id
                    tabela.Dados)
        atualizarTabelasClientes (removeEAdiciona)

    let filtrarTabelasClientesPor filtro =
        obterClientes().Dados
        |> List.filter filtro

    let obterPorCpf cpf =
        filtrarTabelasClientesPor (fun cliente -> cliente.CPF = cpf)

    let obterPorNome nome =
        filtrarTabelasClientesPor (fun cliente -> cliente.Nome = nome)

    let obterPorId id =
        obterClientes().Dados
        |> List.tryFind (fun cliente -> cliente.Id = id)

    let obterTodos() =
        obterClientes().Dados



    