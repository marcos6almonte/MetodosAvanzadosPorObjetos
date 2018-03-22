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
            CeilingFan abanico = new CeilingFan();
            int state = 0;
            Command commandOn = new ConcreteOn(refri,luces,abanico, state);
            Command commandOff = new ConcreteOff(refri, luces, abanico, state);
            Command commandFreeze = new ConcreteFreeze(refri, luces, abanico, state);
            Command commandAdjust_Temp = new ConcreteAdjust_Temp(refri, luces, abanico, state);
            Command commandCeilingFan = new ConcreteCeilingFan(refri, luces, abanico,state);
            Invoker invoker = new Invoker();

            //macro command
            invoker.SetCommand(commandOn);
            invoker.SetCommand(commandFreeze);
            invoker.SetCommand(commandCeilingFan);
            invoker.ExecuteCommand(2);
            invoker.UndoCommand();
           
            Console.ReadLine();
        }
    }
}
