using Indexer;

BaseClass baseClass = new BaseClass(9);
for (int i = 0; i < 9; i++)
{
    Console.WriteLine(baseClass[i]);
}

DerivedClass derivedClass = new DerivedClass(15);
Console.WriteLine();

for (int i = 0; i < 15; ++i)
{
    Console.WriteLine(derivedClass[i]);
}

MatrixArray matrix = new MatrixArray(5,5);
matrix[1, 1] = 58;
Console.WriteLine(matrix[1, 1]);
Console.WriteLine(matrix[0, 0]);
