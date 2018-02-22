using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03
{
    //component
    abstract class Bebida
    {
        public string size { get; set; }

        public abstract void getDescripcion(string sabor);
        public abstract void Cost(int precio);
    }
}
