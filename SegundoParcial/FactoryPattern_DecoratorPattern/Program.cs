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
            PS.create("mexicana");
            Console.WriteLine("\n\n");
            PizzaStore ps = new FactoryFregona();
            ps.create("fregona");
            Console.ReadLine();
        }
       
    }
}
