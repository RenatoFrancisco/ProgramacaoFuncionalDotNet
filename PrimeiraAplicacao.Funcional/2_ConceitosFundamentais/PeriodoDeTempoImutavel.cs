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
    }
}
