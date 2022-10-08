// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int K = 0; K < matr.GetLength(2); K++)
            {
                matr[i, j, K] = new Random().Next(10,100);
            }
        }
    }
}
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int K = 0; K < arr.GetLength(2); K++)
            {
                Console.Write($"{arr[i, j, K]} ({i},{j},{K})  ");
            }
             Console.WriteLine();
        }
    }
}

try
{
    System.Console.Write("Введите количество строк массива n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество слоев массива k = ");
    int k = Convert.ToInt32(Console.ReadLine());
    int[,,] matrix = new int[n, m, k];
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
