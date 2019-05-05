using System;
using System.Collections.Generic;
using System.Linq;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcoes = new FuncoesAninhadas();
            funcoes.EscreveSeNumeroEParOuImpar(12);
            funcoes.EscreveSeNumeroEParOuImpar(17);

            Console.ReadKey();
        }

        static void VerificadorNumeroParTest()
        {
            var numeroPares = new List<int>();
            var numeros = Enumerable.Range(0, 10);

            Func<int, bool> metodoParaFiltrarViaLambda = numero => numero % 2 == 0;

            numeroPares.Where(VerificadorNumeroPar.NumeroEPar);
        }

    }
}
