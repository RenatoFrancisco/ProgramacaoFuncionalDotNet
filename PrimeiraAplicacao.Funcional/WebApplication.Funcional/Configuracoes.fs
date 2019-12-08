module Configuracoes

open Microsoft.Extensions.Configuration
open System.IO

let constructor = new ConfigurationBuilder()
let constructorDiretorio = constructor.SetBasePath(Directory.GetCurrentDirectory())
let arquivoJson = constructorDiretorio.AddJsonFile("appsettings.json")
let configuracao = arquivoJson.Build()

let obterConfiguracao (nomeConfiguracao: string) =
    configuracao.[nomeConfiguracao]

let diretorioTabelas = obterConfiguracao "DiretorioTabelas"



