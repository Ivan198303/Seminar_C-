// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
int factorial(int N)
    {
        int resalt=1;
        for (int i=1; i<=N; i++)resalt=resalt*i;
    return resalt;
    }
try
{
    Console.WriteLine("Введите целое число = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Произведение всех цифр до числа {a} = {factorial(a)}");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
    
}
