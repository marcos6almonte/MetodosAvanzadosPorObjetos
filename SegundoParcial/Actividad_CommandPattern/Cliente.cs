using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    class Cliente
    {
        static void Main(string[] args)
        {
            Fridge refri = new Fridge();
            Lights luces = new Lights();
            Command commandOn = new ConcreteOn(refri,luces);
            Command commandOff = new ConcreteOff(refri, luces);
            Command commandFreeze = new ConcreteFreeze(refri, luces);
            Command commandAdjust_Temp = new ConcreteAdjust_Temp(refri, luces);
            Invoker invoker = new Invoker();

            invoker.SetCommand(commandOn);
            invoker.ExecuteCommand();
            Console.ReadLine();
        }
    }
}
