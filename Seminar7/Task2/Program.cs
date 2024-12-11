// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit( int num)
{
    if(num == 0) return 0;
    {
        return num % 10 + SumDigit(num / 10);
    }
}

Console.WriteLine(SumDigit(number));