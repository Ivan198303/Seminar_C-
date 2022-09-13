// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-9,10);
                }
            return mas;
            }
void Change(int[] a)
    {
      for (int i = 0; i < a.Length; ++i) a[i] = -a[i];
    }

    
int[] array = FillArray(8);
Console.WriteLine(string.Join(",",(array)));
Console.WriteLine(string.Join(",",(Change(array))));

//Console.WriteLine(string.Join(","(Change(array));


// int[] FillArray(int size)
// {
//     int[] mas = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         mas[i] = new Random().Next(-9, 10);
//     }
//     return mas;
// }

// int[] changeArray(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] *= -1;
//     }
//     return mas;
// }

// void PrintArray(int[] mmm)
// {

//     for (int i = 0; i < mmm.Length; i++)
//     {
//         if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
//         else Console.WriteLine($"{mmm[i]}");
//     }

// }

// try
// {
//     int[] array = FillArray(12);
//     PrintArray(array);
//     PrintArray(changeArray(array));
// }
// catch
// {
//     Console.WriteLine("Что-то пошло не так!");
// }
