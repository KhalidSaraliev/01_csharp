﻿Console.Write("Введите первое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    int result = num1 % num2;
    Console.WriteLine($"нет,{result} ");
}