using System;
using System.Collections;

namespace IteratorPattern
{
    public class EtudiantInformationEnum : IEnumerator
    {
        private readonly Information[] _eleves;
        private int _position = -1;
        public EtudiantInformationEnum(Information[] eleves)
        {
            _eleves = eleves;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _eleves.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        object IEnumerator.Current => Current;

        public Information Current
        {
            get
            {
                try
                {
                    return _eleves[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}