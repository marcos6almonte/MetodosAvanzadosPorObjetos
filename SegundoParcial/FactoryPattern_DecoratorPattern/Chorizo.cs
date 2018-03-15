using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Chorizo:Ingredientes
    {
        public Chorizo(AbstractPizza pizza): base(pizza)
        {
            this.name = "Chorizo";
        }
    }
}
