// Проверка на правильность ввода,
try
{
    Console.WriteLine("Введите целое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a);
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
    
}
