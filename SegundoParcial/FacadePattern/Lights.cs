using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Lights
    {
        public void On()
        {
            Console.WriteLine("Luces Encendidas");
        }

        public void Off()
        {
            Console.WriteLine("Luces Apagadas");
        }
    }
}
