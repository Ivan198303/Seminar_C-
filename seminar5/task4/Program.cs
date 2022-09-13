// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, элементов. В своём решении сделайте для 15
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-100,100);
//                 }
//             return mas;
//             }
// int[] array = FillArray(15);
// Console.WriteLine(string.Join(",",(array)));
// int count=0;
//    for (int i=0; i<=array.Length;i++)
//    {
//     if (array[i]>=10&&array[i]<=99)
//     count++;
//    } 
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-100,100);
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

int[] arr = FillArray(15);

PrintArray(arr);
int count = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i]> 10 && arr[i] < 100)
    count++;
}
Console.WriteLine($"В массиве {count} элементов лежит в отрезке от 10 до 99");
