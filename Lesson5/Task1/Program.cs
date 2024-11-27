int Fact(int n)
{
    if (n == 1 || n == 0) 
    {

        Console.WriteLine($"stop reqursion:n = {n}");
        return 1;
    }
    Console.WriteLine (n);
    return n * Fact(n - 1);
}

Console.WriteLine(Fact(5));

//F11 - шаг с заходом
//F10 - гаг с обходом