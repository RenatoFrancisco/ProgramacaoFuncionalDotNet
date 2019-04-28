using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ConceitosFundamentais
{
    public class PeriodoDeTempoImutavel
    {

        public DateTime DataInicial { get; }
        public DateTime DataFinal { get; }

        public PeriodoDeTempoImutavel(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        public static bool VerificarSeDataEstaEntreOPeriodo(PeriodoDeTempoImutavel periodo, DateTime data) =>
            data.CompareTo(periodo.DataInicial) >= 0
                && data.CompareTo(periodo.DataFinal) <= 0;

        public static PeriodoDeTempoImutavel AdicionarDias(PeriodoDeTempoImutavel periodo, int dias) =>
            new PeriodoDeTempoImutavel(periodo.DataInicial.AddDays(dias), periodo.DataFinal.AddDays(dias));

        void ExemploUsoDeDeclaracao(int numero)
        {
            int resultado = 0;
            bool numeroPar = numero % 2 == 0;

            if (numeroPar)
                resultado = 2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        void ExemploUsoDeExpressao(int numero)
        {
            bool numeroPar = numero % 2 == 0;
            int resultado = numeroPar ? 2 : 0;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
