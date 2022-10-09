// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 - 12
// 45 - 9
int degreeNum(int a)
{
    if (a<10) return a;
    return a%10+degreeNum(a/10);
}
try
{
    System.Console.Write("Введите число A = ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел числа {A} = {degreeNum(A)}");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
