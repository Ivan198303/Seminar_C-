// See https://aka.ms/new-console-template for more information
string squareTable(int num)
{
    string result = $"{num} -> 1";

    for (int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i, 2)}";

    }

    return result;
}

try
{
    System.Console.Write("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(squareTable(num));


}
catch
{
    System.Console.WriteLine("Вводите целочисленное значение");
}

