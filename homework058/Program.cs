int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(0, 10);
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

Console.Write("Введите число строк первого массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов первого массива: ");
int n = int.Parse(Console.ReadLine());



Console.Write("Введите число строк второго массива: ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов второго массива: ");
int l = int.Parse(Console.ReadLine());


while (l != m || n != k)
{
    Console.WriteLine("Количество столбцов одной матрицы должно быть равно количеству строк другой!");
    Console.Write("Введите число строк первого массива: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов первого массива: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Введите число строк второго массива: ");
    k = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов второго массива: ");
    l = int.Parse(Console.ReadLine());
}
int[,] array1 = GetArray(m, n);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(k, l);
PrintArray(array2);
Console.WriteLine();

int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < array1.GetLength(0); ++i)
{
    for (int j = 0; j < array2.GetLength(1); ++j)
    {
        newArray[i, j] = 0;

        for (int h = 0; h < array1.GetLength(1); ++h)
        {
            newArray[i, j] += array1[i, h] * array2[h, j];
        }
    }
}
PrintArray(newArray);
Console.WriteLine();