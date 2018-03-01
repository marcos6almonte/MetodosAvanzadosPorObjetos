using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_20905
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoA ba = new BancoA();
            BancoB bb = new BancoB();
            BancoC bc = new BancoC();

            Console.WriteLine();
            Console.WriteLine("Banco A " + ba.setFormat());

            Console.WriteLine();
            Console.WriteLine("Banco B " + bb.setFormat());

            Console.WriteLine();
            Console.WriteLine("Banco C" + bc.setFormat());

            Console.ReadLine();
        }
    }
}
