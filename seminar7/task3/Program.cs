// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
int[,] FillMas1(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = i + j;
        }
    }
    return mas;
}

int[,] arr = FillMas1(6, 6);
PrintArray(arr);

int[,] FillMas2(int[,] arr)
{
    // int[,] mas = new int[n, m];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // mas[i, j] = i + j;
            if (i % 2 == 1 && j % 2 == 1) {
                arr[i, j] = arr[i, j] * arr[i, j];
            }
        }
    }
    return arr;
}
System.Console.WriteLine();
PrintArray(FillMas2(arr));


// int[,] FillMas(int n, int m)
// {
//     int[,] mas = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             mas[i, j] = new Random().Next(-10, 11);
//         }
//     }

//     return mas;
// }
// int[,] EvenNum(int[,]mas)
// {
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             if (i%2!=0 && j%2!=0)
//             mas[i,j]=(mas[i,j]*mas[i,j]);

//         }
//     }
//     return mas;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (j != arr.GetLength(1) - 1)
//                 Console.Write($"{arr[i, j]}, ");
//             else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
//                 Console.WriteLine($"{arr[i, j]}");
//             else if (j == arr.GetLength(1) - 1)
//                 Console.WriteLine($"{arr[i, j]},");
//         }
//     }
// }

// System.Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = FillMas(n, m);
// PrintArray(newArray);
// Console.WriteLine("Измененный массив");
// PrintArray(EvenNum(newArray));
