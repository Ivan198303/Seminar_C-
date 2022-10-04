// Задать двумерный массив. Поменять местами первую и послденюю строку.
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

int[,] ExchangeString(int[,] mas)
{
    int temp; // так можно произвести замену без использования временной переменной
    //int a=0;
    for (int i = 0; i < mas.GetLength(1); i++)
    {
        // a = mas[0, i];
        // mas[0, i] = mas[mas.GetLength(0)-1, i];
        // mas[mas.GetLength(0)-1, i] = a;
        (mas[0,i],mas[mas.GetLength(0)-1,i])=(mas[mas.GetLength(0)-1,i],mas[0,i]); // так можно произвести замену без использования временной переменной
    }
    return mas;
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] newArray = FillMas(n, m);
PrintArray(newArray);
Console.WriteLine();
PrintArray(ExchangeString(newArray));