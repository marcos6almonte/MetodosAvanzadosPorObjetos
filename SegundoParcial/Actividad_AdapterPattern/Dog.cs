using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class Dog
    {
        public virtual void bark()
        {
            Console.WriteLine("Bark...");
        }
        public virtual void bite()
        {
            Console.WriteLine("Bite...");
        }
    }
}
