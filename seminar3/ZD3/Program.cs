// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void HomeTask() 
{
Console.WriteLine("Семинар 3. ДЗ №3"); 
}
HomeTask(); 
try
{
    Console.Write("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine()); 
    void cube(int a)
    {
        for(int b=1; b<a; b++)
        {
            Console.Write($"{b*b*b},");
        }
    } 
    cube(a);       
}
catch
{
    
    Console.WriteLine("Надо вводить именно целое число");
}