using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläin_tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Periytä luokasta, jonka ideoit "Luokat ja oliot" -tehtävässä, jokin alaluokka. Jos et keksi mitään järkevää, keksi uusi luokka ja periytä siitä uusi luokka.
            //Lisää uudelle periytetylle alaluokalle yksi uusi attribuutti ja metodi.
            //Kapseloi luokat, eli mieti näkyvyydet järkeviksi (ts. vain tarpeellisimmat attribuutit tai metodit näkyvät).
            //Tee jollekin attribuutille getter ja/tai setter. Käytä niitä attribuutin tietojen tulostamiseen tai muuttamiseen.

            Koira koira1 = new Koira("Saksanpaimenkoira", 40);
            Console.WriteLine(koira1);

            Valkoinenpaimenkoira vp = new Valkoinenpaimenkoira();
            vp.tulostaTiedot("Valkoinenpaimenkoira", 35, "valkoinen");
            Console.WriteLine(vp);
            Console.Write("Ruokitaanko koira? k/e: ");
            Console.WriteLine();
            char x = Console.ReadKey().KeyChar;
            if (x == 'k')
            {
                vp.RuokiKoira();
                Console.WriteLine("Koira lihoi kilon");
                Console.WriteLine(vp);
            }
            if (x == 'e')
            {
                Console.WriteLine("Koiran paino pysyy samanana");
            }
           
            Console.ReadKey();
        }
    }
}
