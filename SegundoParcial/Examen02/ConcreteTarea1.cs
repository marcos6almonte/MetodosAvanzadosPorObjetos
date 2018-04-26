using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_020905
{
    class ConcreteTarea1 : Command
    {
        public ConcreteTarea1(Robot1 rr1, Robot2 rr2, Robot3 rr3) : base(rr1, rr2, rr3)
        {

        }
        public override void Execute()
        {
            robot1.bañarGato();
        }
        public override void log()
        {
            string fecha = DateTime.Today.ToString();
            logList[n] = "Robot1" + "bañar gato: " + fecha;
            n++;
        }
        public override void printLog()
        {
            foreach (var item in logList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
