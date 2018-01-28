using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180124_Practica2
{
    class king: character
    {
        knifeBehaviour kB = new knifeBehaviour();

        public king(Weapon arma)
        {
            kB.useWeapon();
        }

        public override string fight()
        {
            string ok = base.fight();
            ok += kB.useWeapon();
            return ok;
        }

    }
}
