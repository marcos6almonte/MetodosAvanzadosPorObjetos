using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_020905
{
    abstract class Command
    {
        protected Robot1 robot1;
        protected Robot2 robot2;
        protected Robot3 robot3;
        protected string[] logList= new string[20];
        protected int n;

        public Command(Robot1 rr1, Robot2 rr2, Robot3 rr3)
        {
            this.robot1 = rr1;
            this.robot2= rr2;
            this.robot3= rr3;
        }

        public abstract void Execute();
        public abstract void log();
        public abstract void printLog();

    }
}
