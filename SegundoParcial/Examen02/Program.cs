using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_020905
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot1 robot1 = new Robot1();
            Robot2 robot2 = new Robot2();
            Robot3 robot3 = new Robot3();

            Command commandTarea1 = new ConcreteTarea1(robot1,robot2, robot3);
            Command commandTarea2 = new ConcreteTarea2(robot1, robot2, robot3);
            Command commandTarea3 = new ConcreteTarea3(robot1, robot2, robot3);
            Command commandTarea4 = new ConcreteTarea4(robot1, robot2, robot3);
            Invoker invoker = new Invoker();

            invoker.SetCommand(commandTarea1);
            invoker.ExecuteCommand();
            invoker.logCommand();
            invoker.SetCommand(commandTarea2);
            invoker.ExecuteCommand();
            invoker.logCommand();
            invoker.SetCommand(commandTarea3);
            invoker.ExecuteCommand();
            invoker.logCommand();
            invoker.SetCommand(commandTarea4);
            invoker.ExecuteCommand();
            invoker.logCommand();
            invoker.PrintLog();

            Console.ReadLine();

        }
    }
}
