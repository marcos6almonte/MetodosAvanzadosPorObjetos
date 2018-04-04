using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class Adapter:Dog
    {
        private Cat gato = new Cat();

        public override void bark()
        {
            gato.purk();
        }
        public override void bite()
        {
            gato.slash();
        }
    }
}
