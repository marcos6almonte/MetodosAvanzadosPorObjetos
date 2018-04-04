using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class Cat
    {
        public virtual void purk()
        {
            Console.WriteLine("Purk...");
        }
        public virtual void slash()
        {
            Console.WriteLine("Slash...");
        }
    }
}
