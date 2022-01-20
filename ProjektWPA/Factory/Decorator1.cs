using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    class Decorator1 : DecoratorClass
    {
        public Decorator1(AbsDecorator NowaTransakcja):base(NowaTransakcja)
        {

        }
        public override int setwartosc()
        {
            return (base.setwartosc()+5);
        }
    }
}
