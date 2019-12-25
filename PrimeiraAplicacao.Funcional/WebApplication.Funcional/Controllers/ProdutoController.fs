namespace WebApplication.Funcional.Controllers

open Microsoft.AspNetCore.Mvc

[<ApiController>]
[<Route("api/[controller]/[action]/{id?}")>]
type ProdutoController() =
    inherit ControllerBase()

    [<HttpGet>]
    member __.ObterTodos() =
        ProdutoServico.obterTodos()

    [<HttpGet>]
    member __.ObterPorId id =
        ProdutoServico.obterPorId id

    [<HttpGet>]
    member __.ObterPor( [<FromQuery>] filtro) =
        ProdutoServico.obterPor filtro

    [<HttpPut>]
    member __.Atualizar produto =
        ProdutoServico.atualizarProduto produto

    [<HttpDelete>]
    member __.Excluir id =
        ProdutoServico.excluirProduto id