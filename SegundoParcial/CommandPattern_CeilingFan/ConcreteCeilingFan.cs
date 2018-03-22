using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    class ConcreteCeilingFan:Command
    {
        public ConcreteCeilingFan(Fridge refri, Lights luces, CeilingFan fan, int estado) : base(refri, luces, fan, estado)
        {

        }

        public override void Execute()
        {
            
            switch (state)
            {
                case 3:
                    Console.WriteLine("Is already in high speed");
                    break;
                case 2:
                    Console.WriteLine("change to High Speed");
                    break;
                case 1:
                    Console.WriteLine("change to medium speed");
                    break;
                case 0:
                    Console.WriteLine("change to low speed");
                    break;
            }

           
        }
        public override void Undo()
        {
            switch (state)
            {
                case 3:
                    Console.WriteLine("Change to medium speed");
                    break;
                case 2:
                    Console.WriteLine("change to low speed");
                    break;
                case 1:
                    Console.WriteLine("Fan off");
                    break;
                case 0:
                    Console.WriteLine("Fan is already off");
                    break;
            }

        }
    }
}
