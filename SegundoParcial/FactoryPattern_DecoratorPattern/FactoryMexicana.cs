using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class FactoryMexicana:PizzaStore
    {
        public override string create(string nombrePizza)
        {
            switch (nombrePizza)
            { 
                case "mexicana":
                    AbstractPizza pizza = new Mexicana();
                    pizza = new Chorizo(pizza);
                    pizza = new Morron(pizza);
                    pizza = new Frijol(pizza);
                    pizza = new QuesoOax(pizza);
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
