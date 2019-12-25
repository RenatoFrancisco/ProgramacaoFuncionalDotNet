module ProdutoServico

open Operadores
open Dominio
open Persistencia
open Transporte.Filtros
open ProdutoResposta

let transformarListaEmResposta =
    List.map (ProdutoResposta.transformar)


let obterProdutos() =
    obterContexto().Produtos

let obterTodosDoBanco() =
    obterProdutos().Dados

let atualizarTabelaProdutos funcaoParaObterNovosDados =
    obterProdutos()
    |> EntidadeServico.atualizaTabela funcaoParaObterNovosDados

let filtrarTabelaProdutosPor filtro =
    obterProdutos().Dados
    |> List.filter filtro

let obterSemProdutoComId id (lista : Produto list) =
    lista
    |> List.filter (fun produto -> produto.Id <> id)

let excluirProduto id =
    atualizarTabelaProdutos (fun tabela -> obterSemProdutoComId id tabela.Dados)

let incluirProduto produto =
    atualizarTabelaProdutos (fun tabela -> produto :: tabela.Dados)

let atualizarProduto produto =
    let removeEAdciona tabela =
        produto :: (obterSemProdutoComId produto.Id tabela.Dados)
    atualizarTabelaProdutos(removeEAdciona)

let obterTodos() =
    obterTodosDoBanco
    >> transformarListaEmResposta

let obterDoBancoPorId id =
    obterProdutos().Dados
    |> List.tryFind (fun produto -> produto.Id = id)

let obterPorId =
    obterDoBancoPorId
    >> Option.map (ProdutoResposta.transformar)

let obterPor (filtro : ProdutoFiltro) =
    filtrarTabelaProdutosPor
        (fun produto ->
            produto.Descricao <~ filtro.Descricao
            && (filtro.PrecoMaximo = 0.0 || produto.Preco <= filtro.PrecoMaximo))
