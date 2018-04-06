using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Screen
    {
        public void On()
        {
            Console.WriteLine("Pantalla Encendida");
        }

        public void Off()
        {
            Console.WriteLine("Pantalla Apagada");
        }
    }
}
