using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1Programacion
{
    public class EdadSegundos
    {

        private int edad;

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public int calcular()
        {
            return ((2019) - this.getEdad());
        }

        public int segundos()
        {
            return (this.calcular()) * (3600) * (24) * (365) - 2019;
        }

    }
}
