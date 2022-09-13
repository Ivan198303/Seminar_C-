// Программа которая заполняет и выводит массив из N элементов,N задается с клавиатуры,
// заполненный целыми числами от 1 до 99.  
int [] RndMassive (int N)
{
    int [] array = new int [N];
    for (int i=0; i<N; i++)
        {
            array [i] = new Random().Next(1,100);
        }
    return array;
}
try
{
    Console.WriteLine("Введите размер массива = ");
    int a = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(string.Join(",",RndMassive (a)));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");
    
}
