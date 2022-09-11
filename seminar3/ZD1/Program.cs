// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void HomeTask() 
{
Console.WriteLine("Семинар 3. ДЗ №1"); 
}
HomeTask(); 
Console.WriteLine("Введите пятизначное число ");
string? a =(Console.ReadLine());            
void num(string a)
{
    if (a[0]==a[4]||a[1]==a[3]) Console.WriteLine($"Число: {a} - палиндром.");    
    else Console.WriteLine($"Число: {a} - не палиндром.");
}
        if (a.Length<5||a.Length>5)Console.WriteLine("Введи правильное число");
        else if (a.Length==5)num(a);