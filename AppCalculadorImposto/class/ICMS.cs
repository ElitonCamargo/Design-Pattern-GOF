using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public class ICMS: TipoImposto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.18m; // ICMS 18%
        }
    }
}
