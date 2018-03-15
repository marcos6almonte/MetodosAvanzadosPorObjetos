using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class QuesoOax: Ingredientes
    {
        public QuesoOax(AbstractPizza pizza): base(pizza)
        {
            this.name = "Queso Oaxaca";
        }
    }
}
