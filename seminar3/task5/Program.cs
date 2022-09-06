// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
//2 -> 1,4
double lengthBetween(int x1, int y1, int x2, int y2)
 {
    // (x1 - x2) ^2
    // (y1 - y2) ^ 2
    // N мерное 
     double xres = (x1 - x2) * (x1 - x2);
     double yres = (y1 - y2) * (y1 - y2);
     double res = Math.Sqrt(xres + yres);
     return res;
 }

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {lengthBetween(x1,y1,x2,y2)}");
