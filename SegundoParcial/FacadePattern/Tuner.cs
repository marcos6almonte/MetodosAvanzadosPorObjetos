using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner Encendido");
        }

        public void Off()
        {
            Console.WriteLine("Tuner Apagado");
        }

        public void SetFrequency()
        {
            Console.WriteLine("Ajustando frecuencia");
        }
    }
}
