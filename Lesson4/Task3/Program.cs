string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAscciLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.Readline();
string result = GetLettersFromString(str);
Console.WriteLine(result);