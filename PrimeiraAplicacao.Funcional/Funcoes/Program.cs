using System;
using System.Collections.Generic;
using System.Linq;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicarEImpimirNumeroTest();
            Console.ReadKey();
        }

        static void VerificadorNumeroParTest()
        {
            var numeroPares = new List<int>();
            var numeros = Enumerable.Range(0, 10);

            Func<int, bool> metodoParaFiltrarViaLambda = numero => numero % 2 == 0;

            numeroPares.Where(VerificadorNumeroPar.NumeroEPar);
        }

        static void MultiplicarEImpimirNumeroTest()
        {
            Action<int> multiplicaPor5EDepoisImprimir = FuncaoAltaOrdem.MultiplicarEImprimirNumero(5);
            Action<int> multiplicaPor3EDepoisImprimir = FuncaoAltaOrdem.MultiplicarEImprimirNumero(3);

            int numeroQueSeraMultiplicado = 10;

            multiplicaPor5EDepoisImprimir(numeroQueSeraMultiplicado);
            multiplicaPor3EDepoisImprimir(numeroQueSeraMultiplicado);

        }

    }
}
