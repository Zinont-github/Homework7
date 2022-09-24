// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[5, 5];
// FillArray(array);
double temp = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[j, i] = new Random().Next(1, 10);
        temp += array[j,i];
    }
    Console.Write(temp / array.GetLength(0) + "; ");
    temp = 0;
}
Console.WriteLine();
PrintArray(array);

// void FillArray(int[,] arr)
// {
    // for (int i = 0; i < arr.GetLength(0); i++)
    // {
        // for (int j = 0; j < arr.GetLength(1); j++)
        // {
            // arr[i, j] = new Random().Next(1, 10);
        // }
    // }
// }


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}