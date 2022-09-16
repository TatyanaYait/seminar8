int n = 4;
int value = 1;
int[,] newArraySpiral = new int[n, n];
Console.WriteLine("исходный массив размера 4*4 заполним нулями: ");
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(newArraySpiral);
for (int j = 0; j < newArraySpiral.GetLength(1); j++)
{
    newArraySpiral[0, j] = value;
    value++;
}
for (int i = 1; i < newArraySpiral.GetLength(0); i++)
{
    newArraySpiral[i, newArraySpiral.GetLength(0) - 1] = value;
    value++;
}
for (int j = 2; j >= 0; j--)
{
    newArraySpiral[newArraySpiral.GetLength(0) - 1, j] = value;
    value++;
}
for (int i = 2; i > 0; i--)
{
    newArraySpiral[i, 0] = value;
    value++;
}
for (int j = 2; j < newArraySpiral.GetLength(1) - 2; j++)
{
    newArraySpiral[newArraySpiral.GetLength(0) - 3, j] = value;
    value++;
}
for (int j = 1; j < newArraySpiral.GetLength(1) - 1; j++)
{
    newArraySpiral[newArraySpiral.GetLength(0) - 3, j] = value;
    value++;
}
for (int j = 2; j > 0; j--)
{
    newArraySpiral[newArraySpiral.GetLength(0) - 2, j] = value;
    value++;
}
Console.WriteLine();
Console.WriteLine("Заполненный массив:");
PrintArray(newArraySpiral);
Console.WriteLine();