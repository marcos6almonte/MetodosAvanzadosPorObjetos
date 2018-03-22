using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    //Receiver
    class Lights
    {
        public void on()
        {
            Console.WriteLine("Lights on");
        }
        public void off()
        {
            Console.WriteLine("Lights off");
        }
    }
}
