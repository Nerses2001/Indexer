
namespace Indexer
{
    public class MatrixArray
    {
        private int[,] _matrix;
        public MatrixArray(int row, int col)
        {
            this._matrix = new int[row, col];
        }

        public int this[int indexOne, int indexTwo]
        {
            get => this._matrix[indexOne, indexTwo]; 
            set => this._matrix[indexOne, indexTwo] = value;
        }
    }
}
