using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Console.WriteLine("Pelicula");
            facade.Pelicula();

            Console.WriteLine("\n\nMusica");
            facade.Musica();

            Console.ReadLine();
        }
    }
}
