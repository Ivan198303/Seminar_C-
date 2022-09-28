// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
int SearchNumber(int[,] arr, int x, int y)
{
    int num2=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j <arr.GetLength(1); j++)
        { 
            if (x==i&&y==j) num2=arr[x,y];
        }
    }
    return num2;
}
try
{
    Console.Write("Введите кол-во строк = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов = ");
    int m = Convert.ToInt32(Console.ReadLine());
    FillMas(n,m);
    int[,] arr1 = FillMas(n,m);
    PrintArray(arr1);
    Console.Write("Введите номер строки = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца = ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x>n-1&&y>m-1)Console.WriteLine("Запрашиваемого числа нет");
    else if (x<=n-1&&y<=m-1) Console.WriteLine($"Число по данному адресу = {SearchNumber(arr1,x,y)}"); 
} 
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
