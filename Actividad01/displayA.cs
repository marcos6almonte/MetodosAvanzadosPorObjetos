using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_Actividad01
{
    class displayA: weatherObserver
    {
        
        private string nombre;


        public displayA(string type)
        {
            this.nombre = type;
        }

        public void update(Subject datos)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2}", nombre, datos.Tipo, datos.Cantidad);
        }

        
    }
}
