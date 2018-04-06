using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class CDPlayer
    {
        public void On()
        {
            Console.WriteLine("CDPlayer Encendido");
        }

        public void Off()
        {
            Console.WriteLine("CDPlayer Apagado");
        }

        public void EjectCD()
        {
            Console.WriteLine("Expulsando CD");
        }

        public void PlayCD()
        {
            Console.WriteLine("Reproduciendo CD");
        }
    }
}
