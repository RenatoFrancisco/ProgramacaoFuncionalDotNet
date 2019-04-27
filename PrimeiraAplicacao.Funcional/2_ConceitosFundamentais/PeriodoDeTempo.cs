using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ConceitosFundamentais
{
    public class PeriodoDeTempo
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public bool VerificarSeDataEstaEntreOPeriodo(DateTime data) =>
            data.CompareTo(DataInicial) >= 0
                && data.CompareTo(DataFinal) <= 0;
    }
}
