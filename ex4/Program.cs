/* 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] InitThreeDArray()
{
    int[,,] array = new int[2, 2, 2];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintThreeDArray(int[,,] threeDarray)
{
    Console.WriteLine("Построчный вывод 3Д массива:");
    for (int k = 0; k < threeDarray.GetLength(2); k++)
    {
        for (int i = 0; i < threeDarray.GetLength(0); i++)
        {
            for (int j = 0; j < threeDarray.GetLength(1); j++)
            {
                Console.Write($"{threeDarray[i, j, k]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

int[,,] threeDarray = InitThreeDArray();
PrintThreeDArray(threeDarray);