// Перевернутый массив с печатью.
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-9,10);
                }
            return mas;
            }
            
void PrintArray(int[] mmm)
    {
           
    for (int i=0;i<mmm.Length;i++) 
        {
            if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
            else Console.WriteLine($"{mmm[i]}");
        }

    }
int [] Reserv1(int[]mmm)
{
        int[] revmas=new int[mmm.Length];
        for (int i=0; i<mmm.Length; i++) revmas[i]=mmm[mmm.Length-1-i];
        return revmas;
}

int[] array=FillArray(12);
PrintArray(array);
PrintArray(Reserv1(array));
Console.WriteLine();
Console.WriteLine(string.Join(" , ", array));
Console.WriteLine(string.Join(" , ", Reserv1(array)));