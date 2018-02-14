using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _180213_Practica03
{
    class DHL:ClienteObserver
    {
        string nombre;
        Subject subject;

        public DHL(string name)
        {
            this.nombre = name;
        }

        public void update(Subject sub)
        {
            tiempo();
            Console.WriteLine("Notificado {0} que {1} " + "agrego paquete {2}", nombre, sub.Tipo, sub.Id);

        }

        public void tiempo()
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);

        }
        public void TimerCallback(Object o)
        {
            Console.WriteLine("DHL notificando a cliente: " + nombre);

        }
       



        public Subject Subject
            {
                get { return subject; }
                set { subject = value; }
            }
    }
}
