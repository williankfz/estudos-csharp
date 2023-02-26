using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double Calculo(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * iof / 100.0;
        }
    }
}
