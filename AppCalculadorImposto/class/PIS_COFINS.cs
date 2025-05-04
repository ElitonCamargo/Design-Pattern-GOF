using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public class PIS_COFINS: TipoImposto
    {
        public decimal Calcular(decimal valor)
        {
            return valor * 0.09m; // PIS/COFINS 9%
        }
    }
    
}
