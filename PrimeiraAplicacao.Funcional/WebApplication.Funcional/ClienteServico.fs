module ClienteServico

open Dominio
open Persistencia
open Transporte.Filtros
open Operadores
open Respostas

let obterClientes() =
    obterContexto().Clientes
        
let atualizarTabelasClientes funcaoParaObterNovosDados =
    let tabela = obterClientes()
    let dados = funcaoParaObterNovosDados tabela
    salvarTabela { tabela with Dados = dados}
 
let incluirCliente cliente =
    atualizarTabelasClientes (fun tabela -> cliente :: tabela.Dados)

let transformarListaEmResposta =
    List.map (ClienteResposta.transformar)

let excluirClienteComId id (lista: Cliente list) =
    lista
    |> List.filter (fun cliente -> cliente.Id <> id)

let obterSemClienteComId id (lista : Cliente list) =
    lista
    |> List.filter
        (fun cliente -> cliente.Id <> id)

let excluirClienteDoBanco id =
    atualizarTabelasClientes
        (fun tabela -> obterSemClienteComId id tabela.Dados)

let excluirCliente =
    excluirClienteDoBanco
    >> transformarListaEmResposta

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

let obterPor filtro =
    filtrarTabelasClientesPor
        (fun cliente ->
            (!! filtro.CPF || cliente.CPF = filtro.CPF)
            && (cliente.Nome <~ filtro.Nome
                || cliente.Sobrenome <~ filtro.Nome)
            && (filtro.Idade = 0 || cliente.Idade = filtro.Idade)
        )

let obterPorCpf cpf =
    filtrarTabelasClientesPor (fun cliente -> cliente.CPF = cpf)

let obterPorNome nome =
    filtrarTabelasClientesPor (fun cliente -> cliente.Nome = nome)

let obterDoBancoPorId id =
    obterClientes().Dados
    |> List.tryFind (fun cliente -> cliente.Id = id)

let obterPorId =
    obterDoBancoPorId
    >> Option.map (ClienteResposta.transformar)


let obterTodosDoBanco() = 
    obterClientes().Dados

let obterTodos() =
    obterTodosDoBanco
    >> transformarListaEmResposta



    