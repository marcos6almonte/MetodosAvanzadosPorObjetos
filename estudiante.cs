using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    class estudiante : persona
    {
        private int matricula { get; set; }
        private string carrera { get; set; }
        private string nombre { get; set; }
        private int edad { get; set; }
        private bool genero { get; set; }
        HabilidadMotrizManos motrizm = new HabilidadMotrizManos();
        HabilidadMotrizPies motrizp = new HabilidadMotrizPies();

        public estudiante(int pmatricula, string pcarrera, string pnombre, int pedad, bool pgenero) : base(pnombre, pedad, pgenero)
        {
            this.nombre = pnombre;
            this.edad = pedad;
            this.genero = pgenero;
            this.matricula = pmatricula;
            this.carrera = pcarrera;
           
        }
        public override string hablar()
        {
            string frase = base.hablar();
            frase += ": Soy estudiante de Cetys en " + carrera + " y tengo " + edad;
            return frase;
        }
        public override string Comportamiento()
        {
            string ok = base.Comportamiento();
            ok += motrizm.mover() + " y " + motrizp.mover();
            return ok;
        }


    }
}
