// Проверить число на четность
Console.Write("Введите целое число ");
try
    {
    int a = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 переводит из строки в целое число
        if (a%2==0)
        {
        Console.WriteLine("Число четное");
        } 
        else Console.WriteLine("Число нечетное ");
    }
catch
{
    Console.WriteLine("Надо вводить именно целое число");
}