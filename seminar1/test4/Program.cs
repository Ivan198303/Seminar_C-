// От введенного числа N показываются все целые числа от -N до +N
Console.Write("Введите целое число ");
try
    {
    int n = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 переводит из строки в целое число
    int b = -n;
    Console.WriteLine("Диапазон от " +b);
    Console.WriteLine("Диапазон до " +n);
        while (b<=n)
        {
           Console.Write(b+",");
           b++;
        }
    }
catch
{
    Console.WriteLine("надо вводить именно целое число");
}