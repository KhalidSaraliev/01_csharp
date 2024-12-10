// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’]


char[] CreateMas(string tex)
{
    char[] newMassiv = new char[tex.Length];

    for (int i = 0; i < tex.Length; i++)
    {
        newMassiv[i] = tex[i];
    }
    return newMassiv;
}

void PrintArray (char[] tex)
{
    Console.Write('[');
    for (int i = 0; i < tex.Length; i++)
    {
        if (i < tex.Length - 1)
        {
            Console.Write($"{tex[i]}, ");
        }
        else
        {
            Console.Write($"{tex[i]}");
        }
    }
    Console.WriteLine(']');
}

char[] arr = CreateMas("Hello");
PrintArray(arr);
