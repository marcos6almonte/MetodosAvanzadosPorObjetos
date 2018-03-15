using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class FactoryFregona : PizzaStore
    {
        public override string create(string nombrePizza)
        {
            switch (nombrePizza)
            {
                case "fregona":
                    AbstractPizza pizza = new Fregona();
                    pizza = new Salchicha(pizza);
                    pizza = new Tocino(pizza);
                    pizza = new Pepperoni(pizza);
                    Detalles(pizza);
                    return pizza.getDescripcion();
            }
            return "Pizza Normal de Pepperoni";
        }
        private static void Detalles(AbstractPizza product)
        {
            Console.WriteLine(); // some whitespace for readability
            Console.WriteLine("Pizza: {0}", product.getDescripcion());
        }
    }
}
