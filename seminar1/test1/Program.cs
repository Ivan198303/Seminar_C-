﻿// Нахождение квадрата введенного числа, с условием число положительное или отрицательное или равно "0".
Console.Write("Введите целое число ");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Квадрат этого числа равен" +x*x);
if (x>0)
{
Console.WriteLine("Число положительное");
}
else (x<0)
{
Console.WriteLine("Число отрицательное");
}
