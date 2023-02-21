/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] InitMatrix()
{
    int[,] array = new int[4, 4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Случайный массив целых чисел:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }
    return result;
}

void MimSumRaw(int[] rawSum)
{
    int minRaw = rawSum[0];
    int minRawIndex = 0;
    for (int i = 1; i < rawSum.Length; i++)
    {
        if (rawSum[i] < minRaw)
        {
            minRaw = rawSum[i];
            minRawIndex = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {minRawIndex} строке"); //нумерация строк начинается с 0
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
int[] rawSum = SumRow(matrix);
MimSumRaw(rawSum);
