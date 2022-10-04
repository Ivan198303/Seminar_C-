// // Задать двумерный массив. Программа которая меняет строки на столбцы.
// В случае, если это не возможно, программа выводит сообщение для пользователя.
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

// int[,] ExchangeRowCol(int[,] mas)
// {
//     int[,] newmas = new int[mas.GetLength(0),mas.GetLength(1)];
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//             newmas[i,j]=mas[j,i];
//        }
//     }
//     return newmas;
// }

int[,] ExchangeRowCol(int[,] mas)//второй вариант решения задачи
{
    if (mas.GetLength(dimension:0)!=mas.GetLength(dimension:1)) Console.WriteLine("Массив нельзя повернуть, дожно быть одиноковое кол-во строк и столбцов");
    else
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for(int j=i+1;j<mas.GetLength(dimension:1);j++)(mas[i,j],mas[j,i])=(mas[j,i],mas[i,j]);
        }
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
// if (n!=m)Console.Write("Массив нельзя повернуть");
// else PrintArray(ExchangeRowCol(newArray));
PrintArray(ExchangeRowCol(newArray));