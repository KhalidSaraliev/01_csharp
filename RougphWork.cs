void OpenMatroshka(int size);
{
    if (size == 1)
    {
        Console.WriteLine("Smallest!");
        return;
    }
    OpenMatroshka(size - 1);
    Console.WriteLine($"Opening matroshka of size {size} ")
}

int SmallMatreshka = OpenMatroshka(5);
Console.WriteLine(SmallMatreshka);