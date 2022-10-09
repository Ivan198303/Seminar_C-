// Напишите программу вычисления функции Аккермана с помощьюрекурсии. Даны два неотрицательных числа m и n.
// m=2: n=3 - A(m,n)=9
// m=3, n=2, A(m,n)=29
//
int Akkerman(int a, int b)
{
    if (a==0) return b+1;
    if (b==0) return a-1;

}
try
{
    System.Console.Write("Введите число m = ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число n = ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n<=0&&m<=0)  Console.WriteLine("Введите положительные числа");
    else Console.WriteLine(Akkerman(m,n));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
}
