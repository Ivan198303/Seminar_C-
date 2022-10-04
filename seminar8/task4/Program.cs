// Создать двумерный массив с элементами от 0 до 9. Выыести информацию о том, сколько раз встречается элемент c входных данных.
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
    return mas;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

void PrintDicArray(int[,] arr)
{
    int[] newmas = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
            if (arr[i,j]==0) newmas[0]=newmas[0]+1;
            if (arr[i,j]==1) newmas[1]=newmas[0]+1;
            if (arr[i,j]==2) newmas[2]=newmas[2]+1;
            if (arr[i,j]==3) newmas[3]=newmas[3]+1;
            if (arr[i,j]==4) newmas[4]=newmas[4]+1;
            if (arr[i,j]==5) newmas[5]=newmas[5]+1;
            if (arr[i,j]==6) newmas[6]=newmas[6]+1;
            if (arr[i,j]==7) newmas[7]=newmas[7]+1;
            if (arr[i,j]==8) newmas[8]=newmas[8]+1;
            if (arr[i,j]==9) newmas[9]=newmas[9]+1;
            //newmas[arr[i,j]]+=1;
       }
    }
    for (int k=0;k<newmas.Length;k++)
    {
        if(newmas[k]!=0)Console.WriteLine($"{k} встречается {newmas[k]} раз");
    }
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] newArray = FillMas(n, m);
PrintArray(newArray);
Console.WriteLine();
PrintDicArray(newArray);