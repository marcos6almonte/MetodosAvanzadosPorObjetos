using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Italiana: AbstractPizza
    {
        private string nombre = "Pizza Italiana";

        public override string getDescripcion()
        {
            return nombre;
        }

    }
}
