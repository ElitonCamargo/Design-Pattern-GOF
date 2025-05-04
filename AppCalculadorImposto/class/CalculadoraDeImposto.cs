using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadorImposto
{
    public class CalculadoraDeImposto
    {
        private TipoImposto tipoImposto;
        private decimal baseCalculo;

        public CalculadoraDeImposto(TipoImposto tipoImposto, decimal baseCalculo) 
        {
            this.tipoImposto = tipoImposto;
            this.baseCalculo = baseCalculo;
        }
        public decimal calcular() 
        {
            return tipoImposto.Calcular(this.baseCalculo);
        }
    }
}
