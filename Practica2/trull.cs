using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180124_Practica2
{
    class trull: character
    {
        axeBehaviour aB = new axeBehaviour();
        public trull(Weapon arma)
        {
            aB.useWeapon();
        }

        public override string fight()
        {
            string ok = base.fight();
            ok += aB.useWeapon();
            return ok;
        }

    }
}
