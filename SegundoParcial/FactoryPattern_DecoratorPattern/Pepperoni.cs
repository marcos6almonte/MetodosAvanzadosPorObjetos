using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Pepperoni:Ingredientes
    {
        public Pepperoni(AbstractPizza pizza): base(pizza)
        {
            this.name = "Pepperoni";
        }
    }
}
