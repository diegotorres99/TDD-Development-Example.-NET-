using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorImpuestos
    {
        const decimal porcentajeIVA = 0.16m;
        const decimal ish = 0.03m;
        public decimal ObtenerIVA(decimal montoReserva)
        {
            return porcentajeIVA * montoReserva;
        }

        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        {
            return montoReserva * porcentaje;  
        }

        public decimal ObtenerTotal(decimal iva, decimal ish, decimal monto)
        {
            return iva + ish + monto;
        }
    }
}
