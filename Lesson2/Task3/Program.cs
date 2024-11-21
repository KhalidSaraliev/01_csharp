//int n = 10;
int[] arr = { 3, 5, 35, 1, 7, 9, 43, 16, 77, 89 };
int i = 0;

while( i < arr.Length)
{
    if(arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}