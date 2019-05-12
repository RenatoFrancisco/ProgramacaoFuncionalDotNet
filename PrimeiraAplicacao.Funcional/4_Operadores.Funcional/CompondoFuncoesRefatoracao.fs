module CompondoFuncoesRefatoracao

let converterBooleanoParaTexto valor = 
    if valor 
    then "Sim" 
    else "Não"

let numeroImpar numero = numero % 2 <> 0

let somaCom3 numero = numero + 3

let compor funcao1 funcao2 parametro =
    funcao2 (funcao1 (parametro))

let verificaSeONumeroEImparUsandoOperador = 
    numeroImpar >> converterBooleanoParaTexto

let somaComTresEVerificaSeONumeroEImparUsandoOperador =
    somaCom3 >> numeroImpar >> converterBooleanoParaTexto

let somaDepoisMultiplica =
    compor ((+)1) ((*)2)

let somaDepoisMultiplicaUsandoOOperador valorParaSomar = 
    (+)valorParaSomar >> (*)

let resultado = somaDepoisMultiplicaUsandoOOperador 1 1 <| 2