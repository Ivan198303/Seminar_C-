// Задайте значения М N, Напишите программу которая выведет все натуральные числа от M до N/
string Number(int a, int b)
{
    if (a==b-1)return string.Empty;
    return Convert.ToString(a+1)+" "+ Number(a+1,b);
}
try
{
    System.Console.Write("Введите число m = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число n = ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (m==n)  Console.WriteLine("Введенное число m должно быть больше n");
    else Console.WriteLine(Number(n,m));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
