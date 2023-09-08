
namespace Indexer
{
    public class DerivedClass : BaseClass
    {
        private string[] _derivedArray;
        public DerivedClass(int count):base(count)
        {
            if(count <= 0)
            {
                count = 3;
            }
            this._derivedArray = new string[count];
            GenerateArray(count);
        }

        public override string this[int index] => base[index] + _derivedArray[index];

    }
}
