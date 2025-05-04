using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public static class Helper
    {
        public static TipoImposto selecionarImposto(string tipoImposto) 
        {
            return tipoImposto switch
            {
                "1" => new ICMS(),
                "2" => new IPI(),
                "3" => new PIS_COFINS(),
                _ => throw new ArgumentException("Tipo de imposto inválido.")
            };
        }
    }
}
