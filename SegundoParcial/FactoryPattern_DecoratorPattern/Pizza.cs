using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
   public class Pizza
    {
        public string empacar()
        {
            return "\nTu pizza fue empaquetada.";
        }
        public string enviar()
        {
            return "\nTu pizza fue enviada.";
        }
    }
}
