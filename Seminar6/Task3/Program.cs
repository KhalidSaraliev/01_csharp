int VowelsLetters(string str)
{
    string vowels = "aeyiou";
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}


Console.WriteLine("Введите строку строчными буквами");
string start = Console.ReadLine();

int result = VowelsLetters(start);
Console.WriteLine($"В слове {VowelsLetters(start)} гласных ");