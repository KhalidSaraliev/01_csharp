int[] array = new int[10] {-10,5,8,4,-9,-3,-8,3,2,10,};

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}