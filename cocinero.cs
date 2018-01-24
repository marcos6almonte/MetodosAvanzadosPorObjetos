using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    class cocinero : persona
    {
        private string especialidad { get; set; }
        private string puesto { get; set; }
        private string nombre { get; set; }
        private int edad { get; set; }
        private bool genero { get; set; }
        HabilidadMotrizManos motrizm = new HabilidadMotrizManos();
        HabilidadMotrizPies motrizp = new HabilidadMotrizPies();

        public cocinero(string pnombre, int pedad, bool pgenero, string pespecialidad, string ppuesto) : base(pnombre, pedad, pgenero)
        {
            this.nombre = pnombre;
            this.edad = pedad;
            this.genero = pgenero;
            this.especialidad = pespecialidad;
            this.puesto = ppuesto;
  
        }
        public override string hablar()
        {
            string frase = base.hablar();
            frase += ": Soy cocinero especializado en " + especialidad + " y tengo " + edad;
            return frase;
        }

        public override string Comportamiento()
        {
            string ok= base.Comportamiento();
            ok += motrizm.mover() +" y "+ motrizp.mover();
            return ok;
        }



    }
}
