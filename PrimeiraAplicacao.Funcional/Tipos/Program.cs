using System;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Fatorial(int numero)
        {
            int acumulador = numero;

            for (int n = numero - 1; n >= 0; n--)
                acumulador *= numero;

            return acumulador;
        }

        private static int FatorialRecursivo(int numero)
        {
            return numero == 0 || numero == 1 ? 1
                : numero == 2 ? 2
                : numero * FatorialRecursivo(numero - 1);
        }
    }
}
