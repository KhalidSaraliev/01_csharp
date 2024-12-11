// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

void ChekConsonants(string txt, int index)
{
    string vowels = "aeyuio";
    if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index]))
    {
        Console.Write($"{txt[index]} ");
    }
}

void PrintConsonants(string txt, int index = 0)
{
    if (index == txt.Length)
    {
        return;
    }
    ChekConsonants(txt, index);
    PrintConsonants(txt, index + 1);
}

Console.WriteLine("Введите строку содержащуюю латинские буквы");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text);