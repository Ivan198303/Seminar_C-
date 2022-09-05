// Напишите программу, которая принимает на вход целое число любой разрядности число 
//и удаляет вторую цифру слева направо этого числа.
void num(int x)
        {
            int b=x;
            int count=0;
            int x1=1;
            
            while (x>=10)
            {
                x=x/10;
                count++;
            }
            while (count>1)
            {
                x1=x1*10;
                count--;
            }
            int x2=b/x1;
            int x3=b%x1;
            int x4=x2/10;
            Console.WriteLine ($"Число без 2 цифры слева{x4}{x3}");
        }
try 
    {
    Console.Write ("Введите число ");    
    int x = Convert.ToInt32(Console.ReadLine());
    
    num(x);
    }
catch
{
    Console.WriteLine("Введите номер а не текст");
}