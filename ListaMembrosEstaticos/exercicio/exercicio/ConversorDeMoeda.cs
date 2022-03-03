using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class ConversorDeMoeda
    {
        public static double Valor(double valor, double quantidade)
        {
            return (valor * quantidade) * 6 / 100 + (quantidade * valor);
        }
    }
}
