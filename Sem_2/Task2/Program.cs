Console.Write("Введите трехзначного положительное целое число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int secondtDigit = num / 10 % 10;
    int lastDigit = num % 10;

    int result = secondtDigit;
    int count = 1;

    while (count < lastDigit)
    {
        result = result * secondtDigit;
        count++;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректиный ввод!");
}
