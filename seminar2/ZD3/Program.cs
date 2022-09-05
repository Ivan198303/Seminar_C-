// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
void day(int x)
{
if (x==6)Console.WriteLine("Сегодня выходной день суббота");
if (x==7)Console.WriteLine("Сегодня выходной день воскресенье");
else if (x<=5&x>=1)Console.WriteLine("Сегодня рабочий день");
}

try
    {
    Console.Write ("Введите число от 1 до 7 ");    
    int x = Convert.ToInt32(Console.ReadLine());
    if(x<=0)Console.WriteLine("Введен не верный номер дня недели");
    if(x>=8)Console.WriteLine("Введен не верный номер дня недели");
    else day(x);
    }
catch
{
    Console.WriteLine("Введите номер а не текст");
}