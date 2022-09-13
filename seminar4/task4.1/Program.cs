// Программа которая заполняет и выводит массив из N элементов,N задается с клавиатуры,
// заполненный целыми числами от 1 до 99. Вывести максимальный элемент и его индекс.
int[] RndMassive(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
int[] maxIndex(int[] array)
{
    int[] arrayMax = new int[2];
    int max = 0;
    int indexMax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            indexMax = i;
        }
    }
    arrayMax[0] = indexMax;
    arrayMax[1] = max;
    return arrayMax;
}
try
{
    Console.WriteLine("Введите размер массива = ");
    int a = Convert.ToInt32(Console.ReadLine());
    int[] RNDarray = RndMassive(a);
    Console.WriteLine(string.Join(",", RNDarray));
    Console.WriteLine(string.Join(",", maxIndex(RNDarray)));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");

}

