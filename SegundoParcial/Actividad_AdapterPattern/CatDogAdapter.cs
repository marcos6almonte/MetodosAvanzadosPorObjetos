using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class CatDogAdapter:Dog
    {
        Cat gato = new Cat();

        public void bark()
        {
            gato.purk();
        }
        public void bite()
        {
            gato.slash();
        }
    }
}
