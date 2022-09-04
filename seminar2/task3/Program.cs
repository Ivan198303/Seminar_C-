// Программа которая принимает на вход 2 числа и выводить, 
// является ли второе число кратным первому?
// Если 2 не кратно числу 1, то программа выводит остаток от деления.

void num(int a, int b) 
    {
        
        if (a%b==0) Console.Write("Первое число кратно второму");
        else Console.Write($"Второе число не кратно первому {a%b}");
    }    
Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
  
num(a,b);