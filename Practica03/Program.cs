using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_Practica03
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquetes pack = new Paquetes();

            Proveedor dhl = new Proveedor("DHL");
            dhl.register(new DHL("Alex Rodriguez"));
            dhl.Id = pack.generateID();

            Proveedor fedex = new Proveedor("FEDEX");
            fedex.register(new FEDEX("Sammy Sosa"));
            fedex.register(new FEDEX("Mike Moustakas"));
            fedex.Id = pack.generateID();

            Proveedor cm = new Proveedor("Correos de México");
            cm.register(new CM("Adam Jones"));
            cm.Id=pack.generateID();

            Console.ReadLine();
        }
    }
}
