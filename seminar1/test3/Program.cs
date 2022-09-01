// Число в соотвествии дня
Console.Write ("Введите целое число от 1 до 7 ");
try
    {
    int a = Convert.ToInt32(Console.ReadLine());
    if(a==1)Console.WriteLine("Понедельник");
    else if (a==2) Console.WriteLine("Вторник");
    else if (a==3) Console.WriteLine("Среда");
    else if (a==4) Console.WriteLine("Четверг");
    else if (a==5) Console.WriteLine("Пятница");
    else if (a==6) Console.WriteLine("Субботу");
    else if (a==7) Console.WriteLine("Воскресенье");
    else Console.WriteLine("Введен не верный номер дня недели");
    }
catch
{
    Console.WriteLine("Введите номер а не текст");
}