module CompondoFuncoes

let converterBooleanoParaTexto valor = 
    if valor 
    then "Sim" 
    else "Não"
 
let numeroImpar numero = numero % 2 <> 0

let verificaSeNumeroEImpar valor =
    let resultado = numeroImpar valor
    converterBooleanoParaTexto resultado

let compor funcao1 funcao2 parametro =
    funcao2 (funcao1 (parametro))

let vertificaSeONumeroEImparUsandoComporValor valor =
    compor numeroImpar converterBooleanoParaTexto valor

let somaCom3 numero = numero + 3

let retorno = verificaSeNumeroEImpar 3
let retorno1 = vertificaSeONumeroEImparUsandoComporValor 2

let somaComTresEVerificaSeONumeroEImparUsandoCompor =
    compor somaCom3 (compor numeroImpar converterBooleanoParaTexto)

let retorno2 = somaComTresEVerificaSeONumeroEImparUsandoCompor 3

