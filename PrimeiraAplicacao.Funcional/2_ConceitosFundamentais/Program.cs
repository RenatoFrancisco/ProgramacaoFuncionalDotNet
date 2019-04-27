using System;

namespace _2_ConceitosFundamentais
{
    class Program
    {
        static void Main(string[] args)
        {
            var periodo = new PeriodoDeTempoImutavel(DateTime.Parse("20/08/2016"), DateTime.Parse("31/08/2016"));

            var datasParaTeste = new DateTime[]
            {
                DateTime.Parse("18/08/2016"),
                DateTime.Parse("22/08/2016"),
                DateTime.Parse("01/09/2016"),
            };

            ImprimirResultado(datasParaTeste, periodo);

            Console.WriteLine("Após Alteração:");

            PeriodoDeTempoImutavel.AdicionarDias(periodo, 30);

            ImprimirResultado(datasParaTeste, periodo);

            Console.ReadKey();
        }

        static void ImprimirResultado(DateTime[] datas, PeriodoDeTempoImutavel periodo)
        {
            foreach (var data in datas)
            {
                var resultado = PeriodoDeTempoImutavel.VerificarSeDataEstaEntreOPeriodo(periodo, data);
                Console.WriteLine($@"A data {data:dd/MM/yyyy} está entre {periodo.DataInicial:dd/MM/yyyy} e {periodo.DataFinal:dd/MM/yyyy}? {(resultado ? "Sim" : "Não")}.");
            }
        }
    }
}
