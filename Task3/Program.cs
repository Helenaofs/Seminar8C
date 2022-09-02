// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

int[,] firstMatrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
int[,] resultMatrix = new int[2, 2];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int x = 0; x < firstMatrix.GetLength(1); x++)
            {
                sum += firstMatrix[i, x] * secondMartrix[x, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

FillArray(firstMatrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);

FillArray(secondMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);
