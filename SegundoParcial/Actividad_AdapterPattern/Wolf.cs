using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class Wolf
    {
        public virtual void howl()
        {
            Console.WriteLine("Howl...");
        }
        public virtual void run()
        {
            Console.WriteLine("Run...");
        }
    }
}
