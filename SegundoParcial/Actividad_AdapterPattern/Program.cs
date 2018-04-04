using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180403_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog perro = new CatDogAdapter();
            perro.bark();
            perro.bite();

            Dog perrito = new WolfDogAdapter();
            perrito.bark();
            perrito.bite();

            Console.ReadLine();
        }
    }
}
