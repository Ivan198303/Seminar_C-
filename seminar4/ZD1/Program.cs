// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double degree(int a, int b)
{   
    int resalt = 1;
    for (int i = 0; i < b; i++) resalt = resalt * a;
    return resalt;
}
try
{
    Console.WriteLine("Введите целое A ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое B ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b < 0) b = b * -1;

    int resalt1 = ((int)Math.Pow((Double)a, b));

    Console.WriteLine($"Число А в степени В через цикл = {degree(a, b)} ");
    Console.WriteLine($"Число А в степени В через Math.Pow = {resalt1} ");

}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}