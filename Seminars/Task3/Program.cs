Console.Write("Ведите целое положительное трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num > 99 && num < 1000)
{
int firstDigit = num / 100;
int secondDigit = num % 10;

int result = firstDigit+secondDigit;
Console.WriteLine($"Сумма первой и последней цыфры трехзначного числа: {result}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}