using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class FactoryItaliana:PizzaStore
    {
        public override Pizza create(string nombrePizza)
        {
            switch (nombrePizza)
            {

                case "italiana":
                    return new Italiana();


            }
            return new Normal();
        }
    }
}
