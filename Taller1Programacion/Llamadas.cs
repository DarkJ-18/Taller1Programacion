using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Programacion
{
    public class Llamadas
    {
        private double minutos;



        public void setMinutos(double minutos)
        {
            this.minutos = minutos;
        }


        public double getMinutos()
        {
            return this.minutos;
        }

        public double llamada1()
        {
            return ((this.getMinutos() * 900));
        }

        public double llamada2()
        {
            return ((this.getMinutos() * 800));
        }

        public double llamada3()
        {
            return ((this.getMinutos() * 950));
        }

        public double llamada4()
        {
            return ((this.getMinutos() * 1250));
        }

        public double descuetotal()
        {
            return (this.llamada1() - this.opdescuento1());
        }

        public double descuetota2()
        {
            return (this.llamada1() - this.opdescuento2());
        }

        public double descuetota3()
        {
            return (this.llamada1() - this.opdescuento3());
        }

        public double descuetota4()
        {
            return (this.llamada1() - this.opdescuento4());
        }

        public double opdescuento1()
        {
            return (this.llamada1() * 0.2);

        }

        public double opdescuento2()
        {
            return (this.llamada2() * 0.2);

        }

        public double opdescuento3()
        {
            return (this.llamada3() * 0.2);

        }

        public double opdescuento4()
        {
            return (this.llamada4() * 0.2);

        }

    }
}
