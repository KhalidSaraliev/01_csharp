Console.Write("Введите целое трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstdigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstdigit * 10 + thirdDigit;
    Console.WriteLine ($"Первая и вторая цыфра введенного числа {result} ");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}