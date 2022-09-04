// Напишите программу, которая на выходе показывает третью цифру.
//и сообщает что 3 цифры нет.
void num(int x)
{
int x1=x%1000; // получаем третью цифру слева
int x2=x1/100;
Console.WriteLine($"Третья цифра справа {x2}");
}
    try 
    {
        Console.Write("Введите трехзначное число ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x<100&x>-100)Console.Write("Третьей цифры нет");
        else num(x); 
    } 
    catch
    {
        Console.Write("Введите число а не текст");
    }