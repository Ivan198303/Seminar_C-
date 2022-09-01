// Вывести последнюю цифру трехзначного числа
Console.Write("Введите целое трехзначное число ");
try
    {
    int n = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 переводит из строки в целое число
    int b = n % 10;
    Console.WriteLine("Последняя цифра числа " +b);
    }
catch
{
    Console.WriteLine("Надо вводить именно целое число");
}