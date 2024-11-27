Console.Write("Ведите целое положительное число ");
//string numstr = Console.ReadLine();
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = (-num);
    while (count <= num)
    {
        Console.Write(count + " "); // ($"{count} ");
        count++;
    }
}
else
{
    Console.WriteLine("Вы вели отрицательное или не целое число.");
}
