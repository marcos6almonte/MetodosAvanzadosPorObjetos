using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Morron:Ingredientes
    {
        public Morron(AbstractPizza pizza): base(pizza)
        {
            this.name = "Chile Morron";
        }
    }
}
