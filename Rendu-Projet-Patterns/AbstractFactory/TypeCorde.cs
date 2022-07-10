using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class TypeCorde
    {
        public string Instrument { get; set; }
        public TypeCorde(string instrument) => this.Instrument = instrument;

        public abstract void afficherInstrument();
    }
}
