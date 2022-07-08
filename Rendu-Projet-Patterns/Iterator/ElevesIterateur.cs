using System.Collections;

namespace IteratorPattern
{
    class ElevesIterateur : IEnumerable
    {
        private int _count = 0;
        private ArrayList _eleves;

        public ElevesIterateur(ArrayList eleves)
        {
            _eleves = eleves;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new ElevesEnum(_eleves);
        }
    }
}
