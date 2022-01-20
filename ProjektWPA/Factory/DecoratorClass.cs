using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    abstract class DecoratorClass : AbsDecorator
    {
        AbsDecorator Transakcja;
        public override int setwartosc()
        {
            return Transakcja.setwartosc();
        }
        public DecoratorClass(AbsDecorator nowaTransakcja)
        {
            Transakcja = nowaTransakcja;
        }
    }
}
