using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public class FL : TipoImposto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.25m; // FL 25%
        }
    }
}
