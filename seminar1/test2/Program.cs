// Решение по 
Console.Write("Введите целое число a ");
try 
    {
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число b ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a==b*b) Console.Write("Первое число является квадратом второго");
    else if(b==a*a)Console.Write("Второе число является квадратом первого");
    else Console.Write("Числа не являются квадратами друг друга");
    }
catch
{
    Console.Write("Введите номер а не текст");
}