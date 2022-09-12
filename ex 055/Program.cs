int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
if (m == n)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write("  " + array[j, i]);
        }

        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Операция не возможна! Значение m должно быть равно n");
}
