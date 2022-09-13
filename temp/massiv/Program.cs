// Создаем массив и вывод массива
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-9,10);// указываются границы массива
                }
            return mas;
            }
        int[] array=FillArray(12);               // количество элементов в массиве
Console.WriteLine(string.Join(",",(array)));
// Создаем массив и кол-во элементов задаем с клавиатуры
int[] RndMassive(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
try
{
    Console.WriteLine("Введите размер массива = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(string.Join(",", RndMassive(a)));
}
catch
{
    Console.WriteLine("Надо вводить число а не текст");

}