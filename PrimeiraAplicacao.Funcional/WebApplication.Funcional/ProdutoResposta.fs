module ProdutoResposta

open Dominio

type ProdutoResposta = {
    Id : int
    Descriacao : string
    Detalhes : string
    Preco : double
} with
  static member
    transformar (produto : Produto) = 
    {
        Id = produto.Id
        Descriacao = produto.Descricao
        Detalhes = produto.Detalhes
        Preco = produto.Preco
    }
