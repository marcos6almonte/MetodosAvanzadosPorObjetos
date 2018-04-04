using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class WolfDogAdapter:Dog
    {
        Wolf lobo = new Wolf();
        public void bark()
        {
            lobo.howl();
        }
        public void bite()
        {
            lobo.run();
        }
    }
}
