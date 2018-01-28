using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180124_Practica2
{
    abstract class character
    {
        Weapon weapon;
        
        public void setWeapon(Weapon arma)
        {
            this.weapon = arma;
           
        }
        public virtual string fight()
        {
            return "pelea con : " ;
        }
    }
}
