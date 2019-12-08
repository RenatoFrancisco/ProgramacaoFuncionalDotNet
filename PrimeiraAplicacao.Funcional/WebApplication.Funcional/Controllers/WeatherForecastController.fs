namespace WebApplication.Funcional.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open WebApplication.Funcional

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController (logger : ILogger<WeatherForecastController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() =
        let contexto = Persistencia.obterContexto()
        contexto.Clientes.Dados
