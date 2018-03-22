using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    //Command
    abstract class Command
    {
        protected Fridge fridge;
        protected Lights lights;

        public Command(Fridge refri, Lights luces)
        {
            this.fridge = refri;
            this.lights = luces;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
