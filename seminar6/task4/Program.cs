// Выполнить поэлементное копирование
int[] Copy(int[] arr)
{
    int[] copypaste = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) copypaste[i] = arr[i];
    return copypaste;
}

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-9, 10);
    }
    return mas;
}

Console.WriteLine("Введите размерность массива");
int arg1 = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(arg1);
int[] array1= Copy(array);
Console.WriteLine(string.Join(",", (array)));
array[0]=99999;
Console.WriteLine(string.Join(",", (array1)));
Console.WriteLine("Скопированный массив array");
Console.WriteLine(string.Join(",", Copy(array)));


