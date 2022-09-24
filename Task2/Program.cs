// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int m = ReadInt("Введите позицию элемента: ");
int a = m / 10;
int b = m % 10;
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);

if (a > array.GetLength(0) + 1 || b > array.GetLength(1) + 1)
{
    Console.Write($"{m} Такого числа в массиве нет");
}
else
{
    Console.Write($"На этой позиции стоит число >>>  {array[a, b]}");
}

// Console.WriteLine($"{a}{b}");

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}


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


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}