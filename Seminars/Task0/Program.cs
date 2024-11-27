//string num1str = Console.ReadLine();

Console.Write("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}