namespace WebApplication.Funcional.Controllers

open Servicos
open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("api/[controller]/[action]/{id?}")>]
type ClienteController() =
    inherit ControllerBase()

    [<HttpGet>]
    member __.ObterTodos() =
        ClienteServico.obterTodos()

    [<HttpGet>]
    member __.ObterPorId(id) =
        ClienteServico.obterPorId id

    [<HttpGet>]
    member __.ObterPorCpf(cpf) =
        ClienteServico.obterPorCpf cpf

    [<HttpGet>]
    member __.ObterPorNome([<FromQuery>]nome) =
        ClienteServico.obterPorNome nome

    [<HttpPost>]
    member __.Incluir(cliente) = 
        ClienteServico.incluirCliente cliente

    [<HttpDelete>]
    member __.Excluir(id) =
        Servicos.ClienteServico.excluirCliente id

    [<HttpPut>]
    member __.Atualizar(cliente) =
        ClienteServico.atualizarCliente cliente


