using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinar_bunu_demenolursun
{
    public class Cek : Odeme
    {
        public string isim { get; private set; }
        public string bankid { get; private set; }

        public void CekBilgiler1( string Isım)
        {
            isim = Isım;
        }
        public void CekBilgiler2(string Bankid)
        {
            bankid = Bankid;
        }
    }
}
