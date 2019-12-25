module EntidadeServico

open Persistencia

let atualizaTabela funcaoParaObterNovosDados tabela =
    let dados = funcaoParaObterNovosDados tabela
    salvarTabela { tabela with Dados = dados}