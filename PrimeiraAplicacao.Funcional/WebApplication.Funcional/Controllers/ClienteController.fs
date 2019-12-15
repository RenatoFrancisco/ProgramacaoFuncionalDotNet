namespace WebApplication.Funcional.Controllers

open Servicos
open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("api/[controller]/[action]/{id?}")>]
type ClienteController() =
    inherit ControllerBase()

    [<HttpGet>]
    member __.ObterTodos() =
        Persistencia.obterContexto().Clientes.Dados

    [<HttpPost>]
    member __.Incluir(cliente) = 
        ClienteServico.incluirCliente cliente

    [<HttpDelete>]
    member __.Excluir(id) =
        Servicos.ClienteServico.excluirCliente id

    [<HttpPut>]
    member __.Atualizar(cliente) =
        ClienteServico.atualizarCliente cliente


