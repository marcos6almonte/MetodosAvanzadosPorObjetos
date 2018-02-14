using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180213_Practica03
{
    abstract class Subject
    {
        string tipo;
        string id;

        List<ClienteObserver> clientes = new List<ClienteObserver>();
        
       public Subject(string symbol)
        {
            this.tipo = symbol;
        }

        public void register(ClienteObserver cliente)
        {
            clientes.Add(cliente);
        }

        public void remove(ClienteObserver cliente)
        {
            clientes.Remove(cliente);
        }

        public void Notify()
        {
            foreach (ClienteObserver cliente in clientes)
            {
                cliente.update(this);
            }

            Console.WriteLine("");
        }

       
        public string Id
        {
            get { return id; }
            set

            {
                if (id != value)
                {
                    id = value;
                    Notify();
                }
            }
        }

        public string Tipo
        {
            get { return tipo; }
        }

    }
}

