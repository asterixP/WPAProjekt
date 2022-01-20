using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    class Transakcja : AbsDecorator
    {
        private int wartosc;
        public int getwartosc()
        {
            return wartosc;
        }
        public override int setwartosc()
        {
            return 0;
        }
    }
}
