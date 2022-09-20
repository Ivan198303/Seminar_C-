// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
int[,] newArray1 = FillMas1(3, 4);
PrintArray(newArray1);

// int[,] Array(int n, int m)
// {
//     int[,] mas = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             mas[i, j] = i+j;        
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
//             if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
//             else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
//             else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
//         }
//     }
// }

// System.Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = Array(n, m);
// PrintArray(newArray);
