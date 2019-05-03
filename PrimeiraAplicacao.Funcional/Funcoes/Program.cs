using System;

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
    }
}
