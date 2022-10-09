// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNum(int a, int b)
{
    if (a>b)return 0;
    return a+SumNum(a+1,b);
}
try
{
    System.Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n<0|m<0|n>m)  Console.WriteLine("Числа должны быть положительными, и 2-число больше 1-первого.");
    else Console.WriteLine($"Сумма чисел между введенными значениями = {SumNum(n,m)}");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");


}
