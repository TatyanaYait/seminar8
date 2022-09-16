int[,] GetArray(int m, int n)
{
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

void PrintArray(int[,] arr)
{
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

int sum = 0;

int[] arraySum = new int[m];

for (int i = 0; i < m; ++i)
{
    sum = 0;
    for (int j = 0; j < n; ++j)
    {
        sum += array[i, j];
    }
    arraySum[i] = sum;
}
Console.WriteLine();
for (int i = 0; i < arraySum.GetLength(0); ++i)
{
    Console.WriteLine("  " + arraySum[i]);
}

int minSum = arraySum[0];
int minI = 0;
for (int i = 0; i < m; i++) //ищем минимальный элемент нового массива
{
    if (arraySum[i] < minSum)
    {
        minSum = arraySum[i];
        minI = i;
    }
}
Console.WriteLine();

Console.Write("Номер строки с минимальной суммой элементов: ");
Console.Write(minI + 1);
