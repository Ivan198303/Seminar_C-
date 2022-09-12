// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
void HomeTask() 
{
Console.WriteLine("Семинар 3. ДЗ №2"); 
}
HomeTask(); 
double lengthBetween(int x1, int y1, int z1, int x2, int y2, int z2)
 {
    // (x1 - x2) ^2
    // (y1 - y2) ^2
    // (z1 - z2) ^2
    // 3 мерное 
     double xres = (x1 - x2) * (x1 - x2);
     double yres = (y1 - y2) * (y1 - y2);
     double zres = (z1 - z2) * (z1 - z2);
     double res = Math.Sqrt(xres + yres + zres);
     return res;
 }

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между точками = {lengthBetween(x1,y1,z1,x2,y2,z2)}");