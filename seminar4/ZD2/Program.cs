// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Summa(int a)
{
    int sum=0;
    while (a > 0)
    { 
        int b = a % 10;
        a = a / 10;
        sum = sum + b;
    }
    return sum;
}
try
{
    Console.WriteLine("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a<0) a=a*-1;
    Console.WriteLine($"Сумма цифр числа = {Summa(a)}");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
