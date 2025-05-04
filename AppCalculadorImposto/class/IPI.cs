using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public class IPI: TipoImposto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.10m; // IPI 10%
        }
    }
}
