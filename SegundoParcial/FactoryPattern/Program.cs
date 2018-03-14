using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180314_FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore PS = new FactoryMexicana();
            Pizza nuevaPizza=PS.create("mexicana");
            Console.WriteLine(nuevaPizza.GetType().Name);
            Console.WriteLine(nuevaPizza.empacar());
            Console.WriteLine(nuevaPizza.enviar());
            Console.WriteLine("\n\n");
            PizzaStore ps = new FactoryFregona();
            Pizza nuevaPizza2 = ps.create("fregona");
            Console.WriteLine(nuevaPizza2.GetType().Name);
            Console.WriteLine(nuevaPizza2.empacar());
            Console.WriteLine(nuevaPizza2.enviar());
            Console.ReadLine();
        }
    }
}
