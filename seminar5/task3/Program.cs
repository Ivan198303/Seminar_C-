// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    mas[i]= new Random().Next(-9,10);// указываются границы массива
                }
            return mas;
            }
int[] arr=FillArray(15);

string FindDigit(int[] array, int findNum){
    // int[] result = new int[array.Length];
    string result = "Нет";
    for (int i = 0; i < array.Length; i++){
        if (array[i] == findNum) 
            result = "Да";
    }
    return result;
}
Console.WriteLine(string.Join(",",(arr)));
Console.WriteLine(FindDigit(arr, 7));
