using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläin_tehtävä5
{
    class Valkoinenpaimenkoira : Koira
    {
        private string vari;

        public Valkoinenpaimenkoira()
        {
        }

        public Valkoinenpaimenkoira(string vari)
        {
            this.vari = vari;
        }

        public string Vari
        {
            get
            {
                return vari;
            }
            set
            {
                if (vari == "valkoinen")
                {
                    vari = value;
                }
            }
        }
        public void tulostaTiedot(string rotu, int paino, string vari)
        {
            this.rotu = rotu;
            this.paino = paino;
            this.vari = vari;
        }
        public override string ToString()
        {
            return "Rotu: " + this.rotu + " Paino: " + this.paino + " Väri: " + this.vari;
        }
    }
}
