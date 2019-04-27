using System;

namespace PrimeiraAplicacaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            var soma = calc.SomaQuadradoDosNumerosAteDez();
            Console.WriteLine($"A soma é: {soma}");
            Console.ReadKey();
        }
    }
}
