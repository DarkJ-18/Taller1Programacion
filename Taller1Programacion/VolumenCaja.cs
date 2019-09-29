using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Programacion
{
    class VolumenCaja
    {
        private double A;
        private double B;
        private double C;

        public void setA(double A)
        {
            this.A = A;
        }

        public double getA()
        {
            return this.A;
        }

        public void setB(double B)
        {
            this.B = B;
        }

        public double getB()
        {
            return this.B;
        }

        public void setC(double C)
        {
            this.C = C;
        }

        public double getC()
        {
            return this.C;
        }

        public double Volumcaja()
        {
            return (this.getA() * this.getB() * this.getC());
        }



    }
}
