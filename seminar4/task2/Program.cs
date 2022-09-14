// Напишите программу которая принимает на вход число и выдает количество цифр в числе
// 356 -> 3
// 87 -> 2
// 89126 -> 5
int number(int N)
{
    int i = 0;
    while (N/((int)Math.Pow((Double)10,i))!=0)i++;// Число N делим на 10 в степени i, увеличивая i пока не упремся в не целое число.
    return i;
}   
 try 
{
    Console.WriteLine("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" Количество цифр в числе {a} равен {number(a)} ");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
    
}
// Решение через логарифм
// Console.WriteLine("Введите целое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// double fromLog = 0;
// fromLog=Math.Floor(Math.Log10(a)+1);
// Console.WriteLine($"Количество цифр в через логарифм равен {fromLog}");

