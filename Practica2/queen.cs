using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180124_Practica2
{
    class queen: character
    {
        Weapon weapon;

        public queen(Weapon arma)
        {
            this.weapon = arma;
            setWeapon(arma);

        }

        public override string fight()
        {
            string ok = base.fight();
            ok += weapon;
            return ok;
        }
    }
}
