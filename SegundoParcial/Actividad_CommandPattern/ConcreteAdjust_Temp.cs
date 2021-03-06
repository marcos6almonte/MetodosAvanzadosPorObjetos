﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180320_Actividad_Command
{
    class ConcreteAdjust_Temp: Command
    {
        public ConcreteAdjust_Temp(Fridge fridge, Lights lights) : base(fridge, lights)
        {

        }

        public override void Execute()
        {
            fridge.adjust_temp();
        }
        public override void Undo()
        {
            fridge.loose_temp();
        }
    }
}
