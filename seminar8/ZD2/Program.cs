// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 20);
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

int[] SummaLine(int[,] array)
{
    int[] k = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            k[i] += array[i, j];
        }
    }
    return k;
}
int NumberString(int[] a)
{
    int min =a[0];
    int Indmin = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < min)
        {
        min = a[i];
        Indmin = i;
        }
    }
    return Indmin;
}
try
{
    Console.WriteLine();
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);
    Console.WriteLine();
    Console.WriteLine(string.Join("    ", (SummaLine(newArray))));
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальным значением № {NumberString((SummaLine(newArray)))}");
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
