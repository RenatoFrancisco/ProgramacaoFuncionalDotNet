using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes
{
    public class FuncoesAninhadas
    {
        public void EscreveSeNumeroEParOuImpar(int numero)
        {
            bool verificarSeNumeroEPar() => numero % 2 == 0;

            Action escreveNumeroPar = () =>
                Console.WriteLine(string.Format("O número {0} é par", numero));

            Action escreveNumeroImpar = () =>
                Console.WriteLine(string.Format("O número {0} é impar", numero));

            if (verificarSeNumeroEPar())
                escreveNumeroPar();
            else
                escreveNumeroImpar();
        }
    }
}
