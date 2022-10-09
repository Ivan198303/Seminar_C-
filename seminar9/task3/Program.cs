//Напишите программу которая, на ввход принимает числа А и В,и взводит А в целую степень В с помощьюрекурсии.
int Pow(int a, int b)
{
    if (b==1) return a;
    return a*Pow (a,b-1);
}
try
{
    System.Console.Write("Введите число m = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число n = ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n<=0&&m<=0)  Console.WriteLine("Введите положительные числа");
    else Console.WriteLine(Pow(n,m));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
