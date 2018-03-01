using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_20905
{
    class BancoB:Banco
    {
        ProtocolB pb = new ProtocolB();
     

        public override string setFormat()
        {
            string ok = base.setFormat();
            ok += pb.setProtocol();
            return ok;
        }
    }
}
