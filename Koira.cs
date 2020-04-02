using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläin_tehtävä5
{
    class Koira
    {
        protected string rotu;
        protected int paino=0;

        public Koira()
        {
        }

        public Koira(string rotu, int paino)
        {
            this.rotu = rotu;
            this.paino = paino;
        }
        public bool RuokiKoira()
        {
            paino++;
            {
                return true;
            }
        }

        public override string ToString()
        {
            return "Rotu: " + this.rotu + " Paino: " + this.paino;
        }

        
    }
}
