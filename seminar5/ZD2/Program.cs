// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 10);// указываются границы массива
    }
    return mas;
}
int[] array = FillArray(8); // количество элементов в массиве
int Summa (int[] index)
{
    int sum = 0;
        for (int i = 1; i < array.Length; i=i+2) 
        {
            sum += array[i];
        }
        return sum;
}
Console.WriteLine(string.Join(",", (array)));
Console.WriteLine($"Сумма на нечетных позициях равна = {Summa(array)}");