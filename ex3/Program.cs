/* Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj

Две матрицы можно перемножить между собой тогда и только тогда, 
когда количество столбцов первой матрицы равно количеству строк второй матрицы.
*/

int[,] InitMatrix(int x, int y)
{
    Random rnd = new Random();
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ResultMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    //cij = ai1 · b1j + ai2 · b2j + ... + ain · bnj
    {
    for (int i=0;i<firstMatrix.GetLength(0);i++)
    {
        for(int j=0; j<secondMatrix.GetLength(1);j++)
        {
    for (int k=0; k<firstMatrix.GetLength(1); k++)
    {
        result[i,j]+=(firstMatrix[i,k]*secondMatrix[k,j]);
    }
    }
    }
    return result;
    }
}
Random rnd = new Random();
int x = rnd.Next(2,5);
int y = rnd.Next(2,6);
int[,] firstMatrix = InitMatrix(x, y);
x=rnd.Next(2,5);
int[,] secondMatrix = InitMatrix(y, x);
PrintMatrix(firstMatrix, "Первая матрица:");
PrintMatrix(secondMatrix, "Вторая матрица:");
int[,] resultMatrix = ResultMatrix(firstMatrix, secondMatrix);
PrintMatrix(resultMatrix, "Произведение матриц:");


