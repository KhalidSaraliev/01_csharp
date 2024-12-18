﻿int[,] CreateMatrixRdnInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintArray(double [] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
        {
        Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write(']');
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

double[] GetAverageArrayRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = (double)sum / matrix.GetLength(1);
    }
    return array;
}

int[,] array2d = CreateMatrixRdnInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

double[] result = GetAverageArrayRows(array2d);
PrintArray(result);

