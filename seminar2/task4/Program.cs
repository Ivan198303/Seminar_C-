// Программа принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.
void num(int a) 
    {
        if ((a%7==0)&(a%23==0))Console.WriteLine("Число кратно 7 и 23");// или можно такое условие if (a%7+a%23==0)
        else Console.WriteLine("Число не кратно 7 и 23");
    }    
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
num(a);