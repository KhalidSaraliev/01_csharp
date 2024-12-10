﻿// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

void PrintNaturalNumbers(int num)
{
    if(num == 0) return;
    PrintNaturalNumbers(num-1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);