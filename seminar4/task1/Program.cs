// Программа которая принимает на ыход число А и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int SummaFor(int N) // int N данную функцию можно задать любой аргумент, пример как в ответе (а)
    {
        int sum=0;
        for (int i=1; i<=N ;i++) sum+=i;
        return sum;
    }
try
{
    Console.WriteLine("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" Сумма всех натуральных чисел от 1 до {a} через цикл FOR равна {SummaFor(a)} ");
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
    
}