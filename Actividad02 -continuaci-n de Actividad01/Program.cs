using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180207_Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherData da = new weatherData("Display A", 26);
            da.register(new displayA("Temperatura"));
            da.Cantidad = 28;

            weatherData displayb = new weatherData("Display B", 22);
            displayb.register(new displayB("Humedad"));
            displayb.Cantidad = 22;

            weatherData displayc = new weatherData("Display C", 1022);
            displayc.register(new displayC("Presión"));
            displayc.Cantidad = 1021;

            

            Console.ReadLine();

        }
    }
}
