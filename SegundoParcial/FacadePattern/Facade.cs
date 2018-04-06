using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180404_FacadePattern
{
    class Facade
    {
        private Ampli amplificador;
        private CDPlayer cdplayer;
        private DVD dvd;
        private Lights luces;
        private Proyector proyector;
        private Screen pantalla;
        private Tuner tuner;

        public Facade()
        {
            amplificador = new Ampli();
            cdplayer = new CDPlayer();
            dvd = new DVD();
            luces = new Lights();
            proyector = new Proyector();
            pantalla = new Screen();
            tuner = new Tuner();
         }
        public void Musica()
        {
            cdplayer.On();
            amplificador.On();
            amplificador.On();
            amplificador.setCD();
            cdplayer.PlayCD();
        }
        public void Pelicula()
        {
            pantalla.On();
            proyector.On();
            proyector.ModoTV();
            dvd.On();
            luces.On();
            dvd.On();
            dvd.PlayCD();
            amplificador.On();
            amplificador.setDVD();
        }
       
    }
}
