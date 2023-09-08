

using System;

namespace Indexer
{
    public class BaseClass
    {
        private string[] _baseArray;
        private Random _random;

        public string[] BaseArray
        {
            get => _baseArray;
        }

        public BaseClass(int count) 
        {
            this._random = new Random();
            if(count < 0)
            {
                count = 3;
            }

            this._baseArray = new string[count];
            GenerateArray(count);
        }


        protected void GenerateArray(int count)
        {
            for(int i = 0; i < count; ++i)
            {
                _baseArray[i] = $"{i} {(char)_random.Next(32, 127)}";
            }
        }

        public virtual string this[int index]
        {
            get { return _baseArray[index]; }
        }

    }
}
