// Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

string whatCoord(int num)
{
    switch(num)
    {
        case 1:
        {
            return "x > 0, y > 0";
        }
        case 2:
        {
            return "x < 0, y > 0";
        }
        case 3:
        {
            return "x < 0, y < 0";
        }
        case 4:
        {
            return "x > 0, y < 0";
        }
        default:
        {
            return "Нет такой четверти!";
        }
    }
}
try {
Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(whatCoord(quarter));
}
catch
{
    Console.WriteLine("Нужно ввести целое число");
}
