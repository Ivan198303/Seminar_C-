// Напишите программу, которая принимает трехзначное число и на выходе показывает вторую цифру.
void num(int x)
{
int x1=x%100; // через остаток получаем две последние циыры
int x2=x1/10; // отсекаем крайнюю справа
Console.WriteLine($"Полученное число {x2}");
}
    try 
    {
        Console.Write("Введите трехзначное число ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x>=1000)Console.WriteLine("Введите число меньше 1000");
        else if (x<100)Console.Write("Введите число больше 100");
        else num(x);
    } 
  
    catch
    {
        Console.Write("Введите число а не текст");
    }
