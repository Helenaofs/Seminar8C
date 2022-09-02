//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;

Console.WriteLine("Введите количество строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int column = int.Parse(Console.ReadLine());
int[,] numbers = new int[row, column];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int x = 0; x < massive.GetLength(1) - 1; x++)
            {
                if (massive[i, x] < massive[i, x + 1])
                {
                    int temp = massive[i, x + 1];
                    massive[i, x + 1] = massive[i, x];
                    massive[i, x] = temp;
                }
            }
        }

    }
}

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Массив, где элементы каждой строки упорядочены по убыванию:");
SortArray(numbers);
PrintArray(numbers);
