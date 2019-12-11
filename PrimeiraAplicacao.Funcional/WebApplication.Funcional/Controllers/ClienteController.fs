namespace WebApplication.Funcional.Controllers

open Servicos
open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("api/[controller]/[action]")>]
type ClienteController() =
    inherit ControllerBase()

    [<HttpGet>]
    member __.ObterTodos() =
        Persistencia.obterContexto().Clientes.Dados

    [<HttpPost>]
    member __.Incluir(cliente) = 
        ClienteServico.incluirCliente cliente


