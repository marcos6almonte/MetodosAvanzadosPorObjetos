using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    class persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private bool genero { get; set; }
        

        public persona(string nombre, int edad, bool genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public virtual string hablar()
        {
            return nombre +  ": ";
        }
        public virtual string Comportamiento()
        {
            return "Habilidad: ";
        }
       
    }
    
}
