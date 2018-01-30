using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180129_Practica02
{
    class tipoEmail: InterfaceIndividuo
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public int edad { get; set; }
        public string puesto { get; set; }
        public string telefono { get; set; }

        public bool validate()
        {
            if (email.Contains("@@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
