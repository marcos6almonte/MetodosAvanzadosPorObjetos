using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Ampli
    {
        public void On()
        {
            Console.WriteLine("Prendiendo Amplificador");
        }

        public void Off()
        {
            Console.WriteLine("Apagando el Amplificador");
        }

        public void setCD()
        {
            Console.WriteLine("Emparejando Amplificador con CDPlayer");
        }

        public void setDVD()
        {
            Console.WriteLine("Emparejando Amplificador con DVD");
        }
    }
}
