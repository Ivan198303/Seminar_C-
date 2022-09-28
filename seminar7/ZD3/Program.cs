// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();

    }
}
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(10);
        }
    }
    return mas;
}

double[] Average(int[,] arr)
{
    double[] k = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {         
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            k[j] += arr[i, j];
        }
    k[j]=Math.Round(k[j]/arr.GetLength(0),2);    
    }
    return k;
}
try
{
    Console.Write("Введите кол-во строк = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] arr2 = FillMas(n, m);
    PrintArray(arr2);
    Console.WriteLine($"Cреднее арифметическое столбцов ");
    Console.WriteLine(string.Join("    " , (Average(arr2))));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}



