using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    class WyswietlanieSingleton
    {
        private string wiadomoscpowitalna;
        private static WyswietlanieSingleton instancja;
        public void ustawWiadomosc(string nowawiadomosc)
        {
            wiadomoscpowitalna = nowawiadomosc;
        }

        public string zwrocwiadomosc()
        {
            return wiadomoscpowitalna;
        }

        private WyswietlanieSingleton()
        {

        }

        public static WyswietlanieSingleton getinstance()
        {
            if (instancja == null)
            {
                instancja = new WyswietlanieSingleton();
            }
            return instancja;
        }
    }
}
