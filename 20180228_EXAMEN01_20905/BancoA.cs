using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_20905
{
    class BancoA:Banco
    {
        ProtocolA pa = new ProtocolA();
        
     
        public override string setFormat()
        {
            string ok = base.setFormat();
            ok += pa.setProtocol();
            return ok;
        }
       
    }
}
