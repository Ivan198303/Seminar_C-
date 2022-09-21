// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -7, 567, 89, 223-> 3
int[] MassivNumber(int num) // Создаем массив и заполняем введеными числами
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int Amount(int[] num) // считаем кол-во чисел больше 0.
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}
try
{
    Console.Write("Введите необходимое количество чисел: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Количество введенных чисел больше 0 = {(string.Join(",", Amount(MassivNumber(a))))}");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}