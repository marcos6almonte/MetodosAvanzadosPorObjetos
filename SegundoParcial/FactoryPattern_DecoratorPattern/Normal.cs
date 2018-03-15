using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Normal : AbstractPizza
    {
        private string nombre = "Pizza Pepperoni";
     
        public override string getDescripcion()
        {
            return nombre;
        }



    }
}
