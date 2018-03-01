using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_20905
{
    class Banco
    {
        public string origen { get; set; }
        public string destino { get; set; }
        public int monto { get; set; }
        public DateTime fecha { get; set; }


        public virtual string setFormat()
        {
            return "Envio este monto $50000 de Santander a BBVA hoy 28/02/2018 10:00:00 AMT"; 
        }

    }
}
