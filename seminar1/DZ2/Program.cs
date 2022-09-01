/// Нахождение максимального числа из трех
try 
    {
    Console.Write("Введите целое число a ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число b ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите целое число с ");
    int c = Convert.ToInt32(Console.ReadLine());
    if(a>b)
    {
    if(a>c)Console.Write("Первое число максимальное ="+a);
    }
    if(b>a)
    {
    if(b>c)Console.Write("Второе число максимальное ="+b);
    }
    if(c>a)
    {
    if(c>b)Console.Write("Третье число максимальное ="+c);
    }
    }
catch
{
    Console.Write("Введите число а не текст");
}