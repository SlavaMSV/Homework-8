/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] InitContur()  //метод для определения контура массива
{
    int i = 0;
    int j = 0;
    int[,] array = new int[10, 10];
    array[0, 0] = 1;
    for (j = 1; j < array.GetLength(1); j++)
    {
        array[i, j] = array[i, j - 1] + 1;
    }
    j = array.GetLength(1) - 1;
    for (i = 1; i < array.GetLength(0); i++)
    {
        array[i, j] = array[i - 1, j] + 1;
    }
    i = array.GetLength(0) - 1;
    for (j = array.GetLength(1) - 2; j > -1; j--)
    {
        array[i, j] = array[i, j + 1] + 1;
    }
    j = 0;
    for (i = array.GetLength(0) - 2; i > 0; i--)
    {
        array[i, j] = array[i + 1, j] + 1;
    }
    return array;
}


int[,] FillArray(int[,] contur) // метод для спирального заполнения внутри контура массива
{
    int raw = 1, col = 1;
    while (contur[raw, col] == 0)
    {
        while (contur[raw, col] == 0)
        {
            contur[raw, col] = contur[raw, col - 1] + 1;
            col++;
        }
        raw++;
        col--;
        while (contur[raw, col] == 0)
        {
            contur[raw, col] = contur[raw - 1, col] + 1;
            raw++;
        }
        raw--;
        col--;
        while (contur[raw, col] == 0)
        {
            contur[raw, col] = contur[raw, col + 1] + 1;
            col--;
        }
        raw--;
        col++;
        while (contur[raw, col] == 0)
        {
            contur[raw, col] = contur[raw + 1, col] + 1;
            raw--;
        }
        raw++;
        col++;
    }
    return contur;
}

void PrintMatrix(int[,] contur)
{
    Console.WriteLine("Спиральный массив:");
    for (int i = 0; i < contur.GetLength(0); i++)
    {
        for (int j = 0; j < contur.GetLength(1); j++)
        {
            Console.Write($"{contur[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] contur = InitContur();
int[,] spiralMatrix = FillArray(contur);
PrintMatrix(spiralMatrix);


