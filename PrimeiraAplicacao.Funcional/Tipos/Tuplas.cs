using System;
using System.Collections.Generic;
using System.Text;

namespace Tipos
{
    class Tuplas
    {
        public void CriandoTuplas()
        {
            Tuple<int, int, int> tupla1 = new Tuple<int, int, int>(1, 2, 3);

            //Extraindo os itens da Tupla
            int item1 = tupla1.Item1;
            int item2 = tupla1.Item2;
            int item3 = tupla1.Item3;

            Tuple<int, bool, string> tupla2 =
                new Tuple<int, bool, string>(1, true, "Renato");

            Tuple<int, bool> tupla3 = new Tuple<int, bool>(3, false);

            Tuple<int, int, int, string> tupla4 = 
                new Tuple<int, int, int, string>(1,2, 3, "Teste");

            Func<int, int, int> Soma = (a, b) => a + b;

            Tuple<Func<int, int, int>, bool> tupla5 =
                new Tuple<Func<int, int, int>, bool>(Soma, false);

            Tuple<bool, int> tupla6 = new Tuple<bool, int>(false, 2);
        }
    }
}
