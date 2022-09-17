// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(100,1000);// указываются границы массива
                }
            return mas;
            }
int[] array=FillArray(4);               // количество элементов в массиве
int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {   
        if (array[i] % 2 == 0)  // если число делится с остатком на 0, то оно четное
        sum += array[i];
        }
Console.WriteLine(string.Join(",",(array)));
Console.WriteLine(sum);