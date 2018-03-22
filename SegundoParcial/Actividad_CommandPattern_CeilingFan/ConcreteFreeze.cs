using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    class ConcreteFreeze: Command
    {
        public ConcreteFreeze(Fridge fridge, Lights lights, CeilingFan fan, int state) : base(fridge, lights, fan, state)
        {

        }

        public override void Execute()
        {
            fridge.freeze();
        }
        public override void Undo()
        {
            fridge.unfreeze();
        }

    }
}
