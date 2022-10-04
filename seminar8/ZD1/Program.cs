// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int[,] SelectionSortMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {    
                if (array[i,k] < array[i, k+1]) 
                {
                    int temp=array[i, k+1];
                    array[i, k+1]=array[i,k];
                    array[i,k]=temp;
                }
            }    
        } 
       
    }
    return array;
}
try
{
    System.Console.Write("Введите количество строк n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = FillMas(n, m);
    PrintArray(newArray);
    Console.WriteLine();
    PrintArray(SelectionSortMax(newArray));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
