using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAplicacaoOO
{
    class Calculadora
    {
        public int ElevaNumeroAoQuadrado(int numero)
        {
            return numero * numero;
        }

        public int SomaQuadradoDosNumerosAteDez() =>
            Enumerable.Range(1, 10)
                .Select(ElevaNumeroAoQuadrado)
                .Sum();

    }
}
