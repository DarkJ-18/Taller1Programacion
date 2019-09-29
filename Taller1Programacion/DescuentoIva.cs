using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Programacion
{
    public class DescuentoIva
    {

       
        private double monto;

        public void setMonto(double monto)
        {
            this.monto = monto;
        }

        public double getMonto()
        {
            return this.monto;
        }

      
        public double descuento()
        {
            return (this.getMonto() - (0.20 * this.getMonto()));
        }

        public double total()
        {
            return (this.descuento() * 1.19);
        }

       

    }
}
