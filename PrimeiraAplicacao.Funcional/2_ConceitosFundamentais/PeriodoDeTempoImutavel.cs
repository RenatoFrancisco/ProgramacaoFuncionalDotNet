using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ConceitosFundamentais
{
    public class PeriodoDeTempoImutavel
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public PeriodoDeTempoImutavel(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
        }

        public bool VerificarSeDataEstaEntreOPeriodo(DateTime data) =>
            data.CompareTo(DataInicial) >= 0
                && data.CompareTo(DataFinal) <= 0;
    }
}
