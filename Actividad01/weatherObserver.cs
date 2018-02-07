using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_Actividad01
{
    interface weatherObserver
    {
        void update(Subject data);
    }
}
