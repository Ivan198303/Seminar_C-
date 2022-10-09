// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string Number(int a)
{
    if (a==0)return string.Empty;
    return Convert.ToString(a) +" "+ Number(a-1);
}
try
{
    System.Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Натуральные числа в промежутке от {n} до 1.  ( {Number(n)}) ");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
