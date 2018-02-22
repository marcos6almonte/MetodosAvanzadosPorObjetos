using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03
{
    //concrete component
    class Cerveza:Bebida
    {
        private int costo=25;
        private int total;
        //public string size { get; set; }

        public Cerveza()
        {

        }
        public override void getDescripcion(string sabor)
        {
            Console.WriteLine("Tu bebida es tamaño: " + size + " y los ingredientes son: " + sabor);
        }

        public override void Cost(int precio)
        {
            total = costo + precio;
            Console.WriteLine("\nTu bebida costo:" + total);
        }
    }
}
