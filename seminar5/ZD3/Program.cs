// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] FillArray(int size)
{
    double[] mas = new double[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return mas;
}
double[] array = FillArray(4); // количество элементов в массиве
void PrintArray(double[] mmm)
{

    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.WriteLine($"{mmm[i]} ");
        else Console.WriteLine($"{mmm[i]}");
    }

}
double difference(double[] array)
{
    double max = 0;
    double min = 10;
    double resalt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        resalt = max - min;
    }
    return resalt;
}

PrintArray(array);
Console.WriteLine();
//Console.WriteLine(string.Join("/", (array)));
difference(array);
Console.WriteLine($"Разница между макс и мин равно = {Math.Round(difference(array), 2)}");

