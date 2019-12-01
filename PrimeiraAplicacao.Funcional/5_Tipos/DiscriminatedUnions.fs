module DiscriminatedUnions

type InteiroOuBool = 
    | Inteiro of int
    | Bool of bool

type Pessoa = { Nome:string; Idade:int }

type DiscriminatedComplexo =
    | InteiroOuBool of InteiroOuBool
    | Pessoa of Pessoa
    | Tupla of int * string

type Resultado = 
    | Sucesso
    | Erros of string list

type RespostaDoUsuario =
    | Sim
    | Nao

type Cor = 
    | Vermelho
    | Verde
    | Azul

let resultadoDeSucesso = Sucesso
let resultadoComErros = Erros["Inválido"]

let tupla = Tupla (3, "Gabriel")

let inteiroDoDiscriminated = Inteiro 1
let boolDoDiscriminated = Bool false

let escreveInteiroOuBool inteiroOuBooleano = 
    match inteiroOuBooleano with
    | Inteiro valorInteiro -> printfn "%i" valorInteiro
    | Bool valorBooleano -> printfn "%b" valorBooleano

escreveInteiroOuBool boolDoDiscriminated
escreveInteiroOuBool inteiroDoDiscriminated

type IdentificadorCliente = int
type Nome = | Nome of string
type Sobrenome = | Sobrenome of string

type Cliente = { 
    Id:IdentificadorCliente; 
    Nome:Nome; 
    Sobrenome:Sobrenome }

let criarCliente id nome sobrenome = { Id = id; Nome = nome; Sobrenome = sobrenome }

let id = 1
let nome = Nome "Renato"
let sobrenome = Sobrenome "Francisco"

let cliente1 = criarCliente id nome sobrenome

let talvezUmaString = Some "Aprendendo tipos opcionais"
let talvezOutraString = None

match talvezUmaString with
    | Some texto -> printfn "%s" texto
    | None -> printfn "Valor inválido"

if talvezUmaString.IsSome
    then printfn "%s" talvezUmaString.Value
    else printfn "%s" "Valor inválido"

let testeComValor = Some "Testando valor nulo"
let testeSemValor = None

let length = 
    match testeComValor with
    | Some texto -> texto.Length
    | None -> 0

let stringQueVeioDoCSharp = "Teste com do c#"

let stringParaUsarNaAplicacao =
    match stringQueVeioDoCSharp with
    | null -> None
    | valor -> Some valor



