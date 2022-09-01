// Нахождение квадрата введенного числа, с условием число положительное или отрицательное или равно "0".
Console.Write("Введите целое число ");
try
    {
    int x = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 переводит из строки в целое число
    Console.WriteLine("Квадрат этого числа равен " + x * x);
    if(x>0) Console.WriteLine("Число положительное");
    else if (x<0)Console.WriteLine("Число отрицательное");
    else Console.WriteLine("Вы ввели ноль");
    }
catch
{
    Console.WriteLine("надо вводить именно целое число");
}