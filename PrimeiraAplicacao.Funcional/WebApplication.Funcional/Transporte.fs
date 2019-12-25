namespace Transporte

[<CLIMutable>]
module Filtros =

    type ClienteFiltro = {
        Nome : string
        CPF : string
        Idade : int
    }
    
    type ProdutoFiltro = {
        Descricao : string
        PrecoMaximo : double
    }



