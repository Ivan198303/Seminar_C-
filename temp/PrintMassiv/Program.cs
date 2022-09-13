// Печать массива и вывод на экран
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
int[] array=FillArray(12);
PrintArray(array);


        