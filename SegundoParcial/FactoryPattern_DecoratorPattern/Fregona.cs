﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Fregona: AbstractPizza
    {
        private string nombre = "Pizza Fregona";

        public override string getDescripcion()
        {
            return nombre;
        }

    }
}
