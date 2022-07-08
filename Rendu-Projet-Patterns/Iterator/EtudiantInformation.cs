using System;
using System.Collections;

namespace IteratorPattern
{
    public class EtudiantInformation
    {
        private const int Max = 1;

        private int _count;
        private Information[] _eleves;

        public IEnumerable Eleves
        {
            get
            {
                return new EtudiantInformationIterateur(_eleves);
            }
        }

        public EtudiantInformation()
        {
            _eleves = new Information[Max];

            AjouterEtudiant("Koray", "Fais de son mieux", 14, true);

        }

        private void AjouterEtudiant(string nom, string remarques, int moyenne, bool encouragement)
        {
            var eleve = new Information(nom, remarques, moyenne, encouragement);

            if (_count <= Max)
            {
                _eleves[_count] = eleve;
                _count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}