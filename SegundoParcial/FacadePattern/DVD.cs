using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class DVD
    {
        public void On()
        {
            Console.WriteLine("DVD Encendido");
        }

        public void Off()
        {
            Console.WriteLine("DVD Apagado");
        }

        public void EjectCD()
        {
            Console.WriteLine("Expulsando DVD");
        }

        public void PlayCD()
        {
            Console.WriteLine("Reproduciendo DVD");
        }
    }
}
