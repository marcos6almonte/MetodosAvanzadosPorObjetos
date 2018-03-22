using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    //Receiver
    class Fridge
    {
        public void freeze()
        {
            Console.WriteLine("Fridge freezing");
        }
        public void unfreeze()
        {
            Console.WriteLine("Fridge not freezing");
        }
        public void adjust_temp()
        {
            Console.WriteLine("temperature adjusted");
        }
        public void loose_temp()
        {
            Console.WriteLine("Crazy temperature");
        }

    }
}
