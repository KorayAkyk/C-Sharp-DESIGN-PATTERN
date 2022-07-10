using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class InstrumentCorde : Orchestre
    {
        public TypeCorde ajouterCorde(string instrument) => new Guitare(instrument);

        public TypeVent ajouterVent(string instrument) => new Clarinette(instrument);
    }
}
