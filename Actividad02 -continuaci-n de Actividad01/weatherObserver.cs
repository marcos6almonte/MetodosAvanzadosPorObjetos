using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180207_Actividad2
{
    interface weatherObserver
    {
        void update(Subject data,object objeto);
    }
}
