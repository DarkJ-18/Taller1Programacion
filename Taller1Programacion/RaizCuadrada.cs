using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Programacion
{
    public  class RaizCuadrada
    {

        private double num;
      
      
        public void setNum(double num)
        {
            this.num = num;
        }

        public double getNum()
        {
            return this.num;
           
        }

        public double calcular()
        {
            return (Math.Sqrt(this.getNum()));
        }

    }
}
