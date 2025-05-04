using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public interface TipoImposto
    {
        decimal Calcular(decimal valor);
    }
}
