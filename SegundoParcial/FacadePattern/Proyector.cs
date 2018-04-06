using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Proyector
    {
        public void On()
        {
            Console.WriteLine("Proyector Encendido");
        }

        public void Off()
        {
            Console.WriteLine("Proyector Apagado");
        }

        public void ModoTV()
        {
            Console.WriteLine("Modo TV");
        }

        public void PantallaCOmpleta()
        {
            Console.WriteLine("Proyector Pantalla Completa");
        }
    }
}
