

//int n = 10;
int[] arr = { 1, 43, 5, 6, 2, 34, 54, 67, 8, 9 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}

max = arr[0];
for (int j = 0; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}

Console.WriteLine(max);