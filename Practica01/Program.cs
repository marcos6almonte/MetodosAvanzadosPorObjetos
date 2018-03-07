using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    class Program
    {
        static void Main(string[] args)
        {
            cocinero c = new cocinero("Diego", 22, true, "comida mexicana", "sous chef");
            estudiante e = new estudiante(20900, "ICC", "Humberto", 20, true);
            handicap z = new handicap("Liciado", 48, true);

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(c.hablar());
            Console.WriteLine(c.Comportamiento());
            Console.WriteLine();


            Console.WriteLine(e.hablar());
            Console.WriteLine(e.Comportamiento());
            Console.WriteLine();

            Console.WriteLine(z.hablar());
            Console.WriteLine(z.Comportamiento());
            Console.ReadLine();
        }
    }
}
