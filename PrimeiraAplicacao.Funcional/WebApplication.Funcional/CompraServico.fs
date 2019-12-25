module CompraServico

open Dominio
open Persistencia

let obterCompras() =
    obterContexto().Compras

let atualizarTabelaCompras funcaoParaObterNovosDados =
    obterCompras()
    |> EntidadeServico.atualizaTabela funcaoParaObterNovosDados

let obterSemCompraComId id (lista: Compra list) =
    lista
    |> List.filter (fun compra -> compra.Id <> id)

let excluirCompra id =
    atualizarTabelaCompras (fun tabela -> obterSemCompraComId id tabela.Dados)

let incluirCompra compra =
    atualizarTabelaCompras (fun tabela -> compra :: tabela.Dados)

let atualizarCompra compra =
    let removeEAdiciona tabela =
        compra :: (obterSemCompraComId compra.Id tabela.Dados)
    atualizarTabelaCompras (removeEAdiciona)

let obterTodos() =
    obterCompras().Dados

let obterPorId id =
    obterCompras().Dados
    |> List.tryFind(fun compra -> compra.Id = id)