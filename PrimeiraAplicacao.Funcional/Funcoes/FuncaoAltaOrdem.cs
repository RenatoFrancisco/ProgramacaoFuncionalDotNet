using System;
using System.Collections.Generic;

namespace Funcoes
{
    public class FuncaoAltaOrdem
    {
        public static void ExecutarAcaoSobreElementos<TipoElemento>(
            List<TipoElemento> lista, 
            Action<TipoElemento> acao)
        {
            lista.ForEach(acao);
        }

        public static void ImprimirNomes(List<string> nomes)
        {
            ExecutarAcaoSobreElementos(nomes, Console.WriteLine);
        }

        public static void ImprimirDobroDosNumeros(List<int> numeros)
        {
            ExecutarAcaoSobreElementos(numeros, numero => Console.WriteLine(numero * 2));
        }

        public static Action<int> MultiplicarEImprimirNumero(int multiplicador)
        {
            return (numero) => Console.WriteLine(numero * multiplicador);
        }

        public static void ImprimirNumeros(List<int> numeros, int multiplicador)
        {
            Action<int> multiplicaEDepoisImprimi =
                MultiplicarEImprimirNumero(multiplicador);

            ExecutarAcaoSobreElementos(numeros, multiplicaEDepoisImprimi);
        }
    }
}
