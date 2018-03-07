using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    class handicap : persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private bool genero { get; set; }
        HabilidadMotrizNula motriz = new HabilidadMotrizNula();

        public handicap(string pnombre, int pedad, bool pgenero) : base(pnombre, pedad, pgenero)
        {
            this.nombre = pnombre;
            this.edad = pedad;
            this.genero = pgenero;
        }

        public override string hablar()
        {
            string frase = base.hablar();
            frase += ": Soy el handicap y tengo " + edad;
            return frase;
        }
        public override string Comportamiento()
        {
            string ok = base.Comportamiento();
            ok += motriz.mover();
            return ok;
        }
    }
}
