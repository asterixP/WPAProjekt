using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPA.Factory
{
    class OsobaPrototype
    {
        public int wiek;
        public DateTime Dataurodzenia;
        public string Imie;
        public IdInfoprototype IdInfo;

        public OsobaPrototype lekkakopia()
        {
            return (OsobaPrototype)this.MemberwiseClone();
        }

        public OsobaPrototype glebokakopia()
        {
            OsobaPrototype clone = (OsobaPrototype)this.MemberwiseClone();
            clone.IdInfo = new IdInfoprototype(IdInfo.IdNumber);
            return clone;
        }
    }
}
