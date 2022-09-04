// Решение по определению какое из введенных чисел является квадратом другого c помощью функции.
void num( int a, int b)
{
    if (a==b*b) Console.Write($" {a}  является квадратом {b} ");
    else if(b==a*a)Console.Write($" {b} является квадратом {a} ");
    else Console.Write("Числа не являются квадратом друг друга ");
}
try 
    {
    Console.Write("Введите первое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    int b = Convert.ToInt32(Console.ReadLine());
    num(a,b);
    }
catch
{
    Console.Write("Введите номер а не текст");
}