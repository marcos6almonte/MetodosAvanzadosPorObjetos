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
        protected CeilingFan fan;
        protected int state;


        public Command(Fridge refri, Lights luces, CeilingFan abanico, int estado)
        {
            this.fridge = refri;
            this.lights = luces;
            this.fan = abanico;
            this.state = estado;
        }

        public abstract void Execute();
        public abstract void Undo();
    }
}
