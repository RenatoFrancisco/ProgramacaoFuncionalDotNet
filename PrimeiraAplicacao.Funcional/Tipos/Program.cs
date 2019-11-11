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
    }
}
