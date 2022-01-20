using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    class TransakcjaWytworcza
    {
       public static AbsDecorator StworzTransakcja()
        {
            return new Transakcja();
        }
    }
}
