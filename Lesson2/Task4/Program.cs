﻿int n = 5;
int[] arr = { 6, 9, 4, 1, 78 };
int i = 0;
int max = arr[0];
while(i < n)
{
    if(arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = arr[0];
for(int j = 0; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.WriteLine(max);

max = arr[0];
foreach(int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);