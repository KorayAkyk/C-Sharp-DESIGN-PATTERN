using System.Collections;

namespace IteratorPattern
{
    class EtudiantInformationIterateur : IEnumerable
    {
        private int _count = 0;
        private Information[] _eleves;

        public EtudiantInformationIterateur(Information[] eleves)
        {
            _eleves = eleves;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new EtudiantInformationEnum(_eleves);
        }
    }
}
