int[,,] GetArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            for (int l = 0; l < k; ++l)
            {
                array[i, j, l] = new Random().Next(10, 100);
                int mayak = CreateNewValue(i,j,l,array);
                while (mayak == 1) 
                {
                array[i, j, l] = new Random().Next(10, 100);
                mayak = CreateNewValue(i,j,l,array);
                }
            }
        }

    }
    return array;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            for (int l = 0; l < arr.GetLength(2); ++l)
            {
                Console.Write("  " + arr[i, j, l] + "(" + i + ", " + j + ", " + l + ")");   //  ($"{ arr[i,j,l]} ({i},{j},{l})")
            }
            Console.WriteLine();
        }
    }
}

int CreateNewValue(int znachenie1, int znachenie2, int znachenie3, int[,,] array)
{
    int mayak = 0;
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            for (int h = 0; h < array.GetLength(2); ++h)
            {
                if (i == znachenie1 && j == znachenie2 && h == znachenie3)
                {
                    continue;
                }
                if (array[znachenie1, znachenie2, znachenie3] == array[i, j, h])
                {
                    mayak = 1;
                    return mayak;
                }
            }

        }
    }
return mayak;
}
    Console.Write("Введите число строк массива: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите число высоты массива: ");
    int k = int.Parse(Console.ReadLine());

        // int m = 2;   // Размер массива по условию 2*2*2
        // int n = 2;
        // int k = 2;

    int[,,] array = GetArray(m, n, k);
    PrintArray(array);
    Console.WriteLine();