namespace WebApplication.Funcional.Controllers

open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("api/[controller]/[action]/{id?}")>]
type CompraController() =
    inherit ControllerBase()

    [<HttpGet>]
    member __.ObterTodos() =
        CompraServico.obterTodos()

    [<HttpGet>]
    member __.ObterPorId id =
        CompraServico.obterPorId id

    [<HttpPost>]
    member __.Salvar compra =
        CompraServico.incluirCompra compra

    [<HttpPut>]
    member __.Atualizar compra =
        CompraServico.atualizarCompra compra

    [<HttpDelete>]
    member __.Excluir id =
        CompraServico.excluirCompra id


