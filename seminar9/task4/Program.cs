// Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
string Number(int a)
{
    if (a==0)return string.Empty;
    return Number(a-1)+" "+ Convert.ToString(a);
}
try
{
    System.Console.Write("Введите количество строк массива n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Number(n));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
