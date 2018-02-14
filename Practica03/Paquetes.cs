using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_Practica03
{
    class Paquetes
    {

        string id;
        
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                generateID();
                if (value!="000000000")
                {
                    id = value;
                }
            }
        }

        public string generateID()
        {
            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
            return number;
        }


    }
}
