using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03
{
    //Decorator
    abstract class Ingredientes:Bebida
    {
        protected Bebida bebida;

        public Ingredientes(Bebida drink)
        {
            this.bebida = drink;
        }
        public override void getDescripcion(string flavor)
        {
            bebida.getDescripcion(flavor);
        }

        public override void Cost(int precio)
        {
            bebida.Cost(precio);
        }
    }
}
