//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]
int[] Massive(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива c индексом {i} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
try
{
    Console.Write("Введите размер массива = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(string.Join(",", Massive(a)));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}