// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] FillArrayTen(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 11);
    }
    return mas;
}
int[] pair(int[] mas)
{
    int L = Convert.ToInt32(Math.Round(Convert.ToDouble(mas.Length / 2)));

    int[] result = new int[L + 1];
    for (int i = 0; i < mas.Length / 2; i++)
    {

        result[i] = mas[i] * mas[mas.Length - 1 - i];

    }
    result[L - 1] = mas[L];
    return result;
}
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] inputTen = FillArrayTen(size);
System.Console.WriteLine(string.Join(",", inputTen));
System.Console.WriteLine(string.Join(",", pair(inputTen)));

