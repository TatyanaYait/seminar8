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

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();

int mini = 0;
int minj = 0;
int min = array[0, 0];

for (int i = 0; i < array.GetLength(0); ++i)
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        if (array[i, j] < min)
        {
            mini = i;
            minj = j;
            min = array[i, j];
        }
    }
}
for (int i = 0; i < array.GetLength(0); ++i)
{
    if (i == mini)
        {
            continue;
        }
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        if (j == minj)
        {
            continue;
        }
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
