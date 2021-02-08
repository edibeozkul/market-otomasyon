using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinar_bunu_demenolursun
{
   public class KrediKarti : Odeme
    {
        public string kartno { get ; private set; }
        public string cvv { get; private set; }
        public string skt { get; private set; }

        public void KartBilgileri1( string KartNo)
        {
            kartno = KartNo;
         
        }
        public void KartBilgileri2(string CVV)
        {
            cvv = CVV;
        }
        public void KartBilgileri3( string SKT){
            skt = SKT;

        }
    }
    
}
