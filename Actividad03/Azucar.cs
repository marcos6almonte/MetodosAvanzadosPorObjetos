using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03
{
    //concrete decorator
    class Azucar : Ingredientes
    {
        Bebida drink;
        string sabor = "Azucar";
       
        public Azucar(Bebida bebida) : base(bebida)
        {
            this.drink = bebida;
        }
        public override void getDescripcion(string flavor)
        {
            base.getDescripcion(sabor);
        }
        
        public override void Cost(int precio)
        {
            base.Cost(5);
        }
    }
}

