module InterfacesEmFSharp

type IPessoa =
    abstract member Nome: string
    abstract member Sobrenome: string
    abstract member NomeCompleto: string

type PessoaComInterface (nome: string, sobrenome: string) =
    member val Nome = nome with get, set
    member val Sobrenome = sobrenome with get, set
    
    interface IPessoa with
        member this.Nome = nome
        member this.Sobrenome = sobrenome
        member this.NomeCompleto = sprintf "%s %s" nome sobrenome



