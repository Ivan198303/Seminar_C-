// Нахождение максимального числа из двух
try 
    {
    Console.Write("Введите целое число a ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число b ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a>b) Console.Write("Первое число максимальное ="+a);
    else Console.Write("Второе число максимальное ="+b);
    }
catch
{
    Console.Write("Введите номер а не текст");
}