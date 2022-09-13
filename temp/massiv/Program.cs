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
