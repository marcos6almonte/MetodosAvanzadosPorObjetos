using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    public abstract class Ingredientes : AbstractPizza
    {
        AbstractPizza pizza;

        protected string name = "Undefined Decorator";
        protected double price = 0.0;

        protected Ingredientes(AbstractPizza pissa)
        {
            pizza = pissa;
        }

        public override string getDescripcion()
        {
            return string.Format("{0}, {1}", pizza.getDescripcion(), name);
        }

    }
}
