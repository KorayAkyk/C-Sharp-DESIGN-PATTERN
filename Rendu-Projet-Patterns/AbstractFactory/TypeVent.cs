using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class TypeVent
    {
        public string Instrument { get; set; }
        public TypeVent(string instrument) => this.Instrument = instrument;

        public abstract void afficherInstrument();
    }
}
