// Написать программу, которая принимает 3 целых числа и проверить может ли существовать треугольник со сторонами данной длинны.
string Tridngular(int arg1, int arg2, int arg3)
{
    string res = " not a tringular";
    if (arg1 < arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg1 + arg2) res = " it can be a triangular";
    return res;
}
Console.WriteLine("enter three integers");
int arg1=Convert.ToInt32(Console.ReadLine());
int arg2=Convert.ToInt32(Console.ReadLine());
int arg3=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Tridngular(arg1, arg2, arg3));