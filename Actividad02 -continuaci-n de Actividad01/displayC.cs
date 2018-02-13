using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180207_Actividad2
{
    class displayC:weatherObserver
    {
        private string nombre;
        private weatherData data;


        public displayC(string type)
        {
            this.nombre = type;
        }

        public void update(Subject datos, object objeto)
        {
            if (datos.GetType() == typeof(weatherData))
            {

                weatherData weather = new weatherData(datos.Tipo, datos.Cantidad);
                Console.WriteLine("Confirmado " + weather.Tipo + " " + nombre + ": " + weather.Cantidad);
            }
        }
        public weatherData weatherData
        {
            get { return data; }
            set { data = value; }
        }
    }
}
