using System;
using System.Collections;

namespace IteratorPattern
{
    public class ElevesEnum : IEnumerator
    {
        private readonly ArrayList _eleves;
        private int _position = -1;

        public ElevesEnum(ArrayList eleves)
        {
            _eleves = eleves;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _eleves.Count);
        }

        public void Reset()
        {
            _position = -1;
        }
        
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Information? Current
        {
            get
            {
                try
                {
                    return _eleves[_position] as Information;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}