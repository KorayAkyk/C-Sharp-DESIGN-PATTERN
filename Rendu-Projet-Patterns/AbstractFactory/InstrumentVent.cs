using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class InstrumentVent : Orchestre
    {
        public TypeCorde ajouterCorde(string instrument) => new Saz(instrument);

        public TypeVent ajouterVent(string instrument) => new Saxophone(instrument);
    }
}
