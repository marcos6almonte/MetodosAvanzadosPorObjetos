﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    class ConcreteOn:Command
    {
        public ConcreteOn(Fridge fridge, Lights lights, CeilingFan fan, int state) : base(fridge, lights, fan, state)
        {

        }

        public override void Execute()
        {
            lights.on();
        }
        public override void Undo()
        {
            lights.off();
        }

    }
}
