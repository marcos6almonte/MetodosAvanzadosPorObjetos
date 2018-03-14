using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class FactoryMexicana:PizzaStore
    {
        public override Pizza create(string nombrePizza)
        {
            switch (nombrePizza)
            { 

                case "mexicana":
                    return new Mexicana();
                    

            }
            return new Normal();
        }
    }
}
