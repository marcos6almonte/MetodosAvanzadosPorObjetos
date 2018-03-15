using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Mexicana : AbstractPizza
    {
        private string nombre = "Pizza Mexicana";

        public override string getDescripcion()
        {
            return nombre;
        }


    }
}
