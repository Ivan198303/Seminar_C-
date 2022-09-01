// Проверить число на четность и выыести все четные числа
Console.Write("Введите целое число ");
try
    {
    int a = Convert.ToInt32(Console.ReadLine()); 
    int b =2;
         while (b<=a)
        {
           Console.Write(b+",");
           b=b+2;
        }
    }
catch
{
    Console.WriteLine("Надо вводить именно целое число");
}