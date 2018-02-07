using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_Actividad01
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherData displaya = new weatherData("Display A",26);
            displaya.register(new displayA("Temperatura"));
            displaya.Cantidad=28;

            weatherData displayb = new weatherData("Display B", 22);
            displayb.register(new displayB("Humedad"));
            displayb.Cantidad = 24;

            weatherData displayc = new weatherData("Display C", 1022);
            displayc.register(new displayC("Presión"));
            displayc.Cantidad = 1021;



            Console.ReadLine();

        }
    }
}
