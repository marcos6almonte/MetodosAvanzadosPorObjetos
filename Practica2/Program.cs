using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180124_Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            knight knight = new knight(Weapon.knife);
            trull trull = new trull(Weapon.axe);
            queen queen = new queen(Weapon.arrow);
            king king = new king(Weapon.knife);


            Console.WriteLine();
            Console.WriteLine("Knigth "+ knight.fight());
           
            Console.WriteLine();
            Console.WriteLine("Queen " + queen.fight());

            Console.WriteLine();
            Console.WriteLine("King " + king.fight());

            Console.WriteLine();
            Console.WriteLine("Trull " + trull.fight());
            
            Console.ReadLine();

        }
    }
}
