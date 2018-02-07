using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180206_Actividad01
{
    abstract class Subject
    {
        string tipo;
        int cantidad;
        List<weatherObserver> wO = new List<weatherObserver>();

        public Subject(string type, int quantity)
        {
            this.tipo = type;
            this.cantidad = quantity;
        }
        public void register(weatherObserver display)
        {
            wO.Add(display);
        }
        public void notify()
        {
            foreach (weatherObserver o in wO)
            {
                o.update(this);
            }
        }
        public void remove(weatherObserver display)
        {
            wO.Remove(display);
        }
        public void measurementChanged()
        {
            notify();
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (cantidad != value)
                {
                    cantidad = value;
                    measurementChanged();
                }
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
        }
    }
}
