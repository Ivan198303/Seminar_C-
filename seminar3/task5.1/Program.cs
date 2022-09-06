// See https://aka.ms/new-console-template for more information
double lengthBetween(int[] firstDot, int[] scndDot, int n)
{
    // (x1 - x2) ^2
    // (y1 - y2) ^ 2
    // N мерное 
    int sumDots = 0;
    for (int i = 0; i < n; i++ )
    {
        sumDots = sumDots + (firstDot[i] - scndDot[i]) * (firstDot[i] - scndDot[i]);
    }
    double res = Math.Sqrt(sumDots);
    return res;
}

Console.WriteLine("Введите размерность пространства");
int n = Convert.ToInt32(Console.ReadLine());
int[] firstDot = new int[n];
int[] scndDot = new int[n]; 
int i = 0;
Console.WriteLine("Введите координаты первой точки");
while (i < n)
{
    firstDot[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
i = 0;
Console.WriteLine("Введите координаты второй точки");
while (i < n)
{
    scndDot[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

Console.WriteLine($"Расстояние между точками = {lengthBetween(firstDot, scndDot, n)}");

