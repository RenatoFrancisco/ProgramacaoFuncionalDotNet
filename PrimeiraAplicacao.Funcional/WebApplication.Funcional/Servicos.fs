module Servicos

open Dominio
open Persistencia

module ClienteServico =
    let obterClientes() =
        obterContexto().Clientes
        
    let incluirCliente cliente =
        let tabela = obterClientes()
        let dados = cliente :: tabela.Dados
        salvarTabela { tabela with Dados = dados }

    let excluirCliente id =
        let tabela = obterClientes()
        let dados = [
            for cliente in tabela.Dados do
                match cliente with
                | cliente when cliente.Id = id -> ignore()
                | cliente -> yield cliente
        ]
        salvarTabela { tabela with Dados = dados }

    