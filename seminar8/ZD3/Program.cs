// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
    return mas;
}

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
int[,] MasMulti(int[,] n, int[,] m)
{
    int[,] mas = new int [n.GetLength(0),m.GetLength(1)];
    for (int i = 0; i < n.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            for (int k = 0; k < n.GetLength(1); k++)
            {
                mas[i, j] += n[i, k]*m[k, j];
            }
        }
    }
    return mas;
}
try
{
    Console.WriteLine();
    System.Console.Write("Введите количество строк 1 массива n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов 1 массива m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество строк 2 массива k = ");
    int k = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов 2 массива l = ");
    int l = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = FillMas(n, m);
    int[,] newArray1 = FillMas(k, l);

    PrintArray(newArray);
    Console.WriteLine();
    PrintArray(newArray1);
    Console.WriteLine();
    if (m!=k) Console.WriteLine("Данные массивы нельзя перемножить");
    else PrintArray (MasMulti(newArray, newArray1));


}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
