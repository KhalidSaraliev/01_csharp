﻿//Задайте двумерный массив. найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0)(1,1))

int[,] CreateMatrixRdnInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min,max);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write('|');
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i,j]} ");
        }
        Console.WriteLine('|');
    }
}

int FindSumIndDiagonal(int[,] matrix)
{
    int sum = 0;
    // int minSize = matrix.GetLength(0);

    // if(matrix.GetLength(1) < minSize)
    // {
    //     minSize = matrix.GetLength(1);
    // }

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRdnInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

int result = FindSumIndDiagonal(array2d);
Console.Write(result);
