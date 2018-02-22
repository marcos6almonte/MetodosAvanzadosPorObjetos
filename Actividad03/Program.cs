using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad03
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida drink = new Cafe();
            drink.size = "grande";
            drink = new Azucar(drink);
            drink.Cost(1);
            drink.getDescripcion("");

            Bebida bebida = new Cafe();
            bebida.size = "muy grande";
            bebida = new Canela(bebida);
            bebida.Cost(1);
            bebida.getDescripcion("");

            Bebida drink_ = new Cafe();
            drink_.size = "chico";
            drink_ = new Crema(drink_);
            drink_.Cost(1);
            drink_.getDescripcion("");
            Console.ReadLine();
        }
    }
}
