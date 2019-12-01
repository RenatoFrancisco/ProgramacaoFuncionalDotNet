module ClassesEmFSharp

type Pessoa (nome: string, sobrenome: string) =
    member this.Nome = nome
    member this.Sobrenome = sobrenome

let renato = Pessoa("Renato", "Francisco")
//renato.Sobrenome <- "Silva"

//type PessoaComGetESet (nome: string, sobrenome: string) = 
//    let mutable _nome = nome
//    let mutable _sobrenome = sobrenome

//    member this.Nome
//        with get() = _nome
//        and set value = _nome <- sobrenome

//    member this.Sobrenome
//        with get() = _sobrenome
//        and set value = _sobrenome <- sobrenome

//let renato2 = PessoaComGetESet("Renato", "Francisco")

type PessoaComAutoProperty (nome: string, sobrenome: string) =
    member val Nome = nome with get, set
    member val Sobrenome = sobrenome with get, set

let renato3 = PessoaComAutoProperty("Renato", "Francisco")
//renato.Sobrenome <- "Silva"

type PessoaComIdade (idade: int) =
    let mutable _maioridade = false
    do
        _maioridade <- idade >= 18

    member val idade = idade with get, set
    member val Maioridade = _maioridade with get

type PessoaComHeranca (nome: string, sobrenome: string, idade: int) =
    inherit PessoaComAutoProperty(nome, sobrenome)
    let mutable _maioridade = false
    do
        _maioridade <- idade >= 18

    member val idade = idade with get, set
    member val maioridade = _maioridade with get

let gabriel = PessoaComHeranca("Gabriel", "Schade", 26)






