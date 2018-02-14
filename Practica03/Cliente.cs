using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_Practica03
{
    class Cliente
    {
        string nombre;
        int cantidad_paquetes;

        List<Paquetes> package = new List<Paquetes>();

        public Cliente(string type, int quantity)
        {
            this.nombre = type;
            this.cantidad_paquetes = quantity;
        }

        public void attach(Paquetes pack)
        {
            package.Add(pack);
        }

        public string Nombre { get; set; }
        public int Cantidad_paquetes { get; set; }


    }
}
