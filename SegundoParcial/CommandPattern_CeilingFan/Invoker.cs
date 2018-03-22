using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    //Invoker
    class Invoker
    {
        Command[] comandos = new Command[8];
        public int n, indice = 0;

        public void SetCommand(Command command)
        {
            comandos[indice] = command;
            indice++;
        }

        public void ExecuteCommand(int n)
        {
            this.n = n;
            for (int i=0;i<=n;i++)
            {
                Console.WriteLine("Execute mode");
                comandos[i].Execute();
            }
            

        }
        public void UndoCommand()
        {
            Console.WriteLine("Undo command");
            comandos[n].Undo();
        }
    }
}
